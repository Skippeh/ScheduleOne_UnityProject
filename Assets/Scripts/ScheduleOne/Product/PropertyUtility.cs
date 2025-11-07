namespace ScheduleOne.Product
{
	public class PropertyUtility : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Product.PropertyUtility>
	{
		[global::System.Serializable]
		public class PropertyData
		{
			public global::ScheduleOne.Product.EProperty Property;

			public string Name;

			public string Description;

			public global::UnityEngine.Color Color;
		}

		[global::System.Serializable]
		public class DrugTypeData
		{
			public global::ScheduleOne.Product.EDrugType DrugType;

			public string Name;

			public global::UnityEngine.Color Color;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Product.PropertyUtility.PropertyData> PropertyDatas;

		public global::System.Collections.Generic.List<global::ScheduleOne.Product.PropertyUtility.DrugTypeData> DrugTypeDatas;

		public global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> AllProperties;

		[global::UnityEngine.Header("Test Mixing")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Product.ProductDefinition> Products;

		public global::System.Collections.Generic.List<global::ScheduleOne.Product.PropertyItemDefinition> Properties;

		private global::System.Collections.Generic.Dictionary<string, global::ScheduleOne.Effects.Effect> PropertiesDict;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> GetProperties(int tier)
		{
			return null;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> GetProperties(global::System.Collections.Generic.List<string> ids)
		{
			return null;
		}

		public static global::ScheduleOne.Product.PropertyUtility.PropertyData GetPropertyData(global::ScheduleOne.Product.EProperty property)
		{
			return null;
		}

		public static global::ScheduleOne.Product.PropertyUtility.DrugTypeData GetDrugTypeData(global::ScheduleOne.Product.EDrugType drugType)
		{
			return null;
		}

		public static global::System.Collections.Generic.List<global::UnityEngine.Color32> GetOrderedPropertyColors(global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties)
		{
			return null;
		}
	}
}
