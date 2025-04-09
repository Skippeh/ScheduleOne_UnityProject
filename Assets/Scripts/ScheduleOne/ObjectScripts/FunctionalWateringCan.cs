using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.PlayerTasks;

namespace ScheduleOne.ObjectScripts
{
	public class FunctionalWateringCan : Pourable
	{
		public WateringCanVisuals Visuals;

		private WateringCanInstance itemInstance;

		public void Setup(WateringCanInstance instance)
		{
		}

		protected override void PourAmount(float amount)
		{
		}
	}
}
