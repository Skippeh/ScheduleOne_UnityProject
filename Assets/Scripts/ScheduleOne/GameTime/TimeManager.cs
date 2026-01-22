namespace ScheduleOne.GameTime
{
	public class TimeManager : global::ScheduleOne.DevUtilities.NetworkSingleton<global::ScheduleOne.GameTime.TimeManager>, global::ScheduleOne.Persistence.IBaseSaveable, global::ScheduleOne.Persistence.ISaveable
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CTickLoop_003Ed__104 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
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
			public _003CTickLoop_003Ed__104(int _003C_003E1__state)
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
		private sealed class _003CTimeLoop_003Ed__105 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.GameTime.TimeManager _003C_003E4__this;

			private float _003CtimeToWait_003E5__2;

			private float _003CtimeOnWaitStart_003E5__3;

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
			public _003CTimeLoop_003Ed__105(int _003C_003E1__state)
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

		private const float DefaultCycleDuration = 24f;

		public const float TickDuration = 0.5f;

		public const int EndOfDay = 400;

		public const int WakeTime = 700;

		private static float CycleDuration;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.GameTime.EDay _defaultDay;

		private float _lastMinWaitExcess;

		private bool _stopMinPassWait;

		private float _secondsOnCurrentMinute;

		public ActionList onMinutePass;

		public ActionList onUncappedMinutePass;

		public ActionList onTick;

		public global::System.Action<int> onTimeSkip;

		public global::System.Action onTimeSet;

		public global::System.Action onHourPass;

		public global::System.Action onDayPass;

		public global::System.Action onWeekPass;

		public global::System.Action onUpdate;

		public global::System.Action onFixedUpdate;

		public global::System.Action onSleepStart;

		public global::System.Action onSleepEnd;

		private global::ScheduleOne.Persistence.Loaders.TimeLoader loader;

		private bool NetworkInitialize___EarlyScheduleOne_002EGameTime_002ETimeManagerAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EGameTime_002ETimeManagerAssembly_002DCSharp_002Edll_Excuted;

		public static float MinuteDuration => 0f;

		public static float TicksPerMinute => 0f;

		[field: global::UnityEngine.SerializeField]
		public int DefaultTime { get; private set; }

		public int CurrentTime { get; private set; }

		public global::ScheduleOne.GameTime.EDay CurrentDay => default(global::ScheduleOne.GameTime.EDay);

		public int ElapsedDays { get; private set; }

		public bool IsEndOfDay => false;

		public bool IsNight => false;

		public float NormalizedTimeOfDay => 0f;

		public int DayIndex => 0;

		public bool IsSleepInProgress { get; private set; }

		public float Playtime { get; private set; }

		public bool HostSleepDone { get; private set; }

		public float TimeSpeedMultiplier { get; private set; }

		public int DailyMinSum { get; private set; }

		private float _minuteStaggerTime => 0f;

		private float _tickStaggerTime => 0f;

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

		public override void OnStartServer()
		{
		}

		public override void OnStartClient()
		{
		}

		private void Clean()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true, ExcludeServer = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetTimeData_Client(global::FishNet.Connection.NetworkConnection conn, int elapsedDays, int time, uint serverTick)
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.GameTime.TimeManager._003CTickLoop_003Ed__104))]
		private global::System.Collections.IEnumerator TickLoop()
		{
			return null;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.GameTime.TimeManager._003CTimeLoop_003Ed__105))]
		private global::System.Collections.IEnumerator TimeLoop()
		{
			return null;
		}

		private bool ShouldMinutePass()
		{
			return false;
		}

		private void PassMinute()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true, ExcludeServer = true)]
		private void PassMinute_Client(int oldTime)
		{
		}

		public void SetTimeAndSync(int time)
		{
		}

		private void SetTime(int time)
		{
		}

		public bool IsCurrentTimeWithinRange(int min, int max)
		{
			return false;
		}

		public bool IsCurrentDateWithinRange(global::ScheduleOne.GameTime.GameDateTime start, global::ScheduleOne.GameTime.GameDateTime end)
		{
			return false;
		}

		public global::ScheduleOne.GameTime.GameDateTime GetDateTime()
		{
			return default(global::ScheduleOne.GameTime.GameDateTime);
		}

		public int GetTotalMinSum()
		{
			return 0;
		}

		public void SetTimeSpeedMultiplier(float multiplier)
		{
		}

		public void SetCycleDuration(float time)
		{
		}

		private void CheckSleepStart()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void StartSleep()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		public void SetHostSleepDone(bool done)
		{
		}

		private void SkipForwardToTime(int newTime)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void OnTimeSkip_Client(int oldTime, int newTime)
		{
		}

		public static bool IsGivenTimeWithinRange(int givenTime, int min, int max)
		{
			return false;
		}

		public static bool IsValid24HourTime(string input)
		{
			return false;
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

		public static int AddMinutesTo24HourTime(int time, int minsToAdd)
		{
			return 0;
		}

		public virtual string GetSaveString()
		{
			return null;
		}

		public void Load(global::ScheduleOne.Persistence.Datas.TimeData timeData)
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

		private void RpcWriter___Observers_SetTimeData_Client_1794730778(global::FishNet.Connection.NetworkConnection conn, int elapsedDays, int time, uint serverTick)
		{
		}

		private void RpcLogic___SetTimeData_Client_1794730778(global::FishNet.Connection.NetworkConnection conn, int elapsedDays, int time, uint serverTick)
		{
		}

		private void RpcReader___Observers_SetTimeData_Client_1794730778(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetTimeData_Client_1794730778(global::FishNet.Connection.NetworkConnection conn, int elapsedDays, int time, uint serverTick)
		{
		}

		private void RpcReader___Target_SetTimeData_Client_1794730778(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_PassMinute_Client_3316948804(int oldTime)
		{
		}

		private void RpcLogic___PassMinute_Client_3316948804(int oldTime)
		{
		}

		private void RpcReader___Observers_PassMinute_Client_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_StartSleep_2166136261()
		{
		}

		public void RpcLogic___StartSleep_2166136261()
		{
		}

		private void RpcReader___Observers_StartSleep_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_SetHostSleepDone_1140765316(bool done)
		{
		}

		public void RpcLogic___SetHostSleepDone_1140765316(bool done)
		{
		}

		private void RpcReader___Observers_SetHostSleepDone_1140765316(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_OnTimeSkip_Client_1692629761(int oldTime, int newTime)
		{
		}

		private void RpcLogic___OnTimeSkip_Client_1692629761(int oldTime, int newTime)
		{
		}

		private void RpcReader___Observers_OnTimeSkip_Client_1692629761(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EGameTime_002ETimeManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
