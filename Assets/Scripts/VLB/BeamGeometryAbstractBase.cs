using UnityEngine;

namespace VLB
{
	public abstract class BeamGeometryAbstractBase : MonoBehaviour
	{
		protected Matrix4x4 m_ColorGradientMatrix;

		protected Material m_CustomMaterial;

		public MeshRenderer meshRenderer { get; protected set; }

		public MeshFilter meshFilter { get; protected set; }

		public Mesh coneMesh { get; protected set; }

		protected abstract VolumetricLightBeamAbstractBase GetMaster();

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void DestroyInvalidOwner()
		{
		}

		public static void DestroyBeamGeometryGameObject(BeamGeometryAbstractBase beamGeom)
		{
		}
	}
}
