﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
	public partial class Form1 : Form
	{
		ICalculate calculate;
		public Form1()
		{
			calculate = new Calculator();
			InitializeComponent();
		}

		

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void btnplus_Click(object sender, EventArgs e)
		{
			if(check())
			{
				calculate.plus((int)numberone.Value, (int)numbertow.Value);
			}
			bool check()
			{
				bool isvalid = true;
				if (numberone.Value == 0)
				{
					isvalid = false;
					MessageBox.Show("Please Enter Number One");
				}
				if (numbertow.Value == 0)
				{
					isvalid = false;
					MessageBox.Show("Please Enter Number Two");
				}
				return isvalid;
			}
		}
	}
}
