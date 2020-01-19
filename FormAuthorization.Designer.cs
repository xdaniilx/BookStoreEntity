namespace BookStore
{
    partial class FormAuthorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnter = new System.Windows.Forms.Button();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblAuthorization = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lblShopName = new System.Windows.Forms.Label();
            this.panelAuthorization = new System.Windows.Forms.Panel();
            this.chbShowHidePass = new System.Windows.Forms.CheckBox();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.panelAuthorization.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnter
            // 
            this.btnEnter.AutoSize = true;
            this.btnEnter.BackColor = System.Drawing.Color.Beige;
            this.btnEnter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnter.Font = new System.Drawing.Font("Product Sans", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEnter.Location = new System.Drawing.Point(121, 260);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(112, 38);
            this.btnEnter.TabIndex = 0;
            this.btnEnter.Text = "Войти";
            this.btnEnter.UseVisualStyleBackColor = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tbLogin
            // 
            this.tbLogin.Font = new System.Drawing.Font("Product Sans Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLogin.Location = new System.Drawing.Point(56, 109);
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(239, 33);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.Text = "petrova";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Product Sans Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.Location = new System.Drawing.Point(56, 172);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(239, 33);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "pe123456";
            // 
            // lblAuthorization
            // 
            this.lblAuthorization.AutoSize = true;
            this.lblAuthorization.Font = new System.Drawing.Font("Product Sans Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAuthorization.Location = new System.Drawing.Point(92, 30);
            this.lblAuthorization.Name = "lblAuthorization";
            this.lblAuthorization.Size = new System.Drawing.Size(169, 30);
            this.lblAuthorization.TabIndex = 3;
            this.lblAuthorization.Text = "Авторизация";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(144, 82);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(62, 24);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Логин";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(137, 146);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 24);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Пароль";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.LemonChiffon;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogo.Controls.Add(this.pictureBoxLogo);
            this.panelLogo.Controls.Add(this.lblShopName);
            this.panelLogo.Location = new System.Drawing.Point(12, 12);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(364, 320);
            this.panelLogo.TabIndex = 6;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::BookStore.Properties.Resources.kniga125;
            this.pictureBoxLogo.Location = new System.Drawing.Point(35, 109);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(285, 166);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 5;
            this.pictureBoxLogo.TabStop = false;
            // 
            // lblShopName
            // 
            this.lblShopName.Font = new System.Drawing.Font("Product Sans Light", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShopName.Location = new System.Drawing.Point(28, 18);
            this.lblShopName.Name = "lblShopName";
            this.lblShopName.Size = new System.Drawing.Size(305, 48);
            this.lblShopName.TabIndex = 4;
            this.lblShopName.Text = "Книжный магазин";
            this.lblShopName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelAuthorization
            // 
            this.panelAuthorization.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelAuthorization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAuthorization.Controls.Add(this.chbShowHidePass);
            this.panelAuthorization.Controls.Add(this.btnEnter);
            this.panelAuthorization.Controls.Add(this.tbLogin);
            this.panelAuthorization.Controls.Add(this.lblPassword);
            this.panelAuthorization.Controls.Add(this.lblAuthorization);
            this.panelAuthorization.Controls.Add(this.lblLogin);
            this.panelAuthorization.Controls.Add(this.tbPassword);
            this.panelAuthorization.Location = new System.Drawing.Point(382, 12);
            this.panelAuthorization.Name = "panelAuthorization";
            this.panelAuthorization.Size = new System.Drawing.Size(364, 320);
            this.panelAuthorization.TabIndex = 7;
            // 
            // chbShowHidePass
            // 
            this.chbShowHidePass.AutoSize = true;
            this.chbShowHidePass.Font = new System.Drawing.Font("Product Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbShowHidePass.Location = new System.Drawing.Point(56, 211);
            this.chbShowHidePass.Name = "chbShowHidePass";
            this.chbShowHidePass.Size = new System.Drawing.Size(245, 28);
            this.chbShowHidePass.TabIndex = 6;
            this.chbShowHidePass.Text = "Показать/скрыть пароль";
            this.chbShowHidePass.UseVisualStyleBackColor = true;
            this.chbShowHidePass.CheckedChanged += new System.EventHandler(this.chbShowHidePass_CheckedChanged);
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(756, 346);
            this.Controls.Add(this.panelAuthorization);
            this.Controls.Add(this.panelLogo);
            this.Name = "FormAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Книжный магазин - Авторизация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAuthorization_FormClosing);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.panelAuthorization.ResumeLayout(false);
            this.panelAuthorization.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblAuthorization;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelAuthorization;
        private System.Windows.Forms.CheckBox chbShowHidePass;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Label lblShopName;
    }
}

