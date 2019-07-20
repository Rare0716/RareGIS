using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.SystemUI;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Geodatabase;
using MyGIS.Classes;
using MyGIS.Forms;

namespace MyGIS
{
    public partial class MainForm : Form
    {

        //空间查询的查询方式
        private int mQueryMode;
        //图层索引

        private int mLayerIndex;
        private ZoomIn mZoomIn = null;
        private string mTool;
        public MainForm()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void axTOCControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.ITOCControlEvents_OnMouseDownEvent e)
        {

        }

        private void axMapControl1_OnMouseDown(object sender, ESRI.ArcGIS.Controls.IMapControlEvents2_OnMouseDownEvent e)
        {


            //显示当前比例尺
            this.StatusScale.Text = "比例尺1:" + ((long)this.axMapControl1.MapScale).ToString();
            //显示当前坐标
            this.StatusCoordinate.Text = "当前坐标X=" + e.mapX.ToString() + " Y=" + e.mapY.ToString() + "" + this.axMapControl1.MapUnits;


            this.axMapControl1.Map.ClearSelection();
            //获取当前视图

            IActiveView pActiveView = this.axMapControl1.ActiveView;
            //获取鼠标点

            IPoint pPoint = pActiveView.ScreenDisplay.DisplayTransformation.ToMapPoint(e.x, e.y);

            switch(mTool){
                case "ZoomIn":
                    this.mZoomIn.OnMouseDown(e.button,e.shift,e.x,e.y);
                    break;
                case "ZoomOut":
                    //this.mZoomOut.OnMouseDown(e.button, e.shift, e.x, e.y);
                    break;
                case "Pan":
                    //设置鼠标形状
                    this.axMapControl1.MousePointer = esriControlsMousePointer.esriPointerPanning;
                    //this.mPan.OnMouseDown(e.button, e.shift, e.x, e.y);
                    break;
                case "SpaceQuery":
                    IGeometry pGeometry = null;
                    if (this.mQueryMode == 0)
                    {
                        //矩阵查询
                        pGeometry = this.axMapControl1.TrackRectangle();
                    }
                    else if (this.mQueryMode == 1)
                    {
                        //线查询
                        pGeometry = this.axMapControl1.TrackLine();
                    }
                    else if (this.mQueryMode == 2)
                    {
                        //点查询
                        ITopologicalOperator pTopo;
                        IGeometry pBuffer;
                        pGeometry = pPoint;
                        pTopo = pGeometry as ITopologicalOperator;

                        //根据点位创建缓冲区，缓冲半径为0.1，可修改

                        pBuffer = pTopo.Buffer(0.1);
                        pGeometry = pBuffer.Envelope;



                    }
                    else if (this.mQueryMode == 3)
                    {
                        pGeometry = this.axMapControl1.TrackCircle();
                    }
                    IFeatureLayer pFeatureLayer = this.axMapControl1.get_Layer(this.mLayerIndex) as IFeatureLayer;


                    DataTable pDataTable = this.LoadQueryResult(this.axMapControl1, pFeatureLayer, pGeometry);

                    this.dataGridView1.DataSource = pDataTable.DefaultView;

                    this.dataGridView1.Refresh();
                    break;
                    
                default:
                    break;

            }
            if (mZoomIn != null)
                mZoomIn.OnMouseDown(e.button, e.shift, e.x, e.y);
        }

        private void toolFullExtent_Click(object sender, EventArgs e)
        {
            //初始化FullExtent对象
            ICommand cmd = new ControlsMapFullExtentCommandClass();
            //关联FullExtent与MapControl
            cmd.OnCreate(this.axMapControl1.Object);
            cmd.OnClick();
        }

        private void toolPan_Click(object sender, EventArgs e)
        {
            //初始化Pan对象
            ITool tool = new ControlsMapPanToolClass();
            //查询接口，初始化Command类型
            ICommand cmd = tool as ICommand;
            //Command与MapControl关联
            cmd.OnCreate(this.axMapControl1.Object);
            cmd.OnClick();
            //当前MapControls的工具设为Pan
            this.axMapControl1.CurrentTool = tool;
        }

        private void toolFixedZoomIn_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapZoomInFixedCommandClass();
            cmd.OnCreate(this.axMapControl1.Object);
            cmd.OnClick();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            //文件路径名称，包含文件名称和路径名称
            string strName = null;

            //定义OpenFileDialog，获取并打开地图文档
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "打开MXD";
            openFileDialog.Filter = "MXD文件(*.mxd)|*.mxd";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                strName = openFileDialog.FileName;
                Console.Write(strName);
                if (strName != "")
                {
                    this.axMapControl1.LoadMxFile(strName);
                }
            }
            //地图文档全体显示
            this.axMapControl1.Extent = this.axMapControl1.FullExtent;

        }

        private void menuAddData_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsAddDataCommandClass();
            cmd.OnCreate(this.axMapControl1.Object);
            cmd.OnClick();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void menuFullExtent_Click(object sender, EventArgs e)
        {
            //初始化FullExtent对象
            ICommand cmd = new ControlsMapFullExtentCommandClass();
            //FullExtent 与MapControls关联
            cmd.OnCreate(this.axMapControl1.Object);
            cmd.OnClick();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private DataTable LoadQueryResult(AxMapControl mapControl, IFeatureLayer featureLayer, IGeometry geometry)
        {
            IFeatureClass pFeatureClass = featureLayer.FeatureClass;
            //根据图层图形字段初始化DataTable
            IFields pFields = pFeatureClass.Fields;
            DataTable pDataTable = new DataTable();
            for (int i = 0; i < pFields.FieldCount; i++)
            {
                string strFldName;
                strFldName = pFields.get_Field(i).AliasName;
                pDataTable.Columns.Add(strFldName);
            }

            //空间过滤器
            ISpatialFilter pSpatialFilter = new SpatialFilterClass();
            pSpatialFilter.Geometry = geometry;

            //根据图层类型选择缓冲方式
            switch (pFeatureClass.ShapeType)
            {
                case esriGeometryType.esriGeometryPoint:
                    pSpatialFilter.SpatialRel=esriSpatialRelEnum.esriSpatialRelContains;
                    break;
                case esriGeometryType.esriGeometryPolyline:
                    pSpatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelCrosses;
                    break;
                case esriGeometryType.esriGeometryPolygon:
                    pSpatialFilter.SpatialRel = esriSpatialRelEnum.esriSpatialRelIntersects;
                    break;
            }

            //定义空间过滤器的空间字段
            pSpatialFilter.GeometryField = pFeatureClass.ShapeFieldName;
            IQueryFilter pQueryFilter;

            IFeatureCursor pFeatureCursor;
            IFeature pFeature;
            //利用要素过滤器查询要素


            pQueryFilter = pSpatialFilter as IQueryFilter;

            pFeatureCursor = featureLayer.Search(pQueryFilter, true);
            pFeature = pFeatureCursor.NextFeature();

            while (pFeature != null)
            {
                string strFldValue = null;
                DataRow dr = pDataTable.NewRow();
                //遍历图层属性表字段值
                //并加入pDataTable
                for (int i = 0; i < pFields.FieldCount; i++)
                {
                    string strFldName = pFields.get_Field(i).Name;

                    if (strFldName == "Shape")
                    {
                        strFldValue = Convert.ToString(pFeature.Shape.GeometryType);
                    }
                    else
                    {
                        strFldValue = Convert.ToString(pFeature.get_Value(i));
                    }


                    dr[i] = strFldValue;
                }

                pDataTable.Rows.Add(dr);
                //高亮选择要素
                mapControl.Map.SelectFeature((ILayer)featureLayer, pFeature);
                mapControl.ActiveView.Refresh();
                pFeature = pFeatureCursor.NextFeature();

            }

            return pDataTable;
        }

        private void menuPan_Click(object sender, EventArgs e)
        {
            //初始化Pan对象
            ITool tool = new ControlsMapPanToolClass();
            //查询接口，初始化Command类型
            ICommand cmd = tool as ICommand;
            //Command与MapControl关联
            cmd.OnCreate(this.axMapControl1.Object);
            cmd.OnClick();
            //当前MapControls的工具设为Pan
            this.axMapControl1.CurrentTool = tool;
            
        }

        private void menuAttributeQuery_Click(object sender, EventArgs e)
        {
            //初始化属性查询窗口
            AttributeQueryForm attributeQueryForm = new AttributeQueryForm(this.axMapControl1);
            attributeQueryForm.Show();
        }

        private void menuZoomIn_Click(object sender, EventArgs e)
        {

            ITool tool = new ControlsMapZoomInToolClass();
            ICommand cmd = tool as ICommand;
            cmd.OnCreate(this.axMapControl1.Object);
            cmd.OnClick();
            this.axMapControl1.CurrentTool = tool;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuSpatialQuery_Click(object sender, EventArgs e)
        {
            //初始化空间查询窗体
            SpatialQueryForm spatialQueryForm = new SpatialQueryForm(this.axMapControl1);
            if (spatialQueryForm.ShowDialog()==DialogResult.OK)
            {
               //标记为“空间查询”
                this.mTool = "SpaceQuery";
                //获取查询方式和图层
                this.mQueryMode = spatialQueryForm.mQueryMode;
                this.mLayerIndex = spatialQueryForm.mLayerIndex;
                //定义鼠标形状
                this.axMapControl1.MousePointer = ESRI.ArcGIS.Controls.esriControlsMousePointer.esriPointerCrosshair;
                
            }

        }

        private void toolZoomIn_Click(object sender, EventArgs e)
        {
            ITool tool = new ControlsMapZoomInToolClass();
            ICommand cmd = tool as ICommand;
            cmd.OnCreate(this.axMapControl1.Object);
            cmd.OnClick();
            this.axMapControl1.CurrentTool = tool;
        }

        private void toolZoomOut_Click(object sender, EventArgs e)
        {
            //初始化ZoomIn对象
            //ICommand cmd = new ControlsMapFullExtentCommandClass();
            //ZoomOut与MapControl关联
            //cmd.OnCreate(this.axMapControl1.Object);
            //cmd.OnClick();


            //初始化Pan对象
            ITool tool = new ControlsMapZoomOutToolClass();
            //查询接口，初始化Command类型
            ICommand cmd = tool as ICommand;
            //Command与MapControl关联
            cmd.OnCreate(this.axMapControl1.Object);
            cmd.OnClick();
            //当前MapControls的工具设为Pan
            this.axMapControl1.CurrentTool = tool;
        }

        private void toolFixedZoomOut_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapZoomOutFixedCommandClass();
            cmd.OnCreate(this.axMapControl1.Object);
            cmd.OnClick();
        }

        private void menuFixedZoomIn_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsMapZoomInFixedCommandClass();
            cmd.OnCreate(this.axMapControl1.Object);
            cmd.OnClick();
        }

        private void menuFixedZoomOut_Click(object sender, EventArgs e)
        {

            ICommand cmd = new ControlsMapZoomOutFixedCommand();
            cmd.OnCreate(this.axMapControl1.Object);
            cmd.OnClick();
        }

        private void menuZoomOut_Click(object sender, EventArgs e)
        {
            //初始化对象
            ITool tool = new ControlsMapZoomOutToolClass();
            //查询接口，初始化Command类型
            ICommand cmd = tool as ICommand;
            //Command与MapControl关联
            cmd.OnCreate(this.axMapControl1.Object);
            cmd.OnClick();
            //当前MapControls的工具设为Pan
            this.axMapControl1.CurrentTool = tool;
        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            IMapDocument mapDoc = new MapDocumentClass();
            string mxdFileName = this.axMapControl1.DocumentFilename;
            //MessageBox.Show(mxdFileName);
            try{
                mapDoc.New(mxdFileName);
                mapDoc.ReplaceContents(axMapControl1.Map as IMxdContents);
                mapDoc.Save(mapDoc.UsesRelativePaths, true);
                mapDoc.Close();
            }catch(Exception ex){
                    return;
                }
        }

        private void createMxdFile_Click(object sender, EventArgs e)
        {
            this.axMapControl1 = new AxMapControl();
        }

        private void saveAnother_Click(object sender, EventArgs e)
        {
            ICommand cmd = new ControlsSaveAsDocCommandClass();
            cmd.OnCreate(axMapControl1.Object);
            cmd.OnClick();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("作者qq1983782527", "帮助");
        }
    }
}
