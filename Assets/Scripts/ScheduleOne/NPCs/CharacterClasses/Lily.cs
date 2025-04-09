using ScheduleOne.NPCs.Relation;
using ScheduleOne.Variables;
using UnityEngine;

namespace ScheduleOne.NPCs.CharacterClasses
{
	public class Lily : NPC
	{
		[Header("References")]
		public Transform TutorialScheduleGroup;

		public Transform RegularScheduleGroup;

		public Conditions TutorialConditions;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ECharacterClasses_002ELilyAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ECharacterClasses_002ELilyAssembly_002DCSharp_002Edll_Excuted;

		public override void Awake()
		{
		}

		private void Unlocked(NPCRelationData.EUnlockType type, bool b)
		{
		}

		protected override void MinPass()
		{
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

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ECharacterClasses_002ELily_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
