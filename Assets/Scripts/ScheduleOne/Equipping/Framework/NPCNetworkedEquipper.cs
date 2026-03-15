namespace ScheduleOne.Equipping.Framework
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.NPCs.NPC))]
	public class NPCNetworkedEquipper : global::ScheduleOne.Equipping.Framework.NetworkedEquipper
	{
		private global::ScheduleOne.NPCs.NPC _npc;

		private bool NetworkInitialize___EarlyScheduleOne_002EEquipping_002EFramework_002ENPCNetworkedEquipperAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EEquipping_002EFramework_002ENPCNetworkedEquipperAssembly_002DCSharp_002Edll_Excuted;

		public override void Awake()
		{
		}

		protected override global::ScheduleOne.Core.Equipping.Framework.IEquippableUser GetUser()
		{
			return null;
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void Awake_UserLogic_ScheduleOne_002EEquipping_002EFramework_002ENPCNetworkedEquipper_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
