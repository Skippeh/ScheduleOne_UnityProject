namespace ScheduleOne.Equipping
{
	public class Equippable_TrashGrabber : global::ScheduleOne.Equipping.Equippable_Viewmodel
	{
		public const float TrashDropSpacing = 0.15f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform TrashContent;

		public global::UnityEngine.Transform TrashContent_Min;

		public global::UnityEngine.Transform TrashContent_Max;

		public global::UnityEngine.Animation GrabAnim;

		public global::UnityEngine.Transform Bin;

		public global::UnityEngine.Transform BinRaisedPosition;

		public global::ScheduleOne.Audio.AudioSourceController TrashDropSound;

		[global::UnityEngine.Header("Settings")]
		public float DropTime;

		public float DropForce;

		public global::UnityEngine.Vector3 TrashDropOffset;

		public global::UnityEngine.Events.UnityEvent onPickup;

		private global::ScheduleOne.ObjectScripts.WateringCan.TrashGrabberInstance trashGrabberInstance;

		private global::UnityEngine.Pose defaultBinPosition;

		private global::UnityEngine.Vector3 defaultBinScale;

		public static global::ScheduleOne.Equipping.Equippable_TrashGrabber Instance { get; private set; }

		public static bool IsEquipped => false;

		private float currentDropTime { get; set; }

		private float timeSinceLastDrop { get; set; }

		public override void Equip(global::ScheduleOne.ItemFramework.ItemInstance item)
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

		public void PickupTrash(global::ScheduleOne.Trash.TrashItem item)
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
