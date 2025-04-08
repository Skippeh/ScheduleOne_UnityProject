namespace ScheduleOne.Construction.Features
{
	public class MaterialFeature : global::ScheduleOne.Construction.Features.OptionListFeature
	{
		[global::System.Serializable]
		public class NamedMaterial
		{
			public string matName;

			public global::UnityEngine.Color buttonColor;

			public global::UnityEngine.Material mat;

			public float price;
		}

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::UnityEngine.MeshRenderer> materialTargets;

		[global::UnityEngine.Header("Material settings")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Construction.Features.MaterialFeature.NamedMaterial> materials;

		private bool NetworkInitialize___EarlyScheduleOne_002EConstruction_002EFeatures_002EMaterialFeatureAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EConstruction_002EFeatures_002EMaterialFeatureAssembly_002DCSharp_002Edll_Excuted;

		public override void SelectOption(int optionIndex)
		{
		}

		private void ApplyMaterial(global::ScheduleOne.Construction.Features.MaterialFeature.NamedMaterial mat)
		{
		}

		protected override global::System.Collections.Generic.List<global::ScheduleOne.UI.Construction.Features.FI_OptionList.Option> GetOptions()
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
