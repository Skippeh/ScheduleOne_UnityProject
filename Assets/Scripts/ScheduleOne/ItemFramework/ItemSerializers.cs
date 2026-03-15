namespace ScheduleOne.ItemFramework
{
	public static class ItemSerializers
	{
		public const string NullItem = "";

		public static void WriteItemInstance(this global::FishNet.Serializing.Writer writer, global::ScheduleOne.ItemFramework.ItemInstance value)
		{
		}

		public static global::ScheduleOne.ItemFramework.ItemInstance ReadItemInstance(this global::FishNet.Serializing.Reader reader)
		{
			return null;
		}

		public static void WriteProductItemInstance(this global::FishNet.Serializing.Writer writer, global::ScheduleOne.Product.ProductItemInstance value)
		{
		}

		public static global::ScheduleOne.Product.ProductItemInstance ReadProductItemInstance(this global::FishNet.Serializing.Reader reader)
		{
			return null;
		}
	}
}
