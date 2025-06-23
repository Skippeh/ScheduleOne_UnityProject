namespace ScheduleOne.UI.Items
{
	public class ItemSlotFilterButton : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.UI.ItemSlotUI ItemSlotUI;

		public global::UnityEngine.UI.Button Button;

		public global::UnityEngine.UI.Image IconImage;

		public global::UnityEngine.UI.Image SpotImage;

		public global::UnityEngine.UI.Image[] FilterItemImages;

		public global::TMPro.TextMeshProUGUI FilterMoreItemsLabel;

		public global::ScheduleOne.ItemFramework.ItemSlot AssignedSlot { get; protected set; }

		private void Awake()
		{
		}

		public void AssignSlot(global::ScheduleOne.ItemFramework.ItemSlot slot)
		{
		}

		public void UnassignSlot()
		{
		}

		public void Clicked()
		{
		}

		private void RefreshAppearance()
		{
		}
	}
}
