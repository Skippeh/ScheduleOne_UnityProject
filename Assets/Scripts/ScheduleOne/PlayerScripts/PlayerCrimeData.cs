using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.Law;
using ScheduleOne.NPCs;
using ScheduleOne.Police;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	public class PlayerCrimeData : NetworkBehaviour
	{
		public class VehicleCollisionInstance
		{
			public NPC Victim;

			public float TimeSince;

			public VehicleCollisionInstance(NPC victim, float timeSince)
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

		public PoliceOfficer NearestOfficer;

		public Player Player;

		public AudioSourceController onPursuitEscapedSound;

		public List<PoliceOfficer> Pursuers;

		public float TimeSincePursuitStart;

		public float CurrentPursuitLevelDuration;

		public float TimeSinceSighted;

		public Dictionary<Crime, int> Crimes;

		public bool BodySearchPending;

		public float timeSinceLastShot;

		protected List<VehicleCollisionInstance> Collisions;

		private MusicTrack _lightCombatTrack;

		private MusicTrack _heavyCombatTrack;

		private float outOfSightTimeToDipMusic;

		private float minMusicVolume;

		private float musicChangeRate_Down;

		private float musicChangeRate_Up;

		public SyncVar<EPursuitLevel> syncVar____003CCurrentPursuitLevel_003Ek__BackingField;

		public SyncVar<Vector3> syncVar____003CLastKnownPosition_003Ek__BackingField;

		private bool NetworkInitialize___EarlyScheduleOne_002EPlayerScripts_002EPlayerCrimeDataAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EPlayerScripts_002EPlayerCrimeDataAssembly_002DCSharp_002Edll_Excuted;

		[field: SyncVar(SendRate = 0.5f, WritePermissions = WritePermission.ClientUnsynchronized)]
		public EPursuitLevel CurrentPursuitLevel
		{
			get; [ServerRpc(RunLocally = true)]
			protected set;
		}

		[field: SyncVar(SendRate = 0.5f, WritePermissions = WritePermission.ClientUnsynchronized)]
		public Vector3 LastKnownPosition
		{
			get; [ServerRpc(RunLocally = true)]
			protected set;
		}

		public float CurrentArrestProgress { get; protected set; }

		public float CurrentBodySearchProgress { get; protected set; }

		public float TimeSinceLastBodySearch { get; set; }

		public bool EvadedArrest { get; protected set; }

		public EPursuitLevel SyncAccessor__003CCurrentPursuitLevel_003Ek__BackingField
		{
			get
			{
				return default(EPursuitLevel);
			}
			set
			{
			}
		}

		public Vector3 SyncAccessor__003CLastKnownPosition_003Ek__BackingField
		{
			get
			{
				return default(Vector3);
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

		protected virtual void LateUpdate()
		{
		}

		public void SetPursuitLevel(EPursuitLevel level)
		{
		}

		public void Escalate()
		{
		}

		public void Deescalate()
		{
		}

		[ObserversRpc(RunLocally = true)]
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

		public void AddCrime(Crime crime, int quantity = 1)
		{
		}

		public void ClearCrimes()
		{
		}

		public bool IsCrimeOnRecord(Type crime)
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

		public void RecordVehicleCollision(NPC victim)
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

		private void RpcWriter___Server_set_CurrentPursuitLevel_2979171596(EPursuitLevel value)
		{
		}

		[SpecialName]
		protected void RpcLogic___set_CurrentPursuitLevel_2979171596(EPursuitLevel value)
		{
		}

		private void RpcReader___Server_set_CurrentPursuitLevel_2979171596(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_set_LastKnownPosition_4276783012(Vector3 value)
		{
		}

		[SpecialName]
		protected void RpcLogic___set_LastKnownPosition_4276783012(Vector3 value)
		{
		}

		private void RpcReader___Server_set_LastKnownPosition_4276783012(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
		}

		public void RpcLogic___RecordLastKnownPosition_1140765316(bool resetTimeSinceSighted)
		{
		}

		private void RpcReader___Observers_RecordLastKnownPosition_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		public virtual bool ReadSyncVar___ScheduleOne_002EPlayerScripts_002EPlayerCrimeData(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return false;
		}

		private void Awake_UserLogic_ScheduleOne_002EPlayerScripts_002EPlayerCrimeData_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
