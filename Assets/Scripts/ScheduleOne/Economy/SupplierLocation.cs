using System.Collections.Generic;
using ScheduleOne.Map;
using ScheduleOne.Storage;
using UnityEngine;

namespace ScheduleOne.Economy
{
	public class SupplierLocation : MonoBehaviour
	{
		public static List<SupplierLocation> AllLocations;

		[Header("Settings")]
		public string LocationName;

		public string LocationDescription;

		[Header("References")]
		public Transform GenericContainer;

		public Transform SupplierStandPoint;

		public WorldStorageEntity[] DeliveryBays;

		public POI PoI;

		private SupplierLocationConfiguration[] configs;

		public bool IsOccupied => false;

		public Supplier ActiveSupplier { get; private set; }

		public void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void SetActiveSupplier(Supplier supplier)
		{
		}
	}
}
