namespace ScheduleOne.Effects.MixMaps
{
	[global::System.Serializable]
	public class MixerMap : global::UnityEngine.ScriptableObject
	{
		public float MapRadius;

		public global::System.Collections.Generic.List<global::ScheduleOne.Effects.MixMaps.MixerMapEffect> Effects;

		public global::ScheduleOne.Effects.MixMaps.MixerMapEffect GetEffectAtPoint(global::UnityEngine.Vector2 point)
		{
			return null;
		}

		public global::ScheduleOne.Effects.MixMaps.MixerMapEffect GetEffect(global::ScheduleOne.Effects.Effect property)
		{
			return null;
		}
	}
}
