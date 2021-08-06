using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using PRININ.Classes;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Grid;
using PRININ.Compras;
using DevExpress.XtraEditors.Repository;

namespace PRININ.Pedidos
{
    public partial class frmPedidosNew : DevExpress.XtraEditors.XtraForm
    {
        int idp;
        string cod_cliente;
        public frmPedidosNew()
        {
            InitializeComponent();
            //LoadData();
            LoadMonedas();
            //LoadSucursales();
        }
        decimal _ProTotal;

        public decimal ProTotal { get => _ProTotal; set => _ProTotal = value; }

        private void LoadMonedas()
        {
            try
            {
                string sql = @"SELECT [id]
                                     ,[descripcion]
                               FROM [dbo].[conf_monedas]";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsCompras.monedas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCompras.monedas);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdBuscarClientes_Click(object sender, EventArgs e)
        {
            LookClientes();

            if (cod_cliente == null)
            {
                return;
            }

            Looksucursal();
        }

        private void LookClientes()
        {
            frmBuscarClientesP frm = new frmBuscarClientesP();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //idp = Convert.ToInt32(frm.Pro_id);
                cod_cliente = txtNumCliente.Text = frm.Pro_codigo;
                txtCliente.Text = frm.Pro_cliente;
                //txtDireccionCliente.Text = frm.Pro_direccion + ", "+ frm.Pro_direccion2+ ", "+ frm.Pro_direccion3+ ", "+ frm.Pro_direccion4;
                txtDireccionCliente.Text = frm.Pro_direccion;
                txtDireccionCliente2.Text = frm.Pro_direccion2;
                txtDireccionCliente3.Text = frm.Pro_direccion4;
                txtDireccionCliente4.Text = frm.Pro_direccion3;
            }
            txtDireccionEntrega.Clear();
        }

        private void Looksucursal()
        {
            string sql = @"SELECT  ROW_NUMBER() Over (order by OPCUNO) as numero 
                                   ,OPCUNO as codigo_cliente
		                           ,OPCUNM +', '+ OPCUA1 +', '+  OPCUA2 + ', '+ OPCUA3 +', '+  OPCUA4 as direccion
		                FROM dbo.OCUSAD
						where OPCUNO = '" + cod_cliente.ToString() + "'";

            //string sql = @"SELECT OPCUNO as codigo_cliente
            //          ,OPCUNM as direccion
            //          ,OPCUA1 as direecion2
            //          ,OPCUA2 as direccion3
            //          ,OPCUA3 as direccion4
            //          ,OPCUA4 as direccion5
            //      FROM dbo.OCUSAD
            //      where OPCUNO = '" + cod_cliente.ToString()+"'";
            try
            {
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                dsPedidos.clienteSucursal.Clear();
                adat.Fill(dsPedidos.clienteSucursal);
                conn.Close();
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdAddProd_Click(object sender, EventArgs e)
        {
            frmAddProd addProd = new frmAddProd();
            if (addProd.ShowDialog() == DialogResult.OK)
            {
                foreach (DataRow row in addProd.dt.Rows)
                {
                    string query = @"SELECT ROW_NUMBER() 
                                             Over (order by MMITNO) as id
		                                    ,MMITNO as numero_articulo
		                                    ,MMFUDS  as descripcion
		                                    ,CURRENT_TIMESTAMP as fecha_carga
		                                    ,0 as cantidad
		                                    ,0 as importe
                                            ,0 as total_dolares   
		                                    FROM MITMAS
                                              WHERE MMITNO = '" + row["numero_articulo"] + "'";

                    try
                    {
                        DBOperations dp = new DBOperations();
                        SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                        conn.Open();
                        SqlCommand cmd = new SqlCommand(query, conn);
                        SqlDataAdapter adat = new SqlDataAdapter(cmd);
                        //dsPedidos.detallePedido.Clear();
                        adat.Fill(dsPedidos.detallePedido);
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        CajaDialogo.Error(ex.Message);
                    }
                }
            }

           
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = CajaDialogo.Pregunta("Desea salir sin guardar");
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void repositoryItemDel_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var gridView1 = (GridView)gridPedidos.FocusedView;
            var row = (dsPedidos.detallePedidoRow)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            catch (Exception ex)
            {
                CajaDialogo.Error(ex.Message);
            }
        }

        private void cmdSave_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
            {
                CajaDialogo.Error("Es necesario agregar los items al pedido");
                return;
            }

            //Validar encabezado
            if (!ValidarNullText(txtNumCliente.Text, "Numero de Cliente"))
                return;

            if (!ValidarNullText(txtCliente.Text, "Nombre del Cliente"))
                return;

            if (!ValidarNullText(txtDireccionEntrega.Text, "Direccion de Entrega"))
                return;
            if (!ValidarNullText(datePedido.Text, "Fecha de Pedido"))
                return;
            if (!ValidarNullText(dateFecha.Text, "Fecha"))
                return;
            if (!ValidarNullText(dateEntrega.Text, "Fecha de Entrega"))
                return;
            //if (!ValidarNullText(txtMEntrega.Text, "Metodo de Entrega"))
            //    return;
            if (!ValidarNullText(txtSuNumOrden.Text, "Numero de orden de compra"))
                return;
            if (!ValidarNullText(txtEntrega.Text, "Cond de Entrega"))
                return;
            //if (!ValidarNullText(txtNumOrden.Text, "Numero de Orden"))
            //    return;
            if (!ValidarNullText(txtReferencia.Text, "Ntra ref"))
                return;
            if (!ValidarNullText(gridLookUpMoneda.Text, "Moneda"))
                return;
            if (!ValidarNullText(txtTotal.Text, "Total Weight"))
                return;

            //validar detalle
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                if (row[2] != null)
                {
                    //Numero de Articulo
                    if (string.IsNullOrEmpty(row[2].ToString()))
                    {
                        CajaDialogo.Error("No se permiten grabar descripciones en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permiten grabar descripciones en blanco!");
                    return;
                }

                if (row[3] != null)
                {
                    //Descripcion
                    if (string.IsNullOrEmpty(row[3].ToString()))
                    {
                        CajaDialogo.Error("No se permiten grabar descripciones en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permiten grabar descripciones en blanco!");
                    return;
                }

                if (row[4] != null)
                {
                    //Fecha Carga
                    if (string.IsNullOrEmpty(row[4].ToString()))
                    {
                        CajaDialogo.Error("No se permiten grabar descripciones en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permiten grabar descripciones en blanco!");
                    return;
                }

                if (row[5] != null)
                {
                    //cantidad
                    if (string.IsNullOrEmpty(row[5].ToString()))
                    {
                        CajaDialogo.Error("No se permiten grabar descripciones en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permiten grabar descripciones en blanco!");
                    return;
                }

                if (row[6] != null)
                {
                    //precio unitario
                    if (string.IsNullOrEmpty(row[6].ToString()))
                    {
                        CajaDialogo.Error("No se permiten grabar descripciones en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permiten grabar descripciones en blanco!");
                    return;
                }

                if (row[7] != null)
                {
                    //importe
                    if (string.IsNullOrEmpty(row[7].ToString()))
                    {
                        CajaDialogo.Error("No se permiten grabar descripciones en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permiten grabar descripciones en blanco!");
                    return;
                }
            }

            //Guardar confirmacion de pedido
            DBOperations dp = new DBOperations();
            using (SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                SqlTransaction trans;

                trans = conn.BeginTransaction("SampleTransaction");

                cmd.Connection = conn;
                cmd.Transaction = trans;

                try
                {

                    //Generar el numero
                    cmd.CommandText = @"SELECT coalesce([siguiente],1) as sig
                                            FROM[dbo].[conf_tables_id]
                                            where id = 7";
                    string NumeroP = cmd.ExecuteScalar().ToString();
                    while (NumeroP.Length < 5)
                    {
                        NumeroP = "0" + NumeroP;
                    }

                    //Generar el numero de pedido (correlativo interno de PRININ)
                    cmd.CommandText = @"INSERT INTO [dbo].[CONFIRMACION_PEDIDO]
                                                   ([cod_cliente]
                                                   ,[cliente]
                                                   ,[cliente_direccion]
                                                   ,[direccion_entrega]
                                                   ,[fecha_pedido]
                                                   ,[fecha_entrega]
                                                   ,[fecha_2]
                                                   ,[contacto]
                                                   ,[Sunumero_orden]
                                                   ,[cond_entrega]
                                                   ,[metood_entrega]
                                                   ,[moneda]
                                                   ,[numero_orden]
                                                   ,[ntra_ref]
                                                   ,[numero_pedido]
                                                   ,[enable]        
                                                   ,[cliente_direccion2]
                                                   ,[cliente_direccion3]
                                                   ,[cliente_direccion4]
                                                   ,[total_peso])
                                             VALUES
                                                   (@cod_cliente
                                                   ,@cliente
                                                   ,@cliente_direccion
                                                   ,@direccion_entrega
                                                   ,@fecha_pedido
                                                   ,@fecha_entrega
                                                   ,@fecha_2
                                                   ,@contacto
                                                   ,@Sunumero_orden
                                                   ,@cond_entrega
                                                   ,@metood_entrega
                                                   ,@moneda
                                                   ,@numero_orden
                                                   ,@ntra_ref
                                                   ,@numero_pedido
                                                   ,@enable
                                                   ,@cliente_direccion2
                                                   ,@cliente_direccion3
                                                   ,@cliente_direccion4
                                                   ,@total_peso); SELECT SCOPE_IDENTITY()";
                    if(string.IsNullOrEmpty(txtNumCliente.Text))
                        cmd.Parameters.Add("cod_cliente", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("cod_cliente", SqlDbType.VarChar).Value = txtNumCliente.Text;

                    if (string.IsNullOrEmpty(txtCliente.Text))
                        cmd.Parameters.Add("cliente", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("cliente", SqlDbType.VarChar).Value = txtCliente.Text;

                    if (string.IsNullOrEmpty(txtDireccionCliente.Text))
                        cmd.Parameters.Add("cliente_direccion", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("cliente_direccion", SqlDbType.VarChar).Value = txtDireccionCliente.Text;

                    if (string.IsNullOrEmpty(txtDireccionEntrega.Text))
                        cmd.Parameters.Add("direccion_entrega", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("direccion_entrega", SqlDbType.VarChar).Value = txtDireccionEntrega.Text;

                    if (string.IsNullOrEmpty(datePedido.Text))
                        cmd.Parameters.Add("fecha_pedido", SqlDbType.Date).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("fecha_pedido", SqlDbType.Date).Value = datePedido.EditValue;

                    if (string.IsNullOrEmpty(dateEntrega.Text))
                        cmd.Parameters.Add("fecha_entrega", SqlDbType.Date).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("fecha_entrega", SqlDbType.Date).Value = dateEntrega.EditValue;

                    if (string.IsNullOrEmpty(dateFecha.Text))
                        cmd.Parameters.Add("fecha_2", SqlDbType.Date).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("fecha_2", SqlDbType.Date).Value = dateFecha.EditValue;

                    if (string.IsNullOrEmpty(txtContacto.Text))
                        cmd.Parameters.Add("contacto", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("contacto", SqlDbType.VarChar).Value = txtContacto.Text;

                    if (string.IsNullOrEmpty(txtSuNumOrden.Text))
                        cmd.Parameters.Add("Sunumero_orden", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("Sunumero_orden", SqlDbType.VarChar).Value = txtSuNumOrden.Text;

                    if (string.IsNullOrEmpty(txtEntrega.Text))
                        cmd.Parameters.Add("cond_entrega", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("cond_entrega", SqlDbType.VarChar).Value = txtEntrega.Text;

                    if (string.IsNullOrEmpty(txtMEntrega.Text))
                        cmd.Parameters.Add("metood_entrega", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("metood_entrega", SqlDbType.VarChar).Value = txtMEntrega.Text;

                    if (string.IsNullOrEmpty(gridLookUpMoneda.Text))
                        cmd.Parameters.Add("moneda", SqlDbType.Int).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("moneda", SqlDbType.Int).Value = gridLookUpMoneda.EditValue;

                    if (string.IsNullOrEmpty(txtNumOrden.Text))
                        cmd.Parameters.Add("numero_orden", SqlDbType.Int).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("numero_orden", SqlDbType.Int).Value = txtNumOrden.Text;

                    if (string.IsNullOrEmpty(txtReferencia.Text))
                        cmd.Parameters.Add("ntra_ref", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("ntra_ref", SqlDbType.VarChar).Value = txtReferencia.Text;
                        
                    //parametro correlativo interno Prinin
                        cmd.Parameters.Add("numero_pedido", SqlDbType.Int).Value = NumeroP;

                    if (string.IsNullOrEmpty(txtDireccionCliente2.Text))
                        cmd.Parameters.Add("cliente_direccion2", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("cliente_direccion2", SqlDbType.VarChar).Value = txtDireccionCliente2.Text;

                    if (string.IsNullOrEmpty(txtDireccionCliente3.Text))
                        cmd.Parameters.Add("cliente_direccion3", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("cliente_direccion3", SqlDbType.VarChar).Value = txtDireccionCliente3.Text;

                    if (string.IsNullOrEmpty(txtDireccionCliente4.Text))
                        cmd.Parameters.Add("cliente_direccion4", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("cliente_direccion4", SqlDbType.VarChar).Value = txtDireccionCliente4.Text;
                    if (string.IsNullOrEmpty(txtTotal.Text))
                        cmd.Parameters.Add("total_peso", SqlDbType.Decimal).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("total_peso", SqlDbType.Decimal).Value = txtTotal.Text;

                    cmd.Parameters.Add("enable", SqlDbType.Bit).Value = 0;

                    //Obtener el parametro para enlazar el encabezado al detalle
                    int id_pedido = Convert.ToInt32(cmd.ExecuteScalar());

                    //Limpiamos los parametros

                    cmd.Parameters.Clear();

                    //Vamos a Guardar el detalle
                    for (int i = 0; i < gridView1.DataRowCount; i++)
                    {
                        cmd.Parameters.Clear();
                        DataRow row = gridView1.GetDataRow(i);
                        cmd.CommandText = @"INSERT INTO [dbo].[CONFIRMACION_PEDIDO_D]
                                                               ([id_pedido]
                                                               ,[numero_articulo]
                                                               ,[descripcion]
                                                               ,[fecha_carga]
                                                               ,[cantidad]
                                                               ,[importe])
                                                         VALUES
                                                               (@id_pedido
                                                               ,@numero_articulo
                                                               ,@descripcion
                                                               ,@fecha_carga
                                                               ,@cantidad
                                                               ,@importe)";
                        cmd.Parameters.Add("id_pedido", SqlDbType.Int).Value = id_pedido;
                        cmd.Parameters.Add("numero_articulo", SqlDbType.VarChar).Value = row["numero_articulo"];
                        cmd.Parameters.Add("descripcion", SqlDbType.VarChar).Value = row["descripcion"];
                        cmd.Parameters.Add("fecha_carga", SqlDbType.DateTime).Value = row["fecha_carga"];
                        cmd.Parameters.Add("cantidad", SqlDbType.Decimal).Value = row["cantidad"];
                        cmd.Parameters.Add("importe", SqlDbType.Decimal).Value = row["importe"];

                        cmd.ExecuteNonQuery();
                    }
                    //Update numero de pedido para las tablas id
                    cmd.Parameters.Clear();

                    cmd.CommandText = @"Update[dbo].[conf_tables_id]
                                                set[siguiente] = ([siguiente] + 1)
                                            where id = 7";
                    cmd.ExecuteNonQuery();

                    //Concluir la transaccion
                    trans.Commit();
                    CajaDialogo.Information("Confirmacion de Pedido Creada!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    try
                    {
                        trans.Rollback();
                        CajaDialogo.Error(ex.Message);
                    }
                    catch (Exception ex2)
                    {
                        CajaDialogo.Error(ex2.Message);
                    }
                }
            }
        }

        private bool ValidarNullText(string text, string objeto)
        {
            bool a = false;
            if (!string.IsNullOrEmpty(text))
                a = true;
            else
                CajaDialogo.Error("No puede dejar en blanco la casilla: " + objeto);

            return a;
        }

        private void CalcularTotal()
        {
            ProTotal = 0;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                decimal val = 0;
                try
                {
                    val = Convert.ToDecimal(row["importe"]);
                }
                catch { }
                ProTotal += val;
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch (e.Column.Name)
            {

                case "colcantidad":
                case "colimporte":
                    DataRow row = gridView1.GetDataRow(e.RowHandle);
                    decimal cant, importe;

                    try
                    {
                        cant = Convert.ToDecimal(row["cantidad"]);
                        importe = Convert.ToDecimal(row["importe"]);
                    }
                    catch { cant = importe = 0;}
                    decimal total = cant * importe;
                    row["importe"] = total;
                    CalcularTotal();
                
                    break;
            }
        }

        private void gridLookUpSucursales_EditValueChanged(object sender, EventArgs e)
        {
            //Selecciona la descripcion
            int idSucursal = Convert.ToInt32(gridLookUpSucursales.EditValue);
            foreach (dsPedidos.clienteSucursalRow row in dsPedidos.clienteSucursal)
            {
                if (row["numero"].ToString() == idSucursal.ToString())
                {
                    txtDireccionEntrega.Text = row.direccion;
                }

            }
        }

        private void gridLookUpSucursales_QueryPopUp(object sender, CancelEventArgs e)
        {
            GridLookUpEdit editor = (GridLookUpEdit)sender;
            RepositoryItemGridLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(700, properties.PopupFormSize.Height);
        }
    }
}