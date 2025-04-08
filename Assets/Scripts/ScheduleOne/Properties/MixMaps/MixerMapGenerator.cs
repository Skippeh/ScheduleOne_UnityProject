namespace ScheduleOne.Properties.MixMaps
{
	public class MixerMapGenerator : global::UnityEngine.MonoBehaviour
	{
		public float MapRadius;

		public string MapName;

		public global::UnityEngine.Transform BasePlateMesh;

		public global::ScheduleOne.Properties.MixMaps.Effect EffectPrefab;

		private void OnValidate()
		{
		}

		[global::EasyButtons.Button]
		public void CreateEffectPrefabs()
		{
		}

		[global::EasyButtons.Button]
		public global::ScheduleOne.Properties.MixMaps.Effect GetEffect(global::ScheduleOne.Properties.Property property)
		{
			return null;
		}
	}
}
