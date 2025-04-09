using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	public class Sprinkler : GridItem
	{
		[Header("References")]
		public InteractableObject IntObj;

		public ParticleSystem[] WaterParticles;

		public AudioSourceController ClickSound;

		public AudioSourceController WaterSound;

		[Header("Settings")]
		public float ApplyWaterDelay;

		public float ParticleStopDelay;

		public UnityEvent onSprinklerStart;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002ESprinklerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002ESprinklerAssembly_002DCSharp_002Edll_Excuted;

		public bool IsSprinkling { get; private set; }

		public void Hovered()
		{
		}

		public void Interacted()
		{
		}

		private bool CanWater()
		{
			return false;
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendWater()
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void Water()
		{
		}

		public void ApplyWater(float normalizedAmount)
		{
		}

		protected virtual List<Pot> GetPots()
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

		private void RpcWriter___Server_SendWater_2166136261()
		{
		}

		private void RpcLogic___SendWater_2166136261()
		{
		}

		private void RpcReader___Server_SendWater_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Water_2166136261()
		{
		}

		private void RpcLogic___Water_2166136261()
		{
		}

		private void RpcReader___Observers_Water_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
