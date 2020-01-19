namespace BookStore
{
    partial class FormReport
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
            this.tableReport = new System.Windows.Forms.DataGridView();
            this.tableReportBook = new System.Windows.Forms.DataGridView();
            this.pictureBoxExit = new System.Windows.Forms.PictureBox();
            this.panelReport = new System.Windows.Forms.Panel();
            this.lblParamTypeReport = new System.Windows.Forms.Label();
            this.panelReportInfo = new System.Windows.Forms.Panel();
            this.labelInfo = new System.Windows.Forms.Label();
            this.lblArrivalPeriod = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.dateTimePickerBegin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.panelDate = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.lblRub = new System.Windows.Forms.Label();
            this.lblParamSum = new System.Windows.Forms.Label();
            this.lblParamQuantity = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableReportBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).BeginInit();
            this.panelReport.SuspendLayout();
            this.panelReportInfo.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableReport
            // 
            this.tableReport.AllowUserToAddRows = false;
            this.tableReport.AllowUserToDeleteRows = false;
            this.tableReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tableReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Product Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.tableReport.Location = new System.Drawing.Point(8, 41);
            this.tableReport.Name = "tableReport";
            this.tableReport.ReadOnly = true;
            this.tableReport.Size = new System.Drawing.Size(909, 234);
            this.tableReport.TabIndex = 3;
            this.tableReport.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableArrival_CellClick);
            // 
            // tableReportBook
            // 
            this.tableReportBook.AllowUserToAddRows = false;
            this.tableReportBook.AllowUserToDeleteRows = false;
            this.tableReportBook.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableReportBook.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Product Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableReportBook.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.tableReportBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Product Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableReportBook.DefaultCellStyle = dataGridViewCellStyle4;
            this.tableReportBook.Location = new System.Drawing.Point(8, 33);
            this.tableReportBook.Name = "tableReportBook";
            this.tableReportBook.ReadOnly = true;
            this.tableReportBook.Size = new System.Drawing.Size(909, 228);
            this.tableReportBook.TabIndex = 4;
            // 
            // pictureBoxExit
            // 
            this.pictureBoxExit.Image = global::BookStore.Properties.Resources.exit_icon_icons_com_70975;
            this.pictureBoxExit.Location = new System.Drawing.Point(1105, 583);
            this.pictureBoxExit.Name = "pictureBoxExit";
            this.pictureBoxExit.Size = new System.Drawing.Size(40, 40);
            this.pictureBoxExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExit.TabIndex = 24;
            this.pictureBoxExit.TabStop = false;
            this.pictureBoxExit.Click += new System.EventHandler(this.pictureBoxExit_Click);
            // 
            // panelReport
            // 
            this.panelReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReport.Controls.Add(this.lblParamTypeReport);
            this.panelReport.Controls.Add(this.tableReport);
            this.panelReport.Location = new System.Drawing.Point(5, 65);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(925, 283);
            this.panelReport.TabIndex = 25;
            // 
            // lblParamTypeReport
            // 
            this.lblParamTypeReport.AutoSize = true;
            this.lblParamTypeReport.Font = new System.Drawing.Font("Product Sans Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParamTypeReport.Location = new System.Drawing.Point(3, 8);
            this.lblParamTypeReport.Name = "lblParamTypeReport";
            this.lblParamTypeReport.Size = new System.Drawing.Size(167, 30);
            this.lblParamTypeReport.TabIndex = 5;
            this.lblParamTypeReport.Text = "<Тип отчета>";
            // 
            // panelReportInfo
            // 
            this.panelReportInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReportInfo.Controls.Add(this.labelInfo);
            this.panelReportInfo.Controls.Add(this.tableReportBook);
            this.panelReportInfo.Location = new System.Drawing.Point(5, 354);
            this.panelReportInfo.Name = "panelReportInfo";
            this.panelReportInfo.Size = new System.Drawing.Size(925, 269);
            this.panelReportInfo.TabIndex = 26;
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Product Sans Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo.Location = new System.Drawing.Point(6, 0);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(167, 30);
            this.labelInfo.TabIndex = 5;
            this.labelInfo.Text = "Информация";
            // 
            // lblArrivalPeriod
            // 
            this.lblArrivalPeriod.AutoSize = true;
            this.lblArrivalPeriod.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblArrivalPeriod.Location = new System.Drawing.Point(15, 11);
            this.lblArrivalPeriod.Name = "lblArrivalPeriod";
            this.lblArrivalPeriod.Size = new System.Drawing.Size(102, 24);
            this.lblArrivalPeriod.TabIndex = 27;
            this.lblArrivalPeriod.Text = "За период";
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBegin.Location = new System.Drawing.Point(146, 11);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(24, 24);
            this.lblBegin.TabIndex = 28;
            this.lblBegin.Text = "с:";
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblEnd.Location = new System.Drawing.Point(452, 11);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(35, 24);
            this.lblEnd.TabIndex = 29;
            this.lblEnd.Text = "по:";
            // 
            // dateTimePickerBegin
            // 
            this.dateTimePickerBegin.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerBegin.Location = new System.Drawing.Point(188, 6);
            this.dateTimePickerBegin.Name = "dateTimePickerBegin";
            this.dateTimePickerBegin.Size = new System.Drawing.Size(220, 31);
            this.dateTimePickerBegin.TabIndex = 30;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEnd.Location = new System.Drawing.Point(506, 6);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(220, 31);
            this.dateTimePickerEnd.TabIndex = 31;
            // 
            // panelDate
            // 
            this.panelDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDate.Controls.Add(this.btnConfirm);
            this.panelDate.Controls.Add(this.lblArrivalPeriod);
            this.panelDate.Controls.Add(this.dateTimePickerEnd);
            this.panelDate.Controls.Add(this.dateTimePickerBegin);
            this.panelDate.Controls.Add(this.lblBegin);
            this.panelDate.Controls.Add(this.lblEnd);
            this.panelDate.Location = new System.Drawing.Point(5, 12);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(925, 47);
            this.panelDate.TabIndex = 32;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSize = true;
            this.btnConfirm.Font = new System.Drawing.Font("Product Sans Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirm.Location = new System.Drawing.Point(762, 3);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(113, 34);
            this.btnConfirm.TabIndex = 32;
            this.btnConfirm.Text = "Применить";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panelTotal
            // 
            this.panelTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTotal.Controls.Add(this.lblRub);
            this.panelTotal.Controls.Add(this.lblParamSum);
            this.panelTotal.Controls.Add(this.lblParamQuantity);
            this.panelTotal.Controls.Add(this.lblQuantity);
            this.panelTotal.Controls.Add(this.lblSum);
            this.panelTotal.Location = new System.Drawing.Point(936, 65);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(209, 283);
            this.panelTotal.TabIndex = 33;
            // 
            // lblRub
            // 
            this.lblRub.AutoSize = true;
            this.lblRub.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblRub.Location = new System.Drawing.Point(117, 131);
            this.lblRub.Name = "lblRub";
            this.lblRub.Size = new System.Drawing.Size(81, 26);
            this.lblRub.TabIndex = 32;
            this.lblRub.Text = "рублей";
            // 
            // lblParamSum
            // 
            this.lblParamSum.AutoSize = true;
            this.lblParamSum.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParamSum.Location = new System.Drawing.Point(3, 131);
            this.lblParamSum.Name = "lblParamSum";
            this.lblParamSum.Size = new System.Drawing.Size(25, 26);
            this.lblParamSum.TabIndex = 31;
            this.lblParamSum.Text = "0";
            // 
            // lblParamQuantity
            // 
            this.lblParamQuantity.AutoSize = true;
            this.lblParamQuantity.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblParamQuantity.Location = new System.Drawing.Point(3, 57);
            this.lblParamQuantity.Name = "lblParamQuantity";
            this.lblParamQuantity.Size = new System.Drawing.Size(25, 26);
            this.lblParamQuantity.TabIndex = 30;
            this.lblParamQuantity.Text = "0";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQuantity.Location = new System.Drawing.Point(3, 22);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(130, 26);
            this.lblQuantity.TabIndex = 28;
            this.lblQuantity.Text = "Количество:";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSum.Location = new System.Drawing.Point(3, 92);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(106, 26);
            this.lblSum.TabIndex = 29;
            this.lblSum.Text = "На сумму:";
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1160, 636);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.panelDate);
            this.Controls.Add(this.panelReportInfo);
            this.Controls.Add(this.panelReport);
            this.Controls.Add(this.pictureBoxExit);
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книжный магазин - Поступления";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormReport_FormClosing);
            this.Load += new System.EventHandler(this.FormReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableReportBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExit)).EndInit();
            this.panelReport.ResumeLayout(false);
            this.panelReport.PerformLayout();
            this.panelReportInfo.ResumeLayout(false);
            this.panelReportInfo.PerformLayout();
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableReport;
        private System.Windows.Forms.DataGridView tableReportBook;
        private System.Windows.Forms.PictureBox pictureBoxExit;
        private System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Label lblParamTypeReport;
        private System.Windows.Forms.Panel panelReportInfo;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label lblArrivalPeriod;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerBegin;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label lblRub;
        private System.Windows.Forms.Label lblParamSum;
        private System.Windows.Forms.Label lblParamQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblSum;
    }
}