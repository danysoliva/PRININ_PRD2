using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using PRININ.Classes;
using System.Data;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;

namespace PRININ.Compras
{
    public partial class frmOrdenCompraNormal : DevExpress.XtraEditors.XtraForm
    {
        public enum TipoEdicion
        {
            insert = 1,
            update = 2
        }

        TipoEdicion tipoEdicion;
        decimal _ProTotal;

        decimal _ProImpuesto;

        public decimal ProTotal { get => _ProTotal; set => _ProTotal = value; }
        public decimal ProImpuesto { get => _ProImpuesto; set => _ProImpuesto = value; }

        public frmOrdenCompraNormal(TipoEdicion ptipoEdicion)
        {
            InitializeComponent();
            tipoEdicion = ptipoEdicion;
            LoadMonedas();

            if (tipoEdicion == TipoEdicion.update)
            {

            }
        }

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

        private void cmdAbrirBusqueda_Click(object sender, EventArgs e)
        {
            searchProveedores();
        }

        private void searchProveedores()
        {
            frmBuscarProveedor frmB = new frmBuscarProveedor();
            if (frmB.ShowDialog() == DialogResult.OK)
            {
                txtCodigoProveedor.Text = frmB.Pro_codigo;
                txtProveedor.Text = frmB.Pro_nombre;
                txtRTN.Text = frmB.Pro_rtn;
            }
        }

        private void cmdSincronizarProveedores_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Realmente desea actualizar los Proveedores? esto tomara algunos minutos...", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
            {
                return;
            }

            try
            {
                string sql = @"EXEC [dbo].[get_proveedores]";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sincronizacion Exitosa!");
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            dsCompras.oc_d_normalRow row1 = dsCompras.oc_d_normal.Newoc_d_normalRow();
            dsCompras.oc_d_normal.Addoc_d_normalRow(row1);
            dsCompras.AcceptChanges();

            row1.Impuesto = 0;
        }

        private void repositoryItemButtonEliminar_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar row del grid
            DialogResult r = MessageBox.Show("¿Desea Eliminar ésta linea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
            {
                return;
            }

            var gridView1 = (GridView)gridMain.FocusedView;
            var row = (dsCompras.oc_d_normalRow)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "colprecio":
                case "colcantidad":
                case "colImpuesto":

                    DataRow row = gridView1.GetDataRow(e.RowHandle);
                    decimal cant, precio, impuesto;
                    try
                    {
                        cant = Convert.ToDecimal(row["cantidad"]);
                        precio = Convert.ToDecimal(row["precio"]);
                        impuesto = Convert.ToDecimal(row["Impuesto"]);
                    }
                    catch { cant = precio = impuesto = 0; }
                    decimal total = (cant * precio) + impuesto;
                    row["total_f"] = total;
                    CalcularTotal();
                    //CalcularImpuesto();
                    break;
            }
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
                    val = Convert.ToDecimal(row["total_f"]);
                }
                catch { }
                ProTotal += val;
            }
        }

        private void CalcularImpuesto()
        {
            ProImpuesto = 0;
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                decimal valI = 0;
                try
                {
                    valI = Convert.ToDecimal(row["Impuesto"]);
                }
                catch { }
                ProImpuesto += valI;
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
            {
                CajaDialogo.Error("Es necesario agregar los items a solicitar!");
                return;
            }

            if (ProTotal <= 0)
            {
                CajaDialogo.Error("El total de la orden debe ser mayor a cero!");
                return;
            }

            if (!ValidarNullText(txtProveedor.Text, "Nombre de Proveedor"))
                return;

            if (!ValidarNullText(txtRTN.Text, "RTN de Proveedor"))
                return;

            if (!ValidarNullText(txtDireccion.Text, "Dirección de Proveedor"))
                return;

            if (!ValidarNullText(dtFecha.Text, "Fecha de Orden de Compra"))
                return;

            if (!ValidarNullText(grMoneda.Text, "Moneda de Orden de Compra"))
                return;




            //Validar detalle
            for (int i = 0; i < gridView1.DataRowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                if (row[3] != null)
                {
                    if (string.IsNullOrEmpty(row[3].ToString()))
                    {
                        CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permite grabar descripciones en blanco!");
                    return;
                }

                if (row[4] != null)
                {
                    if (string.IsNullOrEmpty(row[4].ToString()))
                    {
                        CajaDialogo.Error("No se permite grabar Cantidades en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permite grabar cantidades en blanco!");
                    return;
                }

                if (row[5] != null)
                {
                    if (string.IsNullOrEmpty(row[5].ToString()))
                    {
                        CajaDialogo.Error("No se permite grabar precios en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permite grabar precios en blanco!");
                    return;
                }
            }
            DialogResult r = CajaDialogo.Pregunta("Esta seguro de generar esta Orden de Compra?");
            if (r != DialogResult.Yes)
                return;
            //Guardar Orden de compra normal
            DBOperations dp = new DBOperations();
            using (SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ))
            {
                conn.Open();

                SqlCommand cmd = conn.CreateCommand();
                SqlTransaction transaction;

                transaction = conn.BeginTransaction("SampleTransaction");

                cmd.Connection = conn;
                cmd.Transaction = transaction;

                try
                {
                    //Generar el Numero de la orden
                    cmd.CommandText = @"SELECT coalesce([siguiente],1) as sig
                                            FROM[dbo].[conf_tables_id]
                                            where id = 6";//Argegar el id de Orden de Compra Normal  
                    string Num = cmd.ExecuteScalar().ToString();
                    while (Num.Length < 5)
                    {
                        Num = "0" + Num;
                    }

                    //Insert de encabezado
                    cmd.CommandText = @"INSERT INTO [dbo].[ORDENC_NORMAL]
                                                                   (
                                                                     [proveedor]
                                                                    ,[codigo_proveedor]
                                                                    ,[rtn]
                                                                    ,[direccion]
                                                                    ,[contacto]
                                                                    ,[telefono]
                                                                    ,[fecha]
                                                                    ,[fecha_vence]
                                                                    ,[moneda]
                                                                    ,[referencia]
                                                                    ,[cerrada]
                                                                    ,[obs]
                                                                    ,[numero]
                                                                    ,[otros])
                                                             VALUES
                                                                   ( 
                                                                     @proveedor     
                                                                    ,@codigo_proveedor     
                                                                    ,@rtn     
                                                                    ,@direccion     
                                                                    ,@contacto     
                                                                    ,@telefono     
                                                                    ,@fecha     
                                                                    ,@fecha_vence     
                                                                    ,@moneda     
                                                                    ,@referencia     
                                                                    ,@cerrada
                                                                    ,@obs
                                                                    ,@numero
                                                                    ,@otros); SELECT SCOPE_IDENTITY()";
                    cmd.Parameters.Add("proveedor", SqlDbType.VarChar).Value = txtProveedor.Text;
                    if (string.IsNullOrEmpty(txtCodigoProveedor.Text))
                        cmd.Parameters.Add("codigo_proveedor", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("codigo_proveedor", SqlDbType.VarChar).Value = txtCodigoProveedor.Text;

                    if (string.IsNullOrEmpty(txtRTN.Text))
                        cmd.Parameters.Add("rtn", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("rtn", SqlDbType.VarChar).Value = txtRTN.Text;

                    if (string.IsNullOrEmpty(txtDireccion.Text))
                        cmd.Parameters.Add("direccion", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("direccion", SqlDbType.VarChar).Value = txtDireccion.Text;

                    if (string.IsNullOrEmpty(txtContacto.Text))
                        cmd.Parameters.Add("contacto", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("contacto", SqlDbType.VarChar).Value = txtContacto.Text;

                    if (string.IsNullOrEmpty(txtTelefono.Text))
                        cmd.Parameters.Add("telefono", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("telefono", SqlDbType.VarChar).Value = txtTelefono.Text;

                    if (string.IsNullOrEmpty(dtFecha.Text))
                        cmd.Parameters.Add("fecha", SqlDbType.Date).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("fecha", SqlDbType.Date).Value = dtFecha.EditValue;

                    if (string.IsNullOrEmpty(dtFechaVence.Text))
                        cmd.Parameters.Add("fecha_vence", SqlDbType.Date).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("fecha_vence", SqlDbType.Date).Value = dtFechaVence.EditValue;

                    if (string.IsNullOrEmpty(grMoneda.Text))
                        cmd.Parameters.Add("moneda", SqlDbType.Int).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("moneda", SqlDbType.Int).Value = grMoneda.EditValue;

                    if (string.IsNullOrEmpty(txtReferencia.Text))
                        cmd.Parameters.Add("referencia", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("referencia", SqlDbType.VarChar).Value = txtReferencia.Text;

                    if (string.IsNullOrEmpty(txtObservaciones.Text))
                        cmd.Parameters.Add("obs", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        cmd.Parameters.Add("obs", SqlDbType.VarChar).Value = txtObservaciones.Text;

                    cmd.Parameters.Add("cerrada", SqlDbType.Bit).Value = 0;

                    if (string.IsNullOrEmpty(txtOtros.Text))
                        cmd.Parameters.Add("otros", SqlDbType.Decimal).Value = 0;
                    else
                        cmd.Parameters.Add("otros", SqlDbType.Decimal).Value = txtOtros.Text;

                    //parametro numero
                    cmd.Parameters.Add("numero", SqlDbType.VarChar).Value = Num;

                    int Id_OC = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd.Parameters.Clear();

                    //Vamos a recorrer el detalle
                    for (int i = 0; i < gridView1.DataRowCount; i++)
                    {
                        cmd.Parameters.Clear();
                        DataRow row = gridView1.GetDataRow(i);
                        cmd.CommandText = @"INSERT INTO [dbo].[ORDENC_NORMALDe]
                                               ([id_orden_compra]
                                               ,[codigo]
                                               ,[descripcion]
                                               ,[cantidad]
                                               ,[precio]
                                               ,[Impuesto])
                                         VALUES
                                               (@id_orden_compra
                                               ,@codigo
                                               ,@descripcion
                                               ,@cantidad
                                               ,@precio
                                               ,@Impuesto)";

                        cmd.Parameters.Add("id_orden_compra", SqlDbType.Int).Value = Id_OC;
                        cmd.Parameters.Add("codigo", SqlDbType.VarChar).Value = row["codigo"];
                        cmd.Parameters.Add("descripcion", SqlDbType.VarChar).Value = row["descripcion"];
                        cmd.Parameters.Add("cantidad", SqlDbType.Decimal).Value = row["cantidad"];
                        cmd.Parameters.Add("precio", SqlDbType.Decimal).Value = row["precio"];
                        cmd.Parameters.Add("Impuesto", SqlDbType.Decimal).Value = row["Impuesto"];

                        cmd.ExecuteNonQuery();
                    }

                    //update numero row tables id
                    cmd.Parameters.Clear();

                    cmd.CommandText = @"Update [dbo].[conf_tables_id]
                                                set [siguiente] = ([siguiente] + 1)
                                            where id = 6";//Argegar el id de Orden de Compra Normal
                    cmd.ExecuteNonQuery();

                    transaction.Commit();
                    CajaDialogo.Information("Transacción exitosa!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    try
                    {
                        transaction.Rollback();
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
                CajaDialogo.Error("No puede dejar en blanco este campo:"+ objeto);
            return a;
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            //string sql = @"UPDATE [dbo].[ORDENC_NORMAL]
            //                 SET [cerrada] = 1
            //               WHERE [id] = @id";
            //try
            //{
            //    DBOperations dp = new DBOperations();
            //    SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
            //    conn.Open();
            //    SqlCommand cmd = new SqlCommand(sql, conn);
            //    cmd.Parameters.Add("id",SqlDbType.Int).Value = 
            //    cmd.ExecuteNonQuery();

            //    this.DialogResult = DialogResult.OK;
            //    this.Close();
            //}
            //catch (Exception ec)
            //{
            //    CajaDialogo.Error(ec.Message);
            //}
        }

        private void txtOtros_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Convert.ToChar(".")))
            {
                CajaDialogo.Error("Solo se permiten numeros!");
                e.Handled = true;
                return;
            }
        }

        private void txtObservaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtObservaciones.Text.Length >= 71)
                txtObservaciones.Text = txtObservaciones.Text.Substring(0, 69);
        }

        private void txtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}