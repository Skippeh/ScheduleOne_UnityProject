using System;
using System.Collections.Generic;
using EPOOutline;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.AvatarFramework.Equipping;
using ScheduleOne.Combat;
using ScheduleOne.Dialogue;
using ScheduleOne.Doors;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.Map;
using ScheduleOne.Messaging;
using ScheduleOne.NPCs.Actions;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.NPCs.Relation;
using ScheduleOne.NPCs.Responses;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using ScheduleOne.PlayerScripts;
using ScheduleOne.Vehicles;
using ScheduleOne.VoiceOver;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	[RequireComponent(typeof(NPCHealth))]
	public class NPC : NetworkBehaviour, IGUIDRegisterable, ISaveable, IDamageable
	{
		public const float PANIC_DURATION = 20f;

		public const bool RequiresRegionUnlocked = true;

		[Header("Info Settings")]
		public string FirstName;

		public bool hasLastName;

		public string LastName;

		public string ID;

		public bool AutoGenerateMugshot;

		public Sprite MugshotSprite;

		public EMapRegion Region;

		[Header("If true, NPC will respawn next day instead of waiting 3 days.")]
		public bool IsImportant;

		[Header("Personality")]
		[Range(0f, 1f)]
		public float Aggression;

		[Header("References")]
		[SerializeField]
		protected Transform modelContainer;

		[SerializeField]
		protected NPCMovement movement;

		[SerializeField]
		protected InteractableObject intObj;

		public DialogueHandler dialogueHandler;

		public ScheduleOne.AvatarFramework.Avatar Avatar;

		public NPCAwareness awareness;

		public NPCResponses responses;

		public NPCActions actions;

		public NPCBehaviour behaviour;

		public VOEmitter VoiceOverEmitter;

		public NPCHealth Health;

		public Action<LandVehicle> onEnterVehicle;

		public Action<LandVehicle> onExitVehicle;

		[Header("Summoning")]
		public bool CanBeSummoned;

		[Header("Relationship")]
		public NPCRelationData RelationData;

		public string NPCUnlockedVariable;

		public bool ShowRelationshipInfo;

		[Header("Messaging")]
		public List<EConversationCategory> ConversationCategories;

		public bool ConversationCanBeHidden;

		public Action onConversationCreated;

		[Header("Other Settings")]
		public bool CanOpenDoors;

		[SerializeField]
		protected List<GameObject> OutlineRenderers;

		protected Outlinable OutlineEffect;

		[Header("GUID")]
		public string BakedGUID;

		public Action<bool> onVisibilityChanged;

		[HideInInspector]
		[SyncVar]
		public NetworkObject PlayerConversant;

		private Coroutine resetUnsettledCoroutine;

		private List<int> impactHistory;

		private int headlightStartTime;

		private int heaedLightsEndTime;

		protected float defaultAggression;

		private Coroutine lerpScaleRoutine;

		public SyncVar<NetworkObject> syncVar___PlayerConversant;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ENPCAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ENPCAssembly_002DCSharp_002Edll_Excuted;

		public string fullName => null;

		public float Scale { get; private set; }

		public bool IsConscious => false;

		public NPCMovement Movement => null;

		public NPCInventory Inventory { get; protected set; }

		public LandVehicle CurrentVehicle { get; protected set; }

		public bool IsInVehicle => false;

		public bool isInBuilding => false;

		public NPCEnterableBuilding CurrentBuilding { get; protected set; }

		public StaticDoor LastEnteredDoor { get; set; }

		public MSGConversation MSGConversation { get; protected set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public Guid GUID { get; protected set; }

		public bool isVisible { get; protected set; }

		public bool isUnsettled { get; protected set; }

		public bool IsPanicked => false;

		public float timeSincePanicked { get; protected set; }

		public NetworkObject SyncAccessor_PlayerConversant
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public void SetGUID(Guid guid)
		{
		}

		private void PlayerSpawned()
		{
		}

		public override void OnStartClient()
		{
		}

		protected virtual void CreateMessageConversation()
		{
		}

		public void SendTextMessage(string message)
		{
		}

		protected override void OnValidate()
		{
		}

		private void GetHealth()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		[ObserversRpc]
		private void SetTransform(NetworkConnection conn, Vector3 position, Quaternion rotation)
		{
		}

		protected virtual void MinPass()
		{
		}

		protected virtual void Update()
		{
		}

		public virtual void SetVisible(bool visible)
		{
		}

		public void SetScale(float scale)
		{
		}

		public void SetScale(float scale, float lerpTime)
		{
		}

		protected virtual void ApplyScale()
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public virtual void AimedAtByPlayer(NetworkObject player)
		{
		}

		public void OverrideAggression(float aggression)
		{
		}

		public void ResetAggression()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public virtual void SendImpact(Impact impact)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public virtual void ReceiveImpact(Impact impact)
		{
		}

		public virtual void ProcessImpactForce(Vector3 forcePoint, Vector3 forceDirection, float force)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public virtual void EnterVehicle(NetworkConnection connection, LandVehicle veh)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public virtual void ExitVehicle()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendWorldspaceDialogueKey(string key, float duration)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void PlayWorldspaceDialogue(string key, float duration)
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConversant(NetworkObject player)
		{
		}

		private void Hovered_Internal()
		{
		}

		private void Interacted_Internal()
		{
		}

		protected virtual void Hovered()
		{
		}

		protected virtual void Interacted()
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void EnterBuilding(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void ExitBuilding(string buildingID = "")
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetEquippable_Networked(NetworkConnection conn, string assetPath)
		{
		}

		public AvatarEquippable SetEquippable_Networked_Return(NetworkConnection conn, string assetPath)
		{
			return null;
		}

		public AvatarEquippable SetEquippable_Return(string assetPath)
		{
			return null;
		}

		[ObserversRpc(RunLocally = false, ExcludeServer = true)]
		private void SetEquippable_Networked_ExcludeServer(NetworkConnection conn, string assetPath)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SendEquippableMessage_Networked(NetworkConnection conn, string message)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SendEquippableMessage_Networked_Vector(NetworkConnection conn, string message, Vector3 data)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void SendAnimationTrigger(string trigger)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
		}

		public void SetAnimationTrigger(string trigger)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void ResetAnimationTrigger_Networked(NetworkConnection conn, string trigger)
		{
		}

		public void ResetAnimationTrigger(string trigger)
		{
		}

		[ObserversRpc(RunLocally = true)]
		public void SetCrouched_Networked(bool crouched)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		public void SetAnimationBool_Networked(NetworkConnection conn, string id, bool value)
		{
		}

		public void SetAnimationBool(string trigger, bool val)
		{
		}

		protected virtual bool ShouldNoticeGeneralCrime(Player player)
		{
			return false;
		}

		protected virtual void SetUnsettled_30s(Player player)
		{
		}

		protected void SetUnsettled(float duration)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void SetPanicked()
		{
		}

		[ObserversRpc]
		private void ReceivePanicked()
		{
		}

		[ObserversRpc]
		private void RemovePanicked()
		{
		}

		public virtual string GetNameAddress()
		{
			return null;
		}

		public void PlayVO(EVOLineType lineType)
		{
		}

		[TargetRpc]
		public void ReceiveRelationshipData(NetworkConnection conn, float relationship, bool unlocked)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void SetIsBeingPickPocketed(bool pickpocketed)
		{
		}

		[ServerRpc(RequireOwnership = false)]
		public void SendRelationship(float relationship)
		{
		}

		[ObserversRpc]
		private void SetRelationship(float relationship)
		{
		}

		public void ShowOutline(Color color)
		{
		}

		public void ShowOutline(BuildableItem.EOutlineColor color)
		{
		}

		public void HideOutline()
		{
		}

		public virtual bool ShouldSave()
		{
			return false;
		}

		protected virtual bool ShouldSaveRelationshipData()
		{
			return false;
		}

		protected virtual bool ShouldSaveMessages()
		{
			return false;
		}

		protected virtual bool ShouldSaveInventory()
		{
			return false;
		}

		protected virtual bool ShouldSaveHealth()
		{
			return false;
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		public virtual void Load(NPCData data, string containerPath)
		{
		}

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Observers_SetTransform_4260003484(NetworkConnection conn, Vector3 position, Quaternion rotation)
		{
		}

		private void RpcLogic___SetTransform_4260003484(NetworkConnection conn, Vector3 position, Quaternion rotation)
		{
		}

		private void RpcReader___Observers_SetTransform_4260003484(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_AimedAtByPlayer_3323014238(NetworkObject player)
		{
		}

		public virtual void RpcLogic___AimedAtByPlayer_3323014238(NetworkObject player)
		{
		}

		private void RpcReader___Server_AimedAtByPlayer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendImpact_427288424(Impact impact)
		{
		}

		public virtual void RpcLogic___SendImpact_427288424(Impact impact)
		{
		}

		private void RpcReader___Server_SendImpact_427288424(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveImpact_427288424(Impact impact)
		{
		}

		public virtual void RpcLogic___ReceiveImpact_427288424(Impact impact)
		{
		}

		private void RpcReader___Observers_ReceiveImpact_427288424(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_EnterVehicle_3321926803(NetworkConnection connection, LandVehicle veh)
		{
		}

		public virtual void RpcLogic___EnterVehicle_3321926803(NetworkConnection connection, LandVehicle veh)
		{
		}

		private void RpcReader___Observers_EnterVehicle_3321926803(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_EnterVehicle_3321926803(NetworkConnection connection, LandVehicle veh)
		{
		}

		private void RpcReader___Target_EnterVehicle_3321926803(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_ExitVehicle_2166136261()
		{
		}

		public virtual void RpcLogic___ExitVehicle_2166136261()
		{
		}

		private void RpcReader___Observers_ExitVehicle_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendWorldspaceDialogueKey_606697822(string key, float duration)
		{
		}

		public void RpcLogic___SendWorldspaceDialogueKey_606697822(string key, float duration)
		{
		}

		private void RpcReader___Server_SendWorldspaceDialogueKey_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_PlayWorldspaceDialogue_606697822(string key, float duration)
		{
		}

		private void RpcLogic___PlayWorldspaceDialogue_606697822(string key, float duration)
		{
		}

		private void RpcReader___Observers_PlayWorldspaceDialogue_606697822(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetConversant_3323014238(NetworkObject player)
		{
		}

		public void RpcLogic___SetConversant_3323014238(NetworkObject player)
		{
		}

		private void RpcReader___Server_SetConversant_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_EnterBuilding_3905681115(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		public void RpcLogic___EnterBuilding_3905681115(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		private void RpcReader___Observers_EnterBuilding_3905681115(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_EnterBuilding_3905681115(NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		private void RpcReader___Target_EnterBuilding_3905681115(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_ExitBuilding_3615296227(string buildingID = "")
		{
		}

		public void RpcLogic___ExitBuilding_3615296227(string buildingID = "")
		{
		}

		private void RpcReader___Observers_ExitBuilding_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetEquippable_Networked_2971853958(NetworkConnection conn, string assetPath)
		{
		}

		public void RpcLogic___SetEquippable_Networked_2971853958(NetworkConnection conn, string assetPath)
		{
		}

		private void RpcReader___Observers_SetEquippable_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetEquippable_Networked_2971853958(NetworkConnection conn, string assetPath)
		{
		}

		private void RpcReader___Target_SetEquippable_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetEquippable_Networked_ExcludeServer_2971853958(NetworkConnection conn, string assetPath)
		{
		}

		private void RpcLogic___SetEquippable_Networked_ExcludeServer_2971853958(NetworkConnection conn, string assetPath)
		{
		}

		private void RpcReader___Observers_SetEquippable_Networked_ExcludeServer_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SendEquippableMessage_Networked_2971853958(NetworkConnection conn, string message)
		{
		}

		public void RpcLogic___SendEquippableMessage_Networked_2971853958(NetworkConnection conn, string message)
		{
		}

		private void RpcReader___Observers_SendEquippableMessage_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SendEquippableMessage_Networked_2971853958(NetworkConnection conn, string message)
		{
		}

		private void RpcReader___Target_SendEquippableMessage_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SendEquippableMessage_Networked_Vector_4022222929(NetworkConnection conn, string message, Vector3 data)
		{
		}

		public void RpcLogic___SendEquippableMessage_Networked_Vector_4022222929(NetworkConnection conn, string message, Vector3 data)
		{
		}

		private void RpcReader___Observers_SendEquippableMessage_Networked_Vector_4022222929(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SendEquippableMessage_Networked_Vector_4022222929(NetworkConnection conn, string message, Vector3 data)
		{
		}

		private void RpcReader___Target_SendEquippableMessage_Networked_Vector_4022222929(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendAnimationTrigger_3615296227(string trigger)
		{
		}

		public void RpcLogic___SendAnimationTrigger_3615296227(string trigger)
		{
		}

		private void RpcReader___Server_SendAnimationTrigger_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		public void RpcLogic___SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		private void RpcReader___Observers_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		private void RpcReader___Target_SetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		public void RpcLogic___ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		private void RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958(NetworkConnection conn, string trigger)
		{
		}

		private void RpcReader___Target_ResetAnimationTrigger_Networked_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetCrouched_Networked_1140765316(bool crouched)
		{
		}

		public void RpcLogic___SetCrouched_Networked_1140765316(bool crouched)
		{
		}

		private void RpcReader___Observers_SetCrouched_Networked_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetAnimationBool_Networked_619441887(NetworkConnection conn, string id, bool value)
		{
		}

		public void RpcLogic___SetAnimationBool_Networked_619441887(NetworkConnection conn, string id, bool value)
		{
		}

		private void RpcReader___Observers_SetAnimationBool_Networked_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetAnimationBool_Networked_619441887(NetworkConnection conn, string id, bool value)
		{
		}

		private void RpcReader___Target_SetAnimationBool_Networked_619441887(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetPanicked_2166136261()
		{
		}

		public void RpcLogic___SetPanicked_2166136261()
		{
		}

		private void RpcReader___Server_SetPanicked_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceivePanicked_2166136261()
		{
		}

		private void RpcLogic___ReceivePanicked_2166136261()
		{
		}

		private void RpcReader___Observers_ReceivePanicked_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_RemovePanicked_2166136261()
		{
		}

		private void RpcLogic___RemovePanicked_2166136261()
		{
		}

		private void RpcReader___Observers_RemovePanicked_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveRelationshipData_4052192084(NetworkConnection conn, float relationship, bool unlocked)
		{
		}

		public void RpcLogic___ReceiveRelationshipData_4052192084(NetworkConnection conn, float relationship, bool unlocked)
		{
		}

		private void RpcReader___Target_ReceiveRelationshipData_4052192084(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetIsBeingPickPocketed_1140765316(bool pickpocketed)
		{
		}

		public void RpcLogic___SetIsBeingPickPocketed_1140765316(bool pickpocketed)
		{
		}

		private void RpcReader___Server_SetIsBeingPickPocketed_1140765316(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendRelationship_431000436(float relationship)
		{
		}

		public void RpcLogic___SendRelationship_431000436(float relationship)
		{
		}

		private void RpcReader___Server_SendRelationship_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetRelationship_431000436(float relationship)
		{
		}

		private void RpcLogic___SetRelationship_431000436(float relationship)
		{
		}

		private void RpcReader___Observers_SetRelationship_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002ENPCs_002ENPC(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ENPC_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
