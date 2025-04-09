using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Cutscenes
{
	[RequireComponent(typeof(Animation))]
	public class Cutscene : MonoBehaviour
	{
		[Header("Settings")]
		public string Name;

		public bool DisablePlayerControl;

		public bool OverrideFOV;

		public float CameraFOV;

		[Header("References")]
		public Transform CameraControl;

		[Header("Events")]
		public UnityEvent onPlay;

		public UnityEvent onEnd;

		private Animation animation;

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
