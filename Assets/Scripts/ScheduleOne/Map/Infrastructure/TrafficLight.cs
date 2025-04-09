using UnityEngine;

namespace ScheduleOne.Map.Infrastructure
{
	public class TrafficLight : MonoBehaviour
	{
		public enum State
		{
			Red = 0,
			Orange = 1,
			Green = 2
		}

		public static float amberTime;

		[Header("References")]
		[SerializeField]
		protected MeshRenderer redMesh;

		[SerializeField]
		protected MeshRenderer orangeMesh;

		[SerializeField]
		protected MeshRenderer greenMesh;

		[Header("Materials")]
		[SerializeField]
		protected Material redOn_Mat;

		[SerializeField]
		protected Material redOff_Mat;

		[SerializeField]
		protected Material orangeOn_Mat;

		[SerializeField]
		protected Material orangeOff_Mat;

		[SerializeField]
		protected Material greenOn_Mat;

		[SerializeField]
		protected Material greenOff_Mat;

		[Header("Settings")]
		public State state;

		private State appliedState;

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
