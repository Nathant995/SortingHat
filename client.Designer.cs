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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClient));
            this.lblClientTitle = new System.Windows.Forms.Label();
            this.lblClientTitle2 = new System.Windows.Forms.Label();
            this.btnClientClose = new System.Windows.Forms.Button();
            this.btnClientStartSorting = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.wmp1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.pnlSortingHat = new System.Windows.Forms.Panel();
            this.wmpSortingHat = new AxWMPLib.AxWindowsMediaPlayer();
            this.tmrSortingHouse = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp1)).BeginInit();
            this.pnlSortingHat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSortingHat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientTitle
            // 
            this.lblClientTitle.AutoSize = true;
            this.lblClientTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblClientTitle.Font = new System.Drawing.Font("Wizard World", 95.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientTitle.ForeColor = System.Drawing.Color.White;
            this.lblClientTitle.Location = new System.Drawing.Point(21, 36);
            this.lblClientTitle.Name = "lblClientTitle";
            this.lblClientTitle.Size = new System.Drawing.Size(1198, 141);
            this.lblClientTitle.TabIndex = 1;
            this.lblClientTitle.Text = "Wizarding World";
            // 
            // lblClientTitle2
            // 
            this.lblClientTitle2.AutoSize = true;
            this.lblClientTitle2.BackColor = System.Drawing.Color.Transparent;
            this.lblClientTitle2.Font = new System.Drawing.Font("Harry P", 32.75F);
            this.lblClientTitle2.ForeColor = System.Drawing.Color.White;
            this.lblClientTitle2.Location = new System.Drawing.Point(1025, 148);
            this.lblClientTitle2.Name = "lblClientTitle2";
            this.lblClientTitle2.Size = new System.Drawing.Size(165, 43);
            this.lblClientTitle2.TabIndex = 2;
            this.lblClientTitle2.Text = "Sorting Hat";
            // 
            // btnClientClose
            // 
            this.btnClientClose.BackColor = System.Drawing.Color.SlateBlue;
            this.btnClientClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientClose.Font = new System.Drawing.Font("Felix Titling", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientClose.Location = new System.Drawing.Point(1191, -6);
            this.btnClientClose.Name = "btnClientClose";
            this.btnClientClose.Size = new System.Drawing.Size(45, 36);
            this.btnClientClose.TabIndex = 0;
            this.btnClientClose.Text = "X";
            this.btnClientClose.UseVisualStyleBackColor = false;
            this.btnClientClose.Click += new System.EventHandler(this.btnClientClose_Click);
            // 
            // btnClientStartSorting
            // 
            this.btnClientStartSorting.BackColor = System.Drawing.Color.Transparent;
            this.btnClientStartSorting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientStartSorting.Image = ((System.Drawing.Image)(resources.GetObject("btnClientStartSorting.Image")));
            this.btnClientStartSorting.Location = new System.Drawing.Point(251, 504);
            this.btnClientStartSorting.Name = "btnClientStartSorting";
            this.btnClientStartSorting.Size = new System.Drawing.Size(729, 77);
            this.btnClientStartSorting.TabIndex = 3;
            this.btnClientStartSorting.UseVisualStyleBackColor = false;
            this.btnClientStartSorting.Click += new System.EventHandler(this.btnClientStartSorting_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.wmp1);
            this.panel1.Controls.Add(this.btnClientStartSorting);
            this.panel1.Controls.Add(this.lblClientTitle2);
            this.panel1.Controls.Add(this.lblClientTitle);
            this.panel1.Location = new System.Drawing.Point(1, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 622);
            this.panel1.TabIndex = 4;
            // 
            // wmp1
            // 
            this.wmp1.Enabled = true;
            this.wmp1.Location = new System.Drawing.Point(0, 0);
            this.wmp1.Name = "wmp1";
            this.wmp1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp1.OcxState")));
            this.wmp1.Size = new System.Drawing.Size(1235, 666);
            this.wmp1.TabIndex = 4;
            this.wmp1.Visible = false;
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // pnlSortingHat
            // 
            this.pnlSortingHat.Controls.Add(this.wmpSortingHat);
            this.pnlSortingHat.Enabled = false;
            this.pnlSortingHat.Location = new System.Drawing.Point(1, 36);
            this.pnlSortingHat.Name = "pnlSortingHat";
            this.pnlSortingHat.Size = new System.Drawing.Size(1232, 619);
            this.pnlSortingHat.TabIndex = 5;
            this.pnlSortingHat.Visible = false;
            // 
            // wmpSortingHat
            // 
            this.wmpSortingHat.Enabled = true;
            this.wmpSortingHat.Location = new System.Drawing.Point(0, 0);
            this.wmpSortingHat.Name = "wmpSortingHat";
            this.wmpSortingHat.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmpSortingHat.OcxState")));
            this.wmpSortingHat.Size = new System.Drawing.Size(1232, 619);
            this.wmpSortingHat.TabIndex = 0;
            // 
            // tmrSortingHouse
            // 
            this.tmrSortingHouse.Interval = 1000;
            this.tmrSortingHouse.Tick += new System.EventHandler(this.tmrSortingHouse_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Wizard World", 12.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sorting House App";
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1234, 655);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlSortingHat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClientClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmClient";
            this.Text = "SortingHat v0.01";
            this.Load += new System.EventHandler(this.client_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp1)).EndInit();
            this.pnlSortingHat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wmpSortingHat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClientTitle;
        private System.Windows.Forms.Label lblClientTitle2;
        private System.Windows.Forms.Button btnClientClose;
        private System.Windows.Forms.Button btnClientStartSorting;
        private System.Windows.Forms.Panel panel1;
        private AxWMPLib.AxWindowsMediaPlayer wmp1;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Panel pnlSortingHat;
        private AxWMPLib.AxWindowsMediaPlayer wmpSortingHat;
        private System.Windows.Forms.Timer tmrSortingHouse;
        private System.Windows.Forms.Label label1;
    }
}

