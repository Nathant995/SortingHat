namespace Project_SortingHat
{
    partial class frmClient
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
            this.btnClientClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientClose
            // 
            this.btnClientClose.BackColor = System.Drawing.Color.SlateBlue;
            this.btnClientClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientClose.Font = new System.Drawing.Font("Felix Titling", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientClose.Location = new System.Drawing.Point(1196, -2);
            this.btnClientClose.Name = "btnClientClose";
            this.btnClientClose.Size = new System.Drawing.Size(45, 36);
            this.btnClientClose.TabIndex = 0;
            this.btnClientClose.Text = "X";
            this.btnClientClose.UseVisualStyleBackColor = false;
            this.btnClientClose.Click += new System.EventHandler(this.btnClientClose_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1234, 655);
            this.Controls.Add(this.btnClientClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClient";
            this.Text = "SortingHat v0.01";
            this.Load += new System.EventHandler(this.client_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientClose;
    }
}

