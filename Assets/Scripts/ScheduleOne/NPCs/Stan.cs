namespace ScheduleOne.NPCs
{
	public class Stan : global::ScheduleOne.NPCs.NPC
	{
		public global::ScheduleOne.UI.Shop.ShopInterface ShopInterface;

		public global::ScheduleOne.Dialogue.DialogueContainer GreetingDialogue;

		public string GreetedVariable;

		[global::UnityEngine.Header("Settings")]
		public string[] OrderCompletedLines;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EStanAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EStanAssembly_002DCSharp_002Edll_Excuted;

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
