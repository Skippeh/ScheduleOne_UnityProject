using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Clothing
{
	public class ClothingUtility : Singleton<ClothingUtility>
	{
		[Serializable]
		public class ColorData
		{
			public EClothingColor ColorType;

			public Color ActualColor;

			public Color LabelColor;
		}

		[Serializable]
		public class ClothingSlotData
		{
			public EClothingSlot Slot;

			public string Name;

			public Sprite Icon;
		}

		public List<ColorData> ColorDataList;

		public List<ClothingSlotData> ClothingSlotDataList;

		protected override void Awake()
		{
		}

		private void OnValidate()
		{
		}

		public ColorData GetColorData(EClothingColor color)
		{
			return null;
		}

		public ClothingSlotData GetSlotData(EClothingSlot slot)
		{
			return null;
		}
	}
}
