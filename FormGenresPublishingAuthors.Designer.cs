namespace BookStore
{
    partial class FormGenresPublishingAuthors
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
            this.tableInfo = new System.Windows.Forms.DataGridView();
            this.tbInfo1 = new System.Windows.Forms.TextBox();
            this.tbInfo2 = new System.Windows.Forms.TextBox();
            this.lblInfo1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panelInfo2 = new System.Windows.Forms.Panel();
            this.panelInfo1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panelInfo2.SuspendLayout();
            this.panelInfo1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableInfo
            // 
            this.tableInfo.AllowUserToAddRows = false;
            this.tableInfo.AllowUserToDeleteRows = false;
            this.tableInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableInfo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Product Sans Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Product Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableInfo.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableInfo.Location = new System.Drawing.Point(12, 12);
            this.tableInfo.Name = "tableInfo";
            this.tableInfo.ReadOnly = true;
            this.tableInfo.Size = new System.Drawing.Size(530, 419);
            this.tableInfo.TabIndex = 1;
            this.tableInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableInfo_CellClick);
            // 
            // tbInfo1
            // 
            this.tbInfo1.Font = new System.Drawing.Font("Product Sans Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInfo1.Location = new System.Drawing.Point(5, 33);
            this.tbInfo1.Name = "tbInfo1";
            this.tbInfo1.Size = new System.Drawing.Size(283, 33);
            this.tbInfo1.TabIndex = 7;
            // 
            // tbInfo2
            // 
            this.tbInfo2.Font = new System.Drawing.Font("Product Sans Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbInfo2.Location = new System.Drawing.Point(3, 31);
            this.tbInfo2.Name = "tbInfo2";
            this.tbInfo2.Size = new System.Drawing.Size(283, 33);
            this.tbInfo2.TabIndex = 8;
            // 
            // lblInfo1
            // 
            this.lblInfo1.AutoSize = true;
            this.lblInfo1.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo1.Location = new System.Drawing.Point(5, 6);
            this.lblInfo1.Name = "lblInfo1";
            this.lblInfo1.Size = new System.Drawing.Size(68, 24);
            this.lblInfo1.TabIndex = 9;
            this.lblInfo1.Text = "<info1>";
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInfo2.Location = new System.Drawing.Point(3, 4);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(71, 24);
            this.lblInfo2.TabIndex = 10;
            this.lblInfo2.Text = "<info2>";
            // 
            // btnDelete
            // 
            this.btnDelete.AutoSize = true;
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDelete.Location = new System.Drawing.Point(548, 391);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 38);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Удалить";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AutoSize = true;
            this.btnEdit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEdit.Location = new System.Drawing.Point(548, 347);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(126, 38);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Изменить";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAdd.Location = new System.Drawing.Point(548, 303);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(126, 38);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = global::BookStore.Properties.Resources.exit_icon_icons_com_70975;
            this.pictureBoxExit.Location = new System.Drawing.Point(804, 391);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 20;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // panelInfo2
            // 
            this.panelInfo2.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo2.Controls.Add(this.tbInfo2);
            this.panelInfo2.Controls.Add(this.lblInfo2);
            this.panelInfo2.Location = new System.Drawing.Point(550, 96);
            this.panelInfo2.Name = "panelInfo2";
            this.panelInfo2.Size = new System.Drawing.Size(294, 73);
            this.panelInfo2.TabIndex = 21;
            this.panelInfo2.Visible = false;
            // 
            // panelInfo1
            // 
            this.panelInfo1.BackColor = System.Drawing.Color.Transparent;
            this.panelInfo1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInfo1.Controls.Add(this.tbInfo1);
            this.panelInfo1.Controls.Add(this.lblInfo1);
            this.panelInfo1.Location = new System.Drawing.Point(548, 12);
            this.panelInfo1.Name = "panelInfo1";
            this.panelInfo1.Size = new System.Drawing.Size(296, 78);
            this.panelInfo1.TabIndex = 22;
            // 
            // FormGenresPublishingAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(856, 443);
            this.Controls.Add(this.panelInfo1);
            this.Controls.Add(this.panelInfo2);
            this.Controls.Add(this.pictureBoxExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tableInfo);
            this.Name = "FormGenresPublishingAuthors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книжный магазин - Дополнительная информация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGenresPublishingAuthors_FormClosing);
            this.Load += new System.EventHandler(this.FormGenresPublishingAuthors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panelInfo2.ResumeLayout(false);
            this.panelInfo2.PerformLayout();
            this.panelInfo1.ResumeLayout(false);
            this.panelInfo1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableInfo;
        private System.Windows.Forms.TextBox tbInfo1;
        private System.Windows.Forms.TextBox tbInfo2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Panel panelInfo1;
        private System.Windows.Forms.Panel panelInfo2;
        private System.Windows.Forms.Label lblInfo1;
        private System.Windows.Forms.Label lblInfo2;
    }
}