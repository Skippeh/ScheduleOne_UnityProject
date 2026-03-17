namespace ScheduleOne.Weather
{
	[global::UnityEngine.CreateAssetMenu(fileName = "WeatherSequence", menuName = "ScriptableObjects/Weather/Weather Sequence")]
	public class WeatherSequence : global::UnityEngine.ScriptableObject
	{
		[global::System.Serializable]
		public class SequenceItem
		{
			public global::ScheduleOne.Weather.WeatherVolume Volume;

			public int ActiveTime;

			public int TransitionInTime;
		}

		public enum TimeReference
		{
			StartOfDay = 0,
			OnInitialisation = 1,
			Custom = 2
		}

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private string _id;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _chanceToOccur;

		[global::UnityEngine.SerializeField]
		private int _startTime;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Weather.WeatherSequence.TimeReference _timeReference;

		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Weather.WeatherSequence.SequenceItem> _weatherVolumes;

		public string Id => null;

		public global::System.Collections.Generic.List<global::ScheduleOne.Weather.WeatherSequence.SequenceItem> WeatherVolumes => null;

		public global::ScheduleOne.Weather.WeatherSequence.TimeReference TimeRef => default(global::ScheduleOne.Weather.WeatherSequence.TimeReference);

		public int StartTime => 0;
	}
}
