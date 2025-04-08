namespace ScheduleOne.NPCs.CharacterClasses
{
	public class Dan : global::ScheduleOne.NPCs.NPC
	{
		public global::ScheduleOne.UI.Shop.ShopInterface ShopInterface;

		[global::UnityEngine.Header("Settings")]
		public string[] OrderCompletedLines;

		public global::UnityEngine.Events.UnityEvent onGreeting;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ECharacterClasses_002EDanAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ECharacterClasses_002EDanAssembly_002DCSharp_002Edll_Excuted;

		protected override void Start()
		{
		}

		private void OrderCompleted()
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
