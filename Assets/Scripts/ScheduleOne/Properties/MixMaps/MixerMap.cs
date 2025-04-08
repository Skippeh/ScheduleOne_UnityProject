namespace ScheduleOne.Properties.MixMaps
{
	[global::System.Serializable]
	public class MixerMap : global::UnityEngine.ScriptableObject
	{
		public float MapRadius;

		public global::System.Collections.Generic.List<global::ScheduleOne.Properties.MixMaps.MixerMapEffect> Effects;

		public global::ScheduleOne.Properties.MixMaps.MixerMapEffect GetEffectAtPoint(global::UnityEngine.Vector2 point)
		{
			return null;
		}

		public global::ScheduleOne.Properties.MixMaps.MixerMapEffect GetEffect(global::ScheduleOne.Properties.Property property)
		{
			return null;
		}
	}
}
