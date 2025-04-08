namespace Funly.SkyStudio
{
	[global::UnityEngine.ExecuteInEditMode]
	public class OrbitingBody : global::UnityEngine.MonoBehaviour
	{
		private global::UnityEngine.Transform m_PositionTransform;

		private global::Funly.SkyStudio.RotateBody m_RotateBody;

		private global::Funly.SkyStudio.SpherePoint m_SpherePoint;

		private global::UnityEngine.Vector3 m_CachedWorldDirection;

		private global::UnityEngine.Light m_BodyLight;

		public global::UnityEngine.Transform positionTransform => null;

		public global::Funly.SkyStudio.RotateBody rotateBody => null;

		public global::Funly.SkyStudio.SpherePoint Point
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector3 BodyGlobalDirection => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Light BodyLight => null;

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
