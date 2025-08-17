namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class SpraySurfaceData : global::ScheduleOne.Persistence.Datas.SaveData
	{
		public string GUID;

		public bool HasDrawingBeenFinalized;

		public global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> Strokes;

		public SpraySurfaceData(string guid, bool hasDrawingBeenFinalized, global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> strokes)
		{
		}
	}
}
