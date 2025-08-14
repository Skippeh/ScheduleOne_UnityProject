namespace ScheduleOne.Trash
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody))]
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Dragging.Draggable))]
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Combat.PhysicsDamageable))]
	public class TrashItem : global::UnityEngine.MonoBehaviour, global::ScheduleOne.IGUIDRegisterable, global::ScheduleOne.Persistence.ISaveable
	{
		public const float POSITION_CHANGE_THRESHOLD = 1f;

		public const float LINEAR_DRAG = 0.1f;

		public const float ANGULAR_DRAG = 0.1f;

		public const float MIN_Y = -100f;

		public const int INTERACTION_PRIORITY = 5;

		public global::UnityEngine.Rigidbody Rigidbody;

		public global::ScheduleOne.Dragging.Draggable Draggable;

		[global::UnityEngine.Header("Settings")]
		public string ID;

		[global::UnityEngine.Range(0f, 5f)]
		public int Size;

		[global::UnityEngine.Range(0f, 10f)]
		public int SellValue;

		public bool CanGoInContainer;

		public global::UnityEngine.Collider[] colliders;

		private global::UnityEngine.Vector3 lastPosition;

		public global::System.Action<global::ScheduleOne.Trash.TrashItem> onDestroyed;

		private bool collidersEnabled;

		private float timeOnPhysicsEnabled;

		public global::System.Guid GUID { get; protected set; }

		public global::ScheduleOne.Property.Property CurrentProperty { get; protected set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

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

		protected void Hovered()
		{
		}

		protected void Interacted()
		{
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		public void SetVelocity(global::UnityEngine.Vector3 velocity)
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

		public virtual global::ScheduleOne.Persistence.Datas.TrashItemData GetData()
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
