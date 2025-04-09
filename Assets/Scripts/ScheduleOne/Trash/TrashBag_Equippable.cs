using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.Equipping;
using ScheduleOne.ItemFramework;
using UnityEngine;
using UnityEngine.Rendering.Universal;

namespace ScheduleOne.Trash
{
	public class TrashBag_Equippable : Equippable_Viewmodel
	{
		public const float TRASH_CONTAINER_INTERACT_DISTANCE = 2.75f;

		public const float BAG_TRASH_TIME = 1f;

		public const float PICKUP_RANGE = 3f;

		public const float PICKUP_AREA_RADIUS = 0.5f;

		public LayerMask PickupLookMask;

		[Header("References")]
		public DecalProjector PickupAreaProjector;

		public AudioSourceController RustleSound;

		public AudioSourceController BagSound;

		private float _bagTrashTime;

		private TrashContainer _baggedContainer;

		private float _pickupTrashTime;

		public static bool IsHoveringTrash => false;

		public bool IsBaggingTrash { get; private set; }

		public bool IsPickingUpTrash { get; private set; }

		public override void Equip(ItemInstance item)
		{
		}

		public override void Unequip()
		{
		}

		protected override void Update()
		{
		}

		private TrashContainer GetHoveredTrashContainer()
		{
			return null;
		}

		private bool RaycastLook(out RaycastHit hit)
		{
			hit = default(RaycastHit);
			return false;
		}

		private bool IsPickupLocationValid(RaycastHit hit)
		{
			return false;
		}

		private List<TrashItem> GetTrashItemsAtPoint(Vector3 pos)
		{
			return null;
		}

		private void StartBagTrash(TrashContainer container)
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
