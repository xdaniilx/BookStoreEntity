namespace BookStore
{
    partial class FormSales
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableBooks = new System.Windows.Forms.DataGridView();
            this.panelBasket = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxDeleteSellItem = new System.Windows.Forms.PictureBox();
            this.lblParamSum = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.buttonSell = new System.Windows.Forms.Button();
            this.tableSell = new System.Windows.Forms.DataGridView();
            this.lblAuthorization = new System.Windows.Forms.Label();
            this.buttonAddToBasket = new System.Windows.Forms.Button();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panelBookInfo = new System.Windows.Forms.Panel();
            this.lblParamCoverType = new System.Windows.Forms.Label();
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
            this.lblQuantity = new System.Windows.Forms.Label();
            this.numericUpDownQuantity = new System.Windows.Forms.NumericUpDown();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.pictureBoxSearch = new System.Windows.Forms.PictureBox();
            this.cbSearch = new System.Windows.Forms.ComboBox();
            this.cbCategorySearch = new System.Windows.Forms.ComboBox();
            this.pictureBoxErase = new System.Windows.Forms.PictureBox();
            this.lblSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableBooks)).BeginInit();
            this.panelBasket.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteSellItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSell)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panelBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).BeginInit();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErase)).BeginInit();
            this.SuspendLayout();
            // 
            // tableBooks
            // 
            this.tableBooks.AllowUserToAddRows = false;
            this.tableBooks.AllowUserToDeleteRows = false;
            this.tableBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.tableBooks.Location = new System.Drawing.Point(0, 43);
            this.tableBooks.Name = "tableBooks";
            this.tableBooks.ReadOnly = true;
            this.tableBooks.Size = new System.Drawing.Size(738, 313);
            this.tableBooks.TabIndex = 2;
            this.tableBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableBooks_CellClick);
            // 
            // panelBasket
            // 
            this.panelBasket.BackColor = System.Drawing.Color.Transparent;
            this.panelBasket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBasket.Controls.Add(this.label1);
            this.panelBasket.Controls.Add(this.pictureBoxDeleteSellItem);
            this.panelBasket.Controls.Add(this.lblParamSum);
            this.panelBasket.Controls.Add(this.lblSum);
            this.panelBasket.Controls.Add(this.buttonSell);
            this.panelBasket.Controls.Add(this.tableSell);
            this.panelBasket.Controls.Add(this.lblAuthorization);
            this.panelBasket.Location = new System.Drawing.Point(0, 406);
            this.panelBasket.Name = "panelBasket";
            this.panelBasket.Size = new System.Drawing.Size(738, 384);
            this.panelBasket.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(259, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 26);
            this.label1.TabIndex = 17;
            this.label1.Text = "рублей";
            // 
            // pictureBoxDeleteSellItem
            // 
            this.pictureBoxDeleteSellItem.Image = global::BookStore.Properties.Resources._1487086345_cross_81577;
            this.pictureBoxDeleteSellItem.Location = new System.Drawing.Point(672, 249);
            this.pictureBoxDeleteSellItem.Name = "pictureBoxDeleteSellItem";
            this.pictureBoxDeleteSellItem.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxDeleteSellItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxDeleteSellItem.TabIndex = 16;
            this.pictureBoxDeleteSellItem.TabStop = false;
            this.pictureBoxDeleteSellItem.Click += new System.EventHandler(this.pictureBoxDeleteSellItem_Click);
            // 
            // lblParamSum
            // 
            this.lblParamSum.AutoSize = true;
            this.lblParamSum.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParamSum.Location = new System.Drawing.Point(191, 265);
            this.lblParamSum.Name = "lblParamSum";
            this.lblParamSum.Size = new System.Drawing.Size(45, 26);
            this.lblParamSum.TabIndex = 15;
            this.lblParamSum.Text = "<$>";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSum.Location = new System.Drawing.Point(16, 265);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(169, 26);
            this.lblSum.TabIndex = 14;
            this.lblSum.Text = "Итоговая сумма:";
            // 
            // buttonSell
            // 
            this.buttonSell.AutoSize = true;
            this.buttonSell.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSell.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSell.Location = new System.Drawing.Point(21, 314);
            this.buttonSell.Name = "buttonSell";
            this.buttonSell.Size = new System.Drawing.Size(114, 38);
            this.buttonSell.TabIndex = 12;
            this.buttonSell.Text = "Продажа";
            this.buttonSell.UseVisualStyleBackColor = false;
            this.buttonSell.Click += new System.EventHandler(this.buttonSell_Click);
            // 
            // tableSell
            // 
            this.tableSell.AllowUserToAddRows = false;
            this.tableSell.AllowUserToDeleteRows = false;
            this.tableSell.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableSell.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableSell.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableSell.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Product Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableSell.DefaultCellStyle = dataGridViewCellStyle4;
            this.tableSell.Location = new System.Drawing.Point(21, 63);
            this.tableSell.Name = "tableSell";
            this.tableSell.ReadOnly = true;
            this.tableSell.Size = new System.Drawing.Size(691, 180);
            this.tableSell.TabIndex = 12;
            // 
            // lblAuthorization
            // 
            this.lblAuthorization.AutoSize = true;
            this.lblAuthorization.Font = new System.Drawing.Font("Product Sans Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthorization.Location = new System.Drawing.Point(16, 20);
            this.lblAuthorization.Name = "lblAuthorization";
            this.lblAuthorization.Size = new System.Drawing.Size(114, 30);
            this.lblAuthorization.TabIndex = 4;
            this.lblAuthorization.Text = "Корзина";
            // 
            // buttonAddToBasket
            // 
            this.buttonAddToBasket.AutoSize = true;
            this.buttonAddToBasket.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddToBasket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddToBasket.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddToBasket.Location = new System.Drawing.Point(265, 362);
            this.buttonAddToBasket.Name = "buttonAddToBasket";
            this.buttonAddToBasket.Size = new System.Drawing.Size(242, 36);
            this.buttonAddToBasket.TabIndex = 15;
            this.buttonAddToBasket.Text = "Добавить книгу в корзину";
            this.buttonAddToBasket.UseVisualStyleBackColor = false;
            this.buttonAddToBasket.Click += new System.EventHandler(this.buttonAddToBasket_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = global::BookStore.Properties.Resources.exit_icon_icons_com_70975;
            this.pictureBoxExit.Location = new System.Drawing.Point(747, 737);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 13;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // panelBookInfo
            // 
            this.panelBookInfo.BackColor = System.Drawing.Color.Transparent;
            this.panelBookInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBookInfo.Controls.Add(this.lblParamCoverType);
            this.panelBookInfo.Controls.Add(this.pictureBoxCover);
            this.panelBookInfo.Controls.Add(this.lblCoverType);
            this.panelBookInfo.Controls.Add(this.pictureBoxExit);
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
            this.panelBookInfo.Location = new System.Drawing.Point(744, 0);
            this.panelBookInfo.Name = "panelBookInfo";
            this.panelBookInfo.Size = new System.Drawing.Size(800, 790);
            this.panelBookInfo.TabIndex = 21;
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
            // pictureBoxCover
            // 
            this.pictureBoxCover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCover.ErrorImage = global::BookStore.Properties.Resources.noface_ru;
            this.pictureBoxCover.Location = new System.Drawing.Point(523, 15);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(264, 332);
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
            this.richTextBoxDescription.Font = new System.Drawing.Font("Product Sans Light", 14.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDescription.Location = new System.Drawing.Point(16, 365);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.ReadOnly = true;
            this.richTextBoxDescription.Size = new System.Drawing.Size(771, 334);
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
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuantity.Location = new System.Drawing.Point(3, 366);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(130, 26);
            this.lblQuantity.TabIndex = 22;
            this.lblQuantity.Text = "Количество:";
            // 
            // numericUpDownQuantity
            // 
            this.numericUpDownQuantity.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownQuantity.Location = new System.Drawing.Point(137, 366);
            this.numericUpDownQuantity.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDownQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownQuantity.Name = "numericUpDownQuantity";
            this.numericUpDownQuantity.Size = new System.Drawing.Size(100, 31);
            this.numericUpDownQuantity.TabIndex = 50;
            this.numericUpDownQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
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
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(738, 42);
            this.panelSearch.TabIndex = 51;
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
            this.cbSearch.Items.AddRange(new object[] {
            "По названию",
            "По жанру",
            "По автору"});
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
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1544, 790);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.numericUpDownQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.panelBookInfo);
            this.Controls.Add(this.buttonAddToBasket);
            this.Controls.Add(this.panelBasket);
            this.Controls.Add(this.tableBooks);
            this.Name = "FormSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книжный магазин - Продажа книг";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormSales_FormClosing);
            this.Load += new System.EventHandler(this.FormSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableBooks)).EndInit();
            this.panelBasket.ResumeLayout(false);
            this.panelBasket.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDeleteSellItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSell)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panelBookInfo.ResumeLayout(false);
            this.panelBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxErase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tableBooks;
        private System.Windows.Forms.Panel panelBasket;
        private System.Windows.Forms.Button buttonSell;
        private System.Windows.Forms.DataGridView tableSell;
        private System.Windows.Forms.Label lblAuthorization;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Label lblParamSum;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.PictureBox pictureBoxDeleteSellItem;
        private System.Windows.Forms.Button buttonAddToBasket;
        private System.Windows.Forms.Panel panelBookInfo;
        private System.Windows.Forms.Label lblParamCoverType;
        private System.Windows.Forms.PictureBox pictureBoxCover;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.PictureBox pictureBoxSearch;
        private System.Windows.Forms.ComboBox cbSearch;
        private System.Windows.Forms.ComboBox cbCategorySearch;
        private System.Windows.Forms.PictureBox pictureBoxErase;
        private System.Windows.Forms.Label lblSearch;
    }
}