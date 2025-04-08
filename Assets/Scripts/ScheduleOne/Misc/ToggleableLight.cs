namespace ScheduleOne.Misc
{
	public class ToggleableLight : global::UnityEngine.MonoBehaviour
	{
		public bool isOn;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.DevUtilities.OptimizedLight[] lightSources;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.MeshRenderer[] lightSurfacesMeshes;

		public int MaterialIndex;

		[global::UnityEngine.Header("Materials")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material lightOnMat;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material lightOffMat;

		private global::ScheduleOne.ConstructableScripts.Constructable_GridBased constructable;

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
