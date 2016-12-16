namespace RFIDtoCS
{
    partial class RFIDtoCS
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
            this.stbConnected = new System.Windows.Forms.StatusStrip();
            this.pnlConnected = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlError_code = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlError_expl = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnuuFRCoderSimplestItem = new System.Windows.Forms.MenuStrip();
            this.mnuExitItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.stbFunctionError = new System.Windows.Forms.StatusStrip();
            this.pnlFunct_error = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlErr_codes = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlErr_explain = new System.Windows.Forms.ToolStripStatusLabel();
            this.pBar = new System.Windows.Forms.ProgressBar();
            this.stbCardStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLinearRead = new System.Windows.Forms.Button();
            this.lblReadData = new System.Windows.Forms.Label();
            this.txtReadData = new System.Windows.Forms.TextBox();
            this.txtCardUID = new System.Windows.Forms.TextBox();
            this.lblCardUID = new System.Windows.Forms.Label();
            this.stbConnected.SuspendLayout();
            this.mnuuFRCoderSimplestItem.SuspendLayout();
            this.stbFunctionError.SuspendLayout();
            this.stbCardStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // stbConnected
            // 
            this.stbConnected.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.stbConnected.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pnlConnected,
            this.pnlError_code,
            this.pnlError_expl});
            this.stbConnected.Location = new System.Drawing.Point(0, 446);
            this.stbConnected.Name = "stbConnected";
            this.stbConnected.Size = new System.Drawing.Size(299, 22);
            this.stbConnected.SizingGrip = false;
            this.stbConnected.TabIndex = 0;
            this.stbConnected.Text = "statusStrip1";
            // 
            // pnlConnected
            // 
            this.pnlConnected.AutoSize = false;
            this.pnlConnected.BackColor = System.Drawing.SystemColors.Control;
            this.pnlConnected.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.pnlConnected.Name = "pnlConnected";
            this.pnlConnected.Size = new System.Drawing.Size(120, 17);
            // 
            // pnlError_code
            // 
            this.pnlError_code.AutoSize = false;
            this.pnlError_code.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.pnlError_code.Name = "pnlError_code";
            this.pnlError_code.Size = new System.Drawing.Size(50, 17);
            this.pnlError_code.Text = " ";
            // 
            // pnlError_expl
            // 
            this.pnlError_expl.Name = "pnlError_expl";
            this.pnlError_expl.Size = new System.Drawing.Size(114, 17);
            this.pnlError_expl.Spring = true;
            this.pnlError_expl.Text = " ";
            // 
            // mnuuFRCoderSimplestItem
            // 
            this.mnuuFRCoderSimplestItem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExitItem});
            this.mnuuFRCoderSimplestItem.Location = new System.Drawing.Point(0, 0);
            this.mnuuFRCoderSimplestItem.Name = "mnuuFRCoderSimplestItem";
            this.mnuuFRCoderSimplestItem.Size = new System.Drawing.Size(299, 24);
            this.mnuuFRCoderSimplestItem.TabIndex = 1;
            this.mnuuFRCoderSimplestItem.Text = "menuStrip1";
            // 
            // mnuExitItem
            // 
            this.mnuExitItem.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.mnuExitItem.Name = "mnuExitItem";
            this.mnuExitItem.Size = new System.Drawing.Size(40, 20);
            this.mnuExitItem.Text = "Exit";
            this.mnuExitItem.Click += new System.EventHandler(this.mnuExitItem_Click);
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // stbFunctionError
            // 
            this.stbFunctionError.AutoSize = false;
            this.stbFunctionError.Dock = System.Windows.Forms.DockStyle.None;
            this.stbFunctionError.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.stbFunctionError.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pnlFunct_error,
            this.pnlErr_codes,
            this.pnlErr_explain});
            this.stbFunctionError.Location = new System.Drawing.Point(0, 399);
            this.stbFunctionError.Name = "stbFunctionError";
            this.stbFunctionError.Size = new System.Drawing.Size(531, 22);
            this.stbFunctionError.SizingGrip = false;
            this.stbFunctionError.TabIndex = 13;
            this.stbFunctionError.Text = "statusStrip1";
            // 
            // pnlFunct_error
            // 
            this.pnlFunct_error.AutoSize = false;
            this.pnlFunct_error.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.pnlFunct_error.Name = "pnlFunct_error";
            this.pnlFunct_error.Size = new System.Drawing.Size(120, 17);
            this.pnlFunct_error.Text = "Function Error";
            // 
            // pnlErr_codes
            // 
            this.pnlErr_codes.AutoSize = false;
            this.pnlErr_codes.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.pnlErr_codes.Name = "pnlErr_codes";
            this.pnlErr_codes.Size = new System.Drawing.Size(50, 17);
            this.pnlErr_codes.Text = " ";
            // 
            // pnlErr_explain
            // 
            this.pnlErr_explain.Name = "pnlErr_explain";
            this.pnlErr_explain.Size = new System.Drawing.Size(346, 17);
            this.pnlErr_explain.Spring = true;
            this.pnlErr_explain.Text = " ";
            // 
            // pBar
            // 
            this.pBar.Location = new System.Drawing.Point(0, 382);
            this.pBar.Name = "pBar";
            this.pBar.Size = new System.Drawing.Size(545, 14);
            this.pBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pBar.TabIndex = 14;
            this.pBar.UseWaitCursor = true;
            this.pBar.Visible = false;
            // 
            // stbCardStatus
            // 
            this.stbCardStatus.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.stbCardStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3});
            this.stbCardStatus.Location = new System.Drawing.Point(0, 424);
            this.stbCardStatus.Name = "stbCardStatus";
            this.stbCardStatus.Size = new System.Drawing.Size(299, 22);
            this.stbCardStatus.SizingGrip = false;
            this.stbCardStatus.TabIndex = 18;
            this.stbCardStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusLabel1.Text = "CARD STATUS";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel2.Text = " ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = " ";
            // 
            // btnLinearRead
            // 
            this.btnLinearRead.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLinearRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLinearRead.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLinearRead.Location = new System.Drawing.Point(28, 318);
            this.btnLinearRead.Name = "btnLinearRead";
            this.btnLinearRead.Size = new System.Drawing.Size(223, 40);
            this.btnLinearRead.TabIndex = 6;
            this.btnLinearRead.Text = "LINEAR READ";
            this.btnLinearRead.UseVisualStyleBackColor = true;
            this.btnLinearRead.Click += new System.EventHandler(this.btnLinearRead_Click);
            // 
            // lblReadData
            // 
            this.lblReadData.AutoSize = true;
            this.lblReadData.Location = new System.Drawing.Point(27, 111);
            this.lblReadData.Name = "lblReadData";
            this.lblReadData.Size = new System.Drawing.Size(67, 13);
            this.lblReadData.TabIndex = 29;
            this.lblReadData.Text = "Read Data";
            this.lblReadData.Click += new System.EventHandler(this.lblReadData_Click);
            // 
            // txtReadData
            // 
            this.txtReadData.BackColor = System.Drawing.Color.LightGray;
            this.txtReadData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReadData.Location = new System.Drawing.Point(30, 127);
            this.txtReadData.Multiline = true;
            this.txtReadData.Name = "txtReadData";
            this.txtReadData.ReadOnly = true;
            this.txtReadData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReadData.Size = new System.Drawing.Size(241, 185);
            this.txtReadData.TabIndex = 28;
            // 
            // txtCardUID
            // 
            this.txtCardUID.BackColor = System.Drawing.Color.White;
            this.txtCardUID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCardUID.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCardUID.Location = new System.Drawing.Point(99, 67);
            this.txtCardUID.Name = "txtCardUID";
            this.txtCardUID.ReadOnly = true;
            this.txtCardUID.Size = new System.Drawing.Size(152, 21);
            this.txtCardUID.TabIndex = 32;
            this.txtCardUID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCardUID
            // 
            this.lblCardUID.AutoSize = true;
            this.lblCardUID.Location = new System.Drawing.Point(27, 72);
            this.lblCardUID.Name = "lblCardUID";
            this.lblCardUID.Size = new System.Drawing.Size(57, 13);
            this.lblCardUID.TabIndex = 31;
            this.lblCardUID.Text = "Card tag";
            // 
            // RFIDtoCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 468);
            this.Controls.Add(this.txtCardUID);
            this.Controls.Add(this.lblCardUID);
            this.Controls.Add(this.btnLinearRead);
            this.Controls.Add(this.lblReadData);
            this.Controls.Add(this.txtReadData);
            this.Controls.Add(this.pBar);
            this.Controls.Add(this.stbCardStatus);
            this.Controls.Add(this.stbFunctionError);
            this.Controls.Add(this.stbConnected);
            this.Controls.Add(this.mnuuFRCoderSimplestItem);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mnuuFRCoderSimplestItem;
            this.MaximizeBox = false;
            this.Name = "RFIDtoCS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RFIDtoCS";
            this.Load += new System.EventHandler(this.frmuFRSimplest_Load);
            this.stbConnected.ResumeLayout(false);
            this.stbConnected.PerformLayout();
            this.mnuuFRCoderSimplestItem.ResumeLayout(false);
            this.mnuuFRCoderSimplestItem.PerformLayout();
            this.stbFunctionError.ResumeLayout(false);
            this.stbFunctionError.PerformLayout();
            this.stbCardStatus.ResumeLayout(false);
            this.stbCardStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stbConnected;
        private System.Windows.Forms.MenuStrip mnuuFRCoderSimplestItem;
        private System.Windows.Forms.ToolStripMenuItem mnuExitItem;
        private System.Windows.Forms.ToolStripStatusLabel pnlConnected;
        private System.Windows.Forms.ToolStripStatusLabel pnlError_code;
        private System.Windows.Forms.ToolStripStatusLabel pnlError_expl;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.StatusStrip stbFunctionError;
        private System.Windows.Forms.ToolStripStatusLabel pnlFunct_error;
        private System.Windows.Forms.ToolStripStatusLabel pnlErr_codes;
        private System.Windows.Forms.ToolStripStatusLabel pnlErr_explain;
        private System.Windows.Forms.ProgressBar pBar;
        private System.Windows.Forms.StatusStrip stbCardStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.Button btnLinearRead;
        private System.Windows.Forms.Label lblReadData;
        private System.Windows.Forms.TextBox txtReadData;
        private System.Windows.Forms.TextBox txtCardUID;
        private System.Windows.Forms.Label lblCardUID;
    }
}

