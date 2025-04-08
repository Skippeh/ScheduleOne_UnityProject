namespace VLB_Samples
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Collider), typeof(global::UnityEngine.Rigidbody), typeof(global::UnityEngine.MeshRenderer))]
	public class CheckIfInsideBeam : global::UnityEngine.MonoBehaviour
	{
		private bool isInsideBeam;

		private global::UnityEngine.Material m_Material;

		private global::UnityEngine.Collider m_Collider;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnTriggerStay(global::UnityEngine.Collider trigger)
		{
		}
	}
}
