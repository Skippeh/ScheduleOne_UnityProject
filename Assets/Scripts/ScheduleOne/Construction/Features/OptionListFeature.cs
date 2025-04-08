namespace ScheduleOne.Construction.Features
{
	public abstract class OptionListFeature : global::ScheduleOne.Construction.Features.Feature
	{
		[global::UnityEngine.Header("Option list feature settings")]
		public int defaultOptionIndex;

		[global::FishNet.Object.Synchronizing.SyncVar]
		public int ownedOptionIndex;

		public global::FishNet.Object.Synchronizing.SyncVar<int> syncVar___ownedOptionIndex;

		private bool NetworkInitialize___EarlyScheduleOne_002EConstruction_002EFeatures_002EOptionListFeatureAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EConstruction_002EFeatures_002EOptionListFeatureAssembly_002DCSharp_002Edll_Excuted;

		public int SyncAccessor_ownedOptionIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		public override global::ScheduleOne.UI.Construction.Features.FI_Base CreateInterface(global::UnityEngine.Transform parent)
		{
			return null;
		}

		public override void Default()
		{
		}

		protected abstract global::System.Collections.Generic.List<global::ScheduleOne.UI.Construction.Features.FI_OptionList.Option> GetOptions();

		public virtual void SelectOption(int optionIndex)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected virtual void SetData(int colorIndex)
		{
		}

		private void ReceiveData()
		{
		}

		public virtual void PurchaseOption(int optionIndex)
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

		private void RpcWriter___Server_SetData_3316948804(int colorIndex)
		{
		}

		protected virtual void RpcLogic___SetData_3316948804(int colorIndex)
		{
		}

		private void RpcReader___Server_SetData_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EConstruction_002EFeatures_002EOptionListFeature(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EConstruction_002EFeatures_002EOptionListFeature_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
