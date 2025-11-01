namespace ScheduleOne.PlayerScripts
{
	public class Player : global::FishNet.Object.NetworkBehaviour, global::ScheduleOne.Persistence.ISaveable, global::ScheduleOne.Combat.ICombatTargetable, global::ScheduleOne.Combat.IDamageable, global::ScheduleOne.Vision.ISightable
	{
		public delegate void VehicleEvent(global::ScheduleOne.Vehicles.LandVehicle vehicle);

		public delegate void VehicleTransformEvent(global::ScheduleOne.Vehicles.LandVehicle vehicle, global::UnityEngine.Transform exitPoint);

		public const string OWNER_PLAYER_CODE = "Local";

		public const float CapColDefaultHeight = 2f;

		public global::System.Collections.Generic.List<global::FishNet.Object.NetworkObject> objectsTemporarilyOwnedByPlayer;

		public static global::System.Action onLocalPlayerSpawned;

		public static global::System.Action<global::ScheduleOne.PlayerScripts.Player> onPlayerSpawned;

		public static global::System.Action<global::ScheduleOne.PlayerScripts.Player> onPlayerDespawned;

		public static global::ScheduleOne.PlayerScripts.Player Local;

		public static global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.Player> PlayerList;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject LocalGameObject;

		public global::ScheduleOne.AvatarFramework.Avatar Avatar;

		public global::ScheduleOne.AvatarFramework.Animation.AvatarAnimation Anim;

		public global::ScheduleOne.Tools.SmoothedVelocityCalculator VelocityCalculator;

		public global::ScheduleOne.Vision.PlayerVisibility VisualState;

		public global::ScheduleOne.Vision.EntityVisibility Visibility;

		public global::UnityEngine.CapsuleCollider CapCol;

		public global::ScheduleOne.Map.POI PoI;

		public global::ScheduleOne.PlayerScripts.Health.PlayerHealth Health;

		public global::ScheduleOne.PlayerScripts.PlayerCrimeData CrimeData;

		public global::ScheduleOne.PlayerScripts.PlayerEnergy Energy;

		public global::UnityEngine.Transform MimicCamera;

		public global::ScheduleOne.AvatarFramework.Animation.AvatarFootstepDetector FootstepDetector;

		public global::ScheduleOne.PlayerScripts.LocalPlayerFootstepGenerator LocalFootstepDetector;

		public global::UnityEngine.CharacterController CharacterController;

		public global::ScheduleOne.Audio.AudioSourceController PunchSound;

		public global::ScheduleOne.DevUtilities.OptimizedLight ThirdPersonFlashlight;

		public global::ScheduleOne.UI.WorldspaceDialogueRenderer NameLabel;

		public global::ScheduleOne.PlayerScripts.PlayerClothing Clothing;

		public global::ScheduleOne.UI.WorldspaceDialogueRenderer WorldspaceDialogue;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.LayerMask GroundDetectionMask;

		public float AvatarOffset_Standing;

		public float AvatarOffset_Crouched;

		[global::UnityEngine.Header("Movement mapping")]
		public global::UnityEngine.AnimationCurve WalkingMapCurve;

		public global::UnityEngine.AnimationCurve CrouchWalkMapCurve;

		public global::FishNet.Connection.NetworkConnection Connection;

		public global::ScheduleOne.PlayerScripts.Player.VehicleEvent onEnterVehicle;

		public global::ScheduleOne.PlayerScripts.Player.VehicleTransformEvent onExitVehicle;

		public global::System.Action<global::ScheduleOne.Skating.Skateboard> onSkateboardMounted;

		public global::System.Action onSkateboardDismounted;

		public bool HasCompletedIntro;

		public global::ScheduleOne.ItemFramework.ItemSlot[] Inventory;

		[global::UnityEngine.Header("Appearance debugging")]
		public global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings DebugAvatarSettings;

		private global::ScheduleOne.Persistence.Loaders.PlayerLoader loader;

		public global::UnityEngine.Events.UnityEvent onRagdoll;

		public global::UnityEngine.Events.UnityEvent onRagdollEnd;

		public global::UnityEngine.Events.UnityEvent onArrested;

		public global::UnityEngine.Events.UnityEvent onFreed;

		public global::UnityEngine.Events.UnityEvent onTased;

		public global::UnityEngine.Events.UnityEvent onTasedEnd;

		public global::UnityEngine.Events.UnityEvent onPassedOut;

		public global::UnityEngine.Events.UnityEvent onPassOutRecovery;

		public global::System.Collections.Generic.List<global::ScheduleOne.Variables.BaseVariable> PlayerVariables;

		public global::System.Collections.Generic.Dictionary<string, global::ScheduleOne.Variables.BaseVariable> VariableDict;

		private float standingScale;

		private float timeAirborne;

		private global::UnityEngine.Coroutine taseCoroutine;

		private global::System.Collections.Generic.List<global::UnityEngine.ConstantForce> ragdollForceComponents;

		private global::System.Collections.Generic.List<int> impactHistory;

		private global::System.Collections.Generic.List<global::UnityEngine.Quaternion> seizureRotations;

		private global::System.Collections.Generic.List<int> equippableMessageIDHistory;

		private global::UnityEngine.Coroutine lerpScaleRoutine;

		public global::FishNet.Object.Synchronizing.SyncVar<string> syncVar____003CPlayerName_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<string> syncVar____003CPlayerCode_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CCurrentVehicle_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CCurrentBed_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<bool> syncVar____003CIsReadyToSleep_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::UnityEngine.Vector3> syncVar____003CCameraPosition_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::UnityEngine.Quaternion> syncVar____003CCameraRotation_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EPlayerScripts_002EPlayerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EPlayerScripts_002EPlayerAssembly_002DCSharp_002Edll_Excuted;

		public bool IsLocalPlayer => false;

		public global::UnityEngine.Transform CenterPointTransform => null;

		public global::UnityEngine.Vector3 LookAtPoint => default(global::UnityEngine.Vector3);

		public bool IsCurrentlyTargetable => false;

		public float RangedHitChanceMultiplier => 0f;

		public global::UnityEngine.Vector3 Velocity => default(global::UnityEngine.Vector3);

		public global::ScheduleOne.Vision.VisionEvent HighestProgressionEvent { get; set; }

		public global::ScheduleOne.Vision.EntityVisibility VisibilityComponent => null;

		public global::UnityEngine.Vector3 EyePosition { get; private set; }

		public string PlayerName
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
			}
		}

		public string PlayerCode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			protected set
			{
			}
		}

		public global::FishNet.Object.NetworkObject CurrentVehicle
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::FishNet.Object.ServerRpc(RunLocally = true)]
			set
			{
			}
		}

		public global::ScheduleOne.Vehicles.VehicleSeat CurrentVehicleSeat { get; private set; }

		public global::ScheduleOne.Vehicles.LandVehicle LastDrivenVehicle { get; private set; }

		public float TimeSinceVehicleExit { get; protected set; }

		public bool Crouched { get; private set; }

		public global::FishNet.Object.NetworkObject CurrentBed
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::FishNet.Object.ServerRpc]
			set
			{
			}
		}

		public bool IsReadyToSleep
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return false;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
			}
		}

		public bool IsSkating
		{
			get; [global::FishNet.Object.ServerRpc]
			set;
		}

		public global::ScheduleOne.Skating.Skateboard ActiveSkateboard { get; private set; }

		public bool IsSleeping { get; protected set; }

		public bool IsRagdolled { get; protected set; }

		public bool IsArrested { get; protected set; }

		public bool IsTased { get; protected set; }

		public bool IsUnconscious { get; protected set; }

		public float Scale { get; private set; }

		public global::ScheduleOne.Property.Property CurrentProperty { get; protected set; }

		public global::ScheduleOne.Property.Property LastVisitedProperty { get; protected set; }

		public global::ScheduleOne.Property.Business CurrentBusiness { get; protected set; }

		public global::ScheduleOne.Map.EMapRegion CurrentRegion { get; protected set; }

		public global::UnityEngine.Vector3 PlayerBasePosition => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Vector3 CameraPosition
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return default(global::UnityEngine.Vector3);
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::FishNet.Object.ServerRpc]
			set
			{
			}
		}

		public global::UnityEngine.Quaternion CameraRotation
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return default(global::UnityEngine.Quaternion);
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::FishNet.Object.ServerRpc]
			set
			{
			}
		}

		public int EquippedItemSlotIndex { get; private set; }

		public global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings CurrentAvatarSettings { get; protected set; }

		public global::ScheduleOne.Product.ProductItemInstance ConsumedProduct { get; private set; }

		public int TimeSinceProductConsumed { get; private set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public bool avatarVisibleToLocalPlayer { get; private set; }

		public bool playerDataRetrieveReturned { get; private set; }

		public bool playerSaveRequestReturned { get; private set; }

		public bool PlayerInitializedOverNetwork { get; private set; }

		public bool Paranoid { get; set; }

		public bool Sneaky { get; set; }

		public bool Disoriented { get; set; }

		public bool Seizure { get; set; }

		public bool Slippery { get; set; }

		public bool Schizophrenic { get; set; }

		public string SyncAccessor__003CPlayerName_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string SyncAccessor__003CPlayerCode_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::FishNet.Object.NetworkObject SyncAccessor__003CCurrentVehicle_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::FishNet.Object.NetworkObject SyncAccessor__003CCurrentBed_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool SyncAccessor__003CIsReadyToSleep_003Ek__BackingField
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector3 SyncAccessor__003CCameraPosition_003Ek__BackingField
		{
			get
			{
				return default(global::UnityEngine.Vector3);
			}
			set
			{
			}
		}

		public global::UnityEngine.Quaternion SyncAccessor__003CCameraRotation_003Ek__BackingField
		{
			get
			{
				return default(global::UnityEngine.Quaternion);
			}
			set
			{
			}
		}

		global::FishNet.Object.NetworkObject global::ScheduleOne.Combat.ICombatTargetable.NetworkObject => null;

		global::UnityEngine.GameObject global::ScheduleOne.Combat.IDamageable.gameObject => null;

		global::FishNet.Object.NetworkObject global::ScheduleOne.Vision.ISightable.NetworkObject => null;

		public void RecordLastKnownPosition(bool resetTimeSinceLastSeen)
		{
		}

		public float GetSearchTime()
		{
			return 0f;
		}

		public bool IsCurrentlySightable()
		{
			return false;
		}

		[global::EasyButtons.Button]
		public void LoadDebugAvatarSettings()
		{
		}

		public static global::ScheduleOne.PlayerScripts.Player GetPlayer(global::FishNet.Connection.NetworkConnection conn)
		{
			return null;
		}

		public static global::ScheduleOne.PlayerScripts.Player GetRandomPlayer(bool excludeArrestedOrDead = true, bool excludeSleeping = true)
		{
			return null;
		}

		public static global::ScheduleOne.PlayerScripts.Player GetPlayer(string playerCode)
		{
			return null;
		}

		public virtual void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		public override void OnStartClient()
		{
		}

		private void PlayerLoaded()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void RequestSavePlayer()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		[global::FishNet.Object.TargetRpc]
		private void ReturnSaveRequest(global::FishNet.Connection.NetworkConnection conn, bool successful)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void HostExitedGame()
		{
		}

		private void ClientConnectionStateChanged(global::FishNet.Transporting.ClientConnectionStateArgs args)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void SendPlayerNameData(string playerName, ulong id)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void RequestPlayerData(string playerCode)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void MarkPlayerInitialized()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void ReceivePlayerData(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Persistence.Datas.PlayerData data, string inventoryString, string appearanceString, string clothigString, global::ScheduleOne.Persistence.Datas.VariableData[] vars)
		{
		}

		public void SetGravityMultiplier(float multiplier)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void ReceivePlayerNameData(global::FishNet.Connection.NetworkConnection conn, string playerName, string id)
		{
		}

		public void SendFlashlightOn(bool on)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		private void SendFlashlightOnNetworked(bool on)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetFlashlightOn(bool on)
		{
		}

		public override void OnStopClient()
		{
		}

		public override void OnStartServer()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void MinPass()
		{
		}

		protected virtual void Tick()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void RecalculateCurrentProperty()
		{
		}

		private void RecalculateCurrentRegion()
		{
		}

		private void FixedUpdate()
		{
		}

		private void ApplyMovementVisuals()
		{
		}

		public void SetVisible(bool vis, bool network = false)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		public void PlayJumpAnimation()
		{
		}

		public bool GetIsGrounded()
		{
			return false;
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendCrouched(bool crouched)
		{
		}

		public void SetCrouchedLocal(bool crouched)
		{
		}

		[global::FishNet.Object.TargetRpc]
		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ReceiveCrouched(global::FishNet.Connection.NetworkConnection conn, bool crouched)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void SendAvatarSettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		[global::FishNet.Object.ObserversRpc(BufferLast = true, RunLocally = true)]
		public void SetAvatarSettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void SetVisible_Networked(bool vis)
		{
		}

		public void EnterVehicle(global::ScheduleOne.Vehicles.LandVehicle vehicle, global::ScheduleOne.Vehicles.VehicleSeat seat)
		{
		}

		public void ExitVehicle(global::UnityEngine.Transform exitPoint)
		{
		}

		private void PreDestroyClientObjects(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void CurrentVehicleChanged(global::FishNet.Object.NetworkObject oldVeh, global::FishNet.Object.NetworkObject newVeh, bool asServer)
		{
		}

		public static bool AreAllPlayersReadyToSleep()
		{
			return false;
		}

		private void SleepStart()
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetReadyToSleep(bool ready)
		{
		}

		private void SleepEnd()
		{
		}

		public static void Activate()
		{
		}

		public static void Deactivate(bool freeMouse)
		{
		}

		public void ExitAll()
		{
		}

		public void SetVisibleToLocalPlayer(bool vis)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void SetPlayerCode(string code)
		{
		}

		[global::FishNet.Object.ServerRpc]
		public void SendPunch()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void Punch()
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		private void MarkIntroCompleted(global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings appearance)
		{
		}

		public bool IsPointVisibleToPlayer(global::UnityEngine.Vector3 point, float maxDistance_Visible = 30f, float minDistance_Invisible = 5f)
		{
			return false;
		}

		public static global::ScheduleOne.PlayerScripts.Player GetClosestPlayer(global::UnityEngine.Vector3 point, out float distance, global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.Player> exclude = null)
		{
			distance = default(float);
			return null;
		}

		public void SetCapsuleColliderHeight(float normalizedHeight)
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

		public virtual string GetSaveString()
		{
			return null;
		}

		public global::ScheduleOne.Persistence.Datas.PlayerData GetPlayerData()
		{
			return null;
		}

		public virtual global::System.Collections.Generic.List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		public string GetInventoryString()
		{
			return null;
		}

		public string GetAppearanceString()
		{
			return null;
		}

		public string GetClothingString()
		{
			return null;
		}

		public string GetVariablesString()
		{
			return null;
		}

		public virtual void Load(global::ScheduleOne.Persistence.Datas.PlayerData data, string containerPath)
		{
		}

		public virtual void Load(global::ScheduleOne.Persistence.Datas.PlayerData data)
		{
		}

		public virtual void LoadInventory(string contentsString)
		{
		}

		public virtual void LoadAppearance(string appearanceString)
		{
		}

		public virtual void LoadClothing(string contentsString)
		{
		}

		public void SetRagdolled(bool ragdolled)
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

		public virtual void OnDied()
		{
		}

		public virtual void OnRevived()
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void Arrest_Server()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void Arrest_Client()
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void Free_Server()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void Free_Client()
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void SendPassOut()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true, ExcludeOwner = true)]
		public void PassOut()
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void SendPassOutRecovery()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true, ExcludeOwner = true)]
		public void PassOutRecovery()
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SendEquippable_Networked(string assetPath)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetEquippable_Networked(string assetPath)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void SendEquippableMessage_Networked(string message, int receipt)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ReceiveEquippableMessage_Networked(string message, int receipt)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void SendEquippableMessage_Networked_Vector(string message, int receipt, global::UnityEngine.Vector3 data)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ReceiveEquippableMessage_Networked_Vector(string message, int receipt, global::UnityEngine.Vector3 data)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
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

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void SendAnimationBool(string name, bool val)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void SetAnimationBool(string name, bool val)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		public void Taze()
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void SetInventoryItem(int index, global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void SetEquippedSlotIndex(int index)
		{
		}

		public global::ScheduleOne.ItemFramework.ItemInstance GetEquippedItem()
		{
			return null;
		}

		[global::FishNet.Object.ObserversRpc]
		public void RemoveEquippedItemFromInventory(string id, int amount)
		{
		}

		private void GetNetworth(global::ScheduleOne.Money.MoneyManager.FloatContainer container)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		public void SendAppearance(global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings settings)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void SetAppearance(global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings settings, bool refreshClothing)
		{
		}

		public void MountSkateboard(global::ScheduleOne.Skating.Skateboard board)
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true)]
		private void SendMountedSkateboard(global::FishNet.Object.NetworkObject skateboardObj)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetMountedSkateboard(global::FishNet.Object.NetworkObject skateboardObj)
		{
		}

		public void DismountSkateboard()
		{
		}

		public void ConsumeProduct(global::ScheduleOne.Product.ProductItemInstance product)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendConsumeProduct(global::ScheduleOne.Product.ProductItemInstance product)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void ReceiveConsumeProduct(global::ScheduleOne.Product.ProductItemInstance product)
		{
		}

		private void ConsumeProductInternal(global::ScheduleOne.Product.ProductItemInstance product)
		{
		}

		public void ClearProduct()
		{
		}

		private void CreatePlayerVariables()
		{
		}

		public global::ScheduleOne.Variables.BaseVariable GetVariable(string variableName)
		{
			return null;
		}

		public T GetValue<T>(string variableName)
		{
			return default(T);
		}

		public void SetVariableValue(string variableName, string value, bool network = true)
		{
		}

		public void AddVariable(global::ScheduleOne.Variables.BaseVariable variable)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendValue(string variableName, string value, bool sendToOwner)
		{
		}

		[global::FishNet.Object.TargetRpc]
		private void ReceiveValue(global::FishNet.Connection.NetworkConnection conn, string variableName, string value)
		{
		}

		private void ReceiveValue(string variableName, string value)
		{
		}

		public void LoadVariable(global::ScheduleOne.Persistence.Datas.VariableData data)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SendWorldSpaceDialogue(string text, float duration)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void ShowWorldSpaceDialogue(string text, float duration)
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

		private void RpcWriter___Server_set_CurrentVehicle_3323014238(global::FishNet.Object.NetworkObject value)
		{
		}

		[global::System.Runtime.CompilerServices.SpecialName]
		public void RpcLogic___set_CurrentVehicle_3323014238(global::FishNet.Object.NetworkObject value)
		{
		}

		private void RpcReader___Server_set_CurrentVehicle_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_set_CurrentBed_3323014238(global::FishNet.Object.NetworkObject value)
		{
		}

		[global::System.Runtime.CompilerServices.SpecialName]
		public void RpcLogic___set_CurrentBed_3323014238(global::FishNet.Object.NetworkObject value)
		{
		}

		private void RpcReader___Server_set_CurrentBed_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_set_IsSkating_1140765316(bool value)
		{
		}

		[global::System.Runtime.CompilerServices.SpecialName]
		public void RpcLogic___set_IsSkating_1140765316(bool value)
		{
		}

		private void RpcReader___Server_set_IsSkating_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_set_CameraPosition_4276783012(global::UnityEngine.Vector3 value)
		{
		}

		[global::System.Runtime.CompilerServices.SpecialName]
		public void RpcLogic___set_CameraPosition_4276783012(global::UnityEngine.Vector3 value)
		{
		}

		private void RpcReader___Server_set_CameraPosition_4276783012(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_set_CameraRotation_3429297120(global::UnityEngine.Quaternion value)
		{
		}

		[global::System.Runtime.CompilerServices.SpecialName]
		public void RpcLogic___set_CameraRotation_3429297120(global::UnityEngine.Quaternion value)
		{
		}

		private void RpcReader___Server_set_CameraRotation_3429297120(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_RequestSavePlayer_2166136261()
		{
		}

		public void RpcLogic___RequestSavePlayer_2166136261()
		{
		}

		private void RpcReader___Server_RequestSavePlayer_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReturnSaveRequest_214505783(global::FishNet.Connection.NetworkConnection conn, bool successful)
		{
		}

		private void RpcLogic___ReturnSaveRequest_214505783(global::FishNet.Connection.NetworkConnection conn, bool successful)
		{
		}

		private void RpcReader___Observers_ReturnSaveRequest_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ReturnSaveRequest_214505783(global::FishNet.Connection.NetworkConnection conn, bool successful)
		{
		}

		private void RpcReader___Target_ReturnSaveRequest_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_HostExitedGame_2166136261()
		{
		}

		public void RpcLogic___HostExitedGame_2166136261()
		{
		}

		private void RpcReader___Observers_HostExitedGame_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendPlayerNameData_586648380(string playerName, ulong id)
		{
		}

		public void RpcLogic___SendPlayerNameData_586648380(string playerName, ulong id)
		{
		}

		private void RpcReader___Server_SendPlayerNameData_586648380(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_RequestPlayerData_3615296227(string playerCode)
		{
		}

		public void RpcLogic___RequestPlayerData_3615296227(string playerCode)
		{
		}

		private void RpcReader___Server_RequestPlayerData_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_MarkPlayerInitialized_2166136261()
		{
		}

		public void RpcLogic___MarkPlayerInitialized_2166136261()
		{
		}

		private void RpcReader___Server_MarkPlayerInitialized_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceivePlayerData_3244732873(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Persistence.Datas.PlayerData data, string inventoryString, string appearanceString, string clothigString, global::ScheduleOne.Persistence.Datas.VariableData[] vars)
		{
		}

		public void RpcLogic___ReceivePlayerData_3244732873(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Persistence.Datas.PlayerData data, string inventoryString, string appearanceString, string clothigString, global::ScheduleOne.Persistence.Datas.VariableData[] vars)
		{
		}

		private void RpcReader___Observers_ReceivePlayerData_3244732873(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ReceivePlayerData_3244732873(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Persistence.Datas.PlayerData data, string inventoryString, string appearanceString, string clothigString, global::ScheduleOne.Persistence.Datas.VariableData[] vars)
		{
		}

		private void RpcReader___Target_ReceivePlayerData_3244732873(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_ReceivePlayerNameData_3895153758(global::FishNet.Connection.NetworkConnection conn, string playerName, string id)
		{
		}

		private void RpcLogic___ReceivePlayerNameData_3895153758(global::FishNet.Connection.NetworkConnection conn, string playerName, string id)
		{
		}

		private void RpcReader___Observers_ReceivePlayerNameData_3895153758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_ReceivePlayerNameData_3895153758(global::FishNet.Connection.NetworkConnection conn, string playerName, string id)
		{
		}

		private void RpcReader___Target_ReceivePlayerNameData_3895153758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendFlashlightOnNetworked_1140765316(bool on)
		{
		}

		private void RpcLogic___SendFlashlightOnNetworked_1140765316(bool on)
		{
		}

		private void RpcReader___Server_SendFlashlightOnNetworked_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetFlashlightOn_1140765316(bool on)
		{
		}

		private void RpcLogic___SetFlashlightOn_1140765316(bool on)
		{
		}

		private void RpcReader___Observers_SetFlashlightOn_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_PlayJumpAnimation_2166136261()
		{
		}

		public void RpcLogic___PlayJumpAnimation_2166136261()
		{
		}

		private void RpcReader___Observers_PlayJumpAnimation_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendCrouched_1140765316(bool crouched)
		{
		}

		public void RpcLogic___SendCrouched_1140765316(bool crouched)
		{
		}

		private void RpcReader___Server_SendCrouched_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_ReceiveCrouched_214505783(global::FishNet.Connection.NetworkConnection conn, bool crouched)
		{
		}

		private void RpcLogic___ReceiveCrouched_214505783(global::FishNet.Connection.NetworkConnection conn, bool crouched)
		{
		}

		private void RpcReader___Target_ReceiveCrouched_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_ReceiveCrouched_214505783(global::FishNet.Connection.NetworkConnection conn, bool crouched)
		{
		}

		private void RpcReader___Observers_ReceiveCrouched_214505783(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendAvatarSettings_4281687581(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		public void RpcLogic___SendAvatarSettings_4281687581(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		private void RpcReader___Server_SendAvatarSettings_4281687581(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetAvatarSettings_4281687581(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		public void RpcLogic___SetAvatarSettings_4281687581(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		private void RpcReader___Observers_SetAvatarSettings_4281687581(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetVisible_Networked_1140765316(bool vis)
		{
		}

		private void RpcLogic___SetVisible_Networked_1140765316(bool vis)
		{
		}

		private void RpcReader___Observers_SetVisible_Networked_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetReadyToSleep_1140765316(bool ready)
		{
		}

		public void RpcLogic___SetReadyToSleep_1140765316(bool ready)
		{
		}

		private void RpcReader___Server_SetReadyToSleep_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetPlayerCode_3615296227(string code)
		{
		}

		public void RpcLogic___SetPlayerCode_3615296227(string code)
		{
		}

		private void RpcReader___Observers_SetPlayerCode_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendPunch_2166136261()
		{
		}

		public void RpcLogic___SendPunch_2166136261()
		{
		}

		private void RpcReader___Server_SendPunch_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Punch_2166136261()
		{
		}

		private void RpcLogic___Punch_2166136261()
		{
		}

		private void RpcReader___Observers_Punch_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_MarkIntroCompleted_3281254764(global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings appearance)
		{
		}

		private void RpcLogic___MarkIntroCompleted_3281254764(global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings appearance)
		{
		}

		private void RpcReader___Server_MarkIntroCompleted_3281254764(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
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

		private void RpcWriter___Server_Arrest_Server_2166136261()
		{
		}

		public void RpcLogic___Arrest_Server_2166136261()
		{
		}

		private void RpcReader___Server_Arrest_Server_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Arrest_Client_2166136261()
		{
		}

		private void RpcLogic___Arrest_Client_2166136261()
		{
		}

		private void RpcReader___Observers_Arrest_Client_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_Free_Server_2166136261()
		{
		}

		public void RpcLogic___Free_Server_2166136261()
		{
		}

		private void RpcReader___Server_Free_Server_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Free_Client_2166136261()
		{
		}

		private void RpcLogic___Free_Client_2166136261()
		{
		}

		private void RpcReader___Observers_Free_Client_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendPassOut_2166136261()
		{
		}

		public void RpcLogic___SendPassOut_2166136261()
		{
		}

		private void RpcReader___Server_SendPassOut_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_PassOut_2166136261()
		{
		}

		public void RpcLogic___PassOut_2166136261()
		{
		}

		private void RpcReader___Observers_PassOut_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendPassOutRecovery_2166136261()
		{
		}

		public void RpcLogic___SendPassOutRecovery_2166136261()
		{
		}

		private void RpcReader___Server_SendPassOutRecovery_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_PassOutRecovery_2166136261()
		{
		}

		public void RpcLogic___PassOutRecovery_2166136261()
		{
		}

		private void RpcReader___Observers_PassOutRecovery_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendEquippable_Networked_3615296227(string assetPath)
		{
		}

		public void RpcLogic___SendEquippable_Networked_3615296227(string assetPath)
		{
		}

		private void RpcReader___Server_SendEquippable_Networked_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetEquippable_Networked_3615296227(string assetPath)
		{
		}

		private void RpcLogic___SetEquippable_Networked_3615296227(string assetPath)
		{
		}

		private void RpcReader___Observers_SetEquippable_Networked_3615296227(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		public void RpcLogic___SendEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		private void RpcReader___Server_SendEquippableMessage_Networked_3643459082(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		private void RpcLogic___ReceiveEquippableMessage_Networked_3643459082(string message, int receipt)
		{
		}

		private void RpcReader___Observers_ReceiveEquippableMessage_Networked_3643459082(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendEquippableMessage_Networked_Vector_3190074053(string message, int receipt, global::UnityEngine.Vector3 data)
		{
		}

		public void RpcLogic___SendEquippableMessage_Networked_Vector_3190074053(string message, int receipt, global::UnityEngine.Vector3 data)
		{
		}

		private void RpcReader___Server_SendEquippableMessage_Networked_Vector_3190074053(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053(string message, int receipt, global::UnityEngine.Vector3 data)
		{
		}

		private void RpcLogic___ReceiveEquippableMessage_Networked_Vector_3190074053(string message, int receipt, global::UnityEngine.Vector3 data)
		{
		}

		private void RpcReader___Observers_ReceiveEquippableMessage_Networked_Vector_3190074053(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
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

		private void RpcWriter___Server_SendAnimationBool_310431262(string name, bool val)
		{
		}

		public void RpcLogic___SendAnimationBool_310431262(string name, bool val)
		{
		}

		private void RpcReader___Server_SendAnimationBool_310431262(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetAnimationBool_310431262(string name, bool val)
		{
		}

		public void RpcLogic___SetAnimationBool_310431262(string name, bool val)
		{
		}

		private void RpcReader___Observers_SetAnimationBool_310431262(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_Taze_2166136261()
		{
		}

		public void RpcLogic___Taze_2166136261()
		{
		}

		private void RpcReader___Observers_Taze_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetInventoryItem_2317364410(int index, global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public void RpcLogic___SetInventoryItem_2317364410(int index, global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		private void RpcReader___Server_SetInventoryItem_2317364410(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_SetEquippedSlotIndex_3316948804(int index)
		{
		}

		public void RpcLogic___SetEquippedSlotIndex_3316948804(int index)
		{
		}

		private void RpcReader___Server_SetEquippedSlotIndex_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_RemoveEquippedItemFromInventory_3643459082(string id, int amount)
		{
		}

		public void RpcLogic___RemoveEquippedItemFromInventory_3643459082(string id, int amount)
		{
		}

		private void RpcReader___Observers_RemoveEquippedItemFromInventory_3643459082(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendAppearance_3281254764(global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings settings)
		{
		}

		public void RpcLogic___SendAppearance_3281254764(global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings settings)
		{
		}

		private void RpcReader___Server_SendAppearance_3281254764(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetAppearance_2139595489(global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings settings, bool refreshClothing)
		{
		}

		public void RpcLogic___SetAppearance_2139595489(global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings settings, bool refreshClothing)
		{
		}

		private void RpcReader___Observers_SetAppearance_2139595489(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendMountedSkateboard_3323014238(global::FishNet.Object.NetworkObject skateboardObj)
		{
		}

		private void RpcLogic___SendMountedSkateboard_3323014238(global::FishNet.Object.NetworkObject skateboardObj)
		{
		}

		private void RpcReader___Server_SendMountedSkateboard_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetMountedSkateboard_3323014238(global::FishNet.Object.NetworkObject skateboardObj)
		{
		}

		private void RpcLogic___SetMountedSkateboard_3323014238(global::FishNet.Object.NetworkObject skateboardObj)
		{
		}

		private void RpcReader___Observers_SetMountedSkateboard_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendConsumeProduct_2622925554(global::ScheduleOne.Product.ProductItemInstance product)
		{
		}

		private void RpcLogic___SendConsumeProduct_2622925554(global::ScheduleOne.Product.ProductItemInstance product)
		{
		}

		private void RpcReader___Server_SendConsumeProduct_2622925554(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ReceiveConsumeProduct_2622925554(global::ScheduleOne.Product.ProductItemInstance product)
		{
		}

		private void RpcLogic___ReceiveConsumeProduct_2622925554(global::ScheduleOne.Product.ProductItemInstance product)
		{
		}

		private void RpcReader___Observers_ReceiveConsumeProduct_2622925554(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendValue_3589193952(string variableName, string value, bool sendToOwner)
		{
		}

		public void RpcLogic___SendValue_3589193952(string variableName, string value, bool sendToOwner)
		{
		}

		private void RpcReader___Server_SendValue_3589193952(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Target_ReceiveValue_3895153758(global::FishNet.Connection.NetworkConnection conn, string variableName, string value)
		{
		}

		private void RpcLogic___ReceiveValue_3895153758(global::FishNet.Connection.NetworkConnection conn, string variableName, string value)
		{
		}

		private void RpcReader___Target_ReceiveValue_3895153758(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		public void RpcLogic___SendWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		private void RpcReader___Server_SendWorldSpaceDialogue_606697822(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_ShowWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		private void RpcLogic___ShowWorldSpaceDialogue_606697822(string text, float duration)
		{
		}

		private void RpcReader___Observers_ShowWorldSpaceDialogue_606697822(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EPlayerScripts_002EPlayer(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EPlayerScripts_002EPlayer_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
