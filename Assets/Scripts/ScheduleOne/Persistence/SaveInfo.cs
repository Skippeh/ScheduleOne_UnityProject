namespace ScheduleOne.Persistence
{
	public class SaveInfo
	{
		public string SavePath;

		public int SaveSlotNumber;

		public string OrganisationName;

		public global::System.DateTime DateCreated;

		public global::System.DateTime DateLastPlayed;

		public float Networth;

		public string SaveVersion;

		public global::ScheduleOne.Persistence.Datas.MetaData MetaData;

		public SaveInfo(string savePath, int saveSlotNumber, string organisationName, global::System.DateTime dateCreated, global::System.DateTime dateLastPlayed, float networth, string saveVersion, global::ScheduleOne.Persistence.Datas.MetaData metaData)
		{
		}
	}
}
