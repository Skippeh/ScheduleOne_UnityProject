namespace ScheduleOne.Management
{
	public interface IUsable
	{
		bool IsInUse => false;

		bool IsUsedByLocalPlayer => false;

		global::FishNet.Object.NetworkObject NPCUserObject { get; set; }

		global::FishNet.Object.NetworkObject PlayerUserObject { get; set; }

		string UserName => null;

		bool IsInUseByNPC(global::ScheduleOne.NPCs.NPC npc)
		{
			return false;
		}

		void SetPlayerUser(global::FishNet.Object.NetworkObject playerObject);

		void SetNPCUser(global::FishNet.Object.NetworkObject playerObject);
	}
}
