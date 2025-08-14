namespace ScheduleOne.ObjectScripts
{
	public class LabOvenButton : global::UnityEngine.MonoBehaviour
	{
		private const float ANIMATION_TIME = 0.2f;

		public global::UnityEngine.Transform Button;

		public global::UnityEngine.Transform PressedTransform;

		public global::UnityEngine.Transform DepressedTransform;

		public global::ScheduleOne.Misc.ToggleableLight Light;

		public global::ScheduleOne.PlayerTasks.Clickable Clickable;

		private float animationTimer;

		private global::UnityEngine.Vector3 animationStartPos;

		private global::UnityEngine.Vector3 animationEndPos;

		public bool Pressed { get; private set; }

		private void Start()
		{
		}

		public void SetInteractable(bool interactable)
		{
		}

		public void Press(global::UnityEngine.RaycastHit hit)
		{
		}

		public void SetPressed(bool pressed)
		{
		}

		private void Update()
		{
		}
	}
}
