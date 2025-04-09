using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	public class SoilPourer : GridItem
	{
		public float AnimationDuration;

		[Header("References")]
		public InteractableObject HandleIntObj;

		public InteractableObject FillIntObj;

		public MeshRenderer DirtPlane;

		public Transform Dirt_Min;

		public Transform Dirt_Max;

		public ParticleSystem PourParticles;

		public Animation PourAnimation;

		public AudioSourceController FillSound;

		public AudioSourceController ActivateSound;

		public AudioSourceController DirtPourSound;

		private bool isDispensing;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002ESoilPourerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002ESoilPourerAssembly_002DCSharp_002Edll_Excuted;

		public string SoilID { get; protected set; }

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public void HandleHovered()
		{
		}

		public void HandleInteracted()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		private void SendPourSoil()
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void PourSoil()
		{
		}

		private void ApplySoil(string ID)
		{
		}

		public void FillHovered()
		{
		}

		public void FillInteracted()
		{
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendSoil(string ID)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		protected void SetSoil(NetworkConnection conn, string ID)
		{
		}

		public void SetSoilLevel(float level)
		{
		}

		protected virtual List<Pot> GetPots()
		{
			return null;
		}

		public override string GetSaveString()
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

		private void RpcWriter___Server_SendPourSoil_2166136261()
		{
		}

		private void RpcLogic___SendPourSoil_2166136261()
		{
		}

		private void RpcReader___Server_SendPourSoil_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_PourSoil_2166136261()
		{
		}

		private void RpcLogic___PourSoil_2166136261()
		{
		}

		private void RpcReader___Observers_PourSoil_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendSoil_3615296227(string ID)
		{
		}

		public void RpcLogic___SendSoil_3615296227(string ID)
		{
		}

		private void RpcReader___Server_SendSoil_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetSoil_2971853958(NetworkConnection conn, string ID)
		{
		}

		protected void RpcLogic___SetSoil_2971853958(NetworkConnection conn, string ID)
		{
		}

		private void RpcReader___Observers_SetSoil_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetSoil_2971853958(NetworkConnection conn, string ID)
		{
		}

		private void RpcReader___Target_SetSoil_2971853958(PooledReader PooledReader0, Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
