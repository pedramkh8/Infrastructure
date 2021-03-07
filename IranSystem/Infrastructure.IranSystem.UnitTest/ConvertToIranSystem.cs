using Xunit;

namespace Infrastructure.UnitTest.IranSystem
{
	public class ToIranSystemString
	{
		[Theory]
		[InlineData("سلام من به عدد 1 و عدد 2 که شروع هستند")]
		[InlineData("1691D1F7A22FA4881D")]
		[InlineData("3oسلامk4")]
		[InlineData("3oسلامk423dfgd4532")]
		public void SuccessScenario(string message)
		{
			var iranSystemMessage = Infrastructure.IranSystem.Convertor.GetByte(message);
			var uniCodeMessage = Infrastructure.IranSystem.Convertor.GetString(iranSystemMessage);
			Assert.Equal(message, uniCodeMessage);
		}

		[Theory]
		[InlineData("سلام من به عدد 1 و عدد 2 که شروع هستند")]
		[InlineData("1691D1F7A22FA4881D")]
		[InlineData("3oسلامk4")]
		[InlineData("3oسلامk423dfgd4532")]
		[InlineData("ئا ء ئ آ ، ؟ ل؟ل اباب پپ تت ثث جج چچ حح خخ دذ رزسس شش صص ضض طظ ط ظ ع ععع غاغ غغغ فف قق کک گگ لل مم نن وهه ههه یت ی بی")]
		[InlineData("12332Ddfgfg456نشمتسیبانمتاfsdkjha09834sadfhlkjتنابشسمنیتبا34509kjsdfjkfg983400980989080908098شسیبنتمنتم~dfdkjlkمنتشسیس^lkjsddflk^منتمن~")]
		public void SuccessScenario4(string message)
		{
			var iranbyte = Infrastructure.IranSystem.Convertor.GetByte(message);
			var unicodestring = Infrastructure.IranSystem.Convertor.GetString(iranbyte);
			Assert.Equal(message, unicodestring);
		}

		[Theory]
		[InlineData(new byte[] { 144, 147, 145, 163, 164, 32 ,162, 164, 32, 238, 151, 145, 146, 32, 161, 248, 162, 32,
				141, 248, 164, 162, 249, 32, 144, 168, 150, 32, 238, 249, 32, 144, 159, 151, 254, 145, 175, 32, 170, 164, 32, 175 })]
		public void SuccessScenario1(byte[] message)
		{
			var unicodestring  = Infrastructure.IranSystem.Convertor.GetString(message);
			var iranbyte = Infrastructure.IranSystem.Convertor.GetByte(unicodestring);
			for (int i = 0; i < message.Length; i++)
			{
				byte expected = message[i];
				byte actual = iranbyte[i];

				Assert.True(expected == actual,
					string.Format("Expected: '{0}', Actual: '{1}' at offset {2}.", (byte)expected, (byte)actual, i)
				);
			}
		}
	}
}
