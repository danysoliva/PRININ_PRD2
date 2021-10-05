using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using POS_Gasolinera_v1._0;

namespace PRININ.RPTS
{
    public partial class RPT_ND : DevExpress.XtraReports.UI.XtraReport
    {
        public RPT_ND(string cai, 
                               string docnum, 
                               DateTime pFecha, 
                               string Titulo,
                               decimal pNum,
                               string CCode, 
                               string CNombre, 
                               string CRTN, 
                               string pConcepto, 
                               string leyenda,
                               DateTime FechaL,
                               string inicial,
                               string final
                              ,bool enable
                              ,decimal pTasa, string caicomp, string caicorre, string otrasfac, DateTime pfechaVence, string obs)
        {
            InitializeComponent();
            lblCAI.Text = cai;
            txtObservaciones_.Text = obs;
            lblNumeroDoc.Text = docnum;
            lblFecha.Text = string.Format("{0:MM/dd/yyyy}", pFecha);
            lblFechaVence.Text = string.Format("{0:MM/dd/yyyy}", pfechaVence);
            lblTituloDocumento.Text = Titulo;
            lblMonto.Text = string.Format("{0:###,##0.00}", pNum);
            lblValorLempiras.Text = string.Format("{0:###,##0.00}", (pNum* pTasa));
            lblTasaCambio.Text = string.Format("{0:###,##0.0000}", pTasa);
            lblCodigoCliente.Text = CCode;
            lblNombreCLiente.Text = CNombre;
            lblRTN.Text = CRTN;
            txtConcepto.Text = pConcepto;
            lblLeyenda.Text = leyenda;
            ConversorNumALetrasDolares conver = new ConversorNumALetrasDolares(pNum);
            ConversorNumALetras ConverHNL = new ConversorNumALetras((pNum * pTasa));
            //lblValorLetras.Text = conver.NumeroEnLetras;
            lblValorLetras.Text = ConverHNL.NumeroEnLetras;
            lblFechaLimite.Text = string.Format("{0:MM/dd/yyyy}", FechaL);
            lblNumeroInicial.Text = inicial;
            lblNumeroFinal.Text = final;
            lblCaiComp.Text = caicomp;
            lblCorrelativo.Text = caicorre;
            lblOtras.Text = otrasfac;
            if (!enable)
                lblAnulada.Visible = true;

        }



    }
}
