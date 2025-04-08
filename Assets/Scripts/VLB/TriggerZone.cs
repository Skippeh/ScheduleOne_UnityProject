namespace VLB
{
	[global::UnityEngine.DisallowMultipleComponent]
	[global::UnityEngine.RequireComponent(typeof(global::VLB.VolumetricLightBeamAbstractBase))]
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/comp-triggerzone/")]
	public class TriggerZone : global::UnityEngine.MonoBehaviour
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

		private global::VLB.VolumetricLightBeamAbstractBase m_Beam;

		private global::VLB.DynamicOcclusionRaycasting m_DynamicOcclusionRaycasting;

		private global::UnityEngine.PolygonCollider2D m_PolygonCollider2D;

		private global::VLB.TriggerZone.TriggerZoneUpdateRate updateRate => default(global::VLB.TriggerZone.TriggerZoneUpdateRate);

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
