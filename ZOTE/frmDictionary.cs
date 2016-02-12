using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ZOTE
{
	public partial class frmDictionary : Form
	{
		string[] dictionary;
		public frmDictionary()
		{
			InitializeComponent();
			dictionary = new string[4];
			for (int i = 2; i < 6; i++)
			{
				StreamReader sr = new StreamReader(File.OpenRead(Application.StartupPath + "/dictionary" + i.ToString() + ".txt"));
				dictionary[i - 2] = sr.ReadToEnd();
				sr.Close();
			}
		}

		private void txtSearch_TextChanged(object sender, EventArgs e)
		{
			button1.Enabled = (txtSearch.Text != "");
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			button3.Enabled = (listBox1.SelectedIndex != -1);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			listBox1.Items.Clear();
			for (int i = 2; i < 6; i++)
			{
				string[] words = dictionary[i - 2].Split('\n');
				int k = 0;
				foreach (string s in words)
				{
					if (s.Contains(txtSearch.Text))
					{
						string ks = k.ToString("X");
						if (ks.Length == 1)
							ks = "0" + ks;
						listBox1.Items.Add(i.ToString() + " " + ks + " - " + s.Substring(5, s.Length - 6));
					}
					k++;
				}
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if(listBox1.SelectedIndex == -1)
				listBox1.SelectedIndex = 0;
			this.DialogResult = DialogResult.OK;
			this.Close();
		}

		private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == (char)Keys.Enter && txtSearch.Text != "")
			{
				e.Handled = true;
				button1_Click(null, null);
			}
		}

		private void listBox1_DoubleClick(object sender, EventArgs e)
		{
			if (listBox1.SelectedIndex != -1)
				button3_Click(null, null);
		}
	}
}
