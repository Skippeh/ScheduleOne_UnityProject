namespace ScheduleOne.Law
{
	public class CheckpointManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Law.CheckpointManager>
	{
		public enum ECheckpointLocation
		{
			Western = 0,
			Docks = 1,
			NorthResidential = 2,
			WestResidential = 3
		}

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Police.RoadCheckpoint WesternCheckpoint;

		public global::ScheduleOne.Police.RoadCheckpoint DocksCheckpoint;

		public global::ScheduleOne.Police.RoadCheckpoint NorthResidentialCheckpoint;

		public global::ScheduleOne.Police.RoadCheckpoint WestResidentialCheckpoint;

		private bool NetworkInitialize___EarlyScheduleOne_002ELaw_002ECheckpointManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ELaw_002ECheckpointManagerAssembly_002DCSharp_002Edll_Excuted;

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void SetCheckpointEnabled(global::ScheduleOne.Law.CheckpointManager.ECheckpointLocation checkpoint, bool enabled, int requestedOfficers)
		{
		}

		public global::ScheduleOne.Police.RoadCheckpoint GetCheckpoint(global::ScheduleOne.Law.CheckpointManager.ECheckpointLocation loc)
		{
			return null;
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		public override void Awake()
		{
		}
	}
}
