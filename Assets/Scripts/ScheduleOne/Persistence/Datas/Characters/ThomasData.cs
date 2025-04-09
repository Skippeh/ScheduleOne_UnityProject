namespace ScheduleOne.Persistence.Datas.Characters
{
	public class ThomasData : NPCData
	{
		public bool MeetingReminderSent;

		public bool HandoverReminderSent;

		public ThomasData(string id, bool meetingReminderSent, bool handoverReminderSent)
			: base(null)
		{
		}
	}
}
