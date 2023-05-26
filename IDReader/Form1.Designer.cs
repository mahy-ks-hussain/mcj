namespace IDReader
{
    partial class frmIDReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIDReader));
            this.tblyMain = new System.Windows.Forms.TableLayoutPanel();
            this.tblyControls = new System.Windows.Forms.TableLayoutPanel();
            this.fllyRefresh = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tblySearch = new System.Windows.Forms.TableLayoutPanel();
            this.fllySearch = new System.Windows.Forms.FlowLayoutPanel();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.fllyCurrFile = new System.Windows.Forms.FlowLayoutPanel();
            this.lbStatus = new System.Windows.Forms.Label();
            this.fllyData = new System.Windows.Forms.FlowLayoutPanel();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.tbcText = new System.Windows.Forms.TabControl();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.tabRaw = new System.Windows.Forms.TabPage();
            this.rtbRaw = new System.Windows.Forms.RichTextBox();
            this.tblyMain.SuspendLayout();
            this.tblyControls.SuspendLayout();
            this.fllyRefresh.SuspendLayout();
            this.tblySearch.SuspendLayout();
            this.fllySearch.SuspendLayout();
            this.fllyCurrFile.SuspendLayout();
            this.fllyData.SuspendLayout();
            this.tbcText.SuspendLayout();
            this.tabSearch.SuspendLayout();
            this.tabRaw.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblyMain
            // 
            this.tblyMain.ColumnCount = 1;
            this.tblyMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblyMain.Controls.Add(this.tblyControls, 0, 0);
            this.tblyMain.Controls.Add(this.fllyData, 0, 1);
            this.tblyMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblyMain.Location = new System.Drawing.Point(0, 0);
            this.tblyMain.Name = "tblyMain";
            this.tblyMain.RowCount = 2;
            this.tblyMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tblyMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tblyMain.Size = new System.Drawing.Size(984, 761);
            this.tblyMain.TabIndex = 0;
            // 
            // tblyControls
            // 
            this.tblyControls.ColumnCount = 2;
            this.tblyControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tblyControls.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tblyControls.Controls.Add(this.fllyRefresh, 0, 0);
            this.tblyControls.Controls.Add(this.tblySearch, 1, 0);
            this.tblyControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblyControls.Location = new System.Drawing.Point(3, 3);
            this.tblyControls.Name = "tblyControls";
            this.tblyControls.RowCount = 1;
            this.tblyControls.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblyControls.Size = new System.Drawing.Size(978, 70);
            this.tblyControls.TabIndex = 0;
            // 
            // fllyRefresh
            // 
            this.fllyRefresh.Controls.Add(this.btnRefresh);
            this.fllyRefresh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fllyRefresh.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fllyRefresh.Location = new System.Drawing.Point(3, 3);
            this.fllyRefresh.Name = "fllyRefresh";
            this.fllyRefresh.Size = new System.Drawing.Size(189, 64);
            this.fllyRefresh.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(88, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Get Data";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // tblySearch
            // 
            this.tblySearch.ColumnCount = 1;
            this.tblySearch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblySearch.Controls.Add(this.fllySearch, 0, 0);
            this.tblySearch.Controls.Add(this.fllyCurrFile, 0, 1);
            this.tblySearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblySearch.Location = new System.Drawing.Point(198, 3);
            this.tblySearch.Name = "tblySearch";
            this.tblySearch.RowCount = 2;
            this.tblySearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblySearch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblySearch.Size = new System.Drawing.Size(777, 64);
            this.tblySearch.TabIndex = 1;
            // 
            // fllySearch
            // 
            this.fllySearch.Controls.Add(this.lbSearch);
            this.fllySearch.Controls.Add(this.tbSearch);
            this.fllySearch.Controls.Add(this.btnSearch);
            this.fllySearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fllySearch.Location = new System.Drawing.Point(3, 3);
            this.fllySearch.Name = "fllySearch";
            this.fllySearch.Size = new System.Drawing.Size(771, 26);
            this.fllySearch.TabIndex = 0;
            // 
            // lbSearch
            // 
            this.lbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(3, 0);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(57, 29);
            this.lbSearch.TabIndex = 2;
            this.lbSearch.Text = "Enter ID:";
            this.lbSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbSearch
            // 
            this.tbSearch.Enabled = false;
            this.tbSearch.Location = new System.Drawing.Point(66, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(300, 22);
            this.tbSearch.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Enabled = false;
            this.btnSearch.Location = new System.Drawing.Point(372, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // fllyCurrFile
            // 
            this.fllyCurrFile.Controls.Add(this.lbStatus);
            this.fllyCurrFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fllyCurrFile.Location = new System.Drawing.Point(3, 35);
            this.fllyCurrFile.Name = "fllyCurrFile";
            this.fllyCurrFile.Size = new System.Drawing.Size(771, 26);
            this.fllyCurrFile.TabIndex = 1;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(3, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(162, 16);
            this.lbStatus.TabIndex = 2;
            this.lbStatus.Text = "Press \"Get Data\" to begin.";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fllyData
            // 
            this.fllyData.Controls.Add(this.tbcText);
            this.fllyData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fllyData.Location = new System.Drawing.Point(3, 79);
            this.fllyData.Name = "fllyData";
            this.fllyData.Size = new System.Drawing.Size(978, 679);
            this.fllyData.TabIndex = 1;
            // 
            // rtbResult
            // 
            this.rtbResult.ForeColor = System.Drawing.Color.Black;
            this.rtbResult.Location = new System.Drawing.Point(0, 0);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.ReadOnly = true;
            this.rtbResult.Size = new System.Drawing.Size(968, 651);
            this.rtbResult.TabIndex = 3;
            this.rtbResult.Text = "";
            // 
            // tbcText
            // 
            this.tbcText.Controls.Add(this.tabSearch);
            this.tbcText.Controls.Add(this.tabRaw);
            this.tbcText.Location = new System.Drawing.Point(3, 3);
            this.tbcText.Name = "tbcText";
            this.tbcText.SelectedIndex = 0;
            this.tbcText.Size = new System.Drawing.Size(975, 679);
            this.tbcText.TabIndex = 5;
            // 
            // tabSearch
            // 
            this.tabSearch.Controls.Add(this.rtbResult);
            this.tabSearch.Location = new System.Drawing.Point(4, 25);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(967, 650);
            this.tabSearch.TabIndex = 0;
            this.tabSearch.Text = "Search Results";
            this.tabSearch.UseVisualStyleBackColor = true;
            // 
            // tabRaw
            // 
            this.tabRaw.Controls.Add(this.rtbRaw);
            this.tabRaw.Location = new System.Drawing.Point(4, 25);
            this.tabRaw.Name = "tabRaw";
            this.tabRaw.Padding = new System.Windows.Forms.Padding(3);
            this.tabRaw.Size = new System.Drawing.Size(967, 650);
            this.tabRaw.TabIndex = 1;
            this.tabRaw.Text = "Raw Data";
            this.tabRaw.UseVisualStyleBackColor = true;
            // 
            // rtbRaw
            // 
            this.rtbRaw.ForeColor = System.Drawing.Color.Black;
            this.rtbRaw.Location = new System.Drawing.Point(-1, -1);
            this.rtbRaw.Name = "rtbRaw";
            this.rtbRaw.ReadOnly = true;
            this.rtbRaw.Size = new System.Drawing.Size(968, 651);
            this.rtbRaw.TabIndex = 4;
            this.rtbRaw.Text = "";
            // 
            // frmIDReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.tblyMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIDReader";
            this.Text = "AGV ID Reader";
            this.tblyMain.ResumeLayout(false);
            this.tblyControls.ResumeLayout(false);
            this.fllyRefresh.ResumeLayout(false);
            this.tblySearch.ResumeLayout(false);
            this.fllySearch.ResumeLayout(false);
            this.fllySearch.PerformLayout();
            this.fllyCurrFile.ResumeLayout(false);
            this.fllyCurrFile.PerformLayout();
            this.fllyData.ResumeLayout(false);
            this.tbcText.ResumeLayout(false);
            this.tabSearch.ResumeLayout(false);
            this.tabRaw.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblyMain;
        private System.Windows.Forms.TableLayoutPanel tblyControls;
        private System.Windows.Forms.FlowLayoutPanel fllyRefresh;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel fllyData;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RichTextBox rtbResult;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.TableLayoutPanel tblySearch;
        private System.Windows.Forms.FlowLayoutPanel fllySearch;
        private System.Windows.Forms.FlowLayoutPanel fllyCurrFile;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TabControl tbcText;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TabPage tabRaw;
        private System.Windows.Forms.RichTextBox rtbRaw;
    }
}

