namespace Tree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.DrawButton = new System.Windows.Forms.Button();
            this.depth = new System.Windows.Forms.NumericUpDown();
            this.leftAngle = new System.Windows.Forms.NumericUpDown();
            this.rightAngle = new System.Windows.Forms.NumericUpDown();
            this.leftLength = new System.Windows.Forms.NumericUpDown();
            this.rightLength = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.drawColor = new System.Windows.Forms.ColorDialog();
            this.colorB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.depth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLength)).BeginInit();
            this.SuspendLayout();
            // 
            // DrawButton
            // 
            this.DrawButton.Location = new System.Drawing.Point(696, 365);
            this.DrawButton.Name = "DrawButton";
            this.DrawButton.Size = new System.Drawing.Size(75, 23);
            this.DrawButton.TabIndex = 0;
            this.DrawButton.Text = "draw";
            this.DrawButton.UseVisualStyleBackColor = true;
            this.DrawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // depth
            // 
            this.depth.Location = new System.Drawing.Point(696, 38);
            this.depth.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.depth.Name = "depth";
            this.depth.Size = new System.Drawing.Size(59, 21);
            this.depth.TabIndex = 1;
            this.depth.ValueChanged += new System.EventHandler(this.depth_ValueChanged);
            // 
            // leftAngle
            // 
            this.leftAngle.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.leftAngle.Location = new System.Drawing.Point(696, 80);
            this.leftAngle.Name = "leftAngle";
            this.leftAngle.Size = new System.Drawing.Size(59, 21);
            this.leftAngle.TabIndex = 2;
            this.leftAngle.ValueChanged += new System.EventHandler(this.leftAngle_ValueChanged);
            // 
            // rightAngle
            // 
            this.rightAngle.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rightAngle.Location = new System.Drawing.Point(696, 128);
            this.rightAngle.Name = "rightAngle";
            this.rightAngle.Size = new System.Drawing.Size(59, 21);
            this.rightAngle.TabIndex = 3;
            this.rightAngle.ValueChanged += new System.EventHandler(this.rightAngle_ValueChanged);
            // 
            // leftLength
            // 
            this.leftLength.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.leftLength.Location = new System.Drawing.Point(696, 177);
            this.leftLength.Name = "leftLength";
            this.leftLength.Size = new System.Drawing.Size(59, 21);
            this.leftLength.TabIndex = 4;
            this.leftLength.ValueChanged += new System.EventHandler(this.leftLength_ValueChanged);
            // 
            // rightLength
            // 
            this.rightLength.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rightLength.Location = new System.Drawing.Point(696, 228);
            this.rightLength.Name = "rightLength";
            this.rightLength.Size = new System.Drawing.Size(59, 21);
            this.rightLength.TabIndex = 5;
            this.rightLength.ValueChanged += new System.EventHandler(this.rightLength_ValueChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(696, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "depth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "leftAngle";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(592, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "rightAngle";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(594, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 10;
            this.label4.Text = "leftLength";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(592, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "rightLength";
            // 
            // colorB
            // 
            this.colorB.Location = new System.Drawing.Point(645, 295);
            this.colorB.Name = "colorB";
            this.colorB.Size = new System.Drawing.Size(75, 23);
            this.colorB.TabIndex = 12;
            this.colorB.Text = "color";
            this.colorB.UseVisualStyleBackColor = true;
            this.colorB.Click += new System.EventHandler(this.colorB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rightLength);
            this.Controls.Add(this.leftLength);
            this.Controls.Add(this.rightAngle);
            this.Controls.Add(this.leftAngle);
            this.Controls.Add(this.depth);
            this.Controls.Add(this.DrawButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.depth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DrawButton;
        private System.Windows.Forms.NumericUpDown depth;
        private System.Windows.Forms.NumericUpDown leftAngle;
        private System.Windows.Forms.NumericUpDown rightAngle;
        private System.Windows.Forms.NumericUpDown leftLength;
        private System.Windows.Forms.NumericUpDown rightLength;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColorDialog drawColor;
        private System.Windows.Forms.Button colorB;
    }
}

