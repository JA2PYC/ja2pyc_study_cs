﻿namespace WindowsFormsApp.UI
{
    partial class FrmMain
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
            this.ButtonOnOff = new System.Windows.Forms.Button();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.PictureBoxMain = new System.Windows.Forms.PictureBox();
            this.ListBoxMain = new System.Windows.Forms.ListBox();
            this.LayoutMain = new System.Windows.Forms.TableLayoutPanel();
            this.ListBoxLogs = new System.Windows.Forms.ListBox();
            this.PanelStatus = new System.Windows.Forms.Panel();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.ProgressBarStatus = new System.Windows.Forms.ProgressBar();
            this.FlowPanelLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonCameraType = new System.Windows.Forms.Button();
            this.ButtonCameraList = new System.Windows.Forms.Button();
            this.ButtonStartLive = new System.Windows.Forms.Button();
            this.FlowPanelRight = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonCameraInfo = new System.Windows.Forms.Button();
            this.ButtonCaptureImage = new System.Windows.Forms.Button();
            this.ButtonSetResolution = new System.Windows.Forms.Button();
            this.ButtonStopLive = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).BeginInit();
            this.LayoutMain.SuspendLayout();
            this.PanelStatus.SuspendLayout();
            this.FlowPanelLeft.SuspendLayout();
            this.FlowPanelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonOnOff
            // 
            this.ButtonOnOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ButtonOnOff.Location = new System.Drawing.Point(1076, 615);
            this.ButtonOnOff.Name = "ButtonOnOff";
            this.ButtonOnOff.Size = new System.Drawing.Size(185, 63);
            this.ButtonOnOff.TabIndex = 0;
            this.ButtonOnOff.Text = "On/Off";
            this.ButtonOnOff.UseVisualStyleBackColor = true;
            this.ButtonOnOff.Click += new System.EventHandler(this.BtnOnOff_Click);
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(3, 3);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(85, 50);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // PictureBoxMain
            // 
            this.PictureBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxMain.BackColor = System.Drawing.SystemColors.Window;
            this.PictureBoxMain.Location = new System.Drawing.Point(192, 71);
            this.PictureBoxMain.Name = "PictureBoxMain";
            this.PictureBoxMain.Size = new System.Drawing.Size(878, 538);
            this.PictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PictureBoxMain.TabIndex = 2;
            this.PictureBoxMain.TabStop = false;
            this.PictureBoxMain.Click += new System.EventHandler(this.PictureBoxMain_Click);
            // 
            // ListBoxMain
            // 
            this.ListBoxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxMain.FormattingEnabled = true;
            this.ListBoxMain.ItemHeight = 12;
            this.ListBoxMain.Location = new System.Drawing.Point(192, 615);
            this.ListBoxMain.Name = "ListBoxMain";
            this.ListBoxMain.Size = new System.Drawing.Size(878, 63);
            this.ListBoxMain.TabIndex = 3;
            // 
            // LayoutMain
            // 
            this.LayoutMain.AutoSize = true;
            this.LayoutMain.BackColor = System.Drawing.SystemColors.Window;
            this.LayoutMain.ColumnCount = 3;
            this.LayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.LayoutMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.LayoutMain.Controls.Add(this.ListBoxMain, 1, 2);
            this.LayoutMain.Controls.Add(this.PictureBoxMain, 1, 1);
            this.LayoutMain.Controls.Add(this.ButtonOnOff, 2, 2);
            this.LayoutMain.Controls.Add(this.ListBoxLogs, 0, 2);
            this.LayoutMain.Controls.Add(this.PanelStatus, 2, 0);
            this.LayoutMain.Controls.Add(this.FlowPanelLeft, 0, 1);
            this.LayoutMain.Controls.Add(this.FlowPanelRight, 2, 1);
            this.LayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutMain.Location = new System.Drawing.Point(0, 0);
            this.LayoutMain.Name = "LayoutMain";
            this.LayoutMain.RowCount = 3;
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.LayoutMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.LayoutMain.Size = new System.Drawing.Size(1264, 681);
            this.LayoutMain.TabIndex = 4;
            this.LayoutMain.Paint += new System.Windows.Forms.PaintEventHandler(this.MainLayout_Paint);
            // 
            // ListBoxLogs
            // 
            this.ListBoxLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBoxLogs.FormattingEnabled = true;
            this.ListBoxLogs.ItemHeight = 12;
            this.ListBoxLogs.Location = new System.Drawing.Point(3, 615);
            this.ListBoxLogs.Name = "ListBoxLogs";
            this.ListBoxLogs.Size = new System.Drawing.Size(183, 63);
            this.ListBoxLogs.TabIndex = 6;
            // 
            // PanelStatus
            // 
            this.PanelStatus.Controls.Add(this.LabelStatus);
            this.PanelStatus.Controls.Add(this.ProgressBarStatus);
            this.PanelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelStatus.Location = new System.Drawing.Point(1076, 3);
            this.PanelStatus.Name = "PanelStatus";
            this.PanelStatus.Size = new System.Drawing.Size(185, 62);
            this.PanelStatus.TabIndex = 7;
            // 
            // LabelStatus
            // 
            this.LabelStatus.BackColor = System.Drawing.SystemColors.Control;
            this.LabelStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LabelStatus.Location = new System.Drawing.Point(0, 0);
            this.LabelStatus.Margin = new System.Windows.Forms.Padding(0);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Padding = new System.Windows.Forms.Padding(5);
            this.LabelStatus.Size = new System.Drawing.Size(185, 39);
            this.LabelStatus.TabIndex = 4;
            this.LabelStatus.Text = "Status";
            // 
            // ProgressBarStatus
            // 
            this.ProgressBarStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ProgressBarStatus.ForeColor = System.Drawing.Color.LawnGreen;
            this.ProgressBarStatus.Location = new System.Drawing.Point(0, 39);
            this.ProgressBarStatus.Name = "ProgressBarStatus";
            this.ProgressBarStatus.Size = new System.Drawing.Size(185, 23);
            this.ProgressBarStatus.TabIndex = 5;
            // 
            // FlowPanelLeft
            // 
            this.FlowPanelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FlowPanelLeft.AutoScroll = true;
            this.FlowPanelLeft.AutoSize = true;
            this.FlowPanelLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowPanelLeft.Controls.Add(this.ButtonCameraType);
            this.FlowPanelLeft.Controls.Add(this.ButtonCameraList);
            this.FlowPanelLeft.Controls.Add(this.ButtonCameraInfo);
            this.FlowPanelLeft.Controls.Add(this.ButtonSetResolution);
            this.FlowPanelLeft.Controls.Add(this.ButtonCaptureImage);
            this.FlowPanelLeft.Controls.Add(this.ButtonStartLive);
            this.FlowPanelLeft.Controls.Add(this.ButtonStopLive);
            this.FlowPanelLeft.Location = new System.Drawing.Point(8, 71);
            this.FlowPanelLeft.Name = "FlowPanelLeft";
            this.FlowPanelLeft.Size = new System.Drawing.Size(172, 538);
            this.FlowPanelLeft.TabIndex = 9;
            // 
            // ButtonCameraType
            // 
            this.ButtonCameraType.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonCameraType.Location = new System.Drawing.Point(3, 3);
            this.ButtonCameraType.MaximumSize = new System.Drawing.Size(150, 50);
            this.ButtonCameraType.MinimumSize = new System.Drawing.Size(80, 50);
            this.ButtonCameraType.Name = "ButtonCameraType";
            this.ButtonCameraType.Size = new System.Drawing.Size(80, 50);
            this.ButtonCameraType.TabIndex = 8;
            this.ButtonCameraType.Text = "Camera \r\nType";
            this.ButtonCameraType.UseVisualStyleBackColor = true;
            this.ButtonCameraType.Click += new System.EventHandler(this.BtnCameraType_Click);
            // 
            // ButtonCameraList
            // 
            this.ButtonCameraList.Location = new System.Drawing.Point(89, 3);
            this.ButtonCameraList.Name = "ButtonCameraList";
            this.ButtonCameraList.Size = new System.Drawing.Size(80, 50);
            this.ButtonCameraList.TabIndex = 9;
            this.ButtonCameraList.Text = "Camera \r\nList";
            this.ButtonCameraList.UseVisualStyleBackColor = true;
            this.ButtonCameraList.Click += new System.EventHandler(this.BtnCameraList_Click);
            // 
            // ButtonStartLive
            // 
            this.ButtonStartLive.Location = new System.Drawing.Point(89, 115);
            this.ButtonStartLive.Name = "ButtonStartLive";
            this.ButtonStartLive.Size = new System.Drawing.Size(80, 50);
            this.ButtonStartLive.TabIndex = 10;
            this.ButtonStartLive.Text = "Start \r\nLive";
            this.ButtonStartLive.UseVisualStyleBackColor = true;
            this.ButtonStartLive.Click += new System.EventHandler(this.BtnLive_Click);
            // 
            // FlowPanelRight
            // 
            this.FlowPanelRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.FlowPanelRight.AutoSize = true;
            this.FlowPanelRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FlowPanelRight.Controls.Add(this.ButtonStart);
            this.FlowPanelRight.Location = new System.Drawing.Point(1123, 71);
            this.FlowPanelRight.Name = "FlowPanelRight";
            this.FlowPanelRight.Size = new System.Drawing.Size(91, 538);
            this.FlowPanelRight.TabIndex = 10;
            // 
            // ButtonCameraInfo
            // 
            this.ButtonCameraInfo.Location = new System.Drawing.Point(3, 59);
            this.ButtonCameraInfo.Name = "ButtonCameraInfo";
            this.ButtonCameraInfo.Size = new System.Drawing.Size(80, 50);
            this.ButtonCameraInfo.TabIndex = 11;
            this.ButtonCameraInfo.Text = "Camera \r\nInfo";
            this.ButtonCameraInfo.UseVisualStyleBackColor = true;
            // 
            // ButtonCaptureImage
            // 
            this.ButtonCaptureImage.Location = new System.Drawing.Point(3, 115);
            this.ButtonCaptureImage.Name = "ButtonCaptureImage";
            this.ButtonCaptureImage.Size = new System.Drawing.Size(80, 50);
            this.ButtonCaptureImage.TabIndex = 12;
            this.ButtonCaptureImage.Text = "Get Image";
            this.ButtonCaptureImage.UseVisualStyleBackColor = true;
            // 
            // ButtonSetResolution
            // 
            this.ButtonSetResolution.Location = new System.Drawing.Point(89, 59);
            this.ButtonSetResolution.Name = "ButtonSetResolution";
            this.ButtonSetResolution.Size = new System.Drawing.Size(80, 50);
            this.ButtonSetResolution.TabIndex = 13;
            this.ButtonSetResolution.Text = "Set \r\nResolution";
            this.ButtonSetResolution.UseVisualStyleBackColor = true;
            // 
            // ButtonStopLive
            // 
            this.ButtonStopLive.Location = new System.Drawing.Point(3, 171);
            this.ButtonStopLive.Name = "ButtonStopLive";
            this.ButtonStopLive.Size = new System.Drawing.Size(80, 50);
            this.ButtonStopLive.TabIndex = 14;
            this.ButtonStopLive.Text = "Stop \r\nLive";
            this.ButtonStopLive.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.LayoutMain);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "FrmMain";
            this.Text = "WFApp";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxMain)).EndInit();
            this.LayoutMain.ResumeLayout(false);
            this.LayoutMain.PerformLayout();
            this.PanelStatus.ResumeLayout(false);
            this.FlowPanelLeft.ResumeLayout(false);
            this.FlowPanelRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        // Main layout for the form
        private System.Windows.Forms.TableLayoutPanel LayoutMain;
        // Main PictureBox for displaying camera feed
        private System.Windows.Forms.PictureBox PictureBoxMain;
        private System.Windows.Forms.ListBox ListBoxMain;
        private System.Windows.Forms.ListBox ListBoxLogs;
        // Button to toggle process on/off
        private System.Windows.Forms.Button ButtonOnOff;
        // Status panel with label and progress bar
        private System.Windows.Forms.Panel PanelStatus;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.ProgressBar ProgressBarStatus;
        // FlowLayoutPanel for left side buttons
        private System.Windows.Forms.FlowLayoutPanel FlowPanelLeft;
        private System.Windows.Forms.Button ButtonCameraType;
        private System.Windows.Forms.Button ButtonCameraList;
        private System.Windows.Forms.Button ButtonStartLive;
        
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.FlowLayoutPanel FlowPanelRight;
        private System.Windows.Forms.Button ButtonCameraInfo;
        private System.Windows.Forms.Button ButtonCaptureImage;
        private System.Windows.Forms.Button ButtonSetResolution;
        private System.Windows.Forms.Button ButtonStopLive;
    }
}

