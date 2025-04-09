using UnityEngine;

namespace VLB
{
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeamAbstractBase))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-triggerzone/")]
	public class TriggerZone : MonoBehaviour
	{
		private enum TriggerZoneUpdateRate
		{
			OnEnable = 0,
			OnOcclusionChange = 1
		}

		public const string ClassName = "TriggerZone";

		public bool setIsTrigger;

		public float rangeMultiplier;

		private const int kMeshColliderNumSides = 8;

		private VolumetricLightBeamAbstractBase m_Beam;

		private DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

		private PolygonCollider2D m_PolygonCollider2D;

		private TriggerZoneUpdateRate updateRate => default(TriggerZoneUpdateRate);

		private void OnEnable()
		{
		}

		private void OnOcclusionProcessed()
		{
		}

		private void ComputeZone()
		{
		}
	}
}
