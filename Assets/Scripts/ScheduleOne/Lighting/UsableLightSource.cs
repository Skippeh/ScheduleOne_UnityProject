using UnityEngine;

namespace ScheduleOne.Lighting
{
	public class UsableLightSource : MonoBehaviour
	{
		[Range(0.5f, 2f)]
		public float GrowSpeedMultiplier;

		public bool isEmitting;
	}
}
