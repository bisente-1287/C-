/*
 * Created by SharpDevelop.
 * User: CC2_PC13
 * Date: 23/10/2026
 * Time: 07:32 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Multiplica
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnCalcularClick(object sender, EventArgs e)
		{
			double n1, n2,resul;
			n1=Convert.ToDouble(txtNum1.Text);
			n2=Convert.ToDouble(txtNum2.Text);
			resul=n1*n2;
			MessageBox.Show("Resultado de la multiplicacion: "+resul);
			
			
		}
	}
}
