using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Persistence
{
	public class SavePoint : MonoBehaviour
	{
		public const float SAVE_COOLDOWN = 60f;

		public InteractableObject IntObj;

		public UnityEvent onSaveStart;

		public UnityEvent onSaveComplete;

		public void Awake()
		{
		}

		public void Hovered()
		{
		}

		private bool CanSave(out string reason)
		{
			reason = null;
			return false;
		}

		public void Interacted()
		{
		}

		private void Save()
		{
		}

		public void OnSaveComplete()
		{
		}
	}
}
