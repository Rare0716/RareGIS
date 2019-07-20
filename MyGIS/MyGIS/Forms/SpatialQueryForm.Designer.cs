namespace MyGIS.Forms
{
    partial class SpatialQueryForm
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
            this.lblMode = new System.Windows.Forms.Label();
            this.cboLayer = new System.Windows.Forms.ComboBox();
            this.cboMode = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLayer
            // 
            this.lblLayer.AccessibleDescription = "标签";
            this.lblLayer.AutoSize = true;
            this.lblLayer.Location = new System.Drawing.Point(47, 42);
            this.lblLayer.Name = "lblLayer";
            this.lblLayer.Size = new System.Drawing.Size(65, 12);
            this.lblLayer.TabIndex = 0;
            this.lblLayer.Text = "选择图层：";
            this.lblLayer.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Location = new System.Drawing.Point(47, 110);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(65, 12);
            this.lblMode.TabIndex = 1;
            this.lblMode.Text = "查询方式：";
            // 
            // cboLayer
            // 
            this.cboLayer.AccessibleDescription = "MapControl中的图层名称";
            this.cboLayer.FormattingEnabled = true;
            this.cboLayer.Location = new System.Drawing.Point(111, 34);
            this.cboLayer.Name = "cboLayer";
            this.cboLayer.Size = new System.Drawing.Size(121, 20);
            this.cboLayer.TabIndex = 2;
            // 
            // cboMode
            // 
            this.cboMode.AccessibleDescription = "空间查询的方式";
            this.cboMode.FormattingEnabled = true;
            this.cboMode.Location = new System.Drawing.Point(111, 102);
            this.cboMode.Name = "cboMode";
            this.cboMode.Size = new System.Drawing.Size(121, 20);
            this.cboMode.TabIndex = 3;
            // 
            // btnOk
            // 
            this.btnOk.AccessibleDescription = "确定查询按钮";
            this.btnOk.Location = new System.Drawing.Point(49, 188);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleDescription = "取消查询按钮";
            this.btnCancel.Location = new System.Drawing.Point(157, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // SpatialQueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.cboMode);
            this.Controls.Add(this.cboLayer);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.lblLayer);
            this.Name = "SpatialQueryForm";
            this.Text = "SpatialQueryForm";
            this.Load += new System.EventHandler(this.SpatialQueryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLayer;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ComboBox cboLayer;
        private System.Windows.Forms.ComboBox cboMode;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}