namespace ScheduleOne.Storage
{
	public class PalletZone : global::UnityEngine.MonoBehaviour
	{
		private global::System.Collections.Generic.List<global::ScheduleOne.Storage.Pallet> pallets;

		[global::UnityEngine.Header("Prefabs")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject palletPrefab;

		private bool orderReceivedThisFrame;

		public bool isClear => false;

		protected void OnTriggerStay(global::UnityEngine.Collider other)
		{
		}

		protected void FixedUpdate()
		{
		}

		protected void LateUpdate()
		{
		}

		public global::ScheduleOne.Storage.Pallet GeneratePallet()
		{
			return null;
		}

		private bool AreAllPalletsClear()
		{
			return false;
		}
	}
}
