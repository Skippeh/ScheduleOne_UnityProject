using System.Collections.Generic;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.ObjectScripts
{
	[RequireComponent(typeof(TrashContainer))]
	public class TrashContainerItem : GridItem, ITransitEntity
	{
		public const float MAX_VERTICAL_OFFSET = 2f;

		public TrashContainer Container;

		public ParticleSystem Flies;

		public AudioSourceController TrashAddedSound;

		public DecalProjector PickupAreaProjector;

		public Transform[] accessPoints;

		[Header("Pickup settings")]
		public bool UsableByCleaners;

		public float PickupRadius;

		public List<TrashItem> TrashItemsInRadius;

		public List<TrashBag> TrashBagsInRadius;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002ETrashContainerItemAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002ETrashContainerItemAssembly_002DCSharp_002Edll_Excuted;

		public string Name => null;

		public List<ItemSlot> InputSlots { get; set; }

		public List<ItemSlot> OutputSlots { get; set; }

		public Transform LinkOrigin => null;

		public Transform[] AccessPoints => null;

		public bool Selectable { get; }

		public bool IsAcceptingItems { get; set; }

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		private void TrashLevelChanged()
		{
		}

		public override bool CanBeDestroyed(out string reason)
		{
			reason = null;
			return false;
		}

		public override string GetSaveString()
		{
			return null;
		}

		private void TrashAdded(string trashID)
		{
		}

		public override void ShowOutline(Color color)
		{
		}

		public override void HideOutline()
		{
		}

		private void CheckTrashItems()
		{
		}

		private void AddTrashToRadius(TrashItem trashItem)
		{
		}

		private void AddTrashBagToRadius(TrashBag trashBag)
		{
		}

		private void RemoveTrashItemFromRadius(TrashItem trashItem)
		{
		}

		private void RemoveTrashBagFromRadius(TrashBag trashBag)
		{
		}

		private bool IsTrashValid(TrashItem trashItem)
		{
			return false;
		}

		public bool IsPointInRadius(Vector3 point)
		{
			return false;
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EObjectScripts_002ETrashContainerItem_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
