namespace WindowSniffer
{
    partial class WindowSnifferForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setWindowTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moveWindowToScreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dgdWindows = new System.Windows.Forms.DataGridView();
            this.refreshWindowListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.hideWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boundsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdWindows)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.windowToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshWindowListToolStripMenuItem,
            this.toolStripSeparator1,
            this.setWindowTextToolStripMenuItem,
            this.moveWindowToScreenToolStripMenuItem,
            this.showWindowToolStripMenuItem,
            this.hideWindowToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // setWindowTextToolStripMenuItem
            // 
            this.setWindowTextToolStripMenuItem.Name = "setWindowTextToolStripMenuItem";
            this.setWindowTextToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.setWindowTextToolStripMenuItem.Text = "Set Window Text";
            this.setWindowTextToolStripMenuItem.Click += new System.EventHandler(this.setWindowTextToolStripMenuItem_Click);
            // 
            // moveWindowToScreenToolStripMenuItem
            // 
            this.moveWindowToScreenToolStripMenuItem.Name = "moveWindowToScreenToolStripMenuItem";
            this.moveWindowToScreenToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.moveWindowToScreenToolStripMenuItem.Text = "Move Window to (0, 0)";
            this.moveWindowToScreenToolStripMenuItem.Click += new System.EventHandler(this.moveWindowToScreenToolStripMenuItem_Click);
            // 
            // showWindowToolStripMenuItem
            // 
            this.showWindowToolStripMenuItem.Name = "showWindowToolStripMenuItem";
            this.showWindowToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.showWindowToolStripMenuItem.Text = "Show Window";
            this.showWindowToolStripMenuItem.Click += new System.EventHandler(this.showWindowToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 397);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(467, 22);
            this.statusStrip1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dgdWindows.AllowUserToResizeRows = false;
            this.dgdWindows.AutoGenerateColumns = false;
            this.dgdWindows.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgdWindows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdWindows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.handleDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.boundsDataGridViewTextBoxColumn,
            this.sizeDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn});
            this.dgdWindows.DataSource = this.windowBindingSource;
            this.dgdWindows.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgdWindows.Location = new System.Drawing.Point(0, 24);
            this.dgdWindows.MultiSelect = false;
            this.dgdWindows.Name = "dataGridView1";
            this.dgdWindows.ReadOnly = true;
            this.dgdWindows.RowHeadersVisible = false;
            this.dgdWindows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgdWindows.Size = new System.Drawing.Size(467, 373);
            this.dgdWindows.TabIndex = 1;
            // 
            // refreshWindowListToolStripMenuItem
            // 
            this.refreshWindowListToolStripMenuItem.Name = "refreshWindowListToolStripMenuItem";
            this.refreshWindowListToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.refreshWindowListToolStripMenuItem.Text = "Refresh Window List";
            this.refreshWindowListToolStripMenuItem.Click += new System.EventHandler(this.refreshWindowListToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(191, 6);
            // 
            // hideWindowToolStripMenuItem
            // 
            this.hideWindowToolStripMenuItem.Name = "hideWindowToolStripMenuItem";
            this.hideWindowToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.hideWindowToolStripMenuItem.Text = "Hide Window";
            this.hideWindowToolStripMenuItem.Click += new System.EventHandler(this.hideWindowToolStripMenuItem_Click);
            // 
            // handleDataGridViewTextBoxColumn
            // 
            this.handleDataGridViewTextBoxColumn.DataPropertyName = "Handle";
            this.handleDataGridViewTextBoxColumn.HeaderText = "Handle";
            this.handleDataGridViewTextBoxColumn.Name = "handleDataGridViewTextBoxColumn";
            this.handleDataGridViewTextBoxColumn.ReadOnly = true;
            this.handleDataGridViewTextBoxColumn.Width = 66;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.textDataGridViewTextBoxColumn.DataPropertyName = "Text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Text";
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boundsDataGridViewTextBoxColumn
            // 
            this.boundsDataGridViewTextBoxColumn.DataPropertyName = "Bounds";
            this.boundsDataGridViewTextBoxColumn.HeaderText = "Bounds";
            this.boundsDataGridViewTextBoxColumn.Name = "boundsDataGridViewTextBoxColumn";
            this.boundsDataGridViewTextBoxColumn.ReadOnly = true;
            this.boundsDataGridViewTextBoxColumn.Width = 68;
            // 
            // sizeDataGridViewTextBoxColumn
            // 
            this.sizeDataGridViewTextBoxColumn.DataPropertyName = "Size";
            this.sizeDataGridViewTextBoxColumn.HeaderText = "Size";
            this.sizeDataGridViewTextBoxColumn.Name = "sizeDataGridViewTextBoxColumn";
            this.sizeDataGridViewTextBoxColumn.ReadOnly = true;
            this.sizeDataGridViewTextBoxColumn.Width = 52;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "Location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "Location";
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Width = 73;
            // 
            // windowBindingSource
            // 
            this.windowBindingSource.DataSource = typeof(WindowSniffer.Window);
            // 
            // WindowSnifferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 419);
            this.Controls.Add(this.dgdWindows);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WindowSnifferForm";
            this.Text = "Window Sniffer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdWindows)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.windowBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dgdWindows;
        private System.Windows.Forms.DataGridViewTextBoxColumn handleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boundsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource windowBindingSource;
        private System.Windows.Forms.ToolStripMenuItem setWindowTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moveWindowToScreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshWindowListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem hideWindowToolStripMenuItem;
    }
}

