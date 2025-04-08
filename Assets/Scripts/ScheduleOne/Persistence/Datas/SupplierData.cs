namespace ScheduleOne.Persistence.Datas
{
	[global::System.Serializable]
	public class SupplierData : global::ScheduleOne.Persistence.Datas.NPCData
	{
		public int timeSinceMeetingStart;

		public int timeSinceLastMeetingEnd;

		public float debt;

		public int minsUntilDeadDropReady;

		public global::ScheduleOne.DevUtilities.StringIntPair[] deaddropItems;

		public bool debtReminderSent;

		public SupplierData(string id, int _timeSinceMeetingStart, int _timeSinceLastMeetingEnd, float _debt, int _minsUntilDeadDropReady, global::ScheduleOne.DevUtilities.StringIntPair[] _deaddropItems, bool _debtReminderSent)
			: base(null)
		{
		}
	}
}
