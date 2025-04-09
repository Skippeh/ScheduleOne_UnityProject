using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	public class ShopInterfaceDetailPanel : MonoBehaviour
	{
		[Header("References")]
		public RectTransform Panel;

		public VerticalLayoutGroup LayoutGroup;

		public TextMeshProUGUI DescriptionLabel;

		public TextMeshProUGUI UnlockLabel;

		private ListingUI listing;

		private void Awake()
		{
		}

		public void Open(ListingUI _listing)
		{
		}

		private void LateUpdate()
		{
		}

		private void Position()
		{
		}

		public void Close()
		{
		}
	}
}
