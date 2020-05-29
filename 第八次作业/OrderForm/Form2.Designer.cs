namespace OrderForm
{
    partial class Form2
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.orderId = new System.Windows.Forms.Label();
            this.orderName = new System.Windows.Forms.Label();
            this.orderAddress = new System.Windows.Forms.Label();
            this.addSure = new System.Windows.Forms.Button();
            this.addCancel = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.findid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(101, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(101, 112);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 21);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(101, 156);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 21);
            this.textBox3.TabIndex = 2;
            // 
            // orderId
            // 
            this.orderId.AutoSize = true;
            this.orderId.Location = new System.Drawing.Point(41, 78);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(17, 12);
            this.orderId.TabIndex = 3;
            this.orderId.Text = "id";
            // 
            // orderName
            // 
            this.orderName.AutoSize = true;
            this.orderName.Location = new System.Drawing.Point(41, 120);
            this.orderName.Name = "orderName";
            this.orderName.Size = new System.Drawing.Size(53, 12);
            this.orderName.TabIndex = 4;
            this.orderName.Text = "客户姓名";
            // 
            // orderAddress
            // 
            this.orderAddress.AutoSize = true;
            this.orderAddress.Location = new System.Drawing.Point(41, 165);
            this.orderAddress.Name = "orderAddress";
            this.orderAddress.Size = new System.Drawing.Size(29, 12);
            this.orderAddress.TabIndex = 5;
            this.orderAddress.Text = "地址";
            // 
            // addSure
            // 
            this.addSure.Location = new System.Drawing.Point(276, 45);
            this.addSure.Name = "addSure";
            this.addSure.Size = new System.Drawing.Size(75, 23);
            this.addSure.TabIndex = 6;
            this.addSure.Text = "确认";
            this.addSure.UseVisualStyleBackColor = true;
            this.addSure.Click += new System.EventHandler(this.addSure_Click);
            // 
            // addCancel
            // 
            this.addCancel.Location = new System.Drawing.Point(276, 115);
            this.addCancel.Name = "addCancel";
            this.addCancel.Size = new System.Drawing.Size(75, 23);
            this.addCancel.TabIndex = 7;
            this.addCancel.Text = "取消";
            this.addCancel.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(101, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 21);
            this.textBox4.TabIndex = 8;
            // 
            // findid
            // 
            this.findid.AutoSize = true;
            this.findid.Location = new System.Drawing.Point(41, 32);
            this.findid.Name = "findid";
            this.findid.Size = new System.Drawing.Size(41, 12);
            this.findid.TabIndex = 9;
            this.findid.Text = "操作id";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 205);
            this.Controls.Add(this.findid);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.addCancel);
            this.Controls.Add(this.addSure);
            this.Controls.Add(this.orderAddress);
            this.Controls.Add(this.orderName);
            this.Controls.Add(this.orderId);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label orderId;
        private System.Windows.Forms.Label orderName;
        private System.Windows.Forms.Label orderAddress;
        private System.Windows.Forms.Button addSure;
        private System.Windows.Forms.Button addCancel;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label findid;
    }
}