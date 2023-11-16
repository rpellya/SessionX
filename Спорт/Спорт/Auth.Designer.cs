namespace Спорт
{
    partial class Auth
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth));
            this.button_log_in = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_captcha = new System.Windows.Forms.Label();
            this.checkBox_captcha = new System.Windows.Forms.CheckBox();
            this.icon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_log_in
            // 
            this.button_log_in.BackColor = System.Drawing.Color.White;
            this.button_log_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button_log_in.Location = new System.Drawing.Point(807, 455);
            this.button_log_in.Name = "button_log_in";
            this.button_log_in.Size = new System.Drawing.Size(218, 60);
            this.button_log_in.TabIndex = 10;
            this.button_log_in.Text = "Log in";
            this.button_log_in.UseVisualStyleBackColor = false;
            this.button_log_in.Click += new System.EventHandler(this.button_log_in_Click);
            // 
            // password
            // 
            this.password.AutoSize = true;
            this.password.BackColor = System.Drawing.SystemColors.WindowText;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.password.Location = new System.Drawing.Point(713, 325);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(108, 26);
            this.password.TabIndex = 9;
            this.password.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(843, 331);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // login
            // 
            this.login.AutoSize = true;
            this.login.BackColor = System.Drawing.SystemColors.WindowText;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.login.Location = new System.Drawing.Point(747, 280);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(65, 26);
            this.login.TabIndex = 7;
            this.login.Text = "Login";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(843, 280);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(490, -9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(973, 950);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label_captcha
            // 
            this.label_captcha.AutoSize = true;
            this.label_captcha.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_captcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_captcha.Location = new System.Drawing.Point(838, 404);
            this.label_captcha.Name = "label_captcha";
            this.label_captcha.Size = new System.Drawing.Size(92, 25);
            this.label_captcha.TabIndex = 13;
            this.label_captcha.Text = "Captcha";
            // 
            // checkBox_captcha
            // 
            this.checkBox_captcha.AutoSize = true;
            this.checkBox_captcha.Location = new System.Drawing.Point(993, 413);
            this.checkBox_captcha.Name = "checkBox_captcha";
            this.checkBox_captcha.Size = new System.Drawing.Size(15, 14);
            this.checkBox_captcha.TabIndex = 14;
            this.checkBox_captcha.UseVisualStyleBackColor = true;
            this.checkBox_captcha.CheckedChanged += new System.EventHandler(this.checkBox_captcha_CheckedChanged);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.White;
            this.icon.BackgroundImage = global::Спорт.Properties.Resources.logo;
            this.icon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.icon.ForeColor = System.Drawing.Color.Transparent;
            this.icon.Location = new System.Drawing.Point(919, 12);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(170, 130);
            this.icon.TabIndex = 15;
            this.icon.UseVisualStyleBackColor = false;
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Спорт.Properties.Resources.G403T5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1101, 619);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.checkBox_captcha);
            this.Controls.Add(this.label_captcha);
            this.Controls.Add(this.button_log_in);
            this.Controls.Add(this.password);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.login);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Name = "Auth";
            this.Text = "Auth";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_log_in;
        private System.Windows.Forms.Label password;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label login;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_captcha;
        private System.Windows.Forms.CheckBox checkBox_captcha;
        private System.Windows.Forms.Button icon;
    }
}

