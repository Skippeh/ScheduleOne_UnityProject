namespace ScheduleOne.Construction.Features
{
	public class GenericOptionListFeature : global::ScheduleOne.Construction.Features.OptionListFeature
	{
		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.Construction.Features.GenericOption> options;

		private global::ScheduleOne.Construction.Features.GenericOption visibleOption;

		private global::ScheduleOne.Construction.Features.GenericOption installedOption;

		private bool NetworkInitialize___EarlyScheduleOne_002EConstruction_002EFeatures_002EGenericOptionListFeatureAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EConstruction_002EFeatures_002EGenericOptionListFeatureAssembly_002DCSharp_002Edll_Excuted;

		public override void Default()
		{
		}

		protected override global::System.Collections.Generic.List<global::ScheduleOne.UI.Construction.Features.FI_OptionList.Option> GetOptions()
		{
			return null;
		}

		public override void SelectOption(int optionIndex)
		{
		}

		public override void PurchaseOption(int optionIndex)
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
