using System;
using ScheduleOne.Growing;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	[Serializable]
	[CreateAssetMenu(fileName = "AdditiveDefinition", menuName = "ScriptableObjects/Item Definitions/AdditiveDefinition", order = 1)]
	public class AdditiveDefinition : StorableItemDefinition
	{
		public Additive AdditivePrefab;
	}
}
