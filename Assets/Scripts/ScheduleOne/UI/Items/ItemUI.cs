using ScheduleOne.ItemFramework;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Items
{
	public class ItemUI : MonoBehaviour
	{
		protected ItemInstance itemInstance;

		[Header("References")]
		public RectTransform Rect;

		public Image IconImg;

		public TextMeshProUGUI QuantityLabel;

		protected int DisplayedQuantity;

		protected bool Destroyed;

		public virtual void Setup(ItemInstance item)
		{
		}

		public virtual void Destroy()
		{
		}

		public virtual RectTransform DuplicateIcon(Transform parent, int overriddenQuantity = -1)
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
