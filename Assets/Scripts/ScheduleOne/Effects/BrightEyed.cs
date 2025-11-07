namespace ScheduleOne.Effects
{
	[global::UnityEngine.CreateAssetMenu(fileName = "BrightEyed", menuName = "Properties/BrightEyed Property")]
	public class BrightEyed : global::ScheduleOne.Effects.Effect
	{
		public global::UnityEngine.Color EyeColor;

		public float Emission;

		public float LightIntensity;

		public override void ApplyToNPC(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public override void ApplyToPlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public override void ClearFromNPC(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public override void ClearFromPlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}
	}
}
