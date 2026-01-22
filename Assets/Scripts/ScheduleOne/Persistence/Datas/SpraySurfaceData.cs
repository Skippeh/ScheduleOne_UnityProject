namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class SpraySurfaceData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> Strokes;

		public bool ContainsCartelGraffiti;

		public SpraySurfaceData(global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> strokes, bool containsCartelGraffiti)
		{
		}
	}
}
