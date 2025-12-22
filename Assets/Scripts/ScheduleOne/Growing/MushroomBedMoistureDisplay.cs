namespace ScheduleOne.Growing
{
	public class MushroomBedMoistureDisplay : global::ScheduleOne.Growing.GrowContainerMoistureDisplay
	{
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.GameObject _tooHotIndicator;

		private global::ScheduleOne.ObjectScripts.MushroomBed _bed;

		protected override void Awake()
		{
		}

		protected override void UpdateCanvasContents()
		{
		}
	}
}
