using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using PRININ.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PRININ.Compras
{
    public partial class frmOrdenCompra : Form
    {

        public enum TipoEdicion
        {
            Insert = 1,
            Update = 2
        }

        TipoEdicion ProTipoEdicion;
        decimal _ProTotal;

        public decimal ProTotal { get => _ProTotal; set => _ProTotal = value; }

        public frmOrdenCompra(TipoEdicion pTipoEdicion)
        {
            InitializeComponent();
            ProTipoEdicion = pTipoEdicion;
            //LoadMonedas();
            //var combo = ((PRININ.Compras.dsCompras.monedasRow)((System.Data.DataRowView)grMoneda.GetSelectedDataRow()).Row).id;//sender as GridLookUpEdit;
            grMoneda.EditValue = 1;
            //var combo = grResolucion.Properties.s;//sender as GridLookUpEdit;

            //LoadRubros();
            LoadResolucion();
            LoadMonedas();
            //repositoryItemGridLookUpEdit1.View.Columns["id"].Visible = false;
            if (ProTipoEdicion == TipoEdicion.Update)
            {

            }
        }

        private void LoadMonedas()
        {
            try
            {
                string sql = @"SELECT [id]
                                     ,[descripcion]
                               FROM [dbo].[conf_monedas] where estado=1";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsCompras1.monedas.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCompras1.monedas);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadResolucion()
        {
            try
            {
                string sql = @"SELECT [codigo]
                                     ,[descripcion]
                               FROM [dbo].[resolucion]";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsCompras1.resolucion.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCompras1.resolucion);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }


        private void LoadRubros()
        {
            try
            {
                string sql = @"SELECT [id]
                                          ,(cast([codigo] as varchar) + ' - ' +[descripcion]) as descripcion
                                      FROM [dbo].[RUBROS]
                                      where enable = 1 
                                      order by codigo asc ";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                dsCompras1.rubros.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCompras1.rubros);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }



        private void LoadCapitulos(int pIdRubroSelected)
        {
            try
            {
                //string sql = @"sp_get_lista_capitulos_a_exonerar_oc";
                string sql = @"[sp_get_lista_capitulos_a_exonerar_oc]";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@id_rub", pIdRubroSelected);
                cmd.Parameters.AddWithValue("@id_rub", pIdRubroSelected);
                //dsCompras1.capitulos.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCompras1.capitulos);
                conn.Close();
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void LoadRubrosRes(string pIdResolucionSelected)
        {
            try
            {
                string sql = @"sp_get_lista_rubros_resolucion_a_exonerar_oc";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_res", pIdResolucionSelected);
                dsCompras1.rubros.Clear();
                SqlDataAdapter adat = new SqlDataAdapter(cmd);
                adat.Fill(dsCompras1.rubros);
                conn.Close();
                this.grResolucion.Enabled = false;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }




        private void cmdAbrirBusqueda_Click(object sender, EventArgs e)
        {
            LookProveedor();
        }

        private void LookProveedor()
        {
            frmBuscarProveedor frm = new frmBuscarProveedor();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                txtCodigoProveedor.Text = frm.Pro_codigo;
                txtProveedor.Text = frm.Pro_nombre;
                txtRTN.Text = frm.Pro_rtn;
            }
        }

        private void cmdSincronizarProveedores_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Realmente desea actualizar los Proveedores? esto tomara algunos minutos...", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(r!= DialogResult.Yes)
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

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            switch (e.Column.Name)
            {
                case "colprecio":
                case "colcantidad":
                    DataRow row = gridView1.GetDataRow(e.RowHandle);
                    decimal cant, precio;
                    try
                    {
                        cant = Convert.ToDecimal(row["cantidad"]);
                        precio = Convert.ToDecimal(row["precio"]);
                    }
                    catch{cant = precio = 0;}
                    decimal total = cant * precio;
                    row["total_f"] = total;
                    CalcularTotal();
                break;
                case "colid_rubro":
                    DataRow row1 = gridView1.GetDataRow(e.RowHandle);
                    int id = Convert.ToInt32(row1["id_rubro"]);
                    //int id = Convert.ToInt32(row1["id_capitulo"]);
                    // row1["saldo"] = getSaldoRubro(id);
                    //row1["saldo"] = getSaldoCapitulo(id);
                    //LoadCapitulos(id);
                    frmseleccionarCapitulo frm = new frmseleccionarCapitulo(id);
                    if(frm.ShowDialog()== DialogResult.OK)
                    {
                        //row1["saldo"] = frm.saldo;
                        //row1["pagos_d"] = frm.pagos;
                        row1["saldo"] = getSaldoCapitulo(frm.id);
                        row1["pagos_d"] = SaldoPagosCapitulo(frm.id);
                        row1["id_capitulo"] = frm.id;
                        row1["capitulo"] = frm.descripcion;
                    }
                    break;
                case "colCap":
                    //DataRow row2 = gridView1.GetDataRow(e.RowHandle);
                    //int id_cap = Convert.ToInt32(row2["id_capitulo"]);
                    
                    //row2["saldo"] = getSaldoCapitulo(id_cap);
                    //row2["pagos_d"] = SaldoPagosCapitulo(id_cap);
                    
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
                catch{}
                ProTotal += val;
            }
        }

        private void cmdAgregar_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(grResolucion.Text ))
            {
                CajaDialogo.Error("Debe seleccionar primero la Resolucion!");
                return;
            }


            dsCompras.oc_detalleRow row1 = dsCompras1.oc_detalle.Newoc_detalleRow();
            #region Codigo No Utilizado
            //row1.id = 0;
            //row1.id_compra = 0;
            //row1.id_producto = id_producto;
            //Producto Pro = new Producto();
            //if (Pro.RecuperarRegistros(id_producto))
            //{
            //    row1.descripcion = Pro.Nombre;
            //    row1.cantidad = 1;
            //    row1.precio = Pro.Precio_unit;
            //    row1.unidad_media = Pro.Id_unidadmedida;
            //    row1.nombre_unidadmedida = Pro.Nombre_unidadmedida;
            //    row1.total = 0;
            //    dsOrdenes1.ordenes_d.Addordenes_dRow(row1);
            //}
            #endregion
            dsCompras1.oc_detalle.Addoc_detalleRow(row1);
            //repositoryItemGridLookUpEdit1.View.Columns["id"].Visible = false;
            dsCompras1.AcceptChanges();
           
            repositoryItemGridLookUpEdit1.View.PopulateColumns(repositoryItemGridLookUpEdit1.DataSource);
            repositoryItemGridLookUpEdit1.View.Columns[0].Visible =false;

            var combo = ((PRININ.Compras.dsCompras.resolucionRow)((System.Data.DataRowView)grResolucion.GetSelectedDataRow()).Row).codigo;//sender as GridLookUpEdit;
            //var combo = grResolucion.Properties.s;//sender as GridLookUpEdit;
            // this.LoadRubrosRes(combo);
            // var click = combo.GetSelectedDataRow.Text;


            //int iclick = Convert.ToInt32(click);
            this.LoadRubrosRes(combo);
        }

        private void repositoryItemButtonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar row del grid
            DialogResult r = MessageBox.Show("¿Desea Eliminar ésta linea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
            {
                return;
            }

            var gridView1 = (GridView)gridMain.FocusedView;
            var row = (dsCompras.oc_detalleRow)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (gridView1.DataRowCount == 0)
            {
                CajaDialogo.Error("Es necesario agregar los items a solicitar!");
                return;
            }

            if(ProTotal <= 0)
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

            if (!ValidarNullText(grResolucion.Text, "Resolución Orden de Compra"))
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

                if (row["id_capitulo"] != null)
                {
                    if (string.IsNullOrEmpty(row["id_capitulo"].ToString()))
                    {
                        CajaDialogo.Error("No se permite grabar Ordenes de compra dejando el Capitulo en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permite grabar Ordenes de compra dejando el Capitulo en blanco!");
                    return;
                }


                if (row["id_rubro"] != null)
                {
                    if (string.IsNullOrEmpty(row["id_rubro"].ToString()))
                    {
                        CajaDialogo.Error("No se permite grabar Ordenes de compra dejando el Rubro en blanco!");
                        return;
                    }
                }
                else
                {
                    CajaDialogo.Error("No se permite grabar Ordenes de compra dejando el Rubro en blanco!");
                    return;
                }

            }

           

                DialogResult r = CajaDialogo.Pregunta("Esta seguro de generar esta Orden de Compra?");
            if (r != DialogResult.Yes)
                return;

            //Guardar orden de compra.
            DBOperations dp = new DBOperations();
            using (SqlConnection connection = new SqlConnection(dp.ConnectionStringPRININ))
            {
                connection.Open();

                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                // Start a local transaction.
                transaction = connection.BeginTransaction("SampleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    //Generar el numero
                    command.CommandText = @"SELECT coalesce([siguiente],1) as sig
                                            FROM [dbo].[conf_tables_id]
                                            where id = 3";
                    string vNumero = command.ExecuteScalar().ToString();
                    while(vNumero.Length < 5)
                    {
                        vNumero = "0" + vNumero;
                    }

                    for (int i = 0; i < gridView1.DataRowCount; i++)
                    {
                        command.Parameters.Clear();
                        DataRow row = gridView1.GetDataRow(i);

                        command.CommandText = @"SELECT coalesce(sum([cantidad] * [precio]),0) as total
						                         FROM [dbo].[ORDEN_COMPRA_D]dd join
							                     [dbo].ORDEN_COMPRA hh on
								                 dd.id_orden_compra = hh.id 
						                         where hh.cerrada = 0 
							                     and dd.id_capitulo = @id_cap1
							                     and hh.fecha >= '10/06/2020'";
                        command.Parameters.Add("id_cap1", SqlDbType.Int).Value = row["id_capitulo"];
                        string vTotalActual = command.ExecuteScalar().ToString();

                        decimal total = (Convert.ToDecimal(row["cantidad"]) * Convert.ToDecimal(row["precio"]));

                        command.CommandText = @"select monto_inicial from CAPITULOS_SALDOS
                                                    where enable = 1 
                                                          and id = @id_cap2";

                        command.Parameters.Add("id_cap2", SqlDbType.Int).Value = row["id_capitulo"];
                        object id = row["id_capitulo"];

                        string vMontoInicial= command.ExecuteScalar().ToString();

                        decimal saldo = (Convert.ToDecimal(vMontoInicial)) - ((Convert.ToDecimal(vTotalActual)) + total);

                        if (saldo < 0) {
                            CajaDialogo.Error("El monto está excedido");
                            return;
                        }
                    }

                    //for (int i = 0; i < gridView1.DataRowCount; i++)
                    //{
                    //    command.Parameters.Clear();
                    //    DataRow row = gridView1.GetDataRow(i);

                    //    command.CommandText = @"select 
							             //       count(id_capitulo) as sal_pagos
						              //          from ORDEN_COMPRA_D
						              //          where id_capitulo=@id_cap3
						              //          group by id_capitulo";
                    //    command.Parameters.Add("id_cap3", SqlDbType.Int).Value = row["id_capitulo"];
                    //    string vPagosActuales = command.ExecuteScalar().ToString();

                    //    command.CommandText = @"select pagos from CAPITULOS_SALDOS
                    //                                where id_capitulo = @id_cap4";

                    //    command.Parameters.Add("id_cap4", SqlDbType.Int).Value = row["id_capitulo"];

                    //    string vTotalPagos = command.ExecuteScalar().ToString();

                    //    decimal saldoPagos = (Convert.ToDecimal(vTotalPagos)) - ((Convert.ToDecimal(vPagosActuales)) + 1);

                    //    //if (saldoPagos < 0)
                    //    //{
                    //    //    CajaDialogo.Error("LLego al Límite de Pagos");
                    //    //    return;
                    //    //}




                    //    // command.ExecuteNonQuery();
                    //}

                    //encabezado
                    command.CommandText = @"INSERT INTO [dbo].[ORDEN_COMPRA]
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
                                                                    ,[resolucion]
                                                                    )
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
                                                                    ,@resolucion
                                                                    ); SELECT SCOPE_IDENTITY()";

                    command.Parameters.Add("proveedor", SqlDbType.VarChar).Value = txtProveedor.Text;
                    if (string.IsNullOrEmpty(txtCodigoProveedor.Text))
                        command.Parameters.Add("codigo_proveedor", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        command.Parameters.Add("codigo_proveedor", SqlDbType.VarChar).Value = txtCodigoProveedor.Text;

                    if (string.IsNullOrEmpty(txtRTN.Text))
                        command.Parameters.Add("rtn", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        command.Parameters.Add("rtn", SqlDbType.VarChar).Value = txtRTN.Text;

                    if (string.IsNullOrEmpty(txtDireccion.Text))
                        command.Parameters.Add("direccion", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        command.Parameters.Add("direccion", SqlDbType.VarChar).Value = txtDireccion.Text;

                    if (string.IsNullOrEmpty(txtContacto.Text))
                        command.Parameters.Add("contacto", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        command.Parameters.Add("contacto", SqlDbType.VarChar).Value = txtContacto.Text;

                    if (string.IsNullOrEmpty(txtTelefono.Text))
                        command.Parameters.Add("telefono", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        command.Parameters.Add("telefono", SqlDbType.VarChar).Value = txtTelefono.Text;

                    if (string.IsNullOrEmpty(dtFecha.Text))
                        command.Parameters.Add("fecha", SqlDbType.Date).Value = DBNull.Value;
                    else
                        command.Parameters.Add("fecha", SqlDbType.Date).Value = dtFecha.EditValue;

                    if (string.IsNullOrEmpty(dtFechaVence.Text))
                        command.Parameters.Add("fecha_vence", SqlDbType.Date).Value = DBNull.Value;
                    else
                        command.Parameters.Add("fecha_vence", SqlDbType.Date).Value = dtFechaVence.EditValue;

                    if (string.IsNullOrEmpty(grMoneda.Text))
                        command.Parameters.Add("moneda", SqlDbType.Int).Value = DBNull.Value;
                    else
                        command.Parameters.Add("moneda", SqlDbType.Int).Value = grMoneda.EditValue;

                    if (string.IsNullOrEmpty(grMoneda.Text))
                        command.Parameters.Add("referencia", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        command.Parameters.Add("referencia", SqlDbType.VarChar).Value = txtReferencia.Text;

                    if (string.IsNullOrEmpty(txtObservaciones.Text))
                        command.Parameters.Add("obs", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        command.Parameters.Add("obs", SqlDbType.VarChar).Value = txtObservaciones.Text;

                    if (string.IsNullOrEmpty(grResolucion.Text))
                        command.Parameters.Add("resolucion", SqlDbType.VarChar).Value = DBNull.Value;
                    else
                        command.Parameters.Add("resolucion", SqlDbType.VarChar).Value = grResolucion.Text;

                    command.Parameters.Add("cerrada", SqlDbType.Bit).Value = 0;

                    
                    

                    //parametro numero
                    command.Parameters.Add("numero", SqlDbType.VarChar).Value = vNumero;

                    int Id_OC = Convert.ToInt32(command.ExecuteScalar());

                    //Limipiamos los parametros
                    command.Parameters.Clear();

                    //Vamos a recorrer el detalle
                    for (int i = 0; i < gridView1.DataRowCount; i++)
                    {
                        command.Parameters.Clear();
                        DataRow row = gridView1.GetDataRow(i);
                        command.CommandText = @"INSERT INTO [dbo].[ORDEN_COMPRA_D]
                                                                               ([id_orden_compra]
                                                                               ,[codigo]
                                                                               ,[descripcion]
                                                                               ,[cantidad]
                                                                               ,[precio]
                                                                               ,[id_rubro]
                                                                               ,[id_capitulo])
                                                                         VALUES
                                                                               (@id_orden_compra
                                                                               ,@codigo
                                                                               ,@descripcion
                                                                               ,@cantidad
                                                                               ,@precio
                                                                               ,@id_rubro
                                                                               ,@id_cap)";
                        command.Parameters.Add("id_orden_compra", SqlDbType.Int).Value = Id_OC;
                        command.Parameters.Add("codigo", SqlDbType.VarChar).Value = row["codigo"];
                        command.Parameters.Add("descripcion", SqlDbType.VarChar).Value = row["descripcion"];
                        command.Parameters.Add("cantidad", SqlDbType.Decimal).Value = row["cantidad"];
                        command.Parameters.Add("precio", SqlDbType.Decimal).Value = row["precio"];

                        if (row["id_rubro"] == null)
                            command.Parameters.Add("id_rubro", SqlDbType.Int).Value = DBNull.Value;
                        else
                            command.Parameters.Add("id_rubro", SqlDbType.Int).Value = row["id_rubro"];

                        command.Parameters.Add("id_cap", SqlDbType.Int).Value = row["id_capitulo"]; 

                        command.ExecuteNonQuery();
                    }

                    //update numero row tables id
                    command.Parameters.Clear();

                    command.CommandText = @"Update [dbo].[conf_tables_id]
                                                set [siguiente] = ([siguiente] + 1)
                                            where id = 3";
                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    CajaDialogo.Information("Transacción exitosa!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    // Attempt to roll back the transaction.
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
                CajaDialogo.Error("No puede dejar en blanco la casilla: " + objeto);

            return a;
        }

        private void repositoryItemGridLookUpEdit1_EditValueChanged(object sender, EventArgs e)
        {
        }

        private void repositoryItemGridLookUpEdit1_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {   
        }

        decimal getSaldoRubro(int pid_rub)
        {
            //Rubro seleccionado
            decimal val = 0;
            //var gridView = (GridView)gridMain.FocusedView;
            //var row = (DataRow)gridView.GetFocusedRow()//GetFocusedDataRow();
            int id_rubro = pid_rub;
            try
            {
                //string sql = @"SELECT  coalesce(([monto_inicial] - coalesce((SELECT sum([cantidad] * [precio]) as total
                //                       FROM [PRININ].[dbo].[ORDEN_COMPRA_D]dd join
                //                            [PRININ].[dbo].ORDEN_COMPRA hh on
                //                         dd.id_orden_compra = hh.id 
                //                       where hh.cerrada = 0 and dd.id_rubro = @id_rub),0) ),0) as saldo

                //                  FROM [PRININ].[dbo].[RUBROS_SALDOS] rr
                //                  where rr.enable = 1 and rr.id_rubro = @id_rub";
                string sql = "sp_get_saldo_rubro_a_exonerar";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_rub",id_rubro);
                val = Convert.ToDecimal(cmd.ExecuteScalar());
                //row["col_saldo"] = saldo;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return val;
        }

        //Cambios Royaltic Saldos por Capítulo
        decimal getSaldoCapitulo(int pid_cap)
        {
            //Rubro seleccionado
            decimal val = 0;
            //var gridView = (GridView)gridMain.FocusedView;
            //var row = (DataRow)gridView.GetFocusedRow()//GetFocusedDataRow();
            int id_capitulo= pid_cap;
            try
            {
                //string sql = @"SELECT  coalesce(([monto_inicial] - coalesce((SELECT sum([cantidad] * [precio]) as total
                //                       FROM [PRININ].[dbo].[ORDEN_COMPRA_D]dd join
                //                            [PRININ].[dbo].ORDEN_COMPRA hh on
                //                         dd.id_orden_compra = hh.id 
                //                       where hh.cerrada = 0 and dd.id_rubro = @id_rub),0) ),0) as saldo

                //                  FROM [PRININ].[dbo].[RUBROS_SALDOS] rr
                //                  where rr.enable = 1 and rr.id_rubro = @id_rub";
                string sql = "sp_get_saldo_capitulo_a_exonerar";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cap", id_capitulo);
                val = Convert.ToDecimal(cmd.ExecuteScalar());

                //row["col_saldo"] = saldo;
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            return val;
        }

        public int SaldoPagosCapitulo(int pid_cap)
        {
            int val = 0;
            try
            {
                string sql = "sp_get_saldo_pagos_capitulo_a_exonerar";
                DBOperations dp = new DBOperations();
                SqlConnection conn = new SqlConnection(dp.ConnectionStringPRININ);
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id_cap", pid_cap);
                val = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
            if (val < 0)
                val = 0;

            return val;
        }

        private void txtRTN_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtProveedor_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigoProveedor_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtObservaciones_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtObservaciones.Text.Length > 70)
            {
                errorProvider1.SetError(txtObservaciones, "Solo se permite hasta un maximo de 70 caracteres!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtObservaciones_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void grMoneda_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void grResolucion_TextChanged(object sender, EventArgs e)
        {
            //var combo = sender as GridLookUpEdit;
            //var click = combo.GetSelectedDataRow.Text;


            //int iclick = Convert.ToInt32(click);
            //this.LoadRubrosRes(iclick);
        }

        private void repositoryItemButtonEdit1_ButtonClick_1(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
        }

        private void repositoryItemButtonDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //Eliminar row del grid
            DialogResult r = MessageBox.Show("¿Desea Eliminar ésta linea?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r != DialogResult.Yes)
            {
                return;
            }

            var gridView1 = (GridView)gridMain.FocusedView;
            var row = (dsCompras.oc_detalleRow)gridView1.GetFocusedDataRow();

            try
            {
                gridView1.DeleteRow(gridView1.FocusedRowHandle);
            }
            catch (Exception ec)
            {
                CajaDialogo.Error(ec.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
