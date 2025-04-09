using FishNet.Connection;
using ScheduleOne.DevUtilities;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.Law
{
	public class CheckpointManager : NetworkSingleton<CheckpointManager>
	{
		public enum ECheckpointLocation
		{
			Western = 0,
			Docks = 1,
			NorthResidential = 2,
			WestResidential = 3
		}

		[Header("References")]
		public RoadCheckpoint WesternCheckpoint;

		public RoadCheckpoint DocksCheckpoint;

		public RoadCheckpoint NorthResidentialCheckpoint;

		public RoadCheckpoint WestResidentialCheckpoint;

		private bool NetworkInitialize___EarlyScheduleOne_002ELaw_002ECheckpointManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ELaw_002ECheckpointManagerAssembly_002DCSharp_002Edll_Excuted;

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public void SetCheckpointEnabled(ECheckpointLocation checkpoint, bool enabled, int requestedOfficers)
		{
		}

		public RoadCheckpoint GetCheckpoint(ECheckpointLocation loc)
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
