namespace ScheduleOne.Construction.Features
{
	public abstract class Feature : global::FishNet.Object.NetworkBehaviour
	{
		public string featureName;

		public global::UnityEngine.Sprite featureIcon;

		public global::UnityEngine.Transform featureIconLocation;

		public global::UnityEngine.GameObject featureInterfacePrefab;

		public bool disableRoofDisibility;

		private bool NetworkInitialize___EarlyScheduleOne_002EConstruction_002EFeatures_002EFeatureAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EConstruction_002EFeatures_002EFeatureAssembly_002DCSharp_002Edll_Excuted;

		public virtual void Awake()
		{
		}

		public override void OnStartClient()
		{
		}

		public virtual global::ScheduleOne.UI.Construction.Features.FI_Base CreateInterface(global::UnityEngine.Transform parent)
		{
			return null;
		}

		public abstract void Default();

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EConstruction_002EFeatures_002EFeature_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
