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
    public partial class FormulaForm : Telerik.WinControls.UI.RadForm
    {
        private Formula formula;
        private FormulaBLL formulaBLL;
        
        public FormulaForm()
        {
            formula = new Formula();
            formulaBLL = new FormulaBLL();
            InitializeComponent();
        }
        private void NumClick(string number)
        {
            if (String.IsNullOrEmpty(txtValue.Text))
                txtValue.Text += number;
            else
            {
                var value = txtValue.Text.Substring((txtValue.Text.Length-1),1);
                if (value == "t" || value == "e" || value == "h" || value == "y")
                    return;
                else
                    txtValue.Text += number;
            }
        }

        private void InitiateData()
        {
            var list = formulaBLL.GetAll();
            radGridView1.DataSource = list;
        }
        private void OpClick(string operand)
        {
            var value = "";
            if (!String.IsNullOrEmpty(txtValue.Text))
            {
                value = txtValue.Text.Substring((txtValue.Text.Length - 1), 1);
            }
           
                if (value == "+" || value == "-" || value == "*" || value == "/" || value == ".")
                    return;
                else
                    txtValue.Text += operand;

            
        }

        private void WordClick(string word)
        {
            if (String.IsNullOrEmpty(txtValue.Text))
                txtValue.Text += word;
            else
            {
                var value = txtValue.Text.Substring((txtValue.Text.Length - 1), 1);
                if (value == "0" || value == "1" || value == "2" || value == "3" || value == "4" || value == "5" || value == "6" || value == "7" || value == "8" || value == "9" || value == "t" || value == "h" || value == "e" || value == "y")
                    return;
                else
                    txtValue.Text += word;
            }
        }

        private void BraceClick(string brace)
        {
            if (String.IsNullOrEmpty(txtValue.Text))
                txtValue.Text += brace;
            else
            {
                var value = txtValue.Text.Substring((txtValue.Text.Length - 1), 1);
                if (brace == "(" && (value == "0" || value == "1" || value == "2" || value == "3" || value == "4" || value == "5" || value == "6" || value == "7" || value == "8" || value == "9" || value == ")" || value == "t" || value == "h" || value == "e" || value == "y"))
                    return;
                else if (brace == ")" && (value == "("))
                    return;
                else
                    txtValue.Text += brace;

            }
        }
        private void radPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void radPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            NumClick("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            NumClick("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            NumClick("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            NumClick("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            NumClick("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            NumClick("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            NumClick("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            NumClick("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            NumClick("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            NumClick("0");
        }

        private void btnWidth_Click(object sender, EventArgs e)
        {
            WordClick("Width");
        }

        private void btnHeight_Click(object sender, EventArgs e)
        {
            WordClick("Height");
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            WordClick("Price");
        }

        private void btnQuantity_Click(object sender, EventArgs e)
        {
            WordClick("Quantity");
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            OpClick("+");
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            OpClick("-");
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            OpClick("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            OpClick("/");
        }

        private void btnLeftBracket_Click(object sender, EventArgs e)
        {
            OpClick("(");
        }

        private void btnRightBracket_Click(object sender, EventArgs e)
        {
            OpClick(")");
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            OpClick(".");
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtValue.Text = "";
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtValue.Text))
            {
                txtValue.Text = txtValue.Text.Substring(0, (txtValue.Text.Length - 1));
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtValue.Text))
            {
                formula.FormulaType = txtValue.Text;
                formula.InsertBy = 1;

                if(formulaBLL.Insert(formula))
                {
                    MessageBox.Show("Formula inserted successfully!");
                    InitiateData();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }
            }

        }

        private void FormulaForm_Load(object sender, EventArgs e)
        {
            InitiateData();
        }

        private void radGridView1_CellDoubleClick(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            int rowindex = e.RowIndex;
            formula = (Formula)radGridView1.Rows[rowindex].DataBoundItem;
            if (formula != null)
            {
                lblID.Text = formula.FormulaID.ToString();
                txtValue.Text = formula.FormulaType;

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(txtValue.Text))
            {
                formula.FormulaType = txtValue.Text;
                formula.LUB = 1;
                if(formulaBLL.Update(formula))
                {
                    MessageBox.Show("Formula updated successfully!");
                    InitiateData();
                    Clear();
                }
                else
                {
                    MessageBox.Show("Something went wrong!");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(lblID.Text))
            {
                if (MessageBox.Show("Are you sure you want to delete this?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    formulaBLL.Delete(int.Parse(lblID.Text));
                    InitiateData();
                    Clear();
                }

            }
        }

        private void Clear()
        {
            txtValue.Text = "";
            lblID.Text = "";
        }
    }
}
