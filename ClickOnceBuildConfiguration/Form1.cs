using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClickOnceBuildConfiguration
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

#if DEBUG
			label1.Text = "Debug";
#else
			label1.Text = "Release";
#endif
		}
	}
}
