namespace ScheduleOne.Tools
{
	[global::UnityEngine.ExecuteInEditMode]
	public class WheelRotator : global::UnityEngine.MonoBehaviour
	{
		public float Radius;

		public global::UnityEngine.Transform Wheel;

		public bool Flip;

		public global::ScheduleOne.Audio.AudioSourceController Controller;

		public float AudioVolumeDivisor;

		public global::UnityEngine.Vector3 RotationAxis;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector3 lastFramePosition;

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}
	}
}
