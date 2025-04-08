namespace ScheduleOne.UI.Items
{
	public class ItemInfoPanel : global::UnityEngine.MonoBehaviour
	{
		public const float VERTICAL_THRESHOLD = 200f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.RectTransform ContentContainer;

		public global::UnityEngine.GameObject TopArrow;

		public global::UnityEngine.GameObject BottomArrow;

		public global::UnityEngine.Canvas Canvas;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.Vector2 Offset;

		[global::UnityEngine.Header("Prefabs")]
		public global::ScheduleOne.UI.Items.ItemInfoContent DefaultContentPrefab;

		private global::ScheduleOne.UI.Items.ItemInfoContent content;

		public bool IsOpen { get; protected set; }

		public global::ScheduleOne.ItemFramework.ItemInstance CurrentItem { get; protected set; }

		private void Awake()
		{
		}

		public void Open(global::ScheduleOne.ItemFramework.ItemInstance item, global::UnityEngine.RectTransform rect)
		{
		}

		public void Open(global::ScheduleOne.ItemFramework.ItemDefinition def, global::UnityEngine.RectTransform rect)
		{
		}

		public void Close()
		{
		}
	}
}
