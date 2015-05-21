using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MultiClip
{
	public partial class ClipboardCommentDialog : Form
	{
		public ClipboardCommentDialog()
		{
			InitializeComponent();
			Font = SystemFonts.MenuFont;
		}

		private void cmdOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		private void cmdCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}
	}
}
