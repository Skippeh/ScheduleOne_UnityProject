namespace ScheduleOne.UI.Shop
{
	public class ShopColorPicker : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.UI.Image AssetIconImage;

		public global::TMPro.TextMeshProUGUI ColorLabel;

		public global::UnityEngine.RectTransform ColorButtonParent;

		public global::UnityEngine.GameObject ColorButtonPrefab;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.Clothing.EClothingColor> onColorPicked;

		public bool IsOpen => false;

		public void Start()
		{
		}

		private void ColorPicked(global::ScheduleOne.Clothing.EClothingColor color)
		{
		}

		public void Open(global::ScheduleOne.ItemFramework.ItemDefinition item)
		{
		}

		public void Close()
		{
		}

		private void ColorHovered(global::ScheduleOne.Clothing.EClothingColor color)
		{
		}
	}
}
