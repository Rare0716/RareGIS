
namespace MyGIS.Forms
{
    partial class AttributeQueryForm
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
            this.lblLayer = new System.Windows.Forms.Label();
            this.lblFind = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.cboLayer = new System.Windows.Forms.ComboBox();
            this.cboField = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLayer
            // 
            this.lblLayer.AccessibleDescription = "图层";
            this.lblLayer.AutoSize = true;
            this.lblLayer.Location = new System.Drawing.Point(37, 17);
            this.lblLayer.Name = "lblLayer";
            this.lblLayer.Size = new System.Drawing.Size(65, 12);
            this.lblLayer.TabIndex = 0;
            this.lblLayer.Text = "选择图层：";
            this.lblLayer.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFind
            // 
            this.lblFind.AccessibleDescription = "标签";
            this.lblFind.AutoSize = true;
            this.lblFind.Location = new System.Drawing.Point(37, 103);
            this.lblFind.Name = "lblFind";
            this.lblFind.Size = new System.Drawing.Size(65, 12);
            this.lblFind.TabIndex = 1;
            this.lblFind.Text = "字段查找：";
            this.lblFind.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblField
            // 
            this.lblField.AccessibleDescription = "标签";
            this.lblField.AutoSize = true;
            this.lblField.Location = new System.Drawing.Point(37, 59);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(65, 12);
            this.lblField.TabIndex = 2;
            this.lblField.Text = "字段名称：";
            // 
            // cboLayer
            // 
            this.cboLayer.AccessibleDescription = "MapControl中的图层名称";
            this.cboLayer.FormattingEnabled = true;
            this.cboLayer.Location = new System.Drawing.Point(116, 14);
            this.cboLayer.Name = "cboLayer";
            this.cboLayer.Size = new System.Drawing.Size(121, 20);
            this.cboLayer.TabIndex = 3;
            this.cboLayer.SelectedIndexChanged += new System.EventHandler(this.cboLayer_SelectedIndexChanged);
            // 
            // cboField
            // 
            this.cboField.AccessibleDescription = "cboLayer选中图层的所有字段名称";
            this.cboField.FormattingEnabled = true;
            this.cboField.Location = new System.Drawing.Point(116, 56);
            this.cboField.Name = "cboField";
            this.cboField.Size = new System.Drawing.Size(121, 20);
            this.cboField.TabIndex = 4;
            this.cboField.SelectedIndexChanged += new System.EventHandler(this.cboField_SelectedIndexChanged);
            // 
            // btnOk
            // 
            this.btnOk.AccessibleDescription = "查询按钮";
            this.btnOk.Location = new System.Drawing.Point(39, 179);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "查找";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "取消查询按钮";
            this.btnCancel.Location = new System.Drawing.Point(162, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtValue
            // 
            this.txtValue.AccessibleDescription = "输入的查询对象名称";
            this.txtValue.Location = new System.Drawing.Point(116, 94);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(100, 21);
            this.txtValue.TabIndex = 7;
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // AttributeQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cboField);
            this.Controls.Add(this.cboLayer);
            this.Controls.Add(this.lblField);
            this.Controls.Add(this.lblFind);
            this.Controls.Add(this.lblLayer);
            this.Name = "AttributeQueryForm";
            this.Text = "AttributeQueryForm";
            this.Load += new System.EventHandler(this.AttributeQueryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLayer;
        private System.Windows.Forms.Label lblFind;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.ComboBox cboLayer;
        private System.Windows.Forms.ComboBox cboField;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtValue;
    }
}