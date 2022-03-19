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
            this.pnlUI = new System.Windows.Forms.Panel();
            this.btnQuizSubmit = new System.Windows.Forms.Button();
            this.txtWizardName = new System.Windows.Forms.TextBox();
            this.gbxQuizGender = new System.Windows.Forms.GroupBox();
            this.rboGender_Male = new System.Windows.Forms.RadioButton();
            this.rboGender_Female = new System.Windows.Forms.RadioButton();
            this.gbxQuestion2 = new System.Windows.Forms.GroupBox();
            this.rdo_q2_opt2 = new System.Windows.Forms.RadioButton();
            this.rdo_q2_opt3 = new System.Windows.Forms.RadioButton();
            this.rdo_q2_opt4 = new System.Windows.Forms.RadioButton();
            this.rdo_q2_opt1 = new System.Windows.Forms.RadioButton();
            this.gbxQuestion4 = new System.Windows.Forms.GroupBox();
            this.rdo_q4_opt1 = new System.Windows.Forms.RadioButton();
            this.rdo_q4_opt4 = new System.Windows.Forms.RadioButton();
            this.rdo_q4_opt3 = new System.Windows.Forms.RadioButton();
            this.rdo_q4_opt2 = new System.Windows.Forms.RadioButton();
            this.gbxQuestion6 = new System.Windows.Forms.GroupBox();
            this.rdo_q6_opt1 = new System.Windows.Forms.RadioButton();
            this.rdo_q6_opt4 = new System.Windows.Forms.RadioButton();
            this.rdo_q6_opt3 = new System.Windows.Forms.RadioButton();
            this.rdo_q6_opt2 = new System.Windows.Forms.RadioButton();
            this.gbxQuestion1 = new System.Windows.Forms.GroupBox();
            this.rdo_q1_opt1 = new System.Windows.Forms.RadioButton();
            this.rdo_q1_opt4 = new System.Windows.Forms.RadioButton();
            this.rdo_q1_opt3 = new System.Windows.Forms.RadioButton();
            this.rdo_q1_opt2 = new System.Windows.Forms.RadioButton();
            this.gbxQuestion3 = new System.Windows.Forms.GroupBox();
            this.rdo_q3_opt1 = new System.Windows.Forms.RadioButton();
            this.rdo_q3_opt4 = new System.Windows.Forms.RadioButton();
            this.rdo_q3_opt3 = new System.Windows.Forms.RadioButton();
            this.rdo_q3_opt2 = new System.Windows.Forms.RadioButton();
            this.gbxQuestion5 = new System.Windows.Forms.GroupBox();
            this.rdo_q5_opt1 = new System.Windows.Forms.RadioButton();
            this.rdo_q5_opt4 = new System.Windows.Forms.RadioButton();
            this.rdo_q5_opt3 = new System.Windows.Forms.RadioButton();
            this.rdo_q5_opt2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmp1)).BeginInit();
            this.pnlSortingHat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wmpSortingHat)).BeginInit();
            this.pnlUI.SuspendLayout();
            this.gbxQuizGender.SuspendLayout();
            this.gbxQuestion2.SuspendLayout();
            this.gbxQuestion4.SuspendLayout();
            this.gbxQuestion6.SuspendLayout();
            this.gbxQuestion1.SuspendLayout();
            this.gbxQuestion3.SuspendLayout();
            this.gbxQuestion5.SuspendLayout();
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
            this.pnlSortingHat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlSortingHat.BackgroundImage")));
            this.pnlSortingHat.Controls.Add(this.pnlUI);
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
            // pnlUI
            // 
            this.pnlUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUI.Controls.Add(this.gbxQuestion5);
            this.pnlUI.Controls.Add(this.gbxQuestion3);
            this.pnlUI.Controls.Add(this.gbxQuestion1);
            this.pnlUI.Controls.Add(this.gbxQuestion6);
            this.pnlUI.Controls.Add(this.gbxQuestion4);
            this.pnlUI.Controls.Add(this.gbxQuestion2);
            this.pnlUI.Controls.Add(this.gbxQuizGender);
            this.pnlUI.Controls.Add(this.txtWizardName);
            this.pnlUI.Controls.Add(this.btnQuizSubmit);
            this.pnlUI.Enabled = false;
            this.pnlUI.Location = new System.Drawing.Point(45, 36);
            this.pnlUI.Name = "pnlUI";
            this.pnlUI.Size = new System.Drawing.Size(1145, 545);
            this.pnlUI.TabIndex = 7;
            this.pnlUI.Visible = false;
            // 
            // btnQuizSubmit
            // 
            this.btnQuizSubmit.Location = new System.Drawing.Point(504, 512);
            this.btnQuizSubmit.Name = "btnQuizSubmit";
            this.btnQuizSubmit.Size = new System.Drawing.Size(135, 31);
            this.btnQuizSubmit.TabIndex = 0;
            this.btnQuizSubmit.Text = "Submit";
            this.btnQuizSubmit.UseVisualStyleBackColor = true;
            // 
            // txtWizardName
            // 
            this.txtWizardName.Location = new System.Drawing.Point(2, 88);
            this.txtWizardName.Name = "txtWizardName";
            this.txtWizardName.Size = new System.Drawing.Size(236, 20);
            this.txtWizardName.TabIndex = 1;
            // 
            // gbxQuizGender
            // 
            this.gbxQuizGender.Controls.Add(this.rboGender_Female);
            this.gbxQuizGender.Controls.Add(this.rboGender_Male);
            this.gbxQuizGender.Location = new System.Drawing.Point(8, 121);
            this.gbxQuizGender.Name = "gbxQuizGender";
            this.gbxQuizGender.Size = new System.Drawing.Size(230, 61);
            this.gbxQuizGender.TabIndex = 2;
            this.gbxQuizGender.TabStop = false;
            this.gbxQuizGender.Text = "Gender";
            // 
            // rboGender_Male
            // 
            this.rboGender_Male.AutoSize = true;
            this.rboGender_Male.Location = new System.Drawing.Point(6, 27);
            this.rboGender_Male.Name = "rboGender_Male";
            this.rboGender_Male.Size = new System.Drawing.Size(48, 17);
            this.rboGender_Male.TabIndex = 0;
            this.rboGender_Male.TabStop = true;
            this.rboGender_Male.Text = "Male";
            this.rboGender_Male.UseVisualStyleBackColor = true;
            // 
            // rboGender_Female
            // 
            this.rboGender_Female.AutoSize = true;
            this.rboGender_Female.Location = new System.Drawing.Point(165, 27);
            this.rboGender_Female.Name = "rboGender_Female";
            this.rboGender_Female.Size = new System.Drawing.Size(59, 17);
            this.rboGender_Female.TabIndex = 1;
            this.rboGender_Female.TabStop = true;
            this.rboGender_Female.Text = "Female";
            this.rboGender_Female.UseVisualStyleBackColor = true;
            // 
            // gbxQuestion2
            // 
            this.gbxQuestion2.Controls.Add(this.rdo_q2_opt1);
            this.gbxQuestion2.Controls.Add(this.rdo_q2_opt4);
            this.gbxQuestion2.Controls.Add(this.rdo_q2_opt3);
            this.gbxQuestion2.Controls.Add(this.rdo_q2_opt2);
            this.gbxQuestion2.Location = new System.Drawing.Point(807, 56);
            this.gbxQuestion2.Name = "gbxQuestion2";
            this.gbxQuestion2.Size = new System.Drawing.Size(268, 141);
            this.gbxQuestion2.TabIndex = 3;
            this.gbxQuestion2.TabStop = false;
            this.gbxQuestion2.Text = "Question 2";
            // 
            // rdo_q2_opt2
            // 
            this.rdo_q2_opt2.AutoSize = true;
            this.rdo_q2_opt2.Location = new System.Drawing.Point(84, 44);
            this.rdo_q2_opt2.Name = "rdo_q2_opt2";
            this.rdo_q2_opt2.Size = new System.Drawing.Size(85, 17);
            this.rdo_q2_opt2.TabIndex = 0;
            this.rdo_q2_opt2.TabStop = true;
            this.rdo_q2_opt2.Text = "radioButton1";
            this.rdo_q2_opt2.UseVisualStyleBackColor = true;
            // 
            // rdo_q2_opt3
            // 
            this.rdo_q2_opt3.AutoSize = true;
            this.rdo_q2_opt3.Location = new System.Drawing.Point(84, 77);
            this.rdo_q2_opt3.Name = "rdo_q2_opt3";
            this.rdo_q2_opt3.Size = new System.Drawing.Size(85, 17);
            this.rdo_q2_opt3.TabIndex = 1;
            this.rdo_q2_opt3.TabStop = true;
            this.rdo_q2_opt3.Text = "radioButton2";
            this.rdo_q2_opt3.UseVisualStyleBackColor = true;
            // 
            // rdo_q2_opt4
            // 
            this.rdo_q2_opt4.AutoSize = true;
            this.rdo_q2_opt4.Location = new System.Drawing.Point(84, 109);
            this.rdo_q2_opt4.Name = "rdo_q2_opt4";
            this.rdo_q2_opt4.Size = new System.Drawing.Size(85, 17);
            this.rdo_q2_opt4.TabIndex = 2;
            this.rdo_q2_opt4.TabStop = true;
            this.rdo_q2_opt4.Text = "radioButton3";
            this.rdo_q2_opt4.UseVisualStyleBackColor = true;
            // 
            // rdo_q2_opt1
            // 
            this.rdo_q2_opt1.AutoSize = true;
            this.rdo_q2_opt1.Location = new System.Drawing.Point(84, 10);
            this.rdo_q2_opt1.Name = "rdo_q2_opt1";
            this.rdo_q2_opt1.Size = new System.Drawing.Size(85, 17);
            this.rdo_q2_opt1.TabIndex = 3;
            this.rdo_q2_opt1.TabStop = true;
            this.rdo_q2_opt1.Text = "radioButton4";
            this.rdo_q2_opt1.UseVisualStyleBackColor = true;
            // 
            // gbxQuestion4
            // 
            this.gbxQuestion4.Controls.Add(this.rdo_q4_opt1);
            this.gbxQuestion4.Controls.Add(this.rdo_q4_opt4);
            this.gbxQuestion4.Controls.Add(this.rdo_q4_opt3);
            this.gbxQuestion4.Controls.Add(this.rdo_q4_opt2);
            this.gbxQuestion4.Location = new System.Drawing.Point(807, 203);
            this.gbxQuestion4.Name = "gbxQuestion4";
            this.gbxQuestion4.Size = new System.Drawing.Size(268, 141);
            this.gbxQuestion4.TabIndex = 4;
            this.gbxQuestion4.TabStop = false;
            this.gbxQuestion4.Text = "Question 4";
            // 
            // rdo_q4_opt1
            // 
            this.rdo_q4_opt1.AutoSize = true;
            this.rdo_q4_opt1.Location = new System.Drawing.Point(84, 10);
            this.rdo_q4_opt1.Name = "rdo_q4_opt1";
            this.rdo_q4_opt1.Size = new System.Drawing.Size(85, 17);
            this.rdo_q4_opt1.TabIndex = 3;
            this.rdo_q4_opt1.TabStop = true;
            this.rdo_q4_opt1.Text = "radioButton5";
            this.rdo_q4_opt1.UseVisualStyleBackColor = true;
            // 
            // rdo_q4_opt4
            // 
            this.rdo_q4_opt4.AutoSize = true;
            this.rdo_q4_opt4.Location = new System.Drawing.Point(84, 109);
            this.rdo_q4_opt4.Name = "rdo_q4_opt4";
            this.rdo_q4_opt4.Size = new System.Drawing.Size(85, 17);
            this.rdo_q4_opt4.TabIndex = 2;
            this.rdo_q4_opt4.TabStop = true;
            this.rdo_q4_opt4.Text = "radioButton6";
            this.rdo_q4_opt4.UseVisualStyleBackColor = true;
            // 
            // rdo_q4_opt3
            // 
            this.rdo_q4_opt3.AutoSize = true;
            this.rdo_q4_opt3.Location = new System.Drawing.Point(84, 77);
            this.rdo_q4_opt3.Name = "rdo_q4_opt3";
            this.rdo_q4_opt3.Size = new System.Drawing.Size(85, 17);
            this.rdo_q4_opt3.TabIndex = 1;
            this.rdo_q4_opt3.TabStop = true;
            this.rdo_q4_opt3.Text = "radioButton7";
            this.rdo_q4_opt3.UseVisualStyleBackColor = true;
            // 
            // rdo_q4_opt2
            // 
            this.rdo_q4_opt2.AutoSize = true;
            this.rdo_q4_opt2.Location = new System.Drawing.Point(84, 44);
            this.rdo_q4_opt2.Name = "rdo_q4_opt2";
            this.rdo_q4_opt2.Size = new System.Drawing.Size(85, 17);
            this.rdo_q4_opt2.TabIndex = 0;
            this.rdo_q4_opt2.TabStop = true;
            this.rdo_q4_opt2.Text = "radioButton8";
            this.rdo_q4_opt2.UseVisualStyleBackColor = true;
            // 
            // gbxQuestion6
            // 
            this.gbxQuestion6.Controls.Add(this.rdo_q6_opt1);
            this.gbxQuestion6.Controls.Add(this.rdo_q6_opt4);
            this.gbxQuestion6.Controls.Add(this.rdo_q6_opt3);
            this.gbxQuestion6.Controls.Add(this.rdo_q6_opt2);
            this.gbxQuestion6.Location = new System.Drawing.Point(807, 350);
            this.gbxQuestion6.Name = "gbxQuestion6";
            this.gbxQuestion6.Size = new System.Drawing.Size(268, 141);
            this.gbxQuestion6.TabIndex = 4;
            this.gbxQuestion6.TabStop = false;
            this.gbxQuestion6.Text = "Question 6";
            // 
            // rdo_q6_opt1
            // 
            this.rdo_q6_opt1.AutoSize = true;
            this.rdo_q6_opt1.Location = new System.Drawing.Point(84, 10);
            this.rdo_q6_opt1.Name = "rdo_q6_opt1";
            this.rdo_q6_opt1.Size = new System.Drawing.Size(85, 17);
            this.rdo_q6_opt1.TabIndex = 3;
            this.rdo_q6_opt1.TabStop = true;
            this.rdo_q6_opt1.Text = "radioButton9";
            this.rdo_q6_opt1.UseVisualStyleBackColor = true;
            // 
            // rdo_q6_opt4
            // 
            this.rdo_q6_opt4.AutoSize = true;
            this.rdo_q6_opt4.Location = new System.Drawing.Point(84, 109);
            this.rdo_q6_opt4.Name = "rdo_q6_opt4";
            this.rdo_q6_opt4.Size = new System.Drawing.Size(91, 17);
            this.rdo_q6_opt4.TabIndex = 2;
            this.rdo_q6_opt4.TabStop = true;
            this.rdo_q6_opt4.Text = "radioButton10";
            this.rdo_q6_opt4.UseVisualStyleBackColor = true;
            // 
            // rdo_q6_opt3
            // 
            this.rdo_q6_opt3.AutoSize = true;
            this.rdo_q6_opt3.Location = new System.Drawing.Point(84, 77);
            this.rdo_q6_opt3.Name = "rdo_q6_opt3";
            this.rdo_q6_opt3.Size = new System.Drawing.Size(91, 17);
            this.rdo_q6_opt3.TabIndex = 1;
            this.rdo_q6_opt3.TabStop = true;
            this.rdo_q6_opt3.Text = "radioButton11";
            this.rdo_q6_opt3.UseVisualStyleBackColor = true;
            // 
            // rdo_q6_opt2
            // 
            this.rdo_q6_opt2.AutoSize = true;
            this.rdo_q6_opt2.Location = new System.Drawing.Point(84, 44);
            this.rdo_q6_opt2.Name = "rdo_q6_opt2";
            this.rdo_q6_opt2.Size = new System.Drawing.Size(91, 17);
            this.rdo_q6_opt2.TabIndex = 0;
            this.rdo_q6_opt2.TabStop = true;
            this.rdo_q6_opt2.Text = "radioButton12";
            this.rdo_q6_opt2.UseVisualStyleBackColor = true;
            // 
            // gbxQuestion1
            // 
            this.gbxQuestion1.Controls.Add(this.rdo_q1_opt1);
            this.gbxQuestion1.Controls.Add(this.rdo_q1_opt4);
            this.gbxQuestion1.Controls.Add(this.rdo_q1_opt3);
            this.gbxQuestion1.Controls.Add(this.rdo_q1_opt2);
            this.gbxQuestion1.Location = new System.Drawing.Point(454, 56);
            this.gbxQuestion1.Name = "gbxQuestion1";
            this.gbxQuestion1.Size = new System.Drawing.Size(268, 141);
            this.gbxQuestion1.TabIndex = 4;
            this.gbxQuestion1.TabStop = false;
            this.gbxQuestion1.Text = "Question 1";
            // 
            // rdo_q1_opt1
            // 
            this.rdo_q1_opt1.AutoSize = true;
            this.rdo_q1_opt1.Location = new System.Drawing.Point(84, 10);
            this.rdo_q1_opt1.Name = "rdo_q1_opt1";
            this.rdo_q1_opt1.Size = new System.Drawing.Size(31, 17);
            this.rdo_q1_opt1.TabIndex = 3;
            this.rdo_q1_opt1.TabStop = true;
            this.rdo_q1_opt1.Text = "1";
            this.rdo_q1_opt1.UseVisualStyleBackColor = true;
            // 
            // rdo_q1_opt4
            // 
            this.rdo_q1_opt4.AutoSize = true;
            this.rdo_q1_opt4.Location = new System.Drawing.Point(84, 109);
            this.rdo_q1_opt4.Name = "rdo_q1_opt4";
            this.rdo_q1_opt4.Size = new System.Drawing.Size(91, 17);
            this.rdo_q1_opt4.TabIndex = 2;
            this.rdo_q1_opt4.TabStop = true;
            this.rdo_q1_opt4.Text = "radioButton14";
            this.rdo_q1_opt4.UseVisualStyleBackColor = true;
            // 
            // rdo_q1_opt3
            // 
            this.rdo_q1_opt3.AutoSize = true;
            this.rdo_q1_opt3.Location = new System.Drawing.Point(84, 77);
            this.rdo_q1_opt3.Name = "rdo_q1_opt3";
            this.rdo_q1_opt3.Size = new System.Drawing.Size(91, 17);
            this.rdo_q1_opt3.TabIndex = 1;
            this.rdo_q1_opt3.TabStop = true;
            this.rdo_q1_opt3.Text = "radioButton15";
            this.rdo_q1_opt3.UseVisualStyleBackColor = true;
            // 
            // rdo_q1_opt2
            // 
            this.rdo_q1_opt2.AutoSize = true;
            this.rdo_q1_opt2.Location = new System.Drawing.Point(84, 44);
            this.rdo_q1_opt2.Name = "rdo_q1_opt2";
            this.rdo_q1_opt2.Size = new System.Drawing.Size(31, 17);
            this.rdo_q1_opt2.TabIndex = 0;
            this.rdo_q1_opt2.TabStop = true;
            this.rdo_q1_opt2.Text = "2";
            this.rdo_q1_opt2.UseVisualStyleBackColor = true;
            // 
            // gbxQuestion3
            // 
            this.gbxQuestion3.Controls.Add(this.rdo_q3_opt1);
            this.gbxQuestion3.Controls.Add(this.rdo_q3_opt4);
            this.gbxQuestion3.Controls.Add(this.rdo_q3_opt3);
            this.gbxQuestion3.Controls.Add(this.rdo_q3_opt2);
            this.gbxQuestion3.Location = new System.Drawing.Point(454, 203);
            this.gbxQuestion3.Name = "gbxQuestion3";
            this.gbxQuestion3.Size = new System.Drawing.Size(268, 141);
            this.gbxQuestion3.TabIndex = 4;
            this.gbxQuestion3.TabStop = false;
            this.gbxQuestion3.Text = "Question 3";
            // 
            // rdo_q3_opt1
            // 
            this.rdo_q3_opt1.AutoSize = true;
            this.rdo_q3_opt1.Location = new System.Drawing.Point(84, 10);
            this.rdo_q3_opt1.Name = "rdo_q3_opt1";
            this.rdo_q3_opt1.Size = new System.Drawing.Size(91, 17);
            this.rdo_q3_opt1.TabIndex = 3;
            this.rdo_q3_opt1.TabStop = true;
            this.rdo_q3_opt1.Text = "radioButton17";
            this.rdo_q3_opt1.UseVisualStyleBackColor = true;
            // 
            // rdo_q3_opt4
            // 
            this.rdo_q3_opt4.AutoSize = true;
            this.rdo_q3_opt4.Location = new System.Drawing.Point(84, 109);
            this.rdo_q3_opt4.Name = "rdo_q3_opt4";
            this.rdo_q3_opt4.Size = new System.Drawing.Size(91, 17);
            this.rdo_q3_opt4.TabIndex = 2;
            this.rdo_q3_opt4.TabStop = true;
            this.rdo_q3_opt4.Text = "radioButton18";
            this.rdo_q3_opt4.UseVisualStyleBackColor = true;
            // 
            // rdo_q3_opt3
            // 
            this.rdo_q3_opt3.AutoSize = true;
            this.rdo_q3_opt3.Location = new System.Drawing.Point(84, 77);
            this.rdo_q3_opt3.Name = "rdo_q3_opt3";
            this.rdo_q3_opt3.Size = new System.Drawing.Size(91, 17);
            this.rdo_q3_opt3.TabIndex = 1;
            this.rdo_q3_opt3.TabStop = true;
            this.rdo_q3_opt3.Text = "radioButton19";
            this.rdo_q3_opt3.UseVisualStyleBackColor = true;
            // 
            // rdo_q3_opt2
            // 
            this.rdo_q3_opt2.AutoSize = true;
            this.rdo_q3_opt2.Location = new System.Drawing.Point(84, 44);
            this.rdo_q3_opt2.Name = "rdo_q3_opt2";
            this.rdo_q3_opt2.Size = new System.Drawing.Size(91, 17);
            this.rdo_q3_opt2.TabIndex = 0;
            this.rdo_q3_opt2.TabStop = true;
            this.rdo_q3_opt2.Text = "radioButton20";
            this.rdo_q3_opt2.UseVisualStyleBackColor = true;
            // 
            // gbxQuestion5
            // 
            this.gbxQuestion5.Controls.Add(this.rdo_q5_opt1);
            this.gbxQuestion5.Controls.Add(this.rdo_q5_opt4);
            this.gbxQuestion5.Controls.Add(this.rdo_q5_opt3);
            this.gbxQuestion5.Controls.Add(this.rdo_q5_opt2);
            this.gbxQuestion5.Location = new System.Drawing.Point(454, 350);
            this.gbxQuestion5.Name = "gbxQuestion5";
            this.gbxQuestion5.Size = new System.Drawing.Size(268, 141);
            this.gbxQuestion5.TabIndex = 5;
            this.gbxQuestion5.TabStop = false;
            this.gbxQuestion5.Text = "Question 5";
            // 
            // rdo_q5_opt1
            // 
            this.rdo_q5_opt1.AutoSize = true;
            this.rdo_q5_opt1.Location = new System.Drawing.Point(84, 10);
            this.rdo_q5_opt1.Name = "rdo_q5_opt1";
            this.rdo_q5_opt1.Size = new System.Drawing.Size(91, 17);
            this.rdo_q5_opt1.TabIndex = 3;
            this.rdo_q5_opt1.TabStop = true;
            this.rdo_q5_opt1.Text = "radioButton21";
            this.rdo_q5_opt1.UseVisualStyleBackColor = true;
            // 
            // rdo_q5_opt4
            // 
            this.rdo_q5_opt4.AutoSize = true;
            this.rdo_q5_opt4.Location = new System.Drawing.Point(84, 109);
            this.rdo_q5_opt4.Name = "rdo_q5_opt4";
            this.rdo_q5_opt4.Size = new System.Drawing.Size(91, 17);
            this.rdo_q5_opt4.TabIndex = 2;
            this.rdo_q5_opt4.TabStop = true;
            this.rdo_q5_opt4.Text = "radioButton22";
            this.rdo_q5_opt4.UseVisualStyleBackColor = true;
            // 
            // rdo_q5_opt3
            // 
            this.rdo_q5_opt3.AutoSize = true;
            this.rdo_q5_opt3.Location = new System.Drawing.Point(84, 77);
            this.rdo_q5_opt3.Name = "rdo_q5_opt3";
            this.rdo_q5_opt3.Size = new System.Drawing.Size(91, 17);
            this.rdo_q5_opt3.TabIndex = 1;
            this.rdo_q5_opt3.TabStop = true;
            this.rdo_q5_opt3.Text = "radioButton23";
            this.rdo_q5_opt3.UseVisualStyleBackColor = true;
            // 
            // rdo_q5_opt2
            // 
            this.rdo_q5_opt2.AutoSize = true;
            this.rdo_q5_opt2.Location = new System.Drawing.Point(84, 44);
            this.rdo_q5_opt2.Name = "rdo_q5_opt2";
            this.rdo_q5_opt2.Size = new System.Drawing.Size(91, 17);
            this.rdo_q5_opt2.TabIndex = 0;
            this.rdo_q5_opt2.TabStop = true;
            this.rdo_q5_opt2.Text = "radioButton24";
            this.rdo_q5_opt2.UseVisualStyleBackColor = true;
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
            this.pnlUI.ResumeLayout(false);
            this.pnlUI.PerformLayout();
            this.gbxQuizGender.ResumeLayout(false);
            this.gbxQuizGender.PerformLayout();
            this.gbxQuestion2.ResumeLayout(false);
            this.gbxQuestion2.PerformLayout();
            this.gbxQuestion4.ResumeLayout(false);
            this.gbxQuestion4.PerformLayout();
            this.gbxQuestion6.ResumeLayout(false);
            this.gbxQuestion6.PerformLayout();
            this.gbxQuestion1.ResumeLayout(false);
            this.gbxQuestion1.PerformLayout();
            this.gbxQuestion3.ResumeLayout(false);
            this.gbxQuestion3.PerformLayout();
            this.gbxQuestion5.ResumeLayout(false);
            this.gbxQuestion5.PerformLayout();
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
        private System.Windows.Forms.Panel pnlUI;
        private System.Windows.Forms.GroupBox gbxQuestion5;
        private System.Windows.Forms.RadioButton rdo_q5_opt1;
        private System.Windows.Forms.RadioButton rdo_q5_opt4;
        private System.Windows.Forms.RadioButton rdo_q5_opt3;
        private System.Windows.Forms.RadioButton rdo_q5_opt2;
        private System.Windows.Forms.GroupBox gbxQuestion3;
        private System.Windows.Forms.RadioButton rdo_q3_opt1;
        private System.Windows.Forms.RadioButton rdo_q3_opt4;
        private System.Windows.Forms.RadioButton rdo_q3_opt3;
        private System.Windows.Forms.RadioButton rdo_q3_opt2;
        private System.Windows.Forms.GroupBox gbxQuestion1;
        private System.Windows.Forms.RadioButton rdo_q1_opt1;
        private System.Windows.Forms.RadioButton rdo_q1_opt4;
        private System.Windows.Forms.RadioButton rdo_q1_opt3;
        private System.Windows.Forms.RadioButton rdo_q1_opt2;
        private System.Windows.Forms.GroupBox gbxQuestion6;
        private System.Windows.Forms.RadioButton rdo_q6_opt1;
        private System.Windows.Forms.RadioButton rdo_q6_opt4;
        private System.Windows.Forms.RadioButton rdo_q6_opt3;
        private System.Windows.Forms.RadioButton rdo_q6_opt2;
        private System.Windows.Forms.GroupBox gbxQuestion4;
        private System.Windows.Forms.RadioButton rdo_q4_opt1;
        private System.Windows.Forms.RadioButton rdo_q4_opt4;
        private System.Windows.Forms.RadioButton rdo_q4_opt3;
        private System.Windows.Forms.RadioButton rdo_q4_opt2;
        private System.Windows.Forms.GroupBox gbxQuestion2;
        private System.Windows.Forms.RadioButton rdo_q2_opt1;
        private System.Windows.Forms.RadioButton rdo_q2_opt4;
        private System.Windows.Forms.RadioButton rdo_q2_opt3;
        private System.Windows.Forms.RadioButton rdo_q2_opt2;
        private System.Windows.Forms.GroupBox gbxQuizGender;
        private System.Windows.Forms.RadioButton rboGender_Female;
        private System.Windows.Forms.RadioButton rboGender_Male;
        private System.Windows.Forms.TextBox txtWizardName;
        private System.Windows.Forms.Button btnQuizSubmit;
    }
}

