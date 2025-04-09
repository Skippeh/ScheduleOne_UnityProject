using System.Collections.Generic;
using ScheduleOne.UI.Construction.Features;
using UnityEngine;

namespace ScheduleOne.Construction.Features
{
	public class GenericOptionListFeature : OptionListFeature
	{
		[Header("References")]
		[SerializeField]
		protected List<GenericOption> options;

		private GenericOption visibleOption;

		private GenericOption installedOption;

		private bool NetworkInitialize___EarlyScheduleOne_002EConstruction_002EFeatures_002EGenericOptionListFeatureAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EConstruction_002EFeatures_002EGenericOptionListFeatureAssembly_002DCSharp_002Edll_Excuted;

		public override void Default()
		{
		}

		protected override List<FI_OptionList.Option> GetOptions()
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
