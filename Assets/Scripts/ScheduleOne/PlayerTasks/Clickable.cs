using ScheduleOne.PlayerScripts;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.PlayerTasks
{
	public class Clickable : MonoBehaviour
	{
		public bool ClickableEnabled;

		public bool AutoCalculateOffset;

		public bool FlattenZOffset;

		public UnityEvent<RaycastHit> onClickStart;

		public UnityEvent onClickEnd;

		public virtual CursorManager.ECursorType HoveredCursor { get; protected set; }

		public Vector3 originalHitPoint { get; protected set; }

		public bool IsHeld { get; protected set; }

		private void Awake()
		{
		}

		public virtual void StartClick(RaycastHit hit)
		{
		}

		public virtual void EndClick()
		{
		}

		public void SetOriginalHitPoint(Vector3 hitPoint)
		{
		}
	}
}
