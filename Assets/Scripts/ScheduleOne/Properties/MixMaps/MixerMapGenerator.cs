using EasyButtons;
using UnityEngine;

namespace ScheduleOne.Properties.MixMaps
{
	public class MixerMapGenerator : MonoBehaviour
	{
		public float MapRadius;

		public string MapName;

		public Transform BasePlateMesh;

		public Effect EffectPrefab;

		private void OnValidate()
		{
		}

		[Button]
		public void CreateEffectPrefabs()
		{
		}

		[Button]
		public Effect GetEffect(Property property)
		{
			return null;
		}
	}
}
