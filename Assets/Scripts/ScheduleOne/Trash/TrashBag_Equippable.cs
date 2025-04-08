namespace ScheduleOne.Trash
{
	public class TrashBag_Equippable : global::ScheduleOne.Equipping.Equippable_Viewmodel
	{
		public const float TRASH_CONTAINER_INTERACT_DISTANCE = 2.75f;

		public const float BAG_TRASH_TIME = 1f;

		public const float PICKUP_RANGE = 3f;

		public const float PICKUP_AREA_RADIUS = 0.5f;

		public global::UnityEngine.LayerMask PickupLookMask;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Rendering.Universal.DecalProjector PickupAreaProjector;

		public global::ScheduleOne.Audio.AudioSourceController RustleSound;

		public global::ScheduleOne.Audio.AudioSourceController BagSound;

		private float _bagTrashTime;

		private global::ScheduleOne.Trash.TrashContainer _baggedContainer;

		private float _pickupTrashTime;

		public static bool IsHoveringTrash => false;

		public bool IsBaggingTrash { get; private set; }

		public bool IsPickingUpTrash { get; private set; }

		public override void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public override void Unequip()
		{
		}

		protected override void Update()
		{
		}

		private global::ScheduleOne.Trash.TrashContainer GetHoveredTrashContainer()
		{
			return null;
		}

		private bool RaycastLook(out global::UnityEngine.RaycastHit hit)
		{
			hit = default(global::UnityEngine.RaycastHit);
			return false;
		}

		private bool IsPickupLocationValid(global::UnityEngine.RaycastHit hit)
		{
			return false;
		}

		private global::System.Collections.Generic.List<global::ScheduleOne.Trash.TrashItem> GetTrashItemsAtPoint(global::UnityEngine.Vector3 pos)
		{
			return null;
		}

		private void StartBagTrash(global::ScheduleOne.Trash.TrashContainer container)
		{
		}

		private void StopBagTrash(bool complete)
		{
		}

		private void StartPickup()
		{
		}

		private void StopPickup(bool complete)
		{
		}
	}
}
