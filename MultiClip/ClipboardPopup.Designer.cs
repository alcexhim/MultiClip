namespace MultiClip
{
	partial class ClipboardPopup
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.lv = new System.Windows.Forms.ListView();
			this.chContent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// lv
			// 
			this.lv.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chContent});
			this.lv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lv.FullRowSelect = true;
			this.lv.GridLines = true;
			this.lv.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
			this.lv.HideSelection = false;
			this.lv.Location = new System.Drawing.Point(0, 0);
			this.lv.Name = "lv";
			this.lv.Size = new System.Drawing.Size(358, 168);
			this.lv.TabIndex = 0;
			this.lv.UseCompatibleStateImageBehavior = false;
			this.lv.View = System.Windows.Forms.View.Details;
			this.lv.ItemActivate += new System.EventHandler(this.lv_ItemActivate);
			// 
			// chContent
			// 
			this.chContent.Text = "Content";
			this.chContent.Width = 337;
			// 
			// ClipboardPopup
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(358, 168);
			this.ControlBox = false;
			this.Controls.Add(this.lv);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ClipboardPopup";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.TopMost = true;
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ColumnHeader chContent;
		internal System.Windows.Forms.ListView lv;
	}
}

