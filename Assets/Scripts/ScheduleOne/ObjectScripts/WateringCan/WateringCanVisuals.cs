namespace ScheduleOne.ObjectScripts.WateringCan
{
	public class WateringCanVisuals : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.ParticleSystem OverflowParticles;

		public global::UnityEngine.Transform WaterTransform;

		public float WaterMaxY;

		public float WaterMinY;

		public global::UnityEngine.Transform SideWaterTransform;

		public float SideWaterMinScale;

		public float SideWaterMaxScale;

		public global::ScheduleOne.Audio.AudioSourceController FillSound;

		public virtual void SetFillLevel(float normalizedFillLevel)
		{
		}

		public void SetOverflowParticles(bool enabled)
		{
		}
	}
}
