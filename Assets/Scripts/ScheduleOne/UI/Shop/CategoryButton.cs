using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Shop
{
	public class CategoryButton : MonoBehaviour
	{
		public EShopCategory Category;

		private Button button;

		private ShopInterface shop;

		public bool isSelected { get; protected set; }

		private void Awake()
		{
		}

		private void OnValidate()
		{
		}

		private void Clicked()
		{
		}

		public void Deselect()
		{
		}

		public void Select()
		{
		}

		private void RefreshUI()
		{
		}
	}
}
