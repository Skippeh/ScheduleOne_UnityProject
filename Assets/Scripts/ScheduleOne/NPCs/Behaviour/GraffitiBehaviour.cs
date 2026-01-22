namespace ScheduleOne.NPCs.Behaviour
{
	public class GraffitiBehaviour : global::ScheduleOne.NPCs.Behaviour.Behaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDoEffectRoutine_003Ed__27 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.NPCs.Behaviour.GraffitiBehaviour _003C_003E4__this;

			private int _003CsafetyCounter_003E5__2;

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
			public _003CDoEffectRoutine_003Ed__27(int _003C_003E1__state)
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

		public const int InterruptionXP = 50;

		public const float InterruptionCartelInfluenceChange = -0.1f;

		[global::UnityEngine.Header("Graffiti: Components")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.NPCs.Other.SprayPaint _sprayPaint;

		[global::UnityEngine.Header("Graffiti: Settings")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2Int _graffitiDurationInMinutes;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2 _minMaxEffectLoopDuration;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2 _minMaxEffectPauseDuration;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Gradient _effectColorGradient;

		[global::UnityEngine.Header("Graffiti: Drawings")]
		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SerializedGraffitiDrawing> _drawinglist;

		[global::UnityEngine.Header("Graffiti: Interruptions")]
		[global::UnityEngine.SerializeField]
		private global::System.Collections.Generic.List<global::ScheduleOne.NPCs.Behaviour.Behaviour> _interruptingBehaviours;

		[global::UnityEngine.Header("Debugging & Development")]
		[global::UnityEngine.SerializeField]
		private bool _debugMode;

		private int _duration;

		private global::UnityEngine.Coroutine _effectCoroutine;

		private global::ScheduleOne.Graffiti.WorldSpraySurface _spraySurface;

		private bool _graffitiCompleted;

		private bool NetworkInitialize___EarlyScheduleOne_002ENPCs_002EBehaviour_002EGraffitiBehaviourAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002ENPCs_002EBehaviour_002EGraffitiBehaviourAssembly_002DCSharp_002Edll_Excuted;

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public override void Enable()
		{
		}

		public override void Disable()
		{
		}

		public override void Activate()
		{
		}

		public override void Pause()
		{
		}

		public override void Deactivate()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		private void Complete_Server()
		{
		}

		private void CheckForInterruptions()
		{
		}

		private void SetupEvents()
		{
		}

		private void CleanUp()
		{
		}

		private void OnMinPass()
		{
		}

		private void OnTimePass(int minutes)
		{
		}

		private void StopEffectRoutine()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.NPCs.Behaviour.GraffitiBehaviour._003CDoEffectRoutine_003Ed__27))]
		private global::System.Collections.IEnumerator DoEffectRoutine()
		{
			return null;
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void SetSpraySurface_Client(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject surface)
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

		private void RpcWriter___Server_Complete_Server_2166136261()
		{
		}

		private void RpcLogic___Complete_Server_2166136261()
		{
		}

		private void RpcReader___Server_Complete_Server_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetSpraySurface_Client_1824087381(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject surface)
		{
		}

		public void RpcLogic___SetSpraySurface_Client_1824087381(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject surface)
		{
		}

		private void RpcReader___Observers_SetSpraySurface_Client_1824087381(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		public override void Awake()
		{
		}
	}
}
