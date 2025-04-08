namespace ScheduleOne.Map
{
	public class Gate : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.Transform Gate1;

		public global::UnityEngine.Vector3 Gate1Open;

		public global::UnityEngine.Vector3 Gate1Closed;

		public global::UnityEngine.Transform Gate2;

		public global::UnityEngine.Vector3 Gate2Open;

		public global::UnityEngine.Vector3 Gate2Closed;

		public float OpenSpeed;

		public float Acceleration;

		[global::UnityEngine.Header("Sound")]
		public global::ScheduleOne.Audio.AudioSourceController[] StartSounds;

		public global::ScheduleOne.Audio.AudioSourceController[] LoopSounds;

		public global::ScheduleOne.Audio.AudioSourceController[] StopSounds;

		private float Momentum;

		private float openDelta;

		public bool IsOpen { get; protected set; }

		private void Update()
		{
		}

		[global::EasyButtons.Button]
		public void Open()
		{
		}

		[global::EasyButtons.Button]
		public void Close()
		{
		}
	}
}
