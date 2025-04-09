using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using ScheduleOne.DevUtilities;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Loaders;
using UnityEngine.Events;

namespace ScheduleOne.GameTime
{
	public class TimeManager : NetworkSingleton<TimeManager>, IBaseSaveable, ISaveable
	{
		[CompilerGenerated]
		private sealed class _003CStaggeredMinPass_003Ed__103 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeManager _003C_003E4__this;

			public float staggerTime;

			private Delegate[] _003Clisteners_003E5__2;

			private float _003CperDelay_003E5__3;

			private float _003CstartTime_003E5__4;

			private float _003CwaitOverflow_003E5__5;

			private float _003CtimeOnWaitStart_003E5__6;

			private int _003CloopsSinceLastWait_003E5__7;

			private int _003Ci_003E5__8;

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
			public _003CStaggeredMinPass_003Ed__103(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CTickLoop_003Ed__101 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeManager _003C_003E4__this;

			private float _003ClastWaitExcess_003E5__2;

			private float _003CtimeToWait_003E5__3;

			private float _003CtimeOnWaitStart_003E5__4;

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
			public _003CTickLoop_003Ed__101(int _003C_003E1__state)
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

		[CompilerGenerated]
		private sealed class _003CTimeLoop_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public TimeManager _003C_003E4__this;

			private float _003ClastWaitExcess_003E5__2;

			private float _003CtimeToWait_003E5__3;

			private float _003CtimeOnWaitStart_003E5__4;

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
			public _003CTimeLoop_003Ed__102(int _003C_003E1__state)
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

		public const float CYCLE_DURATION_MINS = 24f;

		public const float MINUTE_TIME = 1f;

		public const int DEFAULT_WAKE_TIME = 700;

		public const int END_OF_DAY = 400;

		public int DefaultTime;

		public EDay DefaultDay;

		public float TimeProgressionMultiplier;

		private int savedTime;

		public Action onMinutePass;

		public Action onHourPass;

		public Action onDayPass;

		public Action onWeekPass;

		public Action onUpdate;

		public Action onFixedUpdate;

		public Action<int> onTimeSkip;

		public Action onTick;

		public static Action onSleepStart;

		public UnityEvent _onSleepStart;

		public static Action<int> onSleepEnd;

		public UnityEvent _onSleepEnd;

		public UnityEvent onFirstNight;

		public Action onTimeChanged;

		public const int SelectedWakeTime = 700;

		private GameDateTime sleepStartTime;

		private int sleepEndTime;

		private float defaultFixedTimeScale;

		private TimeLoader loader;

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

		public EDay CurrentDay => default(EDay);

		public bool TimeOverridden { get; protected set; }

		public bool HostDailySummaryDone { get; private set; }

		public string SaveFolderName => null;

		public string SaveFileName => null;

		public Loader Loader => null;

		public bool ShouldSaveUnderFolder => false;

		public List<string> LocalExtraFiles { get; set; }

		public List<string> LocalExtraFolders { get; set; }

		public bool HasChanged { get; set; }

		public override void Awake()
		{
		}

		public virtual void InitializeSaveable()
		{
		}

		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		public override void OnStartClient()
		{
		}

		private void Clean()
		{
		}

		public void SendTimeData(NetworkConnection connection)
		{
		}

		[ObserversRpc(RunLocally = true, ExcludeServer = true)]
		[TargetRpc]
		private void SetData(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void FixedUpdate()
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void ResetHostSleepDone()
		{
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void MarkHostSleepDone()
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void SetHostSleepDone(bool done)
		{
		}

		[IteratorStateMachine(typeof(_003CTickLoop_003Ed__101))]
		private IEnumerator TickLoop()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CTimeLoop_003Ed__102))]
		private IEnumerator TimeLoop()
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CStaggeredMinPass_003Ed__103))]
		private IEnumerator StaggeredMinPass(float staggerTime)
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

		public bool IsCurrentDateWithinRange(GameDateTime start, GameDateTime end)
		{
			return false;
		}

		[ObserversRpc]
		private void InvokeDayPassClientSide()
		{
		}

		[ObserversRpc]
		private void InvokeWeekPassClientSide()
		{
		}

		public void FastForwardToWakeTime()
		{
		}

		public GameDateTime GetDateTime()
		{
			return default(GameDateTime);
		}

		public int GetTotalMinSum()
		{
			return 0;
		}

		public static int AddMinutesTo24HourTime(int time, int minsToAdd)
		{
			return 0;
		}

		public static List<int> GetAllTimeInRange(int min, int max)
		{
			return null;
		}

		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetWakeTime(int amount)
		{
		}

		[ObserversRpc(RunLocally = true)]
		private void StartSleep()
		{
		}

		[ObserversRpc(RunLocally = true)]
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

		private void RpcWriter___Observers_SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
		}

		private void RpcLogic___SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
		}

		private void RpcReader___Observers_SetData_2661156041(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Target_SetData_2661156041(NetworkConnection conn, int _elapsedDays, int _time, float sendTime)
		{
		}

		private void RpcReader___Target_SetData_2661156041(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_ResetHostSleepDone_2166136261()
		{
		}

		public void RpcLogic___ResetHostSleepDone_2166136261()
		{
		}

		private void RpcReader___Server_ResetHostSleepDone_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_MarkHostSleepDone_2166136261()
		{
		}

		public void RpcLogic___MarkHostSleepDone_2166136261()
		{
		}

		private void RpcReader___Server_MarkHostSleepDone_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetHostSleepDone_1140765316(bool done)
		{
		}

		private void RpcLogic___SetHostSleepDone_1140765316(bool done)
		{
		}

		private void RpcReader___Observers_SetHostSleepDone_1140765316(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_InvokeDayPassClientSide_2166136261()
		{
		}

		private void RpcLogic___InvokeDayPassClientSide_2166136261()
		{
		}

		private void RpcReader___Observers_InvokeDayPassClientSide_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_InvokeWeekPassClientSide_2166136261()
		{
		}

		private void RpcLogic___InvokeWeekPassClientSide_2166136261()
		{
		}

		private void RpcReader___Observers_InvokeWeekPassClientSide_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Server_SetWakeTime_3316948804(int amount)
		{
		}

		public void RpcLogic___SetWakeTime_3316948804(int amount)
		{
		}

		private void RpcReader___Server_SetWakeTime_3316948804(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_StartSleep_2166136261()
		{
		}

		private void RpcLogic___StartSleep_2166136261()
		{
		}

		private void RpcReader___Observers_StartSleep_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		private void RpcWriter___Observers_EndSleep_2166136261()
		{
		}

		private void RpcLogic___EndSleep_2166136261()
		{
		}

		private void RpcReader___Observers_EndSleep_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EGameTime_002ETimeManager_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
