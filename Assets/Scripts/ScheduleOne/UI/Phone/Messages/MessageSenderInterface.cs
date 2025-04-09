using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Messaging;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone.Messages
{
	public class MessageSenderInterface : MonoBehaviour
	{
		public enum EVisibility
		{
			Hidden = 0,
			Docked = 1,
			Expanded = 2
		}

		public EVisibility Visibility;

		[Header("Settings")]
		public float DockedMenuYPos;

		public float ExpandedMenuYPos;

		[Header("References")]
		public RectTransform Menu;

		public RectTransform SendablesContainer;

		public RectTransform[] DockedUIElements;

		public RectTransform[] ExpandedUIElements;

		public Button ComposeButton;

		public Button[] CancelButtons;

		private List<MessageBubble> sendableBubbles;

		private Dictionary<MessageBubble, SendableMessage> sendableMap;

		public void Awake()
		{
		}

		public void Start()
		{
		}

		private void Exit(ExitAction exit)
		{
		}

		public void SetVisibility(EVisibility visibility)
		{
		}

		public void UpdateSendables()
		{
		}

		public void AddSendable(SendableMessage sendable)
		{
		}

		protected virtual void SendableSelected(SendableMessage sendable)
		{
		}
	}
}
