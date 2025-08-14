namespace ScheduleOne.Police
{
	public class NPCResponses_CartelGoon : global::ScheduleOne.NPCs.Responses.NPCResponses
	{
		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Cartel.CartelGoon Goon;

		protected override void Awake()
		{
		}

		public override void ExplosionHeard(global::ScheduleOne.Noise.NoiseEvent explosionSound)
		{
		}

		public override void GunshotHeard(global::ScheduleOne.Noise.NoiseEvent gunshotSound)
		{
		}

		public override void NoticePlayerDischargingWeapon(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public override void PlayerFailedPickpocket(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public override void HitByCar(global::ScheduleOne.Vehicles.LandVehicle vehicle)
		{
		}

		public override void ImpactReceived(global::ScheduleOne.Combat.Impact impact)
		{
		}

		public override void RespondToAimedAt(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		protected override void RespondToAnnoyingImpact(global::ScheduleOne.PlayerScripts.Player perpetrator, global::ScheduleOne.Combat.Impact impact)
		{
		}
	}
}
