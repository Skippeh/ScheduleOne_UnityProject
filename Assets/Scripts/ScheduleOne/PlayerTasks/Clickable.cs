namespace ScheduleOne.PlayerTasks
{
	public class Clickable : global::UnityEngine.MonoBehaviour
	{
		public bool ClickableEnabled;

		public bool AutoCalculateOffset;

		public bool FlattenZOffset;

		public global::UnityEngine.Events.UnityEvent<global::UnityEngine.RaycastHit> onClickStart;

		public global::UnityEngine.Events.UnityEvent onClickEnd;

		public virtual global::ScheduleOne.PlayerScripts.CursorManager.ECursorType HoveredCursor { get; protected set; }

		public global::UnityEngine.Vector3 originalHitPoint { get; protected set; }

		public bool IsHeld { get; protected set; }

		private void Awake()
		{
		}

		public virtual void StartClick(global::UnityEngine.RaycastHit hit)
		{
		}

		public virtual void EndClick()
		{
		}

		public void SetOriginalHitPoint(global::UnityEngine.Vector3 hitPoint)
		{
		}
	}
}
