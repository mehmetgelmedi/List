namespace List
{
    partial class Form1
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
            this.btnAdim2 = new System.Windows.Forms.Button();
            this.txtElemanAl = new System.Windows.Forms.TextBox();
            this.btnAdim3 = new System.Windows.Forms.Button();
            this.btnAdim4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdim2
            // 
            this.btnAdim2.Location = new System.Drawing.Point(82, 65);
            this.btnAdim2.Name = "btnAdim2";
            this.btnAdim2.Size = new System.Drawing.Size(131, 23);
            this.btnAdim2.TabIndex = 0;
            this.btnAdim2.Text = "Adım-2";
            this.btnAdim2.UseVisualStyleBackColor = true;
            this.btnAdim2.Click += new System.EventHandler(this.btnAdim2_Click);
            // 
            // txtElemanAl
            // 
            this.txtElemanAl.Location = new System.Drawing.Point(82, 95);
            this.txtElemanAl.Name = "txtElemanAl";
            this.txtElemanAl.Size = new System.Drawing.Size(131, 20);
            this.txtElemanAl.TabIndex = 1;
            // 
            // btnAdim3
            // 
            this.btnAdim3.Enabled = false;
            this.btnAdim3.Location = new System.Drawing.Point(82, 122);
            this.btnAdim3.Name = "btnAdim3";
            this.btnAdim3.Size = new System.Drawing.Size(131, 23);
            this.btnAdim3.TabIndex = 2;
            this.btnAdim3.Text = "Adım-3";
            this.btnAdim3.UseVisualStyleBackColor = true;
            this.btnAdim3.Click += new System.EventHandler(this.btnAdim3_Click);
            // 
            // btnAdim4
            // 
            this.btnAdim4.Location = new System.Drawing.Point(82, 151);
            this.btnAdim4.Name = "btnAdim4";
            this.btnAdim4.Size = new System.Drawing.Size(131, 23);
            this.btnAdim4.TabIndex = 3;
            this.btnAdim4.Text = "Adım-4";
            this.btnAdim4.UseVisualStyleBackColor = true;
            this.btnAdim4.Click += new System.EventHandler(this.btnAdim4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnAdim4);
            this.Controls.Add(this.btnAdim3);
            this.Controls.Add(this.txtElemanAl);
            this.Controls.Add(this.btnAdim2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "1.Ödev Tek Yönlü LinkedList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdim2;
        private System.Windows.Forms.TextBox txtElemanAl;
        private System.Windows.Forms.Button btnAdim3;
        private System.Windows.Forms.Button btnAdim4;
    }
}

