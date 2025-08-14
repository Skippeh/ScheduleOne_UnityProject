namespace ScheduleOne.Product
{
	[global::System.Serializable]
	public class ProductList
	{
		[global::System.Serializable]
		public class Entry
		{
			public string ProductID;

			public global::ScheduleOne.ItemFramework.EQuality Quality;

			public int Quantity;

			public Entry(string productID, global::ScheduleOne.ItemFramework.EQuality quality, int quantity)
			{
			}

			public Entry()
			{
			}
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Product.ProductList.Entry> entries;

		public string GetCommaSeperatedString()
		{
			return null;
		}

		public string GetLineSeperatedString()
		{
			return null;
		}

		public string GetQualityString()
		{
			return null;
		}

		public int GetTotalQuantity()
		{
			return 0;
		}
	}
}
