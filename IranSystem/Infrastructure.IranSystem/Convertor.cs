using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.IranSystem
{
	public class Convertor
	{
		static List<IranSystemCharacter> Mapping = new List<IranSystemCharacter>()
		{
			new IranSystemCharacter{UniCode=1776,IranSystemCode=128 },//۰
			new IranSystemCharacter{UniCode=1777,IranSystemCode=129 },//۱
			new IranSystemCharacter{UniCode=1778,IranSystemCode=130 },//۲
			new IranSystemCharacter{UniCode=1779,IranSystemCode=131 },//۳
			new IranSystemCharacter{UniCode=1780,IranSystemCode=132 },//۴
			new IranSystemCharacter{UniCode=1781,IranSystemCode=133 },//۵
			new IranSystemCharacter{UniCode=1782,IranSystemCode=134 },//۶
			new IranSystemCharacter{UniCode=1783,IranSystemCode=135 },//۷
			new IranSystemCharacter{UniCode=1784,IranSystemCode=136 },//۸
			new IranSystemCharacter{UniCode=1785,IranSystemCode=137 },//۹
			new IranSystemCharacter{UniCode=1548,IranSystemCode=138 },//،
			new IranSystemCharacter{UniCode=45,  IranSystemCode=139 },//-
			new IranSystemCharacter{UniCode=1567,IranSystemCode=140 },//؟
			new IranSystemCharacter{UniCode=1570,IranSystemCode=141},//ﺁ
			new IranSystemCharacter{UniCode=1574,IranSystemCode=142 },//ئ
			new IranSystemCharacter{ UniCode=1569, IranSystemCode=143 },//ﺀ

			new IranSystemCharacter{UniCode=1575,IranSystemCode=144,Status=CharStatus.First },//ﺍ
			new IranSystemCharacter{UniCode=1575,IranSystemCode=145 ,Status=CharStatus.LastSticked},//ﺎ
			new IranSystemCharacter{UniCode=1576,IranSystemCode=146 ,Status=CharStatus.LastSticked},//ﺏ‡
			new IranSystemCharacter{UniCode=1576,IranSystemCode=147,Status=CharStatus.Midlle },//ﺑ†
			new IranSystemCharacter{UniCode=1662,IranSystemCode=148 ,Status=CharStatus.LastSticked},//ﭖ‡
			new IranSystemCharacter{UniCode=1662,IranSystemCode=149 ,Status=CharStatus.Midlle},//ﭘ†
			new IranSystemCharacter{UniCode=1578,IranSystemCode=150,Status=CharStatus.LastSticked },//ﺕ‡
			new IranSystemCharacter{UniCode=1578,IranSystemCode=151 ,Status=CharStatus.Midlle},//ﺗ†
			new IranSystemCharacter{UniCode=1579,IranSystemCode=152,Status=CharStatus.LastSticked },//ﺙ‡
			new IranSystemCharacter{UniCode=1579,IranSystemCode=153 ,Status=CharStatus.Midlle},//ﺛ†
			new IranSystemCharacter{UniCode=1580,IranSystemCode=154 ,Status=CharStatus.LastSticked},//ﺝ‡
			new IranSystemCharacter{UniCode=1580,IranSystemCode=155,Status=CharStatus.Midlle },//ﺟ†
			new IranSystemCharacter{UniCode=1670,IranSystemCode=156 ,Status=CharStatus.LastSticked},//ﭺ‡
			new IranSystemCharacter{UniCode=1670,IranSystemCode=157 ,Status=CharStatus.Midlle},//ﭼ†
			new IranSystemCharacter{UniCode=1581,IranSystemCode=158 ,Status=CharStatus.LastSticked},//ﺡ‡
			new IranSystemCharacter{ UniCode=1581,IranSystemCode= 159 ,Status=CharStatus.Midlle},//ﺣ†

			new IranSystemCharacter{UniCode=1582,IranSystemCode=160 ,Status=CharStatus.LastSticked},//ﺥ‡
			new IranSystemCharacter{UniCode=1582,IranSystemCode=161 ,Status=CharStatus.Midlle},//ﺧ†
			new IranSystemCharacter{UniCode=1583,IranSystemCode=162 },//ﺩ‡
			new IranSystemCharacter{UniCode=1584,IranSystemCode=163 },//ﺫ‡
			new IranSystemCharacter{UniCode=1585,IranSystemCode=164 },//ﺭ‡
			new IranSystemCharacter{UniCode=1586,IranSystemCode=165 },//ﺯ‡
			new IranSystemCharacter{UniCode=1688,IranSystemCode=166 },//ﮊ‡
			new IranSystemCharacter{UniCode=1587,IranSystemCode=167 ,Status=CharStatus.LastSticked},//ﺱ‡
			new IranSystemCharacter{UniCode=1587,IranSystemCode=168 ,Status=CharStatus.Midlle},//ﺳ†
			new IranSystemCharacter{UniCode=1588,IranSystemCode=169 ,Status=CharStatus.LastSticked},//ﺵ‡
			new IranSystemCharacter{UniCode=1588,IranSystemCode=170 ,Status=CharStatus.Midlle},//ﺷ†
			new IranSystemCharacter{UniCode=1589,IranSystemCode=171 ,Status=CharStatus.LastSticked},//ﺹ‡
			new IranSystemCharacter{UniCode=1589,IranSystemCode=172 ,Status=CharStatus.Midlle},//ﺻ†
			new IranSystemCharacter{UniCode=1590,IranSystemCode=173 ,Status=CharStatus.LastSticked},//ﺽ‡
			new IranSystemCharacter{UniCode=1590,IranSystemCode=174 ,Status=CharStatus.Midlle},//ﺿ†
			new IranSystemCharacter{ UniCode= 1591,IranSystemCode=175 },//ﻁ*

			new IranSystemCharacter{UniCode=1592,IranSystemCode=224 },//ﻅ*
			new IranSystemCharacter{UniCode=1593,IranSystemCode=225 ,Status=CharStatus.LastSeparate},//ﻉ
			new IranSystemCharacter{UniCode=1593,IranSystemCode=226 ,Status=CharStatus.LastSticked},//ﻊ
			new IranSystemCharacter{UniCode=1593,IranSystemCode=227 ,Status=CharStatus.Midlle},//ﻌ
			new IranSystemCharacter{UniCode=1593,IranSystemCode=228 ,Status=CharStatus.First},//ﻋ
			new IranSystemCharacter{UniCode=1594,IranSystemCode=229 ,Status=CharStatus.LastSeparate},//ﻍ
			new IranSystemCharacter{UniCode=1594,IranSystemCode=230 ,Status=CharStatus.LastSticked},//ﻎ
			new IranSystemCharacter{UniCode=1594,IranSystemCode=231 ,Status=CharStatus.Midlle},//ﻐ
			new IranSystemCharacter{UniCode=1594,IranSystemCode=232 ,Status=CharStatus.First },//ﻏ
			new IranSystemCharacter{UniCode=1601,IranSystemCode=233 ,Status=CharStatus.LastSticked},//ﻑ‡
			new IranSystemCharacter{UniCode=1601,IranSystemCode=234 ,Status=CharStatus.Midlle},//ﻓ†
			new IranSystemCharacter{UniCode=1602,IranSystemCode=235 ,Status=CharStatus.LastSticked},//ﻕ‡
			new IranSystemCharacter{UniCode=1602,IranSystemCode=236 ,Status=CharStatus.Midlle},//ﻗ†
			new IranSystemCharacter{UniCode=1705,IranSystemCode=237 ,Status=CharStatus.LastSticked},//ﮎ‡
			new IranSystemCharacter{UniCode=1705,IranSystemCode=238 ,Status=CharStatus.Midlle},//ﮐ†
			new IranSystemCharacter{ UniCode=1711, IranSystemCode=239 ,Status=CharStatus.LastSticked},//ﮒ‡

			new IranSystemCharacter{UniCode=1711,IranSystemCode=240,Status=CharStatus.Midlle },//ﮔ†
			new IranSystemCharacter{ UniCode=1604, IranSystemCode=241 ,Status=CharStatus.LastSticked},//ﻝ‡
			//new IranSystem{65152,242 },//ﻻ
			new IranSystemCharacter{UniCode=1604,IranSystemCode=243 ,Status=CharStatus.Midlle},//ﻟ†
			new IranSystemCharacter{UniCode=1605,IranSystemCode=244 ,Status=CharStatus.LastSticked},//ﻡ‡
			new IranSystemCharacter{UniCode=1605,IranSystemCode=245 ,Status=CharStatus.Midlle},//ﻣ†
			new IranSystemCharacter{UniCode=1606,IranSystemCode=246 ,Status=CharStatus.LastSticked},//ﻥ‡
			new IranSystemCharacter{UniCode=1606,IranSystemCode=247,Status=CharStatus.Midlle },//ﻧ†
			new IranSystemCharacter{UniCode=1608,IranSystemCode=248 },//ﻭ‡
			new IranSystemCharacter{UniCode=1607,IranSystemCode=249 ,Status=CharStatus.LastSeparate},//ﻩ‡
			new IranSystemCharacter{UniCode=1607,IranSystemCode=250 ,Status=CharStatus.Midlle},//ﻬ
			new IranSystemCharacter{UniCode=1607,IranSystemCode=251 ,Status=CharStatus.First},//ﻫ
			new IranSystemCharacter{UniCode=1740,IranSystemCode=252 ,Status=CharStatus.LastSticked},//ﯽ
			new IranSystemCharacter{UniCode=1740,IranSystemCode=253 ,Status=CharStatus.LastSeparate},//ﯼ
			new IranSystemCharacter{UniCode=1740,IranSystemCode=254 ,Status=CharStatus.Midlle},//ﯾ†
			new IranSystemCharacter{ UniCode=32,IranSystemCode= 255 },//NBSP
		};

		//First Characters
		static int[] lastStickedMiddleChars = new int[] { 1576, 1662, 1578, 1579, 1580, 1670, 1581, 1582, 1587,
													1588, 1589, 1590, 1591, 1601, 1602,
													1705, 1711, 1604, 1605, 1606};

		static int[] firstLastSticked = new int[] { 1575 };
		static int[] firstMidlleLastSeparate = new int[] { 1607 };
		static int[] midlleLastSeparateLastSticked = new int[] { 1740 };
		static int[] firstMidlleLastStickedLastSeparate = new int[] { 1594, 1593 };

		static int[] separatorChars = new int[] {  1776, 1777, 1778, 1779, 1780, 1781, 1782, 1783,
													1784, 1785, 1548, 1567, 1570, 1574, 1569};

		public static string GetString(byte[] iranSystem)
		{
			char[] uniCode = new char[iranSystem.Length];

			for (int i = 0; i < iranSystem.Length; i++)
			{
				if (iranSystem[i] < 128)
				{
					uniCode[i] = (char)iranSystem[i];
				}
				else
				{
					uniCode[i] = (char)Mapping.Single(character => character.IranSystemCode == iranSystem[i]).UniCode;
				}
			}

			return new string(uniCode);
		}

		public static byte[] GetByte(string unicode)
		{
			byte[] iranSystemMessage = new byte[unicode.Length];
			int previousChar;
			int nextChar;

			for (int i = 0; i < unicode.Length; i++)
			{
				if (unicode[i] < 128)
				{
					iranSystemMessage[i] = (byte)unicode[i];
				}
				else
				{
					var matchedChars = Mapping.Where(character => character.UniCode == unicode[i]).ToList();

					if (matchedChars.Count() == 1)
					{
						iranSystemMessage[i] = matchedChars.Single().IranSystemCode;
						continue;
					}

					previousChar = i > 0 ? unicode[i - 1] : -1;
					nextChar = i < unicode.Length - 1 ? unicode[i + 1] : -1;

					if (lastStickedMiddleChars.Contains(unicode[i]))
					{
						if (separatorChars.Contains(nextChar) || nextChar < 128)
						{
							iranSystemMessage[i] = matchedChars.Single(character => character.Status == CharStatus.LastSticked).IranSystemCode;
							continue;
						}
						else
						{
							iranSystemMessage[i] = matchedChars.Single(character => character.Status == CharStatus.Midlle).IranSystemCode;
							continue;
						}
					}

					if (firstLastSticked.Contains(unicode[i]))
					{
						if (separatorChars.Contains(previousChar) || previousChar < 128)
						{
							iranSystemMessage[i] = matchedChars.Single(character => character.Status == CharStatus.First).IranSystemCode;
							continue;
						}
						else
						{
							iranSystemMessage[i] = matchedChars.Single(character => character.Status == CharStatus.LastSticked).IranSystemCode;
							continue;
						}
					}

					if (firstMidlleLastSeparate.Contains(unicode[i]))
					{
						if ((separatorChars.Contains(previousChar) || previousChar < 128) && separatorChars.Contains(nextChar) || nextChar < 128)
						{
							iranSystemMessage[i] = matchedChars.Single(character => character.Status == CharStatus.LastSeparate).IranSystemCode;
							continue;
						}
						else if (separatorChars.Contains(previousChar) || previousChar < 128)
						{
							iranSystemMessage[i] = matchedChars.Single(character => character.Status == CharStatus.First).IranSystemCode;
							continue;
						}

						else
						{
							iranSystemMessage[i] = matchedChars.Single(character => character.Status == CharStatus.Midlle).IranSystemCode;
							continue;
						}
					}


					if (midlleLastSeparateLastSticked.Contains(unicode[i]))
					{
						if ((separatorChars.Contains(previousChar) || previousChar < 128) && separatorChars.Contains(nextChar) || nextChar < 128)
						{
							iranSystemMessage[i] = matchedChars.Single(character => character.Status == CharStatus.LastSeparate).IranSystemCode;
							continue;
						}
						else if (separatorChars.Contains(nextChar) || nextChar < 128)
						{
							iranSystemMessage[i] = matchedChars.Single(character => character.Status == CharStatus.LastSticked).IranSystemCode;
							continue;
						}
						else
						{
							iranSystemMessage[i] = matchedChars.Single(character => character.Status == CharStatus.Midlle).IranSystemCode;
							continue;
						}
					}

					if (firstMidlleLastStickedLastSeparate.Contains(unicode[i]))
					{
						if ((separatorChars.Contains(previousChar) || previousChar < 128) && separatorChars.Contains(nextChar) || nextChar < 128)
						{
							iranSystemMessage[i] = matchedChars.Single(character => character.Status == CharStatus.LastSeparate).IranSystemCode;
							continue;
						}
						else
							if (separatorChars.Contains(previousChar) || previousChar < 128)
						{
							iranSystemMessage[i] = matchedChars.Single(character => character.Status == CharStatus.First).IranSystemCode;
							continue;
						}

						else
							if (separatorChars.Contains(nextChar) || nextChar < 128)
						{
							iranSystemMessage[i] = matchedChars.Single(character => character.Status == CharStatus.LastSticked).IranSystemCode;
							continue;
						}
						else
						{
							iranSystemMessage[i] = matchedChars.Single(character => character.Status == CharStatus.Midlle).IranSystemCode;
							continue;
						}
					}
				}
			}

			return iranSystemMessage;
		}
	}
}
