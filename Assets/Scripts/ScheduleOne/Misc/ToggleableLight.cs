using ScheduleOne.ConstructableScripts;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Misc
{
	public class ToggleableLight : MonoBehaviour
	{
		public bool isOn;

		[Header("References")]
		[SerializeField]
		protected OptimizedLight[] lightSources;

		[SerializeField]
		protected MeshRenderer[] lightSurfacesMeshes;

		public int MaterialIndex;

		[Header("Materials")]
		[SerializeField]
		protected Material lightOnMat;

		[SerializeField]
		protected Material lightOffMat;

		private Constructable_GridBased constructable;

		private bool lightsApplied;

		protected virtual void Awake()
		{
		}

		private void OnValidate()
		{
		}

		protected virtual void Update()
		{
		}

		public void TurnOn()
		{
		}

		public void TurnOff()
		{
		}

		protected virtual void SetLights(bool active)
		{
		}
	}
}
