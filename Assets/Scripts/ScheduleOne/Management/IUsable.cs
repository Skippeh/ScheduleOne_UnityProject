namespace ScheduleOne.Management
{
	public interface IUsable
	{
		bool IsInUse => false;

		global::FishNet.Object.NetworkObject NPCUserObject { get; set; }

		global::FishNet.Object.NetworkObject PlayerUserObject { get; set; }

		void SetPlayerUser(global::FishNet.Object.NetworkObject playerObject);

		void SetNPCUser(global::FishNet.Object.NetworkObject playerObject);
	}
}
