using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lfy_ChangeColor
{
    public partial class Ctl_ColorChange: UserControl
    {		
        public Ctl_ColorChange()
        {
            InitializeComponent();
        }
		public Ctl_ColorChange(string str)
		{
			
			InitializeComponent();
			this.Ctl_Lbl.Text = str;
		}
		
	     private void ColorChange_Click(object sender, EventArgs e)
		{
			if (((Ctl_ColorChange)sender).BackColor == Color.Red)
			{ ((Ctl_ColorChange)sender).BackColor = Color.Yellow; }
			else if (((Ctl_ColorChange)sender).BackColor == Color.Yellow)
			{ ((Ctl_ColorChange)sender).BackColor = Color.Green; }
			else
			{ ((Ctl_ColorChange)sender).BackColor = Color.Red; }
		}

		private void Ctl_ColorChange_Load(object sender, EventArgs e)
		{

		}
	}
}
