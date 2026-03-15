namespace ScheduleOne.Weather
{
	public class PuddleVolume : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::UnityEngine.GameObject> _puddleObjs;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2Int _minMaxPuddlesInVolume;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2 _minMaxPuddleDecay;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2 _minMaxGrowthRate;

		private float _decayRate;

		private float _growthRate;

		private void Start()
		{
		}

		private void RandomiseActivePuddles()
		{
		}

		private void Update()
		{
		}

		public void UpdateRates(global::ScheduleOne.Weather.WeatherConditions weatherConditions)
		{
		}
	}
}
