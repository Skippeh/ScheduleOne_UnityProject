namespace ScheduleOne.Weather
{
	[global::UnityEngine.CreateAssetMenu(fileName = "WeatherBasedObjectProvider", menuName = "ScriptableObjects/Weather/Weather Based Object Provider")]
	public class WeatherBasedObjectProvider : global::UnityEngine.ScriptableObject
	{
		[global::System.Serializable]
		public enum EvaluationType
		{
			LessThan = 0,
			Equals = 1,
			GreaterThan = 2,
			Blend = 3
		}

		[global::System.Flags]
		public enum ConditionFlags
		{
			None = 0,
			Sunny = 1,
			Cloudy = 2,
			Rainy = 4,
			Stormy = 8,
			Snowy = 0x10,
			Foggy = 0x20,
			Windy = 0x40,
			Hail = 0x80,
			Sleet = 0x100
		}

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Weather.WeatherBasedObjectProvider.ConditionFlags _selectedConditions;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Weather.WeatherConditions _conditions;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Weather.WeatherBasedObjectProvider.EvaluationType _evaluationType;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Object _object;

		public global::UnityEngine.Object Object => null;

		public bool DoesSatisfyConditions(global::ScheduleOne.Weather.WeatherConditions activeConditions)
		{
			return false;
		}

		public float GetAverageBlend(global::ScheduleOne.Weather.WeatherConditions activeConditions)
		{
			return 0f;
		}

		private float GetConditionBlendValue(float activeValue, float condition)
		{
			return 0f;
		}

		private bool EvaluateConditions(float conditionValue, float conditionThreshold)
		{
			return false;
		}
	}
}
