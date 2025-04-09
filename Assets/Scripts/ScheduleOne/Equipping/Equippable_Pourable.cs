using ScheduleOne.ObjectScripts;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Equipping
{
	public class Equippable_Pourable : Equippable_Viewmodel
	{
		[Header("Pourable settings")]
		public float InteractionRange;

		public Pourable PourablePrefab;

		public virtual string InteractionLabel { get; set; }

		protected override void Update()
		{
		}

		protected virtual void StartPourTask(Pot pot)
		{
		}

		protected virtual bool CanPour(Pot pot, out string reason)
		{
			reason = null;
			return false;
		}
	}
}
