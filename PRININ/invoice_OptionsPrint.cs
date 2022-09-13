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
using DevExpress.XtraSplashScreen;

namespace PRININ
{
    public partial class invoice_OptionsPrint : DevExpress.XtraEditors.XtraForm
    {
        #region Developer Defined Variables
        
        DBOperations dp = new DBOperations();

        string LocalUserName;
        string LocalMachineName;

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
                                                                            WHERE [estado] = 'a' AND [kind] = 'FA'").Tables[0];
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
            else if (txt_InvoiceNumber.Text.ToString() == "")
                return false;
            else if (txt_PO.Text.ToString() == "")
                return false;
            else
                return true;
        }

        #endregion
        public invoice_OptionsPrint()
        {
            InitializeComponent();
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
                    SplashScreenManager.ShowForm(typeof(WaitForm1));

                    #region Procedure Parameters

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandTimeout = 600000;
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@ccicompania", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@ccidivision", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@cciplanta", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@ccialmacen", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@nnufactura", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@regdataid", SqlDbType.Int));
                    cmd.Parameters.Add(new SqlParameter("@line1", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@line2", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@line3", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@line4", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@line5", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@line6", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@user", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@machine", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@customerPO", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@contado", SqlDbType.Bit));
                    cmd.Parameters.Add(new SqlParameter("@registro_exonerado", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@id_sag", SqlDbType.VarChar));
                    cmd.Parameters.Add(new SqlParameter("@oc_exenta", SqlDbType.VarChar));
                    //cmd.Parameters.Add(new SqlParameter("@consignado", SqlDbType.VarChar));
                    //cmd.Parameters.Add(new SqlParameter("@dir_consignado", SqlDbType.VarChar));
                    //cmd.Parameters.Add(new SqlParameter("@rtn_consignado", SqlDbType.VarChar));
                    //cmd.Parameters.Add(new SqlParameter("@vendido", SqlDbType.VarChar));
                    //cmd.Parameters.Add(new SqlParameter("@dir_vendido", SqlDbType.VarChar));
                    //cmd.Parameters.Add(new SqlParameter("@rtn_vendido", SqlDbType.VarChar));

                    cmd.Parameters["@ccicompania"].Value = cmb_company.EditValue;
                    cmd.Parameters["@ccidivision"].Value = cmb_division.EditValue;
                    cmd.Parameters["@cciplanta"].Value = cmb_facility.EditValue;
                    cmd.Parameters["@ccialmacen"].Value = cmb_wharehouse.EditValue;
                    cmd.Parameters["@nnufactura"].Value = txt_InvoiceNumber.Text.ToString();
                    cmd.Parameters["@regdataid"].Value = int.Parse(cmb_cai.EditValue.ToString());
                    cmd.Parameters["@line1"].Value = txt_line1.Text.ToString();
                    cmd.Parameters["@line2"].Value = txt_line2.Text.ToString();
                    cmd.Parameters["@line3"].Value = txt_line3.Text.ToString();
                    cmd.Parameters["@line4"].Value = txt_line4.Text.ToString();
                    cmd.Parameters["@line5"].Value = txt_line5.Text.ToString();
                    cmd.Parameters["@line6"].Value = txt_line6.Text.ToString();

                    if (string.IsNullOrEmpty(txtRegistroExonerado.Text))
                        cmd.Parameters["@registro_exonerado"].Value = DBNull.Value;
                    else
                        cmd.Parameters["@registro_exonerado"].Value = txtRegistroExonerado.Text;

                    if (string.IsNullOrEmpty(txtID_SAG.Text))
                        cmd.Parameters["@id_sag"].Value = DBNull.Value;
                    else
                        cmd.Parameters["@id_sag"].Value = txtID_SAG.Text;

                    if (string.IsNullOrEmpty(txtNumeroOC_Exenta.Text))
                        cmd.Parameters["@oc_exenta"].Value = DBNull.Value;
                    else
                        cmd.Parameters["@oc_exenta"].Value = txtNumeroOC_Exenta.Text;

                    cmd.Parameters["@user"].Value = LocalUserName;
                    cmd.Parameters["@machine"].Value = LocalMachineName;
                    cmd.Parameters["@customerPO"].Value = txt_PO.Text.ToString();
                    cmd.Parameters["@contado"].Value = chk_contado.EditValue;
                   
                    //cmd.Parameters["@consignado"].Value = txtConsignadoA.Text;
                    //cmd.Parameters["@dir_consignado"].Value = txtDirConsignado.Text;
                    //cmd.Parameters["@rtn_consignado"].Value = txtRTNConsignado.Text;
                    //cmd.Parameters["@vendido"].Value = txtVendidoA.Text;
                    //cmd.Parameters["@dir_vendido"].Value = txtDirVendido.Text;
                    //cmd.Parameters["@rtn_vendido"].Value = txtRTN_Vendido.Text;

                    /********************OUTPUT PARAMETER*********************************************************/
                    SqlParameter param = cmd.Parameters.Add(new SqlParameter("@InsertedID", SqlDbType.Int));
                    param.Direction = ParameterDirection.ReturnValue;
                    /*********************************************************************************************/

                    #endregion

                    #region Procedure Execution

                    Int32 recordID = Convert.ToInt32(dp.PRININ_Exec_SP_GetID("sp_invoice_import_single_v5", cmd, param));

                    #endregion

                    if (recordID > 0)
                    {
                        #region Read Invoice Data & Execute Report

                        DataSet datos = dp.PRININ_GetSelectData(
                            @"
                        /***************************************************************************************/
                        /**************************************HEADER*******************************************/
                        /***************************************************************************************/
                        SELECT A.[id]
                                ,A.[cono] AS company_id
	                            ,C.[CCTX15] AS company_name
                                ,A.[divi] AS division_id
	                            ,D.[CCTX15] AS division_name
                                ,A.[faci] AS facility_id
	                            ,E.[CFFACN] AS facility_name
                                ,A.[whlo] AS wharehouse_id
	                            ,F.[OACONM] AS wharehouse_name
                                ,A.[inv_num] AS invoice_number_m3
	                            ,(CASE LEN(CAST(B.[UHIVNO] AS varchar(10))) 
		                        WHEN 1 THEN CONCAT('0000000',CAST(B.[UHIVNO] AS varchar))
		                        WHEN 2 THEN CONCAT('000000',CAST(B.[UHIVNO] AS varchar))
		                        WHEN 3 THEN CONCAT('00000',CAST(B.[UHIVNO] AS varchar))
		                        WHEN 4 THEN CONCAT('0000',CAST(B.[UHIVNO] AS varchar))
		                        WHEN 5 THEN CONCAT('000',CAST(B.[UHIVNO] AS varchar))
		                        WHEN 6 THEN CONCAT('00',CAST(B.[UHIVNO] AS varchar))
		                        WHEN 7 THEN CONCAT('0',CAST(B.[UHIVNO] AS varchar))
		                        ELSE CAST(B.[UHIVNO] AS varchar) END) AS invoice_number_dei
                                ,A.[reg_data_id] AS invoice_reg_id
	                            ,H.[cai] AS invoice_cai
	                            ,H.[fecha_emision] AS invoice_fecha_emision
	                            ,H.[fecha_vence] AS invoice_fecha_vence
	                            ,H.[num_ini] AS invoice_num_ini
	                            ,H.[num_fin] AS invoice_num_fin
	                            ,B.[UHIVAM] AS invoice_total_USD
	                            ,-- [dbo].[udf_Qty_to_Words_ES](B.[UHIVAM]) AS invoice_total_USD_words
                                
                               (SELECT sum(Coalesce(B11.ONIVAM, 0)) 
                            FROM [dbo].[z_INVDATA] A11
                                    INNER JOIN [dbo].[OINVOL] B11
	                                    ON A11.[cono] = B11.[ONCONO]
	                                AND A11.[divi] = B11.[ONDIVI]
	                                AND A11.[whlo] = B11.[ONWHLO]
	                                AND A11.[inv_num] = B11.[ONEXIN]
	                                AND B11.[ONIVTP] = 31
                                    WHERE A11.[id] = " + recordID + @") as subtotal

                                ,[dbo].[udf_Qty_to_Words_ES](B.[UHIVAM]) AS invoice_total_USD_words
                                ,B.[UHIVLA] AS invoice_total_HNL
	                            ,[dbo].[udf_Qty_to_Words_ES](B.[UHIVLA]) + ' Lempiras' AS invoice_total_HNL_words
                                ,B.[UHCUCD] AS invoice_currency
                                ,B.[UHRAIN] AS invoice_exchange_rate
	                            ,B.[UHIDAT] AS invoice_date
	                            ,B.[UHDUDT] AS invoice_due_date
	                            ,(CASE A.[contado] WHEN 1 THEN 'Contado' ELSE 'Crédito' END) AS invoice_payment_terms
	                            ,J.[UATEPY] AS invoice_credit_terms_code
                                ,K.[CTTX15] AS invoice_credit_terms_name
                                ,CONCAT(CONVERT(int, RTRIM(LTRIM(SUBSTRING(K.[CTPARM],77,3)))), ' dias') AS invoice_credit_terms_days
                                ,I.[OKALCU] AS customer_short_name
                                ,CONCAT(I.[OKCUNM], ' ', I.[OKYREF]) AS customer_long_name
                                ,I.[OKTOWN] as town
                                ,I.[OKPONO] as pono
                                ,I.[OKCUA1] AS customer_address_l1
                                ,I.[OKCUA2] AS customer_address_l2
                                ,I.[OKCUA3] AS customer_address_l3
                                ,I.[OKCUA4] AS customer_country
                                ,I.[OKPHNO] AS customer_phone
	                            ,A.[cust_po_number] AS customer_po_number
	                            ,I.[OKTEDL] AS customer_delivery_terms
	                            ,I.[OKVRNO] AS customer_RTN
                                ,A.[line1] AS invoice_cust_line1
                                ,A.[line2] AS invoice_cust_line2
                                ,A.[line3] AS invoice_cust_line3
                                ,A.[line4] AS invoice_cust_line4
                                ,A.[line5] AS invoice_cust_line5
                                ,A.[line6] AS invoice_cust_line6
                                ,A.registro_exonerado
                                ,A.id_sag
                                ,A.oc_exenta

                            , (SELECT sum(Coalesce(B1.ONCVT1, 0)) as impuesto
                            FROM [dbo].[z_INVDATA] a1
                            INNER JOIN [dbo].[OINVOL] B1
	                            ON a1.[cono] = B1.[ONCONO]
	                            AND A1.[divi] = B1.[ONDIVI]
	                            AND A1.[whlo] = B1.[ONWHLO]
	                            AND A1.[inv_num] = B1.[ONEXIN]
	                            AND B1.[ONIVTP] = 31
                                WHERE A1.[id] = " + recordID + @") as impuesto
                                
                                
                            FROM [dbo].[z_INVDATA] A
                            INNER JOIN [dbo].[OINVOH] B /*Invoice Header*/
                            ON A.[cono] = B.[UHCONO]
                            AND A.[divi] = B.[UHDIVI]
                            AND A.[faci] = B.[UHFACI]
                            AND A.[inv_num] = B.[UHEXIN]
                            INNER JOIN [dbo].[CMNDIV] C
	                        ON B.[UHCONO] = C.[CCCONO]
                            AND C.[CCDIVI] = ''
                            INNER JOIN [dbo].[CMNDIV] D
	                        ON B.[UHCONO] = D.[CCCONO]
                            AND B.[UHDIVI] = D.[CCDIVI]
                            INNER JOIN [dbo].[CFACIL] E
	                        ON B.[UHCONO] = E.[CFCONO]
                            AND B.[UHDIVI] = E.[CFDIVI]
                            AND B.[UHFACI] = E.[CFFACI]
                            INNER JOIN [dbo].[CIADDR] F
	                        ON A.[cono] = F.[OACONO]
                            AND A.[whlo] = F.[OAADK2]
                            INNER JOIN [dbo].[z_INVREGDAT] H
	                        ON A.[reg_data_id] = H.[id]
                            INNER JOIN [dbo].[OCUSMA] I
	                        ON B.[UHCONO] = I.[OKCONO]
                            AND B.[UHPYNO] = I.[OKCUNO]
                            INNER JOIN [dbo].[ODHEAD] J
	                        ON B.[UHCONO] = J.[UACONO]
                            AND B.[UHDIVI] = J.[UADIVI]
                            AND B.[UHFACI] = J.[UAFACI]
                            AND A.[whlo] = J.[UAWHLO]
                            AND B.[UHEXIN] = J.[UAEXIN]
                            INNER JOIN [dbo].[CSYTAB] K
	                        ON J.[UACONO] = K.[CTCONO]
                            AND K.[CTSTCO] = 'TEPY'
                            AND J.[UATEPY] = K.[CTSTKY]
                            AND K.[CTLNCD] = 'ES'
                            WHERE A.[id] = " + recordID + @";
                        /***************************************************************************************/
                        /***************************************************************************************/



                        /***************************************************************************************/
                        /**************************************DETAIL*******************************************/
                        /***************************************************************************************/

                        SELECT DISTINCT
                                 A.[id] AS invoice_id
	                            ,A.[cono] AS company_id
	                            ,A.[divi] AS division_id
	                            ,A.[faci] AS facility_id
	                            ,A.[whlo] AS wharehouse_id
	                            ,A.[inv_num] AS invoice_number
	                            ,C.[UBITNO] AS line_item_number
	                            ,D.[MMITDS] AS line_item_name_shor
	                            ,D.[MMFUDS] AS line_item_name_long
	                            ,C.[UBIVQT] AS line_item_qty_kg
	                            ,C.[UBIVQA] AS line_item_qty_saco
	                            ,C.[UBIVQS] AS line_item_qty_tm
	                            ,C.[UBSAPR] AS line_item_price_unit
	                            ,C.[UBALUN] AS line_unit_sale
	                            ,C.[UBSPUN] AS line_unit_price
	                            ,B.[ONIVAM] AS line_total_USD
	                            ,B.[ONIVLA] AS line_total_HNL
                            FROM [dbo].[z_INVDATA] A
                            INNER JOIN [dbo].[OINVOL] B
	                            ON A.[cono] = B.[ONCONO]
	                        AND A.[divi] = B.[ONDIVI]
	                        AND A.[whlo] = B.[ONWHLO]
	                        AND A.[inv_num] = B.[ONEXIN]
	                        AND B.[ONIVTP] = 31
                            INNER JOIN [dbo].[ODLINE] C
	                            ON A.[cono] = C.[UBCONO]
	                        AND A.[divi] = C.[UBDIVI]
	                        AND A.[faci] = C.[UBFACI]
	                        AND A.[whlo] = C.[UBWHLO]
	                        AND B.[ONDLIX] = C.[UBDLIX]
	                        AND B.[ONIVAM] = C.[UBLNAM]
                            INNER JOIN [dbo].[MITMAS] D
	                            ON C.[UBCONO] = D.[MMCONO]
	                        AND C.[UBITNO] = D.[MMITNO]
                            WHERE A.[id] = " + recordID + @";

                        /***************************************************************************************/
                        /***************************************************************************************/
                        ");

                        datos.Tables[0].TableName = "header";
                        datos.Tables[1].TableName = "detail";
                        RPTS.RPT_Factura report = new RPTS.RPT_Factura(datos) { DataSource = datos, DataMember = "detail", ShowPrintMarginsWarning = false };
                        //RPTS.RPT_Factura_bk report = new RPTS.RPT_Factura_bk() { DataSource = datos, DataMember = "detail", ShowPrintMarginsWarning = false };
                        report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                        ReportPrintTool printReport = new ReportPrintTool(report);
                        printReport.ShowPreview();

                        this.DialogResult = System.Windows.Forms.DialogResult.OK;
                        this.Close();

                        #endregion

                    }
                    else 
                    {
                        if(recordID == -1)
                            MessageBox.Show("Aparentemente la factura indicada no existe, por favor verifique y vuelva a intentar.", "Proceso no Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else if (recordID == -2)
                            MessageBox.Show("Esta factura ya ha sido importada e impresa. Debes utilizar el metodo de re-impresión del sistema.", "Proceso no Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show("Algo salio mal, por favor contacta al departamento de sistemas.", "Proceso no Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    SplashScreenManager.CloseForm();
                }
                else 
                {
                    MessageBox.Show("A excepción de las Lineas, todos los datos son requeridos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al guardar los datos.\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SplashScreenManager.CloseForm();
            }
        }

        private void chimpuesto_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}