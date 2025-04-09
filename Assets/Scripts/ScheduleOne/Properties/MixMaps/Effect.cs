using UnityEngine;

namespace ScheduleOne.Properties.MixMaps
{
	public class Effect : MonoBehaviour
	{
		public Property Property;

		[Range(0.05f, 3f)]
		public float Radius;

		public Vector2 Position => default(Vector2);

		public void OnValidate()
		{
		}
	}
}
