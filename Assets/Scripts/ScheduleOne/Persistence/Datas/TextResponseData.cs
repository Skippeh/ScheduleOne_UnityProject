using System;

namespace ScheduleOne.Persistence.Datas
{
	[Serializable]
	public class TextResponseData
	{
		public string Text;

		public string Label;

		public TextResponseData(string text, string label)
		{
		}

		public TextResponseData()
		{
		}
	}
}
