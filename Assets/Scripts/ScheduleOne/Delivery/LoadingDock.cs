namespace ScheduleOne.Delivery
{
	public class LoadingDock : global::UnityEngine.MonoBehaviour, global::ScheduleOne.IGUIDRegisterable, global::ScheduleOne.Management.ITransitEntity
	{
		[global::UnityEngine.SerializeField]
		protected string BakedGUID;

		public global::ScheduleOne.Property.Property ParentProperty;

		public global::ScheduleOne.DevUtilities.VehicleDetector VehicleDetector;

		public global::ScheduleOne.Map.ParkingLot Parking;

		public global::UnityEngine.Transform uiPoint;

		public global::UnityEngine.Transform[] accessPoints;

		public global::UnityEngine.GameObject[] OutlineRenderers;

		private global::EPOOutline.Outlinable OutlineEffect;

		public global::ScheduleOne.Vehicles.LandVehicle DynamicOccupant { get; private set; }

		public global::ScheduleOne.Vehicles.LandVehicle StaticOccupant { get; private set; }

		public bool IsInUse => false;

		public global::System.Guid GUID { get; protected set; }

		public string Name => null;

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> InputSlots { get; set; }

		public global::System.Collections.Generic.List<global::ScheduleOne.ItemFramework.ItemSlot> OutputSlots { get; set; }

		public global::UnityEngine.Transform LinkOrigin => null;

		public global::UnityEngine.Transform[] AccessPoints => null;

		public bool Selectable { get; }

		public bool IsAcceptingItems { get; set; }

		public bool IsDestroyed { get; set; }

		[global::EasyButtons.Button]
		public void RegenerateGUID()
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		private void RefreshOccupant()
		{
		}

		private void SetOccupant(global::ScheduleOne.Vehicles.LandVehicle occupant)
		{
		}

		public void SetStaticOccupant(global::ScheduleOne.Vehicles.LandVehicle vehicle)
		{
		}

		public virtual void ShowOutline(global::UnityEngine.Color color)
		{
		}

		public virtual void HideOutline()
		{
		}
	}
}
