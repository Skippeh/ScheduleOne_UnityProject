namespace ScheduleOne.GameTime
{
	public class TimeManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.GameTime.TimeManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CStaggeredMinPass_003Ed__105 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.GameTime.TimeManager _003C_003E4__this;

			public float staggerTime;

			private global::System.Collections.Generic.List<global::System.Action> _003Clisteners_003E5__2;

			private float _003CperDelay_003E5__3;

			private float _003CstartTime_003E5__4;

			private float _003CwaitOverflow_003E5__5;

			private float _003CtimeOnWaitStart_003E5__6;

			private int _003CloopsSinceLastWait_003E5__7;

			private int _003Ci_003E5__8;

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
			public _003CStaggeredMinPass_003Ed__105(int _003C_003E1__state)
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
		private sealed class _003CTickLoop_003Ed__103 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.GameTime.TimeManager _003C_003E4__this;

			private float _003ClastWaitExcess_003E5__2;

			private float _003CtimeToWait_003E5__3;

			private float _003CtimeOnWaitStart_003E5__4;

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
			public _003CTickLoop_003Ed__103(int _003C_003E1__state)
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
		private sealed class _003CTimeLoop_003Ed__104 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.GameTime.TimeManager _003C_003E4__this;

			private float _003ClastWaitExcess_003E5__2;

			private float _003CtimeToWait_003E5__3;

			private float _003CtimeOnWaitStart_003E5__4;

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
			public _003CTimeLoop_003Ed__104(int _003C_003E1__state)
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

		public const float CYCLE_DURATION_MINS = 24f;

		public const float MINUTE_TIME = 1f;

		public const int DEFAULT_WAKE_TIME = 700;

		public const int END_OF_DAY = 400;

		public int DefaultTime;

		public global::ScheduleOne.GameTime.EDay DefaultDay;

		public float TimeProgressionMultiplier;

		private int savedTime;

		public ActionList onMinutePass;

		public global::System.Action onHourPass;

		public global::System.Action onDayPass;

		public global::System.Action onWeekPass;

		public global::System.Action onUpdate;

		public global::System.Action onFixedUpdate;

		public global::System.Action<int> onTimeSkip;

		public global::System.Action onUnscaledMinPass;

		public global::System.Action onTick;

		public global::System.Action onTimeChanged;

		public global::System.Action onSleepStart;

		public global::System.Action onSleepEnd;

		public global::UnityEngine.Events.UnityEvent onFirstNight;

		public const int SelectedWakeTime = 700;

		private global::ScheduleOne.GameTime.GameDateTime sleepStartTime;

		private int sleepEndTime;

		private float defaultFixedTimeScale;

		private global::ScheduleOne.Persistence.Loaders.TimeLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002EGameTime_002ETimeManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EGameTime_002ETimeManagerAssembly_002DCSharp_002Edll_Excuted;

		public bool IsEndOfDay => false;

		public bool SleepInProgress { get; protected set; }

		public int ElapsedDays { get; protected set; }

		public int CurrentTime { get; protected set; }

		public float TimeOnCurrentMinute { get; protected set; }

		public int DailyMinTotal { get; protected set; }

		public bool IsNight => false;

		public int DayIndex => 0;

		public float NormalizedTime => 0f;

		public float Playtime { get; protected set; }

		public global::ScheduleOne.GameTime.EDay CurrentDay => default(global::ScheduleOne.GameTime.EDay);

		public bool TimeOverridden { get; protected set; }

		public bool HostDailySummaryDone { get; private set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public global::ScheduleOne.Persistence.Loaders.Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public global::System.Collections.Generic.List<string> LocalExtraFiles { get; set; }

		public global::System.Collections.Generic.List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public int LoadOrder { get; }

		public override void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public override void OnStartClient()
		{
		}

		private void Clean()
		{
		}

		public void SendTimeData(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true, ExcludeServer = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetData(global::FishNet.Connection.NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void ResetHostSleepDone()
		{
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void MarkHostSleepDone()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetHostSleepDone(bool done)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.GameTime.TimeManager._003CTickLoop_003Ed__103))]
		private global::System.Collections.IEnumerator TickLoop()
		{
			return null;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.GameTime.TimeManager._003CTimeLoop_003Ed__104))]
		private global::System.Collections.IEnumerator TimeLoop()
		{
			return null;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.GameTime.TimeManager._003CStaggeredMinPass_003Ed__105))]
		private global::System.Collections.IEnumerator StaggeredMinPass(float staggerTime)
		{
			return null;
		}

		private void Tick()
		{
		}

		public void SetTime(int _time, bool local = false)
		{
		}

		public void SetElapsedDays(int days)
		{
		}

		public static string Get12HourTime(float _time, bool appendDesignator = true)
		{
			return null;
		}

		public static int Get24HourTimeFromMinSum(int minSum)
		{
			return 0;
		}

		public static int GetMinSumFrom24HourTime(int _time)
		{
			return 0;
		}

		public bool IsCurrentTimeWithinRange(int min, int max)
		{
			return false;
		}

		public static bool IsGivenTimeWithinRange(int givenTime, int min, int max)
		{
			return false;
		}

		public static bool IsValid24HourTime(string input)
		{
			return false;
		}

		public bool IsCurrentDateWithinRange(global::ScheduleOne.GameTime.GameDateTime start, global::ScheduleOne.GameTime.GameDateTime end)
		{
			return false;
		}

		[global::FishNet.Object.ObserversRpc]
		private void InvokeDayPassClientSide()
		{
		}

		[global::FishNet.Object.ObserversRpc]
		private void InvokeWeekPassClientSide()
		{
		}

		public void FastForwardToWakeTime()
		{
		}

		public global::ScheduleOne.GameTime.GameDateTime GetDateTime()
		{
			return default(global::ScheduleOne.GameTime.GameDateTime);
		}

		public int GetTotalMinSum()
		{
			return 0;
		}

		public static int AddMinutesTo24HourTime(int time, int minsToAdd)
		{
			return 0;
		}

		public static global::System.Collections.Generic.List<int> GetAllTimeInRange(int min, int max)
		{
			return null;
		}

		[global::FishNet.Object.ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetWakeTime(int amount)
		{
		}

		public void ForceSleep()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void StartSleep()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void EndSleep()
		{
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public void SetPlaytime(float time)
		{
		}

		public void SetTimeOverridden(bool overridden, int time = 1200)
		{
		}

		private void SetRandomTime()
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

		private void RpcWriter___Observers_SetData_2661156041(global::FishNet.Connection.NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
		}

		private void RpcLogic___SetData_2661156041(global::FishNet.Connection.NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
		}

		private void RpcReader___Observers_SetData_2661156041(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetData_2661156041(global::FishNet.Connection.NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
		}

		private void RpcReader___Target_SetData_2661156041(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_ResetHostSleepDone_2166136261()
		{
		}

		public void RpcLogic___ResetHostSleepDone_2166136261()
		{
		}

		private void RpcReader___Server_ResetHostSleepDone_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_MarkHostSleepDone_2166136261()
		{
		}

		public void RpcLogic___MarkHostSleepDone_2166136261()
		{
		}

		private void RpcReader___Server_MarkHostSleepDone_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetHostSleepDone_1140765316(bool done)
		{
		}

		private void RpcLogic___SetHostSleepDone_1140765316(bool done)
		{
		}

		private void RpcReader___Observers_SetHostSleepDone_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_InvokeDayPassClientSide_2166136261()
		{
		}

		private void RpcLogic___InvokeDayPassClientSide_2166136261()
		{
		}

		private void RpcReader___Observers_InvokeDayPassClientSide_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_InvokeWeekPassClientSide_2166136261()
		{
		}

		private void RpcLogic___InvokeWeekPassClientSide_2166136261()
		{
		}

		private void RpcReader___Observers_InvokeWeekPassClientSide_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_SetWakeTime_3316948804(int amount)
		{
		}

		public void RpcLogic___SetWakeTime_3316948804(int amount)
		{
		}

		private void RpcReader___Server_SetWakeTime_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_StartSleep_2166136261()
		{
		}

		private void RpcLogic___StartSleep_2166136261()
		{
		}

		private void RpcReader___Observers_StartSleep_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_EndSleep_2166136261()
		{
		}

		private void RpcLogic___EndSleep_2166136261()
		{
		}

		private void RpcReader___Observers_EndSleep_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EGameTime_002ETimeManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
