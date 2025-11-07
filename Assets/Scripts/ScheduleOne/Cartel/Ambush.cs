namespace ScheduleOne.Cartel
{
	public class Ambush : global::ScheduleOne.Cartel.CartelActivity
	{
		public const float MIN_DISTANCE_TO_POLICE_OFFICER = 15f;

		public const int CANCEL_AMBUSH_AFTER_MINS = 360;

		public const float AMBUSH_DEFEATED_INFLUENCE_CHANGE = -0.1f;

		public static global::ScheduleOne.Levelling.FullRank MIN_RANK_FOR_RANGED_WEAPONS;

		private global::ScheduleOne.Cartel.CartelRegionActivities _regionActivities;

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.AvatarFramework.Equipping.AvatarWeapon[] RangedWeapons;

		public global::ScheduleOne.AvatarFramework.Equipping.AvatarWeapon[] MeleeWeapons;

		public override void Activate(global::ScheduleOne.Map.EMapRegion region)
		{
		}

		protected override void Deactivate()
		{
		}

		protected override void MinPassed()
		{
		}

		private bool CanPlayerBeAmbushed(global::ScheduleOne.PlayerScripts.Player player)
		{
			return false;
		}

		private void ContractReceiptRecorded(global::ScheduleOne.Economy.ContractReceipt receipt)
		{
		}

		private void SpawnAmbush(global::ScheduleOne.PlayerScripts.Player target, global::UnityEngine.Vector3[] potentialSpawnPoints)
		{
		}
	}
}
