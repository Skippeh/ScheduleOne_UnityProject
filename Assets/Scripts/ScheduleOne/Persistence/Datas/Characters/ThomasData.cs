namespace ScheduleOne.Persistence.Datas.Characters
{
	public class ThomasData : global::ScheduleOne.Persistence.Datas.NPCData
	{
		public bool MeetingReminderSent;

		public bool HandoverReminderSent;

		public ThomasData(string id, bool meetingReminderSent, bool handoverReminderSent)
			: base(null)
		{
		}
	}
}
