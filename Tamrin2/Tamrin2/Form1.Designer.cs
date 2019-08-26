namespace Tamrin2
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
            this.lblenteryourname = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnsayhello = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblresult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblenteryourname
            // 
            this.lblenteryourname.AutoSize = true;
            this.lblenteryourname.Location = new System.Drawing.Point(12, 9);
            this.lblenteryourname.Name = "lblenteryourname";
            this.lblenteryourname.Size = new System.Drawing.Size(150, 19);
            this.lblenteryourname.TabIndex = 0;
            this.lblenteryourname.Text = "Enter your name:";
            this.lblenteryourname.MouseLeave += new System.EventHandler(this.lblenteryourname_MouseLeave);
            this.lblenteryourname.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblenteryourname_MouseMove);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(168, 6);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(241, 27);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // btnsayhello
            // 
            this.btnsayhello.Location = new System.Drawing.Point(16, 51);
            this.btnsayhello.Name = "btnsayhello";
            this.btnsayhello.Size = new System.Drawing.Size(127, 42);
            this.btnsayhello.TabIndex = 2;
            this.btnsayhello.Text = "&Say Hello";
            this.btnsayhello.UseVisualStyleBackColor = true;
            this.btnsayhello.Click += new System.EventHandler(this.btnsayhello_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(149, 51);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(127, 42);
            this.btnclear.TabIndex = 3;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(282, 51);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(127, 42);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(23, 126);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 19);
            this.lblresult.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 198);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsayhello);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblenteryourname);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "My App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblenteryourname;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnsayhello;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblresult;


    }
}

