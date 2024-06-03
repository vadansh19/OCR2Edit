using System.Windows.Forms;

namespace LetsTextify
{
    partial class FrmTeching
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
            this.pnlTeaching = new System.Windows.Forms.Panel();
            this.Panel141 = new System.Windows.Forms.Panel();
            this.pnl_cam_1_create_receipe = new System.Windows.Forms.PictureBox();
            this.btnZoomPlus = new System.Windows.Forms.Button();
            this.btnZoomMinus = new System.Windows.Forms.Button();
            this.trkZoomLevel = new System.Windows.Forms.TrackBar();
            this.btnStartPreview = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.grp_preprocessing_OCR_CR_OP = new System.Windows.Forms.GroupBox();
            this.txtResultPostProcessed = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveRecipeTeach = new System.Windows.Forms.Button();
            this.cmbScaleFactor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbOEMValue = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPsmValue = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetData = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbThreshMethod = new System.Windows.Forms.ComboBox();
            this.cmbSmooth = new System.Windows.Forms.ComboBox();
            this.cmbDilate = new System.Windows.Forms.ComboBox();
            this.cmbErode = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cmbDataTypes = new System.Windows.Forms.ComboBox();
            this.txtCharMaxHeight = new System.Windows.Forms.TextBox();
            this.cmbTrainFile = new System.Windows.Forms.ComboBox();
            this.txtCharMaxWidth = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txtCharMinHeight = new System.Windows.Forms.TextBox();
            this.chkWhiteOnBlack = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtCharMinWidth = new System.Windows.Forms.TextBox();
            this.lblCapControlMax = new System.Windows.Forms.Label();
            this.txtThreshMax = new System.Windows.Forms.TextBox();
            this.lblCapControlMin = new System.Windows.Forms.Label();
            this.txtThreshMin = new System.Windows.Forms.TextBox();
            this.lblThreshholdMethod = new System.Windows.Forms.Label();
            this.lblSmooth = new System.Windows.Forms.Label();
            this.lblDilate = new System.Windows.Forms.Label();
            this.lblErode = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.Label174 = new System.Windows.Forms.Label();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.tmr_offline_Capture = new System.Windows.Forms.Timer(this.components);
            this.pnlRecipe = new System.Windows.Forms.Panel();
            this.pnlRecipeNamePopUp = new System.Windows.Forms.Panel();
            this.btnCancelRecipeCreate = new System.Windows.Forms.Button();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.btnCreateRecipe = new System.Windows.Forms.Button();
            this.dgvRecipeList = new System.Windows.Forms.DataGridView();
            this.dgvRecipeListSrNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRecipeListRecipeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRecipeListLastModifiedOn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Create = new System.Windows.Forms.Button();
            this.pnlPreview = new System.Windows.Forms.Panel();
            this.IsSavePostProcessedData = new System.Windows.Forms.CheckBox();
            this.txtPostProcessPreview = new System.Windows.Forms.TextBox();
            this.btnCompareOCR = new System.Windows.Forms.Button();
            this.txtPreviewResult = new System.Windows.Forms.TextBox();
            this.btnStopPreview = new System.Windows.Forms.Button();
            this.pbPreviewImage = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlCompareOCR = new System.Windows.Forms.Panel();
            this.closeCompareOCR = new System.Windows.Forms.Button();
            this.PreprocessedImgText = new System.Windows.Forms.TextBox();
            this.OriginalImgText = new System.Windows.Forms.TextBox();
            this.PreprocessedImg = new System.Windows.Forms.Label();
            this.OriginalImage = new System.Windows.Forms.Label();
            this.PreProcessedImage = new System.Windows.Forms.PictureBox();
            this.OriginalPicture = new System.Windows.Forms.PictureBox();
            this.pnlTeaching.SuspendLayout();
            this.Panel141.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnl_cam_1_create_receipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkZoomLevel)).BeginInit();
            this.grp_preprocessing_OCR_CR_OP.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlRecipe.SuspendLayout();
            this.pnlRecipeNamePopUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeList)).BeginInit();
            this.pnlPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewImage)).BeginInit();
            this.pnlCompareOCR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreProcessedImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTeaching
            // 
            this.pnlTeaching.Controls.Add(this.Panel141);
            this.pnlTeaching.Controls.Add(this.btnZoomPlus);
            this.pnlTeaching.Controls.Add(this.btnZoomMinus);
            this.pnlTeaching.Controls.Add(this.trkZoomLevel);
            this.pnlTeaching.Controls.Add(this.btnStartPreview);
            this.pnlTeaching.Controls.Add(this.label7);
            this.pnlTeaching.Controls.Add(this.grp_preprocessing_OCR_CR_OP);
            this.pnlTeaching.Location = new System.Drawing.Point(0, 0);
            this.pnlTeaching.Name = "pnlTeaching";
            this.pnlTeaching.Size = new System.Drawing.Size(1157, 640);
            this.pnlTeaching.TabIndex = 0;
            this.pnlTeaching.Visible = false;
            // 
            // Panel141
            // 
            this.Panel141.AutoScroll = true;
            this.Panel141.BackColor = System.Drawing.Color.White;
            this.Panel141.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Panel141.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel141.Controls.Add(this.pnl_cam_1_create_receipe);
            this.Panel141.Location = new System.Drawing.Point(8, 5);
            this.Panel141.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Panel141.Name = "Panel141";
            this.Panel141.Size = new System.Drawing.Size(783, 480);
            this.Panel141.TabIndex = 236;
            // 
            // pnl_cam_1_create_receipe
            // 
            this.pnl_cam_1_create_receipe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_cam_1_create_receipe.Location = new System.Drawing.Point(-5, 2);
            this.pnl_cam_1_create_receipe.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pnl_cam_1_create_receipe.Name = "pnl_cam_1_create_receipe";
            this.pnl_cam_1_create_receipe.Size = new System.Drawing.Size(782, 471);
            this.pnl_cam_1_create_receipe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pnl_cam_1_create_receipe.TabIndex = 81;
            this.pnl_cam_1_create_receipe.TabStop = false;
            this.pnl_cam_1_create_receipe.WaitOnLoad = true;
            this.pnl_cam_1_create_receipe.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_cam_1_create_receipe_Paint);
            this.pnl_cam_1_create_receipe.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pnl_cam_1_create_receipe_MouseClick);
            this.pnl_cam_1_create_receipe.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_cam_1_create_receipe_MouseDown);
            this.pnl_cam_1_create_receipe.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnl_cam_1_create_receipe_MouseMove);
            this.pnl_cam_1_create_receipe.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_cam_1_create_receipe_MouseUp);
            // 
            // btnZoomPlus
            // 
            this.btnZoomPlus.AutoSize = true;
            this.btnZoomPlus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnZoomPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnZoomPlus.ForeColor = System.Drawing.Color.White;
            this.btnZoomPlus.Location = new System.Drawing.Point(497, 533);
            this.btnZoomPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoomPlus.Name = "btnZoomPlus";
            this.btnZoomPlus.Size = new System.Drawing.Size(32, 28);
            this.btnZoomPlus.TabIndex = 241;
            this.btnZoomPlus.Text = "+";
            this.btnZoomPlus.UseVisualStyleBackColor = false;
            this.btnZoomPlus.Click += new System.EventHandler(this.btnZoomPlus_Click);
            // 
            // btnZoomMinus
            // 
            this.btnZoomMinus.AutoSize = true;
            this.btnZoomMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnZoomMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnZoomMinus.ForeColor = System.Drawing.Color.White;
            this.btnZoomMinus.Location = new System.Drawing.Point(152, 533);
            this.btnZoomMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnZoomMinus.Name = "btnZoomMinus";
            this.btnZoomMinus.Size = new System.Drawing.Size(40, 28);
            this.btnZoomMinus.TabIndex = 240;
            this.btnZoomMinus.Text = "-";
            this.btnZoomMinus.UseVisualStyleBackColor = false;
            this.btnZoomMinus.Click += new System.EventHandler(this.btnZoomMinus_Click);
            // 
            // trkZoomLevel
            // 
            this.trkZoomLevel.AutoSize = false;
            this.trkZoomLevel.BackColor = System.Drawing.Color.DarkGray;
            this.trkZoomLevel.LargeChange = 2;
            this.trkZoomLevel.Location = new System.Drawing.Point(200, 532);
            this.trkZoomLevel.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.trkZoomLevel.Maximum = 30;
            this.trkZoomLevel.Name = "trkZoomLevel";
            this.trkZoomLevel.Size = new System.Drawing.Size(283, 28);
            this.trkZoomLevel.TabIndex = 238;
            this.trkZoomLevel.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkZoomLevel.Scroll += new System.EventHandler(this.trkZoomLevel_Scroll);
            // 
            // btnStartPreview
            // 
            this.btnStartPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnStartPreview.Enabled = false;
            this.btnStartPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartPreview.ForeColor = System.Drawing.Color.White;
            this.btnStartPreview.Location = new System.Drawing.Point(645, 586);
            this.btnStartPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartPreview.Name = "btnStartPreview";
            this.btnStartPreview.Size = new System.Drawing.Size(140, 38);
            this.btnStartPreview.TabIndex = 243;
            this.btnStartPreview.Text = "Start Preview";
            this.btnStartPreview.UseVisualStyleBackColor = false;
            this.btnStartPreview.Click += new System.EventHandler(this.btnStartPreview_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.label7.Location = new System.Drawing.Point(20, 540);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 239;
            this.label7.Text = "Zoom Level";
            // 
            // grp_preprocessing_OCR_CR_OP
            // 
            this.grp_preprocessing_OCR_CR_OP.Controls.Add(this.txtResult);
            this.grp_preprocessing_OCR_CR_OP.Controls.Add(this.groupBox1);
            this.grp_preprocessing_OCR_CR_OP.Controls.Add(this.txtResultPostProcessed);
            this.grp_preprocessing_OCR_CR_OP.Location = new System.Drawing.Point(797, 9);
            this.grp_preprocessing_OCR_CR_OP.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grp_preprocessing_OCR_CR_OP.Name = "grp_preprocessing_OCR_CR_OP";
            this.grp_preprocessing_OCR_CR_OP.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.grp_preprocessing_OCR_CR_OP.Size = new System.Drawing.Size(352, 623);
            this.grp_preprocessing_OCR_CR_OP.TabIndex = 237;
            this.grp_preprocessing_OCR_CR_OP.TabStop = false;
            this.grp_preprocessing_OCR_CR_OP.Text = "OCR";
            // 
            // txtResultPostProcessed
            // 
            this.txtResultPostProcessed.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtResultPostProcessed.Location = new System.Drawing.Point(11, 102);
            this.txtResultPostProcessed.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtResultPostProcessed.Multiline = true;
            this.txtResultPostProcessed.Name = "txtResultPostProcessed";
            this.txtResultPostProcessed.ReadOnly = true;
            this.txtResultPostProcessed.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultPostProcessed.Size = new System.Drawing.Size(319, 82);
            this.txtResultPostProcessed.TabIndex = 109;
            this.txtResultPostProcessed.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveRecipeTeach);
            this.groupBox1.Controls.Add(this.cmbScaleFactor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbOEMValue);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbPsmValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnGetData);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbThreshMethod);
            this.groupBox1.Controls.Add(this.cmbSmooth);
            this.groupBox1.Controls.Add(this.cmbDilate);
            this.groupBox1.Controls.Add(this.cmbErode);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.cmbDataTypes);
            this.groupBox1.Controls.Add(this.txtCharMaxHeight);
            this.groupBox1.Controls.Add(this.cmbTrainFile);
            this.groupBox1.Controls.Add(this.txtCharMaxWidth);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.txtCharMinHeight);
            this.groupBox1.Controls.Add(this.chkWhiteOnBlack);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.txtCharMinWidth);
            this.groupBox1.Controls.Add(this.lblCapControlMax);
            this.groupBox1.Controls.Add(this.txtThreshMax);
            this.groupBox1.Controls.Add(this.lblCapControlMin);
            this.groupBox1.Controls.Add(this.txtThreshMin);
            this.groupBox1.Controls.Add(this.lblThreshholdMethod);
            this.groupBox1.Controls.Add(this.lblSmooth);
            this.groupBox1.Controls.Add(this.lblDilate);
            this.groupBox1.Controls.Add(this.lblErode);
            this.groupBox1.Controls.Add(this.label27);
            this.groupBox1.Controls.Add(this.Label174);
            this.groupBox1.Location = new System.Drawing.Point(11, 175);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.groupBox1.Size = new System.Drawing.Size(332, 441);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "Setup Param";
            // 
            // btnSaveRecipeTeach
            // 
            this.btnSaveRecipeTeach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnSaveRecipeTeach.Enabled = false;
            this.btnSaveRecipeTeach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveRecipeTeach.ForeColor = System.Drawing.Color.White;
            this.btnSaveRecipeTeach.Location = new System.Drawing.Point(176, 391);
            this.btnSaveRecipeTeach.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveRecipeTeach.Name = "btnSaveRecipeTeach";
            this.btnSaveRecipeTeach.Size = new System.Drawing.Size(141, 37);
            this.btnSaveRecipeTeach.TabIndex = 234;
            this.btnSaveRecipeTeach.Text = "Save Recipe";
            this.btnSaveRecipeTeach.UseVisualStyleBackColor = false;
            this.btnSaveRecipeTeach.Click += new System.EventHandler(this.btnSaveRecipeTeach_Click);
            // 
            // cmbScaleFactor
            // 
            this.cmbScaleFactor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbScaleFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbScaleFactor.FormattingEnabled = true;
            this.cmbScaleFactor.Items.AddRange(new object[] {
            "-2",
            "-1",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.cmbScaleFactor.Location = new System.Drawing.Point(163, 121);
            this.cmbScaleFactor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbScaleFactor.Name = "cmbScaleFactor";
            this.cmbScaleFactor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbScaleFactor.Size = new System.Drawing.Size(153, 24);
            this.cmbScaleFactor.TabIndex = 233;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.label4.Location = new System.Drawing.Point(29, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 232;
            this.label4.Text = "ScaleFactor";
            // 
            // cmbOEMValue
            // 
            this.cmbOEMValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOEMValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbOEMValue.FormattingEnabled = true;
            this.cmbOEMValue.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbOEMValue.Location = new System.Drawing.Point(163, 95);
            this.cmbOEMValue.Margin = new System.Windows.Forms.Padding(4);
            this.cmbOEMValue.Name = "cmbOEMValue";
            this.cmbOEMValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbOEMValue.Size = new System.Drawing.Size(153, 24);
            this.cmbOEMValue.TabIndex = 231;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.label3.Location = new System.Drawing.Point(28, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 230;
            this.label3.Text = "OEM Value";
            // 
            // cmbPsmValue
            // 
            this.cmbPsmValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPsmValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbPsmValue.FormattingEnabled = true;
            this.cmbPsmValue.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13"});
            this.cmbPsmValue.Location = new System.Drawing.Point(163, 68);
            this.cmbPsmValue.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPsmValue.Name = "cmbPsmValue";
            this.cmbPsmValue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbPsmValue.Size = new System.Drawing.Size(153, 24);
            this.cmbPsmValue.TabIndex = 229;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.label2.Location = new System.Drawing.Point(28, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 228;
            this.label2.Text = "PSM Value";
            // 
            // btnGetData
            // 
            this.btnGetData.AutoSize = true;
            this.btnGetData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnGetData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnGetData.ForeColor = System.Drawing.Color.White;
            this.btnGetData.Location = new System.Drawing.Point(28, 391);
            this.btnGetData.Margin = new System.Windows.Forms.Padding(4);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(141, 37);
            this.btnGetData.TabIndex = 227;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = false;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.label1.Location = new System.Drawing.Point(27, 274);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 226;
            this.label1.Text = "Threshhold";
            // 
            // cmbThreshMethod
            // 
            this.cmbThreshMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbThreshMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbThreshMethod.FormattingEnabled = true;
            this.cmbThreshMethod.Items.AddRange(new object[] {
            "Binary",
            "Block"});
            this.cmbThreshMethod.Location = new System.Drawing.Point(163, 229);
            this.cmbThreshMethod.Margin = new System.Windows.Forms.Padding(4);
            this.cmbThreshMethod.Name = "cmbThreshMethod";
            this.cmbThreshMethod.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbThreshMethod.Size = new System.Drawing.Size(153, 24);
            this.cmbThreshMethod.TabIndex = 225;
            // 
            // cmbSmooth
            // 
            this.cmbSmooth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSmooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbSmooth.FormattingEnabled = true;
            this.cmbSmooth.Items.AddRange(new object[] {
            "0",
            "1",
            "3",
            "5",
            "7",
            "9"});
            this.cmbSmooth.Location = new System.Drawing.Point(163, 202);
            this.cmbSmooth.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSmooth.Name = "cmbSmooth";
            this.cmbSmooth.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbSmooth.Size = new System.Drawing.Size(153, 24);
            this.cmbSmooth.TabIndex = 224;
            // 
            // cmbDilate
            // 
            this.cmbDilate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDilate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbDilate.FormattingEnabled = true;
            this.cmbDilate.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbDilate.Location = new System.Drawing.Point(163, 175);
            this.cmbDilate.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDilate.Name = "cmbDilate";
            this.cmbDilate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbDilate.Size = new System.Drawing.Size(153, 24);
            this.cmbDilate.TabIndex = 223;
            // 
            // cmbErode
            // 
            this.cmbErode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbErode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbErode.FormattingEnabled = true;
            this.cmbErode.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbErode.Location = new System.Drawing.Point(163, 148);
            this.cmbErode.Margin = new System.Windows.Forms.Padding(4);
            this.cmbErode.Name = "cmbErode";
            this.cmbErode.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbErode.Size = new System.Drawing.Size(153, 24);
            this.cmbErode.TabIndex = 212;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.label26.Location = new System.Drawing.Point(28, 341);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(95, 17);
            this.label26.TabIndex = 221;
            this.label26.Text = "CharacterMax";
            // 
            // cmbDataTypes
            // 
            this.cmbDataTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbDataTypes.FormattingEnabled = true;
            this.cmbDataTypes.Items.AddRange(new object[] {
            "Int",
            "UInt",
            "Float",
            "UFloat",
            "Capital-Letters",
            "Small-Letters",
            "Capital-Small-Letters",
            "Special-Chars",
            "ASCII",
            "Custom"});
            this.cmbDataTypes.Location = new System.Drawing.Point(163, 41);
            this.cmbDataTypes.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDataTypes.Name = "cmbDataTypes";
            this.cmbDataTypes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbDataTypes.Size = new System.Drawing.Size(153, 24);
            this.cmbDataTypes.TabIndex = 211;
            // 
            // txtCharMaxHeight
            // 
            this.txtCharMaxHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtCharMaxHeight.Location = new System.Drawing.Point(267, 343);
            this.txtCharMaxHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtCharMaxHeight.MaxLength = 3;
            this.txtCharMaxHeight.Name = "txtCharMaxHeight";
            this.txtCharMaxHeight.Size = new System.Drawing.Size(44, 23);
            this.txtCharMaxHeight.TabIndex = 220;
            // 
            // cmbTrainFile
            // 
            this.cmbTrainFile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrainFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cmbTrainFile.FormattingEnabled = true;
            this.cmbTrainFile.Location = new System.Drawing.Point(163, 14);
            this.cmbTrainFile.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTrainFile.Name = "cmbTrainFile";
            this.cmbTrainFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbTrainFile.Size = new System.Drawing.Size(153, 24);
            this.cmbTrainFile.TabIndex = 210;
            // 
            // txtCharMaxWidth
            // 
            this.txtCharMaxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtCharMaxWidth.Location = new System.Drawing.Point(195, 343);
            this.txtCharMaxWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtCharMaxWidth.MaxLength = 3;
            this.txtCharMaxWidth.Name = "txtCharMaxWidth";
            this.txtCharMaxWidth.Size = new System.Drawing.Size(44, 23);
            this.txtCharMaxWidth.TabIndex = 219;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label25.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.label25.Location = new System.Drawing.Point(29, 318);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(92, 17);
            this.label25.TabIndex = 218;
            this.label25.Text = "CharacterMin";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.White;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label23.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.label23.Location = new System.Drawing.Point(265, 300);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 17);
            this.label23.TabIndex = 217;
            this.label23.Text = "Height";
            // 
            // txtCharMinHeight
            // 
            this.txtCharMinHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtCharMinHeight.Location = new System.Drawing.Point(267, 318);
            this.txtCharMinHeight.Margin = new System.Windows.Forms.Padding(4);
            this.txtCharMinHeight.MaxLength = 3;
            this.txtCharMinHeight.Name = "txtCharMinHeight";
            this.txtCharMinHeight.Size = new System.Drawing.Size(44, 23);
            this.txtCharMinHeight.TabIndex = 216;
            // 
            // chkWhiteOnBlack
            // 
            this.chkWhiteOnBlack.AutoSize = true;
            this.chkWhiteOnBlack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.chkWhiteOnBlack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.chkWhiteOnBlack.Location = new System.Drawing.Point(33, 362);
            this.chkWhiteOnBlack.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.chkWhiteOnBlack.Name = "chkWhiteOnBlack";
            this.chkWhiteOnBlack.Size = new System.Drawing.Size(150, 24);
            this.chkWhiteOnBlack.TabIndex = 222;
            this.chkWhiteOnBlack.Text = "WhiteOnBlack";
            this.chkWhiteOnBlack.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.White;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.label24.Location = new System.Drawing.Point(195, 300);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(44, 17);
            this.label24.TabIndex = 215;
            this.label24.Text = "Width";
            // 
            // txtCharMinWidth
            // 
            this.txtCharMinWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtCharMinWidth.Location = new System.Drawing.Point(195, 318);
            this.txtCharMinWidth.Margin = new System.Windows.Forms.Padding(4);
            this.txtCharMinWidth.MaxLength = 3;
            this.txtCharMinWidth.Name = "txtCharMinWidth";
            this.txtCharMinWidth.Size = new System.Drawing.Size(44, 23);
            this.txtCharMinWidth.TabIndex = 214;
            // 
            // lblCapControlMax
            // 
            this.lblCapControlMax.AutoSize = true;
            this.lblCapControlMax.BackColor = System.Drawing.Color.Transparent;
            this.lblCapControlMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblCapControlMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.lblCapControlMax.Location = new System.Drawing.Point(269, 256);
            this.lblCapControlMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapControlMax.Name = "lblCapControlMax";
            this.lblCapControlMax.Size = new System.Drawing.Size(33, 17);
            this.lblCapControlMax.TabIndex = 213;
            this.lblCapControlMax.Text = "Max";
            // 
            // txtThreshMax
            // 
            this.txtThreshMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtThreshMax.Location = new System.Drawing.Point(263, 274);
            this.txtThreshMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtThreshMax.MaxLength = 3;
            this.txtThreshMax.Name = "txtThreshMax";
            this.txtThreshMax.Size = new System.Drawing.Size(44, 23);
            this.txtThreshMax.TabIndex = 212;
            // 
            // lblCapControlMin
            // 
            this.lblCapControlMin.AutoSize = true;
            this.lblCapControlMin.BackColor = System.Drawing.Color.Transparent;
            this.lblCapControlMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblCapControlMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.lblCapControlMin.Location = new System.Drawing.Point(195, 256);
            this.lblCapControlMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapControlMin.Name = "lblCapControlMin";
            this.lblCapControlMin.Size = new System.Drawing.Size(30, 17);
            this.lblCapControlMin.TabIndex = 211;
            this.lblCapControlMin.Text = "Min";
            // 
            // txtThreshMin
            // 
            this.txtThreshMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtThreshMin.Location = new System.Drawing.Point(192, 274);
            this.txtThreshMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtThreshMin.MaxLength = 3;
            this.txtThreshMin.Name = "txtThreshMin";
            this.txtThreshMin.Size = new System.Drawing.Size(44, 23);
            this.txtThreshMin.TabIndex = 210;
            // 
            // lblThreshholdMethod
            // 
            this.lblThreshholdMethod.AutoSize = true;
            this.lblThreshholdMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblThreshholdMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblThreshholdMethod.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.lblThreshholdMethod.Location = new System.Drawing.Point(29, 231);
            this.lblThreshholdMethod.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThreshholdMethod.Name = "lblThreshholdMethod";
            this.lblThreshholdMethod.Size = new System.Drawing.Size(131, 17);
            this.lblThreshholdMethod.TabIndex = 205;
            this.lblThreshholdMethod.Text = "Threshhold Method";
            // 
            // lblSmooth
            // 
            this.lblSmooth.AutoSize = true;
            this.lblSmooth.BackColor = System.Drawing.Color.Transparent;
            this.lblSmooth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblSmooth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.lblSmooth.Location = new System.Drawing.Point(29, 204);
            this.lblSmooth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSmooth.Name = "lblSmooth";
            this.lblSmooth.Size = new System.Drawing.Size(56, 17);
            this.lblSmooth.TabIndex = 204;
            this.lblSmooth.Text = "Smooth";
            // 
            // lblDilate
            // 
            this.lblDilate.AutoSize = true;
            this.lblDilate.BackColor = System.Drawing.Color.Transparent;
            this.lblDilate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDilate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.lblDilate.Location = new System.Drawing.Point(29, 178);
            this.lblDilate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDilate.Name = "lblDilate";
            this.lblDilate.Size = new System.Drawing.Size(44, 17);
            this.lblDilate.TabIndex = 203;
            this.lblDilate.Text = "Dilate";
            // 
            // lblErode
            // 
            this.lblErode.AutoSize = true;
            this.lblErode.BackColor = System.Drawing.Color.Transparent;
            this.lblErode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblErode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.lblErode.Location = new System.Drawing.Point(29, 151);
            this.lblErode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblErode.Name = "lblErode";
            this.lblErode.Size = new System.Drawing.Size(46, 17);
            this.lblErode.TabIndex = 202;
            this.lblErode.Text = "Erode";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.label27.Location = new System.Drawing.Point(29, 16);
            this.label27.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(67, 17);
            this.label27.TabIndex = 197;
            this.label27.Text = "Train File";
            // 
            // Label174
            // 
            this.Label174.AutoSize = true;
            this.Label174.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Label174.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.Label174.Location = new System.Drawing.Point(28, 42);
            this.Label174.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Label174.Name = "Label174";
            this.Label174.Size = new System.Drawing.Size(72, 17);
            this.Label174.TabIndex = 128;
            this.Label174.Text = "Datatypes";
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtResult.Location = new System.Drawing.Point(11, 16);
            this.txtResult.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResult.Size = new System.Drawing.Size(319, 168);
            this.txtResult.TabIndex = 108;
            // 
            // tmr_offline_Capture
            // 
            this.tmr_offline_Capture.Interval = 1000;
            this.tmr_offline_Capture.Tick += new System.EventHandler(this.tmr_offline_Capture_Tick);
            // 
            // pnlRecipe
            // 
            this.pnlRecipe.Controls.Add(this.pnlRecipeNamePopUp);
            this.pnlRecipe.Controls.Add(this.dgvRecipeList);
            this.pnlRecipe.Controls.Add(this.Delete);
            this.pnlRecipe.Controls.Add(this.Edit);
            this.pnlRecipe.Controls.Add(this.Create);
            this.pnlRecipe.Location = new System.Drawing.Point(0, 0);
            this.pnlRecipe.Name = "pnlRecipe";
            this.pnlRecipe.Size = new System.Drawing.Size(1149, 640);
            this.pnlRecipe.TabIndex = 235;
            // 
            // pnlRecipeNamePopUp
            // 
            this.pnlRecipeNamePopUp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRecipeNamePopUp.Controls.Add(this.btnCancelRecipeCreate);
            this.pnlRecipeNamePopUp.Controls.Add(this.lblRecipeName);
            this.pnlRecipeNamePopUp.Controls.Add(this.txtRecipeName);
            this.pnlRecipeNamePopUp.Controls.Add(this.btnCreateRecipe);
            this.pnlRecipeNamePopUp.Location = new System.Drawing.Point(284, 183);
            this.pnlRecipeNamePopUp.Name = "pnlRecipeNamePopUp";
            this.pnlRecipeNamePopUp.Size = new System.Drawing.Size(408, 201);
            this.pnlRecipeNamePopUp.TabIndex = 10;
            this.pnlRecipeNamePopUp.Visible = false;
            // 
            // btnCancelRecipeCreate
            // 
            this.btnCancelRecipeCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnCancelRecipeCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelRecipeCreate.ForeColor = System.Drawing.Color.White;
            this.btnCancelRecipeCreate.Location = new System.Drawing.Point(217, 127);
            this.btnCancelRecipeCreate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelRecipeCreate.Name = "btnCancelRecipeCreate";
            this.btnCancelRecipeCreate.Size = new System.Drawing.Size(122, 42);
            this.btnCancelRecipeCreate.TabIndex = 15;
            this.btnCancelRecipeCreate.Text = "Cancel";
            this.btnCancelRecipeCreate.UseVisualStyleBackColor = false;
            this.btnCancelRecipeCreate.Click += new System.EventHandler(this.btnCancelRecipeCreate_Click);
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecipeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.lblRecipeName.Location = new System.Drawing.Point(20, 54);
            this.lblRecipeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(121, 20);
            this.lblRecipeName.TabIndex = 14;
            this.lblRecipeName.Text = "Recipe Name";
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(181, 52);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(194, 22);
            this.txtRecipeName.TabIndex = 13;
            this.txtRecipeName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRecipeName_KeyDown);
            // 
            // btnCreateRecipe
            // 
            this.btnCreateRecipe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnCreateRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateRecipe.ForeColor = System.Drawing.Color.White;
            this.btnCreateRecipe.Location = new System.Drawing.Point(76, 126);
            this.btnCreateRecipe.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateRecipe.Name = "btnCreateRecipe";
            this.btnCreateRecipe.Size = new System.Drawing.Size(122, 42);
            this.btnCreateRecipe.TabIndex = 11;
            this.btnCreateRecipe.Text = "Create";
            this.btnCreateRecipe.UseVisualStyleBackColor = false;
            this.btnCreateRecipe.Click += new System.EventHandler(this.btnCreateRecipe_Click);
            // 
            // dgvRecipeList
            // 
            this.dgvRecipeList.AllowUserToAddRows = false;
            this.dgvRecipeList.AllowUserToDeleteRows = false;
            this.dgvRecipeList.AllowUserToResizeColumns = false;
            this.dgvRecipeList.AllowUserToResizeRows = false;
            this.dgvRecipeList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecipeList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvRecipeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecipeList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvRecipeListSrNo,
            this.dgvRecipeListRecipeName,
            this.dgvRecipeListLastModifiedOn});
            this.dgvRecipeList.Location = new System.Drawing.Point(20, 59);
            this.dgvRecipeList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRecipeList.MultiSelect = false;
            this.dgvRecipeList.Name = "dgvRecipeList";
            this.dgvRecipeList.RowHeadersWidth = 51;
            this.dgvRecipeList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvRecipeList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRecipeList.Size = new System.Drawing.Size(884, 526);
            this.dgvRecipeList.TabIndex = 5;
            // 
            // dgvRecipeListSrNo
            // 
            this.dgvRecipeListSrNo.HeaderText = "Serial Number";
            this.dgvRecipeListSrNo.MinimumWidth = 6;
            this.dgvRecipeListSrNo.Name = "dgvRecipeListSrNo";
            this.dgvRecipeListSrNo.ReadOnly = true;
            this.dgvRecipeListSrNo.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dgvRecipeListRecipeName
            // 
            this.dgvRecipeListRecipeName.HeaderText = "Recipe Name";
            this.dgvRecipeListRecipeName.MinimumWidth = 6;
            this.dgvRecipeListRecipeName.Name = "dgvRecipeListRecipeName";
            this.dgvRecipeListRecipeName.ReadOnly = true;
            this.dgvRecipeListRecipeName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecipeListRecipeName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvRecipeListLastModifiedOn
            // 
            this.dgvRecipeListLastModifiedOn.HeaderText = "Last Modified On";
            this.dgvRecipeListLastModifiedOn.MinimumWidth = 6;
            this.dgvRecipeListLastModifiedOn.Name = "dgvRecipeListLastModifiedOn";
            this.dgvRecipeListLastModifiedOn.ReadOnly = true;
            this.dgvRecipeListLastModifiedOn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRecipeListLastModifiedOn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(923, 320);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(187, 85);
            this.Delete.TabIndex = 8;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(921, 193);
            this.Edit.Margin = new System.Windows.Forms.Padding(4);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(187, 87);
            this.Edit.TabIndex = 7;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Create
            // 
            this.Create.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.Create.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Create.ForeColor = System.Drawing.Color.White;
            this.Create.Location = new System.Drawing.Point(923, 63);
            this.Create.Margin = new System.Windows.Forms.Padding(4);
            this.Create.Name = "Create";
            this.Create.Size = new System.Drawing.Size(187, 95);
            this.Create.TabIndex = 6;
            this.Create.Text = "Create";
            this.Create.UseVisualStyleBackColor = false;
            this.Create.Click += new System.EventHandler(this.Create_Click);
            // 
            // pnlPreview
            // 
            this.pnlPreview.Controls.Add(this.IsSavePostProcessedData);
            this.pnlPreview.Controls.Add(this.btnCompareOCR);
            this.pnlPreview.Controls.Add(this.txtPreviewResult);
            this.pnlPreview.Controls.Add(this.btnStopPreview);
            this.pnlPreview.Controls.Add(this.pbPreviewImage);
            this.pnlPreview.Controls.Add(this.txtPostProcessPreview);
            this.pnlPreview.Location = new System.Drawing.Point(0, 0);
            this.pnlPreview.Name = "pnlPreview";
            this.pnlPreview.Size = new System.Drawing.Size(1157, 640);
            this.pnlPreview.TabIndex = 236;
            this.pnlPreview.Visible = false;
            // 
            // IsSavePostProcessedData
            // 
            this.IsSavePostProcessedData.AutoSize = true;
            this.IsSavePostProcessedData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.IsSavePostProcessedData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.IsSavePostProcessedData.Location = new System.Drawing.Point(576, 594);
            this.IsSavePostProcessedData.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.IsSavePostProcessedData.Name = "IsSavePostProcessedData";
            this.IsSavePostProcessedData.Size = new System.Drawing.Size(239, 24);
            this.IsSavePostProcessedData.TabIndex = 245;
            this.IsSavePostProcessedData.Text = "SavePostProcessedData";
            this.IsSavePostProcessedData.UseVisualStyleBackColor = true;
            this.IsSavePostProcessedData.Visible = false;
            // 
            // txtPostProcessPreview
            // 
            this.txtPostProcessPreview.Location = new System.Drawing.Point(872, 288);
            this.txtPostProcessPreview.Margin = new System.Windows.Forms.Padding(4);
            this.txtPostProcessPreview.Multiline = true;
            this.txtPostProcessPreview.Name = "txtPostProcessPreview";
            this.txtPostProcessPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPostProcessPreview.Size = new System.Drawing.Size(247, 162);
            this.txtPostProcessPreview.TabIndex = 244;
            this.txtPostProcessPreview.Visible = false;
            // 
            // btnCompareOCR
            // 
            this.btnCompareOCR.AutoSize = true;
            this.btnCompareOCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnCompareOCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnCompareOCR.ForeColor = System.Drawing.Color.White;
            this.btnCompareOCR.Location = new System.Drawing.Point(858, 476);
            this.btnCompareOCR.Margin = new System.Windows.Forms.Padding(4);
            this.btnCompareOCR.Name = "btnCompareOCR";
            this.btnCompareOCR.Size = new System.Drawing.Size(261, 45);
            this.btnCompareOCR.TabIndex = 243;
            this.btnCompareOCR.Text = "Compare OCR";
            this.btnCompareOCR.UseVisualStyleBackColor = false;
            this.btnCompareOCR.Click += new System.EventHandler(this.btnCompareOCR_Click);
            // 
            // txtPreviewResult
            // 
            this.txtPreviewResult.Location = new System.Drawing.Point(858, 59);
            this.txtPreviewResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreviewResult.Multiline = true;
            this.txtPreviewResult.Name = "txtPreviewResult";
            this.txtPreviewResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPreviewResult.Size = new System.Drawing.Size(261, 391);
            this.txtPreviewResult.TabIndex = 7;
            // 
            // btnStopPreview
            // 
            this.btnStopPreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.btnStopPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStopPreview.ForeColor = System.Drawing.Color.White;
            this.btnStopPreview.Location = new System.Drawing.Point(858, 536);
            this.btnStopPreview.Margin = new System.Windows.Forms.Padding(4);
            this.btnStopPreview.Name = "btnStopPreview";
            this.btnStopPreview.Size = new System.Drawing.Size(261, 49);
            this.btnStopPreview.TabIndex = 5;
            this.btnStopPreview.Text = "Stop Preview";
            this.btnStopPreview.UseVisualStyleBackColor = false;
            this.btnStopPreview.Click += new System.EventHandler(this.btnStopPreview_Click);
            // 
            // pbPreviewImage
            // 
            this.pbPreviewImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbPreviewImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreviewImage.Location = new System.Drawing.Point(38, 59);
            this.pbPreviewImage.Margin = new System.Windows.Forms.Padding(4);
            this.pbPreviewImage.Name = "pbPreviewImage";
            this.pbPreviewImage.Size = new System.Drawing.Size(794, 527);
            this.pbPreviewImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPreviewImage.TabIndex = 4;
            this.pbPreviewImage.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // pnlCompareOCR
            // 
            this.pnlCompareOCR.Controls.Add(this.OriginalPicture);
            this.pnlCompareOCR.Controls.Add(this.PreProcessedImage);
            this.pnlCompareOCR.Controls.Add(this.closeCompareOCR);
            this.pnlCompareOCR.Controls.Add(this.PreprocessedImgText);
            this.pnlCompareOCR.Controls.Add(this.OriginalImgText);
            this.pnlCompareOCR.Controls.Add(this.PreprocessedImg);
            this.pnlCompareOCR.Controls.Add(this.OriginalImage);
            this.pnlCompareOCR.Location = new System.Drawing.Point(0, 0);
            this.pnlCompareOCR.Name = "pnlCompareOCR";
            this.pnlCompareOCR.Size = new System.Drawing.Size(1157, 640);
            this.pnlCompareOCR.TabIndex = 237;
            this.pnlCompareOCR.Visible = false;
            // 
            // closeCompareOCR
            // 
            this.closeCompareOCR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.closeCompareOCR.ForeColor = System.Drawing.Color.White;
            this.closeCompareOCR.Location = new System.Drawing.Point(972, 574);
            this.closeCompareOCR.Margin = new System.Windows.Forms.Padding(4);
            this.closeCompareOCR.Name = "closeCompareOCR";
            this.closeCompareOCR.Size = new System.Drawing.Size(153, 44);
            this.closeCompareOCR.TabIndex = 13;
            this.closeCompareOCR.Text = "Close";
            this.closeCompareOCR.UseVisualStyleBackColor = false;
            this.closeCompareOCR.Click += new System.EventHandler(this.closeCompareOCR_Click);
            // 
            // PreprocessedImgText
            // 
            this.PreprocessedImgText.Location = new System.Drawing.Point(599, 464);
            this.PreprocessedImgText.Margin = new System.Windows.Forms.Padding(4);
            this.PreprocessedImgText.Multiline = true;
            this.PreprocessedImgText.Name = "PreprocessedImgText";
            this.PreprocessedImgText.ReadOnly = true;
            this.PreprocessedImgText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.PreprocessedImgText.Size = new System.Drawing.Size(525, 94);
            this.PreprocessedImgText.TabIndex = 12;
            // 
            // OriginalImgText
            // 
            this.OriginalImgText.Location = new System.Drawing.Point(35, 464);
            this.OriginalImgText.Margin = new System.Windows.Forms.Padding(4);
            this.OriginalImgText.Multiline = true;
            this.OriginalImgText.Name = "OriginalImgText";
            this.OriginalImgText.ReadOnly = true;
            this.OriginalImgText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OriginalImgText.Size = new System.Drawing.Size(523, 94);
            this.OriginalImgText.TabIndex = 11;
            // 
            // PreprocessedImg
            // 
            this.PreprocessedImg.AutoSize = true;
            this.PreprocessedImg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.PreprocessedImg.Location = new System.Drawing.Point(595, 23);
            this.PreprocessedImg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PreprocessedImg.Name = "PreprocessedImg";
            this.PreprocessedImg.Size = new System.Drawing.Size(134, 16);
            this.PreprocessedImg.TabIndex = 10;
            this.PreprocessedImg.Text = "Preprocessed Image";
            // 
            // OriginalImage
            // 
            this.OriginalImage.AutoSize = true;
            this.OriginalImage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(89)))), ((int)(((byte)(133)))));
            this.OriginalImage.Location = new System.Drawing.Point(31, 23);
            this.OriginalImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OriginalImage.Name = "OriginalImage";
            this.OriginalImage.Size = new System.Drawing.Size(91, 16);
            this.OriginalImage.TabIndex = 9;
            this.OriginalImage.Text = "OriginalImage";
            // 
            // PreProcessedImage
            // 
            this.PreProcessedImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PreProcessedImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PreProcessedImage.Location = new System.Drawing.Point(599, 42);
            this.PreProcessedImage.Margin = new System.Windows.Forms.Padding(4);
            this.PreProcessedImage.Name = "PreProcessedImage";
            this.PreProcessedImage.Size = new System.Drawing.Size(526, 390);
            this.PreProcessedImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PreProcessedImage.TabIndex = 8;
            this.PreProcessedImage.TabStop = false;
            this.PreProcessedImage.WaitOnLoad = true;
            // 
            // OriginalPicture
            // 
            this.OriginalPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OriginalPicture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OriginalPicture.Location = new System.Drawing.Point(35, 42);
            this.OriginalPicture.Margin = new System.Windows.Forms.Padding(4);
            this.OriginalPicture.Name = "OriginalPicture";
            this.OriginalPicture.Size = new System.Drawing.Size(523, 390);
            this.OriginalPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OriginalPicture.TabIndex = 7;
            this.OriginalPicture.TabStop = false;
            // 
            // FrmTeching
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1157, 640);
            this.Controls.Add(this.pnlPreview);
            this.Controls.Add(this.pnlTeaching);
            this.Controls.Add(this.pnlRecipe);
            this.Controls.Add(this.pnlCompareOCR);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTeching";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTeching";
            this.Load += new System.EventHandler(this.FrmTeching_Load);
            this.pnlTeaching.ResumeLayout(false);
            this.pnlTeaching.PerformLayout();
            this.Panel141.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnl_cam_1_create_receipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkZoomLevel)).EndInit();
            this.grp_preprocessing_OCR_CR_OP.ResumeLayout(false);
            this.grp_preprocessing_OCR_CR_OP.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlRecipe.ResumeLayout(false);
            this.pnlRecipeNamePopUp.ResumeLayout(false);
            this.pnlRecipeNamePopUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecipeList)).EndInit();
            this.pnlPreview.ResumeLayout(false);
            this.pnlPreview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreviewImage)).EndInit();
            this.pnlCompareOCR.ResumeLayout(false);
            this.pnlCompareOCR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PreProcessedImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OriginalPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlTeaching;
        private Button btnZoomPlus;
        private Button btnZoomMinus;
        private TrackBar trkZoomLevel;
        private Button btnStartPreview;
        private Label label7;
        internal Panel Panel141;
        private PictureBox pnl_cam_1_create_receipe;
        internal GroupBox grp_preprocessing_OCR_CR_OP;
        internal TextBox txtResultPostProcessed;
        private GroupBox groupBox1;
        private Button btnSaveRecipeTeach;
        private ComboBox cmbScaleFactor;
        private Label label4;
        private ComboBox cmbOEMValue;
        internal Label label3;
        private ComboBox cmbPsmValue;
        internal Label label2;
        private Button btnGetData;
        private Label label1;
        private ComboBox cmbThreshMethod;
        private ComboBox cmbSmooth;
        private ComboBox cmbDilate;
        private ComboBox cmbErode;
        private Label label26;
        private ComboBox cmbDataTypes;
        private TextBox txtCharMaxHeight;
        private ComboBox cmbTrainFile;
        private TextBox txtCharMaxWidth;
        private Label label25;
        private Label label23;
        private TextBox txtCharMinHeight;
        private CheckBox chkWhiteOnBlack;
        private Label label24;
        private TextBox txtCharMinWidth;
        private Label lblCapControlMax;
        private TextBox txtThreshMax;
        private Label lblCapControlMin;
        private TextBox txtThreshMin;
        private Label lblThreshholdMethod;
        private Label lblSmooth;
        private Label lblDilate;
        private Label lblErode;
        internal Label label27;
        internal Label Label174;
        internal TextBox txtResult;
        public Timer tmr_offline_Capture;
        private Panel pnlRecipe;
        private Panel pnlPreview;
        private DataGridView dgvRecipeList;
        private Button Delete;
        private Button Edit;
        private Button Create;
        private TextBox txtPreviewResult;
        private Button btnStopPreview;
        private PictureBox pbPreviewImage;
        private Timer timer1;
        private Panel pnlRecipeNamePopUp;
        private Button btnCreateRecipe;
        private Label lblRecipeName;
        private TextBox txtRecipeName;
        private Button btnCancelRecipeCreate;
        private Panel pnlCompareOCR;
        private Button closeCompareOCR;
        private TextBox PreprocessedImgText;
        private TextBox OriginalImgText;
        internal Label PreprocessedImg;
        internal Label OriginalImage;
        private PictureBox PreProcessedImage;
        private PictureBox OriginalPicture;
        private DataGridViewTextBoxColumn dgvRecipeListSrNo;
        private DataGridViewTextBoxColumn dgvRecipeListRecipeName;
        private DataGridViewTextBoxColumn dgvRecipeListLastModifiedOn;
        private Button btnCompareOCR;
        private TextBox txtPostProcessPreview;
        private CheckBox IsSavePostProcessedData;
    }
}