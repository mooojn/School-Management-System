using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.UI.WinForms; 

namespace WindowsFormsApp1
{
	internal class Util
	{
		public static void FixButtonText(Form form)
		{
			foreach (Control c in form.Controls)
			{
				if (c is Bunifu.UI.WinForms.BunifuButton.BunifuButton2 btn)
				{
					btn.TextAlignment = HorizontalAlignment.Center;
				}
			}
		}
	}
}


