using ScheduleOne.Audio;
using ScheduleOne.ItemFramework;
using ScheduleOne.ObjectScripts.WateringCan;
using ScheduleOne.Trash;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Equipping
{
	public class Equippable_TrashGrabber : Equippable_Viewmodel
	{
		public const float TrashDropSpacing = 0.15f;

		[Header("References")]
		public Transform TrashContent;

		public Transform TrashContent_Min;

		public Transform TrashContent_Max;

		public Animation GrabAnim;

		public Transform Bin;

		public Transform BinRaisedPosition;

		public AudioSourceController TrashDropSound;

		[Header("Settings")]
		public float DropTime;

		public float DropForce;

		public Vector3 TrashDropOffset;

		public UnityEvent onPickup;

		private TrashGrabberInstance trashGrabberInstance;

		private Pose defaultBinPosition;

		private Vector3 defaultBinScale;

		public static Equippable_TrashGrabber Instance { get; private set; }

		public static bool IsEquipped => false;

		private float currentDropTime { get; set; }

		private float timeSinceLastDrop { get; set; }

		public override void Equip(ItemInstance item)
		{
		}

		public override void Unequip()
		{
		}

		protected override void Update()
		{
		}

		private void EjectTrash()
		{
		}

		private void OnDestroy()
		{
		}

		public void PickupTrash(TrashItem item)
		{
		}

		public int GetCapacity()
		{
			return 0;
		}

		private void RefreshVisuals()
		{
		}
	}
}
