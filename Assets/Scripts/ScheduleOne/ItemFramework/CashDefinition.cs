using System;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	[Serializable]
	[CreateAssetMenu(fileName = "CashDefinition", menuName = "ScriptableObjects/CashDefinition", order = 1)]
	public class CashDefinition : StorableItemDefinition
	{
		public override ItemInstance GetDefaultInstance(int quantity = 1)
		{
			return null;
		}
	}
}
