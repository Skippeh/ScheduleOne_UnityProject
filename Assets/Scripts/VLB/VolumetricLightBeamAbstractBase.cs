namespace VLB
{
	public abstract class VolumetricLightBeamAbstractBase : global::UnityEngine.MonoBehaviour
	{
		public enum AttachedLightType
		{
			NoLight = 0,
			OtherLight = 1,
			SpotLight = 2
		}

		public const string ClassName = "VolumetricLightBeamAbstractBase";

		[global::UnityEngine.SerializeField]
		protected int pluginVersion;

		protected global::UnityEngine.Light m_CachedLightSpot;

		public bool hasGeometry => false;

		public global::UnityEngine.Bounds bounds => default(global::UnityEngine.Bounds);

		public int _INTERNAL_pluginVersion => 0;

		public global::UnityEngine.Light lightSpotAttached => null;

		public abstract global::VLB.BeamGeometryAbstractBase GetBeamGeometry();

		protected abstract void SetBeamGeometryNull();

		public abstract bool IsScalable();

		public abstract global::UnityEngine.Vector3 GetLossyScale();

		public global::UnityEngine.Light GetLightSpotAttachedSlow(out global::VLB.VolumetricLightBeamAbstractBase.AttachedLightType lightType)
		{
			lightType = default(global::VLB.VolumetricLightBeamAbstractBase.AttachedLightType);
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
