using System;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	[Serializable]
	[CreateAssetMenu(fileName = "IntegerItemDefinition", menuName = "ScriptableObjects/IntegerItemDefinition", order = 1)]
	public class IntegerItemDefinition : StorableItemDefinition
	{
		public int DefaultValue;

		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}
	}
}
