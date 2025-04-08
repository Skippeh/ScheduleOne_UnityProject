namespace ScheduleOne.UI.Management
{
	public class WorldspaceUIElement : global::UnityEngine.MonoBehaviour
	{
		public const float TRANSITION_TIME = 0.1f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform RectTransform;

		public global::UnityEngine.RectTransform Container;

		public global::TMPro.TextMeshProUGUI TitleLabel;

		public global::ScheduleOne.UI.Management.AssignedWorkerDisplay AssignedWorkerDisplay;

		private global::UnityEngine.Coroutine scaleRoutine;

		public bool IsEnabled { get; protected set; }

		public bool IsVisible => false;

		public virtual void Show()
		{
		}

		public virtual void Hide(global::System.Action callback = null)
		{
		}

		public virtual void Destroy()
		{
		}

		public void UpdatePosition(global::UnityEngine.Vector3 worldSpacePosition)
		{
		}

		public virtual void SetInternalScale(float scale)
		{
		}

		private void SetScale(float scale, global::System.Action callback)
		{
		}

		public virtual void HoverStart()
		{
		}

		public virtual void HoverEnd()
		{
		}

		public void SetAssignedNPC(global::ScheduleOne.NPCs.NPC npc)
		{
		}
	}
}
