namespace BookStore
{
    partial class FormWarehouseman
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
            this.tableBooks = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.cbCategorySearch = new System.Windows.Forms.ComboBox();
            this.pictureBoxErase = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.menuStripWarehouse = new System.Windows.Forms.MenuStrip();
            this.MenuItemAddArrival = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGenres = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPublishing = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReportArrival = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemReportSell = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPopularBook = new System.Windows.Forms.ToolStripMenuItem();
            this.panelBookInfo = new System.Windows.Forms.Panel();
            this.lblParamCoverType = new System.Windows.Forms.Label();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.lblCoverType = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.lblParamISBN = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblParamAgeLimit = new System.Windows.Forms.Label();
            this.lblAgeLimit = new System.Windows.Forms.Label();
            this.lblParamPageCount = new System.Windows.Forms.Label();
            this.lblCountPage = new System.Windows.Forms.Label();
            this.lblParamPublishing = new System.Windows.Forms.Label();
            this.lblPublishing = new System.Windows.Forms.Label();
            this.lblParamYearPublishing = new System.Windows.Forms.Label();
            this.lblYearPublishing = new System.Windows.Forms.Label();
            this.lblParamGenre = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblParamAuthor = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblParamNameBook = new System.Windows.Forms.Label();
            this.buttonEditInformation = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableBooks)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErase)).BeginInit();
            this.menuStripWarehouse.SuspendLayout();
            this.panelBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.SuspendLayout();
            // 
            // tableBooks
            // 
            this.tableBooks.AllowUserToAddRows = false;
            this.tableBooks.AllowUserToDeleteRows = false;
            this.tableBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableBooks.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableBooks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Product Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableBooks.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableBooks.Location = new System.Drawing.Point(0, 74);
            this.tableBooks.Name = "tableBooks";
            this.tableBooks.ReadOnly = true;
            this.tableBooks.Size = new System.Drawing.Size(738, 658);
            this.tableBooks.TabIndex = 0;
            this.tableBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableBooks_CellClick);
            // 
            // panelSearch
            // 
            this.panelSearch.BackColor = System.Drawing.Color.Transparent;
            this.panelSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSearch.Controls.Add(this.pictureBoxSearch);
            this.panelSearch.Controls.Add(this.cbSearch);
            this.panelSearch.Controls.Add(this.cbCategorySearch);
            this.panelSearch.Controls.Add(this.pictureBoxErase);
            this.panelSearch.Controls.Add(this.lblSearch);
            this.panelSearch.Location = new System.Drawing.Point(0, 32);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(738, 42);
            this.panelSearch.TabIndex = 11;
            // 
            // pictureBoxSearch
            // 
            this.pictureBoxSearch.Image = global::BookStore.Properties.Resources.search_512;
            this.pictureBoxSearch.Location = new System.Drawing.Point(651, 3);
            this.pictureBoxSearch.Name = "pictureBoxSearch";
            this.pictureBoxSearch.Size = new System.Drawing.Size(38, 33);
            this.pictureBoxSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearch.TabIndex = 13;
            this.pictureBoxSearch.TabStop = false;
            this.pictureBoxSearch.Click += new System.EventHandler(this.pictureBoxSearch_Click);
            // 
            // cbSearch
            // 
            this.cbSearch.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSearch.FormattingEnabled = true;
            this.cbSearch.Location = new System.Drawing.Point(283, 3);
            this.cbSearch.Name = "cbSearch";
            this.cbSearch.Size = new System.Drawing.Size(362, 32);
            this.cbSearch.TabIndex = 12;
            // 
            // cbCategorySearch
            // 
            this.cbCategorySearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategorySearch.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCategorySearch.FormattingEnabled = true;
            this.cbCategorySearch.Items.AddRange(new object[] {
            "По названию",
            "По автору",
            "По жанру"});
            this.cbCategorySearch.Location = new System.Drawing.Point(86, 4);
            this.cbCategorySearch.Name = "cbCategorySearch";
            this.cbCategorySearch.Size = new System.Drawing.Size(191, 32);
            this.cbCategorySearch.TabIndex = 11;
            this.cbCategorySearch.SelectedIndexChanged += new System.EventHandler(this.cbCategorySearch_SelectedIndexChanged);
            // 
            // pictureBoxErase
            // 
            this.pictureBoxErase.Image = global::BookStore.Properties.Resources._33;
            this.pictureBoxErase.Location = new System.Drawing.Point(695, 3);
            this.pictureBoxErase.Name = "pictureBoxErase";
            this.pictureBoxErase.Size = new System.Drawing.Size(38, 33);
            this.pictureBoxErase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxErase.TabIndex = 10;
            this.pictureBoxErase.TabStop = false;
            this.pictureBoxErase.Click += new System.EventHandler(this.pictureBoxErase_Click);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSearch.Location = new System.Drawing.Point(11, 7);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(63, 24);
            this.lblSearch.TabIndex = 8;
            this.lblSearch.Text = "Поиск";
            // 
            // menuStripWarehouse
            // 
            this.menuStripWarehouse.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStripWarehouse.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemAddArrival,
            this.menuItemAuthors,
            this.menuItemGenres,
            this.menuItemPublishing,
            this.toolStripMenuItem1});
            this.menuStripWarehouse.Location = new System.Drawing.Point(0, 0);
            this.menuStripWarehouse.Name = "menuStripWarehouse";
            this.menuStripWarehouse.Size = new System.Drawing.Size(1524, 32);
            this.menuStripWarehouse.TabIndex = 18;
            this.menuStripWarehouse.Text = "menuStrip1";
            // 
            // MenuItemAddArrival
            // 
            this.MenuItemAddArrival.Name = "MenuItemAddArrival";
            this.MenuItemAddArrival.Size = new System.Drawing.Size(248, 28);
            this.MenuItemAddArrival.Text = "Оформление поступления";
            this.MenuItemAddArrival.Click += new System.EventHandler(this.MenuItemAddArrival_Click);
            // 
            // menuItemAuthors
            // 
            this.menuItemAuthors.Name = "menuItemAuthors";
            this.menuItemAuthors.Size = new System.Drawing.Size(86, 28);
            this.menuItemAuthors.Text = "Авторы";
            this.menuItemAuthors.Click += new System.EventHandler(this.menuItemAuthors_Click);
            // 
            // menuItemGenres
            // 
            this.menuItemGenres.Name = "menuItemGenres";
            this.menuItemGenres.Size = new System.Drawing.Size(82, 28);
            this.menuItemGenres.Text = "Жанры";
            this.menuItemGenres.Click += new System.EventHandler(this.menuItemGenres_Click);
            // 
            // menuItemPublishing
            // 
            this.menuItemPublishing.Name = "menuItemPublishing";
            this.menuItemPublishing.Size = new System.Drawing.Size(141, 28);
            this.menuItemPublishing.Text = "Издательства";
            this.menuItemPublishing.Click += new System.EventHandler(this.menuItemPublishing_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemReportArrival,
            this.MenuItemReportSell,
            this.MenuItemPopularBook});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(85, 28);
            this.toolStripMenuItem1.Text = "Отчеты";
            // 
            // MenuItemReportArrival
            // 
            this.MenuItemReportArrival.Name = "MenuItemReportArrival";
            this.MenuItemReportArrival.Size = new System.Drawing.Size(241, 28);
            this.MenuItemReportArrival.Text = "Поступления книг";
            this.MenuItemReportArrival.Click += new System.EventHandler(this.поступленияКнигToolStripMenuItem_Click);
            // 
            // MenuItemReportSell
            // 
            this.MenuItemReportSell.Name = "MenuItemReportSell";
            this.MenuItemReportSell.Size = new System.Drawing.Size(241, 28);
            this.MenuItemReportSell.Text = "Продажи книг";
            this.MenuItemReportSell.Click += new System.EventHandler(this.MenuItemReportSell_Click);
            // 
            // MenuItemPopularBook
            // 
            this.MenuItemPopularBook.Name = "MenuItemPopularBook";
            this.MenuItemPopularBook.Size = new System.Drawing.Size(241, 28);
            this.MenuItemPopularBook.Text = "Популярность книг";
            this.MenuItemPopularBook.Click += new System.EventHandler(this.MenuItemPopularBook_Click);
            // 
            // panelBookInfo
            // 
            this.panelBookInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelBookInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBookInfo.Controls.Add(this.lblParamCoverType);
            this.panelBookInfo.Controls.Add(this.pictureBoxExit);
            this.panelBookInfo.Controls.Add(this.pictureBoxCover);
            this.panelBookInfo.Controls.Add(this.lblCoverType);
            this.panelBookInfo.Controls.Add(this.richTextBoxDescription);
            this.panelBookInfo.Controls.Add(this.lblParamISBN);
            this.panelBookInfo.Controls.Add(this.lblISBN);
            this.panelBookInfo.Controls.Add(this.lblParamAgeLimit);
            this.panelBookInfo.Controls.Add(this.lblAgeLimit);
            this.panelBookInfo.Controls.Add(this.lblParamPageCount);
            this.panelBookInfo.Controls.Add(this.lblCountPage);
            this.panelBookInfo.Controls.Add(this.lblParamPublishing);
            this.panelBookInfo.Controls.Add(this.lblPublishing);
            this.panelBookInfo.Controls.Add(this.lblParamYearPublishing);
            this.panelBookInfo.Controls.Add(this.lblYearPublishing);
            this.panelBookInfo.Controls.Add(this.lblParamGenre);
            this.panelBookInfo.Controls.Add(this.lblGenre);
            this.panelBookInfo.Controls.Add(this.lblParamAuthor);
            this.panelBookInfo.Controls.Add(this.lblAuthor);
            this.panelBookInfo.Controls.Add(this.lblParamNameBook);
            this.panelBookInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBookInfo.Location = new System.Drawing.Point(744, 32);
            this.panelBookInfo.Name = "panelBookInfo";
            this.panelBookInfo.Size = new System.Drawing.Size(780, 757);
            this.panelBookInfo.TabIndex = 20;
            // 
            // lblParamCoverType
            // 
            this.lblParamCoverType.AutoSize = true;
            this.lblParamCoverType.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParamCoverType.Location = new System.Drawing.Point(140, 323);
            this.lblParamCoverType.Name = "lblParamCoverType";
            this.lblParamCoverType.Size = new System.Drawing.Size(140, 24);
            this.lblParamCoverType.TabIndex = 29;
            this.lblParamCoverType.Text = "<Тип обложки>";
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = global::BookStore.Properties.Resources.exit_icon_icons_com_70975;
            this.pictureBoxExit.Location = new System.Drawing.Point(727, 705);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 17;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCover.ErrorImage = global::BookStore.Properties.Resources.noface_ru;
            this.pictureBoxCover.Location = new System.Drawing.Point(524, 15);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(243, 332);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 19;
            this.pictureBoxCover.TabStop = false;
            // 
            // lblCoverType
            // 
            this.lblCoverType.AutoSize = true;
            this.lblCoverType.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCoverType.Location = new System.Drawing.Point(12, 323);
            this.lblCoverType.Name = "lblCoverType";
            this.lblCoverType.Size = new System.Drawing.Size(122, 24);
            this.lblCoverType.TabIndex = 28;
            this.lblCoverType.Text = "Тип обложки:";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxDescription.Font = new System.Drawing.Font("Product Sans Light", 14.15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(16, 365);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ReadOnly = true;
            this.richTextBoxDescription.Size = new System.Drawing.Size(751, 334);
            this.richTextBoxDescription.TabIndex = 27;
            this.richTextBoxDescription.Text = "<Описание>";
            // 
            // lblParamISBN
            // 
            this.lblParamISBN.AutoSize = true;
            this.lblParamISBN.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParamISBN.Location = new System.Drawing.Point(65, 289);
            this.lblParamISBN.Name = "lblParamISBN";
            this.lblParamISBN.Size = new System.Drawing.Size(69, 24);
            this.lblParamISBN.TabIndex = 26;
            this.lblParamISBN.Text = "<ISBN>";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblISBN.Location = new System.Drawing.Point(12, 289);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(52, 24);
            this.lblISBN.TabIndex = 25;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblParamAgeLimit
            // 
            this.lblParamAgeLimit.AutoSize = true;
            this.lblParamAgeLimit.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParamAgeLimit.Location = new System.Drawing.Point(246, 255);
            this.lblParamAgeLimit.Name = "lblParamAgeLimit";
            this.lblParamAgeLimit.Size = new System.Drawing.Size(100, 24);
            this.lblParamAgeLimit.TabIndex = 24;
            this.lblParamAgeLimit.Text = "<Возраст>";
            // 
            // lblAgeLimit
            // 
            this.lblAgeLimit.AutoSize = true;
            this.lblAgeLimit.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAgeLimit.Location = new System.Drawing.Point(12, 255);
            this.lblAgeLimit.Name = "lblAgeLimit";
            this.lblAgeLimit.Size = new System.Drawing.Size(228, 24);
            this.lblAgeLimit.TabIndex = 23;
            this.lblAgeLimit.Text = "Возрастное ограничение:";
            // 
            // lblParamPageCount
            // 
            this.lblParamPageCount.AutoSize = true;
            this.lblParamPageCount.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParamPageCount.Location = new System.Drawing.Point(206, 219);
            this.lblParamPageCount.Name = "lblParamPageCount";
            this.lblParamPageCount.Size = new System.Drawing.Size(129, 24);
            this.lblParamPageCount.TabIndex = 22;
            this.lblParamPageCount.Text = "<Кол-во стр.>";
            // 
            // lblCountPage
            // 
            this.lblCountPage.AutoSize = true;
            this.lblCountPage.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountPage.Location = new System.Drawing.Point(12, 219);
            this.lblCountPage.Name = "lblCountPage";
            this.lblCountPage.Size = new System.Drawing.Size(188, 24);
            this.lblCountPage.TabIndex = 21;
            this.lblCountPage.Text = "Количество страниц:";
            // 
            // lblParamPublishing
            // 
            this.lblParamPublishing.AutoSize = true;
            this.lblParamPublishing.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParamPublishing.Location = new System.Drawing.Point(152, 183);
            this.lblParamPublishing.Name = "lblParamPublishing";
            this.lblParamPublishing.Size = new System.Drawing.Size(151, 24);
            this.lblParamPublishing.TabIndex = 20;
            this.lblParamPublishing.Text = "<Издательство>";
            // 
            // lblPublishing
            // 
            this.lblPublishing.AutoSize = true;
            this.lblPublishing.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPublishing.Location = new System.Drawing.Point(12, 183);
            this.lblPublishing.Name = "lblPublishing";
            this.lblPublishing.Size = new System.Drawing.Size(134, 24);
            this.lblPublishing.TabIndex = 19;
            this.lblPublishing.Text = "Издательство:";
            // 
            // lblParamYearPublishing
            // 
            this.lblParamYearPublishing.AutoSize = true;
            this.lblParamYearPublishing.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParamYearPublishing.Location = new System.Drawing.Point(136, 149);
            this.lblParamYearPublishing.Name = "lblParamYearPublishing";
            this.lblParamYearPublishing.Size = new System.Drawing.Size(134, 24);
            this.lblParamYearPublishing.TabIndex = 18;
            this.lblParamYearPublishing.Text = "<Год издания>";
            // 
            // lblYearPublishing
            // 
            this.lblYearPublishing.AutoSize = true;
            this.lblYearPublishing.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYearPublishing.Location = new System.Drawing.Point(12, 149);
            this.lblYearPublishing.Name = "lblYearPublishing";
            this.lblYearPublishing.Size = new System.Drawing.Size(118, 24);
            this.lblYearPublishing.TabIndex = 17;
            this.lblYearPublishing.Text = "Год издания:";
            // 
            // lblParamGenre
            // 
            this.lblParamGenre.AutoSize = true;
            this.lblParamGenre.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParamGenre.Location = new System.Drawing.Point(79, 116);
            this.lblParamGenre.Name = "lblParamGenre";
            this.lblParamGenre.Size = new System.Drawing.Size(78, 24);
            this.lblParamGenre.TabIndex = 16;
            this.lblParamGenre.Text = "<Жанр>";
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGenre.Location = new System.Drawing.Point(12, 116);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(61, 24);
            this.lblGenre.TabIndex = 15;
            this.lblGenre.Text = "Жанр:";
            // 
            // lblParamAuthor
            // 
            this.lblParamAuthor.AutoSize = true;
            this.lblParamAuthor.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParamAuthor.Location = new System.Drawing.Point(83, 83);
            this.lblParamAuthor.Name = "lblParamAuthor";
            this.lblParamAuthor.Size = new System.Drawing.Size(82, 24);
            this.lblParamAuthor.TabIndex = 14;
            this.lblParamAuthor.Text = "<Автор>";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthor.Location = new System.Drawing.Point(12, 83);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(65, 24);
            this.lblAuthor.TabIndex = 12;
            this.lblAuthor.Text = "Автор:";
            // 
            // lblParamNameBook
            // 
            this.lblParamNameBook.AutoSize = true;
            this.lblParamNameBook.Font = new System.Drawing.Font("Product Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParamNameBook.Location = new System.Drawing.Point(11, 15);
            this.lblParamNameBook.Name = "lblParamNameBook";
            this.lblParamNameBook.Size = new System.Drawing.Size(205, 30);
            this.lblParamNameBook.TabIndex = 10;
            this.lblParamNameBook.Text = "<Название книги>";
            // 
            // buttonEditInformation
            // 
            this.buttonEditInformation.AutoSize = true;
            this.buttonEditInformation.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEditInformation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEditInformation.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEditInformation.Location = new System.Drawing.Point(12, 738);
            this.buttonEditInformation.Name = "buttonEditInformation";
            this.buttonEditInformation.Size = new System.Drawing.Size(320, 38);
            this.buttonEditInformation.TabIndex = 30;
            this.buttonEditInformation.Text = "Изменить информацию о книге";
            this.buttonEditInformation.UseVisualStyleBackColor = false;
            this.buttonEditInformation.Click += new System.EventHandler(this.buttonEditInformation_Click);
            // 
            // FormWarehouseman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1524, 789);
            this.Controls.Add(this.buttonEditInformation);
            this.Controls.Add(this.panelBookInfo);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.tableBooks);
            this.Controls.Add(this.menuStripWarehouse);
            this.MainMenuStrip = this.menuStripWarehouse;
            this.Name = "FormWarehouseman";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книжный магазин - Кладовщик";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormWarehouseman_FormClosing);
            this.Load += new System.EventHandler(this.FormWarehouseman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBooks)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErase)).EndInit();
            this.menuStripWarehouse.ResumeLayout(false);
            this.menuStripWarehouse.PerformLayout();
            this.panelBookInfo.ResumeLayout(false);
            this.panelBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableBooks;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.PictureBox pictureBoxErase;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.MenuStrip menuStripWarehouse;
        private System.Windows.Forms.ToolStripMenuItem menuItemAuthors;
        private System.Windows.Forms.ToolStripMenuItem menuItemGenres;
        private System.Windows.Forms.ToolStripMenuItem menuItemPublishing;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.Panel panelBookInfo;
        private System.Windows.Forms.Label lblParamCoverType;
        private System.Windows.Forms.Label lblCoverType;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label lblParamISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblParamAgeLimit;
        private System.Windows.Forms.Label lblAgeLimit;
        private System.Windows.Forms.Label lblParamPageCount;
        private System.Windows.Forms.Label lblCountPage;
        private System.Windows.Forms.Label lblParamPublishing;
        private System.Windows.Forms.Label lblPublishing;
        private System.Windows.Forms.Label lblParamYearPublishing;
        private System.Windows.Forms.Label lblYearPublishing;
        private System.Windows.Forms.Label lblParamGenre;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.Label lblParamAuthor;
        private System.Windows.Forms.Label lblAuthor;
        public System.Windows.Forms.Label lblParamNameBook;
        private System.Windows.Forms.Button buttonEditInformation;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.ComboBox cbCategorySearch;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReportArrival;
        private System.Windows.Forms.ToolStripMenuItem MenuItemReportSell;
        private System.Windows.Forms.ToolStripMenuItem MenuItemAddArrival;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPopularBook;
    }
}