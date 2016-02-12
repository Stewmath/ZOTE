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
	public partial class Form1 : Form
	{
		GBHL.GBFile gb;
		TextLoader tl;
		string fname = "";
		frmSearch fSearch;
		frmDictionary fDictionary;

		public Form1(string filename)
		{
			InitializeComponent();
			if (filename != "")
				LoadROM(filename);
		}

		void setBles(bool b)
		{
			panel1.Enabled = b;
			saveToolStripMenuItem.Enabled = b;
			searchWordToolStripMenuItem.Enabled = b;
			dumpDictionaryToolStripMenuItem.Enabled = b;
			dicToolStripMenuItem.Enabled = b;
			if (!b)
			{
				fSearch = null;
				fDictionary = null;
			}
		}

		private void openROMToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog o = new OpenFileDialog();
			o.Title = "Open ROM";
			o.Filter = "All Supported Types|*.gbc;*.bin";
			if (o.ShowDialog() != DialogResult.OK)
				return;
			LoadROM(o.FileName);
		}

		private void LoadROM(string file)
		{
			try
			{
				BinaryReader br = new BinaryReader(File.OpenRead(file));
				byte[] buffer = br.ReadBytes((int)br.BaseStream.Length);
				br.Close();
				gb = new GBHL.GBFile(buffer);
				fname = file;
			}
			catch (Exception)
			{
				MessageBox.Show("IO Error.", "Error");
				setBles(false);
			}

			setBles(true);
			tl = new TextLoader(gb);
			panel1.Enabled = true;
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			tl.lastSize = 0;
			rtEdit.Text = tl.getFinalText((int)nLocation.Value);
			//lblSize.Text = "Compressed Size: " + (gb.BufferLocation - (int)nLocation.Value) + " Bytes";
			setText(rtEdit.Text);
		}

		private void setText(string text)
		{
			try
			{
				rtDisplay.Text = "";
				rtDisplay.ForeColor = Color.White;
				rtDisplay.SelectionStart = 0;
				text = text.Replace("\r", "").Replace("\n", "");
				for (int i = 0; i < text.Length; i++)
				{
					char c = text[i];
					if (c == '<') //Tag
					{
						i++;
						c = text[i];
						if (c == 'C') //Color
						{
							i += 4;
							c = text[i++];
							if (c == '0')
								rtDisplay.SelectionColor = Color.White;
							else if (c == '1')
								rtDisplay.SelectionColor = Color.Maroon;
							else if (c == '2')
								rtDisplay.SelectionColor = Color.Orange;
							else if (c == '3')
								rtDisplay.SelectionColor = Color.RoyalBlue;
							else if (c == '4')
								rtDisplay.SelectionColor = Color.Lime;
							else
								rtDisplay.SelectionColor = Color.White;
							continue;
						}
						if (c == 'R') //Ref
						{
							i += 4;
							c = text[i++];
							char bchar = c;
							i++;
							c = text[i++];
							byte r = (byte)Convert.ToInt32(c.ToString(), 16);
							if (text[i] != '>')
							{
								r <<= 4;
								r += (byte)Convert.ToInt32(text[i++].ToString(), 16); //byte.Parse(rtEdit.Text[i++].ToString());
								i++;
							}
							if (bchar == '2')
								rtDisplay.SelectedText += tl.getWordText(2, r, 0x1D);
							else if (bchar == '3')
								rtDisplay.SelectedText += tl.getWordText(3, r, 0x1D);
							else if (bchar == '4')
								rtDisplay.SelectedText += tl.getWordText(4, r, 0x1D);
							else if (bchar == '5')
								rtDisplay.SelectedText += tl.getWordText(5, r, 0x1D);

							if (text[i - 1] == '>')
							{
								i--;
								continue;
							}

							while (i < text.Length && text[i] != '>')
								i++;
							continue;
						}
						else
						{
							while (text[i] != '>')
								i++;
							continue;
						}
					}
					else if (c == '\\')
					{
						i++;
						if (text[i] == 'n')
						{
							rtDisplay.SelectedText = "\r\n";
							continue;
						}
					}
					rtDisplay.SelectedText += c;
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Compile error.", "Error");
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			setText(rtEdit.Text);
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			byte[] buffer = new byte[gb.Buffer.Length];
			Array.Copy(gb.Buffer, buffer, buffer.Length);
			try
			{
				gb.BufferLocation = (int)nLocation.Value;
				for (int i = 0; i < rtEdit.Text.Length; i++)
				{
					char c = rtEdit.Text[i];
					if (c == '<')
					{
						i++;
						c = rtEdit.Text[i];
						if (c == 'C')
						{
							gb.WriteByte(9);
							i += 4;
							c = rtEdit.Text[i++];
							gb.WriteByte(Convert.ToByte(c.ToString(), 16));
							continue;
						}
						if (c == 'S')
						{
							gb.WriteByte(6);
							i += 8;
							c = rtEdit.Text[i++];
							byte b = Convert.ToByte(c.ToString(), 16);
							if (rtEdit.Text[i] != '>')
							{
								b <<= 4;
								c = rtEdit.Text[i++];
								b += Convert.ToByte(c.ToString(), 16);
							}
							gb.WriteByte(b);
							continue;
						}
						if (c == 'V')
						{
							gb.WriteByte(0xA);
							i += 5;
							c = rtEdit.Text[i++];
							byte b = Convert.ToByte(c.ToString(), 16);
							if (rtEdit.Text[i] != '>')
							{
								b <<= 4;
								c = rtEdit.Text[i++];
								b += Convert.ToByte(c.ToString(), 16);
							}
							gb.WriteByte(b);
							continue;
						}
						if (c == 'R')
						{
							i += 4;
							c = rtEdit.Text[i++];
							gb.WriteByte(Convert.ToByte(c.ToString(), 16));
							i++;
							c = rtEdit.Text[i++];
							byte b = Convert.ToByte(c.ToString(), 16);
							if (rtEdit.Text[i] != '>')
							{
								b <<= 4;
								c = rtEdit.Text[i++];
								b += Convert.ToByte(c.ToString(), 16);
							}
							gb.WriteByte(b);
							continue;
						}
						if (c == 'I')
						{
							gb.WriteByte(0xC);
							i += 6;
							c = rtEdit.Text[i++];
							byte b = Convert.ToByte(c.ToString(), 16);
							if (rtEdit.Text[i] != '>')
							{
								b <<= 4;
								c = rtEdit.Text[i++];
								b += Convert.ToByte(c.ToString(), 16);
							}
							gb.WriteByte(b);
							continue;
						}
					}
					else if (c == '\\')
					{
						i++;
						if (rtEdit.Text[i] == 'n')
						{
							gb.WriteByte(1);
						}
						continue;
					}
					else if (c == '#')
					{
						i++;
						if (rtEdit.Text.Substring(i, 4) == "NAME")
						{
							gb.WriteBytes(new byte[] { 0xA, 0 });
							i += 3;
							continue;
						}
						else
						{
							gb.WriteByte(Convert.ToByte(rtEdit.Text[i - 1]));
						}
						continue;
					}

					gb.WriteByte(ASCIIEncoding.ASCII.GetBytes(rtEdit.Text[i].ToString())[0]);
				}
			}
			catch (Exception)
			{
				MessageBox.Show("Error compiling.", "Error");
				gb.Buffer = buffer;
				return;
			}
			gb.WriteByte(0);
			BinaryWriter bw = new BinaryWriter(File.Open(fname, FileMode.OpenOrCreate));
			bw.Write(gb.Buffer);
			bw.Close();
		}

		private void searchWordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (fSearch == null)
				fSearch = new frmSearch(gb);
			if (fSearch.ShowDialog() != DialogResult.OK)
				return;
			int i = fSearch.lstResult.SelectedIndex;
			nLocation.Value = Convert.ToInt32(fSearch.lstResult.Items[i].ToString(), 16);
			button1_Click(null, null);
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			autoFillReferencesToolStripMenuItem.Checked = ZOTE.Properties.Settings.Default.DecompressWord;
		}

		private void autoFillReferencesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ZOTE.Properties.Settings.Default.DecompressWord = autoFillReferencesToolStripMenuItem.Checked;
			ZOTE.Properties.Settings.Default.Save();
		}

		private void forumsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process p = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo ps = new System.Diagnostics.ProcessStartInfo("http://zeldahacking.ulmb.com/index.php");
			p.StartInfo = ps;
			p.Start();
		}

		private void dumpDictionaryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Dictionary d = new Dictionary();
			d.dump(gb, tl);
		}

		private void dicToolStripMenuItem_Click(object sender, EventArgs e)
		{
			for (int i = 2; i < 6; i++)
			{
				if (!File.Exists(Application.StartupPath + "/dictionary" + i.ToString() + ".txt"))
				{
					MessageBox.Show("Missing dictionary " + i.ToString() + ".", "Missing Dictionary");
					return;
				}
			}
			if (fDictionary == null)
				fDictionary = new frmDictionary();
			if (fDictionary.ShowDialog() != DialogResult.OK)
				return;
			string s = fDictionary.listBox1.Items[fDictionary.listBox1.SelectedIndex].ToString();
			char c = s[0];
			byte b = (byte)Convert.ToInt32(s[2].ToString(), 16);
			b <<= 4;
			b += (byte)Convert.ToInt32(s[3].ToString(), 16);
			rtEdit.Text = rtEdit.Text.Insert(rtEdit.SelectionStart, "<REF " + c + " " + b.ToString("X") + ">");
		}
	}
}
