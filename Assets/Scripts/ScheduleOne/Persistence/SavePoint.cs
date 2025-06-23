namespace ScheduleOne.Persistence
{
	public class SavePoint : global::UnityEngine.MonoBehaviour
	{
		public const float SAVE_COOLDOWN = 60f;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Events.UnityEvent onSaveStart;

		public global::UnityEngine.Events.UnityEvent onSaveComplete;

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

		public void OnSaveStart()
		{
		}

		public void OnSaveComplete()
		{
		}
	}
}
