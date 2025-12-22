namespace ScheduleOne.NPCs.Behaviour
{
	public class SewerGoblinRetrieveBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		public const float PROXIMITY_THRESHOLD = 2f;

		public const float TIMEOUT = 20f;

		private global::ScheduleOne.NPCs.CharacterClasses.SewerGoblin sewerGoblin;

		public global::System.Action onRetrieveComplete;

		public global::System.Action onRetrieveCancelled;

		private float timeSinceStart;

		private bool grabbing;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002ESewerGoblinRetrieveBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002ESewerGoblinRetrieveBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.PlayerScripts.Player Target => null;

		public override void Awake()
		{
		}

		public override void Activate()
		{
		}

		public override void Resume()
		{
		}

		public override void Deactivate()
		{
		}

		public override void Pause()
		{
		}

		private void StartBehaviour()
		{
		}

		private void StopBehaviour()
		{
		}

		public void CancelRetrieve()
		{
		}

		private void CompleteRetrieve()
		{
		}

		public override void BehaviourUpdate()
		{
		}

		private bool IsTargetDestinationValid()
		{
			return false;
		}

		private bool GetNewDestination(out global::UnityEngine.Vector3 dest)
		{
			dest = default(global::UnityEngine.Vector3);
			return false;
		}

		private bool WithinRangeOfTarget()
		{
			return false;
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002EBehaviour_002ESewerGoblinRetrieveBehaviour_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
