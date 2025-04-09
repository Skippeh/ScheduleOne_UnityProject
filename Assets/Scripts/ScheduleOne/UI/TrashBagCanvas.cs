using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Input;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class TrashBagCanvas : Singleton<TrashBagCanvas>
	{
		[Header("References")]
		public Canvas Canvas;

		public InputPrompt InputPrompt;

		public bool IsOpen { get; private set; }

		public void Open()
		{
		}

		public void Close()
		{
		}
	}
}
