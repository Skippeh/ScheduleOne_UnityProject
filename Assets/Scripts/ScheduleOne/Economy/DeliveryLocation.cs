namespace ScheduleOne.Economy
{
	public class DeliveryLocation : global::UnityEngine.MonoBehaviour, global::ScheduleOne.IGUIDRegisterable
	{
		public string LocationName;

		public string LocationDescription;

		public global::UnityEngine.Transform CustomerStandPoint;

		public global::UnityEngine.Transform TeleportPoint;

		public global::ScheduleOne.Map.POI PoI;

		public string StaticGUID;

		public global::System.Collections.Generic.List<global::ScheduleOne.Quests.Contract> ScheduledContracts;

		public global::System.Guid GUID { get; protected set; }

		public void SetGUID(global::System.Guid guid)
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
