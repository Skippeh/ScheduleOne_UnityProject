using System;
using ScheduleOne.DevUtilities;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class SupplierData : NPCData
	{
		public int timeSinceMeetingStart;

		public int timeSinceLastMeetingEnd;

		public float debt;

		public int minsUntilDeadDropReady;

		public StringIntPair[] deaddropItems;

		public bool debtReminderSent;

		public SupplierData(string id, int _timeSinceMeetingStart, int _timeSinceLastMeetingEnd, float _debt, int _minsUntilDeadDropReady, StringIntPair[] _deaddropItems, bool _debtReminderSent)
			: base(null)
		{
		}
	}
}
