using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.Product
{
	[Serializable]
	public class ProductList
	{
		[Serializable]
		public class Entry
		{
			public string ProductID;

			public EQuality Quality;

			public int Quantity;
		}

		public List<Entry> entries;

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
