namespace PJ.Inf.ApplicantAssistance.Win
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            txtPlaza = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            txtDependencia2 = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            lblNoAsistentes = new Label();
            lblAsistentes = new Label();
            label1 = new Label();
            materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            txtNombres = new MaterialSkin.Controls.MaterialTextBox2();
            txtApellidos = new MaterialSkin.Controls.MaterialTextBox2();
            txtDni = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            txtDniBuscado = new MaterialSkin.Controls.MaterialTextBox2();
            materialCard2 = new MaterialSkin.Controls.MaterialCard();
            dgvBusqueda = new DataGridView();
            txtBusqueda = new MaterialSkin.Controls.MaterialTextBox2();
            materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            statusStrip1 = new StatusStrip();
            toolStripProgressBar1 = new ToolStripProgressBar();
            ID = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ParAula = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            materialCard1.SuspendLayout();
            materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(materialCard1, 0, 0);
            tableLayoutPanel1.Controls.Add(materialCard2, 1, 0);
            tableLayoutPanel1.Controls.Add(statusStrip1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 85);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            tableLayoutPanel1.Size = new Size(1463, 831);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(txtPlaza);
            materialCard1.Controls.Add(txtDependencia2);
            materialCard1.Controls.Add(lblNoAsistentes);
            materialCard1.Controls.Add(lblAsistentes);
            materialCard1.Controls.Add(label1);
            materialCard1.Controls.Add(materialLabel10);
            materialCard1.Controls.Add(materialLabel7);
            materialCard1.Controls.Add(txtNombres);
            materialCard1.Controls.Add(txtApellidos);
            materialCard1.Controls.Add(txtDni);
            materialCard1.Controls.Add(materialLabel5);
            materialCard1.Controls.Add(materialLabel4);
            materialCard1.Controls.Add(materialLabel3);
            materialCard1.Controls.Add(materialLabel2);
            materialCard1.Controls.Add(txtDniBuscado);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(16, 19);
            materialCard1.Margin = new Padding(16, 19, 16, 19);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(16, 19, 16, 19);
            materialCard1.Size = new Size(406, 757);
            materialCard1.TabIndex = 0;
            // 
            // txtPlaza
            // 
            txtPlaza.AnimateReadOnly = false;
            txtPlaza.BackgroundImageLayout = ImageLayout.None;
            txtPlaza.CharacterCasing = CharacterCasing.Normal;
            txtPlaza.Depth = 0;
            txtPlaza.HideSelection = true;
            txtPlaza.Hint = "Plaza";
            txtPlaza.Location = new Point(21, 560);
            txtPlaza.Margin = new Padding(3, 4, 3, 4);
            txtPlaza.MaxLength = 32767;
            txtPlaza.MouseState = MaterialSkin.MouseState.OUT;
            txtPlaza.Name = "txtPlaza";
            txtPlaza.PasswordChar = '\0';
            txtPlaza.ReadOnly = false;
            txtPlaza.ScrollBars = ScrollBars.None;
            txtPlaza.SelectedText = "";
            txtPlaza.SelectionLength = 0;
            txtPlaza.SelectionStart = 0;
            txtPlaza.ShortcutsEnabled = true;
            txtPlaza.Size = new Size(366, 89);
            txtPlaza.TabIndex = 20;
            txtPlaza.TabStop = false;
            txtPlaza.TextAlign = HorizontalAlignment.Center;
            txtPlaza.UseSystemPasswordChar = false;
            // 
            // txtDependencia2
            // 
            txtDependencia2.AnimateReadOnly = false;
            txtDependencia2.BackgroundImageLayout = ImageLayout.None;
            txtDependencia2.CharacterCasing = CharacterCasing.Normal;
            txtDependencia2.Depth = 0;
            txtDependencia2.HideSelection = true;
            txtDependencia2.Hint = "Dependencia";
            txtDependencia2.Location = new Point(19, 472);
            txtDependencia2.Margin = new Padding(3, 4, 3, 4);
            txtDependencia2.MaxLength = 32767;
            txtDependencia2.MouseState = MaterialSkin.MouseState.OUT;
            txtDependencia2.Name = "txtDependencia2";
            txtDependencia2.PasswordChar = '\0';
            txtDependencia2.ReadOnly = true;
            txtDependencia2.ScrollBars = ScrollBars.None;
            txtDependencia2.SelectedText = "";
            txtDependencia2.SelectionLength = 0;
            txtDependencia2.SelectionStart = 0;
            txtDependencia2.ShortcutsEnabled = true;
            txtDependencia2.Size = new Size(367, 80);
            txtDependencia2.TabIndex = 19;
            txtDependencia2.TabStop = false;
            txtDependencia2.TextAlign = HorizontalAlignment.Center;
            txtDependencia2.UseSystemPasswordChar = false;
            // 
            // lblNoAsistentes
            // 
            lblNoAsistentes.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNoAsistentes.Location = new Point(303, 705);
            lblNoAsistentes.Name = "lblNoAsistentes";
            lblNoAsistentes.Size = new Size(83, 49);
            lblNoAsistentes.TabIndex = 17;
            lblNoAsistentes.Text = "####";
            lblNoAsistentes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAsistentes
            // 
            lblAsistentes.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsistentes.Location = new Point(131, 705);
            lblAsistentes.Name = "lblAsistentes";
            lblAsistentes.Size = new Size(78, 49);
            lblAsistentes.TabIndex = 16;
            lblAsistentes.Text = "####";
            lblAsistentes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Font = new Font("Consolas", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 165);
            label1.Name = "label1";
            label1.Size = new Size(367, 87);
            label1.TabIndex = 15;
            label1.Text = "NO ENCONTRADO";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // materialLabel10
            // 
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel10.Location = new Point(215, 717);
            materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(11, 31);
            materialLabel10.TabIndex = 14;
            materialLabel10.Text = "|";
            // 
            // materialLabel7
            // 
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel7.Location = new Point(233, 717);
            materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(63, 31);
            materialLabel7.TabIndex = 11;
            materialLabel7.Text = "Faltan:";
            // 
            // txtNombres
            // 
            txtNombres.AnimateReadOnly = false;
            txtNombres.BackgroundImageLayout = ImageLayout.None;
            txtNombres.CharacterCasing = CharacterCasing.Normal;
            txtNombres.Depth = 0;
            txtNombres.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNombres.HideSelection = true;
            txtNombres.Hint = "Nombres";
            txtNombres.LeadingIcon = null;
            txtNombres.Location = new Point(21, 400);
            txtNombres.Margin = new Padding(3, 4, 3, 4);
            txtNombres.MaxLength = 32767;
            txtNombres.MouseState = MaterialSkin.MouseState.OUT;
            txtNombres.Name = "txtNombres";
            txtNombres.PasswordChar = '\0';
            txtNombres.PrefixSuffixText = null;
            txtNombres.ReadOnly = true;
            txtNombres.RightToLeft = RightToLeft.No;
            txtNombres.SelectedText = "";
            txtNombres.SelectionLength = 0;
            txtNombres.SelectionStart = 0;
            txtNombres.ShortcutsEnabled = true;
            txtNombres.Size = new Size(366, 48);
            txtNombres.TabIndex = 7;
            txtNombres.TabStop = false;
            txtNombres.TextAlign = HorizontalAlignment.Center;
            txtNombres.TrailingIcon = null;
            txtNombres.UseSystemPasswordChar = false;
            // 
            // txtApellidos
            // 
            txtApellidos.AnimateReadOnly = false;
            txtApellidos.BackgroundImageLayout = ImageLayout.None;
            txtApellidos.CharacterCasing = CharacterCasing.Normal;
            txtApellidos.Depth = 0;
            txtApellidos.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtApellidos.HideSelection = true;
            txtApellidos.Hint = "Apellidos";
            txtApellidos.LeadingIcon = null;
            txtApellidos.Location = new Point(19, 328);
            txtApellidos.Margin = new Padding(3, 4, 3, 4);
            txtApellidos.MaxLength = 32767;
            txtApellidos.MouseState = MaterialSkin.MouseState.OUT;
            txtApellidos.Name = "txtApellidos";
            txtApellidos.PasswordChar = '\0';
            txtApellidos.PrefixSuffixText = null;
            txtApellidos.ReadOnly = true;
            txtApellidos.RightToLeft = RightToLeft.No;
            txtApellidos.SelectedText = "";
            txtApellidos.SelectionLength = 0;
            txtApellidos.SelectionStart = 0;
            txtApellidos.ShortcutsEnabled = true;
            txtApellidos.Size = new Size(367, 48);
            txtApellidos.TabIndex = 6;
            txtApellidos.TabStop = false;
            txtApellidos.TextAlign = HorizontalAlignment.Center;
            txtApellidos.TrailingIcon = null;
            txtApellidos.UseSystemPasswordChar = false;
            // 
            // txtDni
            // 
            txtDni.AnimateReadOnly = false;
            txtDni.BackgroundImageLayout = ImageLayout.None;
            txtDni.CharacterCasing = CharacterCasing.Normal;
            txtDni.Depth = 0;
            txtDni.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDni.HideSelection = true;
            txtDni.Hint = "DNI";
            txtDni.LeadingIcon = null;
            txtDni.Location = new Point(19, 256);
            txtDni.Margin = new Padding(3, 4, 3, 4);
            txtDni.MaxLength = 32767;
            txtDni.MouseState = MaterialSkin.MouseState.OUT;
            txtDni.Name = "txtDni";
            txtDni.PasswordChar = '\0';
            txtDni.PrefixSuffixText = null;
            txtDni.ReadOnly = true;
            txtDni.RightToLeft = RightToLeft.No;
            txtDni.SelectedText = "";
            txtDni.SelectionLength = 0;
            txtDni.SelectionStart = 0;
            txtDni.ShortcutsEnabled = true;
            txtDni.Size = new Size(367, 48);
            txtDni.TabIndex = 5;
            txtDni.TabStop = false;
            txtDni.TextAlign = HorizontalAlignment.Center;
            txtDni.TrailingIcon = null;
            txtDni.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.Location = new Point(21, 23);
            materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(141, 19);
            materialLabel5.TabIndex = 0;
            materialLabel5.Text = "ZONA DE ESCANEO";
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel4.Location = new Point(61, 677);
            materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(78, 19);
            materialLabel4.TabIndex = 9;
            materialLabel4.Text = "RESUMEN:";
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(27, 140);
            materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(66, 19);
            materialLabel3.TabIndex = 2;
            materialLabel3.Text = "ESTADO:";
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(47, 717);
            materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(130, 31);
            materialLabel2.TabIndex = 10;
            materialLabel2.Text = "Presentes:";
            // 
            // txtDniBuscado
            // 
            txtDniBuscado.AnimateReadOnly = false;
            txtDniBuscado.BackgroundImageLayout = ImageLayout.None;
            txtDniBuscado.CharacterCasing = CharacterCasing.Normal;
            txtDniBuscado.Depth = 0;
            txtDniBuscado.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDniBuscado.HideSelection = true;
            txtDniBuscado.Hint = "Esperando lectura de DNI...";
            txtDniBuscado.LeadingIcon = null;
            txtDniBuscado.Location = new Point(19, 64);
            txtDniBuscado.Margin = new Padding(3, 4, 3, 4);
            txtDniBuscado.MaxLength = 32767;
            txtDniBuscado.MouseState = MaterialSkin.MouseState.OUT;
            txtDniBuscado.Name = "txtDniBuscado";
            txtDniBuscado.PasswordChar = '\0';
            txtDniBuscado.PrefixSuffixText = null;
            txtDniBuscado.ReadOnly = false;
            txtDniBuscado.RightToLeft = RightToLeft.No;
            txtDniBuscado.SelectedText = "";
            txtDniBuscado.SelectionLength = 0;
            txtDniBuscado.SelectionStart = 0;
            txtDniBuscado.ShortcutsEnabled = true;
            txtDniBuscado.Size = new Size(367, 48);
            txtDniBuscado.TabIndex = 1;
            txtDniBuscado.TabStop = false;
            txtDniBuscado.TextAlign = HorizontalAlignment.Left;
            txtDniBuscado.TrailingIcon = null;
            txtDniBuscado.UseSystemPasswordChar = false;
            txtDniBuscado.KeyDown += txtDniBuscado_KeyDown;
            // 
            // materialCard2
            // 
            materialCard2.BackColor = Color.FromArgb(255, 255, 255);
            materialCard2.Controls.Add(dgvBusqueda);
            materialCard2.Controls.Add(txtBusqueda);
            materialCard2.Controls.Add(materialLabel6);
            materialCard2.Depth = 0;
            materialCard2.Dock = DockStyle.Fill;
            materialCard2.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard2.Location = new Point(454, 19);
            materialCard2.Margin = new Padding(16, 19, 16, 19);
            materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard2.Name = "materialCard2";
            materialCard2.Padding = new Padding(16, 19, 16, 19);
            materialCard2.Size = new Size(993, 757);
            materialCard2.TabIndex = 1;
            // 
            // dgvBusqueda
            // 
            dgvBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBusqueda.Columns.AddRange(new DataGridViewColumn[] { ID, Column1, ParAula, Column5, Column2, Column3, Column4 });
            dgvBusqueda.Location = new Point(19, 95);
            dgvBusqueda.Margin = new Padding(3, 4, 3, 4);
            dgvBusqueda.Name = "dgvBusqueda";
            dgvBusqueda.RowHeadersWidth = 51;
            dgvBusqueda.Size = new Size(953, 640);
            dgvBusqueda.TabIndex = 2;
            dgvBusqueda.CellDoubleClick += dgvBusqueda_CellDoubleClick;
            // 
            // txtBusqueda
            // 
            txtBusqueda.AnimateReadOnly = false;
            txtBusqueda.BackgroundImageLayout = ImageLayout.None;
            txtBusqueda.CharacterCasing = CharacterCasing.Normal;
            txtBusqueda.Depth = 0;
            txtBusqueda.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBusqueda.HideSelection = true;
            txtBusqueda.Hint = "Buscar:";
            txtBusqueda.LeadingIcon = null;
            txtBusqueda.Location = new Point(206, 23);
            txtBusqueda.Margin = new Padding(3, 4, 3, 4);
            txtBusqueda.MaxLength = 32767;
            txtBusqueda.MouseState = MaterialSkin.MouseState.OUT;
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.PasswordChar = '\0';
            txtBusqueda.PrefixSuffixText = null;
            txtBusqueda.ReadOnly = false;
            txtBusqueda.RightToLeft = RightToLeft.No;
            txtBusqueda.SelectedText = "";
            txtBusqueda.SelectionLength = 0;
            txtBusqueda.SelectionStart = 0;
            txtBusqueda.ShortcutsEnabled = true;
            txtBusqueda.Size = new Size(767, 48);
            txtBusqueda.TabIndex = 1;
            txtBusqueda.TabStop = false;
            txtBusqueda.TextAlign = HorizontalAlignment.Left;
            txtBusqueda.TrailingIcon = null;
            txtBusqueda.UseSystemPasswordChar = false;
            txtBusqueda.KeyDown += txtBusqueda_KeyDown;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(19, 35);
            materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(139, 19);
            materialLabel6.TabIndex = 0;
            materialLabel6.Text = "LISTADO GENERAL";
            // 
            // statusStrip1
            // 
            tableLayoutPanel1.SetColumnSpan(statusStrip1, 2);
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripProgressBar1 });
            statusStrip1.Location = new Point(0, 809);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1463, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            toolStripProgressBar1.Name = "toolStripProgressBar1";
            toolStripProgressBar1.Size = new Size(114, 21);
            toolStripProgressBar1.Visible = false;
            // 
            // ID
            // 
            ID.DataPropertyName = "ParId";
            ID.HeaderText = "Column6";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 125;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "ParDocumentoIdentidad";
            Column1.HeaderText = "DNI";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 80;
            // 
            // ParAula
            // 
            ParAula.DataPropertyName = "ParAula";
            ParAula.HeaderText = "AULA";
            ParAula.MinimumWidth = 6;
            ParAula.Name = "ParAula";
            ParAula.Width = 125;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "ParFechaIngreso";
            Column5.HeaderText = "HORA INGRESO";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 180;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "ParNombres";
            Column2.HeaderText = "NOMBRES";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 300;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "ParDependencia";
            Column3.HeaderText = "DEPENDENCIA";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 300;
            // 
            // Column4
            // 
            Column4.DataPropertyName = "ParPlaza";
            Column4.HeaderText = "PLAZA";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 300;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1469, 920);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Padding = new Padding(3, 85, 3, 4);
            Text = "ASISTENCIA DE POSTULANTES - 2026";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            materialCard2.ResumeLayout(false);
            materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 txtDniBuscado;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialTextBox2 txtBusqueda;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private DataGridView dgvBusqueda;
        private MaterialSkin.Controls.MaterialTextBox2 txtDni;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombres;
        private MaterialSkin.Controls.MaterialTextBox2 txtApellidos;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private Label label1;
        private Label lblNoAsistentes;
        private Label lblAsistentes;
        private MaterialSkin.Controls.MaterialTextBox2 materialMultiLineTextBox21;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDependencia2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtPlaza;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn ParAula;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
