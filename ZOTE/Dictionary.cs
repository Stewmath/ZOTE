using System;
using System.Collections.Generic;
using System.Text;
using GBHL;
using System.IO;

namespace ZOTE
{
	public class Dictionary
	{
		public void dump(GBFile gb, TextLoader tl)
		{
			byte bank = 0x1D;
			for (int i = 2; i < 6; i++)
			{
				switch (i)
				{
					case 02:
						gb.BufferLocation = bank * 0x4000 + 0x1ED8;
						break;
					case 03:
						gb.BufferLocation = bank * 0x4000 + 0x2928;
						break;
					case 04:
						gb.BufferLocation = bank * 0x4000 + 0x30C1;
						break;
					case 05:
						gb.BufferLocation = bank * 0x4000 + 0x3781;
						break;
				}
				StreamWriter sw = new StreamWriter(File.Open(System.Windows.Forms.Application.StartupPath + "/dictionary" + i + ".txt", FileMode.OpenOrCreate));
				for (int k = 0; k < 256; k++)
				{
					string s = k.ToString("X");
					if (s.Length == 1)
						s = "0" + s;
					sw.WriteLine(s + " = " + tl.getFinalText(gb.BufferLocation));
				}
				sw.Close();
			}
		}
	}
}
