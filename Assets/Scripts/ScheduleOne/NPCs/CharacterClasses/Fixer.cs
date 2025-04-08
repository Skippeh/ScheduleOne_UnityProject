namespace ScheduleOne.NPCs.CharacterClasses
{
	public class Fixer : global::ScheduleOne.NPCs.NPC
	{
		public const int ADDITIONAL_SIGNING_FEE_1 = 100;

		public const int ADDITIONAL_SIGNING_FEE_2 = 250;

		public const int MAX_SIGNING_FEE = 500;

		public const int ADDITIONAL_FEE_THRESHOLD = 5;

		public global::ScheduleOne.Dialogue.DialogueContainer GreetingDialogue;

		public string GreetedVariable;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ECharacterClasses_002EFixerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ECharacterClasses_002EFixerAssembly_002DCSharp_002Edll_Excuted;

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

		public static float GetAdditionalSigningFee()
		{
			return 0f;
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
