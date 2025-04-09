using System;
using ScheduleOne.ItemFramework;

namespace ScheduleOne.ObjectScripts
{
	[Serializable]
	public class DryingOperation
	{
		public string ItemID;

		public int Quantity;

		public EQuality StartQuality;

		public int Time;

		public DryingOperation(string itemID, int quantity, EQuality startQuality, int time)
		{
		}

		public DryingOperation()
		{
		}

		public void IncreaseQuality()
		{
		}

		public QualityItemInstance GetQualityItemInstance()
		{
			return null;
		}

		public EQuality GetQuality()
		{
			return default(EQuality);
		}
	}
}
