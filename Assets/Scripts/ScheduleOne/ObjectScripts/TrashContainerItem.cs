namespace ScheduleOne.ObjectScripts
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Trash.TrashContainer))]
	public class TrashContainerItem : global::ScheduleOne.EntityFramework.GridItem, global::ScheduleOne.Management.ITransitEntity
	{
		public const float MAX_VERTICAL_OFFSET = 2f;

		public global::ScheduleOne.Trash.TrashContainer Container;

		public global::UnityEngine.ParticleSystem Flies;

		public global::ScheduleOne.Audio.AudioSourceController TrashAddedSound;

		public global::UnityEngine.Rendering.Universal.DecalProjector PickupAreaProjector;

		public global::UnityEngine.Transform[] accessPoints;

		[global::UnityEngine.Header("Pickup settings")]
		public bool UsableByCleaners;

		public float PickupSquareWidth;

		public global::System.Collections.Generic.List<global::ScheduleOne.Trash.TrashItem> TrashItemsInRadius;

		public global::System.Collections.Generic.List<global::ScheduleOne.Trash.TrashBag> TrashBagsInRadius;

		private float calculatedPickupRadius;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002ETrashContainerItemAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002ETrashContainerItemAssembly_002DCSharp_002Edll_Excuted;

		public string Name => null;

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> InputSlots { get; set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> OutputSlots { get; set; }

		public global::UnityEngine.Transform LinkOrigin => null;

		public global::UnityEngine.Transform[] AccessPoints => null;

		public bool Selectable { get; }

		public bool IsAcceptingItems { get; set; }

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public override void InitializeGridItem(global::ScheduleOne.ItemFramework.ItemInstance instance, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
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

		public override global::ScheduleOne.Persistence.Datas.BuildableItemData GetBaseData()
		{
			return null;
		}

		private void TrashAdded(string trashID)
		{
		}

		public override void ShowOutline(global::UnityEngine.Color color)
		{
		}

		public override void HideOutline()
		{
		}

		private void CheckTrashItems()
		{
		}

		private void AddTrashToRadius(global::ScheduleOne.Trash.TrashItem trashItem)
		{
		}

		private void AddTrashBagToRadius(global::ScheduleOne.Trash.TrashBag trashBag)
		{
		}

		private void RemoveTrashItemFromRadius(global::ScheduleOne.Trash.TrashItem trashItem)
		{
		}

		private void RemoveTrashBagFromRadius(global::ScheduleOne.Trash.TrashBag trashBag)
		{
		}

		private bool IsTrashValid(global::ScheduleOne.Trash.TrashItem trashItem)
		{
			return false;
		}

		public bool IsPointInPickupZone(global::UnityEngine.Vector3 point)
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
