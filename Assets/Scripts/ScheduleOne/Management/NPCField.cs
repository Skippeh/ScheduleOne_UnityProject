namespace ScheduleOne.Management
{
	public class NPCField : global::ScheduleOne.Management.ConfigField
	{
		public global::System.Type TypeRequirement;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.NPCs.NPC> onNPCChanged;

		public global::ScheduleOne.NPCs.NPC SelectedNPC { get; protected set; }

		public NPCField(global::ScheduleOne.Management.EntityConfiguration parentConfig)
			: base(null)
		{
		}

		public void SetNPC(global::ScheduleOne.NPCs.NPC npc, bool network)
		{
		}

		public bool DoesNPCMatchRequirement(global::ScheduleOne.NPCs.NPC npc)
		{
			return false;
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		public global::ScheduleOne.Persistence.Datas.NPCFieldData GetData()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.NPCFieldData data)
		{
		}
	}
}
