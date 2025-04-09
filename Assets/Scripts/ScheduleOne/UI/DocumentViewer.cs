using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.UI
{
	public class DocumentViewer : Singleton<DocumentViewer>
	{
		[Header("References")]
		public Canvas Canvas;

		public RectTransform[] Documents;

		public UnityEvent onOpen;

		public bool IsOpen { get; protected set; }

		protected override void Start()
		{
		}

		private void Exit(ExitAction action)
		{
		}

		public void Open(string documentName)
		{
		}

		public void Close()
		{
		}
	}
}
