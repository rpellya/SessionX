namespace Спорт
{
    partial class Order_form
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
            this.Order_label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_create = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Order_label
            // 
            this.Order_label.AutoSize = true;
            this.Order_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Order_label.Location = new System.Drawing.Point(27, 23);
            this.Order_label.Name = "Order_label";
            this.Order_label.Size = new System.Drawing.Size(108, 31);
            this.Order_label.TabIndex = 0;
            this.Order_label.Text = "Заказы";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1063, 499);
            this.dataGridView1.TabIndex = 1;
            // 
            // button_create
            // 
            this.button_create.Location = new System.Drawing.Point(899, 22);
            this.button_create.Name = "button_create";
            this.button_create.Size = new System.Drawing.Size(182, 45);
            this.button_create.TabIndex = 2;
            this.button_create.Text = "Сформировать заказ";
            this.button_create.UseVisualStyleBackColor = true;
            this.button_create.Click += new System.EventHandler(this.button_create_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(179, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(682, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Поиск товаров";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Order_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1173, 670);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_create);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Order_label);
            this.Name = "Order_form";
            this.Text = "Orders";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Order_label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_create;
        private System.Windows.Forms.Button button1;
    }
}