
namespace COVENTAF.PuntoVenta
{
    partial class frmRetenciones
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRetenciones));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblTotalRetenciones = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.dgvDetalleRetenciones = new System.Windows.Forms.DataGridView();
            this.Retencion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AutoRetenedora = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cboRetenciones = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.btnEliminarProductos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.barraTitulo.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRetenciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 447);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(597, 4);
            this.panel3.TabIndex = 150;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(588, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(9, 447);
            this.panel2.TabIndex = 151;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 447);
            this.panel1.TabIndex = 152;
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.barraTitulo.Controls.Add(this.btnCerrar);
            this.barraTitulo.Controls.Add(this.pictureBox1);
            this.barraTitulo.Controls.Add(this.lblTitulo);
            this.barraTitulo.Cursor = System.Windows.Forms.Cursors.Default;
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(4, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(584, 28);
            this.barraTitulo.TabIndex = 153;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lblTitulo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.Location = new System.Drawing.Point(12, 4);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(106, 21);
            this.lblTitulo.TabIndex = 8;
            this.lblTitulo.Text = "Retenciones";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Silver;
            this.panel4.Controls.Add(this.btnEliminar);
            this.panel4.Controls.Add(this.btnCancelar);
            this.panel4.Controls.Add(this.BtnAceptar);
            this.panel4.Controls.Add(this.lblTotalRetenciones);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(4, 291);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(584, 156);
            this.panel4.TabIndex = 154;
            // 
            // lblTotalRetenciones
            // 
            this.lblTotalRetenciones.AutoSize = true;
            this.lblTotalRetenciones.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.lblTotalRetenciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(178)))));
            this.lblTotalRetenciones.Location = new System.Drawing.Point(291, 24);
            this.lblTotalRetenciones.Name = "lblTotalRetenciones";
            this.lblTotalRetenciones.Size = new System.Drawing.Size(141, 18);
            this.lblTotalRetenciones.TabIndex = 206;
            this.lblTotalRetenciones.Text = "Total Retenciones:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(13)))), ((int)(((byte)(66)))));
            this.panel5.Controls.Add(this.pictureBox26);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.label20);
            this.panel5.Controls.Add(this.pictureBox11);
            this.panel5.Controls.Add(this.btnEliminarProductos);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(4, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(584, 55);
            this.panel5.TabIndex = 155;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Gold;
            this.label10.Location = new System.Drawing.Point(22, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 30);
            this.label10.TabIndex = 140;
            this.label10.Text = "COVENTAF";
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold);
            this.label20.ForeColor = System.Drawing.Color.SeaShell;
            this.label20.Location = new System.Drawing.Point(39, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(122, 23);
            this.label20.TabIndex = 141;
            this.label20.Text = "Retenciones";
            // 
            // dgvDetalleRetenciones
            // 
            this.dgvDetalleRetenciones.AllowUserToAddRows = false;
            this.dgvDetalleRetenciones.AllowUserToDeleteRows = false;
            this.dgvDetalleRetenciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetalleRetenciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetalleRetenciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDetalleRetenciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dgvDetalleRetenciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetalleRetenciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.DarkGoldenrod;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(24)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleRetenciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDetalleRetenciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Retencion,
            this.Descripcion,
            this.Monto,
            this.Base,
            this.Referencia,
            this.AutoRetenedora});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.NavajoWhite;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetalleRetenciones.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvDetalleRetenciones.EnableHeadersVisualStyles = false;
            this.dgvDetalleRetenciones.GridColor = System.Drawing.Color.Maroon;
            this.dgvDetalleRetenciones.Location = new System.Drawing.Point(4, 136);
            this.dgvDetalleRetenciones.Name = "dgvDetalleRetenciones";
            this.dgvDetalleRetenciones.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Sienna;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetalleRetenciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvDetalleRetenciones.RowTemplate.Height = 25;
            this.dgvDetalleRetenciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleRetenciones.Size = new System.Drawing.Size(584, 158);
            this.dgvDetalleRetenciones.TabIndex = 156;
            // 
            // Retencion
            // 
            this.Retencion.HeaderText = "Retencion";
            this.Retencion.Name = "Retencion";
            this.Retencion.ReadOnly = true;
            this.Retencion.Width = 94;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 105;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            this.Monto.Width = 74;
            // 
            // Base
            // 
            this.Base.HeaderText = "Base";
            this.Base.Name = "Base";
            this.Base.ReadOnly = true;
            this.Base.Width = 61;
            // 
            // Referencia
            // 
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            this.Referencia.ReadOnly = true;
            this.Referencia.Width = 97;
            // 
            // AutoRetenedora
            // 
            this.AutoRetenedora.HeaderText = "AutoRetenedora";
            this.AutoRetenedora.Name = "AutoRetenedora";
            this.AutoRetenedora.ReadOnly = true;
            this.AutoRetenedora.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.AutoRetenedora.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.AutoRetenedora.Width = 133;
            // 
            // cboRetenciones
            // 
            this.cboRetenciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRetenciones.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboRetenciones.FormattingEnabled = true;
            this.cboRetenciones.Location = new System.Drawing.Point(179, 96);
            this.cboRetenciones.Name = "cboRetenciones";
            this.cboRetenciones.Size = new System.Drawing.Size(277, 29);
            this.cboRetenciones.TabIndex = 157;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(77)))), ((int)(((byte)(178)))));
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 18);
            this.label1.TabIndex = 207;
            this.label1.Text = "Lista de retenciones:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(92)))), ((int)(((byte)(133)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(50)))), ((int)(((byte)(97)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnAgregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnAgregar.Location = new System.Drawing.Point(483, 90);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(98, 36);
            this.btnAgregar.TabIndex = 208;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pictureBox26
            // 
            this.pictureBox26.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox26.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox26.Image = global::COVENTAF.Properties.Resources.logo;
            this.pictureBox26.Location = new System.Drawing.Point(1444, 3);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(340, 48);
            this.pictureBox26.TabIndex = 143;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox11.Image = global::COVENTAF.Properties.Resources.logo;
            this.pictureBox11.Location = new System.Drawing.Point(2138, 2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(351, 48);
            this.pictureBox11.TabIndex = 142;
            this.pictureBox11.TabStop = false;
            // 
            // btnEliminarProductos
            // 
            this.btnEliminarProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarProductos.BackColor = System.Drawing.Color.Silver;
            this.btnEliminarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProductos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminarProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarProductos.Image")));
            this.btnEliminarProductos.Location = new System.Drawing.Point(1226, 4);
            this.btnEliminarProductos.Name = "btnEliminarProductos";
            this.btnEliminarProductos.Size = new System.Drawing.Size(47, 43);
            this.btnEliminarProductos.TabIndex = 125;
            this.btnEliminarProductos.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Maroon;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(92)))), ((int)(((byte)(133)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(50)))), ((int)(((byte)(97)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnEliminar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnEliminar.Image = global::COVENTAF.Properties.Resources.borrar;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnEliminar.Location = new System.Drawing.Point(5, 14);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 36);
            this.btnEliminar.TabIndex = 209;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(92)))), ((int)(((byte)(133)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(50)))), ((int)(((byte)(97)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.Image = global::COVENTAF.Properties.Resources.cancelar;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnCancelar.Location = new System.Drawing.Point(457, 98);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 44);
            this.btnCancelar.TabIndex = 208;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(50)))), ((int)(((byte)(124)))));
            this.BtnAceptar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(92)))), ((int)(((byte)(133)))));
            this.BtnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(50)))), ((int)(((byte)(97)))));
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAceptar.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F);
            this.BtnAceptar.ForeColor = System.Drawing.Color.Gainsboro;
            this.BtnAceptar.Image = global::COVENTAF.Properties.Resources.comprobado;
            this.BtnAceptar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.BtnAceptar.Location = new System.Drawing.Point(343, 98);
            this.BtnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(98, 44);
            this.BtnAceptar.TabIndex = 207;
            this.BtnAceptar.Text = "&Aceptar";
            this.BtnAceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnAceptar.UseVisualStyleBackColor = false;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::COVENTAF.Properties.Resources.close_login;
            this.btnCerrar.Location = new System.Drawing.Point(1210, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(21, 21);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 80;
            this.btnCerrar.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::COVENTAF.Properties.Resources.close_login;
            this.pictureBox1.Location = new System.Drawing.Point(3984, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // frmRetenciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(597, 451);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboRetenciones);
            this.Controls.Add(this.dgvDetalleRetenciones);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.barraTitulo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRetenciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Retenciones";
            this.Load += new System.EventHandler(this.frmRetenciones_Load);
            this.barraTitulo.ResumeLayout(false);
            this.barraTitulo.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleRetenciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox26;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.Button btnEliminarProductos;
        private System.Windows.Forms.DataGridView dgvDetalleRetenciones;
        private System.Windows.Forms.Label lblTotalRetenciones;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.ComboBox cboRetenciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Retencion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Base;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AutoRetenedora;
    }
}