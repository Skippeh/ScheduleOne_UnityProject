namespace ScheduleOne.Growing
{
	public class PotMoistureDisplay : global::ScheduleOne.Growing.GrowContainerMoistureDisplay
	{
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.GameObject _temperatureBoostIndicator;

		private global::ScheduleOne.ObjectScripts.Pot _pot;

		protected override void Awake()
		{
		}

		protected override void UpdateCanvasContents()
		{
		}
	}
}
