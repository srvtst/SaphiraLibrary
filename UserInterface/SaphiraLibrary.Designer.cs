
namespace UserInterface
{
    partial class SaphiraLibrary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaphiraLibrary));
            this.dgwBook = new System.Windows.Forms.DataGridView();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategorySearch = new System.Windows.Forms.Label();
            this.lblBookSearch = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblAuthorAdded = new System.Windows.Forms.Label();
            this.grpBookAdded = new System.Windows.Forms.GroupBox();
            this.cmbxCategoryAdded = new System.Windows.Forms.ComboBox();
            this.cmbxAuthorAdded = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblPublisher = new System.Windows.Forms.Label();
            this.txtPublisher = new System.Windows.Forms.TextBox();
            this.lblPageCount = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtPageCount = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblCategoryAdded = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtAuthorSearch = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbFiltreleme = new System.Windows.Forms.TabPage();
            this.tbGenelIslemler = new System.Windows.Forms.TabPage();
            this.btnYazarEkle = new System.Windows.Forms.Button();
            this.dgwYazar = new System.Windows.Forms.DataGridView();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnYazarSil = new System.Windows.Forms.Button();
            this.btnYazarGüncelle = new System.Windows.Forms.Button();
            this.btnKategoriGüncelle = new System.Windows.Forms.Button();
            this.btnKategoriSil = new System.Windows.Forms.Button();
            this.dgwKategori = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKategori = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtYazar = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnCustomerRemove = new System.Windows.Forms.Button();
            this.btnCustomerUpdated = new System.Windows.Forms.Button();
            this.btnCustomerAdded = new System.Windows.Forms.Button();
            this.dgwCustomer = new System.Windows.Forms.DataGridView();
            this.txtCustomerAge = new System.Windows.Forms.TextBox();
            this.rbKadın = new System.Windows.Forms.RadioButton();
            this.rbErkek = new System.Windows.Forms.RadioButton();
            this.txtCustomerJob = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerAge = new System.Windows.Forms.Label();
            this.lblCustomerGender = new System.Windows.Forms.Label();
            this.lblCustomerJob = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.tgKiralamaIslemleri = new System.Windows.Forms.TabPage();
            this.btnKitapKirala = new System.Windows.Forms.Button();
            this.dpDonusDate = new System.Windows.Forms.DateTimePicker();
            this.lblDönüşTarihi = new System.Windows.Forms.Label();
            this.dpRentDate = new System.Windows.Forms.DateTimePicker();
            this.lblKiralamaTarihi = new System.Windows.Forms.Label();
            this.lnlMüşteriAdıKiralama = new System.Windows.Forms.Label();
            this.cbxMüsteriAdıKiralama = new System.Windows.Forms.ComboBox();
            this.lblKitapAdıKiralama = new System.Windows.Forms.Label();
            this.cbxKitapAdıKiralama = new System.Windows.Forms.ComboBox();
            this.tgListeleme = new System.Windows.Forms.TabPage();
            this.btnKiralamaListeleme = new System.Windows.Forms.Button();
            this.btnKategoriListeleme = new System.Windows.Forms.Button();
            this.btnYazarListeleme = new System.Windows.Forms.Button();
            this.dgwListeleme = new System.Windows.Forms.DataGridView();
            this.btnKitapListeleme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).BeginInit();
            this.grpBookAdded.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbFiltreleme.SuspendLayout();
            this.tbGenelIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwYazar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKategori)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).BeginInit();
            this.tgKiralamaIslemleri.SuspendLayout();
            this.tgListeleme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeleme)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwBook
            // 
            this.dgwBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwBook.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgwBook.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgwBook.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwBook.Location = new System.Drawing.Point(6, 55);
            this.dgwBook.Name = "dgwBook";
            this.dgwBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwBook.Size = new System.Drawing.Size(1096, 193);
            this.dgwBook.TabIndex = 0;
            this.dgwBook.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwBook_CellClick);
            // 
            // cbxCategory
            // 
            this.cbxCategory.BackColor = System.Drawing.Color.White;
            this.cbxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(172, 23);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(151, 23);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategorySearch
            // 
            this.lblCategorySearch.AutoSize = true;
            this.lblCategorySearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCategorySearch.Location = new System.Drawing.Point(8, 26);
            this.lblCategorySearch.Name = "lblCategorySearch";
            this.lblCategorySearch.Size = new System.Drawing.Size(158, 13);
            this.lblCategorySearch.TabIndex = 2;
            this.lblCategorySearch.Text = "Kategori Adına Göre Filtreleme : ";
            // 
            // lblBookSearch
            // 
            this.lblBookSearch.AutoSize = true;
            this.lblBookSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBookSearch.Location = new System.Drawing.Point(356, 26);
            this.lblBookSearch.Name = "lblBookSearch";
            this.lblBookSearch.Size = new System.Drawing.Size(143, 13);
            this.lblBookSearch.TabIndex = 6;
            this.lblBookSearch.Text = "Kitap Adına Göre Filtreleme : ";
            this.lblBookSearch.Click += new System.EventHandler(this.Form1_Load);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(299, 81);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 47);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblAuthorAdded
            // 
            this.lblAuthorAdded.AutoSize = true;
            this.lblAuthorAdded.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAuthorAdded.Location = new System.Drawing.Point(40, 236);
            this.lblAuthorAdded.Name = "lblAuthorAdded";
            this.lblAuthorAdded.Size = new System.Drawing.Size(44, 14);
            this.lblAuthorAdded.TabIndex = 9;
            this.lblAuthorAdded.Text = "Yazar : ";
            // 
            // grpBookAdded
            // 
            this.grpBookAdded.Controls.Add(this.cmbxCategoryAdded);
            this.grpBookAdded.Controls.Add(this.btnAdd);
            this.grpBookAdded.Controls.Add(this.cmbxAuthorAdded);
            this.grpBookAdded.Controls.Add(this.btnUpdate);
            this.grpBookAdded.Controls.Add(this.lblPublisher);
            this.grpBookAdded.Controls.Add(this.txtPublisher);
            this.grpBookAdded.Controls.Add(this.lblPageCount);
            this.grpBookAdded.Controls.Add(this.txtPrice);
            this.grpBookAdded.Controls.Add(this.lblPrice);
            this.grpBookAdded.Controls.Add(this.txtPageCount);
            this.grpBookAdded.Controls.Add(this.lblBookName);
            this.grpBookAdded.Controls.Add(this.txtBookName);
            this.grpBookAdded.Controls.Add(this.lblCategoryAdded);
            this.grpBookAdded.Controls.Add(this.lblAuthorAdded);
            this.grpBookAdded.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpBookAdded.Location = new System.Drawing.Point(317, 21);
            this.grpBookAdded.Name = "grpBookAdded";
            this.grpBookAdded.Size = new System.Drawing.Size(466, 289);
            this.grpBookAdded.TabIndex = 10;
            this.grpBookAdded.TabStop = false;
            this.grpBookAdded.Text = "Kitap İşlemleri";
            // 
            // cmbxCategoryAdded
            // 
            this.cmbxCategoryAdded.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCategoryAdded.FormattingEnabled = true;
            this.cmbxCategoryAdded.Location = new System.Drawing.Point(100, 190);
            this.cmbxCategoryAdded.Name = "cmbxCategoryAdded";
            this.cmbxCategoryAdded.Size = new System.Drawing.Size(169, 22);
            this.cmbxCategoryAdded.TabIndex = 21;
            // 
            // cmbxAuthorAdded
            // 
            this.cmbxAuthorAdded.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxAuthorAdded.FormattingEnabled = true;
            this.cmbxAuthorAdded.Location = new System.Drawing.Point(100, 233);
            this.cmbxAuthorAdded.Name = "cmbxAuthorAdded";
            this.cmbxAuthorAdded.Size = new System.Drawing.Size(169, 22);
            this.cmbxAuthorAdded.TabIndex = 20;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(299, 156);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 46);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblPublisher
            // 
            this.lblPublisher.AutoSize = true;
            this.lblPublisher.Location = new System.Drawing.Point(25, 64);
            this.lblPublisher.Name = "lblPublisher";
            this.lblPublisher.Size = new System.Drawing.Size(61, 14);
            this.lblPublisher.TabIndex = 19;
            this.lblPublisher.Text = "Yayın Evi : ";
            // 
            // txtPublisher
            // 
            this.txtPublisher.Location = new System.Drawing.Point(100, 61);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.Size = new System.Drawing.Size(169, 22);
            this.txtPublisher.TabIndex = 18;
            // 
            // lblPageCount
            // 
            this.lblPageCount.AutoSize = true;
            this.lblPageCount.Location = new System.Drawing.Point(8, 109);
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(78, 14);
            this.lblPageCount.TabIndex = 17;
            this.lblPageCount.Text = "Sayfa Sayısı : ";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(100, 106);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(169, 22);
            this.txtPrice.TabIndex = 16;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(42, 151);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(42, 14);
            this.lblPrice.TabIndex = 15;
            this.lblPrice.Text = "Fiyat : ";
            // 
            // txtPageCount
            // 
            this.txtPageCount.Location = new System.Drawing.Point(100, 148);
            this.txtPageCount.Name = "txtPageCount";
            this.txtPageCount.Size = new System.Drawing.Size(169, 22);
            this.txtPageCount.TabIndex = 14;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(22, 23);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(64, 14);
            this.lblBookName.TabIndex = 13;
            this.lblBookName.Text = "Kitap Adı : ";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(100, 20);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(169, 22);
            this.txtBookName.TabIndex = 12;
            // 
            // lblCategoryAdded
            // 
            this.lblCategoryAdded.AutoSize = true;
            this.lblCategoryAdded.Location = new System.Drawing.Point(20, 193);
            this.lblCategoryAdded.Name = "lblCategoryAdded";
            this.lblCategoryAdded.Size = new System.Drawing.Size(64, 14);
            this.lblCategoryAdded.TabIndex = 11;
            this.lblCategoryAdded.Text = "Kategori  : ";
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemove.Location = new System.Drawing.Point(977, 23);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(125, 26);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "Sil";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtAuthorSearch
            // 
            this.txtAuthorSearch.Location = new System.Drawing.Point(517, 23);
            this.txtAuthorSearch.Name = "txtAuthorSearch";
            this.txtAuthorSearch.Size = new System.Drawing.Size(151, 23);
            this.txtAuthorSearch.TabIndex = 11;
            this.txtAuthorSearch.TextChanged += new System.EventHandler(this.txtAuthorSearch_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbFiltreleme);
            this.tabControl1.Controls.Add(this.tbGenelIslemler);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tgKiralamaIslemleri);
            this.tabControl1.Controls.Add(this.tgListeleme);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1177, 392);
            this.tabControl1.TabIndex = 12;
            // 
            // tbFiltreleme
            // 
            this.tbFiltreleme.Controls.Add(this.btnRemove);
            this.tbFiltreleme.Controls.Add(this.cbxCategory);
            this.tbFiltreleme.Controls.Add(this.txtAuthorSearch);
            this.tbFiltreleme.Controls.Add(this.dgwBook);
            this.tbFiltreleme.Controls.Add(this.lblCategorySearch);
            this.tbFiltreleme.Controls.Add(this.lblBookSearch);
            this.tbFiltreleme.Location = new System.Drawing.Point(4, 24);
            this.tbFiltreleme.Name = "tbFiltreleme";
            this.tbFiltreleme.Padding = new System.Windows.Forms.Padding(3);
            this.tbFiltreleme.Size = new System.Drawing.Size(1169, 364);
            this.tbFiltreleme.TabIndex = 0;
            this.tbFiltreleme.Text = "Filtreleme";
            this.tbFiltreleme.UseVisualStyleBackColor = true;
            // 
            // tbGenelIslemler
            // 
            this.tbGenelIslemler.Controls.Add(this.btnYazarEkle);
            this.tbGenelIslemler.Controls.Add(this.dgwYazar);
            this.tbGenelIslemler.Controls.Add(this.btnKategoriEkle);
            this.tbGenelIslemler.Controls.Add(this.btnYazarSil);
            this.tbGenelIslemler.Controls.Add(this.btnYazarGüncelle);
            this.tbGenelIslemler.Controls.Add(this.btnKategoriGüncelle);
            this.tbGenelIslemler.Controls.Add(this.btnKategoriSil);
            this.tbGenelIslemler.Controls.Add(this.dgwKategori);
            this.tbGenelIslemler.Controls.Add(this.label2);
            this.tbGenelIslemler.Controls.Add(this.txtKategori);
            this.tbGenelIslemler.Controls.Add(this.label1);
            this.tbGenelIslemler.Controls.Add(this.txtYazar);
            this.tbGenelIslemler.Controls.Add(this.grpBookAdded);
            this.tbGenelIslemler.Location = new System.Drawing.Point(4, 24);
            this.tbGenelIslemler.Name = "tbGenelIslemler";
            this.tbGenelIslemler.Padding = new System.Windows.Forms.Padding(3);
            this.tbGenelIslemler.Size = new System.Drawing.Size(1169, 364);
            this.tbGenelIslemler.TabIndex = 1;
            this.tbGenelIslemler.Text = "Genel İşlemler";
            this.tbGenelIslemler.UseVisualStyleBackColor = true;
            // 
            // btnYazarEkle
            // 
            this.btnYazarEkle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnYazarEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazarEkle.Location = new System.Drawing.Point(802, 70);
            this.btnYazarEkle.Name = "btnYazarEkle";
            this.btnYazarEkle.Size = new System.Drawing.Size(75, 23);
            this.btnYazarEkle.TabIndex = 19;
            this.btnYazarEkle.Text = "Ekle";
            this.btnYazarEkle.UseVisualStyleBackColor = false;
            this.btnYazarEkle.Click += new System.EventHandler(this.btnYazarEkle_Click);
            // 
            // dgwYazar
            // 
            this.dgwYazar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgwYazar.BackgroundColor = System.Drawing.Color.White;
            this.dgwYazar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwYazar.Location = new System.Drawing.Point(792, 109);
            this.dgwYazar.Name = "dgwYazar";
            this.dgwYazar.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwYazar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwYazar.Size = new System.Drawing.Size(305, 183);
            this.dgwYazar.TabIndex = 11;
            this.dgwYazar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwYazar_CellClick);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKategoriEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriEkle.Location = new System.Drawing.Point(18, 70);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKategoriEkle.TabIndex = 18;
            this.btnKategoriEkle.Text = "Ekle";
            this.btnKategoriEkle.UseVisualStyleBackColor = false;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnYazarSil
            // 
            this.btnYazarSil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnYazarSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazarSil.Location = new System.Drawing.Point(1009, 70);
            this.btnYazarSil.Name = "btnYazarSil";
            this.btnYazarSil.Size = new System.Drawing.Size(75, 23);
            this.btnYazarSil.TabIndex = 17;
            this.btnYazarSil.Text = "Sil";
            this.btnYazarSil.UseVisualStyleBackColor = false;
            this.btnYazarSil.Click += new System.EventHandler(this.btnYazarSil_Click);
            // 
            // btnYazarGüncelle
            // 
            this.btnYazarGüncelle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnYazarGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazarGüncelle.Location = new System.Drawing.Point(906, 70);
            this.btnYazarGüncelle.Name = "btnYazarGüncelle";
            this.btnYazarGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnYazarGüncelle.TabIndex = 16;
            this.btnYazarGüncelle.Text = "Güncelle";
            this.btnYazarGüncelle.UseVisualStyleBackColor = false;
            this.btnYazarGüncelle.Click += new System.EventHandler(this.btnYazarGüncelle_Click);
            // 
            // btnKategoriGüncelle
            // 
            this.btnKategoriGüncelle.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKategoriGüncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriGüncelle.Location = new System.Drawing.Point(110, 70);
            this.btnKategoriGüncelle.Name = "btnKategoriGüncelle";
            this.btnKategoriGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnKategoriGüncelle.TabIndex = 14;
            this.btnKategoriGüncelle.Text = "Güncelle";
            this.btnKategoriGüncelle.UseVisualStyleBackColor = false;
            this.btnKategoriGüncelle.Click += new System.EventHandler(this.btnKategoriGüncelle_Click);
            // 
            // btnKategoriSil
            // 
            this.btnKategoriSil.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKategoriSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriSil.Location = new System.Drawing.Point(203, 70);
            this.btnKategoriSil.Name = "btnKategoriSil";
            this.btnKategoriSil.Size = new System.Drawing.Size(75, 23);
            this.btnKategoriSil.TabIndex = 13;
            this.btnKategoriSil.Text = "Sil";
            this.btnKategoriSil.UseVisualStyleBackColor = false;
            this.btnKategoriSil.Click += new System.EventHandler(this.btnKategoriSil_Click);
            // 
            // dgwKategori
            // 
            this.dgwKategori.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgwKategori.BackgroundColor = System.Drawing.Color.White;
            this.dgwKategori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwKategori.GridColor = System.Drawing.Color.White;
            this.dgwKategori.Location = new System.Drawing.Point(6, 109);
            this.dgwKategori.Name = "dgwKategori";
            this.dgwKategori.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgwKategori.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwKategori.Size = new System.Drawing.Size(295, 183);
            this.dgwKategori.TabIndex = 12;
            this.dgwKategori.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwKategori_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kategori  Adı: ";
            // 
            // txtKategori
            // 
            this.txtKategori.Location = new System.Drawing.Point(103, 28);
            this.txtKategori.Name = "txtKategori";
            this.txtKategori.Size = new System.Drawing.Size(162, 23);
            this.txtKategori.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(789, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazar Adı:";
            // 
            // txtYazar
            // 
            this.txtYazar.Location = new System.Drawing.Point(853, 32);
            this.txtYazar.Name = "txtYazar";
            this.txtYazar.Size = new System.Drawing.Size(162, 23);
            this.txtYazar.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.btnCustomerRemove);
            this.tabPage3.Controls.Add(this.btnCustomerUpdated);
            this.tabPage3.Controls.Add(this.btnCustomerAdded);
            this.tabPage3.Controls.Add(this.dgwCustomer);
            this.tabPage3.Controls.Add(this.txtCustomerAge);
            this.tabPage3.Controls.Add(this.rbKadın);
            this.tabPage3.Controls.Add(this.rbErkek);
            this.tabPage3.Controls.Add(this.txtCustomerJob);
            this.tabPage3.Controls.Add(this.txtCustomerName);
            this.tabPage3.Controls.Add(this.lblCustomerAge);
            this.tabPage3.Controls.Add(this.lblCustomerGender);
            this.tabPage3.Controls.Add(this.lblCustomerJob);
            this.tabPage3.Controls.Add(this.lblCustomerName);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1169, 364);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Müşteri İşlemleri";
            // 
            // btnCustomerRemove
            // 
            this.btnCustomerRemove.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCustomerRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerRemove.Location = new System.Drawing.Point(214, 202);
            this.btnCustomerRemove.Name = "btnCustomerRemove";
            this.btnCustomerRemove.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerRemove.TabIndex = 12;
            this.btnCustomerRemove.Text = "Sil";
            this.btnCustomerRemove.UseVisualStyleBackColor = false;
            this.btnCustomerRemove.Click += new System.EventHandler(this.btnCustomerRemove_Click);
            // 
            // btnCustomerUpdated
            // 
            this.btnCustomerUpdated.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCustomerUpdated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerUpdated.Location = new System.Drawing.Point(120, 202);
            this.btnCustomerUpdated.Name = "btnCustomerUpdated";
            this.btnCustomerUpdated.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerUpdated.TabIndex = 11;
            this.btnCustomerUpdated.Text = "Güncelle";
            this.btnCustomerUpdated.UseVisualStyleBackColor = false;
            this.btnCustomerUpdated.Click += new System.EventHandler(this.btnCustomerUpdated_Click);
            // 
            // btnCustomerAdded
            // 
            this.btnCustomerAdded.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCustomerAdded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomerAdded.Location = new System.Drawing.Point(28, 202);
            this.btnCustomerAdded.Name = "btnCustomerAdded";
            this.btnCustomerAdded.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerAdded.TabIndex = 10;
            this.btnCustomerAdded.Text = "Ekle";
            this.btnCustomerAdded.UseVisualStyleBackColor = false;
            this.btnCustomerAdded.Click += new System.EventHandler(this.btnCustomerAdded_Click);
            // 
            // dgwCustomer
            // 
            this.dgwCustomer.BackgroundColor = System.Drawing.Color.White;
            this.dgwCustomer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCustomer.Location = new System.Drawing.Point(312, 31);
            this.dgwCustomer.Name = "dgwCustomer";
            this.dgwCustomer.Size = new System.Drawing.Size(789, 194);
            this.dgwCustomer.TabIndex = 9;
            this.dgwCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwCustomer_CellClick);
            // 
            // txtCustomerAge
            // 
            this.txtCustomerAge.Location = new System.Drawing.Point(120, 147);
            this.txtCustomerAge.Name = "txtCustomerAge";
            this.txtCustomerAge.Size = new System.Drawing.Size(159, 23);
            this.txtCustomerAge.TabIndex = 8;
            // 
            // rbKadın
            // 
            this.rbKadın.AutoSize = true;
            this.rbKadın.Location = new System.Drawing.Point(200, 113);
            this.rbKadın.Name = "rbKadın";
            this.rbKadın.Size = new System.Drawing.Size(56, 19);
            this.rbKadın.TabIndex = 7;
            this.rbKadın.TabStop = true;
            this.rbKadın.Text = "Kadın";
            this.rbKadın.UseVisualStyleBackColor = true;
            // 
            // rbErkek
            // 
            this.rbErkek.AutoSize = true;
            this.rbErkek.Location = new System.Drawing.Point(125, 113);
            this.rbErkek.Name = "rbErkek";
            this.rbErkek.Size = new System.Drawing.Size(54, 19);
            this.rbErkek.TabIndex = 6;
            this.rbErkek.TabStop = true;
            this.rbErkek.Text = "Erkek";
            this.rbErkek.UseVisualStyleBackColor = true;
            // 
            // txtCustomerJob
            // 
            this.txtCustomerJob.Location = new System.Drawing.Point(120, 75);
            this.txtCustomerJob.Name = "txtCustomerJob";
            this.txtCustomerJob.Size = new System.Drawing.Size(155, 23);
            this.txtCustomerJob.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(120, 36);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(155, 23);
            this.txtCustomerName.TabIndex = 4;
            // 
            // lblCustomerAge
            // 
            this.lblCustomerAge.AutoSize = true;
            this.lblCustomerAge.Location = new System.Drawing.Point(81, 150);
            this.lblCustomerAge.Name = "lblCustomerAge";
            this.lblCustomerAge.Size = new System.Drawing.Size(33, 15);
            this.lblCustomerAge.TabIndex = 3;
            this.lblCustomerAge.Text = "Yaş : ";
            // 
            // lblCustomerGender
            // 
            this.lblCustomerGender.AutoSize = true;
            this.lblCustomerGender.Location = new System.Drawing.Point(54, 117);
            this.lblCustomerGender.Name = "lblCustomerGender";
            this.lblCustomerGender.Size = new System.Drawing.Size(60, 15);
            this.lblCustomerGender.TabIndex = 2;
            this.lblCustomerGender.Text = "Cinsiyet : ";
            // 
            // lblCustomerJob
            // 
            this.lblCustomerJob.AutoSize = true;
            this.lblCustomerJob.Location = new System.Drawing.Point(59, 78);
            this.lblCustomerJob.Name = "lblCustomerJob";
            this.lblCustomerJob.Size = new System.Drawing.Size(55, 15);
            this.lblCustomerJob.TabIndex = 1;
            this.lblCustomerJob.Text = "Meslek : ";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(6, 39);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(108, 15);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "Müşteri Ad Soyad :";
            // 
            // tgKiralamaIslemleri
            // 
            this.tgKiralamaIslemleri.Controls.Add(this.btnKitapKirala);
            this.tgKiralamaIslemleri.Controls.Add(this.dpDonusDate);
            this.tgKiralamaIslemleri.Controls.Add(this.lblDönüşTarihi);
            this.tgKiralamaIslemleri.Controls.Add(this.dpRentDate);
            this.tgKiralamaIslemleri.Controls.Add(this.lblKiralamaTarihi);
            this.tgKiralamaIslemleri.Controls.Add(this.lnlMüşteriAdıKiralama);
            this.tgKiralamaIslemleri.Controls.Add(this.cbxMüsteriAdıKiralama);
            this.tgKiralamaIslemleri.Controls.Add(this.lblKitapAdıKiralama);
            this.tgKiralamaIslemleri.Controls.Add(this.cbxKitapAdıKiralama);
            this.tgKiralamaIslemleri.Location = new System.Drawing.Point(4, 24);
            this.tgKiralamaIslemleri.Name = "tgKiralamaIslemleri";
            this.tgKiralamaIslemleri.Size = new System.Drawing.Size(1169, 364);
            this.tgKiralamaIslemleri.TabIndex = 4;
            this.tgKiralamaIslemleri.Text = "Kiralama İşlemleri";
            this.tgKiralamaIslemleri.UseVisualStyleBackColor = true;
            // 
            // btnKitapKirala
            // 
            this.btnKitapKirala.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKitapKirala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapKirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapKirala.Location = new System.Drawing.Point(110, 215);
            this.btnKitapKirala.Name = "btnKitapKirala";
            this.btnKitapKirala.Size = new System.Drawing.Size(139, 35);
            this.btnKitapKirala.TabIndex = 8;
            this.btnKitapKirala.Text = "Kirala";
            this.btnKitapKirala.UseVisualStyleBackColor = false;
            this.btnKitapKirala.Click += new System.EventHandler(this.btnKitapKirala_Click);
            // 
            // dpDonusDate
            // 
            this.dpDonusDate.Location = new System.Drawing.Point(124, 170);
            this.dpDonusDate.Name = "dpDonusDate";
            this.dpDonusDate.Size = new System.Drawing.Size(200, 23);
            this.dpDonusDate.TabIndex = 7;
            // 
            // lblDönüşTarihi
            // 
            this.lblDönüşTarihi.AutoSize = true;
            this.lblDönüşTarihi.Location = new System.Drawing.Point(20, 176);
            this.lblDönüşTarihi.Name = "lblDönüşTarihi";
            this.lblDönüşTarihi.Size = new System.Drawing.Size(85, 15);
            this.lblDönüşTarihi.TabIndex = 6;
            this.lblDönüşTarihi.Text = "Dönüş Tarihi : ";
            // 
            // dpRentDate
            // 
            this.dpRentDate.Location = new System.Drawing.Point(124, 117);
            this.dpRentDate.Name = "dpRentDate";
            this.dpRentDate.Size = new System.Drawing.Size(193, 23);
            this.dpRentDate.TabIndex = 5;
            // 
            // lblKiralamaTarihi
            // 
            this.lblKiralamaTarihi.AutoSize = true;
            this.lblKiralamaTarihi.Location = new System.Drawing.Point(20, 123);
            this.lblKiralamaTarihi.Name = "lblKiralamaTarihi";
            this.lblKiralamaTarihi.Size = new System.Drawing.Size(102, 15);
            this.lblKiralamaTarihi.TabIndex = 4;
            this.lblKiralamaTarihi.Text = "Kiralama Tarihi : ";
            // 
            // lnlMüşteriAdıKiralama
            // 
            this.lnlMüşteriAdıKiralama.AutoSize = true;
            this.lnlMüşteriAdıKiralama.Location = new System.Drawing.Point(20, 75);
            this.lnlMüşteriAdıKiralama.Name = "lnlMüşteriAdıKiralama";
            this.lnlMüşteriAdıKiralama.Size = new System.Drawing.Size(78, 15);
            this.lnlMüşteriAdıKiralama.TabIndex = 3;
            this.lnlMüşteriAdıKiralama.Text = "Müşteri Adı : ";
            // 
            // cbxMüsteriAdıKiralama
            // 
            this.cbxMüsteriAdıKiralama.FormattingEnabled = true;
            this.cbxMüsteriAdıKiralama.Location = new System.Drawing.Point(124, 67);
            this.cbxMüsteriAdıKiralama.Name = "cbxMüsteriAdıKiralama";
            this.cbxMüsteriAdıKiralama.Size = new System.Drawing.Size(193, 23);
            this.cbxMüsteriAdıKiralama.TabIndex = 2;
            // 
            // lblKitapAdıKiralama
            // 
            this.lblKitapAdıKiralama.AutoSize = true;
            this.lblKitapAdıKiralama.Location = new System.Drawing.Point(20, 23);
            this.lblKitapAdıKiralama.Name = "lblKitapAdıKiralama";
            this.lblKitapAdıKiralama.Size = new System.Drawing.Size(62, 15);
            this.lblKitapAdıKiralama.TabIndex = 1;
            this.lblKitapAdıKiralama.Text = "Kitap Adı :";
            // 
            // cbxKitapAdıKiralama
            // 
            this.cbxKitapAdıKiralama.FormattingEnabled = true;
            this.cbxKitapAdıKiralama.Location = new System.Drawing.Point(124, 15);
            this.cbxKitapAdıKiralama.Name = "cbxKitapAdıKiralama";
            this.cbxKitapAdıKiralama.Size = new System.Drawing.Size(193, 23);
            this.cbxKitapAdıKiralama.TabIndex = 0;
            // 
            // tgListeleme
            // 
            this.tgListeleme.Controls.Add(this.btnKiralamaListeleme);
            this.tgListeleme.Controls.Add(this.btnKategoriListeleme);
            this.tgListeleme.Controls.Add(this.btnYazarListeleme);
            this.tgListeleme.Controls.Add(this.dgwListeleme);
            this.tgListeleme.Controls.Add(this.btnKitapListeleme);
            this.tgListeleme.Location = new System.Drawing.Point(4, 24);
            this.tgListeleme.Name = "tgListeleme";
            this.tgListeleme.Size = new System.Drawing.Size(1169, 364);
            this.tgListeleme.TabIndex = 3;
            this.tgListeleme.Text = "Listeleme Yönetimi";
            this.tgListeleme.UseVisualStyleBackColor = true;
            // 
            // btnKiralamaListeleme
            // 
            this.btnKiralamaListeleme.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKiralamaListeleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKiralamaListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKiralamaListeleme.Location = new System.Drawing.Point(16, 177);
            this.btnKiralamaListeleme.Name = "btnKiralamaListeleme";
            this.btnKiralamaListeleme.Size = new System.Drawing.Size(139, 39);
            this.btnKiralamaListeleme.TabIndex = 4;
            this.btnKiralamaListeleme.Text = "Kiralanan Kitaplar";
            this.btnKiralamaListeleme.UseVisualStyleBackColor = false;
            this.btnKiralamaListeleme.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKategoriListeleme
            // 
            this.btnKategoriListeleme.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKategoriListeleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKategoriListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKategoriListeleme.Location = new System.Drawing.Point(16, 121);
            this.btnKategoriListeleme.Name = "btnKategoriListeleme";
            this.btnKategoriListeleme.Size = new System.Drawing.Size(139, 38);
            this.btnKategoriListeleme.TabIndex = 3;
            this.btnKategoriListeleme.Text = "Kategori Listeleme";
            this.btnKategoriListeleme.UseVisualStyleBackColor = false;
            this.btnKategoriListeleme.Click += new System.EventHandler(this.btnKategoriListeleme_Click);
            // 
            // btnYazarListeleme
            // 
            this.btnYazarListeleme.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnYazarListeleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazarListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazarListeleme.Location = new System.Drawing.Point(16, 67);
            this.btnYazarListeleme.Name = "btnYazarListeleme";
            this.btnYazarListeleme.Size = new System.Drawing.Size(139, 37);
            this.btnYazarListeleme.TabIndex = 2;
            this.btnYazarListeleme.Text = "Yazar Listeleme";
            this.btnYazarListeleme.UseVisualStyleBackColor = false;
            this.btnYazarListeleme.Click += new System.EventHandler(this.btnYazarListeleme_Click);
            // 
            // dgwListeleme
            // 
            this.dgwListeleme.BackgroundColor = System.Drawing.Color.White;
            this.dgwListeleme.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwListeleme.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwListeleme.Location = new System.Drawing.Point(154, 16);
            this.dgwListeleme.Name = "dgwListeleme";
            this.dgwListeleme.Size = new System.Drawing.Size(918, 224);
            this.dgwListeleme.TabIndex = 1;
            // 
            // btnKitapListeleme
            // 
            this.btnKitapListeleme.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnKitapListeleme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKitapListeleme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKitapListeleme.Location = new System.Drawing.Point(16, 16);
            this.btnKitapListeleme.Name = "btnKitapListeleme";
            this.btnKitapListeleme.Size = new System.Drawing.Size(139, 34);
            this.btnKitapListeleme.TabIndex = 0;
            this.btnKitapListeleme.Text = "Kitap Listeleme";
            this.btnKitapListeleme.UseVisualStyleBackColor = false;
            this.btnKitapListeleme.Click += new System.EventHandler(this.btnKitapListeleme_Click);
            // 
            // SaphiraLibrary
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1177, 392);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SaphiraLibrary";
            this.Text = "Saphira Library";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwBook)).EndInit();
            this.grpBookAdded.ResumeLayout(false);
            this.grpBookAdded.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tbFiltreleme.ResumeLayout(false);
            this.tbFiltreleme.PerformLayout();
            this.tbGenelIslemler.ResumeLayout(false);
            this.tbGenelIslemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwYazar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKategori)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCustomer)).EndInit();
            this.tgKiralamaIslemleri.ResumeLayout(false);
            this.tgKiralamaIslemleri.PerformLayout();
            this.tgListeleme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgwListeleme)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwBook;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategorySearch;
        private System.Windows.Forms.Label lblBookSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblAuthorAdded;
        private System.Windows.Forms.GroupBox grpBookAdded;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbxCategoryAdded;
        private System.Windows.Forms.ComboBox cmbxAuthorAdded;
        private System.Windows.Forms.Label lblPublisher;
        private System.Windows.Forms.TextBox txtPublisher;
        private System.Windows.Forms.Label lblPageCount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtPageCount;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblCategoryAdded;
        private System.Windows.Forms.TextBox txtAuthorSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbFiltreleme;
        private System.Windows.Forms.TabPage tbGenelIslemler;
        private System.Windows.Forms.TextBox txtKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtYazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgwKategori;
        private System.Windows.Forms.DataGridView dgwYazar;
        private System.Windows.Forms.Button btnYazarSil;
        private System.Windows.Forms.Button btnYazarGüncelle;
        private System.Windows.Forms.Button btnKategoriGüncelle;
        private System.Windows.Forms.Button btnKategoriSil;
        private System.Windows.Forms.Button btnYazarEkle;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tgListeleme;
        private System.Windows.Forms.DataGridView dgwListeleme;
        private System.Windows.Forms.Button btnKitapListeleme;
        private System.Windows.Forms.Button btnKategoriListeleme;
        private System.Windows.Forms.Button btnYazarListeleme;
        private System.Windows.Forms.Button btnCustomerRemove;
        private System.Windows.Forms.Button btnCustomerUpdated;
        private System.Windows.Forms.Button btnCustomerAdded;
        private System.Windows.Forms.DataGridView dgwCustomer;
        private System.Windows.Forms.TextBox txtCustomerAge;
        private System.Windows.Forms.RadioButton rbKadın;
        private System.Windows.Forms.RadioButton rbErkek;
        private System.Windows.Forms.TextBox txtCustomerJob;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerAge;
        private System.Windows.Forms.Label lblCustomerGender;
        private System.Windows.Forms.Label lblCustomerJob;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TabPage tgKiralamaIslemleri;
        private System.Windows.Forms.Button btnKitapKirala;
        private System.Windows.Forms.DateTimePicker dpDonusDate;
        private System.Windows.Forms.Label lblDönüşTarihi;
        private System.Windows.Forms.DateTimePicker dpRentDate;
        private System.Windows.Forms.Label lblKiralamaTarihi;
        private System.Windows.Forms.Label lnlMüşteriAdıKiralama;
        private System.Windows.Forms.ComboBox cbxMüsteriAdıKiralama;
        private System.Windows.Forms.Label lblKitapAdıKiralama;
        private System.Windows.Forms.ComboBox cbxKitapAdıKiralama;
        private System.Windows.Forms.Button btnKiralamaListeleme;
    }
}