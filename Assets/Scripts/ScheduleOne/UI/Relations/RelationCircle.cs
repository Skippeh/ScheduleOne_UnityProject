using System;
using EasyButtons;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Relation;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Relations
{
	public class RelationCircle : MonoBehaviour
	{
		public const float NotchMinRot = 90f;

		public const float NotchMaxRot = -90f;

		public static Color PortraitColor_ZeroDependence;

		public static Color PortraitColor_MaxDependence;

		public string AssignedNPC_ID;

		public NPC AssignedNPC;

		public Action onClicked;

		public Action onHoverStart;

		public Action onHoverEnd;

		public bool AutoSetName;

		[Header("References")]
		public RectTransform Rect;

		public Image PortraitBackground;

		public Image HeadshotImg;

		public RectTransform NotchPivot;

		public RectTransform Locked;

		public Button Button;

		public EventTrigger Trigger;

		private void Awake()
		{
		}

		private void OnValidate()
		{
		}

		public void AssignNPC(NPC npc)
		{
		}

		private void UnassignNPC()
		{
		}

		private void RelationshipChange(float change)
		{
		}

		public void SetNotchPosition(float relationshipDelta)
		{
		}

		private void RefreshNotchPosition()
		{
		}

		private void RefreshDependenceDisplay()
		{
		}

		[Button]
		public void SetLocked()
		{
		}

		[Button]
		public void SetUnlocked(NPCRelationData.EUnlockType unlockType, bool notify = true)
		{
		}

		[Button]
		public void LoadNPCData()
		{
		}

		private void UpdateBlackout()
		{
		}

		public void SetBlackedOut(bool blackedOut)
		{
		}

		private void ButtonClicked()
		{
		}

		private void HoverStart()
		{
		}

		private void HoverEnd()
		{
		}
	}
}
