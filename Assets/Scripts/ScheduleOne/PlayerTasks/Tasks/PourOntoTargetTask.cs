using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using UnityEngine;

namespace ScheduleOne.PlayerTasks.Tasks
{
	public class PourOntoTargetTask : PourIntoPotTask
	{
		public Transform Target;

		public float SUCCESS_THRESHOLD;

		public float SUCCESS_TIME;

		private float timeOverTarget;

		public PourOntoTargetTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab)
			: base(null, null, null)
		{
		}

		public override void Update()
		{
		}

		public override void StopTask()
		{
		}

		public virtual void TargetReached()
		{
		}
	}
}
