using ScheduleOne.Combat;
using ScheduleOne.Law;
using ScheduleOne.Noise;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.NPCs.Responses
{
	public class NPCResponses_Civilian : NPCResponses
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

		private EAttackResponse currentThreatResponse;

		private float timeSinceLastThreat;

		protected override void Update()
		{
		}

		public override void GunshotHeard(NoiseEvent gunshotSound)
		{
		}

		public override void ExplosionHeard(NoiseEvent explosionSound)
		{
		}

		public override void PlayerFailedPickpocket(Player player)
		{
		}

		protected override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		protected override void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
		}

		protected override void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
		}

		protected override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		private void RespondToLethalOrRepeatedAttack(Player perpetrator, Impact impact)
		{
		}

		public override void RespondToAimedAt(Player player)
		{
		}

		private void ExecuteThreatResponse(EAttackResponse response, Player target, Vector3 threatOrigin, Crime crime = null)
		{
		}

		private EAttackResponse GetThreatResponse(EThreatType type, Player threatSource)
		{
			return default(EAttackResponse);
		}
	}
}
