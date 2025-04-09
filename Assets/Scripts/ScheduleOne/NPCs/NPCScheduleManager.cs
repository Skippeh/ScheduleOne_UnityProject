using System.Collections.Generic;
using EasyButtons;
using ScheduleOne.GameTime;
using ScheduleOne.NPCs.Schedules;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	public class NPCScheduleManager : MonoBehaviour
	{
		public bool DEBUG_MODE;

		[Header("References")]
		public GameObject[] EnabledDuringCurfew;

		public GameObject[] EnabledDuringNoCurfew;

		public List<NPCAction> ActionList;

		protected int lastProcessedTime;

		public bool ScheduleEnabled { get; protected set; }

		public bool CurfewModeEnabled { get; protected set; }

		public NPCAction ActiveAction { get; set; }

		public List<NPCAction> PendingActions { get; set; }

		public NPC Npc { get; protected set; }

		protected List<NPCAction> ActionsAwaitingStart { get; set; }

		protected TimeManager Time => null;

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

		[Button]
		public void InitializeActions()
		{
		}

		protected virtual void MinPass()
		{
		}

		private List<NPCAction> GetActionsOccurringAt(int time)
		{
			return null;
		}

		private List<NPCAction> GetActionsTotallyOccurringWithinRange(int min, int max, bool checkShouldStart)
		{
			return null;
		}

		private void StartAction(NPCAction action)
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
