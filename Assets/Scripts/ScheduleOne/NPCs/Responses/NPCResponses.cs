namespace ScheduleOne.NPCs.Responses
{
	public class NPCResponses : global::UnityEngine.MonoBehaviour
	{
		public const float ASSAULT_RELATIONSHIPCHANGE = -0.25f;

		public const float DEADLYASSAULT_RELATIONSHIPCHANGE = -1f;

		public const float AIMED_AT_RELATIONSHIPCHANGE = -0.5f;

		public const float PICKPOCKET_RELATIONSHIPCHANGE = -0.25f;

		private const float INITIALIZED_TIME_OFFSET = 100f;

		private const float TIME_THRESHOLD = 20f;

		protected float timeSinceLastImpact;

		protected float timeSinceAimedAt;

		protected global::ScheduleOne.NPCs.NPC npc { get; private set; }

		protected global::ScheduleOne.NPCs.Actions.NPCActions actions => null;

		protected virtual void Awake()
		{
		}

		public virtual void GunshotHeard(global::ScheduleOne.Noise.NoiseEvent gunshotSound)
		{
		}

		public virtual void ExplosionHeard(global::ScheduleOne.Noise.NoiseEvent explosionSound)
		{
		}

		public virtual void NoticedPettyCrime(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public virtual void NoticedVandalism(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public virtual void SawPickpocketing(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public virtual void NoticePlayerBrandishingWeapon(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public virtual void NoticePlayerDischargingWeapon(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public virtual void PlayerFailedPickpocket(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public virtual void NoticedDrugDeal(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public virtual void NoticedViolatingCurfew(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public virtual void NoticedWantedPlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public virtual void NoticedSuspiciousPlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public virtual void HitByCar(global::ScheduleOne.Vehicles.LandVehicle vehicle)
		{
		}

		public virtual void ImpactReceived(global::ScheduleOne.Combat.Impact impact)
		{
		}

		protected virtual void RespondToFirstNonLethalAttack(global::ScheduleOne.PlayerScripts.Player perpetrator, global::ScheduleOne.Combat.Impact impact)
		{
		}

		protected virtual void RespondToRepeatedNonLethalAttack(global::ScheduleOne.PlayerScripts.Player perpetrator, global::ScheduleOne.Combat.Impact impact)
		{
		}

		protected virtual void RespondToLethalAttack(global::ScheduleOne.PlayerScripts.Player perpetrator, global::ScheduleOne.Combat.Impact impact)
		{
		}

		protected virtual void RespondToAnnoyingImpact(global::ScheduleOne.PlayerScripts.Player perpetrator, global::ScheduleOne.Combat.Impact impact)
		{
		}

		public virtual void RespondToAimedAt(global::ScheduleOne.PlayerScripts.Player player)
		{
		}
	}
}
