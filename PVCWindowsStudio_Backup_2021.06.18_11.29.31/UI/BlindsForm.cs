﻿using PVCWindowsStudio.BLL;
using PVCWindowsStudio.BO;
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
    public partial class BlindsForm : Telerik.WinControls.UI.RadForm
    {
        private Blinds blind;
        private BlindBLL blindBll;
        public BlindsForm()
        {
            blind = new Blinds();
            blindBll = new BlindBLL();
            InitializeComponent();
        }

        private void BlindsForm_Load(object sender, EventArgs e)
        {
            InitiateData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            blind.Name = txtName.Text;
            blind.Other = txtDescription.Text;
            blind.Price = Convert.ToDecimal(txtPrice.Text);
            blind.Color = txtColor.Text;
            blind.InsertBy = 1;
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                if (blindBll.Insert(blind))
                {
                    MessageBox.Show("Blind inserted successfully!");
                    this.radValidationProvider1.Validate(txtName);
                    Clear();
                    InitiateData();
                }
                else
                    MessageBox.Show("Something went wrong!");
            }
            
        }
        private void Clear()
        {
            txtPrice.Text = "";
            txtName.Text = "";
            txtColor.Text = "";
            txtDescription.Text = "";
            lblID.Text = "";
        }
        private void InitiateData()
        {
            var list = blindBll.GetAll();
            blindsGrindView.DataSource = list;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            blind.BlindID = int.Parse(lblID.Text);
            blind.Name = txtName.Text;
            blind.Other = txtDescription.Text;
            blind.Price = Convert.ToDecimal(txtPrice.Text);
            blind.Color = txtColor.Text;
            blind.LUB = 1;
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                blindBll.Update(blind);
            }
            this.radValidationProvider1.Validate(txtName);
            Clear();
            InitiateData();
        }

        private void blindsGrindView_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            blind = (Blinds)blindsGrindView.Rows[rowindex].DataBoundItem;
            if (blind != null)
            {
                lblID.Text = blind.BlindID.ToString();
                txtName.Text = blind.Name;
                txtDescription.Text = blind.Other;
                txtColor.Text = blind.Color;
                txtPrice.Text = blind.Price.ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    blindBll.Delete(int.Parse(lblID.Text));
                    InitiateData();
                    Clear();
                }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
