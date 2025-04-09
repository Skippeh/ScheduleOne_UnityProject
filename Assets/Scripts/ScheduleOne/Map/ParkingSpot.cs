using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Map
{
	public class ParkingSpot : MonoBehaviour
	{
		private ParkingLot ParentLot;

		public Transform AlignmentPoint;

		public EParkingAlignment Alignment;

		[SerializeField]
		private LandVehicle OccupantVehicle_Readonly;

		public LandVehicle OccupantVehicle { get; protected set; }

		private void Awake()
		{
		}

		private void Init()
		{
		}

		public void SetOccupant(LandVehicle vehicle)
		{
		}
	}
}
