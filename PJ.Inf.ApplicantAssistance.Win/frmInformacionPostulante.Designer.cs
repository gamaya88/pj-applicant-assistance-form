namespace PJ.Inf.ApplicantAssistance.Win
{
    partial class frmInformacionPostulante
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
            tableLayoutPanel1 = new TableLayoutPanel();
            materialCard1 = new MaterialSkin.Controls.MaterialCard();
            txtPlaza = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            txtDependencia = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            txtEmail = new MaterialSkin.Controls.MaterialTextBox2();
            txtTelefono = new MaterialSkin.Controls.MaterialTextBox2();
            txtFicha = new MaterialSkin.Controls.MaterialTextBox2();
            txtNombres = new MaterialSkin.Controls.MaterialTextBox2();
            txtApellidos = new MaterialSkin.Controls.MaterialTextBox2();
            txtDni = new MaterialSkin.Controls.MaterialTextBox2();
            tableLayoutPanel1.SuspendLayout();
            materialCard1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(materialCard1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 64);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(385, 567);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // materialCard1
            // 
            materialCard1.BackColor = Color.FromArgb(255, 255, 255);
            materialCard1.Controls.Add(txtPlaza);
            materialCard1.Controls.Add(txtDependencia);
            materialCard1.Controls.Add(materialButton1);
            materialCard1.Controls.Add(txtEmail);
            materialCard1.Controls.Add(txtTelefono);
            materialCard1.Controls.Add(txtFicha);
            materialCard1.Controls.Add(txtNombres);
            materialCard1.Controls.Add(txtApellidos);
            materialCard1.Controls.Add(txtDni);
            materialCard1.Depth = 0;
            materialCard1.Dock = DockStyle.Fill;
            materialCard1.ForeColor = Color.FromArgb(222, 0, 0, 0);
            materialCard1.Location = new Point(14, 14);
            materialCard1.Margin = new Padding(14);
            materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            materialCard1.Name = "materialCard1";
            materialCard1.Padding = new Padding(14);
            materialCard1.Size = new Size(357, 539);
            materialCard1.TabIndex = 1;
            // 
            // txtPlaza
            // 
            txtPlaza.AnimateReadOnly = false;
            txtPlaza.BackgroundImageLayout = ImageLayout.None;
            txtPlaza.CharacterCasing = CharacterCasing.Normal;
            txtPlaza.Depth = 0;
            txtPlaza.HideSelection = true;
            txtPlaza.Hint = "Plaza";
            txtPlaza.Location = new Point(20, 245);
            txtPlaza.MaxLength = 32767;
            txtPlaza.MouseState = MaterialSkin.MouseState.OUT;
            txtPlaza.Name = "txtPlaza";
            txtPlaza.PasswordChar = '\0';
            txtPlaza.ReadOnly = true;
            txtPlaza.ScrollBars = ScrollBars.None;
            txtPlaza.SelectedText = "";
            txtPlaza.SelectionLength = 0;
            txtPlaza.SelectionStart = 0;
            txtPlaza.ShortcutsEnabled = true;
            txtPlaza.Size = new Size(320, 67);
            txtPlaza.TabIndex = 24;
            txtPlaza.TabStop = false;
            txtPlaza.TextAlign = HorizontalAlignment.Center;
            txtPlaza.UseSystemPasswordChar = false;
            // 
            // txtDependencia
            // 
            txtDependencia.AnimateReadOnly = false;
            txtDependencia.BackgroundImageLayout = ImageLayout.None;
            txtDependencia.CharacterCasing = CharacterCasing.Normal;
            txtDependencia.Depth = 0;
            txtDependencia.HideSelection = true;
            txtDependencia.Hint = "Dependencia";
            txtDependencia.Location = new Point(19, 179);
            txtDependencia.MaxLength = 32767;
            txtDependencia.MouseState = MaterialSkin.MouseState.OUT;
            txtDependencia.Name = "txtDependencia";
            txtDependencia.PasswordChar = '\0';
            txtDependencia.ReadOnly = true;
            txtDependencia.ScrollBars = ScrollBars.None;
            txtDependencia.SelectedText = "";
            txtDependencia.SelectionLength = 0;
            txtDependencia.SelectionStart = 0;
            txtDependencia.ShortcutsEnabled = true;
            txtDependencia.Size = new Size(321, 60);
            txtDependencia.TabIndex = 23;
            txtDependencia.TabStop = false;
            txtDependencia.TextAlign = HorizontalAlignment.Center;
            txtDependencia.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(140, 483);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(76, 36);
            materialButton1.TabIndex = 22;
            materialButton1.Text = "VOLVER";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += materialButton1_Click;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Emails";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(19, 426);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = MaterialSkin.MouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = true;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(320, 48);
            txtEmail.TabIndex = 21;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtTelefono
            // 
            txtTelefono.AnimateReadOnly = false;
            txtTelefono.BackgroundImageLayout = ImageLayout.None;
            txtTelefono.CharacterCasing = CharacterCasing.Normal;
            txtTelefono.Depth = 0;
            txtTelefono.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTelefono.HideSelection = true;
            txtTelefono.Hint = "Teléfonos";
            txtTelefono.LeadingIcon = null;
            txtTelefono.Location = new Point(19, 372);
            txtTelefono.MaxLength = 32767;
            txtTelefono.MouseState = MaterialSkin.MouseState.OUT;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.PasswordChar = '\0';
            txtTelefono.PrefixSuffixText = null;
            txtTelefono.ReadOnly = true;
            txtTelefono.RightToLeft = RightToLeft.No;
            txtTelefono.SelectedText = "";
            txtTelefono.SelectionLength = 0;
            txtTelefono.SelectionStart = 0;
            txtTelefono.ShortcutsEnabled = true;
            txtTelefono.Size = new Size(320, 48);
            txtTelefono.TabIndex = 20;
            txtTelefono.TabStop = false;
            txtTelefono.TextAlign = HorizontalAlignment.Left;
            txtTelefono.TrailingIcon = null;
            txtTelefono.UseSystemPasswordChar = false;
            // 
            // txtFicha
            // 
            txtFicha.AnimateReadOnly = false;
            txtFicha.BackgroundImageLayout = ImageLayout.None;
            txtFicha.CharacterCasing = CharacterCasing.Normal;
            txtFicha.Depth = 0;
            txtFicha.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFicha.HideSelection = true;
            txtFicha.Hint = "Ficha";
            txtFicha.LeadingIcon = null;
            txtFicha.Location = new Point(20, 318);
            txtFicha.MaxLength = 32767;
            txtFicha.MouseState = MaterialSkin.MouseState.OUT;
            txtFicha.Name = "txtFicha";
            txtFicha.PasswordChar = '\0';
            txtFicha.PrefixSuffixText = null;
            txtFicha.ReadOnly = true;
            txtFicha.RightToLeft = RightToLeft.No;
            txtFicha.SelectedText = "";
            txtFicha.SelectionLength = 0;
            txtFicha.SelectionStart = 0;
            txtFicha.ShortcutsEnabled = true;
            txtFicha.Size = new Size(320, 48);
            txtFicha.TabIndex = 19;
            txtFicha.TabStop = false;
            txtFicha.TextAlign = HorizontalAlignment.Left;
            txtFicha.TrailingIcon = null;
            txtFicha.UseSystemPasswordChar = false;
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
            txtNombres.Location = new Point(18, 125);
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
            txtNombres.Size = new Size(320, 48);
            txtNombres.TabIndex = 7;
            txtNombres.TabStop = false;
            txtNombres.TextAlign = HorizontalAlignment.Left;
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
            txtApellidos.Location = new Point(17, 71);
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
            txtApellidos.Size = new Size(321, 48);
            txtApellidos.TabIndex = 6;
            txtApellidos.TabStop = false;
            txtApellidos.TextAlign = HorizontalAlignment.Left;
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
            txtDni.Location = new Point(17, 17);
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
            txtDni.Size = new Size(321, 48);
            txtDni.TabIndex = 5;
            txtDni.TabStop = false;
            txtDni.TextAlign = HorizontalAlignment.Left;
            txtDni.TrailingIcon = null;
            txtDni.UseSystemPasswordChar = false;
            // 
            // frmInformacionPostulante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 634);
            Controls.Add(tableLayoutPanel1);
            Name = "frmInformacionPostulante";
            Text = "DETALLE DE POSTULANTE";
            tableLayoutPanel1.ResumeLayout(false);
            materialCard1.ResumeLayout(false);
            materialCard1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombres;
        private MaterialSkin.Controls.MaterialTextBox2 txtApellidos;
        private MaterialSkin.Controls.MaterialTextBox2 txtDni;
        private MaterialSkin.Controls.MaterialTextBox2 txtFicha;
        private MaterialSkin.Controls.MaterialTextBox2 txtTelefono;
        private MaterialSkin.Controls.MaterialTextBox2 txtEmail;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtPlaza;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDependencia;
    }
}