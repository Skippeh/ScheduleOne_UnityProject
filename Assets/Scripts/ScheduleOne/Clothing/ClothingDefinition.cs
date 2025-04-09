using System;
using System.Collections.Generic;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Clothing
{
	[Serializable]
	[CreateAssetMenu(fileName = "ClothingDefinition", menuName = "ScriptableObjects/ClothingDefinition", order = 1)]
	public class ClothingDefinition : StorableItemDefinition
	{
		public EClothingSlot Slot;

		public EClothingApplicationType ApplicationType;

		public string ClothingAssetPath;

		public bool Colorable;

		public EClothingColor DefaultColor;

		public List<EClothingSlot> SlotsToBlock;

		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}
	}
}
