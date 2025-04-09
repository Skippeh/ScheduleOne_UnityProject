using System;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using ScheduleOne.Packaging;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Product.Packaging
{
	[Serializable]
	[CreateAssetMenu(fileName = "PackagingDefinition", menuName = "ScriptableObjects/Item Definitions/PackagingDefinition", order = 1)]
	public class PackagingDefinition : StorableItemDefinition
	{
		public int Quantity;

		public EStealthLevel StealthLevel;

		public FunctionalPackaging FunctionalPackaging;

		public Equippable Equippable_Filled;

		public StoredItem StoredItem_Filled;
	}
}
