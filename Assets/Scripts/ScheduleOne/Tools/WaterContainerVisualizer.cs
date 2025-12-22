namespace ScheduleOne.Tools
{
	public class WaterContainerVisualizer : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Tools.TransformLerp[] _waterTransformLerps;

		private global::ScheduleOne.ItemFramework.WaterContainerInstance _assignedWaterContainer;

		public void AssignWaterContainer(global::ScheduleOne.ItemFramework.WaterContainerInstance waterContainer)
		{
		}

		public void UnassignWaterContainer()
		{
		}

		private void WaterContainerChanged()
		{
		}

		private void SetFillLevel(float normalizedFillLevel)
		{
		}
	}
}
