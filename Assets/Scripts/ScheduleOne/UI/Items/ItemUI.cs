namespace ScheduleOne.UI.Items
{
	public class ItemUI : global::UnityEngine.MonoBehaviour
	{
		protected global::ScheduleOne.ItemFramework.ItemInstance itemInstance;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Rect;

		public global::UnityEngine.UI.Image IconImg;

		public global::TMPro.TextMeshProUGUI QuantityLabel;

		protected int DisplayedQuantity;

		protected bool Destroyed;

		public virtual void Setup(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public virtual void Destroy()
		{
		}

		public virtual global::UnityEngine.RectTransform DuplicateIcon(global::UnityEngine.Transform parent, int overriddenQuantity = -1)
		{
			return null;
		}

		public virtual void SetVisible(bool vis)
		{
		}

		public virtual void UpdateUI()
		{
		}

		public virtual void SetDisplayedQuantity(int quantity)
		{
		}
	}
}
