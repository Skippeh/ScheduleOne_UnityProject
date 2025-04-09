using System;
using UnityEngine;

namespace ScheduleOne.Storage
{
	public class PalletSlot : MonoBehaviour, IGUIDRegisterable
	{
		public Action onPalletAdded;

		public Action onPalletRemoved;

		public Guid GUID { get; protected set; }

		public Pallet occupant { get; protected set; }

		public void SetGUID(Guid guid)
		{
		}

		public void SetOccupant(Pallet _occupant)
		{
		}
	}
}
