using System;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	public class ClipboardScreen : MonoBehaviour
	{
		[Header("References")]
		public RectTransform Container;

		[Header("Settings")]
		public float ClosedOffset;

		public bool OpenOnStart;

		public bool UseExitListener;

		public int ExitActionPriority;

		private Coroutine lerpRoutine;

		public bool IsOpen { get; protected set; }

		protected virtual void Start()
		{
		}

		private void Exit(ExitAction exitAction)
		{
		}

		public virtual void Open()
		{
		}

		public virtual void Close()
		{
		}

		private void Lerp(bool open, Action callback)
		{
		}
	}
}
