namespace ScheduleOne.NPCs.Other
{
	public class UseUmbrella : global::ScheduleOne.NPCs.Other.NPCDiscreteAction
	{
		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.NPCs.NPC _npc;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Core.Equipping.Framework.EquippableData _umbrellaData;

		private global::ScheduleOne.Core.Equipping.Framework.IEquippedItemHandler _equippedItemHandler;

		private void Awake()
		{
		}

		protected override void BeginOnServer()
		{
		}

		protected override void EndOnServer()
		{
		}
	}
}
