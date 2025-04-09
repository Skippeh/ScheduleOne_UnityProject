using UnityEngine;

namespace ScheduleOne.Storage
{
	public class PalletSlotDetector : MonoBehaviour
	{
		public Pallet pallet;

		protected virtual void OnTriggerStay(Collider other)
		{
		}
	}
}
