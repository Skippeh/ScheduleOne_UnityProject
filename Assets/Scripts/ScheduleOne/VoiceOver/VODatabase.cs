namespace ScheduleOne.VoiceOver
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "VODatabase", menuName = "ScriptableObjects/VODatabase")]
	public class VODatabase : global::UnityEngine.ScriptableObject
	{
		[global::UnityEngine.Range(0f, 2f)]
		public float VolumeMultiplier;

		public global::System.Collections.Generic.List<global::ScheduleOne.VoiceOver.VODatabaseEntry> Entries;

		public global::ScheduleOne.VoiceOver.VODatabaseEntry GetEntry(global::ScheduleOne.VoiceOver.EVOLineType lineType)
		{
			return null;
		}

		public global::UnityEngine.AudioClip GetRandomClip(global::ScheduleOne.VoiceOver.EVOLineType lineType)
		{
			return null;
		}
	}
}
