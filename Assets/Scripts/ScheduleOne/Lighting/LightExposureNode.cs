namespace ScheduleOne.Lighting
{
	public class LightExposureNode : global::UnityEngine.MonoBehaviour
	{
		public float ambientExposure;

		public global::System.Collections.Generic.Dictionary<global::ScheduleOne.Lighting.UsableLightSource, float> sources;

		public float GetTotalExposure(out float growSpeedMultiplier)
		{
			growSpeedMultiplier = default(float);
			return 0f;
		}

		public void AddSource(global::ScheduleOne.Lighting.UsableLightSource source, float lightAmount)
		{
		}

		public void RemoveSource(global::ScheduleOne.Lighting.UsableLightSource source)
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
