using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MultiClip
{
	public partial class ClipboardPopup : Form
	{
		public ClipboardPopup()
		{
			InitializeComponent();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			base.OnClosing(e);
			e.Cancel = true;
			Hide();
		}

		private void ClosePopupWindow()
		{
			string data = lv.SelectedItems[0].Text;

			Hide();

			Clipboard.SetText(data);

			CaptainHook.HookManager.Enabled = false;
			SendKeys.Send("^v");
			CaptainHook.HookManager.Enabled = true;

			System.Threading.Thread.Sleep(500);

			Clipboard.Clear();
		}

		private void lv_ItemActivate(object sender, EventArgs e)
		{
			ClosePopupWindow();
		}
	}
}
