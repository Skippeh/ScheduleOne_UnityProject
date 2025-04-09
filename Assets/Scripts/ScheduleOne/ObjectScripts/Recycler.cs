using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.Audio;
using ScheduleOne.Interaction;
using ScheduleOne.Misc;
using ScheduleOne.Trash;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	public class Recycler : NetworkBehaviour
	{
		public enum EState
		{
			HatchClosed = 0,
			HatchOpen = 1,
			Processing = 2
		}

		[CompilerGenerated]
		private sealed class _003CProcess_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Recycler _003C_003E4__this;

			public bool startedByLocalPlayer;

			private float _003Cvalue_003E5__2;

			private float _003ClerpTime_003E5__3;

			private float _003Ci_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CProcess_003Ed__45(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public LayerMask DetectionMask;

		[Header("References")]
		public InteractableObject HandleIntObj;

		public InteractableObject ButtonIntObj;

		public InteractableObject CashIntObj;

		public ToggleableLight ButtonLight;

		public Animation ButtonAnim;

		public Animation HatchAnim;

		public Animation CashAnim;

		public RectTransform OpenHatchInstruction;

		public RectTransform InsertTrashInstruction;

		public RectTransform PressBeginInstruction;

		public RectTransform ProcessingScreen;

		public TextMeshProUGUI ProcessingLabel;

		public TextMeshProUGUI ValueLabel;

		public BoxCollider CheckCollider;

		public Transform Cash;

		public GameObject BankNote;

		[Header("Sound")]
		public AudioSourceController OpenSound;

		public AudioSourceController CloseSound;

		public AudioSourceController PressSound;

		public AudioSourceController DoneSound;

		public AudioSourceController CashEjectSound;

		private float cashValue;

		public UnityEvent onStart;

		public UnityEvent onStop;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002ERecyclerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002ERecyclerAssembly_002DCSharp_002Edll_Excuted;

		public EState State { get; protected set; }

		public bool IsHatchOpen { get; private set; }

		public void Start()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		private void OnDestroy()
		{
		}

		private void MinPass()
		{
		}

		public void HandleInteracted()
		{
		}

		public void ButtonInteracted()
		{
		}

		public void CashInteracted()
		{
		}

		[ServerRpc(RequireOwnership = false)]
		private void SendCashCollected()
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void CashCollected()
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void EnableCash()
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetCashValue(float amount)
		{
		}

		[IteratorStateMachine(typeof(_003CProcess_003Ed__45))]
		private IEnumerator Process(bool startedByLocalPlayer)
		{
			return null;
		}

		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendState(EState state)
		{
		}

		[ObserversRpc(RunLocally = true)]
		[TargetRpc]
		private void SetState(NetworkConnection conn, EState state, bool force = false)
		{
		}

		private void SetHatchOpen(bool open)
		{
		}

		private TrashItem[] GetTrash()
		{
			return null;
		}

		private void OnDrawGizmos()
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

		private void RpcWriter___Server_SendCashCollected_2166136261()
		{
		}

		private void RpcLogic___SendCashCollected_2166136261()
		{
		}

		private void RpcReader___Server_SendCashCollected_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_CashCollected_2166136261()
		{
		}

		private void RpcLogic___CashCollected_2166136261()
		{
		}

		private void RpcReader___Observers_CashCollected_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_EnableCash_2166136261()
		{
		}

		private void RpcLogic___EnableCash_2166136261()
		{
		}

		private void RpcReader___Observers_EnableCash_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_SetCashValue_431000436(float amount)
		{
		}

		private void RpcLogic___SetCashValue_431000436(float amount)
		{
		}

		private void RpcReader___Observers_SetCashValue_431000436(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SendState_3569965459(EState state)
		{
		}

		public void RpcLogic___SendState_3569965459(EState state)
		{
		}

		private void RpcReader___Server_SendState_3569965459(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetState_3790170803(NetworkConnection conn, EState state, bool force = false)
		{
		}

		private void RpcLogic___SetState_3790170803(NetworkConnection conn, EState state, bool force = false)
		{
		}

		private void RpcReader___Observers_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetState_3790170803(NetworkConnection conn, EState state, bool force = false)
		{
		}

		private void RpcReader___Target_SetState_3790170803(PooledReader PooledReader0, Channel channel)
		{
		}

		public virtual void Awake()
		{
		}
	}
}
