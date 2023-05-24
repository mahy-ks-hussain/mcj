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
            this.fllySearch = new System.Windows.Forms.FlowLayoutPanel();
            this.fllyData = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbData = new System.Windows.Forms.GroupBox();
            this.rtbData = new System.Windows.Forms.RichTextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.tblyMain.SuspendLayout();
            this.tblyControls.SuspendLayout();
            this.fllyRefresh.SuspendLayout();
            this.fllySearch.SuspendLayout();
            this.fllyData.SuspendLayout();
            this.gbData.SuspendLayout();
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
            this.tblyControls.Controls.Add(this.fllySearch, 1, 0);
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
            this.fllyRefresh.Location = new System.Drawing.Point(3, 3);
            this.fllyRefresh.Name = "fllyRefresh";
            this.fllyRefresh.Size = new System.Drawing.Size(189, 64);
            this.fllyRefresh.TabIndex = 0;
            // 
            // fllySearch
            // 
            this.fllySearch.Controls.Add(this.lbSearch);
            this.fllySearch.Controls.Add(this.tbSearch);
            this.fllySearch.Controls.Add(this.btnSearch);
            this.fllySearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fllySearch.Location = new System.Drawing.Point(198, 3);
            this.fllySearch.Name = "fllySearch";
            this.fllySearch.Size = new System.Drawing.Size(777, 64);
            this.fllySearch.TabIndex = 1;
            // 
            // fllyData
            // 
            this.fllyData.Controls.Add(this.gbData);
            this.fllyData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fllyData.Location = new System.Drawing.Point(3, 79);
            this.fllyData.Name = "fllyData";
            this.fllyData.Size = new System.Drawing.Size(978, 679);
            this.fllyData.TabIndex = 1;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(3, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(109, 23);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh Data";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(66, 3);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 22);
            this.tbSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(172, 3);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbData
            // 
            this.gbData.Controls.Add(this.rtbData);
            this.gbData.Location = new System.Drawing.Point(3, 3);
            this.gbData.Name = "gbData";
            this.gbData.Size = new System.Drawing.Size(975, 676);
            this.gbData.TabIndex = 0;
            this.gbData.TabStop = false;
            this.gbData.Text = "Data";
            // 
            // rtbData
            // 
            this.rtbData.Location = new System.Drawing.Point(6, 21);
            this.rtbData.Name = "rtbData";
            this.rtbData.ReadOnly = true;
            this.rtbData.Size = new System.Drawing.Size(960, 646);
            this.rtbData.TabIndex = 0;
            this.rtbData.Text = "";
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
            this.fllySearch.ResumeLayout(false);
            this.fllySearch.PerformLayout();
            this.fllyData.ResumeLayout(false);
            this.gbData.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblyMain;
        private System.Windows.Forms.TableLayoutPanel tblyControls;
        private System.Windows.Forms.FlowLayoutPanel fllyRefresh;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.FlowLayoutPanel fllySearch;
        private System.Windows.Forms.FlowLayoutPanel fllyData;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbData;
        private System.Windows.Forms.RichTextBox rtbData;
        private System.Windows.Forms.Label lbSearch;
    }
}

