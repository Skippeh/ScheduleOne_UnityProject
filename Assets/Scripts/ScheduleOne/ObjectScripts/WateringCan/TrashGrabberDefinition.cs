using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.WateringCan
{
	[Serializable]
	[CreateAssetMenu(fileName = "TrashGrabberDefinition", menuName = "ScriptableObjects/Item Definitions/TrashGrabberDefinition", order = 1)]
	public class TrashGrabberDefinition : StorableItemDefinition
	{
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}
	}
}
