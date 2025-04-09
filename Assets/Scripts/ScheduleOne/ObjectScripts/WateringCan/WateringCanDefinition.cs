using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.WateringCan
{
	[Serializable]
	[CreateAssetMenu(fileName = "WateringCanDefinition", menuName = "ScriptableObjects/Item Definitions/WateringCanDefinition", order = 1)]
	public class WateringCanDefinition : StorableItemDefinition
	{
		public const float Capacity = 15f;

		public GameObject FunctionalWateringCanPrefab;

		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}
	}
}
