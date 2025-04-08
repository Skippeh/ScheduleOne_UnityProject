namespace ScheduleOne.StationFramework
{
	public class LiquidContainer : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.Range(0f, 1f)]
		public float Viscosity;

		public bool AdjustMurkiness;

		[global::UnityEngine.Header("References")]
		public global::LiquidVolumeFX.LiquidVolume LiquidVolume;

		public global::ScheduleOne.StationFramework.LiquidVolumeCollider Collider;

		public global::UnityEngine.Transform ColliderTransform_Min;

		public global::UnityEngine.Transform ColliderTransform_Max;

		[global::UnityEngine.Header("Visuals Settings")]
		public float MaxLevel;

		private global::UnityEngine.MeshRenderer liquidMesh;

		public float CurrentLiquidLevel { get; private set; }

		public global::UnityEngine.Color LiquidColor { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void MinPass()
		{
		}

		private void UpdateLighting()
		{
		}

		public void SetLiquidLevel(float level, bool debug = false)
		{
		}

		public void SetLiquidColor(global::UnityEngine.Color color, bool setColorVariable = true, bool updateLigting = true)
		{
		}
	}
}
