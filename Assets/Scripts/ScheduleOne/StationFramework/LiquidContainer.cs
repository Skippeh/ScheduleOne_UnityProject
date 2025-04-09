using LiquidVolumeFX;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	public class LiquidContainer : MonoBehaviour
	{
		[Header("Settings")]
		[Range(0f, 1f)]
		public float Viscosity;

		public bool AdjustMurkiness;

		[Header("References")]
		public LiquidVolume LiquidVolume;

		public LiquidVolumeCollider Collider;

		public Transform ColliderTransform_Min;

		public Transform ColliderTransform_Max;

		[Header("Visuals Settings")]
		public float MaxLevel;

		private MeshRenderer liquidMesh;

		public float CurrentLiquidLevel { get; private set; }

		public Color LiquidColor { get; private set; }

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

		public void SetLiquidColor(Color color, bool setColorVariable = true, bool updateLigting = true)
		{
		}
	}
}
