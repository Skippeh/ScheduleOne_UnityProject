namespace ScheduleOne.Cutscenes
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Animation))]
	public class Cutscene : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		public string Name;

		public bool DisablePlayerControl;

		public bool OverrideFOV;

		public float CameraFOV;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform CameraControl;

		[global::UnityEngine.Header("Events")]
		public global::UnityEngine.Events.UnityEvent onPlay;

		public global::UnityEngine.Events.UnityEvent onEnd;

		private global::UnityEngine.Animation animation;

		public bool IsPlaying { get; private set; }

		protected virtual void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public virtual void Play()
		{
		}

		public void InvokeEnd()
		{
		}
	}
}
