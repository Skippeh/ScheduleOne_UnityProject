using UnityEngine;

namespace VLB
{
	public abstract class VolumetricLightBeamAbstractBase : MonoBehaviour
	{
		public enum AttachedLightType
		{
			NoLight = 0,
			OtherLight = 1,
			SpotLight = 2
		}

		public const string ClassName = "VolumetricLightBeamAbstractBase";

		[SerializeField]
		protected int pluginVersion;

		protected Light m_CachedLightSpot;

		public bool hasGeometry => false;

		public Bounds bounds => default(Bounds);

		public int _INTERNAL_pluginVersion => 0;

		public Light lightSpotAttached => null;

		public abstract BeamGeometryAbstractBase GetBeamGeometry();

		protected abstract void SetBeamGeometryNull();

		public abstract bool IsScalable();

		public abstract Vector3 GetLossyScale();

		public Light GetLightSpotAttachedSlow(out AttachedLightType lightType)
		{
			lightType = default(AttachedLightType);
			return null;
		}

		protected void InitLightSpotAttachedCached()
		{
		}

		private void OnDestroy()
		{
		}

		protected void DestroyBeam()
		{
		}
	}
}
