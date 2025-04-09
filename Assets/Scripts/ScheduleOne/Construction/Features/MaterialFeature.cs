using System;
using System.Collections.Generic;
using ScheduleOne.UI.Construction.Features;
using UnityEngine;

namespace ScheduleOne.Construction.Features
{
	public class MaterialFeature : OptionListFeature
	{
		[Serializable]
		public class NamedMaterial
		{
			public string matName;

			public Color buttonColor;

			public Material mat;

			public float price;
		}

		[Header("References")]
		[SerializeField]
		protected List<MeshRenderer> materialTargets;

		[Header("Material settings")]
		public List<NamedMaterial> materials;

		private bool NetworkInitialize___EarlyScheduleOne_002EConstruction_002EFeatures_002EMaterialFeatureAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EConstruction_002EFeatures_002EMaterialFeatureAssembly_002DCSharp_002Edll_Excuted;

		public override void SelectOption(int optionIndex)
		{
		}

		private void ApplyMaterial(NamedMaterial mat)
		{
		}

		protected override List<FI_OptionList.Option> GetOptions()
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

		public override void Awake()
		{
		}
	}
}
