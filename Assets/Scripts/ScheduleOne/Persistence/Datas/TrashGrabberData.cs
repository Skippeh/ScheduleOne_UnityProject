namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class TrashGrabberData : global::ScheduleOne.Persistence.Datas.ItemData
	{
		public global::ScheduleOne.Persistence.TrashContentData Content;

		public TrashGrabberData(string iD, int quantity, global::ScheduleOne.Persistence.TrashContentData content)
			: base(null, 0)
		{
		}
	}
}
