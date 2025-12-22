namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "ItemDefinition", menuName = "ScriptableObjects/ItemDefinition", order = 1)]
	public class ItemDefinition : global::UnityEngine.ScriptableObject
	{
		public const int DEFAULT_STACK_LIMIT = 10;

		public string Name;

		[global::UnityEngine.TextArea(3, 10)]
		public string Description;

		public string ID;

		public global::UnityEngine.Sprite Icon;

		public global::ScheduleOne.ItemFramework.EItemCategory Category;

		public string[] Keywords;

		public bool AvailableInDemo;

		public bool UsableInFilters;

		public global::UnityEngine.Color LabelDisplayColor;

		public int StackLimit;

		public global::ScheduleOne.Equipping.Equippable Equippable;

		public global::ScheduleOne.UI.Items.ItemUI CustomItemUI;

		public global::ScheduleOne.UI.Items.ItemInfoContent CustomInfoContent;

		[global::UnityEngine.Header("Legal Status")]
		public global::ScheduleOne.ItemFramework.ELegalStatus legalStatus;

		public virtual global::ScheduleOne.ItemFramework.ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}

		public virtual void ValidateDefinition()
		{
		}
	}
}
