using CodilityProject.Bussiness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodilityProject
{
	public partial class MainForm : Form
	{
		public MainForm()
		{


			InitializeComponent();
		}

		private void txtvalue_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
			{
				e.Handled = true;
			}
											   
			if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
			{
				e.Handled = true;
			}
		}

		private void btnCalc_Click(object sender, EventArgs e)
		{
			if (txtvalue.Text == "")
			{
				lblSonuc.Text = "Lütfen Rakam belirtiniz.";
			}
			else
			{																					    
				lblSonuc.Text = Dollars.ConvertNumberToText(Convert.ToDecimal(txtvalue.Text)).ToString();

			}
		}

		private void btntrcalc_Click(object sender, EventArgs e)
		{
			if (txtvalue.Text == "")
			{
				lblSonuc.Text = "Lütfen Rakam belirtiniz.";
			}
			else
			{
				lblSonuc.Text = TurkishLiras.ConvertNumberToText(Convert.ToDecimal(txtvalue.Text));

			}
		}

		private void btnTRTtoN_Click(object sender, EventArgs e)
		{
			if (txtvalue_TtoN.Text == "")
			{
				lblSonuc_TtoN.Text = "Lütfen Yazı belirtiniz.";
			}
			else
			{
				lblSonuc_TtoN.Text = TurkishLiras.ConvertTextToNumber(txtvalue_TtoN.Text).ToString();

			}
		}

		private void btnDollarTtoN_Click(object sender, EventArgs e)
		{
			if (txtvalue_TtoN.Text == "")
			{
				lblSonuc_TtoN.Text = "Lütfen Yazı belirtiniz.";
			}
			else
			{
				lblSonuc_TtoN.Text = Dollars.ConvertTextToNumber(txtvalue_TtoN.Text).ToString();

			}
		}
	}
}
