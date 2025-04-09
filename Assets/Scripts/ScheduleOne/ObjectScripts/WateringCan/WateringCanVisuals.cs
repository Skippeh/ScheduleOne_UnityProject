using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.ObjectScripts.WateringCan
{
	public class WateringCanVisuals : MonoBehaviour
	{
		public ParticleSystem OverflowParticles;

		public Transform WaterTransform;

		public float WaterMaxY;

		public float WaterMinY;

		public Transform SideWaterTransform;

		public float SideWaterMinScale;

		public float SideWaterMaxScale;

		public AudioSourceController FillSound;

		public virtual void SetFillLevel(float normalizedFillLevel)
		{
		}

		public void SetOverflowParticles(bool enabled)
		{
		}
	}
}
