using UnityEngine;

namespace VLB_Samples
{
	[RequireComponent(typeof(Collider), typeof(Rigidbody), typeof(MeshRenderer))]
	public class CheckIfInsideBeam : MonoBehaviour
	{
		private bool isInsideBeam;

		private Material m_Material;

		private Collider m_Collider;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnTriggerStay(Collider trigger)
		{
		}
	}
}
