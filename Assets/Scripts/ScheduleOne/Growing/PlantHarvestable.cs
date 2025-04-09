using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Growing
{
	public class PlantHarvestable : MonoBehaviour
	{
		public StorableItemDefinition Product;

		public int ProductQuantity;

		public virtual void Harvest(bool giveProduct = true)
		{
		}
	}
}
