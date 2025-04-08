namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class FootprintMatchData
	{
		public string TileOwnerGUID;

		public int TileIndex;

		public global::UnityEngine.Vector2 FootprintCoordinate;

		public FootprintMatchData(string tileOwnerGUID, int tileIndex, global::UnityEngine.Vector2 footprintCoordinate)
		{
		}
	}
}
