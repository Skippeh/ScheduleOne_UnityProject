using System;
using ScheduleOne.Product;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class ProductData : SaveData
	{
		public string Name;

		public string ID;

		public EDrugType DrugType;

		public string[] Properties;

		public ProductData(string name, string id, EDrugType drugType, string[] properties)
		{
		}
	}
}
