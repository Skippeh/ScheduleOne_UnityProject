namespace ScheduleOne.Temperature
{
	public class AirConditioner : global::ScheduleOne.EntityFramework.GridItem
	{
		public enum EMode
		{
			Off = 0,
			Cooling = 1,
			Heating = 2
		}

		private const float CoolingTemperature = 0f;

		private const float HeatingTemperature = 40f;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Light _coolingLight;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Light _heatingLight;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Audio.AudioSourceController _beepSound;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Audio.AudioSourceController _loopSound;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.ParticleSystem _heatParticles;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.ParticleSystem _coolParticles;

		public global::FishNet.Object.Synchronizing.SyncVar<global::ScheduleOne.Temperature.AirConditioner.EMode> syncVar____003CCurrentMode_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002ETemperature_002EAirConditionerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ETemperature_002EAirConditionerAssembly_002DCSharp_002Edll_Excuted;

		[field: global::UnityEngine.SerializeField]
		public global::ScheduleOne.Temperature.TemperatureEmitter TemperatureEmitter { get; private set; }

		[field: global::UnityEngine.SerializeField]
		public global::ScheduleOne.UI.TemperatureDisplay TemperatureDisplay { get; private set; }

		public global::ScheduleOne.Temperature.AirConditioner.EMode CurrentMode
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return default(global::ScheduleOne.Temperature.AirConditioner.EMode);
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private set
			{
			}
		}

		public global::ScheduleOne.Temperature.AirConditioner.EMode SyncAccessor__003CCurrentMode_003Ek__BackingField
		{
			get
			{
				return default(global::ScheduleOne.Temperature.AirConditioner.EMode);
			}
			set
			{
			}
		}

		public override void Awake()
		{
		}

		public override void InitializeGridItem(global::ScheduleOne.ItemFramework.ItemInstance instance, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		private void HeatmapVisibilityChanged(global::ScheduleOne.Property.Property property, bool visible)
		{
		}

		protected override void Destroy()
		{
		}

		private void Update()
		{
		}

		private void UpdateLoopSound()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetMode_Server(global::ScheduleOne.Temperature.AirConditioner.EMode mode)
		{
		}

		public void SetMode(global::ScheduleOne.Temperature.AirConditioner.EMode mode)
		{
		}

		private void ApplyMode()
		{
		}

		private void OnModeChanged(global::ScheduleOne.Temperature.AirConditioner.EMode previous, global::ScheduleOne.Temperature.AirConditioner.EMode current, bool asServer)
		{
		}

		[global::EasyButtons.Button]
		public void SetOff()
		{
		}

		[global::EasyButtons.Button]
		public void SetCooling()
		{
		}

		[global::EasyButtons.Button]
		public void SetHeating()
		{
		}

		public override global::ScheduleOne.Persistence.Datas.BuildableItemData GetBaseData()
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

		private void RpcWriter___Server_SetMode_Server_3835190203(global::ScheduleOne.Temperature.AirConditioner.EMode mode)
		{
		}

		public void RpcLogic___SetMode_Server_3835190203(global::ScheduleOne.Temperature.AirConditioner.EMode mode)
		{
		}

		private void RpcReader___Server_SetMode_Server_3835190203(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002ETemperature_002EAirConditioner(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002ETemperature_002EAirConditioner_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
