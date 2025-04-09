using System;
using ScheduleOne.Equipping;
using ScheduleOne.UI.Items;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	[Serializable]
	[CreateAssetMenu(fileName = "ItemDefinition", menuName = "ScriptableObjects/ItemDefinition", order = 1)]
	public class ItemDefinition : ScriptableObject
	{
		public const int DEFAULT_STACK_LIMIT = 10;

		public string Name;

		[TextArea(3, 10)]
		public string Description;

		public string ID;

		public Sprite Icon;

		public EItemCategory Category;

		public string[] Keywords;

		public bool AvailableInDemo;

		public Color LabelDisplayColor;

		public int StackLimit;

		public Equippable Equippable;

		public ItemUI CustomItemUI;

		public ItemInfoContent CustomInfoContent;

		[Header("Legal Status")]
		public ELegalStatus legalStatus;

		public virtual ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}
	}
}
