
namespace TheNorthwind.Products
{
    partial class ProductGridForm
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
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grdProductGridForm = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DeleteProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateProduct = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductGridForm)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(112, 33);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(477, 27);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.UseWaitCursor = true;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı: ";
            this.label1.UseWaitCursor = true;
            // 
            // grdProductGridForm
            // 
            this.grdProductGridForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductGridForm.Location = new System.Drawing.Point(14, 107);
            this.grdProductGridForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdProductGridForm.MultiSelect = false;
            this.grdProductGridForm.Name = "grdProductGridForm";
            this.grdProductGridForm.RowHeadersWidth = 51;
            this.grdProductGridForm.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.grdProductGridForm.RowTemplate.Height = 25;
            this.grdProductGridForm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdProductGridForm.Size = new System.Drawing.Size(873, 489);
            this.grdProductGridForm.TabIndex = 2;
            this.grdProductGridForm.UseWaitCursor = true;
            this.grdProductGridForm.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdProductGridForm_CellMouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteProduct,
            this.UpdateProduct});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(136, 52);
            // 
            // DeleteProduct
            // 
            this.DeleteProduct.Name = "DeleteProduct";
            this.DeleteProduct.Size = new System.Drawing.Size(135, 24);
            this.DeleteProduct.Text = "Sil";
            this.DeleteProduct.Click += new System.EventHandler(this.DeleteProduct_Click);
            // 
            // UpdateProduct
            // 
            this.UpdateProduct.Name = "UpdateProduct";
            this.UpdateProduct.Size = new System.Drawing.Size(135, 24);
            this.UpdateProduct.Text = "Güncelle";
            this.UpdateProduct.Click += new System.EventHandler(this.UpdateProduct_Click);
            // 
            // ProductGridForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 635);
            this.Controls.Add(this.grdProductGridForm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearch);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ProductGridForm";
            this.Text = "ProductGridForm";
            this.Load += new System.EventHandler(this.ProductGridForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdProductGridForm)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdProductGridForm;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem DeleteProduct;
        private System.Windows.Forms.ToolStripMenuItem UpdateProduct;
    }
}