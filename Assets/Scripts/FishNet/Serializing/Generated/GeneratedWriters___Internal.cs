using System.Collections.Generic;
using System.Runtime.InteropServices;
using FishNet.Object;
using ScheduleOne.AvatarFramework;
using ScheduleOne.AvatarFramework.Customization;
using ScheduleOne.Casino;
using ScheduleOne.Combat;
using ScheduleOne.Delivery;
using ScheduleOne.DevUtilities;
using ScheduleOne.Doors;
using ScheduleOne.Economy;
using ScheduleOne.Employees;
using ScheduleOne.GameTime;
using ScheduleOne.ItemFramework;
using ScheduleOne.Law;
using ScheduleOne.Levelling;
using ScheduleOne.Management;
using ScheduleOne.Messaging;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Product;
using ScheduleOne.Property;
using ScheduleOne.Quests;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Handover;
using ScheduleOne.UI.Phone.Messages;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.Modification;
using ScheduleOne.Vision;
using UnityEngine;

namespace FishNet.Serializing.Generated
{
	[StructLayout(LayoutKind.Auto, CharSet = CharSet.Auto)]
	public static class GeneratedWriters___Internal
	{
		[RuntimeInitializeOnLoadMethod]
		private static void InitializeOnce()
		{
		}

		public static void Write___ScheduleOne_002EVision_002EVisionEventReceiptFishNet_002ESerializing_002EGenerated(this Writer writer, VisionEventReceipt value)
		{
		}

		public static void Write___ScheduleOne_002EPlayerScripts_002EPlayerVisualState_002FEVisualStateFishNet_002ESerializing_002EGenerated(this Writer writer, PlayerVisualState.EVisualState value)
		{
		}

		public static void Write___ScheduleOne_002EVision_002EVisionCone_002FEEventLevelFishNet_002ESerializing_002EGenerated(this Writer writer, VisionCone.EEventLevel value)
		{
		}

		public static void Write___ScheduleOne_002EQuests_002EContractInfoFishNet_002ESerializing_002EGenerated(this Writer writer, ContractInfo value)
		{
		}

		public static void Write___ScheduleOne_002EProduct_002EProductListFishNet_002ESerializing_002EGenerated(this Writer writer, ProductList value)
		{
		}

		public static void Write___ScheduleOne_002EProduct_002EProductList_002FEntryFishNet_002ESerializing_002EGenerated(this Writer writer, ProductList.Entry value)
		{
		}

		public static void Write___ScheduleOne_002EItemFramework_002EEQualityFishNet_002ESerializing_002EGenerated(this Writer writer, EQuality value)
		{
		}

		public static void Write___System_002ECollections_002EGeneric_002EList_00601_003CScheduleOne_002EProduct_002EProductList_002FEntry_003EFishNet_002ESerializing_002EGenerated(this Writer writer, List<ProductList.Entry> value)
		{
		}

		public static void Write___ScheduleOne_002EQuests_002EQuestWindowConfigFishNet_002ESerializing_002EGenerated(this Writer writer, QuestWindowConfig value)
		{
		}

		public static void Write___ScheduleOne_002EGameTime_002EGameDateTimeFishNet_002ESerializing_002EGenerated(this Writer writer, GameDateTime value)
		{
		}

		public static void Write___ScheduleOne_002EQuests_002EQuestManager_002FEQuestActionFishNet_002ESerializing_002EGenerated(this Writer writer, QuestManager.EQuestAction value)
		{
		}

		public static void Write___ScheduleOne_002EQuests_002EEQuestStateFishNet_002ESerializing_002EGenerated(this Writer writer, EQuestState value)
		{
		}

		public static void Write___ScheduleOne_002ECombat_002EImpactFishNet_002ESerializing_002EGenerated(this Writer writer, Impact value)
		{
		}

		public static void Write___ScheduleOne_002ECombat_002EEImpactTypeFishNet_002ESerializing_002EGenerated(this Writer writer, EImpactType value)
		{
		}

		public static void Write___ScheduleOne_002EVehicles_002ELandVehicleFishNet_002ESerializing_002EGenerated(this Writer writer, LandVehicle value)
		{
		}

		public static void Write___ScheduleOne_002ELaw_002ECheckpointManager_002FECheckpointLocationFishNet_002ESerializing_002EGenerated(this Writer writer, CheckpointManager.ECheckpointLocation value)
		{
		}

		public static void Write___ScheduleOne_002EPlayerScripts_002EPlayerFishNet_002ESerializing_002EGenerated(this Writer writer, Player value)
		{
		}

		public static void Write___System_002ECollections_002EGeneric_002EList_00601_003CSystem_002EString_003EFishNet_002ESerializing_002EGenerated(this Writer writer, List<string> value)
		{
		}

		public static void Write___ScheduleOne_002EDevUtilities_002EStringIntPairFishNet_002ESerializing_002EGenerated(this Writer writer, StringIntPair value)
		{
		}

		public static void Write___ScheduleOne_002EDevUtilities_002EStringIntPair_005B_005DFishNet_002ESerializing_002EGenerated(this Writer writer, StringIntPair[] value)
		{
		}

		public static void Write___ScheduleOne_002EMessaging_002EMessageFishNet_002ESerializing_002EGenerated(this Writer writer, Message value)
		{
		}

		public static void Write___ScheduleOne_002EMessaging_002EMessage_002FESenderTypeFishNet_002ESerializing_002EGenerated(this Writer writer, Message.ESenderType value)
		{
		}

		public static void Write___ScheduleOne_002EUI_002EPhone_002EMessages_002EMessageChainFishNet_002ESerializing_002EGenerated(this Writer writer, MessageChain value)
		{
		}

		public static void Write___ScheduleOne_002EPersistence_002EDatas_002EMSGConversationDataFishNet_002ESerializing_002EGenerated(this Writer writer, MSGConversationData value)
		{
		}

		public static void Write___ScheduleOne_002EPersistence_002EDatas_002ETextMessageDataFishNet_002ESerializing_002EGenerated(this Writer writer, TextMessageData value)
		{
		}

		public static void Write___ScheduleOne_002EPersistence_002EDatas_002ETextMessageData_005B_005DFishNet_002ESerializing_002EGenerated(this Writer writer, TextMessageData[] value)
		{
		}

		public static void Write___ScheduleOne_002EPersistence_002EDatas_002ETextResponseDataFishNet_002ESerializing_002EGenerated(this Writer writer, TextResponseData value)
		{
		}

		public static void Write___ScheduleOne_002EPersistence_002EDatas_002ETextResponseData_005B_005DFishNet_002ESerializing_002EGenerated(this Writer writer, TextResponseData[] value)
		{
		}

		public static void Write___ScheduleOne_002EMessaging_002EResponseFishNet_002ESerializing_002EGenerated(this Writer writer, Response value)
		{
		}

		public static void Write___System_002ECollections_002EGeneric_002EList_00601_003CScheduleOne_002EMessaging_002EResponse_003EFishNet_002ESerializing_002EGenerated(this Writer writer, List<Response> value)
		{
		}

		public static void Write___System_002ECollections_002EGeneric_002EList_00601_003CFishNet_002EObject_002ENetworkObject_003EFishNet_002ESerializing_002EGenerated(this Writer writer, List<NetworkObject> value)
		{
		}

		public static void Write___ScheduleOne_002EPersistence_002EDatas_002EAdvancedTransitRouteDataFishNet_002ESerializing_002EGenerated(this Writer writer, AdvancedTransitRouteData value)
		{
		}

		public static void Write___ScheduleOne_002EManagement_002EManagementItemFilter_002FEModeFishNet_002ESerializing_002EGenerated(this Writer writer, ManagementItemFilter.EMode value)
		{
		}

		public static void Write___ScheduleOne_002EPersistence_002EDatas_002EAdvancedTransitRouteData_005B_005DFishNet_002ESerializing_002EGenerated(this Writer writer, AdvancedTransitRouteData[] value)
		{
		}

		public static void Write___ScheduleOne_002ELevelling_002EERankFishNet_002ESerializing_002EGenerated(this Writer writer, ERank value)
		{
		}

		public static void Write___ScheduleOne_002ELevelling_002EFullRankFishNet_002ESerializing_002EGenerated(this Writer writer, FullRank value)
		{
		}

		public static void Write___ScheduleOne_002EPersistence_002EDatas_002EPlayerDataFishNet_002ESerializing_002EGenerated(this Writer writer, PlayerData value)
		{
		}

		public static void Write___ScheduleOne_002EPersistence_002EDatas_002EVariableDataFishNet_002ESerializing_002EGenerated(this Writer writer, VariableData value)
		{
		}

		public static void Write___ScheduleOne_002EPersistence_002EDatas_002EVariableData_005B_005DFishNet_002ESerializing_002EGenerated(this Writer writer, VariableData[] value)
		{
		}

		public static void Write___ScheduleOne_002EAvatarFramework_002EAvatarSettingsFishNet_002ESerializing_002EGenerated(this Writer writer, AvatarSettings value)
		{
		}

		public static void Write___ScheduleOne_002EAvatarFramework_002EEye_002FEyeLidConfigurationFishNet_002ESerializing_002EGenerated(this Writer writer, Eye.EyeLidConfiguration value)
		{
		}

		public static void Write___ScheduleOne_002EAvatarFramework_002EAvatarSettings_002FLayerSettingFishNet_002ESerializing_002EGenerated(this Writer writer, AvatarSettings.LayerSetting value)
		{
		}

		public static void Write___System_002ECollections_002EGeneric_002EList_00601_003CScheduleOne_002EAvatarFramework_002EAvatarSettings_002FLayerSetting_003EFishNet_002ESerializing_002EGenerated(this Writer writer, List<AvatarSettings.LayerSetting> value)
		{
		}

		public static void Write___ScheduleOne_002EAvatarFramework_002EAvatarSettings_002FAccessorySettingFishNet_002ESerializing_002EGenerated(this Writer writer, AvatarSettings.AccessorySetting value)
		{
		}

		public static void Write___System_002ECollections_002EGeneric_002EList_00601_003CScheduleOne_002EAvatarFramework_002EAvatarSettings_002FAccessorySetting_003EFishNet_002ESerializing_002EGenerated(this Writer writer, List<AvatarSettings.AccessorySetting> value)
		{
		}

		public static void Write___ScheduleOne_002EAvatarFramework_002ECustomization_002EBasicAvatarSettingsFishNet_002ESerializing_002EGenerated(this Writer writer, BasicAvatarSettings value)
		{
		}

		public static void Write___ScheduleOne_002EPlayerScripts_002EPlayerCrimeData_002FEPursuitLevelFishNet_002ESerializing_002EGenerated(this Writer writer, PlayerCrimeData.EPursuitLevel value)
		{
		}

		public static void Write___ScheduleOne_002EProperty_002EPropertyFishNet_002ESerializing_002EGenerated(this Writer writer, Property value)
		{
		}

		public static void Write___ScheduleOne_002EEmployees_002EEEmployeeTypeFishNet_002ESerializing_002EGenerated(this Writer writer, EEmployeeType value)
		{
		}

		public static void Write___ScheduleOne_002EEconomy_002EEDealWindowFishNet_002ESerializing_002EGenerated(this Writer writer, EDealWindow value)
		{
		}

		public static void Write___ScheduleOne_002EUI_002EHandover_002EHandoverScreen_002FEHandoverOutcomeFishNet_002ESerializing_002EGenerated(this Writer writer, HandoverScreen.EHandoverOutcome value)
		{
		}

		public static void Write___System_002ECollections_002EGeneric_002EList_00601_003CScheduleOne_002EItemFramework_002EItemInstance_003EFishNet_002ESerializing_002EGenerated(this Writer writer, List<ItemInstance> value)
		{
		}

		public static void Write___ScheduleOne_002EPersistence_002EDatas_002ECustomerDataFishNet_002ESerializing_002EGenerated(this Writer writer, ScheduleOne.Persistence.Datas.CustomerData value)
		{
		}

		public static void Write___System_002EString_005B_005DFishNet_002ESerializing_002EGenerated(this Writer writer, string[] value)
		{
		}

		public static void Write___System_002ESingle_005B_005DFishNet_002ESerializing_002EGenerated(this Writer writer, float[] value)
		{
		}

		public static void Write___ScheduleOne_002EProduct_002EEDrugTypeFishNet_002ESerializing_002EGenerated(this Writer writer, EDrugType value)
		{
		}

		public static void Write___ScheduleOne_002EPersistence_002EDatas_002EGameDataFishNet_002ESerializing_002EGenerated(this Writer writer, GameData value)
		{
		}

		public static void Write___ScheduleOne_002EDevUtilities_002EGameSettingsFishNet_002ESerializing_002EGenerated(this Writer writer, GameSettings value)
		{
		}

		public static void Write___ScheduleOne_002EDelivery_002EDeliveryInstanceFishNet_002ESerializing_002EGenerated(this Writer writer, DeliveryInstance value)
		{
		}

		public static void Write___ScheduleOne_002EDelivery_002EEDeliveryStatusFishNet_002ESerializing_002EGenerated(this Writer writer, EDeliveryStatus value)
		{
		}

		public static void Write___ScheduleOne_002ECombat_002EExplosionDataFishNet_002ESerializing_002EGenerated(this Writer writer, ExplosionData value)
		{
		}

		public static void Write___ScheduleOne_002ECasino_002EPlayingCard_002FECardSuitFishNet_002ESerializing_002EGenerated(this Writer writer, PlayingCard.ECardSuit value)
		{
		}

		public static void Write___ScheduleOne_002ECasino_002EPlayingCard_002FECardValueFishNet_002ESerializing_002EGenerated(this Writer writer, PlayingCard.ECardValue value)
		{
		}

		public static void Write___FishNet_002EObject_002ENetworkObject_005B_005DFishNet_002ESerializing_002EGenerated(this Writer writer, NetworkObject[] value)
		{
		}

		public static void Write___ScheduleOne_002ECasino_002ERTBGameController_002FEStageFishNet_002ESerializing_002EGenerated(this Writer writer, RTBGameController.EStage value)
		{
		}

		public static void Write___ScheduleOne_002ECasino_002ESlotMachine_002FESymbolFishNet_002ESerializing_002EGenerated(this Writer writer, SlotMachine.ESymbol value)
		{
		}

		public static void Write___ScheduleOne_002ECasino_002ESlotMachine_002FESymbol_005B_005DFishNet_002ESerializing_002EGenerated(this Writer writer, SlotMachine.ESymbol[] value)
		{
		}

		public static void Write___ScheduleOne_002EDoors_002EEDoorSideFishNet_002ESerializing_002EGenerated(this Writer writer, EDoorSide value)
		{
		}

		public static void Write___ScheduleOne_002EVehicles_002EModification_002EEVehicleColorFishNet_002ESerializing_002EGenerated(this Writer writer, EVehicleColor value)
		{
		}

		public static void Write___ScheduleOne_002EVehicles_002EParkDataFishNet_002ESerializing_002EGenerated(this Writer writer, ParkData value)
		{
		}

		public static void Write___ScheduleOne_002EVehicles_002EEParkingAlignmentFishNet_002ESerializing_002EGenerated(this Writer writer, EParkingAlignment value)
		{
		}

		public static void Write___ScheduleOne_002EPersistence_002ETrashContentDataFishNet_002ESerializing_002EGenerated(this Writer writer, TrashContentData value)
		{
		}

		public static void Write___System_002EInt32_005B_005DFishNet_002ESerializing_002EGenerated(this Writer writer, int[] value)
		{
		}

		public static void Write___ScheduleOne_002ETiles_002ECoordinateFishNet_002ESerializing_002EGenerated(this Writer writer, Coordinate value)
		{
		}

		public static void Write___ScheduleOne_002EProduct_002EWeedAppearanceSettingsFishNet_002ESerializing_002EGenerated(this Writer writer, WeedAppearanceSettings value)
		{
		}

		public static void Write___ScheduleOne_002EProduct_002ECocaineAppearanceSettingsFishNet_002ESerializing_002EGenerated(this Writer writer, CocaineAppearanceSettings value)
		{
		}

		public static void Write___ScheduleOne_002EProduct_002EMethAppearanceSettingsFishNet_002ESerializing_002EGenerated(this Writer writer, MethAppearanceSettings value)
		{
		}

		public static void Write___ScheduleOne_002EProduct_002ENewMixOperationFishNet_002ESerializing_002EGenerated(this Writer writer, NewMixOperation value)
		{
		}

		public static void Write___ScheduleOne_002EObjectScripts_002ERecycler_002FEStateFishNet_002ESerializing_002EGenerated(this Writer writer, Recycler.EState value)
		{
		}

		public static void Write___ScheduleOne_002ETiles_002ECoordinateProceduralTilePairFishNet_002ESerializing_002EGenerated(this Writer writer, CoordinateProceduralTilePair value)
		{
		}

		public static void Write___System_002ECollections_002EGeneric_002EList_00601_003CScheduleOne_002ETiles_002ECoordinateProceduralTilePair_003EFishNet_002ESerializing_002EGenerated(this Writer writer, List<CoordinateProceduralTilePair> value)
		{
		}

		public static void Write___ScheduleOne_002EObjectScripts_002EChemistryCookOperationFishNet_002ESerializing_002EGenerated(this Writer writer, ChemistryCookOperation value)
		{
		}

		public static void Write___ScheduleOne_002EObjectScripts_002EDryingOperationFishNet_002ESerializing_002EGenerated(this Writer writer, DryingOperation value)
		{
		}

		public static void Write___ScheduleOne_002EObjectScripts_002EOvenCookOperationFishNet_002ESerializing_002EGenerated(this Writer writer, OvenCookOperation value)
		{
		}

		public static void Write___ScheduleOne_002EObjectScripts_002EMixOperationFishNet_002ESerializing_002EGenerated(this Writer writer, MixOperation value)
		{
		}
	}
}
