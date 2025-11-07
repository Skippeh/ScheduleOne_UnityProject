namespace ScheduleOne.Effects.MixMaps
{
	public class MixerMapGenerator : global::UnityEngine.MonoBehaviour
	{
		public float MapRadius;

		public string MapName;

		public global::UnityEngine.Transform BasePlateMesh;

		public global::ScheduleOne.Effects.MixMaps.MixMapEffect EffectPrefab;

		private void OnValidate()
		{
		}

		[global::EasyButtons.Button]
		public void CreateEffectPrefabs()
		{
		}

		[global::EasyButtons.Button]
		public global::ScheduleOne.Effects.MixMaps.MixMapEffect GetEffect(global::ScheduleOne.Effects.Effect effect)
		{
			return null;
		}
	}
}
