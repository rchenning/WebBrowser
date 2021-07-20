namespace WebBrowserUI
{
    partial class HistoryManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryManagerForm));
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.HistorySearchText = new System.Windows.Forms.ToolStripTextBox();
            this.HistorySearchButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.HistoryDeleteButton = new System.Windows.Forms.ToolStripButton();
            this.HistoryClearButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // historyListBox
            // 
            this.historyListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.Location = new System.Drawing.Point(0, 25);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(800, 425);
            this.historyListBox.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HistorySearchText,
            this.HistorySearchButton,
            this.toolStripSeparator1,
            this.HistoryDeleteButton,
            this.HistoryClearButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // HistorySearchText
            // 
            this.HistorySearchText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HistorySearchText.Name = "HistorySearchText";
            this.HistorySearchText.Size = new System.Drawing.Size(200, 25);
            // 
            // HistorySearchButton
            // 
            this.HistorySearchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HistorySearchButton.Image = ((System.Drawing.Image)(resources.GetObject("HistorySearchButton.Image")));
            this.HistorySearchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HistorySearchButton.Name = "HistorySearchButton";
            this.HistorySearchButton.Size = new System.Drawing.Size(46, 22);
            this.HistorySearchButton.Text = "Search";
            this.HistorySearchButton.ToolTipText = "Search";
            this.HistorySearchButton.Click += new System.EventHandler(this.HistorySearchButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // HistoryDeleteButton
            // 
            this.HistoryDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HistoryDeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("HistoryDeleteButton.Image")));
            this.HistoryDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HistoryDeleteButton.Name = "HistoryDeleteButton";
            this.HistoryDeleteButton.Size = new System.Drawing.Size(44, 22);
            this.HistoryDeleteButton.Text = "Delete";
            this.HistoryDeleteButton.Click += new System.EventHandler(this.HistoryDeleteButton_Click);
            // 
            // HistoryClearButton
            // 
            this.HistoryClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HistoryClearButton.Image = ((System.Drawing.Image)(resources.GetObject("HistoryClearButton.Image")));
            this.HistoryClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HistoryClearButton.Name = "HistoryClearButton";
            this.HistoryClearButton.Size = new System.Drawing.Size(79, 22);
            this.HistoryClearButton.Text = "Clear History";
            this.HistoryClearButton.Click += new System.EventHandler(this.HistoryClearButton_Click);
            // 
            // HistoryManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.historyListBox);
            this.Controls.Add(this.toolStrip1);
            this.Name = "HistoryManagerForm";
            this.Text = "History Manager Form";
            this.Load += new System.EventHandler(this.HistoryManagerForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripTextBox HistorySearchText;
        private System.Windows.Forms.ToolStripButton HistorySearchButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton HistoryDeleteButton;
        private System.Windows.Forms.ToolStripButton HistoryClearButton;
    }
}