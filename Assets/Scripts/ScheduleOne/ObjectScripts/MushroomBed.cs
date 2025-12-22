namespace ScheduleOne.ObjectScripts
{
	public class MushroomBed : global::ScheduleOne.Growing.GrowContainer, global::ScheduleOne.Management.IConfigurable
	{
		public enum EMushroomBedSoilAppearance
		{
			NoSpores = 0,
			MaskedSpores = 1,
			FullSpores = 2
		}

		[global::UnityEngine.Header("Mushroom Bed")]
		[global::UnityEngine.SerializeField]
		private float _internalSideLength;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Management.ConfigurationReplicator _configurationReplicator;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Sprite _typeIcon;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UI.Management.MushroomBedUIElement _worldspaceUIPrefab;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.ParticleSystem _poofParticles;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Audio.AudioSourceController _poofSound;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _colonyAlignment;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Transform _mixFXContainer;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.ParticleSystem[] _mixParticles;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Audio.AudioSourceController _mixSound;

		private global::UnityEngine.Material _soilMaterialInstance;

		private global::ScheduleOne.ObjectScripts.MushroomBed.EMushroomBedSoilAppearance _currentSoilAppearance;

		private bool _mushroomBedColdAtLeastOnce;

		public global::FishNet.Object.Synchronizing.SyncVar<global::FishNet.Object.NetworkObject> syncVar____003CCurrentPlayerConfigurer_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EMushroomBedAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EMushroomBedAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.Growing.ShroomColony CurrentColony { get; set; }

		public global::ScheduleOne.Management.EntityConfiguration Configuration => null;

		public global::ScheduleOne.Management.ConfigurationReplicator ConfigReplicator => null;

		public global::ScheduleOne.Management.EConfigurableType ConfigurableType => default(global::ScheduleOne.Management.EConfigurableType);

		public global::ScheduleOne.UI.Management.WorldspaceUIElement WorldspaceUI { get; set; }

		public global::FishNet.Object.NetworkObject CurrentPlayerConfigurer
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
			}
		}

		public global::UnityEngine.Sprite TypeIcon => null;

		public global::UnityEngine.Transform Transform => null;

		public global::UnityEngine.Transform UIPoint => null;

		public bool CanBeSelected => false;

		protected global::ScheduleOne.Management.MushroomBedConfiguration _configuration { get; set; }

		public global::FishNet.Object.NetworkObject SyncAccessor__003CCurrentPlayerConfigurer_003Ek__BackingField
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void SendConfigurationToClient(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public override void InitializeGridItem(global::ScheduleOne.ItemFramework.ItemInstance instance, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		public override string GetManagementName()
		{
			return null;
		}

		protected override void Destroy()
		{
		}

		public override bool CanBeDestroyed(out string reason)
		{
			reason = null;
			return false;
		}

		public override bool IsPointAboveGrowSurface(global::UnityEngine.Vector3 point)
		{
			return false;
		}

		public override void SetGrowableVisible(bool visible)
		{
		}

		public override bool CanApplyAdditive(global::ScheduleOne.ItemFramework.AdditiveDefinition additiveDef, out string invalidReason)
		{
			invalidReason = null;
			return false;
		}

		protected override global::UnityEngine.Vector3 GetRandomPourTargetPosition()
		{
			return default(global::UnityEngine.Vector3);
		}

		public override float GetGrowSurfaceSideLength()
		{
			return 0f;
		}

		protected override global::UnityEngine.Material GetSoilMaterial()
		{
			return null;
		}

		public override void SetSoil(global::ScheduleOne.ItemFramework.SoilDefinition soil)
		{
		}

		public override void SetMoistureAmount(float amount)
		{
		}

		public void ConfigureSoilAppearance(global::ScheduleOne.ObjectScripts.MushroomBed.EMushroomBedSoilAppearance appearance, global::UnityEngine.Texture2D sporeMask = null)
		{
		}

		public bool IsReadyForHarvest(out string reason)
		{
			reason = null;
			return false;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(global::FishNet.Object.NetworkObject player)
		{
		}

		protected override global::ScheduleOne.ItemFramework.AdditiveDefinition ApplyAdditive(string additiveID, bool isInitialApplication)
		{
			return null;
		}

		public void PlayMixFXAtPoint(global::UnityEngine.Vector3 point)
		{
		}

		protected override void OnTileTemperatureChanged(global::ScheduleOne.Tiles.Tile tile, float newTemp)
		{
		}

		public override bool ContainsGrowable()
		{
			return false;
		}

		[global::EasyButtons.Button]
		private void TestCreateColony()
		{
		}

		public void CreateAndAssignColony(global::ScheduleOne.ItemFramework.ShroomSpawnDefinition shroomSpawn)
		{
		}

		public void AssignColony(global::ScheduleOne.Growing.ShroomColony colony)
		{
		}

		private void OnColonyFullyHarvested()
		{
		}

		protected override void ClearSoil()
		{
		}

		public void CheckShowTemperatureHint()
		{
		}

		public global::ScheduleOne.UI.Management.WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		public void DestroyWorldspaceUI()
		{
		}

		public override global::ScheduleOne.Persistence.Datas.BuildableItemData GetBaseData()
		{
			return null;
		}

		public override global::ScheduleOne.Persistence.Datas.DynamicSaveData GetSaveData()
		{
			return null;
		}

		public virtual void Load(global::ScheduleOne.Persistence.Datas.MushroomBedData mushroomBedData)
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

		private void RpcWriter___Server_SetConfigurer_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		public void RpcLogic___SetConfigurer_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcReader___Server_SetConfigurer_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EObjectScripts_002EMushroomBed(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		public override void Awake()
		{
		}
	}
}
