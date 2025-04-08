namespace ScheduleOne.UI.Relations
{
	public class RelationCircle : global::UnityEngine.MonoBehaviour
	{
		public const float NotchMinRot = 90f;

		public const float NotchMaxRot = -90f;

		public static global::UnityEngine.Color PortraitColor_ZeroDependence;

		public static global::UnityEngine.Color PortraitColor_MaxDependence;

		public string AssignedNPC_ID;

		public global::ScheduleOne.NPCs.NPC AssignedNPC;

		public global::System.Action onClicked;

		public global::System.Action onHoverStart;

		public global::System.Action onHoverEnd;

		public bool AutoSetName;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Rect;

		public global::UnityEngine.UI.Image PortraitBackground;

		public global::UnityEngine.UI.Image HeadshotImg;

		public global::UnityEngine.RectTransform NotchPivot;

		public global::UnityEngine.RectTransform Locked;

		public global::UnityEngine.UI.Button Button;

		public global::UnityEngine.EventSystems.EventTrigger Trigger;

		private void Awake()
		{
		}

		private void OnValidate()
		{
		}

		public void AssignNPC(global::ScheduleOne.NPCs.NPC npc)
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

		[global::EasyButtons.Button]
		public void SetLocked()
		{
		}

		[global::EasyButtons.Button]
		public void SetUnlocked(global::ScheduleOne.NPCs.Relation.NPCRelationData.EUnlockType unlockType, bool notify = true)
		{
		}

		[global::EasyButtons.Button]
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
