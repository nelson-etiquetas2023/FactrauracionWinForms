namespace FacturaDesktopApp
{
    partial class Factura
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Factura));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_AddFactura = new System.Windows.Forms.ToolStripButton();
            this.btn_SaveFactura = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.txt_numeroFactura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fechaFactura = new System.Windows.Forms.DateTimePicker();
            this.rad_Contado = new System.Windows.Forms.RadioButton();
            this.rad_Credito = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_idCliente = new System.Windows.Forms.TextBox();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.GridProductos = new System.Windows.Forms.DataGridView();
            this.idproduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_SubTotal = new System.Windows.Forms.TextBox();
            this.txt_Impuesto = new System.Windows.Forms.TextBox();
            this.txt_MontoTotalFactura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_ComentariosGen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_buscar_Cliente = new System.Windows.Forms.Button();
            this.btn_AddItems = new System.Windows.Forms.Button();
            this.btn_DeleteItems = new System.Windows.Forms.Button();
            this.chk_FacturaImpresa = new System.Windows.Forms.CheckBox();
            this.chk_FacturaAnulada = new System.Windows.Forms.CheckBox();
            this.btn_buscar_factura = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_LoadFactura = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_LoadFactura = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de Factura :";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_AddFactura,
            this.btn_SaveFactura,
            this.toolStripButton3,
            this.toolStripButton4});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(882, 30);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_AddFactura
            // 
            this.btn_AddFactura.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddFactura.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddFactura.Image")));
            this.btn_AddFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_AddFactura.Name = "btn_AddFactura";
            this.btn_AddFactura.Size = new System.Drawing.Size(155, 27);
            this.btn_AddFactura.Text = "Agregar Factura";
            // 
            // btn_SaveFactura
            // 
            this.btn_SaveFactura.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveFactura.Image = ((System.Drawing.Image)(resources.GetObject("btn_SaveFactura.Image")));
            this.btn_SaveFactura.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SaveFactura.Name = "btn_SaveFactura";
            this.btn_SaveFactura.Size = new System.Drawing.Size(155, 27);
            this.btn_SaveFactura.Text = "Guardar Factura";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(23, 27);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(23, 27);
            this.toolStripButton4.Text = "toolStripButton4";
            // 
            // txt_numeroFactura
            // 
            this.txt_numeroFactura.Location = new System.Drawing.Point(181, 45);
            this.txt_numeroFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txt_numeroFactura.Name = "txt_numeroFactura";
            this.txt_numeroFactura.Size = new System.Drawing.Size(110, 30);
            this.txt_numeroFactura.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // txt_fechaFactura
            // 
            this.txt_fechaFactura.Location = new System.Drawing.Point(181, 86);
            this.txt_fechaFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txt_fechaFactura.Name = "txt_fechaFactura";
            this.txt_fechaFactura.Size = new System.Drawing.Size(313, 30);
            this.txt_fechaFactura.TabIndex = 4;
            // 
            // rad_Contado
            // 
            this.rad_Contado.AutoSize = true;
            this.rad_Contado.Location = new System.Drawing.Point(34, 48);
            this.rad_Contado.Margin = new System.Windows.Forms.Padding(4);
            this.rad_Contado.Name = "rad_Contado";
            this.rad_Contado.Size = new System.Drawing.Size(94, 27);
            this.rad_Contado.TabIndex = 5;
            this.rad_Contado.TabStop = true;
            this.rad_Contado.Text = "Contado";
            this.rad_Contado.UseVisualStyleBackColor = true;
            // 
            // rad_Credito
            // 
            this.rad_Credito.AutoSize = true;
            this.rad_Credito.Location = new System.Drawing.Point(34, 85);
            this.rad_Credito.Margin = new System.Windows.Forms.Padding(4);
            this.rad_Credito.Name = "rad_Credito";
            this.rad_Credito.Size = new System.Drawing.Size(85, 27);
            this.rad_Credito.TabIndex = 6;
            this.rad_Credito.TabStop = true;
            this.rad_Credito.Text = "Credito";
            this.rad_Credito.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rad_Contado);
            this.groupBox1.Controls.Add(this.rad_Credito);
            this.groupBox1.Location = new System.Drawing.Point(659, 59);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(159, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Pago:";
            // 
            // txt_idCliente
            // 
            this.txt_idCliente.Location = new System.Drawing.Point(181, 130);
            this.txt_idCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_idCliente.Name = "txt_idCliente";
            this.txt_idCliente.Size = new System.Drawing.Size(110, 30);
            this.txt_idCliente.TabIndex = 8;
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(181, 169);
            this.txt_NombreCliente.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(470, 30);
            this.txt_NombreCliente.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Id. Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 174);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = "Nombre Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Location = new System.Drawing.Point(14, 253);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Detalle de los Productos: ";
            // 
            // GridProductos
            // 
            this.GridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproduct,
            this.products,
            this.Search,
            this.cantidad,
            this.precio,
            this.imp,
            this.importe});
            this.GridProductos.Location = new System.Drawing.Point(14, 280);
            this.GridProductos.Margin = new System.Windows.Forms.Padding(4);
            this.GridProductos.Name = "GridProductos";
            this.GridProductos.Size = new System.Drawing.Size(791, 303);
            this.GridProductos.TabIndex = 13;
            // 
            // idproduct
            // 
            this.idproduct.HeaderText = "Id. Producto";
            this.idproduct.Name = "idproduct";
            // 
            // products
            // 
            this.products.HeaderText = "Descripcion del Articulo";
            this.products.Name = "products";
            this.products.Width = 180;
            // 
            // Search
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Search.DefaultCellStyle = dataGridViewCellStyle1;
            this.Search.HeaderText = "...";
            this.Search.Name = "Search";
            this.Search.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Search.Text = "...";
            this.Search.ToolTipText = "Buscar productos";
            this.Search.UseColumnTextForButtonValue = true;
            this.Search.Width = 45;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // imp
            // 
            this.imp.HeaderText = "impuesto";
            this.imp.Name = "imp";
            // 
            // importe
            // 
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            // 
            // txt_SubTotal
            // 
            this.txt_SubTotal.Location = new System.Drawing.Point(602, 614);
            this.txt_SubTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txt_SubTotal.Name = "txt_SubTotal";
            this.txt_SubTotal.Size = new System.Drawing.Size(202, 30);
            this.txt_SubTotal.TabIndex = 14;
            // 
            // txt_Impuesto
            // 
            this.txt_Impuesto.Location = new System.Drawing.Point(602, 655);
            this.txt_Impuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Impuesto.Name = "txt_Impuesto";
            this.txt_Impuesto.Size = new System.Drawing.Size(202, 30);
            this.txt_Impuesto.TabIndex = 15;
            // 
            // txt_MontoTotalFactura
            // 
            this.txt_MontoTotalFactura.Location = new System.Drawing.Point(602, 696);
            this.txt_MontoTotalFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MontoTotalFactura.Name = "txt_MontoTotalFactura";
            this.txt_MontoTotalFactura.Size = new System.Drawing.Size(202, 30);
            this.txt_MontoTotalFactura.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(474, 619);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "Sub-Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 658);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "ITBIS:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 700);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 19;
            this.label8.Text = "Total Factura :";
            // 
            // txt_ComentariosGen
            // 
            this.txt_ComentariosGen.Location = new System.Drawing.Point(14, 625);
            this.txt_ComentariosGen.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ComentariosGen.Multiline = true;
            this.txt_ComentariosGen.Name = "txt_ComentariosGen";
            this.txt_ComentariosGen.Size = new System.Drawing.Size(434, 103);
            this.txt_ComentariosGen.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 598);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(196, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Comentarios Generales:";
            // 
            // btn_buscar_Cliente
            // 
            this.btn_buscar_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_Cliente.Location = new System.Drawing.Point(299, 126);
            this.btn_buscar_Cliente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar_Cliente.Name = "btn_buscar_Cliente";
            this.btn_buscar_Cliente.Size = new System.Drawing.Size(49, 39);
            this.btn_buscar_Cliente.TabIndex = 22;
            this.btn_buscar_Cliente.Text = "...";
            this.btn_buscar_Cliente.UseVisualStyleBackColor = true;
            // 
            // btn_AddItems
            // 
            this.btn_AddItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddItems.Location = new System.Drawing.Point(811, 280);
            this.btn_AddItems.Margin = new System.Windows.Forms.Padding(4);
            this.btn_AddItems.Name = "btn_AddItems";
            this.btn_AddItems.Size = new System.Drawing.Size(49, 39);
            this.btn_AddItems.TabIndex = 23;
            this.btn_AddItems.Text = "+";
            this.btn_AddItems.UseVisualStyleBackColor = true;
            // 
            // btn_DeleteItems
            // 
            this.btn_DeleteItems.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteItems.Location = new System.Drawing.Point(811, 326);
            this.btn_DeleteItems.Margin = new System.Windows.Forms.Padding(4);
            this.btn_DeleteItems.Name = "btn_DeleteItems";
            this.btn_DeleteItems.Size = new System.Drawing.Size(49, 39);
            this.btn_DeleteItems.TabIndex = 24;
            this.btn_DeleteItems.Text = "-";
            this.btn_DeleteItems.UseVisualStyleBackColor = true;
            // 
            // chk_FacturaImpresa
            // 
            this.chk_FacturaImpresa.AutoSize = true;
            this.chk_FacturaImpresa.Location = new System.Drawing.Point(479, 229);
            this.chk_FacturaImpresa.Margin = new System.Windows.Forms.Padding(4);
            this.chk_FacturaImpresa.Name = "chk_FacturaImpresa";
            this.chk_FacturaImpresa.Size = new System.Drawing.Size(154, 27);
            this.chk_FacturaImpresa.TabIndex = 25;
            this.chk_FacturaImpresa.Text = "Factura Impresa";
            this.chk_FacturaImpresa.UseVisualStyleBackColor = true;
            // 
            // chk_FacturaAnulada
            // 
            this.chk_FacturaAnulada.AutoSize = true;
            this.chk_FacturaAnulada.Location = new System.Drawing.Point(665, 229);
            this.chk_FacturaAnulada.Margin = new System.Windows.Forms.Padding(4);
            this.chk_FacturaAnulada.Name = "chk_FacturaAnulada";
            this.chk_FacturaAnulada.Size = new System.Drawing.Size(155, 27);
            this.chk_FacturaAnulada.TabIndex = 27;
            this.chk_FacturaAnulada.Text = "Factura Anulada";
            this.chk_FacturaAnulada.UseVisualStyleBackColor = true;
            // 
            // btn_buscar_factura
            // 
            this.btn_buscar_factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar_factura.Location = new System.Drawing.Point(299, 40);
            this.btn_buscar_factura.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar_factura.Name = "btn_buscar_factura";
            this.btn_buscar_factura.Size = new System.Drawing.Size(49, 39);
            this.btn_buscar_factura.TabIndex = 28;
            this.btn_buscar_factura.Text = "...";
            this.btn_buscar_factura.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_LoadFactura);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_LoadFactura);
            this.groupBox2.Location = new System.Drawing.Point(12, 735);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(792, 77);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resumen";
            // 
            // btn_LoadFactura
            // 
            this.btn_LoadFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LoadFactura.Location = new System.Drawing.Point(274, 25);
            this.btn_LoadFactura.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LoadFactura.Name = "btn_LoadFactura";
            this.btn_LoadFactura.Size = new System.Drawing.Size(82, 39);
            this.btn_LoadFactura.TabIndex = 30;
            this.btn_LoadFactura.Text = "Load";
            this.btn_LoadFactura.UseVisualStyleBackColor = true;
            this.btn_LoadFactura.Click += new System.EventHandler(this.Btn_LoadFactura_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(129, 23);
            this.label10.TabIndex = 31;
            this.label10.Text = "Cargar Facrura:";
            // 
            // txt_LoadFactura
            // 
            this.txt_LoadFactura.Location = new System.Drawing.Point(156, 33);
            this.txt_LoadFactura.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LoadFactura.Name = "txt_LoadFactura";
            this.txt_LoadFactura.Size = new System.Drawing.Size(110, 30);
            this.txt_LoadFactura.TabIndex = 30;
            this.txt_LoadFactura.Text = "1";
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 861);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_buscar_factura);
            this.Controls.Add(this.chk_FacturaAnulada);
            this.Controls.Add(this.chk_FacturaImpresa);
            this.Controls.Add(this.btn_DeleteItems);
            this.Controls.Add(this.btn_AddItems);
            this.Controls.Add(this.btn_buscar_Cliente);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_ComentariosGen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_MontoTotalFactura);
            this.Controls.Add(this.txt_Impuesto);
            this.Controls.Add(this.txt_SubTotal);
            this.Controls.Add(this.GridProductos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_NombreCliente);
            this.Controls.Add(this.txt_idCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_fechaFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_numeroFactura);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("HP Simplified", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Factura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SISTEMA DE FACTURACION";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.TextBox txt_numeroFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txt_fechaFactura;
        private System.Windows.Forms.ToolStripButton btn_AddFactura;
        private System.Windows.Forms.ToolStripButton btn_SaveFactura;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.RadioButton rad_Contado;
        private System.Windows.Forms.RadioButton rad_Credito;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_idCliente;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView GridProductos;
        private System.Windows.Forms.TextBox txt_SubTotal;
        private System.Windows.Forms.TextBox txt_Impuesto;
        private System.Windows.Forms.TextBox txt_MontoTotalFactura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_ComentariosGen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_buscar_Cliente;
        private System.Windows.Forms.Button btn_AddItems;
        private System.Windows.Forms.Button btn_DeleteItems;
        private System.Windows.Forms.CheckBox chk_FacturaImpresa;
        private System.Windows.Forms.CheckBox chk_FacturaAnulada;
        private System.Windows.Forms.Button btn_buscar_factura;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_LoadFactura;
        private System.Windows.Forms.Button btn_LoadFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn products;
        private System.Windows.Forms.DataGridViewButtonColumn Search;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn imp;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
    }
}

