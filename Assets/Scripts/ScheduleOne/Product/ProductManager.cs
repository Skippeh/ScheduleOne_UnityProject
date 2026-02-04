namespace ScheduleOne.Product
{
	public class ProductManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.Product.ProductManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		public const int MIN_PRICE = 1;

		public const int MAX_PRICE = 999;

		public const int CONTRACT_RECEIPT_MAX_COUNT = 500;

		public const int STAGGERED_REPLICATIONS_PER_SECOND = 80;

		public global::System.Action<global::ScheduleOne.Product.ProductDefinition> onProductDiscovered;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Product.ProductDefinition> DiscoveredProducts;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Product.ProductDefinition> ListedProducts;

		public static global::System.Collections.Generic.List<global::ScheduleOne.Product.ProductDefinition> FavouritedProducts;

		public global::System.Collections.Generic.List<global::ScheduleOne.Product.ProductDefinition> AllProducts;

		public global::System.Collections.Generic.List<global::ScheduleOne.Product.ProductDefinition> DefaultKnownProducts;

		public global::System.Collections.Generic.List<global::ScheduleOne.Product.PropertyItemDefinition> ValidMixIngredients;

		public global::System.Collections.Generic.List<global::ScheduleOne.Economy.ContractReceipt> ContractReceipts;

		public global::UnityEngine.AnimationCurve SampleSuccessCurve;

		public global::ScheduleOne.Product.ProductDefinition[] ListForSaleOnStart;

		[global::UnityEngine.Header("Default Products")]
		public global::ScheduleOne.Product.WeedDefinition DefaultWeed;

		public global::ScheduleOne.Product.CocaineDefinition DefaultCocaine;

		public global::ScheduleOne.Product.MethDefinition DefaultMeth;

		public global::ScheduleOne.Product.ShroomDefinition DefaultShroom;

		[global::UnityEngine.Header("Mix Maps")]
		public global::ScheduleOne.Effects.MixMaps.MixerMap WeedMixMap;

		public global::ScheduleOne.Effects.MixMaps.MixerMap MethMixMap;

		public global::ScheduleOne.Effects.MixMaps.MixerMap CokeMixMap;

		public global::ScheduleOne.Effects.MixMaps.MixerMap ShroomMixMap;

		private global::System.Collections.Generic.List<global::ScheduleOne.Product.ProductDefinition> createdProducts;

		public global::System.Action<global::ScheduleOne.Product.NewMixOperation> onMixCompleted;

		public global::System.Action<global::ScheduleOne.Product.ProductDefinition> onNewProductCreated;

		public global::System.Action<global::ScheduleOne.Product.ProductDefinition> onProductListed;

		public global::System.Action<global::ScheduleOne.Product.ProductDefinition> onProductDelisted;

		public global::System.Action<global::ScheduleOne.Product.ProductDefinition> onProductFavourited;

		public global::System.Action<global::ScheduleOne.Product.ProductDefinition> onProductUnfavourited;

		public global::System.Action<global::ScheduleOne.Economy.ContractReceipt> onContractReceiptRecorded;

		public global::UnityEngine.Events.UnityEvent onFirstSampleRejection;

		public global::UnityEngine.Events.UnityEvent onSecondUniqueProductCreated;

		public global::System.Collections.Generic.List<string> ProductNames;

		private global::System.Collections.Generic.List<global::ScheduleOne.StationFramework.StationRecipe> mixRecipes;

		public global::System.Action<global::ScheduleOne.StationFramework.StationRecipe> onMixRecipeAdded;

		private global::System.Collections.Generic.Dictionary<global::ScheduleOne.Product.ProductDefinition, float> ProductPrices;

		private global::ScheduleOne.Product.ProductDefinition highestValueProduct;

		private global::System.Collections.Generic.List<global::FishNet.Connection.NetworkConnection> productDataSentTo;

		public global::System.Action<global::FishNet.Connection.NetworkConnection> onProductDataSentToConnection;

		private global::ScheduleOne.Persistence.Loaders.ProductManagerLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002EProduct_002EProductManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EProduct_002EProductManagerAssembly_002DCSharp_002Edll_Excuted;

		public static bool MethDiscovered => false;

		public static bool CocaineDiscovered => false;

		public static bool ShroomsDiscovered => false;

		public static bool IsAcceptingOrders { get; private set; }

		public global::ScheduleOne.Product.NewMixOperation CurrentMixOperation { get; private set; }

		public bool IsMixingInProgress => false;

		public bool IsMixComplete { get; private set; }

		public float TimeSinceProductListingChanged { get; private set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public int LoadOrder { get; }

		public bool HasSentProductDataToConnection(global::FishNet.Connection.NetworkConnection conn)
		{
			return false;
		}

		public override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public override void OnStartServer()
		{
		}

		public override void OnStartClient()
		{
		}

		private void Update()
		{
		}

		private void Clean()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetMethDiscovered()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetCocaineDiscovered()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetShroomsDiscovered()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void RecordContractReceipt(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Economy.ContractReceipt receipt)
		{
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Economy.ContractReceipt> GetContractReceipts(global::ScheduleOne.Map.EMapRegion region, global::System.Collections.Generic.List<global::ScheduleOne.Economy.EContractParty> dealCompleterTypes, int maxMinsAgo)
		{
			return null;
		}

		public virtual void InitializeSaveable()
		{
		}

		public global::ScheduleOne.Effects.MixMaps.MixerMap GetMixerMap(global::ScheduleOne.Product.EDrugType type)
		{
			return null;
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		private void OnMinPass()
		{
		}

		private void OnNewDay()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetProductListed(string productID, bool listed)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetProductListed(global::FishNet.Connection.NetworkConnection conn, string productID, bool listed)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetProductFavourited(string productID, bool listed)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetProductFavourited(global::FishNet.Connection.NetworkConnection conn, string productID, bool fav)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void DiscoverProduct(string productID)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetProductDiscovered(global::FishNet.Connection.NetworkConnection conn, string productID, bool autoList)
		{
		}

		public void SetIsAcceptingOrder(bool accepting)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateWeed_Server(string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.WeedAppearanceSettings appearance)
		{
		}

		[global::FishNet.Object.TargetRpc]
		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void CreateWeed(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.WeedAppearanceSettings appearance)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateCocaine_Server(string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.CocaineAppearanceSettings appearance)
		{
		}

		[global::FishNet.Object.TargetRpc]
		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void CreateCocaine(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.CocaineAppearanceSettings appearance)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateMeth_Server(string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.MethAppearanceSettings appearance)
		{
		}

		[global::FishNet.Object.TargetRpc]
		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void CreateMeth(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.MethAppearanceSettings appearance)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateShroom_Server(string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.ShroomAppearanceSettings appearance)
		{
		}

		[global::FishNet.Object.TargetRpc]
		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void CreateShroom_Client(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.ShroomAppearanceSettings appearance)
		{
		}

		private void RefreshHighestValueProduct()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMixRecipe(string product, string mixer, string output)
		{
		}

		[global::FishNet.Object.TargetRpc]
		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void CreateMixRecipe(global::FishNet.Connection.NetworkConnection conn, string product, string mixer, string output)
		{
		}

		public global::ScheduleOne.StationFramework.StationRecipe GetRecipe(string product, string mixer)
		{
			return null;
		}

		public global::ScheduleOne.StationFramework.StationRecipe GetRecipe(global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> productProperties, global::ScheduleOne.Effects.Effect mixerProperty)
		{
			return null;
		}

		public global::ScheduleOne.Product.ProductDefinition GetKnownProduct(global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties)
		{
			return null;
		}

		public float GetPrice(global::ScheduleOne.Product.ProductDefinition product)
		{
			return 0f;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPrice(string productID, float value)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetPrice(global::FishNet.Connection.NetworkConnection conn, string productID, float value)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMixOperation(global::ScheduleOne.Product.NewMixOperation operation, bool complete)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetMixOperation(global::ScheduleOne.Product.NewMixOperation operation, bool complete)
		{
		}

		public string FinishAndNameMix(string productID, string ingredientID, string mixName)
		{
			return null;
		}

		public static string MakeIDFileSafe(string id)
		{
			return null;
		}

		public static bool IsMixNameValid(string mixName)
		{
			return false;
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void FinishAndNameMix(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendFinishAndNameMix(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		public static float CalculateProductValue(global::ScheduleOne.Product.ProductDefinition product, float baseValue)
		{
			return 0f;
		}

		public static float CalculateProductValue(float baseValue, global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties)
		{
			return 0f;
		}

		public virtual string GetSaveString()
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

		private void RpcWriter___Server_SetMethDiscovered_2166136261()
		{
		}

		public void RpcLogic___SetMethDiscovered_2166136261()
		{
		}

		private void RpcReader___Server_SetMethDiscovered_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetCocaineDiscovered_2166136261()
		{
		}

		public void RpcLogic___SetCocaineDiscovered_2166136261()
		{
		}

		private void RpcReader___Server_SetCocaineDiscovered_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetShroomsDiscovered_2166136261()
		{
		}

		public void RpcLogic___SetShroomsDiscovered_2166136261()
		{
		}

		private void RpcReader___Server_SetShroomsDiscovered_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_RecordContractReceipt_691682765(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Economy.ContractReceipt receipt)
		{
		}

		public void RpcLogic___RecordContractReceipt_691682765(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Economy.ContractReceipt receipt)
		{
		}

		private void RpcReader___Observers_RecordContractReceipt_691682765(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_RecordContractReceipt_691682765(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Economy.ContractReceipt receipt)
		{
		}

		private void RpcReader___Target_RecordContractReceipt_691682765(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetProductListed_310431262(string productID, bool listed)
		{
		}

		public void RpcLogic___SetProductListed_310431262(string productID, bool listed)
		{
		}

		private void RpcReader___Server_SetProductListed_310431262(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetProductListed_619441887(global::FishNet.Connection.NetworkConnection conn, string productID, bool listed)
		{
		}

		public void RpcLogic___SetProductListed_619441887(global::FishNet.Connection.NetworkConnection conn, string productID, bool listed)
		{
		}

		private void RpcReader___Observers_SetProductListed_619441887(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetProductListed_619441887(global::FishNet.Connection.NetworkConnection conn, string productID, bool listed)
		{
		}

		private void RpcReader___Target_SetProductListed_619441887(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetProductFavourited_310431262(string productID, bool listed)
		{
		}

		public void RpcLogic___SetProductFavourited_310431262(string productID, bool listed)
		{
		}

		private void RpcReader___Server_SetProductFavourited_310431262(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetProductFavourited_619441887(global::FishNet.Connection.NetworkConnection conn, string productID, bool fav)
		{
		}

		public void RpcLogic___SetProductFavourited_619441887(global::FishNet.Connection.NetworkConnection conn, string productID, bool fav)
		{
		}

		private void RpcReader___Observers_SetProductFavourited_619441887(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetProductFavourited_619441887(global::FishNet.Connection.NetworkConnection conn, string productID, bool fav)
		{
		}

		private void RpcReader___Target_SetProductFavourited_619441887(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_DiscoverProduct_3615296227(string productID)
		{
		}

		public void RpcLogic___DiscoverProduct_3615296227(string productID)
		{
		}

		private void RpcReader___Server_DiscoverProduct_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetProductDiscovered_619441887(global::FishNet.Connection.NetworkConnection conn, string productID, bool autoList)
		{
		}

		public void RpcLogic___SetProductDiscovered_619441887(global::FishNet.Connection.NetworkConnection conn, string productID, bool autoList)
		{
		}

		private void RpcReader___Observers_SetProductDiscovered_619441887(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetProductDiscovered_619441887(global::FishNet.Connection.NetworkConnection conn, string productID, bool autoList)
		{
		}

		private void RpcReader___Target_SetProductDiscovered_619441887(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_CreateWeed_Server_2331775230(string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.WeedAppearanceSettings appearance)
		{
		}

		public void RpcLogic___CreateWeed_Server_2331775230(string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.WeedAppearanceSettings appearance)
		{
		}

		private void RpcReader___Server_CreateWeed_Server_2331775230(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_CreateWeed_1777266891(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.WeedAppearanceSettings appearance)
		{
		}

		private void RpcLogic___CreateWeed_1777266891(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.WeedAppearanceSettings appearance)
		{
		}

		private void RpcReader___Target_CreateWeed_1777266891(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_CreateWeed_1777266891(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.WeedAppearanceSettings appearance)
		{
		}

		private void RpcReader___Observers_CreateWeed_1777266891(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_CreateCocaine_Server_891166717(string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.CocaineAppearanceSettings appearance)
		{
		}

		public void RpcLogic___CreateCocaine_Server_891166717(string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.CocaineAppearanceSettings appearance)
		{
		}

		private void RpcReader___Server_CreateCocaine_Server_891166717(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_CreateCocaine_1327282946(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.CocaineAppearanceSettings appearance)
		{
		}

		private void RpcLogic___CreateCocaine_1327282946(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.CocaineAppearanceSettings appearance)
		{
		}

		private void RpcReader___Target_CreateCocaine_1327282946(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_CreateCocaine_1327282946(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.CocaineAppearanceSettings appearance)
		{
		}

		private void RpcReader___Observers_CreateCocaine_1327282946(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_CreateMeth_Server_4251728555(string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.MethAppearanceSettings appearance)
		{
		}

		public void RpcLogic___CreateMeth_Server_4251728555(string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.MethAppearanceSettings appearance)
		{
		}

		private void RpcReader___Server_CreateMeth_Server_4251728555(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_CreateMeth_1869045686(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.MethAppearanceSettings appearance)
		{
		}

		private void RpcLogic___CreateMeth_1869045686(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.MethAppearanceSettings appearance)
		{
		}

		private void RpcReader___Target_CreateMeth_1869045686(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_CreateMeth_1869045686(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.MethAppearanceSettings appearance)
		{
		}

		private void RpcReader___Observers_CreateMeth_1869045686(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_CreateShroom_Server_2261384965(string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.ShroomAppearanceSettings appearance)
		{
		}

		public void RpcLogic___CreateShroom_Server_2261384965(string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.ShroomAppearanceSettings appearance)
		{
		}

		private void RpcReader___Server_CreateShroom_Server_2261384965(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_CreateShroom_Client_812995776(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.ShroomAppearanceSettings appearance)
		{
		}

		private void RpcLogic___CreateShroom_Client_812995776(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.ShroomAppearanceSettings appearance)
		{
		}

		private void RpcReader___Target_CreateShroom_Client_812995776(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_CreateShroom_Client_812995776(global::FishNet.Connection.NetworkConnection conn, string name, string id, global::ScheduleOne.Product.EDrugType type, global::System.Collections.Generic.List<string> properties, global::ScheduleOne.Product.ShroomAppearanceSettings appearance)
		{
		}

		private void RpcReader___Observers_CreateShroom_Client_812995776(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendMixRecipe_852232071(string product, string mixer, string output)
		{
		}

		public void RpcLogic___SendMixRecipe_852232071(string product, string mixer, string output)
		{
		}

		private void RpcReader___Server_SendMixRecipe_852232071(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_CreateMixRecipe_1410895574(global::FishNet.Connection.NetworkConnection conn, string product, string mixer, string output)
		{
		}

		public void RpcLogic___CreateMixRecipe_1410895574(global::FishNet.Connection.NetworkConnection conn, string product, string mixer, string output)
		{
		}

		private void RpcReader___Target_CreateMixRecipe_1410895574(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_CreateMixRecipe_1410895574(global::FishNet.Connection.NetworkConnection conn, string product, string mixer, string output)
		{
		}

		private void RpcReader___Observers_CreateMixRecipe_1410895574(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendPrice_606697822(string productID, float value)
		{
		}

		public void RpcLogic___SendPrice_606697822(string productID, float value)
		{
		}

		private void RpcReader___Server_SendPrice_606697822(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetPrice_4077118173(global::FishNet.Connection.NetworkConnection conn, string productID, float value)
		{
		}

		public void RpcLogic___SetPrice_4077118173(global::FishNet.Connection.NetworkConnection conn, string productID, float value)
		{
		}

		private void RpcReader___Observers_SetPrice_4077118173(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetPrice_4077118173(global::FishNet.Connection.NetworkConnection conn, string productID, float value)
		{
		}

		private void RpcReader___Target_SetPrice_4077118173(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendMixOperation_3670976965(global::ScheduleOne.Product.NewMixOperation operation, bool complete)
		{
		}

		public void RpcLogic___SendMixOperation_3670976965(global::ScheduleOne.Product.NewMixOperation operation, bool complete)
		{
		}

		private void RpcReader___Server_SendMixOperation_3670976965(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetMixOperation_3670976965(global::ScheduleOne.Product.NewMixOperation operation, bool complete)
		{
		}

		private void RpcLogic___SetMixOperation_3670976965(global::ScheduleOne.Product.NewMixOperation operation, bool complete)
		{
		}

		private void RpcReader___Observers_SetMixOperation_3670976965(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_FinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		private void RpcLogic___FinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		private void RpcReader___Observers_FinishAndNameMix_4237212381(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendFinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		private void RpcLogic___SendFinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		private void RpcReader___Server_SendFinishAndNameMix_4237212381(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EProduct_002EProductManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
