using System;
using ScheduleOne.NPCs;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Management
{
	public class WorldspaceUIElement : MonoBehaviour
	{
		public const float TRANSITION_TIME = 0.1f;

		[Header("References")]
		public RectTransform RectTransform;

		public RectTransform Container;

		public TextMeshProUGUI TitleLabel;

		public AssignedWorkerDisplay AssignedWorkerDisplay;

		private Coroutine scaleRoutine;

		public bool IsEnabled { get; protected set; }

		public bool IsVisible => false;

		public virtual void Show()
		{
		}

		public virtual void Hide(Action callback = null)
		{
		}

		public virtual void Destroy()
		{
		}

		public void UpdatePosition(Vector3 worldSpacePosition)
		{
		}

		public virtual void SetInternalScale(float scale)
		{
		}

		private void SetScale(float scale, Action callback)
		{
		}

		public virtual void HoverStart()
		{
		}

		public virtual void HoverEnd()
		{
		}

		public void SetAssignedNPC(NPC npc)
		{
		}
	}
}
