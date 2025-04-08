namespace ScheduleOne.NPCs.Responses
{
	public class NPCResponses_Civilian : global::ScheduleOne.NPCs.Responses.NPCResponses
	{
		public enum EAttackResponse
		{
			None = 0,
			Panic = 1,
			Flee = 2,
			CallPolice = 3,
			Fight = 4
		}

		public enum EThreatType
		{
			None = 0,
			AimedAt = 1,
			GunshotHeard = 2,
			ExplosionHeard = 3
		}

		public bool CanCallPolice;

		private global::ScheduleOne.NPCs.Responses.NPCResponses_Civilian.EAttackResponse currentThreatResponse;

		private float timeSinceLastThreat;

		protected override void Update()
		{
		}

		public override void GunshotHeard(global::ScheduleOne.Noise.NoiseEvent gunshotSound)
		{
		}

		public override void ExplosionHeard(global::ScheduleOne.Noise.NoiseEvent explosionSound)
		{
		}

		public override void PlayerFailedPickpocket(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		protected override void RespondToFirstNonLethalAttack(global::ScheduleOne.PlayerScripts.Player perpetrator, global::ScheduleOne.Combat.Impact impact)
		{
		}

		protected override void RespondToAnnoyingImpact(global::ScheduleOne.PlayerScripts.Player perpetrator, global::ScheduleOne.Combat.Impact impact)
		{
		}

		protected override void RespondToLethalAttack(global::ScheduleOne.PlayerScripts.Player perpetrator, global::ScheduleOne.Combat.Impact impact)
		{
		}

		protected override void RespondToRepeatedNonLethalAttack(global::ScheduleOne.PlayerScripts.Player perpetrator, global::ScheduleOne.Combat.Impact impact)
		{
		}

		private void RespondToLethalOrRepeatedAttack(global::ScheduleOne.PlayerScripts.Player perpetrator, global::ScheduleOne.Combat.Impact impact)
		{
		}

		public override void RespondToAimedAt(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		private void ExecuteThreatResponse(global::ScheduleOne.NPCs.Responses.NPCResponses_Civilian.EAttackResponse response, global::ScheduleOne.PlayerScripts.Player target, global::UnityEngine.Vector3 threatOrigin, global::ScheduleOne.Law.Crime crime = null)
		{
		}

		private global::ScheduleOne.NPCs.Responses.NPCResponses_Civilian.EAttackResponse GetThreatResponse(global::ScheduleOne.NPCs.Responses.NPCResponses_Civilian.EThreatType type, global::ScheduleOne.PlayerScripts.Player threatSource)
		{
			return default(global::ScheduleOne.NPCs.Responses.NPCResponses_Civilian.EAttackResponse);
		}
	}
}
