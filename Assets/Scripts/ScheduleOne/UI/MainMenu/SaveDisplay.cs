using ScheduleOne.Persistence;
using UnityEngine;

namespace ScheduleOne.UI.MainMenu
{
	public class SaveDisplay : MonoBehaviour
	{
		[Header("References")]
		public RectTransform[] Slots;

		public void Awake()
		{
		}

		public void Refresh()
		{
		}

		public void SetDisplayedSave(int index, SaveInfo info)
		{
		}

		private float RoundToDecimalPlaces(float value, int decimalPlaces)
		{
			return 0f;
		}

		public static float ToSingle(double value)
		{
			return 0f;
		}

		private string GetTimeLabel(int hours)
		{
			return null;
		}
	}
}
