using System;
using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using UnityEngine;

namespace ScheduleOne.Map
{
	public class ParkingLot : MonoBehaviour, IGUIDRegisterable
	{
		[SerializeField]
		protected string BakedGUID;

		[Header("READONLY")]
		public List<ParkingSpot> ParkingSpots;

		[Header("Entry")]
		public Transform EntryPoint;

		public Transform HiddenVehicleAccessPoint;

		[Header("Exit")]
		public bool UseExitPoint;

		public EParkingAlignment ExitAlignment;

		public Transform ExitPoint;

		public VehicleDetector ExitPointVehicleDetector;

		public Guid GUID { get; protected set; }

		private void Awake()
		{
		}

		public void SetGUID(Guid guid)
		{
		}

		public ParkingSpot GetRandomFreeSpot()
		{
			return null;
		}

		public int GetRandomFreeSpotIndex()
		{
			return 0;
		}

		public List<ParkingSpot> GetFreeParkingSpots()
		{
			return null;
		}
	}
}
