namespace LiquidVolumeFX
{
	public static class DetailExtensions
	{
		public static bool allowsRefraction(this DETAIL detail)
		{
			return false;
		}

		public static bool usesFlask(this DETAIL detail)
		{
			return false;
		}
	}
}
