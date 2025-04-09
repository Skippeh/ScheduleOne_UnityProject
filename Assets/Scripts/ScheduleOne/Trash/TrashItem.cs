using System;
using System.Collections.Generic;
using ScheduleOne.Combat;
using ScheduleOne.Dragging;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Trash
{
	[RequireComponent(typeof(Rigidbody))]
	[RequireComponent(typeof(Draggable))]
	[RequireComponent(typeof(PhysicsDamageable))]
	public class TrashItem : MonoBehaviour, IGUIDRegisterable, ISaveable
	{
		public const float POSITION_CHANGE_THRESHOLD = 1f;

		public const float LINEAR_DRAG = 0.1f;

		public const float ANGULAR_DRAG = 0.1f;

		public const float MIN_Y = -100f;

		public const int INTERACTION_PRIORITY = 5;

		public Rigidbody Rigidbody;

		public Draggable Draggable;

		[Header("Settings")]
		public string ID;

		[Range(0f, 5f)]
		public int Size;

		[Range(0f, 10f)]
		public int SellValue;

		public bool CanGoInContainer;

		public Collider[] colliders;

		private Vector3 lastPosition;

		public Action<TrashItem> onDestroyed;

		private bool collidersEnabled;

		private float timeOnPhysicsEnabled;

		public Guid GUID { get; protected set; }

		public ScheduleOne.Property.Property CurrentProperty { get; protected set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		protected void Awake()
		{
		}

		protected void Start()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		protected void OnValidate()
		{
		}

		protected void MinPass()
		{
		}

		protected void SleepEnd(int mins)
		{
		}

		protected void Hovered()
		{
		}

		protected void Interacted()
		{
		}

		public void SetGUID(Guid guid)
		{
		}

		public void SetVelocity(Vector3 velocity)
		{
		}

		public void DestroyTrash()
		{
		}

		public virtual void Deinitialize()
		{
		}

		private void OnDestroy()
		{
		}

		private void RecheckPosition()
		{
		}

		public virtual TrashItemData GetData()
		{
			return null;
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public virtual bool ShouldSave()
		{
			return false;
		}

		private void RecheckProperty()
		{
		}

		public void SetContinuousCollisionDetection()
		{
		}

		public void SetDiscreteCollisionDetection()
		{
		}

		public void SetPhysicsActive(bool active)
		{
		}

		public void SetCollidersEnabled(bool enabled)
		{
		}
	}
}
