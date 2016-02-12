using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;

namespace ZOTE
{
	public partial class frmSearch : Form
	{
		GBHL.GBFile gb;
		public frmSearch(GBHL.GBFile g)
		{
			gb = g;
			InitializeComponent();
		}

		private void lstResult_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (lstResult.SelectedIndex != -1)
				button2.Enabled = true;
			else
				button1.Enabled = false;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			byte[] bytes = ASCIIEncoding.ASCII.GetBytes(txtSearch.Text);
			lstResult.Items.Clear();
			List<int> addresses = new List<int>();
			gb.BufferLocation = (int)nStart.Value;
			if (bytes.Length == 1)
			{
				for (int i = (int)nStart.Value; i < gb.Buffer.Length; i++)
				{
					if (gb.Buffer[i] == bytes[0])
					{
						addresses.Add(i);
					}
				}
			}
			else
			{
				for (int i = 0; i < gb.Buffer.Length; i++)
				{
					if (gb.Buffer[i] == bytes[0])
					{
						for (int k = 1; k < bytes.Length; k++)
						{
							if (gb.Buffer[i + k] != bytes[k])
								goto EndLoop;
						}
						addresses.Add(i);
					}
				EndLoop:
					continue;
				}
			}

			foreach (int i in addresses)
			{
				gb.BufferLocation = i;
				while (gb.ReadByte() != 0 && gb.BufferLocation > 0)
				{
					gb.BufferLocation -= 2;
				}
				lstResult.Items.Add(gb.BufferLocation.ToString("X"));
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			if (txtSearch.Text.Equals(""))
				button1.Enabled = false;
			else
				button1.Enabled = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (lstResult.SelectedIndex == -1)
				lstResult.SelectedIndex = 0;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void frmSearch_Load(object sender, EventArgs e)
		{
			txtSearch.Focus();
			
		}

		private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter && txtSearch.Text.Length > 0)
			{
				e.Handled = true;
				button1_Click(null, null);
			}
		}

		private void lstResult_DoubleClick(object sender, EventArgs e)
		{
			if(lstResult.Items.Count > 0 && lstResult.SelectedIndex > -1)
				button2_Click(null, null);
		}
	}
}
