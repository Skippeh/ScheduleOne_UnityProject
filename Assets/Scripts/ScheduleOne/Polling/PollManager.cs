namespace ScheduleOne.Polling
{
	public class PollManager : global::UnityEngine.MonoBehaviour
	{
		public enum EPollSubmissionResult
		{
			InProgress = 0,
			Success = 1,
			Failed = 2
		}

		[global::System.Runtime.InteropServices.StructLayout(global::System.Runtime.InteropServices.LayoutKind.Auto)]
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private struct _003CInitAppTicket_003Ed__30 : global::System.Runtime.CompilerServices.IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder _003C_003Et__builder;

			public global::ScheduleOne.Polling.PollManager _003C_003E4__this;

			private global::System.Runtime.CompilerServices.TaskAwaiter<string> _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void global::System.Runtime.CompilerServices.IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			private void SetStateMachine(global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
			}

			void global::System.Runtime.CompilerServices.IAsyncStateMachine.SetStateMachine(global::System.Runtime.CompilerServices.IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CRequestPoll_003Ed__32 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public string url;

			public global::System.Action<string> callback;

			private global::UnityEngine.Networking.UnityWebRequest _003Crequest_003E5__2;

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
			public _003CRequestPoll_003Ed__32(int _003C_003E1__state)
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

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CSubmitAnswerToServer_003Ed__31 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Polling.PollAnswer answer;

			public global::ScheduleOne.Polling.PollManager _003C_003E4__this;

			private global::UnityEngine.Networking.UnityWebRequest _003Creq_003E5__2;

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
			public _003CSubmitAnswerToServer_003Ed__31(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		public const string SERVER_URL = "https://us-central1-s1-polling-987345.cloudfunctions.net/poll";

		private global::Steamworks.CallResult<global::Steamworks.EncryptedAppTicketResponse_t> appTicketCallbackResponse;

		private global::System.Threading.Tasks.TaskCompletionSource<string> tokenCompletion;

		private global::ScheduleOne.Polling.PollResponse receivedPollResponse;

		private int sentResponse;

		private string appTicket;

		public global::System.Action<global::ScheduleOne.Polling.PollData> onActivePollReceived;

		public global::System.Action<global::ScheduleOne.Polling.PollData> onConfirmedPollReceived;

		private bool appTicketRequested;

		public global::ScheduleOne.Polling.PollData ActivePoll { get; private set; }

		public global::ScheduleOne.Polling.PollData ConfirmedPoll { get; private set; }

		public global::ScheduleOne.Polling.PollManager.EPollSubmissionResult SubmissionResult { get; private set; }

		public string SubmisssionFailedMesssage { get; private set; }

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void GenerateAppTicket()
		{
		}

		public void SelectPollResponse(int responseIndex)
		{
		}

		[global::System.Runtime.CompilerServices.AsyncStateMachine(typeof(global::ScheduleOne.Polling.PollManager._003CInitAppTicket_003Ed__30))]
		private global::System.Threading.Tasks.Task InitAppTicket()
		{
			return null;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Polling.PollManager._003CSubmitAnswerToServer_003Ed__31))]
		private global::System.Collections.IEnumerator SubmitAnswerToServer(global::ScheduleOne.Polling.PollAnswer answer)
		{
			return null;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Polling.PollManager._003CRequestPoll_003Ed__32))]
		private global::System.Collections.IEnumerator RequestPoll(string url, global::System.Action<string> callback = null)
		{
			return null;
		}

		private void ResponseCallback(string data)
		{
		}

		private void OnEncryptedAppTicketResponse(global::Steamworks.EncryptedAppTicketResponse_t response, bool ioFailure)
		{
		}

		private global::System.Threading.Tasks.Task<string> GetAppTicket()
		{
			return null;
		}

		private static string CleanTicket(string ticket)
		{
			return null;
		}

		public static bool TryGetExistingPollResponse(int pollId, out int response)
		{
			response = default(int);
			return false;
		}

		private static void RecordSubmission(int pollId, int response)
		{
		}
	}
}
