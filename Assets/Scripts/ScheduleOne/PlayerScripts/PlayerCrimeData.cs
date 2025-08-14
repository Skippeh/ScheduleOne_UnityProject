namespace ScheduleOne.PlayerScripts
{
	public class PlayerCrimeData : global::FishNet.Object.NetworkBehaviour
	{
		public class VehicleCollisionInstance
		{
			public global::ScheduleOne.NPCs.NPC Victim;

			public float TimeSince;

			public VehicleCollisionInstance(global::ScheduleOne.NPCs.NPC victim, float timeSince)
			{
			}
		}

		public enum EPursuitLevel
		{
			None = 0,
			Investigating = 1,
			Arresting = 2,
			NonLethal = 3,
			Lethal = 4
		}

		public const float SEARCH_TIME_INVESTIGATING = 60f;

		public const float SEARCH_TIME_ARRESTING = 25f;

		public const float SEARCH_TIME_NONLETHAL = 30f;

		public const float SEARCH_TIME_LETHAL = 40f;

		public const float ESCALATION_TIME_ARRESTING = 25f;

		public const float ESCALATION_TIME_NONLETHAL = 120f;

		public const float SHOT_COOLDOWN_MIN = 2f;

		public const float SHOT_COOLDOWN_MAX = 8f;

		public const float VEHICLE_COLLISION_LIFETIME = 30f;

		public const float VEHICLE_COLLISION_LIMIT = 3f;

		public global::ScheduleOne.Police.PoliceOfficer NearestOfficer;

		public global::ScheduleOne.PlayerScripts.Player Player;

		public global::ScheduleOne.Audio.AudioSourceController onPursuitEscapedSound;

		public global::System.Collections.Generic.List<global::ScheduleOne.Police.PoliceOfficer> Pursuers;

		public float TimeSincePursuitStart;

		public float CurrentPursuitLevelDuration;

		public float TimeSinceSighted;

		public global::System.Collections.Generic.Dictionary<global::ScheduleOne.Law.Crime, int> Crimes;

		public bool BodySearchPending;

		public float timeSinceLastShot;

		protected global::System.Collections.Generic.List<global::ScheduleOne.PlayerScripts.PlayerCrimeData.VehicleCollisionInstance> Collisions;

		private global::ScheduleOne.Audio.MusicTrack _lightCombatTrack;

		private global::ScheduleOne.Audio.MusicTrack _heavyCombatTrack;

		private float outOfSightTimeToDipMusic;

		private float minMusicVolume;

		private float musicChangeRate_Down;

		private float musicChangeRate_Up;

		public global::FishNet.Object.Synchronizing.SyncVar<global::ScheduleOne.PlayerScripts.PlayerCrimeData.EPursuitLevel> syncVar____003CCurrentPursuitLevel_003Ek__BackingField;

		public global::FishNet.Object.Synchronizing.SyncVar<global::UnityEngine.Vector3> syncVar____003CLastKnownPosition_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EPlayerScripts_002EPlayerCrimeDataAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EPlayerScripts_002EPlayerCrimeDataAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.PlayerScripts.PlayerCrimeData.EPursuitLevel CurrentPursuitLevel
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return default(global::ScheduleOne.PlayerScripts.PlayerCrimeData.EPursuitLevel);
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::FishNet.Object.ServerRpc(RunLocally = true)]
			protected set
			{
			}
		}

		public global::UnityEngine.Vector3 LastKnownPosition
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return default(global::UnityEngine.Vector3);
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			[global::FishNet.Object.ServerRpc(RunLocally = true)]
			protected set
			{
			}
		}

		public float CurrentArrestProgress { get; protected set; }

		public float CurrentBodySearchProgress { get; protected set; }

		public int MinsSinceLastArrested { get; set; }

		public float TimeSinceLastBodySearch { get; set; }

		public bool EvadedArrest { get; protected set; }

		public global::ScheduleOne.PlayerScripts.PlayerCrimeData.EPursuitLevel SyncAccessor__003CCurrentPursuitLevel_003Ek__BackingField
		{
			get
			{
				return default(global::ScheduleOne.PlayerScripts.PlayerCrimeData.EPursuitLevel);
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector3 SyncAccessor__003CLastKnownPosition_003Ek__BackingField
		{
			get
			{
				return default(global::UnityEngine.Vector3);
			}
			set
			{
			}
		}

		public virtual void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		protected virtual void Update()
		{
		}

		private void MinPass()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public void SetPursuitLevel(global::ScheduleOne.PlayerScripts.PlayerCrimeData.EPursuitLevel level)
		{
		}

		public void Escalate()
		{
		}

		public void Deescalate()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void RecordLastKnownPosition(bool resetTimeSinceSighted)
		{
		}

		public void SetArrestProgress(float progress)
		{
		}

		public void ResetBodysearchCooldown()
		{
		}

		public void SetBodySearchProgress(float progress)
		{
		}

		private void OnDie()
		{
		}

		public void AddCrime(global::ScheduleOne.Law.Crime crime, int quantity = 1)
		{
		}

		public void ClearCrimes()
		{
		}

		public bool IsCrimeOnRecord(global::System.Type crime)
		{
			return false;
		}

		public void SetEvaded()
		{
		}

		private void OnSleepStart()
		{
		}

		private void UpdateEscalation()
		{
		}

		private void UpdateTimeout()
		{
		}

		private void UpdateMusic()
		{
		}

		private void TimeoutPursuit()
		{
		}

		public float GetSearchTime()
		{
			return 0f;
		}

		public void ResetShotAccuracy()
		{
		}

		public float GetShotAccuracyMultiplier()
		{
			return 0f;
		}

		public void RecordVehicleCollision(global::ScheduleOne.NPCs.NPC victim)
		{
		}

		private void CheckNearestOfficer()
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

		private void RpcWriter___Server_set_CurrentPursuitLevel_2979171596(global::ScheduleOne.PlayerScripts.PlayerCrimeData.EPursuitLevel value)
		{
		}

		[global::System.Runtime.CompilerServices.SpecialName]
		protected void RpcLogic___set_CurrentPursuitLevel_2979171596(global::ScheduleOne.PlayerScripts.PlayerCrimeData.EPursuitLevel value)
		{
		}

		private void RpcReader___Server_set_CurrentPursuitLevel_2979171596(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_set_LastKnownPosition_4276783012(global::UnityEngine.Vector3 value)
		{
		}

		[global::System.Runtime.CompilerServices.SpecialName]
		protected void RpcLogic___set_LastKnownPosition_4276783012(global::UnityEngine.Vector3 value)
		{
		}

		private void RpcReader___Server_set_LastKnownPosition_4276783012(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
		}

		public void RpcLogic___RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
		}

		private void RpcReader___Observers_RecordLastKnownPosition_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EPlayerScripts_002EPlayerCrimeData(global::FishNet.Serializing.PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		private void Awake_UserLogic_ScheduleOne_002EPlayerScripts_002EPlayerCrimeData_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
