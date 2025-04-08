namespace ScheduleOne.Clothing
{
	public class ClothingUtility : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Clothing.ClothingUtility>
	{
		[global::System.Serializable]
		public class ColorData
		{
			public global::ScheduleOne.Clothing.EClothingColor ColorType;

			public global::UnityEngine.Color ActualColor;

			public global::UnityEngine.Color LabelColor;
		}

		[global::System.Serializable]
		public class ClothingSlotData
		{
			public global::ScheduleOne.Clothing.EClothingSlot Slot;

			public string Name;

			public global::UnityEngine.Sprite Icon;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Clothing.ClothingUtility.ColorData> ColorDataList;

		public global::System.Collections.Generic.List<global::ScheduleOne.Clothing.ClothingUtility.ClothingSlotData> ClothingSlotDataList;

		protected override void Awake()
		{
		}

		private void OnValidate()
		{
		}

		public global::ScheduleOne.Clothing.ClothingUtility.ColorData GetColorData(global::ScheduleOne.Clothing.EClothingColor color)
		{
			return null;
		}

		public global::ScheduleOne.Clothing.ClothingUtility.ClothingSlotData GetSlotData(global::ScheduleOne.Clothing.EClothingSlot slot)
		{
			return null;
		}
	}
}
