﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PRININ.Classes;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;

namespace PRININ
{
    public partial class ND_NC_OptionsPrint : DevExpress.XtraEditors.XtraForm
    {
        #region Developer Defined Variables

        DBOperations dp = new DBOperations();

        string LocalUserName;
        string LocalMachineName;

        Int32 recordID;
        string ND_NC = "";
        #endregion

        #region Developer Defined Methods

        private void load_company() 
        {
            try
            {
                cmb_company.Properties.DataSource = dp.PRININ_GetSelectData(@"SELECT [CCCONO] AS id
                                                                                    ,[CCTX15] AS name
                                                                                FROM [dbo].[CMNDIV]
                                                                                WHERE [CCDIVI] = '' ").Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar datos de la compañía.\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_division()
        {
            try
            {
                cmb_division.Properties.DataSource = dp.PRININ_GetSelectData(string.Format(@" SELECT [CCDIVI] AS id
                                                                                                    ,[CCCONM] AS name
                                                                                                    ,[CCTX15] AS name2
                                                                                                FROM [dbo].[CMNDIV]
                                                                                                WHERE [CCCONO] = {0}
                                                                                                AND [CCDIVI] <> '' ", cmb_company.EditValue)).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar datos de la división.\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_facility()
        {
            try
            {
                cmb_facility.Properties.DataSource = dp.PRININ_GetSelectData(string.Format(@" SELECT [CFFACI] AS id
                                                                                                    ,[CFFACN] AS name
                                                                                                FROM [dbo].[CFACIL]
                                                                                                WHERE [CFCONO] = {0}
                                                                                                AND [CFDIVI] = {1} ", cmb_company.EditValue, cmb_division.EditValue)).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar datos de la planta.\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_wharehouse()
        {
            try
            {
                cmb_wharehouse.Properties.DataSource = dp.PRININ_GetSelectData(string.Format(@"SELECT [OAADK2] AS id
                                                                                                     ,[OACONM] AS name
                                                                                                 FROM [dbo].[CIADDR]
                                                                                                WHERE [OACONO] = {0} ", cmb_company.EditValue)).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar datos del almacén.\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void load_regional_data()
        {
            try
            {
                cmb_cai.Properties.DataSource = dp.PRININ_GetSelectData(@"SELECT [id]
                                                                                ,[cai]
                                                                                ,[fecha_emision] AS emision
                                                                                ,[fecha_vence] AS vencimiento
                                                                                ,[kind] AS tipo
                                                                            FROM [dbo].[z_INVREGDAT]
                                                                            WHERE [estado] = 'a' and [kind]= '" + ND_NC +"'"
                                                                        ).Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar datos del almacén.\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool all_data_is_good() 
        {
            if (cmb_company.EditValue == null)
                return false;
            else if (cmb_division.EditValue == null)
                return false;
            else if (cmb_facility.EditValue == null)
                return false;
            else if (cmb_wharehouse.EditValue == null)
                return false;
            else if (cmb_cai.EditValue == null)
                return false;
            else if (txt_NumeroND_NC.Text.ToString() == "")
                return false;
            //else if (txt_PO.Text.ToString() == "")
            //    return false;
            else
                return true;
        }

        #endregion
        
        public ND_NC_OptionsPrint(string nc_nd)
        {
            InitializeComponent();
            this.ND_NC = nc_nd;
        }

        private void invoice_OptionsPrint_Load(object sender, EventArgs e)
        {
            try
            {
                LocalUserName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                LocalMachineName = System.Environment.MachineName;
                
                load_company();
                load_regional_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al cargar datos de la compañía.\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmb_company_EditValueChanged(object sender, EventArgs e)
        {
            load_division();
            load_wharehouse();
        }

        private void cmb_division_EditValueChanged(object sender, EventArgs e)
        {
            load_facility();
        }

        private void btn_cancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_Print_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (all_data_is_good())
                {
                    #region Procedure Parameters

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@ccicompania", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@ccidivision", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@cciplanta", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@ccialmacen", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@nndocumento", SqlDbType.VarChar));    //Numero de ND-NC
                    cmd.Parameters.Add(new SqlParameter("@regdataid", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@TextField", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@user", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@machine", SqlDbType.VarChar));

                    cmd.Parameters["@ccicompania"].Value = cmb_company.EditValue;
                    cmd.Parameters["@ccidivision"].Value = cmb_division.EditValue;
                    cmd.Parameters["@cciplanta"].Value = cmb_facility.EditValue;
                    cmd.Parameters["@ccialmacen"].Value = cmb_wharehouse.EditValue;
                    cmd.Parameters["@nndocumento"].Value = txt_NumeroND_NC.Text.ToString(); //Numero de ND-NC
                    cmd.Parameters["@regdataid"].Value = int.Parse(cmb_cai.EditValue.ToString());
                    cmd.Parameters["@TextField"].Value = txt_line1.Text.ToString();
                    cmd.Parameters["@user"].Value = LocalUserName;
                    cmd.Parameters["@machine"].Value = LocalMachineName;

                    /********************OUTPUT PARAMETER*********************************************************/
                    SqlParameter param = cmd.Parameters.Add(new SqlParameter("@InsertedID", SqlDbType.Int));
                    param.Direction = ParameterDirection.ReturnValue;
                    /*********************************************************************************************/

                    #endregion

                    #region Procedure Execution

                    recordID = Convert.ToInt32(dp.PRININ_Exec_SP_GetID("sp_customer_ND_NC_import_single", cmd, param));

                    //MessageBox.Show("Done! ID = " + recordID.ToString(), "All Good", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    #endregion

                    Generate_Report("view");
                }
                else 
                {
                    MessageBox.Show("A excepción de las Lineas, todos los datos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar los datos.\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Generate_Report("view");    // <-- TEMPORAL

        }


        private void Generate_Report(string action) {
	        #region Impresión..
	        try{
		        #region Obteniendo_Datos_A_Imprimir
                String query=
                @"SELECT  
                        A.EXJBNO ID
                        ,A.EXCONO company_id  ,D.[CCTX15] AS company_name
                        ,A.EXDIVI division_id ,E.[CCTX15] AS division_name
                        ,LEFT(A.Excuno,2) +'-'+ RIGHT(A.Excuno,4) customer_code
                        ,C.OKCUNM customer_long_name
                        ,C.OKALCU customer_short_name
                        ,C.OKVRNO customer_rtn
                        ,C.[OKCUA1] AS customer_address_l1
                        ,C.[OKCUA2] AS customer_address_l2
                        ,C.[OKCUA3] AS customer_address_l3
                        ,C.[OKCUA4] AS customer_country
                        ,C.[OKPHNO] AS customer_phone
                        ,A.EXCINO ND_NC_number
                        ,CONVERT(varchar(20),(cast(cast(A.EXACDT as varchar(10)) as date)),103) FECHA_EMISION_ND_NC
                        ,(CASE WHEN B.[EYCUAM]<0 THEN B.[EYCUAM]*-1 ELSE B.[EYCUAM] END) value
                        ,[dbo].[udf_Qty_to_Words_ES](CASE WHEN B.[EYCUAM]<0 THEN B.[EYCUAM]*-1 ELSE B.[EYCUAM] END) AS total_USD_words
                        ,A.EXCUCD currency_name
                        ,CASE A.EXFNCN WHEN '3' THEN 'N/C' WHEN '5' THEN 'N/D' END ND_NC, A.EXFNCN ND_NC_CODE
                        ,CASE A.EXFNCN WHEN '3' THEN 'NOTA DE CREDITO' WHEN '5' THEN 'NOTA DE DEBITO' END title
                        ,B.EYLTXT concept
                        ,F.*
                FROM    [DM3SK].[dbo].[fminhd] A   
                        LEFT JOIN [DM3SK].[dbo].[fmintl]  B ON A.EXCONO= EYCONO AND A.EXDIVI=EYDIVI AND A.EXCINO= EYCINO 
                        LEFT JOIN [DM3SK].[dbo].[ocusma]  C ON A.Excuno= C.OKCUNO                        
                        LEFT JOIN [dbo].[CMNDIV] D ON A.EXCONO= D.CCCONO AND D.[CCDIVI] = ''   
                        LEFT JOIN [dbo].[CMNDIV] E ON A.EXDIVI COLLATE Modern_Spanish_CI_AS = E.CCDIVI COLLATE Modern_Spanish_CI_AS  
                        LEFT JOIN [dbo].[z_INVREGDAT] F ON F.estado= 'a' and F.kind= (CASE A.EXFNCN WHEN '3' THEN 'NC' WHEN '5' THEN 'ND' END)         
                WHERE 
                        A.EXFNCN IN(3,5)            
                        and A.EXCINO= '" + txt_NumeroND_NC.Text.ToString() + "'";  
			    //    );
                Console.Out.WriteLine("Query: " + query);
                DataSet datos = dp.PRININ_GetSelectData(query);
                datos.Tables[0].TableName = "ND_NC";
		        #endregion

		        #region Imprimiendo
		        RPTS.RPT_ND_NC report = new RPTS.RPT_ND_NC() { DataSource = datos, DataMember = "Data_Schema_Name", ShowPrintMarginsWarning = false };
		        report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
		        ReportPrintTool printReport = new ReportPrintTool(report);
		        if (action== "view") printReport.ShowPreview();
		        else printReport.Print();
		        #endregion

	        }
	        catch (Exception) { throw; }
	        #endregion
        }

        private void cmbTripoDoc_EditValueChanged(object sender, EventArgs e)
        {
            if (cmbTripoDoc.SelectedIndex == 0) ND_NC = "ND";
            else if (cmbTripoDoc.SelectedIndex == 1) ND_NC = "NC";
            else ND_NC = "";

            load_regional_data();
        }

        private void btn_ManageCAI_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

    }
}