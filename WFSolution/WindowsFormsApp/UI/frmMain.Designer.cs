namespace WindowsFormsApp.UI
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
            this.MainCamera = new System.Windows.Forms.PictureBox();
            this.ProcessLog = new System.Windows.Forms.ListBox();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.ProgressBarStatus = new System.Windows.Forms.ProgressBar();
            this.ListLogs = new System.Windows.Forms.ListBox();
            this.PanelStatus = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.MainCamera)).BeginInit();
            this.MainLayout.SuspendLayout();
            this.PanelStatus.SuspendLayout();
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
            this.ButtonStart.Location = new System.Drawing.Point(1076, 71);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(100, 50);
            this.ButtonStart.TabIndex = 1;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // MainCamera
            // 
            this.MainCamera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainCamera.Location = new System.Drawing.Point(192, 71);
            this.MainCamera.Name = "MainCamera";
            this.MainCamera.Size = new System.Drawing.Size(878, 538);
            this.MainCamera.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.MainCamera.TabIndex = 2;
            this.MainCamera.TabStop = false;
            // 
            // ProcessLog
            // 
            this.ProcessLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProcessLog.FormattingEnabled = true;
            this.ProcessLog.ItemHeight = 12;
            this.ProcessLog.Location = new System.Drawing.Point(192, 615);
            this.ProcessLog.Name = "ProcessLog";
            this.ProcessLog.Size = new System.Drawing.Size(878, 63);
            this.ProcessLog.TabIndex = 3;
            // 
            // MainLayout
            // 
            this.MainLayout.AutoSize = true;
            this.MainLayout.BackColor = System.Drawing.SystemColors.Window;
            this.MainLayout.ColumnCount = 3;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.MainLayout.Controls.Add(this.ProcessLog, 1, 2);
            this.MainLayout.Controls.Add(this.MainCamera, 1, 1);
            this.MainLayout.Controls.Add(this.ButtonStart, 2, 1);
            this.MainLayout.Controls.Add(this.ButtonOnOff, 2, 2);
            this.MainLayout.Controls.Add(this.ListLogs, 0, 2);
            this.MainLayout.Controls.Add(this.PanelStatus, 2, 0);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.MainLayout.Size = new System.Drawing.Size(1264, 681);
            this.MainLayout.TabIndex = 4;
            this.MainLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.MainLayout_Paint);
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
            // ListLogs
            // 
            this.ListLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListLogs.FormattingEnabled = true;
            this.ListLogs.ItemHeight = 12;
            this.ListLogs.Location = new System.Drawing.Point(3, 615);
            this.ListLogs.Name = "ListLogs";
            this.ListLogs.Size = new System.Drawing.Size(183, 63);
            this.ListLogs.TabIndex = 6;
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
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.MainLayout);
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmMain";
            this.Text = "WFApp";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainCamera)).EndInit();
            this.MainLayout.ResumeLayout(false);
            this.MainLayout.PerformLayout();
            this.PanelStatus.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonOnOff;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.PictureBox MainCamera;
        private System.Windows.Forms.ListBox ProcessLog;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.ProgressBar ProgressBarStatus;
        private System.Windows.Forms.ListBox ListLogs;
        private System.Windows.Forms.Panel PanelStatus;
    }
}

