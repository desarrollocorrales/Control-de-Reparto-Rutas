namespace Rutas_Control_de_Reparto.GUIs
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConfigurar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.gridReporte = new DevExpress.XtraGrid.GridControl();
            this.reporteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gvReporte = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFolioControl = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClaveCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombreCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumExterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNumInterior = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colColonia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFolioFactura = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colImporte = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChofer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.bgwProceso = new System.ComponentModel.BackgroundWorker();
            this.pbLoading = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(494, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rutas del día del control de reparto";
            // 
            // btnConfigurar
            // 
            this.btnConfigurar.Location = new System.Drawing.Point(12, 12);
            this.btnConfigurar.Name = "btnConfigurar";
            this.btnConfigurar.Size = new System.Drawing.Size(110, 33);
            this.btnConfigurar.TabIndex = 1;
            this.btnConfigurar.Text = "Configuración";
            this.btnConfigurar.UseVisualStyleBackColor = true;
            this.btnConfigurar.Click += new System.EventHandler(this.btnConfigurar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFecha.CustomFormat = "dd/MMMM/yyyy";
            this.dtpFecha.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(382, 48);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 27);
            this.dtpFecha.TabIndex = 3;
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCargarDatos.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargarDatos.Location = new System.Drawing.Point(588, 48);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(75, 27);
            this.btnCargarDatos.TabIndex = 4;
            this.btnCargarDatos.Text = "Cargar";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // gridReporte
            // 
            this.gridReporte.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridReporte.DataSource = this.reporteBindingSource;
            this.gridReporte.Location = new System.Drawing.Point(12, 81);
            this.gridReporte.MainView = this.gvReporte;
            this.gridReporte.Name = "gridReporte";
            this.gridReporte.Size = new System.Drawing.Size(960, 400);
            this.gridReporte.TabIndex = 5;
            this.gridReporte.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvReporte});
            // 
            // reporteBindingSource
            // 
            this.reporteBindingSource.DataSource = typeof(Rutas_Control_de_Reparto.Modelos.Reporte);
            // 
            // gvReporte
            // 
            this.gvReporte.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.Silver;
            this.gvReporte.Appearance.ColumnFilterButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvReporte.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.Silver;
            this.gvReporte.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.Gray;
            this.gvReporte.Appearance.ColumnFilterButton.Options.UseBackColor = true;
            this.gvReporte.Appearance.ColumnFilterButton.Options.UseBorderColor = true;
            this.gvReporte.Appearance.ColumnFilterButton.Options.UseForeColor = true;
            this.gvReporte.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvReporte.Appearance.ColumnFilterButtonActive.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvReporte.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(212)))), ((int)(((byte)(212)))));
            this.gvReporte.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.Blue;
            this.gvReporte.Appearance.ColumnFilterButtonActive.Options.UseBackColor = true;
            this.gvReporte.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = true;
            this.gvReporte.Appearance.ColumnFilterButtonActive.Options.UseForeColor = true;
            this.gvReporte.Appearance.Empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gvReporte.Appearance.Empty.Options.UseBackColor = true;
            this.gvReporte.Appearance.EvenRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.gvReporte.Appearance.EvenRow.BackColor2 = System.Drawing.Color.GhostWhite;
            this.gvReporte.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.EvenRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvReporte.Appearance.EvenRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.EvenRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvReporte.Appearance.FilterCloseButton.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(170)))), ((int)(((byte)(225)))));
            this.gvReporte.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvReporte.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.FilterCloseButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvReporte.Appearance.FilterCloseButton.Options.UseBackColor = true;
            this.gvReporte.Appearance.FilterCloseButton.Options.UseBorderColor = true;
            this.gvReporte.Appearance.FilterCloseButton.Options.UseForeColor = true;
            this.gvReporte.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(80)))), ((int)(((byte)(135)))));
            this.gvReporte.Appearance.FilterPanel.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvReporte.Appearance.FilterPanel.ForeColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.FilterPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gvReporte.Appearance.FilterPanel.Options.UseBackColor = true;
            this.gvReporte.Appearance.FilterPanel.Options.UseForeColor = true;
            this.gvReporte.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.gvReporte.Appearance.FixedLine.Options.UseBackColor = true;
            this.gvReporte.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(225)))));
            this.gvReporte.Appearance.FocusedCell.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.FocusedCell.Options.UseBackColor = true;
            this.gvReporte.Appearance.FocusedCell.Options.UseForeColor = true;
            this.gvReporte.Appearance.FocusedRow.BackColor = System.Drawing.Color.Navy;
            this.gvReporte.Appearance.FocusedRow.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(178)))));
            this.gvReporte.Appearance.FocusedRow.ForeColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.FocusedRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.FocusedRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.FooterPanel.BackColor = System.Drawing.Color.Silver;
            this.gvReporte.Appearance.FooterPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvReporte.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.FooterPanel.Options.UseBackColor = true;
            this.gvReporte.Appearance.FooterPanel.Options.UseBorderColor = true;
            this.gvReporte.Appearance.FooterPanel.Options.UseForeColor = true;
            this.gvReporte.Appearance.GroupButton.BackColor = System.Drawing.Color.Silver;
            this.gvReporte.Appearance.GroupButton.BorderColor = System.Drawing.Color.Silver;
            this.gvReporte.Appearance.GroupButton.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.GroupButton.Options.UseBackColor = true;
            this.gvReporte.Appearance.GroupButton.Options.UseBorderColor = true;
            this.gvReporte.Appearance.GroupButton.Options.UseForeColor = true;
            this.gvReporte.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvReporte.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(202)))), ((int)(((byte)(202)))));
            this.gvReporte.Appearance.GroupFooter.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.GroupFooter.Options.UseBackColor = true;
            this.gvReporte.Appearance.GroupFooter.Options.UseBorderColor = true;
            this.gvReporte.Appearance.GroupFooter.Options.UseForeColor = true;
            this.gvReporte.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(110)))), ((int)(((byte)(165)))));
            this.gvReporte.Appearance.GroupPanel.BackColor2 = System.Drawing.Color.White;
            this.gvReporte.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvReporte.Appearance.GroupPanel.ForeColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.GroupPanel.Options.UseBackColor = true;
            this.gvReporte.Appearance.GroupPanel.Options.UseFont = true;
            this.gvReporte.Appearance.GroupPanel.Options.UseForeColor = true;
            this.gvReporte.Appearance.GroupRow.BackColor = System.Drawing.Color.Gray;
            this.gvReporte.Appearance.GroupRow.ForeColor = System.Drawing.Color.Silver;
            this.gvReporte.Appearance.GroupRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.GroupRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.HeaderPanel.BackColor = System.Drawing.Color.Silver;
            this.gvReporte.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.Silver;
            this.gvReporte.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.gvReporte.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.HeaderPanel.Options.UseBackColor = true;
            this.gvReporte.Appearance.HeaderPanel.Options.UseBorderColor = true;
            this.gvReporte.Appearance.HeaderPanel.Options.UseFont = true;
            this.gvReporte.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gvReporte.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.Gray;
            this.gvReporte.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(208)))), ((int)(((byte)(200)))));
            this.gvReporte.Appearance.HideSelectionRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.HideSelectionRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.HorzLine.BackColor = System.Drawing.Color.Silver;
            this.gvReporte.Appearance.HorzLine.Options.UseBackColor = true;
            this.gvReporte.Appearance.OddRow.BackColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.OddRow.BackColor2 = System.Drawing.Color.White;
            this.gvReporte.Appearance.OddRow.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.OddRow.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gvReporte.Appearance.OddRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.OddRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.Preview.BackColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.Preview.ForeColor = System.Drawing.Color.Navy;
            this.gvReporte.Appearance.Preview.Options.UseBackColor = true;
            this.gvReporte.Appearance.Preview.Options.UseForeColor = true;
            this.gvReporte.Appearance.Row.BackColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.Row.ForeColor = System.Drawing.Color.Black;
            this.gvReporte.Appearance.Row.Options.UseBackColor = true;
            this.gvReporte.Appearance.Row.Options.UseForeColor = true;
            this.gvReporte.Appearance.RowSeparator.BackColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gvReporte.Appearance.RowSeparator.Options.UseBackColor = true;
            this.gvReporte.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(138)))));
            this.gvReporte.Appearance.SelectedRow.ForeColor = System.Drawing.Color.White;
            this.gvReporte.Appearance.SelectedRow.Options.UseBackColor = true;
            this.gvReporte.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvReporte.Appearance.VertLine.BackColor = System.Drawing.Color.Silver;
            this.gvReporte.Appearance.VertLine.Options.UseBackColor = true;
            this.gvReporte.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFolioControl,
            this.colClaveCliente,
            this.colNombreCliente,
            this.colCalle,
            this.colNumExterior,
            this.colNumInterior,
            this.colColonia,
            this.colCP,
            this.colFolioFactura,
            this.colImporte,
            this.colChofer});
            this.gvReporte.GridControl = this.gridReporte;
            this.gvReporte.GroupCount = 3;
            this.gvReporte.Name = "gvReporte";
            this.gvReporte.OptionsBehavior.Editable = false;
            this.gvReporte.OptionsPrint.UsePrintStyles = true;
            this.gvReporte.OptionsView.EnableAppearanceEvenRow = true;
            this.gvReporte.OptionsView.EnableAppearanceOddRow = true;
            this.gvReporte.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFolioControl, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCP, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colNombreCliente, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvReporte.EndGrouping += new System.EventHandler(this.gvReporte_EndGrouping);
            // 
            // colFolioControl
            // 
            this.colFolioControl.FieldName = "FolioControl";
            this.colFolioControl.Name = "colFolioControl";
            // 
            // colClaveCliente
            // 
            this.colClaveCliente.FieldName = "ClaveCliente";
            this.colClaveCliente.Name = "colClaveCliente";
            this.colClaveCliente.Visible = true;
            this.colClaveCliente.VisibleIndex = 0;
            this.colClaveCliente.Width = 104;
            // 
            // colNombreCliente
            // 
            this.colNombreCliente.FieldName = "NombreCliente";
            this.colNombreCliente.Name = "colNombreCliente";
            // 
            // colCalle
            // 
            this.colCalle.FieldName = "Calle";
            this.colCalle.Name = "colCalle";
            this.colCalle.Visible = true;
            this.colCalle.VisibleIndex = 1;
            // 
            // colNumExterior
            // 
            this.colNumExterior.Caption = "# Ext";
            this.colNumExterior.FieldName = "NumExterior";
            this.colNumExterior.Name = "colNumExterior";
            this.colNumExterior.Visible = true;
            this.colNumExterior.VisibleIndex = 2;
            // 
            // colNumInterior
            // 
            this.colNumInterior.Caption = "# Int";
            this.colNumInterior.FieldName = "NumInterior";
            this.colNumInterior.Name = "colNumInterior";
            this.colNumInterior.Visible = true;
            this.colNumInterior.VisibleIndex = 3;
            // 
            // colColonia
            // 
            this.colColonia.FieldName = "Colonia";
            this.colColonia.Name = "colColonia";
            this.colColonia.Visible = true;
            this.colColonia.VisibleIndex = 4;
            // 
            // colCP
            // 
            this.colCP.FieldName = "CP";
            this.colCP.Name = "colCP";
            // 
            // colFolioFactura
            // 
            this.colFolioFactura.FieldName = "FolioFactura";
            this.colFolioFactura.Name = "colFolioFactura";
            this.colFolioFactura.Visible = true;
            this.colFolioFactura.VisibleIndex = 5;
            // 
            // colImporte
            // 
            this.colImporte.DisplayFormat.FormatString = "c";
            this.colImporte.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colImporte.FieldName = "Importe";
            this.colImporte.Name = "colImporte";
            this.colImporte.Visible = true;
            this.colImporte.VisibleIndex = 6;
            // 
            // colChofer
            // 
            this.colChofer.FieldName = "Chofer";
            this.colChofer.Name = "colChofer";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnImprimir.Location = new System.Drawing.Point(447, 487);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(90, 28);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // bgwProceso
            // 
            this.bgwProceso.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwProceso_DoWork);
            this.bgwProceso.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwProceso_RunWorkerCompleted);
            // 
            // pbLoading
            // 
            this.pbLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbLoading.Image = global::Rutas_Control_de_Reparto.Properties.Resources.loading;
            this.pbLoading.Location = new System.Drawing.Point(266, 92);
            this.pbLoading.Name = "pbLoading";
            this.pbLoading.Size = new System.Drawing.Size(453, 342);
            this.pbLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLoading.TabIndex = 7;
            this.pbLoading.TabStop = false;
            this.pbLoading.Visible = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(984, 527);
            this.Controls.Add(this.pbLoading);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.gridReporte);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnConfigurar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Rutas - Control de Reparto";
            ((System.ComponentModel.ISupportInitialize)(this.gridReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reporteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConfigurar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button btnCargarDatos;
        private DevExpress.XtraGrid.GridControl gridReporte;
        private DevExpress.XtraGrid.Views.Grid.GridView gvReporte;
        private System.Windows.Forms.BindingSource reporteBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colNombreCliente;
        private System.Windows.Forms.Button btnImprimir;
        private DevExpress.XtraGrid.Columns.GridColumn colCalle;
        private DevExpress.XtraGrid.Columns.GridColumn colNumExterior;
        private DevExpress.XtraGrid.Columns.GridColumn colNumInterior;
        private DevExpress.XtraGrid.Columns.GridColumn colColonia;
        private DevExpress.XtraGrid.Columns.GridColumn colCP;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioControl;
        private DevExpress.XtraGrid.Columns.GridColumn colClaveCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colFolioFactura;
        private DevExpress.XtraGrid.Columns.GridColumn colImporte;
        private System.ComponentModel.BackgroundWorker bgwProceso;
        private System.Windows.Forms.PictureBox pbLoading;
        private DevExpress.XtraGrid.Columns.GridColumn colChofer;
    }
}