namespace ScheduleOne.Construction.Features
{
	public class ColorFeature : global::ScheduleOne.Construction.Features.Feature
	{
		[global::System.Serializable]
		public class NamedColor
		{
			public string colorName;

			public global::UnityEngine.Color color;

			public float price;
		}

		[global::System.Serializable]
		public class SecondaryPaintTarget
		{
			public global::System.Collections.Generic.List<global::UnityEngine.MeshRenderer> colorTargets;

			public float sChange;

			public float vChange;
		}

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::UnityEngine.MeshRenderer> colorTargets;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::ScheduleOne.Construction.Features.ColorFeature.SecondaryPaintTarget> secondaryTargets;

		[global::UnityEngine.Header("Color settings")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Construction.Features.ColorFeature.NamedColor> colors;

		public int defaultColorIndex;

		[global::FishNet.Object.Synchronizing.SyncVar]
		public int ownedColorIndex;

		public global::FishNet.Object.Synchronizing.SyncVar<int> syncVar___ownedColorIndex;

		private bool NetworkInitialize___EarlyScheduleOne_002EConstruction_002EFeatures_002EColorFeatureAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EConstruction_002EFeatures_002EColorFeatureAssembly_002DCSharp_002Edll_Excuted;

		public int SyncAccessor_ownedColorIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public override global::ScheduleOne.UI.Construction.Features.FI_Base CreateInterface(global::UnityEngine.Transform parent)
		{
			return null;
		}

		public override void Default()
		{
		}

		private void ApplyColor(global::ScheduleOne.Construction.Features.ColorFeature.NamedColor color)
		{
		}

		public static global::UnityEngine.Color ModifyColor(global::UnityEngine.Color original, float sChange, float vChange)
		{
			return default(global::UnityEngine.Color);
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected virtual void SetData(int colorIndex)
		{
		}

		private void ReceiveData()
		{
		}

		private void BuyColor(global::ScheduleOne.Construction.Features.ColorFeature.NamedColor color)
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

		public virtual bool ReadSyncVar___ScheduleOne_002EConstruction_002EFeatures_002EColorFeature(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		public override void Awake()
		{
		}
	}
}
