using System;
using System.Collections.Generic;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using UnityEngine;

namespace ScheduleOne.PlayerScripts
{
	public class PlayerVisualState : NetworkBehaviour
	{
		public enum EVisualState
		{
			Visible = 0,
			Suspicious = 1,
			DisobeyingCurfew = 2,
			Vandalizing = 3,
			PettyCrime = 4,
			DrugDealing = 5,
			SearchedFor = 6,
			Wanted = 7,
			Pickpocketing = 8,
			DischargingWeapon = 9,
			Brandishing = 10
		}

		[Serializable]
		public class VisualState
		{
			public EVisualState state;

			public string label;

			public Action stateDestroyed;
		}

		public float Suspiciousness;

		public List<VisualState> visualStates;

		private Player player;

		private Dictionary<string, Coroutine> removalRoutinesDict;

		private bool NetworkInitialize___EarlyScheduleOne_002EPlayerScripts_002EPlayerVisualStateAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EPlayerScripts_002EPlayerVisualStateAssembly_002DCSharp_002Edll_Excuted;

		public virtual void Awake()
		{
		}

		private void Update()
		{
		}

		[ServerRpc(RunLocally = true)]
		public void ApplyState(string label, EVisualState state, float autoRemoveAfter = 0f)
		{
		}

		[ServerRpc(RunLocally = true)]
		public void RemoveState(string label, float delay = 0f)
		{
		}

		public VisualState GetState(string label)
		{
			return null;
		}

		public void ClearStates()
		{
		}

		private void UpdateSuspiciousness()
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

		private void RpcWriter___Server_ApplyState_868472085(string label, EVisualState state, float autoRemoveAfter = 0f)
		{
		}

		public void RpcLogic___ApplyState_868472085(string label, EVisualState state, float autoRemoveAfter = 0f)
		{
		}

		private void RpcReader___Server_ApplyState_868472085(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_RemoveState_606697822(string label, float delay = 0f)
		{
		}

		public void RpcLogic___RemoveState_606697822(string label, float delay = 0f)
		{
		}

		private void RpcReader___Server_RemoveState_606697822(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002EPlayerScripts_002EPlayerVisualState_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
