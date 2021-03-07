using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.IranSystem
{
	public static class IranSystemConvertor
	{
		#region "Tools"

		private static byte CharToByte(string chr)
		{
			return (byte)chr[0];
		}

		private static int CharToCharCode(char chr)
		{
			int pbytCode = System.Convert.ToInt32(chr);
			return pbytCode;
		}

		private static string CharCodeToChar(int chr)
		{
			return ((char)chr).ToString();
		}

		#endregion

		#region "To Unicode"

		public static string ToUnicode(byte[] input, string direction = "rtl")
		{
			StringBuilder text = new StringBuilder();

			foreach (var item in input)
			{
				text.Append((char)item);
			}

			return ToUnicode(text.ToString(), direction);
		}

		public static string ToUnicode(string input)
		{
			return ToUnicode(input, "rtl");
		}

		public static string ToUnicode(string input, string direction = "rtl")
		{
			string generatedString = "";
			int length = input.Length;
			int i = 1;
			string sLeft = "";

			while (i <= length)
			{
				if (direction == "rtl")
				{

					string currentChar = input[i - 1].ToString();

					if (((CharToByte(currentChar) >= 0x80) && (CharToByte(currentChar) <= 0x89)))
					{
						sLeft = sLeft + GetUnicodeChar(currentChar);
					}
					else if (sLeft != "")
					{
						generatedString = GetUnicodeChar(currentChar) + sLeft + generatedString;
						sLeft = "";
					}
					else
						generatedString = GetUnicodeChar(currentChar) + generatedString;
				}
				else
				{
					generatedString = generatedString + GetUnicodeChar(input.Substring(i - 1, 1));
				}

				i += 1;
			}

			if (sLeft != "")
			{
				generatedString = sLeft + generatedString;
			}

			return generatedString.Replace("  ", " ");
		}

		private static string GetUnicodeChar(string IranSystemChar)
		{

			switch (CharToByte(IranSystemChar))
			{
				case 10:
					return "";
				case 11:
				case 12:
				case 14:
				case 15:
				case 0x10:
				case 0x11:
				case 0x12:
				case 0x13:
				case 20:
				case 0x15:
				case 0x16:
				case 0x17:
				case 0x18:
				case 0x19:
				case 0x1A:
				case 0x1B:
				case 0x1C:
				case 0x1D:
				case 30:
				case 0x1F:
				case 0x20:
				case 0x21:
				case 0x22:
				case 0x23:
				case 0x24:
				case 0x25:
				case 0x26:
				case 0x27:
				case 0x2A:
				case 0x2B:
				case 0x2C:
				case 0x2D:
				case 0x2E:
				case 0x2F:
				case 0x30:
				case 0x31:
				case 50:
				case 0x33:
				case 0x34:
				case 0x35:
				case 0x36:
				case 0x37:
				case 0x38:
				case 0x39:
				case 0x3A:
				case 0x3B:
				case 60:
				case 0x3D:
				case 0x3E:
				case 0x3F:
				case 0x40:
				case 0x41:
				case 0x42:
				case 0x43:
				case 0x44:
				case 0x45:
				case 70:
				case 0x47:
				case 0x48:
				case 0x49:
				case 0x4A:
				case 0x4B:
				case 0x4C:
				case 0x4D:
				case 0x4E:
				case 0x4F:
				case 80:
				case 0x51:
				case 0x52:
				case 0x53:
				case 0x54:
				case 0x55:
				case 0x56:
				case 0x57:
				case 0x58:
				case 0x59:
				case 90:
				case 0x5B:
				case 0x5C:
				case 0x5D:
				case 0x5E:
				case 0x5F:
				case 0x60:
				case 0x61:
				case 0x62:
				case 0x63:
				case 100:
				case 0x65:
				case 0x66:
				case 0x67:
				case 0x68:
				case 0x69:
				case 0x6A:
				case 0x6B:
				case 0x6C:
				case 0x6D:
				case 110:
				case 0x6F:
				case 0x70:
				case 0x71:
				case 0x72:
				case 0x73:
				case 0x74:
				case 0x75:
				case 0x76:
				case 0x77:
				case 120:
				case 0x79:
				case 0x7A:
				case 0x7B:
				case 0x7C:
				case 0x7D:
				case 0x7E:
				case 0x7F:
				case 0xB0:
				case 0xB1:
				case 0xB2:
				case 0xB3:
				case 180:
				case 0xB5:
				case 0xB6:
				case 0xB7:
				case 0xB8:
				case 0xB9:
				case 0xBA:
				case 0xBB:
				case 0xBC:
				case 0xBD:
				case 190:
				case 0xBF:
				case 0xC0:
				case 0xC1:
				case 0xC2:
				case 0xC3:
				case 0xC4:
				case 0xC5:
				case 0xC6:
				case 0xC7:
				case 200:
				case 0xC9:
				case 0xCA:
				case 0xCB:
				case 0xCC:
				case 0xCD:
				case 0xCE:
				case 0xCF:
				case 0xD0:
				case 0xD1:
				case 210:
				case 0xD3:
				case 0xD4:
				case 0xD5:
				case 0xD6:
				case 0xD7:
				case 0xD8:
				case 0xD9:
				case 0xDA:
				case 0xDB:
				case 220:
				case 0xDD:
				case 0xDE:
				case 0xDF:
					return IranSystemChar;
				case 13:
					return CharCodeToChar(13) + CharCodeToChar(10);
				case 40:
					return ")";
				case 0x29:
					return "(";
				case 0x80:
					return "0";
				case 0x81:
					return "1";
				case 130:
					return "2";
				case 0x83:
					return "3";
				case 0x84:
					return "4";
				case 0x85:
					return "5";
				case 0x86:
					return "6";
				case 0x87:
					return "7";
				case 0x88:
					return "8";
				case 0x89:
					return "9";
				case 0x8A:
					return CharCodeToChar(1548);
				case 0x8B:
					return CharCodeToChar(1600);
				case 140:
					return CharCodeToChar(1567);
				case 0x8D:
					return CharCodeToChar(1570);
				case 0x8E:
					return CharCodeToChar(1574);
				case 0x8F:
					return CharCodeToChar(1569);
				case 0x90:
					return CharCodeToChar(1575);
				case 0x91:
					return CharCodeToChar(1575);
				case 0x92:
					return CharCodeToChar(1576);
				case 0x93:
					return CharCodeToChar(1576);
				case 0x94:
					return CharCodeToChar(1662);
				case 0x95:
					return CharCodeToChar(1662);
				case 150:
					return CharCodeToChar(1578);
				case 0x97:
					return CharCodeToChar(1578);
				case 0x98:
					return CharCodeToChar(1579);
				case 0x99:
					return CharCodeToChar(1579);
				case 0x9A:
					return CharCodeToChar(1580);
				case 0x9B:
					return CharCodeToChar(1580);
				case 0x9C:
					return CharCodeToChar(1670);
				case 0x9D:
					return CharCodeToChar(1670);
				case 0x9E:
					return CharCodeToChar(1581);
				case 0x9F:
					return CharCodeToChar(1581);
				case 160:
					return CharCodeToChar(1582);
				case 0xA1:
					return CharCodeToChar(1582);
				case 0xA2:
					return CharCodeToChar(1583);
				case 0xA3:
					return CharCodeToChar(1584);
				case 0xA4:
					return CharCodeToChar(1585);
				case 0xA5:
					return CharCodeToChar(1586);
				case 0xA6:
					return CharCodeToChar(1688);
				case 0xA7:
					return CharCodeToChar(1587);
				case 0xA8:
					return CharCodeToChar(1587);
				case 0xA9:
					return CharCodeToChar(1588);
				case 170:
					return CharCodeToChar(1588);
				case 0xAB:
					return CharCodeToChar(1589);
				case 0xAC:
					return CharCodeToChar(1589);
				case 0xAD:
					return CharCodeToChar(1590);
				case 0xAE:
					return CharCodeToChar(1590);
				case 0xAF:
					return CharCodeToChar(1591);
				case 0xE0:
					return CharCodeToChar(1592);
				case 0xE1:
					return CharCodeToChar(1593);
				case 0xE2:
					return CharCodeToChar(1593);
				case 0xE3:
					return CharCodeToChar(1593);
				case 0xE4:
					return CharCodeToChar(1593);
				case 0xE5:
					return CharCodeToChar(1594);
				case 230:
					return CharCodeToChar(1594);
				case 0xE7:
					return CharCodeToChar(1594);
				case 0xE8:
					return CharCodeToChar(1594);
				case 0xE9:
					return CharCodeToChar(1601);
				case 0xEA:
					return CharCodeToChar(1601);
				case 0xEB:
					return CharCodeToChar(1602);
				case 0xEC:
					return CharCodeToChar(1602);
				case 0xED:
					return CharCodeToChar(1705);
				case 0xEE:
					return CharCodeToChar(1705);
				case 0xEF:
					return CharCodeToChar(1711);
				case 240:
					return CharCodeToChar(1711);
				case 0xF1:
					return CharCodeToChar(1604);
				case 0xF2:
					return CharCodeToChar(1604) + CharCodeToChar(1575);
				case 0xF3:
					return CharCodeToChar(1604);
				case 0xF4:
					return CharCodeToChar(1605);
				case 0xF5:
					return CharCodeToChar(1605);
				case 0xF6:
					return CharCodeToChar(1606);
				case 0xF7:
					return CharCodeToChar(1606);
				case 0xF8:
					return CharCodeToChar(1608);
				case 0xF9:
					return CharCodeToChar(1607);
				case 250:
					return CharCodeToChar(1607);
				case 0xFB:
					return CharCodeToChar(1607);
				case 0xFC:
					return CharCodeToChar(1610);
				case 0xFD:
					return CharCodeToChar(1610);
				case 0xFE:
					return CharCodeToChar(1610);
			}
			return IranSystemChar;
		}

		#endregion

		#region "To Iran System"

		static IranSystemConvertor()
		{
			IranSysChars = new IranSystemChars[1741];
			SetChars();
		}

		private static IranSystemChars[] IranSysChars;

		private struct IranSystemChars
		{
			public byte avval;
			public byte vasat;
			public byte akhar;
			public byte tanha;
			public Boolean hasAvval;
			public Boolean hasVasat;
			public Boolean hasAkhar;
			public Boolean hasTanha;
		}

		private static string ConcatByteArray(byte[] byteArray)
		{
			System.Text.StringBuilder ret = new System.Text.StringBuilder(byteArray.Length);
			foreach (byte B in byteArray)
			{
				ret.Append(ToChar(B));
			}
			return ret.ToString();
		}

		private static void SetChars()
		{
			//1570 = آ
			//1575 = ا
			//1576 = ب
			//1662 = پ
			//1578 = ت
			//1579 = ث
			//1580 = ج
			//1670 = چ
			//1581 = ح
			//1582 = خ
			//1583 = د
			//1584 = ذ
			//1585 = ر
			//1586 = ز
			//1688 = ژ
			//1587 = س
			//1588 = ش
			//1589 = ص
			//1590 = ض
			//1591 = ط
			//1592 = ظ
			//1593 = ع
			//1594 = غ
			//1601 = ف
			//1602 = ق
			//1705 = ک
			//1603 = ك
			//1711 = گ
			//1604 = ل
			//1605 = م
			//1606 = ن
			//1608 = و
			//1607 = ه
			//1574 = ئ
			//1740 = ی
			//1609 = ي
			//1610 = ي
			//1569 = ء

			IranSysChars[32].avval = 32;
			IranSysChars[1570].avval = 32;//آ
			IranSysChars[1575].avval = 32;//ا
			IranSysChars[1576].avval = 147;//ب
			IranSysChars[1662].avval = 149;//پ
			IranSysChars[1578].avval = 151;//ت
			IranSysChars[1579].avval = 153;//ث
			IranSysChars[1580].avval = 155;//ج
			IranSysChars[1670].avval = 157;//چ
			IranSysChars[1581].avval = 159;//ح
			IranSysChars[1582].avval = 161;//خ
			IranSysChars[1583].avval = 32;//د
			IranSysChars[1584].avval = 32;//ذ
			IranSysChars[1585].avval = 32;//ر
			IranSysChars[1586].avval = 32;//ز
			IranSysChars[1688].avval = 32;//ژ
			IranSysChars[1587].avval = 168;//س
			IranSysChars[1588].avval = 170;//ش
			IranSysChars[1589].avval = 172;//ص
			IranSysChars[1590].avval = 174;//ض
			IranSysChars[1591].avval = 175;//ط
			IranSysChars[1592].avval = 224;//ظ
			IranSysChars[1593].avval = 228;//ع
			IranSysChars[1594].avval = 232;//غ
			IranSysChars[1601].avval = 234;//ف
			IranSysChars[1602].avval = 236;//ق
			IranSysChars[1705].avval = 238;//ک
			IranSysChars[1603].avval = 238;//ك
			IranSysChars[1711].avval = 240;//گ
			IranSysChars[1604].avval = 243;//ل
			IranSysChars[1605].avval = 245;//م
			IranSysChars[1606].avval = 247;//ن
			IranSysChars[1608].avval = 32;//و
			IranSysChars[1607].avval = 251;//ه
			IranSysChars[1574].avval = 142;//ئ
			IranSysChars[1740].avval = 254;//ی
			IranSysChars[1609].avval = 254;//ي
			IranSysChars[1610].avval = 254;//ي
			IranSysChars[1569].avval = 143;//ء

			IranSysChars[32].hasAvval = false;
			IranSysChars[1570].hasAvval = false;//آ
			IranSysChars[1575].hasAvval = false;//ا
			IranSysChars[1576].hasAvval = true;//ب
			IranSysChars[1662].hasAvval = true;//پ
			IranSysChars[1578].hasAvval = true;//ت
			IranSysChars[1579].hasAvval = true;//ث
			IranSysChars[1580].hasAvval = true;//ج
			IranSysChars[1670].hasAvval = true;//چ
			IranSysChars[1581].hasAvval = true;//ح
			IranSysChars[1582].hasAvval = true;//خ
			IranSysChars[1583].hasAvval = false;//د
			IranSysChars[1584].hasAvval = false;//ذ
			IranSysChars[1585].hasAvval = false;//ر
			IranSysChars[1586].hasAvval = false;//ز
			IranSysChars[1688].hasAvval = false;//ژ
			IranSysChars[1587].hasAvval = true;//س
			IranSysChars[1588].hasAvval = true;//ش
			IranSysChars[1589].hasAvval = true;//ص
			IranSysChars[1590].hasAvval = true;//ض
			IranSysChars[1591].hasAvval = true;//ط
			IranSysChars[1592].hasAvval = true;//ظ
			IranSysChars[1593].hasAvval = true;//ع
			IranSysChars[1594].hasAvval = true;//غ
			IranSysChars[1601].hasAvval = true;//ف
			IranSysChars[1602].hasAvval = true;//ق
			IranSysChars[1705].hasAvval = true;//ک
			IranSysChars[1603].hasAvval = true;//ك
			IranSysChars[1711].hasAvval = true;//گ
			IranSysChars[1604].hasAvval = true;//ل
			IranSysChars[1605].hasAvval = true;//م
			IranSysChars[1606].hasAvval = true;//ن
			IranSysChars[1608].hasAvval = false;//و
			IranSysChars[1607].hasAvval = true;//ه
			IranSysChars[1574].hasAvval = true;//ئ
			IranSysChars[1740].hasAvval = true;//ی
			IranSysChars[1609].hasAvval = true;//ي
			IranSysChars[1610].hasAvval = true;//ي
			IranSysChars[1569].hasAvval = false;//ء

			IranSysChars[32].vasat = 32;
			IranSysChars[1570].vasat = 32;//آ
			IranSysChars[1575].vasat = 32;//ا
			IranSysChars[1576].vasat = 147;//ب
			IranSysChars[1662].vasat = 149;//پ
			IranSysChars[1578].vasat = 151;//ت
			IranSysChars[1579].vasat = 153;//ث
			IranSysChars[1580].vasat = 155;//ج
			IranSysChars[1670].vasat = 157;//چ
			IranSysChars[1581].vasat = 159;//ح
			IranSysChars[1582].vasat = 161;//خ
			IranSysChars[1583].vasat = 32;//د
			IranSysChars[1584].vasat = 32;//ذ
			IranSysChars[1585].vasat = 32;//ر
			IranSysChars[1586].vasat = 32;//ز
			IranSysChars[1688].vasat = 32;//ژ
			IranSysChars[1587].vasat = 168;//س
			IranSysChars[1588].vasat = 170;//ش
			IranSysChars[1589].vasat = 172;//ص
			IranSysChars[1590].vasat = 174;//ض
			IranSysChars[1591].vasat = 175;//ط
			IranSysChars[1592].vasat = 224;//ظ
			IranSysChars[1593].vasat = 227;//ع
			IranSysChars[1594].vasat = 231;//غ
			IranSysChars[1601].vasat = 234;//ف
			IranSysChars[1602].vasat = 236;//ق
			IranSysChars[1705].vasat = 238;//ک
			IranSysChars[1603].vasat = 238;//ك
			IranSysChars[1711].vasat = 240;//گ
			IranSysChars[1604].vasat = 243;//ل
			IranSysChars[1605].vasat = 245;//م
			IranSysChars[1606].vasat = 247;//ن
			IranSysChars[1608].vasat = 32;//و
			IranSysChars[1607].vasat = 250;//ه
			IranSysChars[1574].vasat = 142;//ئ
			IranSysChars[1740].vasat = 254;//ی
			IranSysChars[1609].vasat = 254;//ي
			IranSysChars[1610].vasat = 254;//ي
			IranSysChars[1569].vasat = 143;//ء

			IranSysChars[1570].hasVasat = false;//آ
			IranSysChars[1575].hasVasat = false;//ا
			IranSysChars[1576].hasVasat = true;//ب
			IranSysChars[1662].hasVasat = true;//پ
			IranSysChars[1578].hasVasat = true;//ت
			IranSysChars[1579].hasVasat = true;//ث
			IranSysChars[1580].hasVasat = true;//ج
			IranSysChars[1670].hasVasat = true;//چ
			IranSysChars[1581].hasVasat = true;//ح
			IranSysChars[1582].hasVasat = true;//خ
			IranSysChars[1583].hasVasat = false;//د
			IranSysChars[1584].hasVasat = false;//ذ
			IranSysChars[1585].hasVasat = false;//ر
			IranSysChars[1586].hasVasat = false;//ز
			IranSysChars[1688].hasVasat = false;//ژ
			IranSysChars[1587].hasVasat = true;//س
			IranSysChars[1588].hasVasat = true;//ش
			IranSysChars[1589].hasVasat = true;//ص
			IranSysChars[1590].hasVasat = true;//ض
			IranSysChars[1591].hasVasat = true;//ط
			IranSysChars[1592].hasVasat = true;//ظ
			IranSysChars[1593].hasVasat = true;//ع
			IranSysChars[1594].hasVasat = true;//غ
			IranSysChars[1601].hasVasat = true;//ف
			IranSysChars[1602].hasVasat = true;//ق
			IranSysChars[1705].hasVasat = true;//ک
			IranSysChars[1603].hasVasat = true;//ك
			IranSysChars[1711].hasVasat = true;//گ
			IranSysChars[1604].hasVasat = true;//ل
			IranSysChars[1605].hasVasat = true;//م
			IranSysChars[1606].hasVasat = true;//ن
			IranSysChars[1608].hasVasat = false;//و
			IranSysChars[1607].hasVasat = true;//ه
			IranSysChars[1574].hasVasat = true;//ئ
			IranSysChars[1740].hasVasat = true;//ی
			IranSysChars[1609].hasVasat = true;//ي
			IranSysChars[1610].hasVasat = true;//ي
			IranSysChars[1569].hasVasat = false;//ء

			IranSysChars[32].akhar = 32;
			IranSysChars[1570].akhar = 145;//آ
			IranSysChars[1575].akhar = 145;//ا
			IranSysChars[1576].akhar = 146;//ب
			IranSysChars[1662].akhar = 148;//پ
			IranSysChars[1578].akhar = 150;//ت
			IranSysChars[1579].akhar = 152;//ث
			IranSysChars[1580].akhar = 154;//ج
			IranSysChars[1670].akhar = 156;//چ
			IranSysChars[1581].akhar = 158;//ح
			IranSysChars[1582].akhar = 160;//خ
			IranSysChars[1583].akhar = 162;//د
			IranSysChars[1584].akhar = 163;//ذ
			IranSysChars[1585].akhar = 164;//ر
			IranSysChars[1586].akhar = 165;//ز
			IranSysChars[1688].akhar = 166;//ژ
			IranSysChars[1587].akhar = 167;//س
			IranSysChars[1588].akhar = 169;//ش
			IranSysChars[1589].akhar = 171;//ص
			IranSysChars[1590].akhar = 173;//ض
			IranSysChars[1591].akhar = 175;//ط
			IranSysChars[1592].akhar = 224;//ظ
			IranSysChars[1593].akhar = 226;//ع
			IranSysChars[1594].akhar = 230;//غ
			IranSysChars[1601].akhar = 233;//ف
			IranSysChars[1602].akhar = 235;//ق
			IranSysChars[1705].akhar = 237;//ک
			IranSysChars[1603].akhar = 237;//ك
			IranSysChars[1711].akhar = 239;//گ
			IranSysChars[1604].akhar = 241;//ل
			IranSysChars[1605].akhar = 244;//م
			IranSysChars[1606].akhar = 246;//ن
			IranSysChars[1608].akhar = 248;//و
			IranSysChars[1607].akhar = 249;//ه
			IranSysChars[1574].akhar = 252;//ئ
			IranSysChars[1740].akhar = 252;//ی
			IranSysChars[1609].akhar = 252;//ي
			IranSysChars[1610].akhar = 252;//ي
			IranSysChars[1569].akhar = 143;//ء

			IranSysChars[1570].hasAkhar = true;//آ
			IranSysChars[1575].hasAkhar = true;//ا
			IranSysChars[1576].hasAkhar = true;//ب
			IranSysChars[1662].hasAkhar = true;//پ
			IranSysChars[1578].hasAkhar = true;//ت
			IranSysChars[1579].hasAkhar = true;//ث
			IranSysChars[1580].hasAkhar = true;//ج
			IranSysChars[1670].hasAkhar = true;//چ
			IranSysChars[1581].hasAkhar = true;//ح
			IranSysChars[1582].hasAkhar = true;//خ
			IranSysChars[1583].hasAkhar = true;//د
			IranSysChars[1584].hasAkhar = true;//ذ
			IranSysChars[1585].hasAkhar = true;//ر
			IranSysChars[1586].hasAkhar = true;//ز
			IranSysChars[1688].hasAkhar = true;//ژ
			IranSysChars[1587].hasAkhar = true;//س
			IranSysChars[1588].hasAkhar = true;//ش
			IranSysChars[1589].hasAkhar = true;//ص
			IranSysChars[1590].hasAkhar = true;//ض
			IranSysChars[1591].hasAkhar = true;//ط
			IranSysChars[1592].hasAkhar = true;//ظ
			IranSysChars[1593].hasAkhar = true;//ع
			IranSysChars[1594].hasAkhar = true;//غ
			IranSysChars[1601].hasAkhar = true;//ف
			IranSysChars[1602].hasAkhar = true;//ق
			IranSysChars[1705].hasAkhar = true;//ک
			IranSysChars[1603].hasAkhar = true;//ك
			IranSysChars[1711].hasAkhar = true;//گ
			IranSysChars[1604].hasAkhar = true;//ل
			IranSysChars[1605].hasAkhar = true;//م
			IranSysChars[1606].hasAkhar = true;//ن
			IranSysChars[1608].hasAkhar = true;//و
			IranSysChars[1607].hasAkhar = true;//ه
			IranSysChars[1574].hasAkhar = true;//ئ
			IranSysChars[1740].hasAkhar = true;//ی
			IranSysChars[1609].hasAkhar = true;//ي
			IranSysChars[1610].hasAkhar = true;//ي
			IranSysChars[1569].hasAkhar = false;//ء

			IranSysChars[32].tanha = 32;
			IranSysChars[1570].tanha = 141;//آ
			IranSysChars[1575].tanha = 144;//ا
			IranSysChars[1576].tanha = 146;//ب
			IranSysChars[1662].tanha = 148;//پ
			IranSysChars[1578].tanha = 150;//ت
			IranSysChars[1579].tanha = 152;//ث
			IranSysChars[1580].tanha = 154;//ج
			IranSysChars[1670].tanha = 156;//چ
			IranSysChars[1581].tanha = 158;//ح
			IranSysChars[1582].tanha = 160;//خ
			IranSysChars[1583].tanha = 162;//د
			IranSysChars[1584].tanha = 163;//ذ
			IranSysChars[1585].tanha = 164;//ر
			IranSysChars[1586].tanha = 165;//ز
			IranSysChars[1688].tanha = 166;//ژ
			IranSysChars[1587].tanha = 167;//س
			IranSysChars[1588].tanha = 169;//ش
			IranSysChars[1589].tanha = 171;//ص
			IranSysChars[1590].tanha = 173;//ض
			IranSysChars[1591].tanha = 175;//ط
			IranSysChars[1592].tanha = 224;//ظ
			IranSysChars[1593].tanha = 225;//ع
			IranSysChars[1594].tanha = 229;//غ
			IranSysChars[1601].tanha = 233;//ف
			IranSysChars[1602].tanha = 235;//ق
			IranSysChars[1705].tanha = 237;//ک
			IranSysChars[1603].tanha = 237;//ك
			IranSysChars[1711].tanha = 239;//گ
			IranSysChars[1604].tanha = 241;//ل
			IranSysChars[1605].tanha = 244;//م
			IranSysChars[1606].tanha = 246;//ن
			IranSysChars[1608].tanha = 248;//و
			IranSysChars[1607].tanha = 249;//ه
			IranSysChars[1574].tanha = 253;//ئ
			IranSysChars[1740].tanha = 253;//ی
			IranSysChars[1609].tanha = 253;//ي
			IranSysChars[1610].tanha = 253;//ي
			IranSysChars[1569].tanha = 143;//ء

			IranSysChars[1570].hasTanha = true;//آ
			IranSysChars[1575].hasTanha = true;//ا
			IranSysChars[1576].hasTanha = true;//ب
			IranSysChars[1662].hasTanha = true;//پ
			IranSysChars[1578].hasTanha = true;//ت
			IranSysChars[1579].hasTanha = true;//ث
			IranSysChars[1580].hasTanha = true;//ج
			IranSysChars[1670].hasTanha = true;//چ
			IranSysChars[1581].hasTanha = true;//ح
			IranSysChars[1582].hasTanha = true;//خ
			IranSysChars[1583].hasTanha = true;//د
			IranSysChars[1584].hasTanha = true;//ذ
			IranSysChars[1585].hasTanha = true;//ر
			IranSysChars[1586].hasTanha = true;//ز
			IranSysChars[1688].hasTanha = true;//ژ
			IranSysChars[1587].hasTanha = true;//س
			IranSysChars[1588].hasTanha = true;//ش
			IranSysChars[1589].hasTanha = true;//ص
			IranSysChars[1590].hasTanha = true;//ض
			IranSysChars[1591].hasTanha = true;//ط
			IranSysChars[1592].hasTanha = true;//ظ
			IranSysChars[1593].hasTanha = true;//ع
			IranSysChars[1594].hasTanha = true;//غ
			IranSysChars[1601].hasTanha = true;//ف
			IranSysChars[1602].hasTanha = true;//ق
			IranSysChars[1705].hasTanha = true;//ک
			IranSysChars[1603].hasTanha = true;//ك
			IranSysChars[1711].hasTanha = true;//گ
			IranSysChars[1604].hasTanha = true;//ل
			IranSysChars[1605].hasTanha = true;//م
			IranSysChars[1606].hasTanha = true;//ن
			IranSysChars[1608].hasTanha = true;//و
			IranSysChars[1607].hasTanha = true;//ه
			IranSysChars[1574].hasTanha = true;//ئ
			IranSysChars[1740].hasTanha = true;//ی
			IranSysChars[1609].hasTanha = true;//ي
			IranSysChars[1610].hasTanha = true;//ي
			IranSysChars[1569].hasTanha = true;//ء
		}



		public static string ToIranSystemString(string input)
		{
			return ConcatByteArray(ToIranSystem(input));
		}

		public static char ToChar(int CharCode)
		{
			char ch;
			if ((CharCode < -32768) || (CharCode > 0xffff))
			{
				throw new ArgumentException(string.Format("Utils.GetResourceString(\"Argument_RangeTwoBytes1\", \"{0}\")", CharCode));
			}
			if ((CharCode >= 0) && (CharCode <= 0x7f))
			{
				return Convert.ToChar(CharCode);
			}
			try
			{
				int num;
				System.Text.Encoding encoding = System.Text.Encoding.GetEncoding(0/*Utils.GetLocaleCodePage()*/);
				if ((encoding.GetMaxByteCount(1) == 1) && ((CharCode < 0) || (CharCode > 0xff)))
				{
					throw new Exception("ExceptionUtils.VbMakeException(5)");
				}
				char[] chars = new char[2];
				byte[] bytes = new byte[2];
				System.Text.Decoder decoder = encoding.GetDecoder();
				if ((CharCode >= 0) && (CharCode <= 0xff))
				{
					bytes[0] = (byte)(CharCode & 0xff);
					num = decoder.GetChars(bytes, 0, 1, chars, 0);
				}
				else
				{
					bytes[0] = (byte)((CharCode & 0xff00) / 0x100);
					bytes[1] = (byte)(CharCode & 0xff);
					num = decoder.GetChars(bytes, 0, 2, chars, 0);
				}
				ch = chars[0];
			}
			catch (Exception exception)
			{
				throw exception;
			}
			return ch;
		}

		public static Byte[] ToIranSystem(string input)
		{
			int i;
			List<byte> Output = new List<byte>();

			Output.Add(32);
			Output.Add(32);

			input = "  " + input;

			for (i = 2; i <= input.Length - 1; i++)
			{
				int currentASC = CharToCharCode(input[i]);

				IranSystemChars prevCharInfo;

				try
				{
					prevCharInfo = IranSysChars[CharToCharCode(input[i - 1])];
				}
				catch
				{
					prevCharInfo = IranSysChars[32];
				}

				IranSystemChars prevPrevCharInfo;
				try
				{
					prevPrevCharInfo = IranSysChars[CharToCharCode(input[i - 2])];
				}
				catch
				{
					prevPrevCharInfo = IranSysChars[32];
				}

				IranSystemChars currentCharInfo;
				try
				{
					currentCharInfo = IranSysChars[currentASC];
				}
				catch
				{
					currentCharInfo = IranSysChars[32];
				}

				Boolean prevMichasbe = prevCharInfo.hasVasat || prevCharInfo.hasAvval;

				if (currentCharInfo.hasAkhar && prevMichasbe)
				{
					Output.RemoveAt(Output.Count - 1);

					if (prevPrevCharInfo.hasVasat || prevPrevCharInfo.hasAvval)
					{
						Output.Add(prevCharInfo.vasat);
					}
					else
					{
						Output.Add(prevCharInfo.avval);
					}
				}

				if (currentASC < 128)
				{
					Output.Add((byte)currentASC);
				}
				else
				{
					if (prevMichasbe)
					{
						Output.Add(currentCharInfo.akhar);
					}
					else
					{
						Output.Add(currentCharInfo.tanha);
					}
				}
			}

			Output.RemoveAt(0);
			Output.RemoveAt(0);
			Output.Reverse();

			return Output.ToArray();
		}

		#endregion
	}
}