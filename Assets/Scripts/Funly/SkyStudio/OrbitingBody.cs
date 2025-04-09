using UnityEngine;

namespace Funly.SkyStudio
{
	[ExecuteInEditMode]
	public class OrbitingBody : MonoBehaviour
	{
		private Transform m_PositionTransform;

		private RotateBody m_RotateBody;

		private SpherePoint m_SpherePoint;

		private Vector3 m_CachedWorldDirection;

		private Light m_BodyLight;

		public Transform positionTransform => null;

		public RotateBody rotateBody => null;

		public SpherePoint Point
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector3 BodyGlobalDirection => default(Vector3);

		public Light BodyLight => null;

		public void ResetOrbit()
		{
		}

		public void LayoutOribit()
		{
		}

		private void OnValidate()
		{
		}
	}
}
