namespace ScheduleOne.ItemFramework
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "ItemDefinition", menuName = "ScriptableObjects/ItemDefinition", order = 1)]
	public abstract class ItemDefinition : global::ScheduleOne.Core.Items.Framework.BaseItemDefinition
	{
		public enum EEquipMode
		{
			Legacy = 0,
			New = 1
		}

		public bool AvailableInDemo;

		[global::UnityEngine.Header("Legacy Equipping Settings")]
		public global::ScheduleOne.ItemFramework.ItemDefinition.EEquipMode EquipMode;

		public global::ScheduleOne.Equipping.Equippable Equippable;

		[global::UnityEngine.Header("UI Settings")]
		public global::ScheduleOne.UI.Items.ItemUI CustomItemUI;

		public global::ScheduleOne.UI.Items.ItemInfoContent CustomInfoContent;

		public abstract global::ScheduleOne.ItemFramework.ItemInstance GetDefaultInstance(int quantity = 1);
	}
}
