namespace BookStore
{
    partial class FormAddBook
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
            this.panelCover = new System.Windows.Forms.Panel();
            this.buttonAddCover = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.panelBookInfo = new System.Windows.Forms.Panel();
            this.groupBoxAddNew = new System.Windows.Forms.GroupBox();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.tbAddNew = new System.Windows.Forms.TextBox();
            this.cbAddNew = new System.Windows.Forms.ComboBox();
            this.cbAgeLimit = new System.Windows.Forms.ComboBox();
            this.btnEditBook = new System.Windows.Forms.Button();
            this.tbYearOfPublishing = new System.Windows.Forms.TextBox();
            this.numericUpDownPageCount = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.groupBoxGenre = new System.Windows.Forms.GroupBox();
            this.pictureBoxDeleteGenre = new System.Windows.Forms.PictureBox();
            this.tableGenre = new System.Windows.Forms.DataGridView();
            this.cbGenre = new System.Windows.Forms.ComboBox();
            this.pictureBoxAddGenre = new System.Windows.Forms.PictureBox();
            this.groupBoxAuthor = new System.Windows.Forms.GroupBox();
            this.pictureBoxDeleteAuthor = new System.Windows.Forms.PictureBox();
            this.tableAuthor = new System.Windows.Forms.DataGridView();
            this.cbAuthor = new System.Windows.Forms.ComboBox();
            this.pictureBoxAddAuthor = new System.Windows.Forms.PictureBox();
            this.cbCoverType = new System.Windows.Forms.ComboBox();
            this.cbPublishing = new System.Windows.Forms.ComboBox();
            this.tbISBN = new System.Windows.Forms.TextBox();
            this.tbNameBook = new System.Windows.Forms.TextBox();
            this.lblCoverType = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblAgeLimit = new System.Windows.Forms.Label();
            this.lblCountPage = new System.Windows.Forms.Label();
            this.lblPublishing = new System.Windows.Forms.Label();
            this.lblYearPublishing = new System.Windows.Forms.Label();
            this.lblNameBook = new System.Windows.Forms.Label();
            this.panelCover.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.panelBookInfo.SuspendLayout();
            this.groupBoxAddNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPageCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.groupBoxGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGenre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddGenre)).BeginInit();
            this.groupBoxAuthor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAuthor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCover
            // 
            this.panelCover.BackColor = System.Drawing.Color.Transparent;
            this.panelCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCover.Controls.Add(this.buttonAddCover);
            this.panelCover.Controls.Add(this.pictureBoxCover);
            this.panelCover.Location = new System.Drawing.Point(690, 12);
            this.panelCover.Name = "panelCover";
            this.panelCover.Size = new System.Drawing.Size(267, 349);
            this.panelCover.TabIndex = 17;
            // 
            // buttonAddCover
            // 
            this.buttonAddCover.AutoSize = true;
            this.buttonAddCover.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddCover.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddCover.Location = new System.Drawing.Point(14, 294);
            this.buttonAddCover.Name = "buttonAddCover";
            this.buttonAddCover.Size = new System.Drawing.Size(234, 38);
            this.buttonAddCover.TabIndex = 19;
            this.buttonAddCover.Text = "Загрузить обложку";
            this.buttonAddCover.UseVisualStyleBackColor = false;
            this.buttonAddCover.Click += new System.EventHandler(this.buttonAddCover_Click);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(14, 17);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(234, 263);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 0;
            this.pictureBoxCover.TabStop = false;
            // 
            // panelBookInfo
            // 
            this.panelBookInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBookInfo.Controls.Add(this.groupBoxAddNew);
            this.panelBookInfo.Controls.Add(this.cbAgeLimit);
            this.panelBookInfo.Controls.Add(this.btnEditBook);
            this.panelBookInfo.Controls.Add(this.tbYearOfPublishing);
            this.panelBookInfo.Controls.Add(this.numericUpDownPageCount);
            this.panelBookInfo.Controls.Add(this.panelCover);
            this.panelBookInfo.Controls.Add(this.pictureBoxExit);
            this.panelBookInfo.Controls.Add(this.btnAddBook);
            this.panelBookInfo.Controls.Add(this.lblDescription);
            this.panelBookInfo.Controls.Add(this.groupBoxGenre);
            this.panelBookInfo.Controls.Add(this.groupBoxAuthor);
            this.panelBookInfo.Controls.Add(this.cbCoverType);
            this.panelBookInfo.Controls.Add(this.cbPublishing);
            this.panelBookInfo.Controls.Add(this.tbISBN);
            this.panelBookInfo.Controls.Add(this.tbNameBook);
            this.panelBookInfo.Controls.Add(this.lblCoverType);
            this.panelBookInfo.Controls.Add(this.richTextBoxDescription);
            this.panelBookInfo.Controls.Add(this.lblISBN);
            this.panelBookInfo.Controls.Add(this.lblAgeLimit);
            this.panelBookInfo.Controls.Add(this.lblCountPage);
            this.panelBookInfo.Controls.Add(this.lblPublishing);
            this.panelBookInfo.Controls.Add(this.lblYearPublishing);
            this.panelBookInfo.Controls.Add(this.lblNameBook);
            this.panelBookInfo.Location = new System.Drawing.Point(12, 13);
            this.panelBookInfo.Name = "panelBookInfo";
            this.panelBookInfo.Size = new System.Drawing.Size(977, 788);
            this.panelBookInfo.TabIndex = 16;
            // 
            // groupBoxAddNew
            // 
            this.groupBoxAddNew.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAddNew.Controls.Add(this.btnAddNew);
            this.groupBoxAddNew.Controls.Add(this.tbAddNew);
            this.groupBoxAddNew.Controls.Add(this.cbAddNew);
            this.groupBoxAddNew.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAddNew.Location = new System.Drawing.Point(690, 371);
            this.groupBoxAddNew.Name = "groupBoxAddNew";
            this.groupBoxAddNew.Size = new System.Drawing.Size(267, 175);
            this.groupBoxAddNew.TabIndex = 52;
            this.groupBoxAddNew.TabStop = false;
            this.groupBoxAddNew.Text = "Добавить новое";
            // 
            // btnAddNew
            // 
            this.btnAddNew.AutoSize = true;
            this.btnAddNew.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNew.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNew.Location = new System.Drawing.Point(15, 120);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(106, 38);
            this.btnAddNew.TabIndex = 53;
            this.btnAddNew.Text = "Добавить";
            this.btnAddNew.UseVisualStyleBackColor = false;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // tbAddNew
            // 
            this.tbAddNew.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbAddNew.Location = new System.Drawing.Point(15, 83);
            this.tbAddNew.Name = "tbAddNew";
            this.tbAddNew.Size = new System.Drawing.Size(234, 31);
            this.tbAddNew.TabIndex = 53;
            // 
            // cbAddNew
            // 
            this.cbAddNew.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAddNew.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAddNew.FormattingEnabled = true;
            this.cbAddNew.Items.AddRange(new object[] {
            "Автор",
            "Жанр",
            "Издательство"});
            this.cbAddNew.Location = new System.Drawing.Point(15, 39);
            this.cbAddNew.Name = "cbAddNew";
            this.cbAddNew.Size = new System.Drawing.Size(234, 32);
            this.cbAddNew.TabIndex = 53;
            // 
            // cbAgeLimit
            // 
            this.cbAgeLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAgeLimit.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAgeLimit.FormattingEnabled = true;
            this.cbAgeLimit.Items.AddRange(new object[] {
            "0+",
            "6+",
            "12+",
            "16+",
            "18+"});
            this.cbAgeLimit.Location = new System.Drawing.Point(245, 406);
            this.cbAgeLimit.Name = "cbAgeLimit";
            this.cbAgeLimit.Size = new System.Drawing.Size(117, 32);
            this.cbAgeLimit.TabIndex = 32;
            // 
            // btnEditBook
            // 
            this.btnEditBook.AutoSize = true;
            this.btnEditBook.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEditBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditBook.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEditBook.Location = new System.Drawing.Point(705, 579);
            this.btnEditBook.Name = "btnEditBook";
            this.btnEditBook.Size = new System.Drawing.Size(242, 38);
            this.btnEditBook.TabIndex = 51;
            this.btnEditBook.Text = "Сохранить изменения";
            this.btnEditBook.UseVisualStyleBackColor = false;
            this.btnEditBook.Click += new System.EventHandler(this.btnEditBook_Click);
            // 
            // tbYearOfPublishing
            // 
            this.tbYearOfPublishing.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbYearOfPublishing.Location = new System.Drawing.Point(523, 309);
            this.tbYearOfPublishing.Name = "tbYearOfPublishing";
            this.tbYearOfPublishing.Size = new System.Drawing.Size(142, 31);
            this.tbYearOfPublishing.TabIndex = 50;
            // 
            // numericUpDownPageCount
            // 
            this.numericUpDownPageCount.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownPageCount.Location = new System.Drawing.Point(580, 359);
            this.numericUpDownPageCount.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownPageCount.Name = "numericUpDownPageCount";
            this.numericUpDownPageCount.Size = new System.Drawing.Size(85, 31);
            this.numericUpDownPageCount.TabIndex = 49;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = global::BookStore.Properties.Resources.exit_icon_icons_com_70975;
            this.pictureBoxExit.Location = new System.Drawing.Point(907, 721);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 18;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.AutoSize = true;
            this.btnAddBook.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddBook.Location = new System.Drawing.Point(705, 623);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(242, 38);
            this.btnAddBook.TabIndex = 20;
            this.btnAddBook.Text = "Добавить книгу";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDescription.Location = new System.Drawing.Point(11, 454);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(99, 24);
            this.lblDescription.TabIndex = 48;
            this.lblDescription.Text = "Описание:";
            // 
            // groupBoxGenre
            // 
            this.groupBoxGenre.Controls.Add(this.pictureBoxDeleteGenre);
            this.groupBoxGenre.Controls.Add(this.tableGenre);
            this.groupBoxGenre.Controls.Add(this.cbGenre);
            this.groupBoxGenre.Controls.Add(this.pictureBoxAddGenre);
            this.groupBoxGenre.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxGenre.Location = new System.Drawing.Point(15, 174);
            this.groupBoxGenre.Name = "groupBoxGenre";
            this.groupBoxGenre.Size = new System.Drawing.Size(658, 119);
            this.groupBoxGenre.TabIndex = 47;
            this.groupBoxGenre.TabStop = false;
            this.groupBoxGenre.Text = "Жанр";
            // 
            // pictureBoxDeleteGenre
            // 
            this.pictureBoxDeleteGenre.Image = global::BookStore.Properties.Resources._1487086345_cross_81577;
            this.pictureBoxDeleteGenre.Location = new System.Drawing.Point(613, 74);
            this.pictureBoxDeleteGenre.Name = "pictureBoxDeleteGenre";
            this.pictureBoxDeleteGenre.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxDeleteGenre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDeleteGenre.TabIndex = 43;
            this.pictureBoxDeleteGenre.TabStop = false;
            this.pictureBoxDeleteGenre.Click += new System.EventHandler(this.pictureBoxDeleteGenre_Click);
            // 
            // tableGenre
            // 
            this.tableGenre.AllowUserToAddRows = false;
            this.tableGenre.AllowUserToDeleteRows = false;
            this.tableGenre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableGenre.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableGenre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGenre.ColumnHeadersVisible = false;
            this.tableGenre.Location = new System.Drawing.Point(358, 30);
            this.tableGenre.Name = "tableGenre";
            this.tableGenre.ReadOnly = true;
            this.tableGenre.RowHeadersVisible = false;
            this.tableGenre.Size = new System.Drawing.Size(249, 69);
            this.tableGenre.TabIndex = 42;
            // 
            // cbGenre
            // 
            this.cbGenre.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbGenre.FormattingEnabled = true;
            this.cbGenre.Location = new System.Drawing.Point(20, 30);
            this.cbGenre.Name = "cbGenre";
            this.cbGenre.Size = new System.Drawing.Size(242, 32);
            this.cbGenre.TabIndex = 40;
            // 
            // pictureBoxAddGenre
            // 
            this.pictureBoxAddGenre.Image = global::BookStore.Properties.Resources.plus_icon_icons_com_70890;
            this.pictureBoxAddGenre.InitialImage = null;
            this.pictureBoxAddGenre.Location = new System.Drawing.Point(295, 30);
            this.pictureBoxAddGenre.Name = "pictureBoxAddGenre";
            this.pictureBoxAddGenre.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxAddGenre.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAddGenre.TabIndex = 41;
            this.pictureBoxAddGenre.TabStop = false;
            this.pictureBoxAddGenre.Click += new System.EventHandler(this.pictureBoxAddGenre_Click);
            // 
            // groupBoxAuthor
            // 
            this.groupBoxAuthor.Controls.Add(this.pictureBoxDeleteAuthor);
            this.groupBoxAuthor.Controls.Add(this.tableAuthor);
            this.groupBoxAuthor.Controls.Add(this.cbAuthor);
            this.groupBoxAuthor.Controls.Add(this.pictureBoxAddAuthor);
            this.groupBoxAuthor.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxAuthor.Location = new System.Drawing.Point(15, 49);
            this.groupBoxAuthor.Name = "groupBoxAuthor";
            this.groupBoxAuthor.Size = new System.Drawing.Size(658, 119);
            this.groupBoxAuthor.TabIndex = 46;
            this.groupBoxAuthor.TabStop = false;
            this.groupBoxAuthor.Text = "Автор";
            // 
            // pictureBoxDeleteAuthor
            // 
            this.pictureBoxDeleteAuthor.Image = global::BookStore.Properties.Resources._1487086345_cross_81577;
            this.pictureBoxDeleteAuthor.Location = new System.Drawing.Point(613, 74);
            this.pictureBoxDeleteAuthor.Name = "pictureBoxDeleteAuthor";
            this.pictureBoxDeleteAuthor.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxDeleteAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDeleteAuthor.TabIndex = 44;
            this.pictureBoxDeleteAuthor.TabStop = false;
            this.pictureBoxDeleteAuthor.Click += new System.EventHandler(this.pictureBoxDeleteAuthor_Click);
            // 
            // tableAuthor
            // 
            this.tableAuthor.AllowUserToAddRows = false;
            this.tableAuthor.AllowUserToDeleteRows = false;
            this.tableAuthor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableAuthor.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableAuthor.ColumnHeadersVisible = false;
            this.tableAuthor.Location = new System.Drawing.Point(358, 30);
            this.tableAuthor.Name = "tableAuthor";
            this.tableAuthor.ReadOnly = true;
            this.tableAuthor.RowHeadersVisible = false;
            this.tableAuthor.Size = new System.Drawing.Size(249, 69);
            this.tableAuthor.TabIndex = 42;
            // 
            // cbAuthor
            // 
            this.cbAuthor.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAuthor.FormattingEnabled = true;
            this.cbAuthor.Location = new System.Drawing.Point(20, 30);
            this.cbAuthor.Name = "cbAuthor";
            this.cbAuthor.Size = new System.Drawing.Size(242, 32);
            this.cbAuthor.TabIndex = 40;
            // 
            // pictureBoxAddAuthor
            // 
            this.pictureBoxAddAuthor.Image = global::BookStore.Properties.Resources.plus_icon_icons_com_70890;
            this.pictureBoxAddAuthor.InitialImage = null;
            this.pictureBoxAddAuthor.Location = new System.Drawing.Point(295, 30);
            this.pictureBoxAddAuthor.Name = "pictureBoxAddAuthor";
            this.pictureBoxAddAuthor.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxAddAuthor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAddAuthor.TabIndex = 41;
            this.pictureBoxAddAuthor.TabStop = false;
            this.pictureBoxAddAuthor.Click += new System.EventHandler(this.pictureBoxAddAuthor_Click);
            // 
            // cbCoverType
            // 
            this.cbCoverType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCoverType.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCoverType.FormattingEnabled = true;
            this.cbCoverType.Items.AddRange(new object[] {
            "Твердая бумажная",
            "Твердая глянцевая",
            "Мягкая глянцевая",
            "Мягкая бумажная",
            "Суперобложка"});
            this.cbCoverType.Location = new System.Drawing.Point(152, 311);
            this.cbCoverType.Name = "cbCoverType";
            this.cbCoverType.Size = new System.Drawing.Size(210, 32);
            this.cbCoverType.TabIndex = 36;
            // 
            // cbPublishing
            // 
            this.cbPublishing.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPublishing.FormattingEnabled = true;
            this.cbPublishing.Location = new System.Drawing.Point(152, 358);
            this.cbPublishing.Name = "cbPublishing";
            this.cbPublishing.Size = new System.Drawing.Size(210, 32);
            this.cbPublishing.TabIndex = 34;
            // 
            // tbISBN
            // 
            this.tbISBN.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbISBN.Location = new System.Drawing.Point(444, 406);
            this.tbISBN.Name = "tbISBN";
            this.tbISBN.Size = new System.Drawing.Size(221, 31);
            this.tbISBN.TabIndex = 31;
            // 
            // tbNameBook
            // 
            this.tbNameBook.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameBook.Location = new System.Drawing.Point(162, 12);
            this.tbNameBook.Name = "tbNameBook";
            this.tbNameBook.Size = new System.Drawing.Size(511, 31);
            this.tbNameBook.TabIndex = 30;
            // 
            // lblCoverType
            // 
            this.lblCoverType.AutoSize = true;
            this.lblCoverType.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCoverType.Location = new System.Drawing.Point(11, 316);
            this.lblCoverType.Name = "lblCoverType";
            this.lblCoverType.Size = new System.Drawing.Size(122, 24);
            this.lblCoverType.TabIndex = 28;
            this.lblCoverType.Text = "Тип обложки:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxDescription.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(15, 481);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(650, 280);
            this.richTextBoxDescription.TabIndex = 27;
            this.richTextBoxDescription.Text = "";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblISBN.Location = new System.Drawing.Point(386, 410);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(52, 24);
            this.lblISBN.TabIndex = 25;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblAgeLimit
            // 
            this.lblAgeLimit.AutoSize = true;
            this.lblAgeLimit.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAgeLimit.Location = new System.Drawing.Point(11, 410);
            this.lblAgeLimit.Name = "lblAgeLimit";
            this.lblAgeLimit.Size = new System.Drawing.Size(228, 24);
            this.lblAgeLimit.TabIndex = 23;
            this.lblAgeLimit.Text = "Возрастное ограничение:";
            // 
            // lblCountPage
            // 
            this.lblCountPage.AutoSize = true;
            this.lblCountPage.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountPage.Location = new System.Drawing.Point(386, 361);
            this.lblCountPage.Name = "lblCountPage";
            this.lblCountPage.Size = new System.Drawing.Size(188, 24);
            this.lblCountPage.TabIndex = 21;
            this.lblCountPage.Text = "Количество страниц:";
            // 
            // lblPublishing
            // 
            this.lblPublishing.AutoSize = true;
            this.lblPublishing.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPublishing.Location = new System.Drawing.Point(12, 361);
            this.lblPublishing.Name = "lblPublishing";
            this.lblPublishing.Size = new System.Drawing.Size(134, 24);
            this.lblPublishing.TabIndex = 19;
            this.lblPublishing.Text = "Издательство:";
            // 
            // lblYearPublishing
            // 
            this.lblYearPublishing.AutoSize = true;
            this.lblYearPublishing.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYearPublishing.Location = new System.Drawing.Point(386, 316);
            this.lblYearPublishing.Name = "lblYearPublishing";
            this.lblYearPublishing.Size = new System.Drawing.Size(118, 24);
            this.lblYearPublishing.TabIndex = 17;
            this.lblYearPublishing.Text = "Год издания:";
            // 
            // lblNameBook
            // 
            this.lblNameBook.AutoSize = true;
            this.lblNameBook.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNameBook.Location = new System.Drawing.Point(11, 15);
            this.lblNameBook.Name = "lblNameBook";
            this.lblNameBook.Size = new System.Drawing.Size(145, 24);
            this.lblNameBook.TabIndex = 10;
            this.lblNameBook.Text = "Название книги:";
            // 
            // FormAddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1001, 812);
            this.Controls.Add(this.panelBookInfo);
            this.Name = "FormAddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книжный магазин - Добавление книги или изменение";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAddBook_FormClosing);
            this.Load += new System.EventHandler(this.FormAddBook_Load);
            this.panelCover.ResumeLayout(false);
            this.panelCover.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.panelBookInfo.ResumeLayout(false);
            this.panelBookInfo.PerformLayout();
            this.groupBoxAddNew.ResumeLayout(false);
            this.groupBoxAddNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPageCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.groupBoxGenre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableGenre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddGenre)).EndInit();
            this.groupBoxAuthor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableAuthor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddAuthor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCover;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Panel panelBookInfo;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblAgeLimit;
        private System.Windows.Forms.Label lblCountPage;
        private System.Windows.Forms.Label lblPublishing;
        private System.Windows.Forms.Label lblYearPublishing;
        private System.Windows.Forms.Label lblNameBook;
        private System.Windows.Forms.TextBox tbNameBook;
        private System.Windows.Forms.Button buttonAddCover;
        private System.Windows.Forms.PictureBox pictureBoxAddAuthor;
        private System.Windows.Forms.ComboBox cbAuthor;
        private System.Windows.Forms.ComboBox cbCoverType;
        private System.Windows.Forms.ComboBox cbPublishing;
        private System.Windows.Forms.ComboBox cbAgeLimit;
        private System.Windows.Forms.TextBox tbISBN;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.GroupBox groupBoxGenre;
        private System.Windows.Forms.DataGridView tableGenre;
        private System.Windows.Forms.ComboBox cbGenre;
        private System.Windows.Forms.PictureBox pictureBoxAddGenre;
        private System.Windows.Forms.GroupBox groupBoxAuthor;
        private System.Windows.Forms.DataGridView tableAuthor;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.NumericUpDown numericUpDownPageCount;
        private System.Windows.Forms.TextBox tbYearOfPublishing;
        private System.Windows.Forms.Button btnEditBook;
        private System.Windows.Forms.PictureBox pictureBoxDeleteGenre;
        private System.Windows.Forms.PictureBox pictureBoxDeleteAuthor;
        private System.Windows.Forms.GroupBox groupBoxAddNew;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.TextBox tbAddNew;
        private System.Windows.Forms.ComboBox cbAddNew;
        private System.Windows.Forms.Label lblCoverType;
    }
}