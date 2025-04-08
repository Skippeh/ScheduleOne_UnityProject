namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class SerializedSaveData
	{
		[global::System.NonSerialized]
		public static string _DataType;

		public string DataType;

		[global::System.NonSerialized]
		public static int _DataVersion;

		public int DataVersion;

		public string Version => null;
	}
}
