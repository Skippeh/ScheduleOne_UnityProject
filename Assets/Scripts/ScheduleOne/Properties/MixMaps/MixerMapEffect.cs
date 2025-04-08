namespace ScheduleOne.Properties.MixMaps
{
	[global::System.Serializable]
	public class MixerMapEffect
	{
		public global::UnityEngine.Vector2 Position;

		public float Radius;

		public global::ScheduleOne.Properties.Property Property;

		public bool IsPointInEffect(global::UnityEngine.Vector2 point)
		{
			return false;
		}
	}
}
