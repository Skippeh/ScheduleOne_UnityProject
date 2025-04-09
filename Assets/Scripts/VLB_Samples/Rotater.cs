using UnityEngine;
using UnityEngine.Serialization;

namespace VLB_Samples
{
	public class Rotater : MonoBehaviour
	{
		[FormerlySerializedAs("m_EulerSpeed")]
		public Vector3 EulerSpeed;

		private void Update()
		{
		}
	}
}
