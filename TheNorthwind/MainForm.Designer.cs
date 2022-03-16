﻿
namespace TheNorthwind
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.kategorilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewCat = new System.Windows.Forms.ToolStripMenuItem();
            this.AllCat = new System.Windows.Forms.ToolStripMenuItem();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewProd = new System.Windows.Forms.ToolStripMenuItem();
            this.AllProd = new System.Windows.Forms.ToolStripMenuItem();
            this.siparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.AllOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.meunItemNewCategoryAndProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kategorilerToolStripMenuItem,
            this.ürünlerToolStripMenuItem,
            this.siparişlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(698, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // kategorilerToolStripMenuItem
            // 
            this.kategorilerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewCat,
            this.AllCat});
            this.kategorilerToolStripMenuItem.Name = "kategorilerToolStripMenuItem";
            this.kategorilerToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.kategorilerToolStripMenuItem.Text = "Kategoriler";
            // 
            // NewCat
            // 
            this.NewCat.Name = "NewCat";
            this.NewCat.Size = new System.Drawing.Size(199, 26);
            this.NewCat.Text = "Yeni Kategori";
            this.NewCat.Click += new System.EventHandler(this.NewCat_Click);
            // 
            // AllCat
            // 
            this.AllCat.Name = "AllCat";
            this.AllCat.Size = new System.Drawing.Size(199, 26);
            this.AllCat.Text = "Tüm Kategoriler";
            this.AllCat.Click += new System.EventHandler(this.AllCat_Click);
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewProd,
            this.AllProd,
            this.meunItemNewCategoryAndProduct});
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // NewProd
            // 
            this.NewProd.Name = "NewProd";
            this.NewProd.Size = new System.Drawing.Size(234, 26);
            this.NewProd.Text = "Yeni Ürün";
            this.NewProd.Click += new System.EventHandler(this.NewProd_Click);
            // 
            // AllProd
            // 
            this.AllProd.Name = "AllProd";
            this.AllProd.Size = new System.Drawing.Size(234, 26);
            this.AllProd.Text = "Tüm Ürünler";
            this.AllProd.Click += new System.EventHandler(this.AllProd_Click);
            // 
            // siparişlerToolStripMenuItem
            // 
            this.siparişlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewOrder,
            this.AllOrder});
            this.siparişlerToolStripMenuItem.Name = "siparişlerToolStripMenuItem";
            this.siparişlerToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.siparişlerToolStripMenuItem.Text = "Siparişler";
            // 
            // NewOrder
            // 
            this.NewOrder.Name = "NewOrder";
            this.NewOrder.Size = new System.Drawing.Size(186, 26);
            this.NewOrder.Text = "Yeni Sipariş";
            this.NewOrder.Click += new System.EventHandler(this.NewOrder_Click);
            // 
            // AllOrder
            // 
            this.AllOrder.Name = "AllOrder";
            this.AllOrder.Size = new System.Drawing.Size(186, 26);
            this.AllOrder.Text = "Tüm Siparişler";
            this.AllOrder.Click += new System.EventHandler(this.AllOrder_Click);
            // 
            // meunItemNewCategoryAndProduct
            // 
            this.meunItemNewCategoryAndProduct.Name = "meunItemNewCategoryAndProduct";
            this.meunItemNewCategoryAndProduct.Size = new System.Drawing.Size(234, 26);
            this.meunItemNewCategoryAndProduct.Text = "Yeni Kategori ve Ürün";
            this.meunItemNewCategoryAndProduct.Click += new System.EventHandler(this.meunItemNewCategoryAndProduct_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 561);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem kategorilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewCat;
        private System.Windows.Forms.ToolStripMenuItem AllCat;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewProd;
        private System.Windows.Forms.ToolStripMenuItem AllProd;
        private System.Windows.Forms.ToolStripMenuItem siparişlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NewOrder;
        private System.Windows.Forms.ToolStripMenuItem AllOrder;
        private System.Windows.Forms.ToolStripMenuItem meunItemNewCategoryAndProduct;
    }
}

