using ScheduleOne.NPCs;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Properties
{
	[CreateAssetMenu(fileName = "BrightEyed", menuName = "Properties/BrightEyed Property")]
	public class BrightEyed : Property
	{
		public Color EyeColor;

		public float Emission;

		public float LightIntensity;

		public override void ApplyToNPC(NPC npc)
		{
		}

		public override void ApplyToPlayer(Player player)
		{
		}

		public override void ClearFromNPC(NPC npc)
		{
		}

		public override void ClearFromPlayer(Player player)
		{
		}
	}
}
