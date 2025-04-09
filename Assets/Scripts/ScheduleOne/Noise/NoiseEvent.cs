using UnityEngine;

namespace ScheduleOne.Noise
{
	public class NoiseEvent
	{
		public Vector3 origin;

		public float range;

		public ENoiseType type;

		public GameObject source;

		public NoiseEvent(Vector3 _origin, float _range, ENoiseType _type, GameObject _source = null)
		{
		}
	}
}
