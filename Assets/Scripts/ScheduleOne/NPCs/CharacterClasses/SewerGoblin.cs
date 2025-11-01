namespace ScheduleOne.NPCs.CharacterClasses
{
	public class SewerGoblin : global::ScheduleOne.NPCs.NPC
	{
		public enum ESewerGoblinState
		{
			Inactive = 0,
			Attacking = 1,
			Retrieving = 2,
			Retreating = 3
		}

		public const int COOLDOWN_HOURS_BETWEEN_DEPLOYS = 12;

		public const float HOURLY_DEPLOY_CHANCE = 0.1f;

		public const float NORMALIZED_HEALTH_THRESHOLD_TO_RETREAT = 0.5f;

		public const float RETREAT_CHANCE_AFTER_HIT = 0.3f;

		public const int MAX_CANCELLED_RETRIEVE_ATTEMPTS = 3;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Map.NPCEnterableBuilding SewerHidingBuilding;

		public global::ScheduleOne.NPCs.Schedules.NPCEvent_StayInBuilding StayInBuildingEvent;

		public global::ScheduleOne.ItemFramework.ItemDefinition PacifyItem;

		public global::ScheduleOne.NPCs.Behaviour.SewerGoblinRetrieveBehaviour RetrieveBehaviour;

		public global::ScheduleOne.Audio.AudioSourceController ExitSound;

		[global::UnityEngine.HideInInspector]
		public int cancelledRetrieveAttempts;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ECharacterClasses_002ESewerGoblinAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ECharacterClasses_002ESewerGoblinAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.PlayerScripts.Player TargetPlayer { get; private set; }

		public global::ScheduleOne.NPCs.CharacterClasses.SewerGoblin.ESewerGoblinState CurrentState { get; private set; }

		public int HoursSinceLastDeploy { get; set; }

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		private void OnMinPass()
		{
		}

		private void OnHourPass()
		{
		}

		public void DeployToPlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		private void AttackTarget()
		{
		}

		public void Retreat()
		{
		}

		protected override void EnterBuilding(string buildingGUID, int doorIndex)
		{
		}

		protected override void ExitBuilding(global::ScheduleOne.Map.NPCEnterableBuilding building)
		{
		}

		public void DeployToLocalPlayer()
		{
		}

		private void OnSuccesfulCombatHit()
		{
		}

		private bool CanBeginRetieve()
		{
			return false;
		}

		private void BeginRetrieve()
		{
		}

		private void OnRetrieveCancel()
		{
		}

		private void OnRetrieveSuccess()
		{
		}

		public bool IsPlayerValidTarget(global::ScheduleOne.PlayerScripts.Player player)
		{
			return false;
		}

		public bool IsPlayerHoldingPacifyItem(global::ScheduleOne.PlayerScripts.Player player)
		{
			return false;
		}

		public override void ProcessImpactForce(global::UnityEngine.Vector3 forcePoint, global::UnityEngine.Vector3 forceDirection, float force)
		{
		}

		private void OnTakeDamage(float damageAmount)
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ECharacterClasses_002ESewerGoblin_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
