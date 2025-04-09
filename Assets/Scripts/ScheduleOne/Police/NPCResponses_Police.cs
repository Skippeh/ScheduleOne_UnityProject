using ScheduleOne.Combat;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.Noise;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;

namespace ScheduleOne.Police
{
	public class NPCResponses_Police : NPCResponses
	{
		private PoliceOfficer officer;

		protected override void Awake()
		{
		}

		public override void HitByCar(LandVehicle vehicle)
		{
		}

		public override void NoticedDrugDeal(Player player)
		{
		}

		public override void NoticedPettyCrime(Player player)
		{
		}

		public override void NoticedVandalism(Player player)
		{
		}

		public override void SawPickpocketing(Player player)
		{
		}

		public override void NoticePlayerBrandishingWeapon(Player player)
		{
		}

		public override void NoticePlayerDischargingWeapon(Player player)
		{
		}

		public override void NoticedWantedPlayer(Player player)
		{
		}

		public override void NoticedSuspiciousPlayer(Player player)
		{
		}

		public override void NoticedViolatingCurfew(Player player)
		{
		}

		protected override void RespondToFirstNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		protected override void RespondToLethalAttack(Player perpetrator, Impact impact)
		{
		}

		protected override void RespondToRepeatedNonLethalAttack(Player perpetrator, Impact impact)
		{
		}

		protected override void RespondToAnnoyingImpact(Player perpetrator, Impact impact)
		{
		}

		public override void RespondToAimedAt(Player player)
		{
		}

		public override void ImpactReceived(Impact impact)
		{
		}

		public override void GunshotHeard(NoiseEvent gunshotSound)
		{
		}
	}
}
