namespace ScheduleOne.Growing
{
	public class GrowingMushroom : global::UnityEngine.MonoBehaviour
	{
		private const float CapExpansionThreshold = 0.5f;

		[global::UnityEngine.HideInInspector]
		public float LateralScaleMultiplier;

		[global::UnityEngine.HideInInspector]
		public float VerticalScaleMultiplier;

		[global::UnityEngine.HideInInspector]
		public float MaxCapExpansion;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _modelContainer;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.SkinnedMeshRenderer[] _meshRenderers;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Audio.AudioSourceController _harvestSound;

		private global::ScheduleOne.Growing.ShroomColony _parentColony;

		private int _alignmentIndex;

		private void Awake()
		{
		}

		public void Initialize(global::ScheduleOne.Growing.ShroomColony parentColony, int alignmentIndex)
		{
		}

		public void SetGrowthPercent(float percent)
		{
		}

		[global::EasyButtons.Button]
		public void Harvest()
		{
		}
	}
}
