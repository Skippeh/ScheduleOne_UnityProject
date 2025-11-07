namespace ScheduleOne.Effects.MixMaps
{
	[global::System.Serializable]
	public class MixerMapEffect
	{
		public global::UnityEngine.Vector2 Position;

		public float Radius;

		public global::ScheduleOne.Effects.Effect Property;

		public bool IsPointInEffect(global::UnityEngine.Vector2 point)
		{
			return false;
		}
	}
}
