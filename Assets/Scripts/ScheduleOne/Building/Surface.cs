using System;
using System.Collections.Generic;
using EasyButtons;
using UnityEngine;

namespace ScheduleOne.Building
{
	public class Surface : MonoBehaviour, IGUIDRegisterable
	{
		public enum ESurfaceType
		{
			Wall = 0,
			Roof = 1
		}

		public enum EFace
		{
			Front = 0,
			Back = 1,
			Top = 2,
			Bottom = 3,
			Left = 4,
			Right = 5
		}

		[Header("Settings")]
		public ESurfaceType SurfaceType;

		public List<EFace> ValidFaces;

		public ScheduleOne.Property.Property ParentProperty;

		[SerializeField]
		protected string BakedGUID;

		public Guid GUID { get; protected set; }

		public Transform Container => null;

		[Button]
		public void RegenerateGUID()
		{
		}

		private void OnValidate()
		{
		}

		protected virtual void Awake()
		{
		}

		public void SetGUID(Guid guid)
		{
		}

		public Vector3 GetRelativePosition(Vector3 worldPosition)
		{
			return default(Vector3);
		}

		public Quaternion GetRelativeRotation(Quaternion worldRotation)
		{
			return default(Quaternion);
		}

		public bool IsFrontFace(Vector3 point, Collider collider)
		{
			return false;
		}

		public bool IsPointValid(Vector3 point, Collider hitCollider)
		{
			return false;
		}
	}
}
