namespace ScheduleOne.VoiceOver
{
	public class PoliceChatterVO : global::ScheduleOne.VoiceOver.VOEmitter
	{
		public global::ScheduleOne.Audio.AudioSourceController StartBeep;

		public global::ScheduleOne.Audio.AudioSourceController StartEndBeep;

		public global::ScheduleOne.Audio.AudioSourceController Static;

		private global::UnityEngine.Coroutine chatterRoutine;

		public override void Play(global::ScheduleOne.VoiceOver.EVOLineType lineType)
		{
		}

		private void PlayChatter()
		{
		}
	}
}
