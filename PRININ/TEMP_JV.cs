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
using DevExpress.XtraReports.UI;


namespace PRININ
{
    public partial class TEMP_JV : DevExpress.XtraEditors.XtraForm
    {
        DBOperations dp = new DBOperations();

        public TEMP_JV()
        {
            InitializeComponent();
        }

        private void btnImprimirFactura_Click(object sender, EventArgs e)
        {
            #region Imprimir_Factura
            try
                    {
                        DataSet datos = dp.PRININ_GetSelectData(
                            @"
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
   ,[dbo].[udf_Qty_to_Words_ES](B.[UHIVLA]) AS invoice_total_HNL_words
      ,B.[UHCUCD] AS invoice_currency
      ,B.[UHRAIN] AS invoice_exchange_rate
   ,B.[UHIDAT] AS invoice_date
   ,B.[UHDUDT] AS invoice_due_date
   ,(CASE A.[contado] WHEN 1 THEN 'Contado' ELSE 'Crédito' END) AS invoice_payment_terms
   ,J.[UATEPY] AS invoice_credit_terms_code
      ,K.[CTTX15] AS invoice_credit_terms_name
      ,RTRIM(LTRIM(SUBSTRING(K.[CTPARM],35,36))) AS invoice_credit_terms_days
      ,I.[OKALCU] AS customer_short_name
      ,I.[OKCUNM] AS customer_long_name
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
 WHERE A.[id] =" + txtNumero.Text.ToString() + @" ; 


SELECT A.[id] AS invoice_id
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
  INNER JOIN [dbo].[MITMAS] D
  ON C.[UBCONO] = D.[MMCONO]
 AND C.[UBITNO] = D.[MMITNO]
  WHERE A.[id] = " + txtNumero.Text.ToString() + @";

                            "

                            );
                        datos.Tables[0].TableName = "header";
                        datos.Tables[1].TableName = "detail";

                        RPTS.RPT_Factura report = new RPTS.RPT_Factura(datos) { DataSource = datos, DataMember = "Factura_Schema", ShowPrintMarginsWarning = false };
                        report.PrintingSystem.Document.AutoFitToPagesWidth = 1;
                        ReportPrintTool printReport = new ReportPrintTool(report);
                        printReport.ShowPreview();
                    }
                    catch (Exception) { throw; }
                    #endregion

        }
    }
}