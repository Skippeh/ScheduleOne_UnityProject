namespace VLB
{
	public abstract class BeamGeometryAbstractBase : global::UnityEngine.MonoBehaviour
	{
		protected global::UnityEngine.Matrix4x4 m_ColorGradientMatrix;

		protected global::UnityEngine.Material m_CustomMaterial;

		public global::UnityEngine.MeshRenderer meshRenderer { get; protected set; }

		public global::UnityEngine.MeshFilter meshFilter { get; protected set; }

		public global::UnityEngine.Mesh coneMesh { get; protected set; }

		protected abstract global::VLB.VolumetricLightBeamAbstractBase GetMaster();

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void DestroyInvalidOwner()
		{
		}

		public static void DestroyBeamGeometryGameObject(global::VLB.BeamGeometryAbstractBase beamGeom)
		{
		}
	}
}
