namespace ScheduleOne.Graffiti
{
	public class GraffitiManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Graffiti.GraffitiManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		private const string SPRAY_PAINT_STOCK_VARIABLE = "SprayPaintStock";

		private const string SPRAY_PAINTS_PURCHASED_VARIABLE = "SprayPaintsPurchased";

		private global::ScheduleOne.Persistence.Loaders.GraffitiLoader loader;

		private global::System.Collections.Generic.List<global::System.Tuple<global::ScheduleOne.Graffiti.SpraySurface, global::FishNet.Connection.NetworkConnection>> surfaceReplicationQueue;

		private float timeUntilNextReplication;

		private bool NetworkInitialize___EarlyScheduleOne_002EGraffiti_002EGraffitiManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EGraffiti_002EGraffitiManagerAssembly_002DCSharp_002Edll_Excuted;

		public global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SpraySurface> SpraySurfaces { get; private set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public int LoadOrder { get; }

		public override void Awake()
		{
		}

		public override void OnStartServer()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		private void SprayPaintPurchaseCountChanged(float newValue)
		{
		}

		private void RankChange(global::ScheduleOne.Levelling.FullRank oldRank, global::ScheduleOne.Levelling.FullRank newRank)
		{
		}

		private void UpdateSprayPaintStockVariable()
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public void QueueSurfaceToReplicate(global::ScheduleOne.Graffiti.SpraySurface surface, global::FishNet.Connection.NetworkConnection conn)
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

		protected virtual void Awake_UserLogic_ScheduleOne_002EGraffiti_002EGraffitiManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
