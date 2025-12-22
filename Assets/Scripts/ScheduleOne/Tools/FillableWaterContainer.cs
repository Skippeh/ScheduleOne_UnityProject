namespace ScheduleOne.Tools
{
	public class FillableWaterContainer : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Range(0f, 1f)]
		public float MaxTapOpenValue;

		public global::ScheduleOne.Tools.WaterContainerVisualizer Visuals;

		public global::ScheduleOne.Audio.AudioSourceController FillSound;
	}
}
