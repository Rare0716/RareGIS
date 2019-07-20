using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;
using ESRI.ArcGIS.Geodatabase;

namespace MyGIS.Forms
{
    public partial class AttributeQueryForm : Form
    {
        //地图数据
        private AxMapControl mMapControl;
        //选中图层
        private IFeatureLayer mFeatureLayer;

        private string queryText;
        //记录查询的关键词

        //
        private string queryFld;


        public AttributeQueryForm(AxMapControl mapControl)
        {
            InitializeComponent();
            this.mMapControl = mapControl;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AttributeQueryForm_Load(object sender, EventArgs e)
        {
            //MapCOntrol中没有图层时返回
            if (this.mMapControl.LayerCount <= 0)
                return;
            //获取MapControl中的全部图层名称，并加入ComboBox
            //图层
            ILayer pLayer;
            //图层名称
            string strLayerName;
            for (int i = 0; i < this.mMapControl.LayerCount; i++)
            {
                pLayer = this.mMapControl.get_Layer(i);
                strLayerName = pLayer.Name;
                //图层名称加入ComboBox
                this.cboLayer.Items.Add(strLayerName);
            }
            //默认显示第一个选项
            this.cboLayer.SelectedIndex = 0;

        }

        private void cboLayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取cboLayer中选中的图层
            mFeatureLayer = mMapControl.get_Layer(cboLayer.SelectedIndex) as IFeatureLayer;
            IFeatureClass pFeatureClass = mFeatureLayer.FeatureClass;
            //字段名称
            string strFldName;
            for(int i=0;i<pFeatureClass.Fields.FieldCount;i++)
            {
                strFldName = pFeatureClass.Fields.get_Field(i).Name;
                //图层名称加入cboField
                this.cboField.Items.Add(strFldName);
            }
            //默认显示第一个选项
            this.cboField.SelectedIndex = 0;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            IFeatureLayer queryFeatureLayer = this.mMapControl.Map.get_Layer(this.cboLayer.SelectedIndex) as IFeatureLayer;
            IFeatureCursor queryFeatureCursor;
            string queryField=queryFld;
            //Console.Write(queryFld);
            string queryContent=this.queryText;
            QueryFilterClass queryFilter = new QueryFilterClass();
            queryFilter.WhereClause = queryField + "='" + queryContent + "'";
            // MessageBox.Show(queryFilter.WhereClause);
            queryFeatureCursor = queryFeatureLayer.Search(queryFilter, true);
            IFeature resultFeature = queryFeatureCursor.NextFeature();
            if (resultFeature != null)
            {
                this.mMapControl.Map.SelectFeature(queryFeatureLayer, resultFeature);
                this.mMapControl.Extent = resultFeature.Shape.Envelope;
            }
            else
            {
                MessageBox.Show("没有找到结果","提示");
            }
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            queryText = this.txtValue.Text;
        }

        private void cboField_SelectedIndexChanged(object sender, EventArgs e)
        {
            queryFld = this.cboField.Text;
               // this.cboField.SelectedIndex;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
