namespace ScheduleOne.PlayerScripts
{
	public class WaterContainerPourable : global::ScheduleOne.PlayerTasks.Pourable
	{
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Tools.WaterContainerVisualizer _visuals;

		private global::ScheduleOne.ItemFramework.WaterContainerInstance _waterContainerItem;

		public void SetupWaterContainerPourable(global::ScheduleOne.ItemFramework.WaterContainerInstance waterContainer)
		{
		}

		private void OnDestroy()
		{
		}

		protected override void PourAmount(float amount)
		{
		}
	}
}
