using System;
using ScheduleOne.Persistence.Datas;

namespace ScheduleOne.Persistence
{
	public class SaveInfo
	{
		public string SavePath;

		public int SaveSlotNumber;

		public string OrganisationName;

		public DateTime DateCreated;

		public DateTime DateLastPlayed;

		public float Networth;

		public string SaveVersion;

		public MetaData MetaData;

		public SaveInfo(string savePath, int saveSlotNumber, string organisationName, DateTime dateCreated, DateTime dateLastPlayed, float networth, string saveVersion, MetaData metaData)
		{
		}
	}
}
