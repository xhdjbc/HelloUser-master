namespace HelloUser
{
    partial class frmHelloUser
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
            this.EEEEE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutput1 = new System.Windows.Forms.TextBox();
            this.txtOutput2 = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EEEEE
            // 
            this.EEEEE.Location = new System.Drawing.Point(233, 255);
            this.EEEEE.Name = "EEEEE";
            this.EEEEE.Size = new System.Drawing.Size(117, 21);
            this.EEEEE.TabIndex = 0;
            this.EEEEE.Text = "Calculate";
            this.EEEEE.UseVisualStyleBackColor = true;
            this.EEEEE.Click += new System.EventHandler(this.btnSayHello_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Taxes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 33);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tax rate(%)\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtOutput1
            // 
            this.txtOutput1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOutput1.Location = new System.Drawing.Point(174, 136);
            this.txtOutput1.Name = "txtOutput1";
            this.txtOutput1.Size = new System.Drawing.Size(100, 21);
            this.txtOutput1.TabIndex = 3;
            this.txtOutput1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtOutput2
            // 
            this.txtOutput2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtOutput2.Location = new System.Drawing.Point(323, 136);
            this.txtOutput2.Name = "txtOutput2";
            this.txtOutput2.Size = new System.Drawing.Size(100, 21);
            this.txtOutput2.TabIndex = 4;
            // 
            // lblDisplay
            // 
            this.lblDisplay.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplay.Location = new System.Drawing.Point(171, 279);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(252, 108);
            this.lblDisplay.TabIndex = 5;
            this.lblDisplay.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(342, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Calculate the goods\'price with tax";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmHelloUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 396);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtOutput2);
            this.Controls.Add(this.txtOutput1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EEEEE);
            this.Name = "frmHelloUser";
            this.Text = "HelloUser";
            this.Load += new System.EventHandler(this.frmHelloUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EEEEE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutput1;
        private System.Windows.Forms.TextBox txtOutput2;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Label label4;
    }
}

