namespace ScheduleOne.Audio
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Audio.AudioSourceController))]
	public class AmbientLoopJukebox : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.AnimationCurve VolumeCurve;

		public global::System.Collections.Generic.List<global::UnityEngine.AudioClip> Clips;

		private global::ScheduleOne.Audio.AudioSourceController audioSourceController;

		private int currentClipIndex;

		private float musicScale;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void MinPass()
		{
		}
	}
}
