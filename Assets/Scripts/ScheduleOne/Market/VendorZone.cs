namespace ScheduleOne.Market
{
	public class VendorZone : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.BoxCollider zoneCollider;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::UnityEngine.GameObject> doors;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		protected int openTime;

		[global::UnityEngine.SerializeField]
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
