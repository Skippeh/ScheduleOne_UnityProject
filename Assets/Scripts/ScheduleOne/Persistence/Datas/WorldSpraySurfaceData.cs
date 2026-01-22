namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class WorldSpraySurfaceData : global::ScheduleOne.Persistence.Datas.SpraySurfaceData
	{
		public string GUID;

		public bool HasDrawingBeenFinalized;

		public WorldSpraySurfaceData(global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> strokes, bool containsCartelGraffiti, string guid, bool hasBeenFinalized)
			: base(null, containsCartelGraffiti: false)
		{
		}
	}
}
