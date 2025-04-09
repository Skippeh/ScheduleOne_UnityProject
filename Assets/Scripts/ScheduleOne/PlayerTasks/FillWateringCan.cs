using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.Property.Utilities.Water;
using UnityEngine;

namespace ScheduleOne.PlayerTasks
{
	public class FillWateringCan : Task
	{
		protected Tap tap;

		protected WateringCanInstance instance;

		protected WateringCanVisuals visuals;

		private bool audioPlayed;

		public new string TaskName { get; protected set; }

		public FillWateringCan(Tap _tap, WateringCanInstance _instance)
		{
		}

		public override void Update()
		{
		}

		public override void StopTask()
		{
		}

		private void HandleClickStart(RaycastHit hit)
		{
		}

		private void HandleClickEnd()
		{
		}
	}
}
