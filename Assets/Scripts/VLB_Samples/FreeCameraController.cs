using UnityEngine;

namespace VLB_Samples
{
	public class FreeCameraController : MonoBehaviour
	{
		public float cameraSensitivity;

		public float speedNormal;

		public float speedFactorSlow;

		public float speedFactorFast;

		public float speedClimb;

		private float rotationH;

		private float rotationV;

		private bool m_UseMouseView;

		private bool useMouseView
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}
	}
}
