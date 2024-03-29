﻿using PVCWindowsStudio.BLL;
using PVCWindowsStudio.BLL.FormModels;
using PVCWindowsStudio.BO;
using PVCWindowsStudio.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;

namespace PVCWindowsStudio.UI
{
    public partial class ProductItemsForm : Telerik.WinControls.UI.RadForm
    {
        private readonly ProductItemsModel productModel;
        public ProductItemsForm()
        {
            productModel = new ProductItemsModel()
            {
                Product = new Products(),
                ProductItems = new ProductItems(),
                MaterialBll = new MaterialBLL(),
                FormulaBll = new FormulaBLL(),
                ProductBLL = new ProductBLL(),
                ProductItemsBll = new ProductItemsBLL()
            };
            InitializeComponent();
        }

        private void InitiateProduct()
        {
            var productList = productModel.ProductBLL.GetAll();
            productsradGridView.DataSource = productList;
            this.productsradGridView.TableElement.RowHeight = 150;

            ddlMaterial.DataSource = productModel.MaterialBll.GetExist();
            ddlMaterial.DisplayMember = "Name";
            ddlMaterial.ValueMember = "MaterialID";

            ddlFormula.DataSource = productModel.FormulaBll.GetAll();
            ddlFormula.DisplayMember = "FormulaType";
            ddlFormula.ValueMember = "FormulaID";

        }
        private void ProductItemsForm_Load(object sender, EventArgs e)
        {
            InitiateProduct();
            RadMessageBox.SetThemeName("MaterialBlueGrey");


        }

        private Image ConvertToImage(byte[] array)
        {
            Image x = (Bitmap)((new ImageConverter()).ConvertFrom(array));
            return x;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (productPictureBox.Image == null)
                RadMessageBox.Show("Picture box can't be empty!");            
            else
            {
                productModel.ProductItems.ProductID = int.Parse(lblproductID.Text);
                productModel.ProductItems.MaterialID = int.Parse(ddlMaterial.SelectedValue.ToString());
                productModel.ProductItems.FormulaID = int.Parse(ddlFormula.SelectedValue.ToString());
                productModel.ProductItems.InsertBy = UserSession.CurrentUser.UserID;

                if (productModel.ProductItemsBll.Insert(productModel.ProductItems))
                {
                    RadMessageBox.Show("Product is inserted successfully!");
                    InitiateProductItems(int.Parse(lblproductID.Text));
                    Clear();
                }
                else RadMessageBox.Show("Something went wrong!");
            }
        }

        private void Clear()
        {
            lblProductItemID.Text = "";
            productPictureBox.Image = null;
            productitemsGridView.Rows.Clear();
        }

        private void InitiateProductItems(int id)
        {
            productitemsGridView.DataSource = productModel.ProductItemsBll.GetAll(id);
                
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblProductItemID.Text))
            {
                if (productPictureBox.Image == null)
                    MessageBox.Show("Picture box can't be empty!");
                else
                {
                    productModel.ProductItems.ProductItemsID = int.Parse(lblProductItemID.Text);
                    productModel.ProductItems.MaterialID = int.Parse(ddlMaterial.SelectedValue.ToString());
                    productModel.ProductItems.ProductID = int.Parse(lblproductID.Text);
                    productModel.ProductItems.FormulaID = int.Parse(ddlFormula.SelectedValue.ToString());
                    productModel.ProductItems.LUB = UserSession.CurrentUser.UserID;

                    if (productModel.ProductItemsBll.Update(productModel.ProductItems))
                    {
                        RadMessageBox.Show("Product Item uppdated successfully!");
                        InitiateProductItems(int.Parse(lblproductID.Text));
                        Clear();

                    }
                    else
                        RadMessageBox.Show("Something went wrong!");

                }
            }
            else RadMessageBox.Show("Please select a product item!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblProductItemID.Text))
            {
                if (RadMessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, RadMessageIcon.Question) == DialogResult.Yes)
                {
                    if (productModel.ProductItemsBll.Delete(int.Parse(lblProductItemID.Text)))
                    {
                        RadMessageBox.Show("Product Item deleted successfully!");
                        InitiateProductItems(int.Parse(lblproductID.Text));
                        Clear();
                    }
                    else
                        RadMessageBox.Show("Shomething went wrong!");
                }

            }
            else RadMessageBox.Show("Please select a product item!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void productsradGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (!rowindex.Equals(-1))
            {
                productModel.Product = (Products)productsradGridView.Rows[rowindex].DataBoundItem;
                if (productModel.Product != null)
                {
                    lblproductID.Text = productModel.Product.ProductID.ToString();
                    if (productModel.Product.Picture?.Length > 0)
                        productPictureBox.Image = ConvertToImage(productModel.Product.Picture);
                    else
                        productPictureBox.Image = null;
                    InitiateProductItems(int.Parse(lblproductID.Text));

                }
            }
        }

        private void productitemsGridView_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            if (!rowindex.Equals(-1))
            {
                productModel.ProductItems = (ProductItems)productitemsGridView.Rows[rowindex].DataBoundItem;
                if (productModel.ProductItems != null)
                {
                    lblProductItemID.Text = productModel.ProductItems.ProductItemsID.ToString();
                    lblproductID.Text = productModel.ProductItems.Products.ProductID.ToString();
                    ddlFormula.SelectedValue = productModel.ProductItems.Formula.FormulaID;
                    ddlFormula.Text = productModel.ProductItems.Formula.FormulaType;
                    ddlMaterial.SelectedValue = productModel.ProductItems.Materials.MaterialID;
                    ddlMaterial.Text = productModel.ProductItems.Materials.Name;
                    if (productModel.ProductItems.Products.Picture?.Length > 0)
                        productPictureBox.Image = ConvertToImage(productModel.ProductItems.Products.Picture);
                    else
                        productPictureBox.Image = null;

                }
            }
        }

        private void btnAddFormula_Click(object sender, EventArgs e)
        {
            FormulaForm frm = new FormulaForm();
            frm.FormBorderStyle = FormBorderStyle.Sizable;
            frm.Show();
        }

        

        private void helpBtn_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Users\\Lenovo\\Documents\\My HelpAndManual Projects\\NewProject.chm", HelpNavigator.Topic, "ProductItems.htm");

        }

        private void btnAmerican_Click(object sender, EventArgs e)
        {
            ChangeLanguage change = new ChangeLanguage();
            change.UpdateConfig("language", "en");
            Application.Restart();
        }

        private void btnAlbania_Click_1(object sender, EventArgs e)
        {
            ChangeLanguage change = new ChangeLanguage();
            change.UpdateConfig("language", "sq");
            Application.Restart();
        }
    }
}
