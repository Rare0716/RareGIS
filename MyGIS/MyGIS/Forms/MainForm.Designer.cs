namespace MyGIS
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAddData = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAnother = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuView = new System.Windows.Forms.ToolStripMenuItem();
            this.menuZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFixedZoomIn = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFixedZoomOut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFullExtent = new System.Windows.Forms.ToolStripMenuItem();
            this.menuQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAttributeQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSpatialQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolFixedZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolFixedZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolZoomIn = new System.Windows.Forms.ToolStripButton();
            this.toolZoomOut = new System.Windows.Forms.ToolStripButton();
            this.toolPan = new System.Windows.Forms.ToolStripButton();
            this.toolFullExtent = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusBlank = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusScale = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusCoordinate = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.axLicenseControl1 = new ESRI.ArcGIS.Controls.AxLicenseControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.axTOCControl1 = new ESRI.ArcGIS.Controls.AxTOCControl();
            this.axMapControl1 = new ESRI.ArcGIS.Controls.AxMapControl();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuView,
            this.menuQuery});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(811, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFileOpen,
            this.menuAddData,
            this.saveFile,
            this.saveAnother,
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(44, 21);
            this.menuFile.Text = "文件";
            // 
            // menuFileOpen
            // 
            this.menuFileOpen.Name = "menuFileOpen";
            this.menuFileOpen.Size = new System.Drawing.Size(152, 22);
            this.menuFileOpen.Text = "打开";
            this.menuFileOpen.Click += new System.EventHandler(this.menuFileOpen_Click);
            // 
            // menuAddData
            // 
            this.menuAddData.Name = "menuAddData";
            this.menuAddData.Size = new System.Drawing.Size(152, 22);
            this.menuAddData.Text = "添加数据";
            this.menuAddData.Click += new System.EventHandler(this.menuAddData_Click);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(152, 22);
            this.saveFile.Text = "保存";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // saveAnother
            // 
            this.saveAnother.Name = "saveAnother";
            this.saveAnother.Size = new System.Drawing.Size(152, 22);
            this.saveAnother.Text = "另存为";
            this.saveAnother.Click += new System.EventHandler(this.saveAnother_Click);
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(152, 22);
            this.menuExit.Text = "退出";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuView
            // 
            this.menuView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuZoomIn,
            this.menuZoomOut,
            this.menuFixedZoomIn,
            this.menuFixedZoomOut,
            this.menuPan,
            this.menuFullExtent});
            this.menuView.Name = "menuView";
            this.menuView.Size = new System.Drawing.Size(44, 21);
            this.menuView.Text = "视图";
            // 
            // menuZoomIn
            // 
            this.menuZoomIn.Name = "menuZoomIn";
            this.menuZoomIn.Size = new System.Drawing.Size(124, 22);
            this.menuZoomIn.Text = "放大";
            this.menuZoomIn.Click += new System.EventHandler(this.menuZoomIn_Click);
            // 
            // menuZoomOut
            // 
            this.menuZoomOut.Name = "menuZoomOut";
            this.menuZoomOut.Size = new System.Drawing.Size(124, 22);
            this.menuZoomOut.Text = "缩小";
            this.menuZoomOut.Click += new System.EventHandler(this.menuZoomOut_Click);
            // 
            // menuFixedZoomIn
            // 
            this.menuFixedZoomIn.Name = "menuFixedZoomIn";
            this.menuFixedZoomIn.Size = new System.Drawing.Size(124, 22);
            this.menuFixedZoomIn.Text = "中心放大";
            this.menuFixedZoomIn.Click += new System.EventHandler(this.menuFixedZoomIn_Click);
            // 
            // menuFixedZoomOut
            // 
            this.menuFixedZoomOut.Name = "menuFixedZoomOut";
            this.menuFixedZoomOut.Size = new System.Drawing.Size(124, 22);
            this.menuFixedZoomOut.Text = "中心缩小";
            this.menuFixedZoomOut.Click += new System.EventHandler(this.menuFixedZoomOut_Click);
            // 
            // menuPan
            // 
            this.menuPan.Name = "menuPan";
            this.menuPan.Size = new System.Drawing.Size(124, 22);
            this.menuPan.Text = "漫游";
            this.menuPan.Click += new System.EventHandler(this.menuPan_Click);
            // 
            // menuFullExtent
            // 
            this.menuFullExtent.Name = "menuFullExtent";
            this.menuFullExtent.Size = new System.Drawing.Size(124, 22);
            this.menuFullExtent.Text = "全图显示";
            this.menuFullExtent.Click += new System.EventHandler(this.menuFullExtent_Click);
            // 
            // menuQuery
            // 
            this.menuQuery.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAttributeQuery,
            this.menuSpatialQuery});
            this.menuQuery.Name = "menuQuery";
            this.menuQuery.Size = new System.Drawing.Size(44, 21);
            this.menuQuery.Text = "查询";
            // 
            // menuAttributeQuery
            // 
            this.menuAttributeQuery.Name = "menuAttributeQuery";
            this.menuAttributeQuery.Size = new System.Drawing.Size(124, 22);
            this.menuAttributeQuery.Text = "属性查询";
            this.menuAttributeQuery.Click += new System.EventHandler(this.menuAttributeQuery_Click);
            // 
            // menuSpatialQuery
            // 
            this.menuSpatialQuery.Name = "menuSpatialQuery";
            this.menuSpatialQuery.Size = new System.Drawing.Size(124, 22);
            this.menuSpatialQuery.Text = "空间查询";
            this.menuSpatialQuery.Click += new System.EventHandler(this.menuSpatialQuery_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFixedZoomIn,
            this.toolFixedZoomOut,
            this.toolZoomIn,
            this.toolZoomOut,
            this.toolPan,
            this.toolFullExtent});
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(811, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolFixedZoomIn
            // 
            this.toolFixedZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFixedZoomIn.Image = global::MyGIS.Properties.Resources.fixed_zoom_in;
            this.toolFixedZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFixedZoomIn.Name = "toolFixedZoomIn";
            this.toolFixedZoomIn.Size = new System.Drawing.Size(23, 22);
            this.toolFixedZoomIn.Text = "居中放大";
            this.toolFixedZoomIn.Click += new System.EventHandler(this.toolFixedZoomIn_Click);
            // 
            // toolFixedZoomOut
            // 
            this.toolFixedZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFixedZoomOut.Image = global::MyGIS.Properties.Resources.fixed_zoom_out;
            this.toolFixedZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFixedZoomOut.Name = "toolFixedZoomOut";
            this.toolFixedZoomOut.Size = new System.Drawing.Size(23, 22);
            this.toolFixedZoomOut.Text = "居中缩小";
            this.toolFixedZoomOut.Click += new System.EventHandler(this.toolFixedZoomOut_Click);
            // 
            // toolZoomIn
            // 
            this.toolZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomIn.Image = global::MyGIS.Properties.Resources.zoom_in;
            this.toolZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomIn.Name = "toolZoomIn";
            this.toolZoomIn.Size = new System.Drawing.Size(23, 22);
            this.toolZoomIn.Text = "放大";
            this.toolZoomIn.Click += new System.EventHandler(this.toolZoomIn_Click);
            // 
            // toolZoomOut
            // 
            this.toolZoomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolZoomOut.Image = global::MyGIS.Properties.Resources.zoom_out;
            this.toolZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolZoomOut.Name = "toolZoomOut";
            this.toolZoomOut.Size = new System.Drawing.Size(23, 22);
            this.toolZoomOut.Text = "缩小";
            this.toolZoomOut.Click += new System.EventHandler(this.toolZoomOut_Click);
            // 
            // toolPan
            // 
            this.toolPan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolPan.Image = global::MyGIS.Properties.Resources.pan;
            this.toolPan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolPan.Name = "toolPan";
            this.toolPan.Size = new System.Drawing.Size(23, 22);
            this.toolPan.Text = "漫游";
            this.toolPan.Click += new System.EventHandler(this.toolPan_Click);
            // 
            // toolFullExtent
            // 
            this.toolFullExtent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolFullExtent.Image = global::MyGIS.Properties.Resources.full_extent;
            this.toolFullExtent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFullExtent.Name = "toolFullExtent";
            this.toolFullExtent.Size = new System.Drawing.Size(23, 22);
            this.toolFullExtent.Text = "全图显示";
            this.toolFullExtent.Click += new System.EventHandler(this.toolFullExtent_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBlank,
            this.StatusScale,
            this.StatusCoordinate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(811, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusBlank
            // 
            this.StatusBlank.AccessibleDescription = "留作空白";
            this.StatusBlank.Name = "StatusBlank";
            this.StatusBlank.Size = new System.Drawing.Size(696, 17);
            this.StatusBlank.Spring = true;
            // 
            // StatusScale
            // 
            this.StatusScale.AccessibleDescription = "显示当前视图的比例尺";
            this.StatusScale.Name = "StatusScale";
            this.StatusScale.Size = new System.Drawing.Size(44, 17);
            this.StatusScale.Text = "比例尺";
            // 
            // StatusCoordinate
            // 
            this.StatusCoordinate.AccessibleDescription = "显示当前坐标信息";
            this.StatusCoordinate.Name = "StatusCoordinate";
            this.StatusCoordinate.Size = new System.Drawing.Size(56, 17);
            this.StatusCoordinate.Text = "当前坐标";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 53);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.axTOCControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(799, 441);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.axLicenseControl1);
            this.splitContainer2.Panel1.Controls.Add(this.axMapControl1);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer2.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer2.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(600, 441);
            this.splitContainer2.SplitterDistance = 329;
            this.splitContainer2.TabIndex = 0;
            // 
            // axLicenseControl1
            // 
            this.axLicenseControl1.Enabled = true;
            this.axLicenseControl1.Location = new System.Drawing.Point(528, 168);
            this.axLicenseControl1.Name = "axLicenseControl1";
            this.axLicenseControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axLicenseControl1.OcxState")));
            this.axLicenseControl1.Size = new System.Drawing.Size(32, 32);
            this.axLicenseControl1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OrangeRed;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(600, 108);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // axTOCControl1
            // 
            this.axTOCControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axTOCControl1.Location = new System.Drawing.Point(0, 0);
            this.axTOCControl1.Name = "axTOCControl1";
            this.axTOCControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axTOCControl1.OcxState")));
            this.axTOCControl1.Size = new System.Drawing.Size(195, 441);
            this.axTOCControl1.TabIndex = 0;
            this.axTOCControl1.OnMouseDown += new ESRI.ArcGIS.Controls.ITOCControlEvents_Ax_OnMouseDownEventHandler(this.axTOCControl1_OnMouseDown);
            // 
            // axMapControl1
            // 
            this.axMapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axMapControl1.Location = new System.Drawing.Point(0, 0);
            this.axMapControl1.Name = "axMapControl1";
            this.axMapControl1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMapControl1.OcxState")));
            this.axMapControl1.Size = new System.Drawing.Size(600, 329);
            this.axMapControl1.TabIndex = 0;
            this.axMapControl1.OnMouseDown += new ESRI.ArcGIS.Controls.IMapControlEvents2_Ax_OnMouseDownEventHandler(this.axMapControl1_OnMouseDown);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 519);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MainForm";
            this.Text = "oopsGIS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axLicenseControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axTOCControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axMapControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuFileOpen;
        private System.Windows.Forms.ToolStripMenuItem menuAddData;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuView;
        private System.Windows.Forms.ToolStripMenuItem menuZoomIn;
        private System.Windows.Forms.ToolStripMenuItem menuZoomOut;
        private System.Windows.Forms.ToolStripMenuItem menuFixedZoomIn;
        private System.Windows.Forms.ToolStripMenuItem menuFixedZoomOut;
        private System.Windows.Forms.ToolStripMenuItem menuPan;
        private System.Windows.Forms.ToolStripMenuItem menuFullExtent;
        private System.Windows.Forms.ToolStripMenuItem menuQuery;
        private System.Windows.Forms.ToolStripMenuItem menuAttributeQuery;
        private System.Windows.Forms.ToolStripMenuItem menuSpatialQuery;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolFixedZoomIn;
        private System.Windows.Forms.ToolStripButton toolFixedZoomOut;
        private System.Windows.Forms.ToolStripButton toolZoomIn;
        private System.Windows.Forms.ToolStripButton toolPan;
        private System.Windows.Forms.ToolStripButton toolFullExtent;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusBlank;
        private System.Windows.Forms.ToolStripStatusLabel StatusScale;
        private System.Windows.Forms.ToolStripStatusLabel StatusCoordinate;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private ESRI.ArcGIS.Controls.AxTOCControl axTOCControl1;
        private ESRI.ArcGIS.Controls.AxLicenseControl axLicenseControl1;
        private ESRI.ArcGIS.Controls.AxMapControl axMapControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolZoomOut;
        private System.Windows.Forms.ToolStripMenuItem saveFile;
        private System.Windows.Forms.ToolStripMenuItem saveAnother;

    }
}

