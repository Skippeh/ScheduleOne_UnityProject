using System;
using System.Collections.Generic;
using ScheduleOne.Map;
using ScheduleOne.Quests;
using UnityEngine;

namespace ScheduleOne.Economy
{
	public class DeliveryLocation : MonoBehaviour, IGUIDRegisterable
	{
		public string LocationName;

		public string LocationDescription;

		public Transform CustomerStandPoint;

		public Transform TeleportPoint;

		public POI PoI;

		public string StaticGUID;

		public List<Contract> ScheduledContracts;

		public Guid GUID { get; protected set; }

		public void SetGUID(Guid guid)
		{
		}

		private void Awake()
		{
		}

		private void OnValidate()
		{
		}

		public virtual string GetDescription()
		{
			return null;
		}
	}
}
