using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.UI.Items
{
	public class ItemInfoPanel : MonoBehaviour
	{
		public const float VERTICAL_THRESHOLD = 200f;

		[Header("References")]
		public RectTransform Container;

		public RectTransform ContentContainer;

		public GameObject TopArrow;

		public GameObject BottomArrow;

		public Canvas Canvas;

		[Header("Settings")]
		public Vector2 Offset;

		[Header("Prefabs")]
		public ItemInfoContent DefaultContentPrefab;

		private ItemInfoContent content;

		public bool IsOpen { get; protected set; }

		public ItemInstance CurrentItem { get; protected set; }

		private void Awake()
		{
		}

		public void Open(ItemInstance item, RectTransform rect)
		{
		}

		public void Open(ItemDefinition def, RectTransform rect)
		{
		}

		public void Close()
		{
		}
	}
}
