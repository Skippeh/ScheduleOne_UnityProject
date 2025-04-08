namespace ScheduleOne.Map.Infrastructure
{
	public class TrafficLight : global::UnityEngine.MonoBehaviour
	{
		public enum State
		{
			Red = 0,
			Orange = 1,
			Green = 2
		}

		public static float amberTime;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.MeshRenderer redMesh;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.MeshRenderer orangeMesh;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.MeshRenderer greenMesh;

		[global::UnityEngine.Header("Materials")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material redOn_Mat;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material redOff_Mat;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material orangeOn_Mat;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material orangeOff_Mat;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material greenOn_Mat;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Material greenOff_Mat;

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.Map.Infrastructure.TrafficLight.State state;

		private global::ScheduleOne.Map.Infrastructure.TrafficLight.State appliedState;

		protected virtual void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void ApplyState()
		{
		}
	}
}
