using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	public abstract class Property : ScriptableObject
	{
		public string Name;

		public string Description;

		public string ID;

		[Range(1f, 5f)]
		public int Tier;

		[Range(0f, 1f)]
		public float Addictiveness;

		public Color ProductColor;

		public Color LabelColor;

		public bool ImplementedPriorMixingRework;

		[Header("Value")]
		[Range(-100f, 100f)]
		public int ValueChange;

		[Range(0f, 2f)]
		public float ValueMultiplier;

		[Range(-1f, 1f)]
		public float AddBaseValueMultiple;

		public Vector2 MixDirection;

		public float MixMagnitude;

		public abstract void ApplyToNPC(NPC npc);

		public abstract void ClearFromNPC(NPC npc);

		public abstract void ApplyToPlayer(Player player);

		public abstract void ClearFromPlayer(Player player);

		public void OnValidate()
		{
		}
	}
}
