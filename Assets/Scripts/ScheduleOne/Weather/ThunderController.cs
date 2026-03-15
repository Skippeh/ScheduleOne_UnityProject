namespace ScheduleOne.Weather
{
	public class ThunderController : global::ScheduleOne.Weather.WeatherEffectController
	{
		private const float _npcLightningStrikeDistanceFromPlayer = 40f;

		[global::UnityEngine.Header("Thunder Settings")]
		[global::UnityEngine.SerializeField]
		private float _maxThunderDelay;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2 _timeBetweenThunders;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _chanceForLightingStrike;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _chanceForLightingToHitPlayer;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _chanceForLightingToHitNPC;

		private float _sqrDistanceToPlayer;

		private float _thundertimer;

		private float _timeUntilNextThunder;

		private float _effectNormalisedDistanceToPlayer;

		private global::ScheduleOne.Audio.RandomizedAudioSourceController _thunderAudio;

		private global::ScheduleOne.Audio.RandomizedAudioSourceController _lightningAudio;

		private global::ScheduleOne.Effects.VFXEffectHandler _lightningEffect;

		private global::ScheduleOne.Effects.VFXEffectHandler _thunderEffect;

		private global::UnityEngine.Vector3 _debugThunderLocation;

		private bool NetworkInitialize___EarlyScheduleOne_002EWeather_002EThunderControllerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EWeather_002EThunderControllerAssembly_002DCSharp_002Edll_Excuted;

		public override void Awake()
		{
		}

		private void Start()
		{
		}

		protected override void Update()
		{
		}

		[global::ScheduleOne.Core.Button]
		private void TriggerThunder()
		{
		}

		public void TriggerRandomLightningStrike()
		{
		}

		public void TriggerRandomPlayerLightningStrike()
		{
		}

		public void TriggerPlayerLightningStrike(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public void TriggerRandomNPCLightningStrike()
		{
		}

		public void TriggerNPCLightningStrike(global::ScheduleOne.NPCs.NPC targetNPC)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void TriggerLightningStrike_Server(global::UnityEngine.Vector3 position)
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void TriggerLightningStrike_Client(global::UnityEngine.Vector3 position)
		{
		}

		public void TriggerDistantThunder()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void TriggerDistantThunder_Client(global::UnityEngine.Vector3 location)
		{
		}

		private void RandomiseThunderTimer()
		{
		}

		public override void UpdateAudio()
		{
		}

		private global::UnityEngine.Vector3 GetRandomPointInVolume()
		{
			return default(global::UnityEngine.Vector3);
		}

		private void UpdateAudio(global::ScheduleOne.Audio.AudioSourceController audioSource, bool useEffectDistance)
		{
		}

		public override void UpdateProperties(global::UnityEngine.Vector3 anchorPosition, global::UnityEngine.Vector3 playerPosition, float sqrDistanceToPlayer, float enclosureBlend)
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

		private void RpcWriter___Server_TriggerLightningStrike_Server_4276783012(global::UnityEngine.Vector3 position)
		{
		}

		private void RpcLogic___TriggerLightningStrike_Server_4276783012(global::UnityEngine.Vector3 position)
		{
		}

		private void RpcReader___Server_TriggerLightningStrike_Server_4276783012(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_TriggerLightningStrike_Client_4276783012(global::UnityEngine.Vector3 position)
		{
		}

		private void RpcLogic___TriggerLightningStrike_Client_4276783012(global::UnityEngine.Vector3 position)
		{
		}

		private void RpcReader___Observers_TriggerLightningStrike_Client_4276783012(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_TriggerDistantThunder_Client_4276783012(global::UnityEngine.Vector3 location)
		{
		}

		private void RpcLogic___TriggerDistantThunder_Client_4276783012(global::UnityEngine.Vector3 location)
		{
		}

		private void RpcReader___Observers_TriggerDistantThunder_Client_4276783012(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EWeather_002EThunderController_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
