using System;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Tools
{
	public class CountdownText : MonoBehaviour
	{
		public TextMeshProUGUI TimeLabel;

		[Header("Date Setting")]
		public int Year;

		public int Month;

		public int Day;

		public int Hour;

		public int Minute;

		public int Second;

		private DateTime targetPDTDate;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateCountdown()
		{
		}

		private string FormatTime(TimeSpan timeSpan)
		{
			return null;
		}
	}
}
