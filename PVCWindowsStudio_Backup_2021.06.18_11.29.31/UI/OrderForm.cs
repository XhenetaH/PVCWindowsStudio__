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
    public partial class OrderForm : Telerik.WinControls.UI.RadForm
    {
        private OrderBLL orderBll;
        private Orders order;
        private ClientBLL clientBll;
        public OrderForm()
        {
            clientBll = new ClientBLL();
            orderBll = new OrderBLL();
            order = new Orders();
            InitializeComponent();
        }

     

        private void OrderForm_Load(object sender, EventArgs e)
        {
            InitiateData();
            clientMultiComboBox.DataSource = clientBll.GetName();
            clientMultiComboBox.SelectedIndex = -1;
            clientMultiComboBox.AutoCompleteMode = AutoCompleteMode.Append;           
            clientMultiComboBox.Text = "Choose a client";
            discountCmb.SelectedIndex = 1;
        }

        
        private void InitiateData()
        {
            orderGridView.DataSource = orderBll.GetAll();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void radMultiColumnComboBox1_EditorControl_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            lblClientID.Text = clientMultiComboBox.EditorControl.Rows[rowindex].Cells["ClientID"].Value.ToString();
        }

        private void MasterTemplate_CellClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            order = (Orders)orderGridView.Rows[rowindex].DataBoundItem;
            if (order != null)
            {
                lblID.Text = order.OrderID.ToString();
                clientMultiComboBox.SelectedValue = order.ClientID;
                clientMultiComboBox.Text = order.Clients.FullName;
                radDateTimePicker1.Value = order.Date;
                txtDiscount.Text = order.Discount.ToString();
                discountCmb.Text = order.DiscountType;
                if (order.DiscountType == "%")
                    discountCmb.SelectedValue = 0;
                else
                    discountCmb.SelectedValue = 1;
                txtComment.Text = order.Comment;
                lblClientID.Text = order.ClientID.ToString();
            }
        }
        private void Clear()
        {
            clientMultiComboBox.Text = "Choose a client";
            discountCmb.SelectedIndex = 1;

            lblID.Text = "";
            lblClientID.Text = "";
            radDateTimePicker1.Value = DateTime.Now;
            txtDiscount.Text = "";
            txtComment.Text = "";
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                decimal discount = order.Discount;
                decimal actualDiscount = Convert.ToDecimal(txtDiscount.Text);
                order.OrderID = int.Parse(lblID.Text);
                order.ClientID = int.Parse(lblClientID.Text);
                order.Date = radDateTimePicker1.Value;
                order.Discount = Convert.ToDecimal(txtDiscount.Text);
                order.DiscountType = discountCmb.Text;
                order.Comment = txtComment.Text;
                if (discount < actualDiscount)
                {
                    if (discountCmb.SelectedIndex == 1)
                        order.TotalPrice =Math.Round(order.TotalPrice - actualDiscount);
                    else
                        order.TotalPrice =Math.Round(order.TotalPrice - ((actualDiscount / 100) * order.TotalPrice));
                }
                else
                {
                    if (discountCmb.SelectedIndex == 1)                    
                        order.TotalPrice = Math.Round(order.TotalPrice + discount);                    
                    else
                        order.TotalPrice = Math.Round(order.TotalPrice + ((discount / 100) * order.TotalPrice));
                }
                order.LUB = 1;

                if (orderBll.Update(order))
                {
                    MessageBox.Show("Order updated successfully!");
                    InitiateData();
                    Clear();
                }
                else
                    MessageBox.Show("Something went wrong!");
            }
            else
                MessageBox.Show("Please select an order!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (orderBll.DeleteAll(int.Parse(lblID.Text)))
                    {
                        MessageBox.Show("Order deleted successfully!");
                        InitiateData();
                        Clear();
                    }
                    else
                        MessageBox.Show("Something went wrong!");
                }
            }
            else
                MessageBox.Show("Please select an order!");
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            ReportViewerForm1 report = new ReportViewerForm1();
            report.Show();
            var objectDataSource = new Telerik.Reporting.ObjectDataSource();
            
        }
    }
}
