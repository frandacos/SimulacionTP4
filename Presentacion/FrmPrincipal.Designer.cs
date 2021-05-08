namespace SimulacionTP4.Presentacion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.chkDocenaCompra = new System.Windows.Forms.CheckBox();
            this.chkSinStock = new System.Windows.Forms.CheckBox();
            this.pnlSuperior = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.tablaProcedimiento = new System.Windows.Forms.DataGridView();
            this.txtPrecioReventa = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtPrecioVenta = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtPrecioCompra = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtCantidadDias = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtDiaDesde = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtIteraciones = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSinStock = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtDocenasCompra = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlDataGridView = new System.Windows.Forms.Panel();
            this.tablaCalculo = new System.Windows.Forms.DataGridView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.histograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcedimiento)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCalculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            this.btnCalcular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(0, 425);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(257, 54);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.ClickBtnCalcular);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(343, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Beneficio Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotal.Location = new System.Drawing.Point(457, 15);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 17);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "total";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(118, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Media:";
            // 
            // lblMedia
            // 
            this.lblMedia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMedia.AutoSize = true;
            this.lblMedia.Font = new System.Drawing.Font("SansSerif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.lblMedia.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMedia.Location = new System.Drawing.Point(178, 15);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(47, 17);
            this.lblMedia.TabIndex = 10;
            this.lblMedia.Text = "media";
            // 
            // chkDocenaCompra
            // 
            this.chkDocenaCompra.AutoSize = true;
            this.chkDocenaCompra.Location = new System.Drawing.Point(12, 19);
            this.chkDocenaCompra.Name = "chkDocenaCompra";
            this.chkDocenaCompra.Size = new System.Drawing.Size(15, 14);
            this.chkDocenaCompra.TabIndex = 12;
            this.chkDocenaCompra.UseVisualStyleBackColor = true;
            this.chkDocenaCompra.CheckedChanged += new System.EventHandler(this.ChkClickCompraDocena);
            // 
            // chkSinStock
            // 
            this.chkSinStock.AutoSize = true;
            this.chkSinStock.Location = new System.Drawing.Point(16, 22);
            this.chkSinStock.Name = "chkSinStock";
            this.chkSinStock.Size = new System.Drawing.Size(15, 14);
            this.chkSinStock.TabIndex = 14;
            this.chkSinStock.UseVisualStyleBackColor = true;
            this.chkSinStock.CheckedChanged += new System.EventHandler(this.chkSinStock_CheckedChanged);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.pnlSuperior.Controls.Add(this.logo);
            this.pnlSuperior.Controls.Add(this.lblTitulo);
            this.pnlSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSuperior.Location = new System.Drawing.Point(0, 0);
            this.pnlSuperior.Name = "pnlSuperior";
            this.pnlSuperior.Size = new System.Drawing.Size(828, 69);
            this.pnlSuperior.TabIndex = 17;
            // 
            // logo
            // 
            this.logo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logo.Image = global::SimulacionTP4.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(15, 17);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(35, 35);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 3;
            this.logo.TabStop = false;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(56, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(123, 25);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "TP4 Grupo 14";
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.pnlMenu.Controls.Add(this.tablaProcedimiento);
            this.pnlMenu.Controls.Add(this.txtPrecioReventa);
            this.pnlMenu.Controls.Add(this.txtPrecioVenta);
            this.pnlMenu.Controls.Add(this.txtPrecioCompra);
            this.pnlMenu.Controls.Add(this.txtCantidadDias);
            this.pnlMenu.Controls.Add(this.txtDiaDesde);
            this.pnlMenu.Controls.Add(this.txtIteraciones);
            this.pnlMenu.Controls.Add(this.btnCalcular);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.Location = new System.Drawing.Point(571, 69);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(257, 479);
            this.pnlMenu.TabIndex = 18;
            // 
            // tablaProcedimiento
            // 
            this.tablaProcedimiento.AllowUserToAddRows = false;
            this.tablaProcedimiento.AllowUserToDeleteRows = false;
            this.tablaProcedimiento.AllowUserToResizeColumns = false;
            this.tablaProcedimiento.AllowUserToResizeRows = false;
            this.tablaProcedimiento.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaProcedimiento.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.tablaProcedimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaProcedimiento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaProcedimiento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tablaProcedimiento.ColumnHeadersHeight = 50;
            this.tablaProcedimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaProcedimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaProcedimiento.EnableHeadersVisualStyles = false;
            this.tablaProcedimiento.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.tablaProcedimiento.Location = new System.Drawing.Point(0, 318);
            this.tablaProcedimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaProcedimiento.MultiSelect = false;
            this.tablaProcedimiento.Name = "tablaProcedimiento";
            this.tablaProcedimiento.ReadOnly = true;
            this.tablaProcedimiento.RowHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.tablaProcedimiento.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tablaProcedimiento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaProcedimiento.Size = new System.Drawing.Size(257, 107);
            this.tablaProcedimiento.TabIndex = 40;
            this.tablaProcedimiento.Visible = false;
            // 
            // txtPrecioReventa
            // 
            this.txtPrecioReventa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtPrecioReventa.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtPrecioReventa.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtPrecioReventa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPrecioReventa.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrecioReventa.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioReventa.ForeColor = System.Drawing.Color.White;
            this.txtPrecioReventa.Location = new System.Drawing.Point(0, 265);
            this.txtPrecioReventa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioReventa.Name = "txtPrecioReventa";
            this.txtPrecioReventa.Size = new System.Drawing.Size(257, 53);
            this.txtPrecioReventa.TabIndex = 12;
            this.txtPrecioReventa.Texto = "Precio Reventa:";
            this.txtPrecioReventa.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtPrecioReventa.Valor = 0;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtPrecioVenta.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtPrecioVenta.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtPrecioVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPrecioVenta.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrecioVenta.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.ForeColor = System.Drawing.Color.White;
            this.txtPrecioVenta.Location = new System.Drawing.Point(0, 212);
            this.txtPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(257, 53);
            this.txtPrecioVenta.TabIndex = 11;
            this.txtPrecioVenta.Texto = "Precio Venta:";
            this.txtPrecioVenta.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtPrecioVenta.Valor = 0;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtPrecioCompra.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtPrecioCompra.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtPrecioCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtPrecioCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.ForeColor = System.Drawing.Color.White;
            this.txtPrecioCompra.Location = new System.Drawing.Point(0, 159);
            this.txtPrecioCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(257, 53);
            this.txtPrecioCompra.TabIndex = 10;
            this.txtPrecioCompra.Texto = "Precio Compra:";
            this.txtPrecioCompra.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtPrecioCompra.Valor = 0;
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtCantidadDias.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtCantidadDias.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtCantidadDias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtCantidadDias.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtCantidadDias.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadDias.ForeColor = System.Drawing.Color.White;
            this.txtCantidadDias.Location = new System.Drawing.Point(0, 106);
            this.txtCantidadDias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(257, 53);
            this.txtCantidadDias.TabIndex = 9;
            this.txtCantidadDias.Texto = "Cantidad Días:";
            this.txtCantidadDias.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtCantidadDias.Valor = 0;
            // 
            // txtDiaDesde
            // 
            this.txtDiaDesde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDiaDesde.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDiaDesde.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtDiaDesde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDiaDesde.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDiaDesde.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaDesde.ForeColor = System.Drawing.Color.White;
            this.txtDiaDesde.Location = new System.Drawing.Point(0, 53);
            this.txtDiaDesde.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDiaDesde.Name = "txtDiaDesde";
            this.txtDiaDesde.Size = new System.Drawing.Size(257, 53);
            this.txtDiaDesde.TabIndex = 8;
            this.txtDiaDesde.Texto = "Día Desde:";
            this.txtDiaDesde.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtDiaDesde.Valor = 0;
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtIteraciones.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtIteraciones.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtIteraciones.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtIteraciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtIteraciones.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIteraciones.ForeColor = System.Drawing.Color.White;
            this.txtIteraciones.Location = new System.Drawing.Point(0, 0);
            this.txtIteraciones.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(257, 53);
            this.txtIteraciones.TabIndex = 7;
            this.txtIteraciones.Texto = "Iteraciones:";
            this.txtIteraciones.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtIteraciones.Valor = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSinStock);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.txtDocenasCompra);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 494);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 54);
            this.panel1.TabIndex = 19;
            // 
            // txtSinStock
            // 
            this.txtSinStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtSinStock.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtSinStock.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtSinStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSinStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSinStock.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinStock.ForeColor = System.Drawing.Color.White;
            this.txtSinStock.Location = new System.Drawing.Point(324, 0);
            this.txtSinStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSinStock.Name = "txtSinStock";
            this.txtSinStock.Size = new System.Drawing.Size(240, 54);
            this.txtSinStock.TabIndex = 17;
            this.txtSinStock.Texto = "Compra Mercaderia Faltante";
            this.txtSinStock.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtSinStock.Valor = 0;
            // 
            // txtDocenasCompra
            // 
            this.txtDocenasCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDocenasCompra.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDocenasCompra.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtDocenasCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDocenasCompra.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDocenasCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocenasCompra.ForeColor = System.Drawing.Color.White;
            this.txtDocenasCompra.Location = new System.Drawing.Point(37, 0);
            this.txtDocenasCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDocenasCompra.Name = "txtDocenasCompra";
            this.txtDocenasCompra.Size = new System.Drawing.Size(236, 54);
            this.txtDocenasCompra.TabIndex = 16;
            this.txtDocenasCompra.Texto = "Docenas Día Anterior";
            this.txtDocenasCompra.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtDocenasCompra.Valor = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lblMedia);
            this.panel2.Controls.Add(this.lblTotal);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 47);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 378);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(531, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(40, 378);
            this.panel4.TabIndex = 22;
            // 
            // pnlDataGridView
            // 
            this.pnlDataGridView.Controls.Add(this.tablaCalculo);
            this.pnlDataGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDataGridView.Location = new System.Drawing.Point(331, 116);
            this.pnlDataGridView.Name = "pnlDataGridView";
            this.pnlDataGridView.Size = new System.Drawing.Size(200, 378);
            this.pnlDataGridView.TabIndex = 23;
            // 
            // tablaCalculo
            // 
            this.tablaCalculo.AllowUserToAddRows = false;
            this.tablaCalculo.AllowUserToDeleteRows = false;
            this.tablaCalculo.AllowUserToResizeColumns = false;
            this.tablaCalculo.AllowUserToResizeRows = false;
            this.tablaCalculo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaCalculo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.tablaCalculo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tablaCalculo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tablaCalculo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tablaCalculo.ColumnHeadersHeight = 50;
            this.tablaCalculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tablaCalculo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablaCalculo.EnableHeadersVisualStyles = false;
            this.tablaCalculo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.tablaCalculo.Location = new System.Drawing.Point(0, 0);
            this.tablaCalculo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tablaCalculo.MultiSelect = false;
            this.tablaCalculo.Name = "tablaCalculo";
            this.tablaCalculo.ReadOnly = true;
            this.tablaCalculo.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.tablaCalculo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.tablaCalculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCalculo.Size = new System.Drawing.Size(200, 378);
            this.tablaCalculo.TabIndex = 40;
            this.tablaCalculo.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(315, 116);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(16, 378);
            this.splitter1.TabIndex = 39;
            this.splitter1.TabStop = false;
            // 
            // histograma
            // 
            chartArea1.Name = "ChartArea1";
            this.histograma.ChartAreas.Add(chartArea1);
            this.histograma.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.histograma.Legends.Add(legend1);
            this.histograma.Location = new System.Drawing.Point(40, 116);
            this.histograma.Name = "histograma";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.histograma.Series.Add(series1);
            this.histograma.Size = new System.Drawing.Size(275, 378);
            this.histograma.TabIndex = 16;
            this.histograma.Text = "Grafica De Media";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.panel5.Controls.Add(this.chkDocenaCompra);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(37, 54);
            this.panel5.TabIndex = 18;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.panel6.Controls.Add(this.chkSinStock);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(284, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(40, 54);
            this.panel6.TabIndex = 19;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(273, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(11, 54);
            this.panel7.TabIndex = 41;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(828, 548);
            this.Controls.Add(this.histograma);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.pnlDataGridView);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlSuperior);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP4 ";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaProcedimiento)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCalculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.CheckBox chkDocenaCompra;
        private System.Windows.Forms.CheckBox chkSinStock;
        private System.Windows.Forms.Panel pnlSuperior;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel panel1;
        private Controles.DatoTxtNum txtPrecioReventa;
        private Controles.DatoTxtNum txtPrecioVenta;
        private Controles.DatoTxtNum txtPrecioCompra;
        private Controles.DatoTxtNum txtCantidadDias;
        private Controles.DatoTxtNum txtDiaDesde;
        private Controles.DatoTxtNum txtIteraciones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlDataGridView;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.DataGridView tablaProcedimiento;
        private System.Windows.Forms.DataGridView tablaCalculo;
        private System.Windows.Forms.DataVisualization.Charting.Chart histograma;
        private Controles.DatoTxtNum txtSinStock;
        private Controles.DatoTxtNum txtDocenasCompra;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
    }
}