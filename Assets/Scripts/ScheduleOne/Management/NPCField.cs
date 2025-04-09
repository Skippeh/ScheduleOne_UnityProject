using System;
using ScheduleOne.NPCs;
using ScheduleOne.Persistence.Datas;
using UnityEngine.Events;

namespace ScheduleOne.Management
{
	public class NPCField : ConfigField
	{
		public Type TypeRequirement;

		public UnityEvent<NPC> onNPCChanged;

		public NPC SelectedNPC { get; protected set; }

		public NPCField(EntityConfiguration parentConfig)
			: base(null)
		{
		}

		public void SetNPC(NPC npc, bool network)
		{
		}

		public bool DoesNPCMatchRequirement(NPC npc)
		{
			return false;
		}

		public override bool IsValueDefault()
		{
			return false;
		}

		public NPCFieldData GetData()
		{
			return null;
		}

		public void Load(NPCFieldData data)
		{
		}
	}
}
