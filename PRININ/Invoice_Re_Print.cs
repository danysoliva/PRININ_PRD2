using System;
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
    public partial class Invoice_Re_Print : DevExpress.XtraEditors.XtraForm
    {
        DBOperations dp = new DBOperations();

        int selectedID;

        private void print_invoice(string type, string language) 
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(WaitForm2));
                #region Read Invoice Data & Execute Report

                if (language == "ES")
                {
                    #region Query

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
                                    WHERE A11.[id] = "+ selectedID + @") as subtotal
                                ,[dbo].[udf_Qty_to_Words_ES](B.[UHIVAM]) AS invoice_total_USD_words
                                ,B.[UHIVLA] AS invoice_total_HNL
	                            ,[dbo].[udf_Qty_to_Words_ES](B.[UHIVLA])+ ' Lempiras' AS invoice_total_HNL_words
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
                            ,(SELECT sum(Coalesce(B1.ONCVT1, 0)) as impuesto
                            FROM [dbo].[z_INVDATA] a1
                            INNER JOIN [dbo].[OINVOL] B1
	                            ON a1.[cono] = B1.[ONCONO]
	                        AND A1.[divi] = B1.[ONDIVI]
	                        AND A1.[whlo] = B1.[ONWHLO]
	                        AND A1.[inv_num] = B1.[ONEXIN]
	                        AND B1.[ONIVTP] = 31
                            WHERE A1.[id] = " + selectedID + @") as impuesto
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
                            WHERE A.[id] = " + selectedID + @";

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
                            WHERE A.[id] = " + selectedID + @";

                        /***************************************************************************************/
                        /***************************************************************************************/");
                    #endregion

                    datos.Tables[0].TableName = "header";
                    datos.Tables[1].TableName = "detail";
                    int RowsTotal = datos.Tables[1].Rows.Count;
                    int MaxRows = 10 - RowsTotal;
                    if (MaxRows > 0)
                    {
                        DataRow row;
                        for (int i = 0; i < MaxRows; i++)
                        {
                            row = datos.Tables[1].NewRow();
                            row["invoice_id"] = DBNull.Value;
                            row["company_id"] = DBNull.Value;
                            row["division_id"] = DBNull.Value;
                            row["facility_id"] = DBNull.Value;
                            row["wharehouse_id"] = DBNull.Value;
                            row["invoice_number"] = DBNull.Value;
                            row["line_item_number"] = DBNull.Value;
                            row["line_item_name_shor"] = DBNull.Value;
                            row["line_item_name_long"] = DBNull.Value;
                            row["line_item_qty_kg"] = DBNull.Value;
                            row["line_item_qty_saco"] = DBNull.Value;
                            row["line_item_qty_tm"] = DBNull.Value;
                            row["line_item_price_unit"] = DBNull.Value;
                            row["line_unit_sale"] = DBNull.Value;
                            row["line_unit_price"] = DBNull.Value;
                            row["line_total_USD"] = DBNull.Value;
                            row["line_total_HNL"] = DBNull.Value;
                            datos.Tables[1].Rows.Add(row);
                        }
                    }

                    //RPTS.RPT_Factura_bk report = new RPTS.RPT_Factura_bk() { DataSource = datos, DataMember = "detail", ShowPrintMarginsWarning = false };
                    RPTS.RPT_Factura report = new RPTS.RPT_Factura(datos) { DataSource = datos, DataMember = "detail", ShowPrintMarginsWarning = false };
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport = new ReportPrintTool(report);

                    if (type == "dialog")
                        printReport.ShowPreview();
                    else
                        printReport.Print();
                }
                else 
                {
                    #region Query

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
	                            ,[dbo].[udf_Qty_to_Words_EN](B.[UHIVAM]) AS invoice_total_USD_words
                                ,B.[UHIVLA] AS invoice_total_HNL
	                            ,[dbo].[udf_Qty_to_Words_EN](B.[UHIVLA])+ ' Lempiras' AS invoice_total_HNL_words
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
                            WHERE A.[id] = " + selectedID + @";
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
                            WHERE A.[id] = " + selectedID + @";

                        /***************************************************************************************/
                        /***************************************************************************************/");
                            
                    #endregion

                    datos.Tables[0].TableName = "header";
                    datos.Tables[1].TableName = "detail";
                    int RowsTotal = datos.Tables[1].Rows.Count;
                    int MaxRows = 10 - RowsTotal;
                    if (MaxRows > 0)
                    {
                        DataRow row;
                        for (int i = 0; i < MaxRows; i++)
                        {
                            row = datos.Tables[1].NewRow();
                            row["invoice_id"] = DBNull.Value;
                            row["company_id"] = DBNull.Value;
                            row["division_id"] = DBNull.Value;
                            row["facility_id"] = DBNull.Value;
                            row["wharehouse_id"] = DBNull.Value;
                            row["invoice_number"] = DBNull.Value;
                            row["line_item_number"] = DBNull.Value;
                            row["line_item_name_shor"] = DBNull.Value;
                            row["line_item_name_long"] = DBNull.Value;
                            row["line_item_qty_kg"] = DBNull.Value;
                            row["line_item_qty_saco"] = DBNull.Value;
                            row["line_item_qty_tm"] = DBNull.Value;
                            row["line_item_price_unit"] = DBNull.Value;
                            row["line_unit_sale"] = DBNull.Value;
                            row["line_unit_price"] = DBNull.Value;
                            row["line_total_USD"] = DBNull.Value;
                            row["line_total_HNL"] = DBNull.Value;
                            datos.Tables[1].Rows.Add(row);
                        }
                    }

                    RPTS.RPT_Factura_EN report = new RPTS.RPT_Factura_EN() { DataSource = datos, DataMember = "detail", ShowPrintMarginsWarning = false };
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport = new ReportPrintTool(report);

                    if (type == "dialog")
                        printReport.ShowPreview();
                    else
                        printReport.Print();
                }
                #endregion
                SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al leer los datos.\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SplashScreenManager.CloseForm();
            }
        }

        private void print_invoice_reapeted_products(string type, string language)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(WaitForm2));
                #region Read Invoice Data & Execute Report

                if (language == "ES")
                {
                    #region Query

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
                            WHERE A.[id] = " + selectedID + @";
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
								,B.[ONIVRF]
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
                            WHERE A.[id] = " + selectedID + @";

                        /***************************************************************************************/
                        /***************************************************************************************/");
                    #endregion

                    datos.Tables[0].TableName = "header";
                    datos.Tables[1].TableName = "detail";

                    RPTS.RPT_Factura report = new RPTS.RPT_Factura(datos) { DataSource = datos, DataMember = "detail", ShowPrintMarginsWarning = false };
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport = new ReportPrintTool(report);

                    if (type == "dialog")
                        printReport.ShowPreview();
                    else
                        printReport.Print();
                }
                else
                {
                    #region Query

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
	                            ,[dbo].[udf_Qty_to_Words_EN](B.[UHIVAM]) AS invoice_total_USD_words
                                ,B.[UHIVLA] AS invoice_total_HNL
	                            ,[dbo].[udf_Qty_to_Words_EN](B.[UHIVLA]) AS invoice_total_HNL_words
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
                                ,(SELECT sum(Coalesce(B.ONCVT1, 0)) as impuesto
                            FROM [dbo].[z_INVDATA] a1
                            INNER JOIN [dbo].[OINVOL] B1
	                            ON a1.[cono] = B1.[ONCONO]
	                        AND A1.[divi] = B1.[ONDIVI]
	                        AND A1.[whlo] = B1.[ONWHLO]
	                        AND A1.[inv_num] = B1.[ONEXIN]
	                        AND B1.[ONIVTP] = 31
                            WHERE A1.[id] = " + selectedID + @") as impuesto

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
                            WHERE A.[id] = " + selectedID + @";
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
								,B.[ONIVRF]
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
                            WHERE A.[id] = " + selectedID + @";

                        /***************************************************************************************/
                        /***************************************************************************************/");
                    #endregion

                    datos.Tables[0].TableName = "header";
                    datos.Tables[1].TableName = "detail";

                    RPTS.RPT_Factura_EN report = new RPTS.RPT_Factura_EN() { DataSource = datos, DataMember = "detail", ShowPrintMarginsWarning = false };
                    report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                    ReportPrintTool printReport = new ReportPrintTool(report);

                    if (type == "dialog")
                        printReport.ShowPreview();
                    else
                        printReport.Print();
                }
                #endregion
                SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error al leer los datos.\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                SplashScreenManager.CloseForm();
            }
        }

        public Invoice_Re_Print()
        {
            InitializeComponent();
        }

        private void Invoice_Re_Print_Load(object sender, EventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(WaitForm1));
                grd_data.DataSource = dp.PRININ_Exec_SP_Get_Data("lcl_get_imported_invoices", new System.Data.SqlClient.SqlCommand());
                SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                MessageBox.Show(string.Format("Error al leer los datos.\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnc_export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void grdv_data_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu.ShowPopup(Cursor.Position);
            }
        }

        private void grdv_data_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                selectedID = int.Parse(grdv_data.GetRowCellValue(e.FocusedRowHandle, "id").ToString());
            }
            catch { }
        }

        private void btnc_PrintDialog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btnc_directPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void btn_exit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btn_Dialogo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            print_invoice("dialog", "ES");
        }

        private void btn_Directa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            print_invoice("direct", "ES");
        }

        private void btn_Export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Excel File (.xlsx)|*.xlsx";
            dialog.FilterIndex = 0;

            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                grd_data.ExportToXlsx(dialog.FileName);
            }
        }

        private void btnc_Dialog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Dialogo_ItemClick(sender, e);
        }

        private void btnc_Direct_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Directa_ItemClick(sender, e);
        }

        private void btnc_ExportExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_Export_ItemClick(sender, e);
        }

        private void btn_ChangeNotes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Update_Invoice_CM form = new Update_Invoice_CM(selectedID);
            form.ShowDialog();
        }

        private void btnc_ChangeNotes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            btn_ChangeNotes_ItemClick(sender, e);
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                SplashScreenManager.ShowForm(typeof(WaitForm2));
                grd_data.DataSource = dp.PRININ_Exec_SP_Get_Data("lcl_get_imported_invoices", new System.Data.SqlClient.SqlCommand());
                SplashScreenManager.CloseForm();
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm();
                MessageBox.Show(string.Format("Error al leer los datos.\n\nDetalle: {0}", ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnc_DialogPR_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            print_invoice_reapeted_products("dialog", "ES");
        }

        private void btnc_DirectRP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            print_invoice_reapeted_products("direct", "ES");
        }

        private void btn_PrinDialogRP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            print_invoice_reapeted_products("dialog", "ES");
        }

        private void btnc_DirectPrintRP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            print_invoice_reapeted_products("direct", "ES");
        }

        private void btn_EN_NML_PrintDialog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            print_invoice("dialog", "EN");
        }

        private void btn_EN_NML_DirectPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            print_invoice("direct", "EN");
        }

        private void btn_EN_PR_PrintDialog_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            print_invoice_reapeted_products("dialog", "EN");
        }

        private void btn_EN_PR_DirectPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            print_invoice_reapeted_products("direct", "EN");
        }
    }
}