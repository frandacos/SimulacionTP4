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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
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
            this.txtSinStock = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtDocenasCompra = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPrecioReventa = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtPrecioVenta = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtPrecioCompra = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtCantidadDias = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtDiaDesde = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.txtIteraciones = new SimulacionTP4.Presentacion.Controles.DatoTxtNum();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLeft = new System.Windows.Forms.PictureBox();
            this.btnRight = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlTabla = new System.Windows.Forms.Panel();
            this.tablaCalculo = new System.Windows.Forms.DataGridView();
            this.histograma = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Dia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDClima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clima = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RNDDemanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadSobrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IngresosDiarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostoSobrante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GananciaDiaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GananciaAcumulada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Media = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.pnlCalcular = new System.Windows.Forms.Panel();
            this.pnlSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRight)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlTabla.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCalculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.pnlCalcular.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(165)))), ((int)(((byte)(142)))));
            this.btnCalcular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("SansSerif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnCalcular.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcular.Location = new System.Drawing.Point(0, 0);
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
            this.chkDocenaCompra.Location = new System.Drawing.Point(9, 21);
            this.chkDocenaCompra.Name = "chkDocenaCompra";
            this.chkDocenaCompra.Size = new System.Drawing.Size(15, 14);
            this.chkDocenaCompra.TabIndex = 12;
            this.chkDocenaCompra.UseVisualStyleBackColor = true;
            this.chkDocenaCompra.CheckedChanged += new System.EventHandler(this.ChkClickCompraDocena);
            // 
            // chkSinStock
            // 
            this.chkSinStock.AutoSize = true;
            this.chkSinStock.Location = new System.Drawing.Point(9, 20);
            this.chkSinStock.Name = "chkSinStock";
            this.chkSinStock.Size = new System.Drawing.Size(15, 14);
            this.chkSinStock.TabIndex = 14;
            this.chkSinStock.UseVisualStyleBackColor = true;
            this.chkSinStock.CheckedChanged += new System.EventHandler(this.chkSinStock_CheckedChanged);
            // 
            // pnlSuperior
            // 
            this.pnlSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(39)))), ((int)(((byte)(51)))));
            this.pnlSuperior.Controls.Add(this.btnMenu);
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
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.pnlMenu.Controls.Add(this.txtSinStock);
            this.pnlMenu.Controls.Add(this.txtDocenasCompra);
            this.pnlMenu.Controls.Add(this.panel8);
            this.pnlMenu.Controls.Add(this.pnlCalcular);
            this.pnlMenu.Controls.Add(this.txtPrecioReventa);
            this.pnlMenu.Controls.Add(this.txtPrecioVenta);
            this.pnlMenu.Controls.Add(this.txtPrecioCompra);
            this.pnlMenu.Controls.Add(this.txtCantidadDias);
            this.pnlMenu.Controls.Add(this.txtDiaDesde);
            this.pnlMenu.Controls.Add(this.txtIteraciones);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMenu.Location = new System.Drawing.Point(571, 69);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(257, 522);
            this.pnlMenu.TabIndex = 18;
            // 
            // txtSinStock
            // 
            this.txtSinStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtSinStock.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtSinStock.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtSinStock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtSinStock.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSinStock.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSinStock.ForeColor = System.Drawing.Color.White;
            this.txtSinStock.Location = new System.Drawing.Point(30, 372);
            this.txtSinStock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSinStock.Name = "txtSinStock";
            this.txtSinStock.Size = new System.Drawing.Size(227, 54);
            this.txtSinStock.TabIndex = 17;
            this.txtSinStock.Texto = "Compra Mercaderia Faltante";
            this.txtSinStock.TextoAyuda = "";
            this.txtSinStock.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtSinStock.Valor = 0;
            // 
            // txtDocenasCompra
            // 
            this.txtDocenasCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDocenasCompra.ColorFondo = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.txtDocenasCompra.ColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(70)))), ((int)(((byte)(87)))));
            this.txtDocenasCompra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtDocenasCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDocenasCompra.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDocenasCompra.ForeColor = System.Drawing.Color.White;
            this.txtDocenasCompra.Location = new System.Drawing.Point(30, 318);
            this.txtDocenasCompra.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDocenasCompra.Name = "txtDocenasCompra";
            this.txtDocenasCompra.Size = new System.Drawing.Size(227, 54);
            this.txtDocenasCompra.TabIndex = 16;
            this.txtDocenasCompra.Texto = "Docenas Día Anterior";
            this.txtDocenasCompra.TextoAyuda = "Francoooooooooooooooo";
            this.txtDocenasCompra.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtDocenasCompra.Valor = 0;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.panel8.Controls.Add(this.panel6);
            this.panel8.Controls.Add(this.panel5);
            this.panel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 318);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(30, 150);
            this.panel8.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.panel6.Controls.Add(this.chkSinStock);
            this.panel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 54);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(30, 54);
            this.panel6.TabIndex = 19;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(61)))), ((int)(((byte)(77)))));
            this.panel5.Controls.Add(this.chkDocenaCompra);
            this.panel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(30, 54);
            this.panel5.TabIndex = 18;
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
            this.txtPrecioReventa.TextoAyuda = "";
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
            this.txtPrecioVenta.TextoAyuda = "";
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
            this.txtPrecioCompra.TextoAyuda = "";
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
            this.txtCantidadDias.TextoAyuda = "";
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
            this.txtDiaDesde.TextoAyuda = "";
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
            this.txtIteraciones.TextoAyuda = "";
            this.txtIteraciones.TipoDato = SimulacionTP4.Presentacion.Controles.NumTextBox.TipoDato.Reales;
            this.txtIteraciones.Valor = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLeft);
            this.panel1.Controls.Add(this.btnRight);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 537);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 54);
            this.panel1.TabIndex = 19;
            // 
            // btnLeft
            // 
            this.btnLeft.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnLeft.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnLeft.Image")));
            this.btnLeft.Location = new System.Drawing.Point(261, 9);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(27, 33);
            this.btnLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnLeft.TabIndex = 1;
            this.btnLeft.TabStop = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRight.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRight.Image = ((System.Drawing.Image)(resources.GetObject("btnRight.Image")));
            this.btnRight.Location = new System.Drawing.Point(294, 9);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(27, 33);
            this.btnRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnRight.TabIndex = 0;
            this.btnRight.TabStop = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
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
            this.panel3.Size = new System.Drawing.Size(21, 421);
            this.panel3.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(548, 116);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(23, 421);
            this.panel4.TabIndex = 22;
            // 
            // pnlTabla
            // 
            this.pnlTabla.Controls.Add(this.histograma);
            this.pnlTabla.Controls.Add(this.tablaCalculo);
            this.pnlTabla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTabla.Location = new System.Drawing.Point(21, 116);
            this.pnlTabla.Name = "pnlTabla";
            this.pnlTabla.Size = new System.Drawing.Size(527, 421);
            this.pnlTabla.TabIndex = 23;
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
            this.tablaCalculo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dia,
            this.RNDClima,
            this.Clima,
            this.RNDDemanda,
            this.Demanda,
            this.CantidadVenta,
            this.CantidadSobrante,
            this.CantidadCompra,
            this.IngresosDiarios,
            this.CostoCompra,
            this.CostoSobrante,
            this.GananciaDiaria,
            this.GananciaAcumulada,
            this.Media});
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
            this.tablaCalculo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tablaCalculo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaCalculo.Size = new System.Drawing.Size(527, 421);
            this.tablaCalculo.TabIndex = 40;
            // 
            // histograma
            // 
            chartArea2.Name = "ChartArea1";
            this.histograma.ChartAreas.Add(chartArea2);
            this.histograma.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.histograma.Legends.Add(legend2);
            this.histograma.Location = new System.Drawing.Point(0, 0);
            this.histograma.Name = "histograma";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.histograma.Series.Add(series2);
            this.histograma.Size = new System.Drawing.Size(527, 421);
            this.histograma.TabIndex = 16;
            this.histograma.Text = "Grafica De Media";
            this.histograma.Visible = false;
            // 
            // Dia
            // 
            this.Dia.HeaderText = "Día";
            this.Dia.Name = "Dia";
            this.Dia.ReadOnly = true;
            // 
            // RNDClima
            // 
            this.RNDClima.HeaderText = "RND Clima";
            this.RNDClima.Name = "RNDClima";
            this.RNDClima.ReadOnly = true;
            // 
            // Clima
            // 
            this.Clima.HeaderText = "Clima";
            this.Clima.Name = "Clima";
            this.Clima.ReadOnly = true;
            // 
            // RNDDemanda
            // 
            this.RNDDemanda.HeaderText = "RND Demanda";
            this.RNDDemanda.Name = "RNDDemanda";
            this.RNDDemanda.ReadOnly = true;
            // 
            // Demanda
            // 
            this.Demanda.HeaderText = "Demanda";
            this.Demanda.Name = "Demanda";
            this.Demanda.ReadOnly = true;
            // 
            // CantidadVenta
            // 
            this.CantidadVenta.HeaderText = "Cantidad Venta";
            this.CantidadVenta.Name = "CantidadVenta";
            this.CantidadVenta.ReadOnly = true;
            // 
            // CantidadSobrante
            // 
            this.CantidadSobrante.HeaderText = "Cantidad Sobrante";
            this.CantidadSobrante.Name = "CantidadSobrante";
            this.CantidadSobrante.ReadOnly = true;
            // 
            // CantidadCompra
            // 
            this.CantidadCompra.HeaderText = "Cantidad Compra";
            this.CantidadCompra.Name = "CantidadCompra";
            this.CantidadCompra.ReadOnly = true;
            // 
            // IngresosDiarios
            // 
            this.IngresosDiarios.HeaderText = "Ingresos Diarios";
            this.IngresosDiarios.Name = "IngresosDiarios";
            this.IngresosDiarios.ReadOnly = true;
            // 
            // CostoCompra
            // 
            this.CostoCompra.HeaderText = "Costo Compra";
            this.CostoCompra.Name = "CostoCompra";
            this.CostoCompra.ReadOnly = true;
            // 
            // CostoSobrante
            // 
            this.CostoSobrante.HeaderText = "Costo Sobrante";
            this.CostoSobrante.Name = "CostoSobrante";
            this.CostoSobrante.ReadOnly = true;
            // 
            // GananciaDiaria
            // 
            this.GananciaDiaria.HeaderText = "Ganancia Diaria";
            this.GananciaDiaria.Name = "GananciaDiaria";
            this.GananciaDiaria.ReadOnly = true;
            // 
            // GananciaAcumulada
            // 
            this.GananciaAcumulada.HeaderText = "Ganancia Acumulada";
            this.GananciaAcumulada.Name = "GananciaAcumulada";
            this.GananciaAcumulada.ReadOnly = true;
            // 
            // Media
            // 
            this.Media.HeaderText = "Media";
            this.Media.Name = "Media";
            this.Media.ReadOnly = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(789, 17);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(27, 33);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnMenu.TabIndex = 2;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnlCalcular
            // 
            this.pnlCalcular.Controls.Add(this.btnCalcular);
            this.pnlCalcular.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCalcular.Location = new System.Drawing.Point(0, 468);
            this.pnlCalcular.Name = "pnlCalcular";
            this.pnlCalcular.Size = new System.Drawing.Size(257, 54);
            this.pnlCalcular.TabIndex = 20;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(49)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(828, 591);
            this.Controls.Add(this.pnlTabla);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlSuperior);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP4 ";
            this.pnlSuperior.ResumeLayout(false);
            this.pnlSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRight)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlTabla.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCalculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histograma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.pnlCalcular.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnlTabla;
        private System.Windows.Forms.DataGridView tablaCalculo;
        private System.Windows.Forms.DataVisualization.Charting.Chart histograma;
        private Controles.DatoTxtNum txtSinStock;
        private Controles.DatoTxtNum txtDocenasCompra;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox btnLeft;
        private System.Windows.Forms.PictureBox btnRight;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dia;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDClima;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clima;
        private System.Windows.Forms.DataGridViewTextBoxColumn RNDDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn Demanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadSobrante;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn IngresosDiarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostoSobrante;
        private System.Windows.Forms.DataGridViewTextBoxColumn GananciaDiaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn GananciaAcumulada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Media;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel pnlCalcular;
    }
}