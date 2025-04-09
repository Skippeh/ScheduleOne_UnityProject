using System;
using ScheduleOne.ItemFramework;
using UnityEngine;

namespace ScheduleOne.Growing
{
	[Serializable]
	[CreateAssetMenu(fileName = "SeedDefinition", menuName = "ScriptableObjects/Item Definitions/SeedDefinition", order = 1)]
	public class SeedDefinition : StorableItemDefinition
	{
		public FunctionalSeed FunctionSeedPrefab;

		public Plant PlantPrefab;
	}
}
