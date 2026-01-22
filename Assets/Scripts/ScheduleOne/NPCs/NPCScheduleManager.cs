namespace ScheduleOne.NPCs
{
	public class NPCScheduleManager : global::UnityEngine.MonoBehaviour
	{
		private static readonly global::ScheduleOne.NPCs.Schedules.NPCActionOrderByDescending orderByDescending;

		public bool DEBUG_MODE;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject[] EnabledDuringCurfew;

		public global::UnityEngine.GameObject[] EnabledDuringNoCurfew;

		public global::System.Collections.Generic.List<global::ScheduleOne.NPCs.Schedules.NPCAction> ActionList;

		protected int lastProcessedTime;

		public bool ScheduleEnabled { get; protected set; }

		public bool CurfewModeEnabled { get; protected set; }

		public global::ScheduleOne.NPCs.Schedules.NPCAction ActiveAction { get; set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.NPCs.Schedules.NPCAction> PendingActions { get; set; }

		public global::ScheduleOne.NPCs.NPC Npc { get; protected set; }

		protected global::System.Collections.Generic.List<global::ScheduleOne.NPCs.Schedules.NPCAction> ActionsAwaitingStart { get; set; }

		protected global::ScheduleOne.GameTime.TimeManager Time => null;

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		private void LocalPlayerSpawned()
		{
		}

		private void OnValidate()
		{
		}

		protected virtual void Update()
		{
		}

		public void EnableSchedule()
		{
		}

		public void DisableSchedule()
		{
		}

		[global::EasyButtons.Button]
		public void InitializeActions()
		{
		}

		protected virtual void OnMinPass()
		{
		}

		private void UpdateActions()
		{
		}

		protected virtual void OnTick()
		{
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.NPCs.Schedules.NPCAction> GetActionsOccurringAt(int time)
		{
			return null;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.NPCs.Schedules.NPCAction> GetActionsTotallyOccurringWithinRange(int min, int max, bool checkShouldStart)
		{
			return null;
		}

		private void StartAction(global::ScheduleOne.NPCs.Schedules.NPCAction action)
		{
		}

		private void EnforceState()
		{
		}

		public void EnforceState(bool initial = false)
		{
		}

		protected virtual void CurfewEnabled()
		{
		}

		protected virtual void CurfewDisabled()
		{
		}

		public void SetCurfewModeEnabled(bool enabled)
		{
		}
	}
}
