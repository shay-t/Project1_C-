namespace facturationClient
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.date = new MetroFramework.Controls.MetroDateTime();
            this.iCETextBox = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet8 = new facturationClient.Database1DataSet8();
            this.iFFTextBox = new System.Windows.Forms.TextBox();
            this.statut = new MetroFramework.Controls.MetroComboBox();
            this.clientMetroComboBox = new MetroFramework.Controls.MetroComboBox();
            this.reference = new MetroFramework.Controls.MetroTextBox();
            this.prix = new MetroFramework.Controls.MetroTextBox();
            this.quantite = new MetroFramework.Controls.MetroTextBox();
            this.designation = new MetroFramework.Controls.MetroTextBox();
            this.devis = new MetroFramework.Controls.MetroTextBox();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.clientTableAdapter = new facturationClient.Database1DataSet8TableAdapters.ClientTableAdapter();
            this.tableAdapterManager = new facturationClient.Database1DataSet8TableAdapters.TableAdapterManager();
            this.devisTableAdapter = new facturationClient.Database1DataSet8TableAdapters.DevisTableAdapter();
            this.devisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.devisMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.DevisN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dater = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClientId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalTTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButtonprint = new MetroFramework.Controls.MetroButton();
            this.ajouterp = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.compteur = new MetroFramework.Controls.MetroTextBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.produitBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.produitTableAdapter = new facturationClient.Database1DataSet8TableAdapters.ProduitTableAdapter();
            this.produitMetroGrid = new MetroFramework.Controls.MetroGrid();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.refe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.stat = new MetroFramework.Controls.MetroButton();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisMetroGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitMetroGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.compteur);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.metroButton4);
            this.metroPanel1.Controls.Add(this.ajouterp);
            this.metroPanel1.Controls.Add(this.date);
            this.metroPanel1.Controls.Add(this.iCETextBox);
            this.metroPanel1.Controls.Add(this.iFFTextBox);
            this.metroPanel1.Controls.Add(this.statut);
            this.metroPanel1.Controls.Add(this.clientMetroComboBox);
            this.metroPanel1.Controls.Add(this.reference);
            this.metroPanel1.Controls.Add(this.prix);
            this.metroPanel1.Controls.Add(this.quantite);
            this.metroPanel1.Controls.Add(this.designation);
            this.metroPanel1.Controls.Add(this.devis);
            this.metroPanel1.Controls.Add(this.metroButton3);
            this.metroPanel1.Controls.Add(this.metroButton2);
            this.metroPanel1.Controls.Add(this.metroButton1);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.Controls.Add(this.metroLabel9);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(32, 80);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(892, 301);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(472, 23);
            this.date.MinimumSize = new System.Drawing.Size(0, 29);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(179, 29);
            this.date.TabIndex = 28;
            // 
            // iCETextBox
            // 
            this.iCETextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "ICE", true));
            this.iCETextBox.Location = new System.Drawing.Point(85, 204);
            this.iCETextBox.Name = "iCETextBox";
            this.iCETextBox.ReadOnly = true;
            this.iCETextBox.Size = new System.Drawing.Size(179, 20);
            this.iCETextBox.TabIndex = 27;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.database1DataSet8;
            // 
            // database1DataSet8
            // 
            this.database1DataSet8.DataSetName = "Database1DataSet8";
            this.database1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // iFFTextBox
            // 
            this.iFFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "IFF", true));
            this.iFFTextBox.Location = new System.Drawing.Point(85, 159);
            this.iFFTextBox.Name = "iFFTextBox";
            this.iFFTextBox.ReadOnly = true;
            this.iFFTextBox.Size = new System.Drawing.Size(179, 20);
            this.iFFTextBox.TabIndex = 26;
            this.iFFTextBox.TextChanged += new System.EventHandler(this.iFFTextBox_TextChanged);
            // 
            // statut
            // 
            this.statut.FormattingEnabled = true;
            this.statut.ItemHeight = 23;
            this.statut.Items.AddRange(new object[] {
            "En attente",
            "Confirme"});
            this.statut.Location = new System.Drawing.Point(85, 65);
            this.statut.Name = "statut";
            this.statut.Size = new System.Drawing.Size(179, 29);
            this.statut.TabIndex = 1;
            this.statut.UseSelectable = true;
            // 
            // clientMetroComboBox
            // 
            this.clientMetroComboBox.DataSource = this.clientBindingSource;
            this.clientMetroComboBox.DisplayMember = "ClientId";
            this.clientMetroComboBox.FormattingEnabled = true;
            this.clientMetroComboBox.ItemHeight = 23;
            this.clientMetroComboBox.Location = new System.Drawing.Point(85, 107);
            this.clientMetroComboBox.Name = "clientMetroComboBox";
            this.clientMetroComboBox.Size = new System.Drawing.Size(179, 29);
            this.clientMetroComboBox.TabIndex = 2;
            this.clientMetroComboBox.UseSelectable = true;
            this.clientMetroComboBox.ValueMember = "ClientId";
            this.clientMetroComboBox.SelectedIndexChanged += new System.EventHandler(this.clientMetroComboBox_SelectedIndexChanged);
            // 
            // reference
            // 
            // 
            // 
            // 
            this.reference.CustomButton.Image = null;
            this.reference.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.reference.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.reference.CustomButton.Name = "";
            this.reference.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.reference.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.reference.CustomButton.TabIndex = 1;
            this.reference.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.reference.CustomButton.UseSelectable = true;
            this.reference.CustomButton.Visible = false;
            this.reference.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.reference.Lines = new string[0];
            this.reference.Location = new System.Drawing.Point(472, 204);
            this.reference.Margin = new System.Windows.Forms.Padding(2);
            this.reference.MaxLength = 32767;
            this.reference.Name = "reference";
            this.reference.PasswordChar = '\0';
            this.reference.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.reference.SelectedText = "";
            this.reference.SelectionLength = 0;
            this.reference.SelectionStart = 0;
            this.reference.ShortcutsEnabled = true;
            this.reference.Size = new System.Drawing.Size(179, 28);
            this.reference.TabIndex = 24;
            this.reference.UseSelectable = true;
            this.reference.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.reference.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // prix
            // 
            // 
            // 
            // 
            this.prix.CustomButton.Image = null;
            this.prix.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.prix.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.prix.CustomButton.Name = "";
            this.prix.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.prix.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.prix.CustomButton.TabIndex = 1;
            this.prix.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.prix.CustomButton.UseSelectable = true;
            this.prix.CustomButton.Visible = false;
            this.prix.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.prix.Lines = new string[0];
            this.prix.Location = new System.Drawing.Point(472, 159);
            this.prix.Margin = new System.Windows.Forms.Padding(2);
            this.prix.MaxLength = 32767;
            this.prix.Name = "prix";
            this.prix.PasswordChar = '\0';
            this.prix.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.prix.SelectedText = "";
            this.prix.SelectionLength = 0;
            this.prix.SelectionStart = 0;
            this.prix.ShortcutsEnabled = true;
            this.prix.Size = new System.Drawing.Size(179, 28);
            this.prix.TabIndex = 23;
            this.prix.UseSelectable = true;
            this.prix.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.prix.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // quantite
            // 
            // 
            // 
            // 
            this.quantite.CustomButton.Image = null;
            this.quantite.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.quantite.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.quantite.CustomButton.Name = "";
            this.quantite.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.quantite.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.quantite.CustomButton.TabIndex = 1;
            this.quantite.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.quantite.CustomButton.UseSelectable = true;
            this.quantite.CustomButton.Visible = false;
            this.quantite.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.quantite.Lines = new string[0];
            this.quantite.Location = new System.Drawing.Point(472, 107);
            this.quantite.Margin = new System.Windows.Forms.Padding(2);
            this.quantite.MaxLength = 32767;
            this.quantite.Name = "quantite";
            this.quantite.PasswordChar = '\0';
            this.quantite.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.quantite.SelectedText = "";
            this.quantite.SelectionLength = 0;
            this.quantite.SelectionStart = 0;
            this.quantite.ShortcutsEnabled = true;
            this.quantite.Size = new System.Drawing.Size(179, 28);
            this.quantite.TabIndex = 22;
            this.quantite.UseSelectable = true;
            this.quantite.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.quantite.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // designation
            // 
            // 
            // 
            // 
            this.designation.CustomButton.Image = null;
            this.designation.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.designation.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.designation.CustomButton.Name = "";
            this.designation.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.designation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.designation.CustomButton.TabIndex = 1;
            this.designation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.designation.CustomButton.UseSelectable = true;
            this.designation.CustomButton.Visible = false;
            this.designation.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.designation.Lines = new string[0];
            this.designation.Location = new System.Drawing.Point(472, 66);
            this.designation.Margin = new System.Windows.Forms.Padding(2);
            this.designation.MaxLength = 32767;
            this.designation.Name = "designation";
            this.designation.PasswordChar = '\0';
            this.designation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.designation.SelectedText = "";
            this.designation.SelectionLength = 0;
            this.designation.SelectionStart = 0;
            this.designation.ShortcutsEnabled = true;
            this.designation.Size = new System.Drawing.Size(179, 28);
            this.designation.TabIndex = 21;
            this.designation.UseSelectable = true;
            this.designation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.designation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // devis
            // 
            // 
            // 
            // 
            this.devis.CustomButton.Image = null;
            this.devis.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.devis.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.devis.CustomButton.Name = "";
            this.devis.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.devis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.devis.CustomButton.TabIndex = 1;
            this.devis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.devis.CustomButton.UseSelectable = true;
            this.devis.CustomButton.Visible = false;
            this.devis.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.devis.Lines = new string[0];
            this.devis.Location = new System.Drawing.Point(85, 24);
            this.devis.Margin = new System.Windows.Forms.Padding(2);
            this.devis.MaxLength = 32767;
            this.devis.Name = "devis";
            this.devis.PasswordChar = '\0';
            this.devis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.devis.SelectedText = "";
            this.devis.SelectionLength = 0;
            this.devis.SelectionStart = 0;
            this.devis.ShortcutsEnabled = true;
            this.devis.Size = new System.Drawing.Size(179, 28);
            this.devis.TabIndex = 16;
            this.devis.UseSelectable = true;
            this.devis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.devis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton3
            // 
            this.metroButton3.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton3.Location = new System.Drawing.Point(368, 248);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(156, 31);
            this.metroButton3.TabIndex = 15;
            this.metroButton3.Text = "Ajouter devis";
            this.metroButton3.UseCustomBackColor = true;
            this.metroButton3.UseCustomForeColor = true;
            this.metroButton3.UseSelectable = true;
            this.metroButton3.UseStyleColors = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton2.Location = new System.Drawing.Point(547, 248);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(156, 31);
            this.metroButton2.TabIndex = 14;
            this.metroButton2.Text = "Suprimer devis";
            this.metroButton2.UseCustomBackColor = true;
            this.metroButton2.UseCustomForeColor = true;
            this.metroButton2.UseSelectable = true;
            this.metroButton2.UseStyleColors = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.OrangeRed;
            this.metroButton1.Location = new System.Drawing.Point(718, 248);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(156, 31);
            this.metroButton1.TabIndex = 13;
            this.metroButton1.Text = "Nouveau client";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(365, 107);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(59, 19);
            this.metroLabel11.TabIndex = 12;
            this.metroLabel11.Text = "Quantité";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(363, 66);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(77, 19);
            this.metroLabel10.TabIndex = 11;
            this.metroLabel10.Text = "Designation";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(363, 24);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(89, 19);
            this.metroLabel9.TabIndex = 10;
            this.metroLabel9.Text = "Date de Devis";
            this.metroLabel9.Click += new System.EventHandler(this.metroLabel9_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(368, 200);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(67, 19);
            this.metroLabel8.TabIndex = 9;
            this.metroLabel8.Text = "Reference";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(368, 159);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(31, 19);
            this.metroLabel7.TabIndex = 8;
            this.metroLabel7.Text = "Prix";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 200);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(62, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "ICE client";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 159);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(56, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "IF Client";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 107);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(58, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Client ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Status:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(61, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Devis N°:";
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientTableAdapter = this.clientTableAdapter;
            this.tableAdapterManager.DevisTableAdapter = this.devisTableAdapter;
            this.tableAdapterManager.FactureTableAdapter = null;
            this.tableAdapterManager.ProduitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = facturationClient.Database1DataSet8TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // devisTableAdapter
            // 
            this.devisTableAdapter.ClearBeforeFill = true;
            // 
            // devisBindingSource
            // 
            this.devisBindingSource.DataMember = "Client_Devis";
            this.devisBindingSource.DataSource = this.clientBindingSource;
            // 
            // devisMetroGrid
            // 
            this.devisMetroGrid.AllowUserToResizeRows = false;
            this.devisMetroGrid.AutoGenerateColumns = false;
            this.devisMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.devisMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.devisMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.devisMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.devisMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.devisMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.devisMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DevisN,
            this.Qt,
            this.total,
            this.dater,
            this.status,
            this.ClientId,
            this.TotalTTC});
            this.devisMetroGrid.DataSource = this.devisBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.devisMetroGrid.DefaultCellStyle = dataGridViewCellStyle8;
            this.devisMetroGrid.EnableHeadersVisualStyles = false;
            this.devisMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.devisMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.devisMetroGrid.Location = new System.Drawing.Point(32, 450);
            this.devisMetroGrid.Name = "devisMetroGrid";
            this.devisMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.devisMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.devisMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.devisMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.devisMetroGrid.Size = new System.Drawing.Size(714, 187);
            this.devisMetroGrid.TabIndex = 1;
            this.devisMetroGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.devisMetroGrid_CellContentClick);
            this.devisMetroGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.devisMetroGrid_CellMouseClick);
            this.devisMetroGrid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.devisMetroGrid_KeyPress);
            // 
            // DevisN
            // 
            this.DevisN.DataPropertyName = "DevisN";
            this.DevisN.HeaderText = "DevisN";
            this.DevisN.Name = "DevisN";
            // 
            // Qt
            // 
            this.Qt.DataPropertyName = "Qt";
            this.Qt.HeaderText = "Qt";
            this.Qt.Name = "Qt";
            // 
            // total
            // 
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "total";
            this.total.Name = "total";
            // 
            // dater
            // 
            this.dater.DataPropertyName = "Date";
            this.dater.HeaderText = "Date";
            this.dater.Name = "dater";
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // ClientId
            // 
            this.ClientId.DataPropertyName = "ClientId";
            this.ClientId.HeaderText = "ClientId";
            this.ClientId.Name = "ClientId";
            // 
            // TotalTTC
            // 
            this.TotalTTC.DataPropertyName = "DevisN*5";
            this.TotalTTC.HeaderText = "Total (ttc)";
            this.TotalTTC.Name = "TotalTTC";
            // 
            // metroButtonprint
            // 
            this.metroButtonprint.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButtonprint.Location = new System.Drawing.Point(396, 884);
            this.metroButtonprint.Name = "metroButtonprint";
            this.metroButtonprint.Size = new System.Drawing.Size(161, 55);
            this.metroButtonprint.TabIndex = 29;
            this.metroButtonprint.Text = "imprimer";
            this.metroButtonprint.UseCustomBackColor = true;
            this.metroButtonprint.UseCustomForeColor = true;
            this.metroButtonprint.UseSelectable = true;
            this.metroButtonprint.UseStyleColors = true;
            this.metroButtonprint.Visible = false;
            this.metroButtonprint.Click += new System.EventHandler(this.metroButtonprint_Click);
            // 
            // ajouterp
            // 
            this.ajouterp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ajouterp.Location = new System.Drawing.Point(718, 159);
            this.ajouterp.Name = "ajouterp";
            this.ajouterp.Size = new System.Drawing.Size(156, 31);
            this.ajouterp.TabIndex = 29;
            this.ajouterp.Text = "Ajouter produit";
            this.ajouterp.UseCustomBackColor = true;
            this.ajouterp.UseCustomForeColor = true;
            this.ajouterp.UseSelectable = true;
            this.ajouterp.UseStyleColors = true;
            this.ajouterp.Click += new System.EventHandler(this.ajouterp_Click);
            // 
            // metroButton4
            // 
            this.metroButton4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.metroButton4.Location = new System.Drawing.Point(718, 204);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(156, 31);
            this.metroButton4.TabIndex = 30;
            this.metroButton4.Text = "suprimer produit";
            this.metroButton4.UseCustomBackColor = true;
            this.metroButton4.UseCustomForeColor = true;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.UseStyleColors = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(718, 24);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(69, 19);
            this.metroLabel6.TabIndex = 31;
            this.metroLabel6.Text = "Compteur";
            this.metroLabel6.Click += new System.EventHandler(this.metroLabel6_Click);
            // 
            // compteur
            // 
            // 
            // 
            // 
            this.compteur.CustomButton.Image = null;
            this.compteur.CustomButton.Location = new System.Drawing.Point(48, 2);
            this.compteur.CustomButton.Name = "";
            this.compteur.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.compteur.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.compteur.CustomButton.TabIndex = 1;
            this.compteur.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.compteur.CustomButton.UseSelectable = true;
            this.compteur.CustomButton.Visible = false;
            this.compteur.Lines = new string[0];
            this.compteur.Location = new System.Drawing.Point(793, 24);
            this.compteur.MaxLength = 32767;
            this.compteur.Name = "compteur";
            this.compteur.PasswordChar = '\0';
            this.compteur.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.compteur.SelectedText = "";
            this.compteur.SelectionLength = 0;
            this.compteur.SelectionStart = 0;
            this.compteur.ShortcutsEnabled = true;
            this.compteur.Size = new System.Drawing.Size(66, 20);
            this.compteur.TabIndex = 32;
            this.compteur.UseSelectable = true;
            this.compteur.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.compteur.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(32, 398);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(209, 37);
            this.metroTile1.TabIndex = 30;
            this.metroTile1.Text = "Liste des Devis";
            this.metroTile1.UseSelectable = true;
            // 
            // produitBindingSource
            // 
            this.produitBindingSource.DataMember = "Produit";
            this.produitBindingSource.DataSource = this.database1DataSet8;
            // 
            // produitTableAdapter
            // 
            this.produitTableAdapter.ClearBeforeFill = true;
            // 
            // produitMetroGrid
            // 
            this.produitMetroGrid.AllowUserToResizeRows = false;
            this.produitMetroGrid.AutoGenerateColumns = false;
            this.produitMetroGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.produitMetroGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.produitMetroGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.produitMetroGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produitMetroGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.produitMetroGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produitMetroGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.refe,
            this.desi,
            this.qtp,
            this.price});
            this.produitMetroGrid.DataSource = this.produitBindingSource;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.produitMetroGrid.DefaultCellStyle = dataGridViewCellStyle11;
            this.produitMetroGrid.EnableHeadersVisualStyles = false;
            this.produitMetroGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.produitMetroGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.produitMetroGrid.Location = new System.Drawing.Point(32, 695);
            this.produitMetroGrid.Name = "produitMetroGrid";
            this.produitMetroGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.produitMetroGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.produitMetroGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.produitMetroGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.produitMetroGrid.Size = new System.Drawing.Size(720, 183);
            this.produitMetroGrid.TabIndex = 30;
            this.produitMetroGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.produitMetroGrid_CellContentClick);
            this.produitMetroGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.produitMetroGrid_CellMouseClick);
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DevisN";
            this.dataGridViewTextBoxColumn5.HeaderText = "DevisN";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // refe
            // 
            this.refe.DataPropertyName = "reference";
            this.refe.HeaderText = "reference";
            this.refe.Name = "refe";
            this.refe.Width = 150;
            // 
            // desi
            // 
            this.desi.DataPropertyName = "designation";
            this.desi.HeaderText = "designation";
            this.desi.Name = "desi";
            this.desi.Width = 150;
            // 
            // qtp
            // 
            this.qtp.DataPropertyName = "qtp";
            this.qtp.HeaderText = "qtp";
            this.qtp.Name = "qtp";
            // 
            // price
            // 
            this.price.DataPropertyName = "prix";
            this.price.HeaderText = "prix";
            this.price.Name = "price";
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(32, 652);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(209, 37);
            this.metroTile2.TabIndex = 31;
            this.metroTile2.Text = "Liste des Produits";
            this.metroTile2.UseSelectable = true;
            // 
            // stat
            // 
            this.stat.BackColor = System.Drawing.Color.OrangeRed;
            this.stat.Location = new System.Drawing.Point(776, 466);
            this.stat.Name = "stat";
            this.stat.Size = new System.Drawing.Size(156, 60);
            this.stat.TabIndex = 33;
            this.stat.Text = "Changer status";
            this.stat.UseCustomBackColor = true;
            this.stat.UseCustomForeColor = true;
            this.stat.UseSelectable = true;
            this.stat.UseStyleColors = true;
            this.stat.Click += new System.EventHandler(this.stat_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 962);
            this.Controls.Add(this.stat);
            this.Controls.Add(this.metroTile2);
            this.Controls.Add(this.produitMetroGrid);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.metroButtonprint);
            this.Controls.Add(this.devisMetroGrid);
            this.Controls.Add(this.metroPanel1);
            this.Name = "Form3";
            this.Text = "Devis";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devisMetroGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.produitMetroGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroTextBox reference;
        private MetroFramework.Controls.MetroTextBox prix;
        private MetroFramework.Controls.MetroTextBox quantite;
        private MetroFramework.Controls.MetroTextBox designation;
        private MetroFramework.Controls.MetroTextBox devis;
        private Database1DataSet8 database1DataSet8;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private Database1DataSet8TableAdapters.ClientTableAdapter clientTableAdapter;
        private Database1DataSet8TableAdapters.TableAdapterManager tableAdapterManager;
        private MetroFramework.Controls.MetroComboBox clientMetroComboBox;
        private MetroFramework.Controls.MetroComboBox statut;
        private Database1DataSet8TableAdapters.DevisTableAdapter devisTableAdapter;
        private System.Windows.Forms.BindingSource devisBindingSource;
        private MetroFramework.Controls.MetroGrid devisMetroGrid;
        protected System.Windows.Forms.TextBox iFFTextBox;
        private System.Windows.Forms.TextBox iCETextBox;
        private MetroFramework.Controls.MetroDateTime date;
        private MetroFramework.Controls.MetroButton metroButtonprint;
        private System.Windows.Forms.DataGridViewTextBoxColumn DevisN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qt;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn dater;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalTTC;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroButton ajouterp;
        private MetroFramework.Controls.MetroTextBox compteur;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.BindingSource produitBindingSource;
        private Database1DataSet8TableAdapters.ProduitTableAdapter produitTableAdapter;
        private MetroFramework.Controls.MetroGrid produitMetroGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn refe;
        private System.Windows.Forms.DataGridViewTextBoxColumn desi;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtp;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroButton stat;
    }
}