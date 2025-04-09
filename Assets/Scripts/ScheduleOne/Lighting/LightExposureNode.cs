using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	public class LightExposureNode : MonoBehaviour
	{
		public float ambientExposure;

		public Dictionary<UsableLightSource, float> sources;

		public float GetTotalExposure(out float growSpeedMultiplier)
		{
			growSpeedMultiplier = default(float);
			return 0f;
		}

		public void AddSource(UsableLightSource source, float lightAmount)
		{
		}

		public void RemoveSource(UsableLightSource source)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
