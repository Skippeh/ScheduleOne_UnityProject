using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts;
using ScheduleOne.ObjectScripts.Soil;
using UnityEngine;

namespace ScheduleOne.PlayerTasks.Tasks
{
	public class PourSoilTask : PourIntoPotTask
	{
		private PourableSoil soil;

		private Collider HoveredTopCollider;

		public PourSoilTask(Pot _pot, ItemInstance _itemInstance, Pourable _pourablePrefab)
			: base(null, null, null)
		{
		}

		public override void Update()
		{
		}

		public override void StopTask()
		{
		}

		protected override void UpdateCursor()
		{
		}

		private void UpdateHover()
		{
		}

		private Collider GetHoveredTopCollider()
		{
			return null;
		}
	}
}
