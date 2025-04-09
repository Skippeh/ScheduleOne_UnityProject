using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using ScheduleOne.Product;

namespace ScheduleOne.ObjectScripts
{
	[Serializable]
	public class MixOperation
	{
		public string ProductID;

		public EQuality ProductQuality;

		public string IngredientID;

		public int Quantity;

		public MixOperation(string productID, EQuality productQuality, string ingredientID, int quantity)
		{
		}

		public MixOperation()
		{
		}

		public EDrugType GetOutput(out List<ScheduleOne.Properties.Property> properties)
		{
			properties = null;
			return default(EDrugType);
		}

		public bool IsOutputKnown(out ProductDefinition knownProduct)
		{
			knownProduct = null;
			return false;
		}
	}
}
