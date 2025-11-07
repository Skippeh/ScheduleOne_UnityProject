namespace ScheduleOne.ObjectScripts
{
	[global::System.Serializable]
	public class MixOperation
	{
		public string ProductID;

		public global::ScheduleOne.ItemFramework.EQuality ProductQuality;

		public string IngredientID;

		public int Quantity;

		public MixOperation(string productID, global::ScheduleOne.ItemFramework.EQuality productQuality, string ingredientID, int quantity)
		{
		}

		public MixOperation()
		{
		}

		public global::ScheduleOne.Product.EDrugType GetOutput(out global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties)
		{
			properties = null;
			return default(global::ScheduleOne.Product.EDrugType);
		}

		public bool IsOutputKnown(out global::ScheduleOne.Product.ProductDefinition knownProduct)
		{
			knownProduct = null;
			return false;
		}
	}
}
