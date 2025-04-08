namespace ScheduleOne.NPCs
{
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.NPCs.NPCHealth))]
	public class NPC : global::FishNet.Object.NetworkBehaviour, global::ScheduleOne.IGUIDRegisterable, global::ScheduleOne.Persistence.ISaveable, global::ScheduleOne.Combat.IDamageable
	{
		public const float PANIC_DURATION = 20f;

		public const bool RequiresRegionUnlocked = true;

		[global::UnityEngine.Header("Info Settings")]
		public string FirstName;

		public bool hasLastName;

		public string LastName;

		public string ID;

		public bool AutoGenerateMugshot;

		public global::UnityEngine.Sprite MugshotSprite;

		public global::ScheduleOne.Map.EMapRegion Region;

		[global::UnityEngine.Header("If true, NPC will respawn next day instead of waiting 3 days.")]
		public bool IsImportant;

		[global::UnityEngine.Header("Personality")]
		[global::UnityEngine.Range(0f, 1f)]
		public float Aggression;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform modelContainer;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.NPCs.NPCMovement movement;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Interaction.InteractableObject intObj;

		public global::ScheduleOne.Dialogue.DialogueHandler dialogueHandler;

		public global::ScheduleOne.AvatarFramework.Avatar Avatar;

		public global::ScheduleOne.NPCs.NPCAwareness awareness;

		public global::ScheduleOne.NPCs.Responses.NPCResponses responses;

		public global::ScheduleOne.NPCs.Actions.NPCActions actions;

		public global::ScheduleOne.NPCs.Behaviour.NPCBehaviour behaviour;

		public global::ScheduleOne.VoiceOver.VOEmitter VoiceOverEmitter;

		public global::ScheduleOne.NPCs.NPCHealth Health;

		public global::System.Action<global::ScheduleOne.Vehicles.LandVehicle> onEnterVehicle;

		public global::System.Action<global::ScheduleOne.Vehicles.LandVehicle> onExitVehicle;

		[global::UnityEngine.Header("Summoning")]
		public bool CanBeSummoned;

		[global::UnityEngine.Header("Relationship")]
		public global::ScheduleOne.NPCs.Relation.NPCRelationData RelationData;

		public string NPCUnlockedVariable;

		public bool ShowRelationshipInfo;

		[global::UnityEngine.Header("Messaging")]
		public global::System.Collections.Generic.List<global::ScheduleOne.Messaging.EConversationCategory> ConversationCategories;

		public bool ConversationCanBeHidden;

		public global::System.Action onConversationCreated;

		[global::UnityEngine.Header("Other Settings")]
		public bool CanOpenDoors;

		[global::UnityEngine.SerializeField]
		protected global::System.Collections.Generic.List<global::UnityEngine.GameObject> OutlineRenderers;

		protected global::EPOOutline.Outlinable OutlineEffect;

		[global::UnityEngine.Header("GUID")]
		public string BakedGUID;

		public global::System.Action<bool> onVisibilityChanged;

		[global::UnityEngine.HideInInspector]
		[global::FishNet.Object.Synchronizing.SyncVar]
		public global::FishNet.Object.NetworkObject PlayerConversant;

		private global::UnityEngine.Coroutine resetUnsettledCoroutine;

		private global::System.Collections.Generic.List<int> impactHistory;

		private int headlightStartTime;

		private int heaedLightsEndTime;

		protected float defaultAggression;

		private global::UnityEngine.Coroutine lerpScaleRoutine;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar___PlayerConversant;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002ENPCAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002ENPCAssembly_002DCSharp_002Edll_Excuted;

		public string fullName => null;

		public float Scale { get; private set; }

		public bool IsConscious => false;

		public global::ScheduleOne.NPCs.NPCMovement Movement => null;

		public global::ScheduleOne.NPCs.NPCInventory Inventory { get; protected set; }

		public global::ScheduleOne.Vehicles.LandVehicle CurrentVehicle { get; protected set; }

		public bool IsInVehicle => false;

		public bool isInBuilding => false;

		public global::ScheduleOne.Map.NPCEnterableBuilding CurrentBuilding { get; protected set; }

		public global::ScheduleOne.Doors.StaticDoor LastEnteredDoor { get; set; }

		public global::ScheduleOne.Messaging.MSGConversation MSGConversation { get; protected set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public global::System.Guid GUID { get; protected set; }

		public bool isVisible { get; protected set; }

		public bool isUnsettled { get; protected set; }

		public bool IsPanicked => false;

		public float timeSincePanicked { get; protected set; }

		public global::FishNet.Object.NetworkObject SyncAccessor_PlayerConversant
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

		public void SetGUID(global::System.Guid guid)
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

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void SetTransform(global::FishNet.Connection.NetworkConnection conn, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
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

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public virtual void AimedAtByPlayer(global::FishNet.Object.NetworkObject player)
		{
		}

		public void OverrideAggression(float aggression)
		{
		}

		public void ResetAggression()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public virtual void SendImpact(global::ScheduleOne.Combat.Impact impact)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public virtual void ReceiveImpact(global::ScheduleOne.Combat.Impact impact)
		{
		}

		public virtual void ProcessImpactForce(global::UnityEngine.Vector3 forcePoint, global::UnityEngine.Vector3 forceDirection, float force)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public virtual void EnterVehicle(global::FishNet.Connection.NetworkConnection connection, global::ScheduleOne.Vehicles.LandVehicle veh)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public virtual void ExitVehicle()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendWorldspaceDialogueKey(string key, float duration)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void PlayWorldspaceDialogue(string key, float duration)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConversant(global::FishNet.Object.NetworkObject player)
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

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void EnterBuilding(global::FishNet.Connection.NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void ExitBuilding(string buildingID = "")
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetEquippable_Networked(global::FishNet.Connection.NetworkConnection conn, string assetPath)
		{
		}

		public global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable SetEquippable_Networked_Return(global::FishNet.Connection.NetworkConnection conn, string assetPath)
		{
			return null;
		}

		public global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable SetEquippable_Return(string assetPath)
		{
			return null;
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = false, ExcludeServer = true)]
		private void SetEquippable_Networked_ExcludeServer(global::FishNet.Connection.NetworkConnection conn, string assetPath)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SendEquippableMessage_Networked(global::FishNet.Connection.NetworkConnection conn, string message)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SendEquippableMessage_Networked_Vector(global::FishNet.Connection.NetworkConnection conn, string message, global::UnityEngine.Vector3 data)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SendAnimationTrigger(string trigger)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetAnimationTrigger_Networked(global::FishNet.Connection.NetworkConnection conn, string trigger)
		{
		}

		public void SetAnimationTrigger(string trigger)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void ResetAnimationTrigger_Networked(global::FishNet.Connection.NetworkConnection conn, string trigger)
		{
		}

		public void ResetAnimationTrigger(string trigger)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void SetCrouched_Networked(bool crouched)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetAnimationBool_Networked(global::FishNet.Connection.NetworkConnection conn, string id, bool value)
		{
		}

		public void SetAnimationBool(string trigger, bool val)
		{
		}

		protected virtual bool ShouldNoticeGeneralCrime(global::ScheduleOne.PlayerScripts.Player player)
		{
			return false;
		}

		protected virtual void SetUnsettled_30s(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		protected void SetUnsettled(float duration)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SetPanicked()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReceivePanicked()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void RemovePanicked()
		{
		}

		public virtual string GetNameAddress()
		{
			return null;
		}

		public void PlayVO(global::ScheduleOne.VoiceOver.EVOLineType lineType)
		{
		}

		[global::FishNet.Object.TargetRpc]
		public void ReceiveRelationshipData(global::FishNet.Connection.NetworkConnection conn, float relationship, bool unlocked)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SetIsBeingPickPocketed(bool pickpocketed)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SendRelationship(float relationship)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void SetRelationship(float relationship)
		{
		}

		public void ShowOutline(global::UnityEngine.Color color)
		{
		}

		public void ShowOutline(global::ScheduleOne.EntityFramework.BuildableItem.EOutlineColor color)
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

		public virtual global::System.Collections.Generic.List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		public virtual void Load(global::ScheduleOne.Persistence.Datas.NPCData data, string containerPath)
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

		private void RpcWriter___Observers_SetTransform_4260003484(global::FishNet.Connection.NetworkConnection conn, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
		{
		}

		private void RpcLogic___SetTransform_4260003484(global::FishNet.Connection.NetworkConnection conn, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
		{
		}

		private void RpcReader___Observers_SetTransform_4260003484(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_AimedAtByPlayer_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		public virtual void RpcLogic___AimedAtByPlayer_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcReader___Server_AimedAtByPlayer_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendImpact_427288424(global::ScheduleOne.Combat.Impact impact)
		{
		}

		public virtual void RpcLogic___SendImpact_427288424(global::ScheduleOne.Combat.Impact impact)
		{
		}

		private void RpcReader___Server_SendImpact_427288424(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveImpact_427288424(global::ScheduleOne.Combat.Impact impact)
		{
		}

		public virtual void RpcLogic___ReceiveImpact_427288424(global::ScheduleOne.Combat.Impact impact)
		{
		}

		private void RpcReader___Observers_ReceiveImpact_427288424(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_EnterVehicle_3321926803(global::FishNet.Connection.NetworkConnection connection, global::ScheduleOne.Vehicles.LandVehicle veh)
		{
		}

		public virtual void RpcLogic___EnterVehicle_3321926803(global::FishNet.Connection.NetworkConnection connection, global::ScheduleOne.Vehicles.LandVehicle veh)
		{
		}

		private void RpcReader___Observers_EnterVehicle_3321926803(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_EnterVehicle_3321926803(global::FishNet.Connection.NetworkConnection connection, global::ScheduleOne.Vehicles.LandVehicle veh)
		{
		}

		private void RpcReader___Target_EnterVehicle_3321926803(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_ExitVehicle_2166136261()
		{
		}

		public virtual void RpcLogic___ExitVehicle_2166136261()
		{
		}

		private void RpcReader___Observers_ExitVehicle_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendWorldspaceDialogueKey_606697822(string key, float duration)
		{
		}

		public void RpcLogic___SendWorldspaceDialogueKey_606697822(string key, float duration)
		{
		}

		private void RpcReader___Server_SendWorldspaceDialogueKey_606697822(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_PlayWorldspaceDialogue_606697822(string key, float duration)
		{
		}

		private void RpcLogic___PlayWorldspaceDialogue_606697822(string key, float duration)
		{
		}

		private void RpcReader___Observers_PlayWorldspaceDialogue_606697822(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetConversant_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		public void RpcLogic___SetConversant_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcReader___Server_SetConversant_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_EnterBuilding_3905681115(global::FishNet.Connection.NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		public void RpcLogic___EnterBuilding_3905681115(global::FishNet.Connection.NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		private void RpcReader___Observers_EnterBuilding_3905681115(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_EnterBuilding_3905681115(global::FishNet.Connection.NetworkConnection connection, string buildingGUID, int doorIndex)
		{
		}

		private void RpcReader___Target_EnterBuilding_3905681115(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_ExitBuilding_3615296227(string buildingID = "")
		{
		}

		public void RpcLogic___ExitBuilding_3615296227(string buildingID = "")
		{
		}

		private void RpcReader___Observers_ExitBuilding_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetEquippable_Networked_2971853958(global::FishNet.Connection.NetworkConnection conn, string assetPath)
		{
		}

		public void RpcLogic___SetEquippable_Networked_2971853958(global::FishNet.Connection.NetworkConnection conn, string assetPath)
		{
		}

		private void RpcReader___Observers_SetEquippable_Networked_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetEquippable_Networked_2971853958(global::FishNet.Connection.NetworkConnection conn, string assetPath)
		{
		}

		private void RpcReader___Target_SetEquippable_Networked_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetEquippable_Networked_ExcludeServer_2971853958(global::FishNet.Connection.NetworkConnection conn, string assetPath)
		{
		}

		private void RpcLogic___SetEquippable_Networked_ExcludeServer_2971853958(global::FishNet.Connection.NetworkConnection conn, string assetPath)
		{
		}

		private void RpcReader___Observers_SetEquippable_Networked_ExcludeServer_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SendEquippableMessage_Networked_2971853958(global::FishNet.Connection.NetworkConnection conn, string message)
		{
		}

		public void RpcLogic___SendEquippableMessage_Networked_2971853958(global::FishNet.Connection.NetworkConnection conn, string message)
		{
		}

		private void RpcReader___Observers_SendEquippableMessage_Networked_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SendEquippableMessage_Networked_2971853958(global::FishNet.Connection.NetworkConnection conn, string message)
		{
		}

		private void RpcReader___Target_SendEquippableMessage_Networked_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SendEquippableMessage_Networked_Vector_4022222929(global::FishNet.Connection.NetworkConnection conn, string message, global::UnityEngine.Vector3 data)
		{
		}

		public void RpcLogic___SendEquippableMessage_Networked_Vector_4022222929(global::FishNet.Connection.NetworkConnection conn, string message, global::UnityEngine.Vector3 data)
		{
		}

		private void RpcReader___Observers_SendEquippableMessage_Networked_Vector_4022222929(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SendEquippableMessage_Networked_Vector_4022222929(global::FishNet.Connection.NetworkConnection conn, string message, global::UnityEngine.Vector3 data)
		{
		}

		private void RpcReader___Target_SendEquippableMessage_Networked_Vector_4022222929(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendAnimationTrigger_3615296227(string trigger)
		{
		}

		public void RpcLogic___SendAnimationTrigger_3615296227(string trigger)
		{
		}

		private void RpcReader___Server_SendAnimationTrigger_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetAnimationTrigger_Networked_2971853958(global::FishNet.Connection.NetworkConnection conn, string trigger)
		{
		}

		public void RpcLogic___SetAnimationTrigger_Networked_2971853958(global::FishNet.Connection.NetworkConnection conn, string trigger)
		{
		}

		private void RpcReader___Observers_SetAnimationTrigger_Networked_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetAnimationTrigger_Networked_2971853958(global::FishNet.Connection.NetworkConnection conn, string trigger)
		{
		}

		private void RpcReader___Target_SetAnimationTrigger_Networked_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_ResetAnimationTrigger_Networked_2971853958(global::FishNet.Connection.NetworkConnection conn, string trigger)
		{
		}

		public void RpcLogic___ResetAnimationTrigger_Networked_2971853958(global::FishNet.Connection.NetworkConnection conn, string trigger)
		{
		}

		private void RpcReader___Observers_ResetAnimationTrigger_Networked_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ResetAnimationTrigger_Networked_2971853958(global::FishNet.Connection.NetworkConnection conn, string trigger)
		{
		}

		private void RpcReader___Target_ResetAnimationTrigger_Networked_2971853958(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetCrouched_Networked_1140765316(bool crouched)
		{
		}

		public void RpcLogic___SetCrouched_Networked_1140765316(bool crouched)
		{
		}

		private void RpcReader___Observers_SetCrouched_Networked_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetAnimationBool_Networked_619441887(global::FishNet.Connection.NetworkConnection conn, string id, bool value)
		{
		}

		public void RpcLogic___SetAnimationBool_Networked_619441887(global::FishNet.Connection.NetworkConnection conn, string id, bool value)
		{
		}

		private void RpcReader___Observers_SetAnimationBool_Networked_619441887(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetAnimationBool_Networked_619441887(global::FishNet.Connection.NetworkConnection conn, string id, bool value)
		{
		}

		private void RpcReader___Target_SetAnimationBool_Networked_619441887(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetPanicked_2166136261()
		{
		}

		public void RpcLogic___SetPanicked_2166136261()
		{
		}

		private void RpcReader___Server_SetPanicked_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceivePanicked_2166136261()
		{
		}

		private void RpcLogic___ReceivePanicked_2166136261()
		{
		}

		private void RpcReader___Observers_ReceivePanicked_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_RemovePanicked_2166136261()
		{
		}

		private void RpcLogic___RemovePanicked_2166136261()
		{
		}

		private void RpcReader___Observers_RemovePanicked_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ReceiveRelationshipData_4052192084(global::FishNet.Connection.NetworkConnection conn, float relationship, bool unlocked)
		{
		}

		public void RpcLogic___ReceiveRelationshipData_4052192084(global::FishNet.Connection.NetworkConnection conn, float relationship, bool unlocked)
		{
		}

		private void RpcReader___Target_ReceiveRelationshipData_4052192084(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetIsBeingPickPocketed_1140765316(bool pickpocketed)
		{
		}

		public void RpcLogic___SetIsBeingPickPocketed_1140765316(bool pickpocketed)
		{
		}

		private void RpcReader___Server_SetIsBeingPickPocketed_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SendRelationship_431000436(float relationship)
		{
		}

		public void RpcLogic___SendRelationship_431000436(float relationship)
		{
		}

		private void RpcReader___Server_SendRelationship_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetRelationship_431000436(float relationship)
		{
		}

		private void RpcLogic___SetRelationship_431000436(float relationship)
		{
		}

		private void RpcReader___Observers_SetRelationship_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002ENPCs_002ENPC(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ENPCs_002ENPC_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
