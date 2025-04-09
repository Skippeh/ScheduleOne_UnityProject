using FishNet.Object;

namespace ScheduleOne.Management
{
	public interface IUsable
	{
		bool IsInUse => false;

		NetworkObject NPCUserObject { get; set; }

		NetworkObject PlayerUserObject { get; set; }

		void SetPlayerUser(NetworkObject playerObject);

		void SetNPCUser(NetworkObject playerObject);
	}
}
