namespace ScheduleOne.ObjectScripts
{
	public class Recycler : global::FishNet.Object.NetworkBehaviour
	{
		public enum EState
		{
			HatchClosed = 0,
			HatchOpen = 1,
			Processing = 2
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CProcess_003Ed__45 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.ObjectScripts.Recycler _003C_003E4__this;

			public bool startedByLocalPlayer;

			private float _003Cvalue_003E5__2;

			private float _003ClerpTime_003E5__3;

			private float _003Ci_003E5__4;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CProcess_003Ed__45(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		public global::UnityEngine.LayerMask DetectionMask;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Interaction.InteractableObject HandleIntObj;

		public global::ScheduleOne.Interaction.InteractableObject ButtonIntObj;

		public global::ScheduleOne.Interaction.InteractableObject CashIntObj;

		public global::ScheduleOne.Misc.ToggleableLight ButtonLight;

		public global::UnityEngine.Animation ButtonAnim;

		public global::UnityEngine.Animation HatchAnim;

		public global::UnityEngine.Animation CashAnim;

		public global::UnityEngine.RectTransform OpenHatchInstruction;

		public global::UnityEngine.RectTransform InsertTrashInstruction;

		public global::UnityEngine.RectTransform PressBeginInstruction;

		public global::UnityEngine.RectTransform ProcessingScreen;

		public global::TMPro.TextMeshProUGUI ProcessingLabel;

		public global::TMPro.TextMeshProUGUI ValueLabel;

		public global::UnityEngine.BoxCollider CheckCollider;

		public global::UnityEngine.Transform Cash;

		public global::UnityEngine.GameObject BankNote;

		[global::UnityEngine.Header("Sound")]
		public global::ScheduleOne.Audio.AudioSourceController OpenSound;

		public global::ScheduleOne.Audio.AudioSourceController CloseSound;

		public global::ScheduleOne.Audio.AudioSourceController PressSound;

		public global::ScheduleOne.Audio.AudioSourceController DoneSound;

		public global::ScheduleOne.Audio.AudioSourceController CashEjectSound;

		private float cashValue;

		public global::UnityEngine.Events.UnityEvent onStart;

		public global::UnityEngine.Events.UnityEvent onStop;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002ERecyclerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002ERecyclerAssembly_002DCSharp_002Edll_Excuted;

		public global::ScheduleOne.ObjectScripts.Recycler.EState State { get; protected set; }

		public bool IsHatchOpen { get; private set; }

		public void Start()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		private void OnDestroy()
		{
		}

		private void OnTick()
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

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void SendCashCollected()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void CashCollected()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void EnableCash()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetCashValue(float amount)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.ObjectScripts.Recycler._003CProcess_003Ed__45))]
		private global::System.Collections.IEnumerator Process(bool startedByLocalPlayer)
		{
			return null;
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendState(global::ScheduleOne.ObjectScripts.Recycler.EState state)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetState(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.Recycler.EState state, bool force = false)
		{
		}

		private void SetHatchOpen(bool open)
		{
		}

		private global::ScheduleOne.Trash.TrashItem[] GetTrash()
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

		private void RpcReader___Server_SendCashCollected_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_CashCollected_2166136261()
		{
		}

		private void RpcLogic___CashCollected_2166136261()
		{
		}

		private void RpcReader___Observers_CashCollected_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_EnableCash_2166136261()
		{
		}

		private void RpcLogic___EnableCash_2166136261()
		{
		}

		private void RpcReader___Observers_EnableCash_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetCashValue_431000436(float amount)
		{
		}

		private void RpcLogic___SetCashValue_431000436(float amount)
		{
		}

		private void RpcReader___Observers_SetCashValue_431000436(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SendState_3569965459(global::ScheduleOne.ObjectScripts.Recycler.EState state)
		{
		}

		public void RpcLogic___SendState_3569965459(global::ScheduleOne.ObjectScripts.Recycler.EState state)
		{
		}

		private void RpcReader___Server_SendState_3569965459(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetState_3790170803(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.Recycler.EState state, bool force = false)
		{
		}

		private void RpcLogic___SetState_3790170803(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.Recycler.EState state, bool force = false)
		{
		}

		private void RpcReader___Observers_SetState_3790170803(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetState_3790170803(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.Recycler.EState state, bool force = false)
		{
		}

		private void RpcReader___Target_SetState_3790170803(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public virtual void Awake()
		{
		}
	}
}
