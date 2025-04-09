using System;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-sd-raycasting/")]
	public class DynamicOcclusionRaycasting : DynamicOcclusionAbstractBase
	{
		public struct HitResult
		{
			public Vector3 point;

			public Vector3 normal;

			public float distance;

			private Collider2D collider2D;

			private Collider collider3D;

			public bool hasCollider => false;

			public string name => null;

			public Bounds bounds => default(Bounds);

			public HitResult(ref RaycastHit hit3D)
			{
				point = hit3D.point;
				normal = hit3D.normal;
				distance = hit3D.distance;
				collider3D = hit3D.collider;
				collider2D = null;
			}

			public HitResult(ref RaycastHit2D hit2D)
			{
				point = hit2D.point;
				normal = hit2D.normal;
				distance = hit2D.distance;
				collider2D = hit2D.collider;
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

		public Dimensions dimensions;

		public LayerMask layerMask;

		public bool considerTriggers;

		public float minOccluderArea;

		public float minSurfaceRatio;

		public float maxSurfaceDot;

		public PlaneAlignment planeAlignment;

		public float planeOffset;

		[FormerlySerializedAs("fadeDistanceToPlane")]
		public float fadeDistanceToSurface;

		private HitResult m_CurrentHit;

		private float m_RangeMultiplier;

		private uint m_PrevNonSubHitDirectionId;

		[Obsolete("Use 'fadeDistanceToSurface' instead")]
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

		public Plane planeEquationWS { get; private set; }

		private QueryTriggerInteraction queryTriggerInteraction => default(QueryTriggerInteraction);

		private float raycastMaxDistance => 0f;

		public bool IsColliderHiddenByDynamicOccluder(Collider collider)
		{
			return false;
		}

		protected override string GetShaderKeyword()
		{
			return null;
		}

		protected override MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.SD.DynamicOcclusion);
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

		private Vector3 GetRandomVectorAround(Vector3 direction, float angleDiff)
		{
			return default(Vector3);
		}

		private HitResult GetBestHit(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		private HitResult GetBestHit3D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		private HitResult GetBestHit2D(Vector3 rayPos, Vector3 rayDir)
		{
			return default(HitResult);
		}

		private uint GetDirectionCount()
		{
			return 0u;
		}

		private Vector3 GetDirection(uint dirInt)
		{
			return default(Vector3);
		}

		private bool IsHitValid(ref HitResult hit, Vector3 forwardVec)
		{
			return false;
		}

		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return false;
		}

		private void SetHit(ref HitResult hit)
		{
		}

		private void SetHitNull()
		{
		}

		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}

		private void SetClippingPlane(Plane planeWS)
		{
		}

		private void SetClippingPlaneOff()
		{
		}

		private void SetPlaneWS(Plane planeWS)
		{
		}
	}
}
