namespace ScheduleOne.NPCs.Responses
{
	public class NPCResponses_Civilian : global::ScheduleOne.NPCs.Responses.NPCResponses
	{
		public enum EAttackResponse
		{
			None = 0,
			Panic = 1,
			Flee = 2,
			CallPolice = 3,
			Fight = 4
		}

		public enum EThreatType
		{
			None = 0,
			AimedAt = 1,
			GunshotHeard = 2,
			ExplosionHeard = 3
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CResetAttackResponse_003Ed__10 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.NPCs.Responses.NPCResponses_Civilian _003C_003E4__this;

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
			public _003CResetAttackResponse_003Ed__10(int _003C_003E1__state)
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

		[global::UnityEngine.Header("Response Settings")]
		public bool CanCallPolice;

		public bool OverrideThreatResponses;

		public global::ScheduleOne.NPCs.Responses.NPCResponses_Civilian.EAttackResponse ThreatResponseOverride;

		private global::ScheduleOne.NPCs.Responses.NPCResponses_Civilian.EAttackResponse currentThreatResponse;

		private float lastThreatTime;

		private global::UnityEngine.Coroutine resetCoroutine;

		protected override void Awake()
		{
		}

		private void ScheduleResetCoroutine()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.NPCs.Responses.NPCResponses_Civilian._003CResetAttackResponse_003Ed__10))]
		private global::System.Collections.IEnumerator ResetAttackResponse()
		{
			return null;
		}

		public override void GunshotHeard(global::ScheduleOne.Noise.NoiseEvent gunshotSound)
		{
		}

		public override void ExplosionHeard(global::ScheduleOne.Noise.NoiseEvent explosionSound)
		{
		}

		public override void PlayerFailedPickpocket(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		protected override void RespondToFirstNonLethalAttack(global::ScheduleOne.PlayerScripts.Player perpetrator, global::ScheduleOne.Combat.Impact impact)
		{
		}

		protected override void RespondToAnnoyingImpact(global::ScheduleOne.PlayerScripts.Player perpetrator, global::ScheduleOne.Combat.Impact impact)
		{
		}

		protected override void RespondToLethalAttack(global::ScheduleOne.PlayerScripts.Player perpetrator, global::ScheduleOne.Combat.Impact impact)
		{
		}

		protected override void RespondToRepeatedNonLethalAttack(global::ScheduleOne.PlayerScripts.Player perpetrator, global::ScheduleOne.Combat.Impact impact)
		{
		}

		private void RespondToLethalOrRepeatedAttack(global::ScheduleOne.PlayerScripts.Player perpetrator, global::ScheduleOne.Combat.Impact impact)
		{
		}

		public override void RespondToAimedAt(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		private void ExecuteThreatResponse(global::ScheduleOne.NPCs.Responses.NPCResponses_Civilian.EAttackResponse response, global::ScheduleOne.PlayerScripts.Player target, global::UnityEngine.Vector3 threatOrigin, global::ScheduleOne.Law.Crime crime = null)
		{
		}

		private global::ScheduleOne.NPCs.Responses.NPCResponses_Civilian.EAttackResponse GetThreatResponse(global::ScheduleOne.NPCs.Responses.NPCResponses_Civilian.EThreatType type, global::ScheduleOne.PlayerScripts.Player threatSource)
		{
			return default(global::ScheduleOne.NPCs.Responses.NPCResponses_Civilian.EAttackResponse);
		}
	}
}
