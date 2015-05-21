using CaptainHook;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MultiClip
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			NotifyIcon nid = new NotifyIcon();
			nid.ContextMenu = BuildContextMenu();
			nid.Text = "MultiClip";
			nid.Icon = Properties.Resources.MultiClip;
			nid.Visible = true;

			popup = new ClipboardPopup();

			HookManager hkmgr = new HookManager();
			hkmgr.KeyDown += hkmgr_KeyDown;
			hkmgr.KeyUp += hkmgr_KeyUp;

			hkmgr.Start();

			Application.Run();

			nid.Visible = false;
		}

		private static ContextMenu BuildContextMenu()
		{
			ContextMenu cmnu = new ContextMenu();
			cmnu.MenuItems.Add("&About MultiClip", delegate(object sender, EventArgs e)
			{
				MessageBox.Show("Developed by Mike Becker", "About MultiClp", MessageBoxButtons.OK, MessageBoxIcon.Information);
			});
			cmnu.MenuItems.Add("-");
			cmnu.MenuItems.Add("E&xit", delegate(object sender, EventArgs e)
			{
				Application.Exit();
			});
			return cmnu;
		}

		static List<string> list = new List<string>();
		static ClipboardPopup popup = null;

		private static void ShowPopup()
		{
			popup.lv.Items.Clear();
			foreach (string item in list)
			{
				popup.lv.Items.Add(item);
			}
			popup.Location = CenterIn(System.Windows.Forms.Cursor.Position, popup.ClientRectangle);
			popup.Show();
		}

		private static System.Drawing.Point CenterIn(System.Drawing.Point pt, System.Drawing.Rectangle rectangle)
		{
			int x = 0, y = 0;
			x = pt.X - (rectangle.Width / 2);
			y = pt.Y - (rectangle.Height / 2);
			return new System.Drawing.Point(x, y);
		}

		static void hkmgr_KeyDown(object sender, KeyboardEventArgs e)
		{
			if (e.HasModifierKey(ModifierKeys.Control) && e.KeyCode == KeyboardKey.V)
			{
				ShowPopup();
			}
		}
		static void hkmgr_KeyUp(object sender, KeyboardEventArgs e)
		{
			if (e.HasModifierKey(ModifierKeys.Control))
			{
				if (e.KeyCode == KeyboardKey.X || e.KeyCode == KeyboardKey.C)
				{
					string data = Clipboard.GetText();
					if (String.IsNullOrEmpty(data)) return;

					ClipboardCommentDialog dlg = new ClipboardCommentDialog();
					dlg.Location = CenterIn(System.Windows.Forms.Cursor.Position, dlg.ClientRectangle);
					if (dlg.ShowDialog() == DialogResult.OK)
					{

						list.Add(data);
						Clipboard.Clear();
					}
				}
			}
			if (e.KeyCode == KeyboardKey.Escape)
			{
				popup.Hide();
			}
		}
	}
}
