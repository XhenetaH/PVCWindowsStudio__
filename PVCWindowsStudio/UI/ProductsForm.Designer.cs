﻿namespace PVCWindowsStudio.UI
{
    partial class ProductsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsForm));
            Telerik.WinControls.UI.GridViewImageColumn gridViewImageColumn1 = new Telerik.WinControls.UI.GridViewImageColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            Telerik.WinControls.UI.RadValidationRule radValidationRule1 = new Telerik.WinControls.UI.RadValidationRule();
            this.txtName = new Telerik.WinControls.UI.RadTextBox();
            this.productGridView = new Telerik.WinControls.UI.RadGridView();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel5 = new Telerik.WinControls.UI.RadPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.btnRemove = new Telerik.WinControls.UI.RadButton();
            this.btnAdd = new Telerik.WinControls.UI.RadButton();
            this.productPictureBox = new Telerik.WinControls.UI.RadPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescription = new Telerik.WinControls.UI.RadTextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.btnClear = new Telerik.WinControls.UI.RadButton();
            this.btnDelete = new Telerik.WinControls.UI.RadButton();
            this.btnUpdate = new Telerik.WinControls.UI.RadButton();
            this.btnSave = new Telerik.WinControls.UI.RadButton();
            this.radValidationProvider1 = new Telerik.WinControls.UI.RadValidationProvider(this.components);
            this.materialBlueGreyTheme1 = new Telerik.WinControls.Themes.MaterialBlueGreyTheme();
            this.helpBtn = new System.Windows.Forms.PictureBox();
            this.btnAmerican = new System.Windows.Forms.PictureBox();
            this.btnAlbania = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).BeginInit();
            this.radPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radValidationProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAmerican)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlbania)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            resources.ApplyResources(this.txtName, "txtName");
            this.txtName.Name = "txtName";
            this.txtName.ThemeName = "MaterialBlueGrey";
            this.radValidationProvider1.SetValidationRule(this.txtName, radValidationRule1);
            // 
            // productGridView
            // 
            this.productGridView.BackColor = System.Drawing.Color.White;
            this.productGridView.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.productGridView, "productGridView");
            this.productGridView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            // 
            // 
            // 
            this.productGridView.MasterTemplate.AllowAddNewRow = false;
            this.productGridView.MasterTemplate.AllowDeleteRow = false;
            this.productGridView.MasterTemplate.AllowEditRow = false;
            this.productGridView.MasterTemplate.AllowSearchRow = true;
            this.productGridView.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewImageColumn1.EnableExpressionEditor = false;
            gridViewImageColumn1.FieldName = "Picture";
            resources.ApplyResources(gridViewImageColumn1, "gridViewImageColumn1");
            gridViewImageColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            gridViewImageColumn1.MinWidth = 6;
            gridViewImageColumn1.Name = "Picture";
            gridViewImageColumn1.Width = 205;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Name";
            resources.ApplyResources(gridViewTextBoxColumn1, "gridViewTextBoxColumn1");
            gridViewTextBoxColumn1.MinWidth = 6;
            gridViewTextBoxColumn1.Name = "Name";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 211;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Other";
            resources.ApplyResources(gridViewTextBoxColumn2, "gridViewTextBoxColumn2");
            gridViewTextBoxColumn2.MinWidth = 6;
            gridViewTextBoxColumn2.Name = "Other";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn2.Width = 220;
            this.productGridView.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewImageColumn1,
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2});
            this.productGridView.MasterTemplate.EnablePaging = true;
            this.productGridView.MasterTemplate.PageSize = 10;
            this.productGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.productGridView.Name = "productGridView";
            this.productGridView.ThemeName = "MaterialBlueGrey";
            this.productGridView.CellClick += new Telerik.WinControls.UI.GridViewCellEventHandler(this.productGridView_CellClick);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.productGridView);
            resources.ApplyResources(this.radPanel2, "radPanel2");
            this.radPanel2.Name = "radPanel2";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radPanel5);
            this.radPanel1.Controls.Add(this.radPanel4);
            resources.ApplyResources(this.radPanel1, "radPanel1");
            this.radPanel1.Name = "radPanel1";
            // 
            // radPanel5
            // 
            this.radPanel5.Controls.Add(this.helpBtn);
            this.radPanel5.Controls.Add(this.btnAmerican);
            this.radPanel5.Controls.Add(this.btnAlbania);
            this.radPanel5.Controls.Add(this.lblID);
            this.radPanel5.Controls.Add(this.btnRemove);
            this.radPanel5.Controls.Add(this.btnAdd);
            this.radPanel5.Controls.Add(this.productPictureBox);
            this.radPanel5.Controls.Add(this.label2);
            this.radPanel5.Controls.Add(this.txtDescription);
            this.radPanel5.Controls.Add(this.lblUserName);
            this.radPanel5.Controls.Add(this.txtName);
            resources.ApplyResources(this.radPanel5, "radPanel5");
            this.radPanel5.Name = "radPanel5";
            this.radPanel5.ThemeName = "MaterialBlueGrey";
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // btnRemove
            // 
            resources.ApplyResources(this.btnRemove, "btnRemove");
            this.btnRemove.Image = global::PVCWindowsStudio.Properties.Resources.minus__2_1;
            this.btnRemove.Name = "btnRemove";
            // 
            // 
            // 
            this.btnRemove.RootElement.EnableFocusBorderAnimation = false;
            this.btnRemove.ThemeName = "MaterialBlueGrey";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Image = global::PVCWindowsStudio.Properties.Resources.plus__4_1;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.ThemeName = "MaterialBlueGrey";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // productPictureBox
            // 
            resources.ApplyResources(this.productPictureBox, "productPictureBox");
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.ShowBorder = true;
            this.productPictureBox.SvgImageXml = null;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtDescription
            // 
            resources.ApplyResources(this.txtDescription, "txtDescription");
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            // 
            // 
            // 
            this.txtDescription.RootElement.StretchVertically = true;
            this.txtDescription.ThemeName = "MaterialBlueGrey";
            this.radValidationProvider1.SetValidationRule(this.txtDescription, null);
            // 
            // lblUserName
            // 
            resources.ApplyResources(this.lblUserName, "lblUserName");
            this.lblUserName.Name = "lblUserName";
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.btnClear);
            this.radPanel4.Controls.Add(this.btnDelete);
            this.radPanel4.Controls.Add(this.btnUpdate);
            this.radPanel4.Controls.Add(this.btnSave);
            resources.ApplyResources(this.radPanel4, "radPanel4");
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.ThemeName = "MaterialBlueGrey";
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImage = global::PVCWindowsStudio.Properties.Resources.plus__1_;
            resources.ApplyResources(this.btnClear, "btnClear");
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnClear.Image = global::PVCWindowsStudio.Properties.Resources.eraser__1_;
            this.btnClear.Name = "btnClear";
            this.btnClear.ThemeName = "MaterialBlueGrey";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnClear.GetChildAt(0))).Image = global::PVCWindowsStudio.Properties.Resources.eraser__1_;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnClear.GetChildAt(0))).Text = resources.GetString("resource.Text");
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnClear.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnClear.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnClear.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnClear.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment")));
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::PVCWindowsStudio.Properties.Resources.plus__1_;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnDelete.Image = global::PVCWindowsStudio.Properties.Resources.trash;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ThemeName = "MaterialBlueGrey";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnDelete.GetChildAt(0))).Image = global::PVCWindowsStudio.Properties.Resources.trash;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnDelete.GetChildAt(0))).Text = resources.GetString("resource.Text1");
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnDelete.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment1")));
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackgroundImage = global::PVCWindowsStudio.Properties.Resources.plus__1_;
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnUpdate.Image = global::PVCWindowsStudio.Properties.Resources.pencil;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.ThemeName = "MaterialBlueGrey";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnUpdate.GetChildAt(0))).Image = global::PVCWindowsStudio.Properties.Resources.pencil;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnUpdate.GetChildAt(0))).Text = resources.GetString("resource.Text2");
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnUpdate.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnUpdate.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnUpdate.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnUpdate.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment2")));
            // 
            // btnSave
            // 
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.BackgroundImage = global::PVCWindowsStudio.Properties.Resources.plus__1_;
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnSave.Image = global::PVCWindowsStudio.Properties.Resources.plus__3_;
            this.btnSave.Name = "btnSave";
            this.btnSave.ThemeName = "MaterialBlueGrey";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Image = global::PVCWindowsStudio.Properties.Resources.plus__3_;
            ((Telerik.WinControls.UI.RadButtonElement)(this.btnSave.GetChildAt(0))).Text = resources.GetString("resource.Text3");
            ((Telerik.WinControls.Primitives.ImagePrimitive)(this.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(0))).ImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(1))).LineLimit = false;
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            ((Telerik.WinControls.Primitives.TextPrimitive)(this.btnSave.GetChildAt(0).GetChildAt(1).GetChildAt(1))).Alignment = ((System.Drawing.ContentAlignment)(resources.GetObject("resource.Alignment3")));
            // 
            // radValidationProvider1
            // 
            this.radValidationProvider1.ValidationMode = Telerik.WinControls.UI.ValidationMode.Programmatically;
            radValidationRule1.Controls.Add(this.txtName);
            radValidationRule1.Operator = Telerik.WinControls.Data.FilterOperator.IsNotLike;
            radValidationRule1.ToolTipText = "Name can\'t be empty!";
            radValidationRule1.Value = "";
            this.radValidationProvider1.ValidationRules.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            radValidationRule1});
            // 
            // helpBtn
            // 
            this.helpBtn.Image = global::PVCWindowsStudio.Properties.Resources.information__1_;
            resources.ApplyResources(this.helpBtn, "helpBtn");
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.TabStop = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // btnAmerican
            // 
            this.btnAmerican.Image = global::PVCWindowsStudio.Properties.Resources.united_states__1_;
            resources.ApplyResources(this.btnAmerican, "btnAmerican");
            this.btnAmerican.Name = "btnAmerican";
            this.btnAmerican.TabStop = false;
            this.btnAmerican.Click += new System.EventHandler(this.btnAmerican_Click);
            // 
            // btnAlbania
            // 
            this.btnAlbania.Image = global::PVCWindowsStudio.Properties.Resources.albania__1_;
            resources.ApplyResources(this.btnAlbania, "btnAlbania");
            this.btnAlbania.Name = "btnAlbania";
            this.btnAlbania.TabStop = false;
            this.btnAlbania.Click += new System.EventHandler(this.btnAlbania_Click_1);
            // 
            // ProductsForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.ThemeName = "MaterialBlueGrey";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).EndInit();
            this.radPanel5.ResumeLayout(false);
            this.radPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDelete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radValidationProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.helpBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAmerican)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAlbania)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Telerik.WinControls.UI.RadGridView productGridView;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel5;
        private Telerik.WinControls.UI.RadButton btnAdd;
        private Telerik.WinControls.UI.RadPictureBox productPictureBox;
        private System.Windows.Forms.Label label2;
        private Telerik.WinControls.UI.RadTextBox txtDescription;
        private System.Windows.Forms.Label lblUserName;
        private Telerik.WinControls.UI.RadTextBox txtName;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private Telerik.WinControls.UI.RadButton btnClear;
        private Telerik.WinControls.UI.RadButton btnDelete;
        private Telerik.WinControls.UI.RadButton btnUpdate;
        private Telerik.WinControls.UI.RadButton btnSave;
        private Telerik.WinControls.UI.RadButton btnRemove;
        private Telerik.WinControls.UI.RadValidationProvider radValidationProvider1;
        private Telerik.WinControls.Themes.MaterialBlueGreyTheme materialBlueGreyTheme1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.PictureBox helpBtn;
        private System.Windows.Forms.PictureBox btnAmerican;
        private System.Windows.Forms.PictureBox btnAlbania;
    }
}
