namespace ScheduleOne.Weather
{
	public class WorldEnclosure : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Weather.BasicEnclosure> _enclosures;

		private global::System.Collections.Generic.List<global::ScheduleOne.Weather.BasicEnclosure> _blendZones;

		private global::System.Collections.Generic.List<global::ScheduleOne.Weather.BasicEnclosure> _Enclosures;

		public global::System.Collections.Generic.List<global::ScheduleOne.Weather.BasicEnclosure> Enclosures => null;

		private void Start()
		{
		}

		public bool WithinEnclosure(global::UnityEngine.Vector3 targetPosition, out float blend)
		{
			blend = default(float);
			return false;
		}
	}
}
