using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.Vehicles
{
	public class VehicleSeat : MonoBehaviour
	{
		public bool isDriverSeat;

		public Player Occupant;

		public bool isOccupied => false;
	}
}
