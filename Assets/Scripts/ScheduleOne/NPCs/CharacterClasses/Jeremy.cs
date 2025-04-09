using System;
using System.Collections.Generic;
using ScheduleOne.Dialogue;
using ScheduleOne.Map;

namespace ScheduleOne.NPCs.CharacterClasses
{
	public class Jeremy : NPC
	{
		[Serializable]
		public class DealershipListing
		{
			public string vehicleCode;

			public string vehicleName => null;

			public float price => 0f;
		}

		public Dealership Dealership;

		public List<DealershipListing> Listings;

		public DialogueContainer GreetingDialogue;

		public string GreetedVariable;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ECharacterClasses_002EJeremyAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ECharacterClasses_002EJeremyAssembly_002DCSharp_002Edll_Excuted;

		protected override void Start()
		{
		}

		private void Loaded()
		{
		}

		private void EnableGreeting()
		{
		}

		private void SetGreeted()
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

		public override void Awake()
		{
		}
	}
}
