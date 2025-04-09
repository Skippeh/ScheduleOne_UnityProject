using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.Market
{
	public class VendorZone : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		protected BoxCollider zoneCollider;

		[SerializeField]
		protected List<GameObject> doors;

		[Header("Settings")]
		[SerializeField]
		protected int openTime;

		[SerializeField]
		protected int closeTime;

		public bool isOpen => false;

		protected virtual void Start()
		{
		}

		private void MinPassed()
		{
		}

		private bool IsPlayerWithinVendorZone()
		{
			return false;
		}

		private void SetDoorsActive(bool a)
		{
		}
	}
}
