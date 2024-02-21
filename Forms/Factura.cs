﻿using FacturaDesktopApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacturaDesktopApp.Services; 

namespace FacturaDesktopApp
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();
        }
        FacturaService facturaService = new FacturaService();
        BindingSource bs = new BindingSource();
        BindingSource bsdetalle = new BindingSource();
        DataSet ds = new DataSet();
        Boolean EditMode = false;
        List<DocumentoFactura> FacturasFake = new List<DocumentoFactura>();
        

        private void Factura_Load(object sender, EventArgs e)
        {
            // conjunto de datos.
            ds = facturaService.ds;
            bs.DataSource = ds;
            bs.DataMember = "dtheaderfactura";
            // Enlace de datos
            txt_numeroFactura.DataBindings.Add("text", bs, "NUMERO");
            txt_fechaFactura.DataBindings.Add("text", bs, "FECHA");
            txt_idCliente.DataBindings.Add("text", bs, "CUSTOMER_ID");
            txt_NombreCliente.DataBindings.Add("text", bs, "customer_name");
            rad_Contado.DataBindings.Add("checked", bs, "CONTADO");
            rad_Credito.DataBindings.Add("checked", bs, "CREDITO");
            chk_FacturaImpresa.DataBindings.Add("checked", bs, "IMPRESA");
            chk_FacturaAnulada.DataBindings.Add("checked", bs, "ANULADA");
            txt_SubTotal.DataBindings.Add("text", bs, "SUBTOTAL");
            txt_Impuesto.DataBindings.Add("text",bs,"ITBIS");
            txt_MontoTotalFactura.DataBindings.Add("text",bs,"MONTO_FACTURA");
            txt_ComentariosGen.DataBindings.Add("text",bs,"COMENTARIO");
            // binding de detalle de factura
            bsdetalle.DataSource = bs;
            bsdetalle.DataMember = "FK_FACTURA_DETALLE";
            
            //Establecer los estilos de grid de productos.
            GridProductos.AutoGenerateColumns = false;
            AGREGAR_COLUMN_GRID("product_id",80,"Codigo","product_id",GridProductos);
            AGREGAR_COLUMN_GRID("product_name", 250, "Descripcion del Articulo", "product_name", GridProductos);
            AGREGAR_COLUMN_GRID("cantidad", 80, "Cantidad", "cantidad", GridProductos);
            AGREGAR_COLUMN_GRID("precio", 80, "Precio", "precio", GridProductos);
            AGREGAR_COLUMN_GRID("importe", 100, "Subtotal", "importe", GridProductos);
            AGREGAR_COLUMN_GRID("impuesto", 100, "Impuesto", "impuesto", GridProductos);
            AGREGAR_COLUMN_GRID("total_renglon", 100, "Total", "total_renglon", GridProductos);
            GridProductos.DataSource = bsdetalle;
            
            



            


            //FacturasFake = LoadData.GetData();
        }

        private void AGREGAR_COLUMN_GRID(string name, int size, string title, string field_db, DataGridView grid) 
        {
            DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn
            {
              Name = name,
              Width = size,
              HeaderText = title,
              DataPropertyName = field_db
            };
            grid.Columns.Add(col);
        }

        private void Btn_LoadFactura_Click(object sender, EventArgs e)
        {
            //carga de encabezado de la factura
            txt_numeroFactura.Text = FacturasFake[0].Numero.ToString();
            txt_fechaFactura.Text = FacturasFake[0].Fecha.ToString();
            txt_idCliente.Text = FacturasFake[0].customer.Id_Customer.ToString();
            txt_NombreCliente.Text = FacturasFake[0].customer.Customer_Name.ToString();
            rad_Contado.Checked = FacturasFake[0].Contado;
            rad_Credito.Checked = FacturasFake[0].Credito;
            txt_ComentariosGen.Text = FacturasFake[0].Comentarios;
            txt_SubTotal.Text = FacturasFake[0].SubTotal.ToString();
            txt_Impuesto.Text = FacturasFake[0].Impuesto.ToString();
            txt_MontoTotalFactura.Text = FacturasFake[0].MontoTotal_Factura.ToString();
            chk_FacturaImpresa.Checked = FacturasFake[0].Impresa;
            chk_FacturaAnulada.Checked = FacturasFake[0].Anulada;
            // carga de renglones de la factura


            //renglon1
            DataGridViewRow row = (DataGridViewRow)GridProductos.Rows[0].Clone();
            row.Cells[0].Value = FacturasFake[0].items[0].Id_Product.ToString();
            row.Cells[1].Value = FacturasFake[0].items[0].Name_Product.ToString();
            row.Cells[4].Value = FacturasFake[0].items[0].Precio.ToString();
            row.Cells[3].Value = FacturasFake[0].items[0].Cantidad.ToString();
            row.Cells[5].Value = FacturasFake[0].items[0].Imputesto;
            row.Cells[6].Value = FacturasFake[0].items[0].TotalRenglon.ToString();
            GridProductos.Rows.Add(row);


            //renglon2
            row = (DataGridViewRow)GridProductos.Rows[1].Clone();
            row.Cells[0].Value = FacturasFake[0].items[1].Id_Product.ToString();
            row.Cells[1].Value = FacturasFake[0].items[1].Name_Product.ToString();
            row.Cells[4].Value = FacturasFake[0].items[1].Precio.ToString();
            row.Cells[3].Value = FacturasFake[0].items[1].Cantidad.ToString();
            row.Cells[5].Value = FacturasFake[0].items[1].Imputesto;
            row.Cells[6].Value = FacturasFake[0].items[1].TotalRenglon.ToString();
            GridProductos.Rows.Add(row);

            //renglon3
            row = (DataGridViewRow)GridProductos.Rows[2].Clone();
            row.Cells[0].Value = FacturasFake[0].items[2].Id_Product.ToString();
            row.Cells[1].Value = FacturasFake[0].items[2].Name_Product.ToString();
            row.Cells[4].Value = FacturasFake[0].items[2].Precio.ToString();
            row.Cells[3].Value = FacturasFake[0].items[2].Cantidad.ToString();
            row.Cells[5].Value = FacturasFake[0].items[2].Imputesto;
            row.Cells[6].Value = FacturasFake[0].items[2].TotalRenglon.ToString();
            GridProductos.Rows.Add(row);



        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }

        private void btn_NavSiguiente_Click(object sender, EventArgs e)
        {
            bs.Position += 1;
        }

        private void btn_navAnterior_Click(object sender, EventArgs e)
        {
            bs.Position -= 1;
        }

        private void btn_NavPrimero_Click(object sender, EventArgs e)
        {
            bs.Position = 0;

        }

        private void btn_navUltimo_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Count - 1;
        }
    }
}
