using System;
using ScheduleOne.EntityFramework;
using UnityEngine;

namespace ScheduleOne.ItemFramework
{
	[Serializable]
	[CreateAssetMenu(fileName = "BuildableItemDefinition", menuName = "ScriptableObjects/BuildableItemDefinition", order = 1)]
	public class BuildableItemDefinition : StorableItemDefinition
	{
		public enum EBuildSoundType
		{
			Cardboard = 0,
			Wood = 1,
			Metal = 2
		}

		public BuildableItem BuiltItem;

		public EBuildSoundType BuildSoundType;
	}
}
