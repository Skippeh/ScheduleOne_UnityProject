namespace ScheduleOne.Noise
{
	public class NoiseEvent
	{
		public global::UnityEngine.Vector3 origin;

		public float range;

		public global::ScheduleOne.Noise.ENoiseType type;

		public global::UnityEngine.GameObject source;

		public bool OriginInSewer { get; private set; }

		public NoiseEvent(global::UnityEngine.Vector3 _origin, float _range, global::ScheduleOne.Noise.ENoiseType _type, global::UnityEngine.GameObject _source = null)
		{
		}
	}
}
