using System;
using System.Collections.Generic;

using System.Text;
using GBHL;

namespace ZOTE
{
	public class TextLoader
	{
		GBFile gb;
		public int lastSize = 0;

		public TextLoader(GBFile g)
		{
			gb = g;
		}

		public void getTextLocations(int bank)
		{

		}

		public string getFinalText(int location)
		{
			gb.BufferLocation = location;
			byte bank = 0x1D;
			string s = "";
			while (true)
			{
				byte b = gb.ReadByte();
				lastSize++;

				if (b < 0x10)
				{
					switch (b)
					{
						case 0:
							{
								/*if (gb.ReadByte() == 0xF)
								{
									gb.BufferLocation++;
									lastSize += 2;
									break;
								}*/
								return s;
							}

						case 1:
							s += "\\n";
							break;
						case 2:
						case 3:
						case 4:
						case 5:
							if (ZOTE.Properties.Settings.Default.DecompressWord)
							{
								int i = gb.BufferLocation;
								s += getWordText(b, gb.ReadByte(), bank);
								gb.BufferLocation = i + 1;
								lastSize++;
							}
							else
							{
								s += "<REF " + b + " " + gb.ReadByte().ToString("X") + ">";
							}
							break;

						case 6:
							s += "<SPECIAL " + gb.ReadByte().ToString("X") + ">";
							lastSize++;
							break;

						case 7:
							s += "<REF 7 " + gb.ReadByte().ToString("X") + ">";
							lastSize++;
							break;

						case 8:
							s += "<REF 8 " + gb.ReadByte().ToString("X") + ">";
							lastSize++;
							break;

						case 9:
							s += "<COL " + gb.ReadByte().ToString("X") + ">";
							lastSize++;
							break;

						case 0xA:
							byte bb = gb.ReadByte();
							lastSize++;
							if (bb == 0)
								s += "#NAME";
							else
								s += "<VCHK " + bb.ToString("X") + ">";
							break;

						case 0xC:
							s += "<INPUT " + gb.ReadByte().ToString("X") + ">";
							lastSize++;
							break;

						case 0xF:
							s += "<RESUME " + gb.ReadByte().ToString("X") + ">";
							lastSize++;
							break;
					}
				}
				else
				{
					s += Convert.ToChar(b);
				}
			}
		}

		public int getWordLocation(int group, string word)
		{
			return -1;
		}

		public string getWordText(int group, int id, int bank)
		{
			switch (group)
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

			gb.BufferLocation = getWordLocation(gb.BufferLocation, id);
			return getFinalText(gb.BufferLocation);
		}

		private int getWordLocation(int baseLocation, int word)
		{
			gb.BufferLocation = baseLocation;
			int i = 0;
			while (i != word)
			{
				byte b = gb.ReadByte();
				if (b < 0x10)
				{
					if (b == 0)
					{
						i++;
					}
					else if(b != 1)
						gb.BufferLocation++;
				}
			}

			return gb.BufferLocation;
		}
	}
}
