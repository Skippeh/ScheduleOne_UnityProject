using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.Properties.MixMaps;
using ScheduleOne.StationFramework;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Product
{
	public class ProductManager : NetworkSingleton<ProductManager>, IBaseSaveable, ISaveable
	{
		public const int MIN_PRICE = 1;

		public const int MAX_PRICE = 999;

		public Action<ProductDefinition> onProductDiscovered;

		public static List<ProductDefinition> DiscoveredProducts;

		public static List<ProductDefinition> ListedProducts;

		public static List<ProductDefinition> FavouritedProducts;

		public List<ProductDefinition> AllProducts;

		public List<ProductDefinition> DefaultKnownProducts;

		public List<PropertyItemDefinition> ValidMixIngredients;

		public AnimationCurve SampleSuccessCurve;

		[Header("Default Products")]
		public WeedDefinition DefaultWeed;

		public CocaineDefinition DefaultCocaine;

		public MethDefinition DefaultMeth;

		[Header("Mix Maps")]
		public MixerMap WeedMixMap;

		public MixerMap MethMixMap;

		public MixerMap CokeMixMap;

		private List<ProductDefinition> createdProducts;

		public Action<NewMixOperation> onMixCompleted;

		public Action<ProductDefinition> onNewProductCreated;

		public Action<ProductDefinition> onProductListed;

		public Action<ProductDefinition> onProductDelisted;

		public Action<ProductDefinition> onProductFavourited;

		public Action<ProductDefinition> onProductUnfavourited;

		public UnityEvent onFirstSampleRejection;

		public UnityEvent onSecondUniqueProductCreated;

		public List<string> ProductNames;

		private List<StationRecipe> mixRecipes;

		public Action<StationRecipe> onMixRecipeAdded;

		private Dictionary<ProductDefinition, float> ProductPrices;

		private ProductDefinition highestValueProduct;

		private ProductManagerLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002EProduct_002EProductManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EProduct_002EProductManagerAssembly_002DCSharp_002Edll_Excuted;

		public static bool MethDiscovered => false;

		public static bool CocaineDiscovered => false;

		public static bool IsAcceptingOrders { get; private set; }

		public NewMixOperation CurrentMixOperation { get; private set; }

		public bool IsMixingInProgress => false;

		public bool IsMixComplete { get; private set; }

		public float TimeSinceProductListingChanged { get; private set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

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

		[ServerRpc(RequireOwnership = false)]
		public void SetMethDiscovered()
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void SetCocaineDiscovered()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public MixerMap GetMixerMap(EDrugType type)
		{
			return null;
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		private void OnMinPass()
		{
		}

		private void OnNewDay()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetProductListed(string productID, bool listed)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetProductListed(NetworkConnection conn, string productID, bool listed)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetProductFavourited(string productID, bool listed)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetProductFavourited(NetworkConnection conn, string productID, bool fav)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void DiscoverProduct(string productID)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetProductDiscovered(NetworkConnection conn, string productID, bool autoList)
		{
		}

		public void SetIsAcceptingOrder(bool accepting)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateWeed_Server(string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void CreateWeed(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateCocaine_Server(string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void CreateCocaine(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateMeth_Server(string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		private void CreateMeth(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		private void RefreshHighestValueProduct()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMixRecipe(string product, string mixer, string output)
		{
		}

		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public void CreateMixRecipe(NetworkConnection conn, string product, string mixer, string output)
		{
		}

		public StationRecipe GetRecipe(string product, string mixer)
		{
			return null;
		}

		public StationRecipe GetRecipe(List<ScheduleOne.Properties.Property> productProperties, ScheduleOne.Properties.Property mixerProperty)
		{
			return null;
		}

		[TargetRpc]
		private void GiveItem(NetworkConnection conn, string id)
		{
		}

		public ProductDefinition GetKnownProduct(EDrugType type, List<ScheduleOne.Properties.Property> properties)
		{
			return null;
		}

		public float GetPrice(ProductDefinition product)
		{
			return 0f;
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendPrice(string productID, float value)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetPrice(NetworkConnection conn, string productID, float value)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendMixOperation(NewMixOperation operation, bool complete)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetMixOperation(NewMixOperation operation, bool complete)
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

		[ObserversRpc(RunLocally = true)]
		private void FinishAndNameMix(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void SendFinishAndNameMix(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		public static float CalculateProductValue(ProductDefinition product, float baseValue)
		{
			return 0f;
		}

		public static float CalculateProductValue(float baseValue, List<ScheduleOne.Properties.Property> properties)
		{
			return 0f;
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public virtual List<string> WriteData(string parentFolderPath)
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

		private void RpcReader___Server_SetMethDiscovered_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetCocaineDiscovered_2166136261()
		{
		}

		public void RpcLogic___SetCocaineDiscovered_2166136261()
		{
		}

		private void RpcReader___Server_SetCocaineDiscovered_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetProductListed_310431262(string productID, bool listed)
		{
		}

		public void RpcLogic___SetProductListed_310431262(string productID, bool listed)
		{
		}

		private void RpcReader___Server_SetProductListed_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetProductListed_619441887(NetworkConnection conn, string productID, bool listed)
		{
		}

		public void RpcLogic___SetProductListed_619441887(NetworkConnection conn, string productID, bool listed)
		{
		}

		private void RpcReader___Observers_SetProductListed_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetProductListed_619441887(NetworkConnection conn, string productID, bool listed)
		{
		}

		private void RpcReader___Target_SetProductListed_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetProductFavourited_310431262(string productID, bool listed)
		{
		}

		public void RpcLogic___SetProductFavourited_310431262(string productID, bool listed)
		{
		}

		private void RpcReader___Server_SetProductFavourited_310431262(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetProductFavourited_619441887(NetworkConnection conn, string productID, bool fav)
		{
		}

		public void RpcLogic___SetProductFavourited_619441887(NetworkConnection conn, string productID, bool fav)
		{
		}

		private void RpcReader___Observers_SetProductFavourited_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetProductFavourited_619441887(NetworkConnection conn, string productID, bool fav)
		{
		}

		private void RpcReader___Target_SetProductFavourited_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_DiscoverProduct_3615296227(string productID)
		{
		}

		public void RpcLogic___DiscoverProduct_3615296227(string productID)
		{
		}

		private void RpcReader___Server_DiscoverProduct_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetProductDiscovered_619441887(NetworkConnection conn, string productID, bool autoList)
		{
		}

		public void RpcLogic___SetProductDiscovered_619441887(NetworkConnection conn, string productID, bool autoList)
		{
		}

		private void RpcReader___Observers_SetProductDiscovered_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetProductDiscovered_619441887(NetworkConnection conn, string productID, bool autoList)
		{
		}

		private void RpcReader___Target_SetProductDiscovered_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_CreateWeed_Server_2331775230(string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		public void RpcLogic___CreateWeed_Server_2331775230(string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		private void RpcReader___Server_CreateWeed_Server_2331775230(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_CreateWeed_1777266891(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		private void RpcLogic___CreateWeed_1777266891(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		private void RpcReader___Target_CreateWeed_1777266891(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_CreateWeed_1777266891(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, WeedAppearanceSettings appearance)
		{
		}

		private void RpcReader___Observers_CreateWeed_1777266891(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_CreateCocaine_Server_891166717(string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		public void RpcLogic___CreateCocaine_Server_891166717(string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		private void RpcReader___Server_CreateCocaine_Server_891166717(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_CreateCocaine_1327282946(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		private void RpcLogic___CreateCocaine_1327282946(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		private void RpcReader___Target_CreateCocaine_1327282946(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_CreateCocaine_1327282946(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, CocaineAppearanceSettings appearance)
		{
		}

		private void RpcReader___Observers_CreateCocaine_1327282946(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_CreateMeth_Server_4251728555(string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		public void RpcLogic___CreateMeth_Server_4251728555(string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		private void RpcReader___Server_CreateMeth_Server_4251728555(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_CreateMeth_1869045686(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		private void RpcLogic___CreateMeth_1869045686(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		private void RpcReader___Target_CreateMeth_1869045686(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_CreateMeth_1869045686(NetworkConnection conn, string name, string id, EDrugType type, List<string> properties, MethAppearanceSettings appearance)
		{
		}

		private void RpcReader___Observers_CreateMeth_1869045686(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendMixRecipe_852232071(string product, string mixer, string output)
		{
		}

		public void RpcLogic___SendMixRecipe_852232071(string product, string mixer, string output)
		{
		}

		private void RpcReader___Server_SendMixRecipe_852232071(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_CreateMixRecipe_1410895574(NetworkConnection conn, string product, string mixer, string output)
		{
		}

		public void RpcLogic___CreateMixRecipe_1410895574(NetworkConnection conn, string product, string mixer, string output)
		{
		}

		private void RpcReader___Target_CreateMixRecipe_1410895574(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_CreateMixRecipe_1410895574(NetworkConnection conn, string product, string mixer, string output)
		{
		}

		private void RpcReader___Observers_CreateMixRecipe_1410895574(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_GiveItem_2971853958(NetworkConnection conn, string id)
		{
		}

		private void RpcLogic___GiveItem_2971853958(NetworkConnection conn, string id)
		{
		}

		private void RpcReader___Target_GiveItem_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendPrice_606697822(string productID, float value)
		{
		}

		public void RpcLogic___SendPrice_606697822(string productID, float value)
		{
		}

		private void RpcReader___Server_SendPrice_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetPrice_4077118173(NetworkConnection conn, string productID, float value)
		{
		}

		public void RpcLogic___SetPrice_4077118173(NetworkConnection conn, string productID, float value)
		{
		}

		private void RpcReader___Observers_SetPrice_4077118173(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetPrice_4077118173(NetworkConnection conn, string productID, float value)
		{
		}

		private void RpcReader___Target_SetPrice_4077118173(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
		}

		public void RpcLogic___SendMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
		}

		private void RpcReader___Server_SendMixOperation_3670976965(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
		}

		private void RpcLogic___SetMixOperation_3670976965(NewMixOperation operation, bool complete)
		{
		}

		private void RpcReader___Observers_SetMixOperation_3670976965(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_FinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		private void RpcLogic___FinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		private void RpcReader___Observers_FinishAndNameMix_4237212381(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendFinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		private void RpcLogic___SendFinishAndNameMix_4237212381(string productID, string ingredientID, string mixName, string mixID)
		{
		}

		private void RpcReader___Server_SendFinishAndNameMix_4237212381(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EProduct_002EProductManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
