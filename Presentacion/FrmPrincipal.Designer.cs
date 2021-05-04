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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.txtIteraciones = new System.Windows.Forms.TextBox();
            this.txtDiaDesde = new System.Windows.Forms.TextBox();
            this.txtCantidadDias = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioReventa = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.tablaCalculo = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMedia = new System.Windows.Forms.Label();
            this.chkDocenaCompra = new System.Windows.Forms.CheckBox();
            this.txtDocenasCompra = new System.Windows.Forms.TextBox();
            this.chkSinStock = new System.Windows.Forms.CheckBox();
            this.txtSinStock = new System.Windows.Forms.TextBox();
            this.graficaMedia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.tablaCalculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficaMedia)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIteraciones
            // 
            this.txtIteraciones.Location = new System.Drawing.Point(660, 32);
            this.txtIteraciones.MaxLength = 9;
            this.txtIteraciones.Name = "txtIteraciones";
            this.txtIteraciones.Size = new System.Drawing.Size(100, 20);
            this.txtIteraciones.TabIndex = 0;
            // 
            // txtDiaDesde
            // 
            this.txtDiaDesde.Location = new System.Drawing.Point(660, 89);
            this.txtDiaDesde.MaxLength = 9;
            this.txtDiaDesde.Name = "txtDiaDesde";
            this.txtDiaDesde.Size = new System.Drawing.Size(100, 20);
            this.txtDiaDesde.TabIndex = 1;
            // 
            // txtCantidadDias
            // 
            this.txtCantidadDias.Location = new System.Drawing.Point(660, 146);
            this.txtCantidadDias.MaxLength = 9;
            this.txtCantidadDias.Name = "txtCantidadDias";
            this.txtCantidadDias.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadDias.TabIndex = 2;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(660, 203);
            this.txtPrecioCompra.MaxLength = 9;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioCompra.TabIndex = 3;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(660, 260);
            this.txtPrecioVenta.MaxLength = 9;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioVenta.TabIndex = 4;
            // 
            // txtPrecioReventa
            // 
            this.txtPrecioReventa.Location = new System.Drawing.Point(660, 317);
            this.txtPrecioReventa.MaxLength = 9;
            this.txtPrecioReventa.Name = "txtPrecioReventa";
            this.txtPrecioReventa.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioReventa.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(675, 372);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(85, 45);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.ClickBtnCalcular);
            // 
            // tablaCalculo
            // 
            this.tablaCalculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaCalculo.Location = new System.Drawing.Point(39, 146);
            this.tablaCalculo.Name = "tablaCalculo";
            this.tablaCalculo.Size = new System.Drawing.Size(254, 225);
            this.tablaCalculo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Beneficio Total:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(154, 75);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(27, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Media:";
            // 
            // lblMedia
            // 
            this.lblMedia.AutoSize = true;
            this.lblMedia.Location = new System.Drawing.Point(405, 75);
            this.lblMedia.Name = "lblMedia";
            this.lblMedia.Size = new System.Drawing.Size(35, 13);
            this.lblMedia.TabIndex = 10;
            this.lblMedia.Text = "media";
            // 
            // chkDocenaCompra
            // 
            this.chkDocenaCompra.AutoSize = true;
            this.chkDocenaCompra.Location = new System.Drawing.Point(39, 400);
            this.chkDocenaCompra.Name = "chkDocenaCompra";
            this.chkDocenaCompra.Size = new System.Drawing.Size(126, 17);
            this.chkDocenaCompra.TabIndex = 12;
            this.chkDocenaCompra.Text = "Docenas Dia anterior";
            this.chkDocenaCompra.UseVisualStyleBackColor = true;
            this.chkDocenaCompra.CheckedChanged += new System.EventHandler(this.ChkClickCompraDocena);
            // 
            // txtDocenasCompra
            // 
            this.txtDocenasCompra.Location = new System.Drawing.Point(193, 397);
            this.txtDocenasCompra.MaxLength = 9;
            this.txtDocenasCompra.Name = "txtDocenasCompra";
            this.txtDocenasCompra.Size = new System.Drawing.Size(100, 20);
            this.txtDocenasCompra.TabIndex = 13;
            // 
            // chkSinStock
            // 
            this.chkSinStock.AutoSize = true;
            this.chkSinStock.Location = new System.Drawing.Point(318, 399);
            this.chkSinStock.Name = "chkSinStock";
            this.chkSinStock.Size = new System.Drawing.Size(162, 17);
            this.chkSinStock.TabIndex = 14;
            this.chkSinStock.Text = "Comprar Mercaderia Faltante";
            this.chkSinStock.UseVisualStyleBackColor = true;
            this.chkSinStock.CheckedChanged += new System.EventHandler(this.chkSinStock_CheckedChanged);
            // 
            // txtSinStock
            // 
            this.txtSinStock.Location = new System.Drawing.Point(518, 396);
            this.txtSinStock.MaxLength = 9;
            this.txtSinStock.Name = "txtSinStock";
            this.txtSinStock.Size = new System.Drawing.Size(100, 20);
            this.txtSinStock.TabIndex = 15;
            // 
            // graficaMedia
            // 
            chartArea1.Name = "ChartArea1";
            this.graficaMedia.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficaMedia.Legends.Add(legend1);
            this.graficaMedia.Location = new System.Drawing.Point(318, 149);
            this.graficaMedia.Name = "graficaMedia";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficaMedia.Series.Add(series1);
            this.graficaMedia.Size = new System.Drawing.Size(300, 222);
            this.graficaMedia.TabIndex = 16;
            this.graficaMedia.Text = "Grafica De Media";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.graficaMedia);
            this.Controls.Add(this.txtSinStock);
            this.Controls.Add(this.chkSinStock);
            this.Controls.Add(this.txtDocenasCompra);
            this.Controls.Add(this.chkDocenaCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblMedia);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tablaCalculo);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPrecioReventa);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtCantidadDias);
            this.Controls.Add(this.txtDiaDesde);
            this.Controls.Add(this.txtIteraciones);
            this.Name = "FrmPrincipal";
            this.Text = "FrmPrincipal";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaCalculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficaMedia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIteraciones;
        private System.Windows.Forms.TextBox txtDiaDesde;
        private System.Windows.Forms.TextBox txtCantidadDias;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.TextBox txtPrecioReventa;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridView tablaCalculo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMedia;
        private System.Windows.Forms.CheckBox chkDocenaCompra;
        private System.Windows.Forms.TextBox txtDocenasCompra;
        private System.Windows.Forms.CheckBox chkSinStock;
        private System.Windows.Forms.TextBox txtSinStock;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficaMedia;
    }
}