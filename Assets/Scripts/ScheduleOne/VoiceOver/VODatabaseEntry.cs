namespace ScheduleOne.VoiceOver
{
	[global::System.Serializable]
	public class VODatabaseEntry
	{
		public global::ScheduleOne.VoiceOver.EVOLineType LineType;

		public global::UnityEngine.AudioClip[] Clips;

		private global::UnityEngine.AudioClip lastClip;

		public float VolumeMultiplier;

		public global::UnityEngine.AudioClip GetRandomClip()
		{
			return null;
		}
	}
}
