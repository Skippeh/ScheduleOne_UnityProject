namespace ScheduleOne.Misc
{
	public class ToggleableLight : global::UnityEngine.MonoBehaviour
	{
		private enum State
		{
			NotInitialized = 0,
			On = 1,
			Off = 2
		}

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("isOn")]
		private bool _isOn;

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

		private global::ScheduleOne.Misc.ToggleableLight.State state;

		public bool isOn
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		public void TurnOn()
		{
		}

		public void TurnOff()
		{
		}

		protected virtual void SetLights()
		{
		}
	}
}
