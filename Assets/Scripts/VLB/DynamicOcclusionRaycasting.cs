namespace VLB
{
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-sd-raycasting/")]
	public class DynamicOcclusionRaycasting : global::VLB.DynamicOcclusionAbstractBase
	{
		public struct HitResult
		{
			public global::UnityEngine.Vector3 point;

			public global::UnityEngine.Vector3 normal;

			public float distance;

			private global::UnityEngine.Collider2D collider2D;

			private global::UnityEngine.Collider collider3D;

			public bool hasCollider => false;

			public string name => null;

			public global::UnityEngine.Bounds bounds => default(global::UnityEngine.Bounds);

			public HitResult(ref global::UnityEngine.RaycastHit hit3D)
			{
				point = default(global::UnityEngine.Vector3);
				normal = default(global::UnityEngine.Vector3);
				distance = 0f;
				collider2D = null;
				collider3D = null;
			}

			public HitResult(ref global::UnityEngine.RaycastHit2D hit2D)
			{
				point = default(global::UnityEngine.Vector3);
				normal = default(global::UnityEngine.Vector3);
				distance = 0f;
				collider2D = null;
				collider3D = null;
			}

			public void SetNull()
			{
			}
		}

		private enum Direction
		{
			Up = 0,
			Down = 1,
			Left = 2,
			Right = 3,
			Max2D = 1,
			Max3D = 3
		}

		public new const string ClassName = "DynamicOcclusionRaycasting";

		public global::VLB.Dimensions dimensions;

		public global::UnityEngine.LayerMask layerMask;

		public bool considerTriggers;

		public float minOccluderArea;

		public float minSurfaceRatio;

		public float maxSurfaceDot;

		public global::VLB.PlaneAlignment planeAlignment;

		public float planeOffset;

		[global::UnityEngine.Serialization.FormerlySerializedAs("fadeDistanceToPlane")]
		public float fadeDistanceToSurface;

		private global::VLB.DynamicOcclusionRaycasting.HitResult m_CurrentHit;

		private float m_RangeMultiplier;

		private uint m_PrevNonSubHitDirectionId;

		[global::System.Obsolete("Use 'fadeDistanceToSurface' instead")]
		public float fadeDistanceToPlane
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Plane planeEquationWS { get; private set; }

		private global::UnityEngine.QueryTriggerInteraction queryTriggerInteraction => default(global::UnityEngine.QueryTriggerInteraction);

		private float raycastMaxDistance => 0f;

		public bool IsColliderHiddenByDynamicOccluder(global::UnityEngine.Collider collider)
		{
			return false;
		}

		protected override string GetShaderKeyword()
		{
			return null;
		}

		protected override global::VLB.MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(global::VLB.MaterialManager.SD.DynamicOcclusion);
		}

		protected override void OnValidateProperties()
		{
		}

		protected override void OnEnablePostValidate()
		{
		}

		protected override void OnDisable()
		{
		}

		private void Start()
		{
		}

		private global::UnityEngine.Vector3 GetRandomVectorAround(global::UnityEngine.Vector3 direction, float angleDiff)
		{
			return default(global::UnityEngine.Vector3);
		}

		private global::VLB.DynamicOcclusionRaycasting.HitResult GetBestHit(global::UnityEngine.Vector3 rayPos, global::UnityEngine.Vector3 rayDir)
		{
			return default(global::VLB.DynamicOcclusionRaycasting.HitResult);
		}

		private global::VLB.DynamicOcclusionRaycasting.HitResult GetBestHit3D(global::UnityEngine.Vector3 rayPos, global::UnityEngine.Vector3 rayDir)
		{
			return default(global::VLB.DynamicOcclusionRaycasting.HitResult);
		}

		private global::VLB.DynamicOcclusionRaycasting.HitResult GetBestHit2D(global::UnityEngine.Vector3 rayPos, global::UnityEngine.Vector3 rayDir)
		{
			return default(global::VLB.DynamicOcclusionRaycasting.HitResult);
		}

		private uint GetDirectionCount()
		{
			return 0u;
		}

		private global::UnityEngine.Vector3 GetDirection(uint dirInt)
		{
			return default(global::UnityEngine.Vector3);
		}

		private bool IsHitValid(ref global::VLB.DynamicOcclusionRaycasting.HitResult hit, global::UnityEngine.Vector3 forwardVec)
		{
			return false;
		}

		protected override bool OnProcessOcclusion(global::VLB.DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
			return false;
		}

		private void SetHit(ref global::VLB.DynamicOcclusionRaycasting.HitResult hit)
		{
		}

		private void SetHitNull()
		{
		}

		protected override void OnModifyMaterialCallback(global::VLB.MaterialModifier.Interface owner)
		{
		}

		private void SetClippingPlane(global::UnityEngine.Plane planeWS)
		{
		}

		private void SetClippingPlaneOff()
		{
		}

		private void SetPlaneWS(global::UnityEngine.Plane planeWS)
		{
		}
	}
}
