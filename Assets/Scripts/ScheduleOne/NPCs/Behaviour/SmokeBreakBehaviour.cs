namespace ScheduleOne.NPCs.Behaviour
{
	public class SmokeBreakBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		[global::UnityEngine.Header("Components")]
		public global::ScheduleOne.NPCs.Other.SmokeCigarette SmokeCigarette;

		[global::UnityEngine.Header("Smoke Break Settings")]
		public global::UnityEngine.Vector2Int MinMaxSmokeBreak;

		public float maxDistanceToSmokeLocation;

		[global::UnityEngine.Header("Smoking Locations")]
		public global::System.Collections.Generic.List<global::UnityEngine.Transform> SmokeBreakLocations;

		[global::UnityEngine.Header("Debug")]
		[global::UnityEngine.SerializeField]
		private bool _debugMode;

		[global::UnityEngine.SerializeField]
		private int _ocationOverride;

		[global::UnityEngine.SerializeField]
		private bool _showMaxDistance;

		[global::UnityEngine.SerializeField]
		private bool _showLocationGizmos;

		[global::UnityEngine.SerializeField]
		private bool _showLookAtGizmos;

		private int _smokeBreakDuration;

		private global::UnityEngine.Transform _currentSmokeLocation;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002ESmokeBreakBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002ESmokeBreakBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private void SetupEvents()
		{
		}

		private void CleanUp()
		{
		}

		public override void Enable()
		{
		}

		public override void Activate()
		{
		}

		public override void Deactivate()
		{
		}

		private void BeginSmokeBreak()
		{
		}

		private void EndSmokeBreak()
		{
		}

		private void CheckSmokeBreakEnd()
		{
		}

		private void UpdateSmokeBreakDuration(int amount)
		{
		}

		protected override void WalkCallback(global::ScheduleOne.NPCs.NPCMovement.WalkResult result)
		{
		}

		private void OnTimeSkipped(int skippedTimeInMintues)
		{
		}

		private void OnHourPass()
		{
		}

		[global::EasyButtons.Button]
		public void ChangeLocation()
		{
		}

		[global::EasyButtons.Button]
		public void ActivateSmokeBreak()
		{
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
