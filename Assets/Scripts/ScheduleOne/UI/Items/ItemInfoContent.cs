using ScheduleOne.ItemFramework;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Items
{
	public class ItemInfoContent : MonoBehaviour
	{
		[Header("Settings")]
		public float Height;

		[Header("References")]
		public TextMeshProUGUI NameLabel;

		public TextMeshProUGUI DescriptionLabel;

		public virtual void Initialize(ItemInstance instance)
		{
		}

		public virtual void Initialize(ItemDefinition definition)
		{
		}
	}
}
