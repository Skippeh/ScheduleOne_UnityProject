using System;

namespace ScheduleOne.Product
{
	[Serializable]
	public class NewMixOperation
	{
		public string ProductID;

		public string IngredientID;

		public NewMixOperation(string productID, string ingredientID)
		{
		}

		public NewMixOperation()
		{
		}
	}
}
