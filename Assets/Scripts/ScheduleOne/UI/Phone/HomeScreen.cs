namespace ScheduleOne.UI.Phone
{
	public class HomeScreen : global::ScheduleOne.DevUtilities.PlayerSingleton<global::ScheduleOne.UI.Phone.HomeScreen>
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDelayedSetCanvasActive_003Ed__15 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public global::ScheduleOne.UI.Phone.HomeScreen _003C_003E4__this;

			public bool active;

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
			public _003CDelayedSetCanvasActive_003Ed__15(int _003C_003E1__state)
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

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Canvas canvas;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text timeText;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform appIconContainer;

		[global::UnityEngine.Header("Prefabs")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject appIconPrefab;

		protected global::System.Collections.Generic.List<global::UnityEngine.UI.Button> appIcons;

		private global::UnityEngine.Coroutine delayedSetOpenRoutine;

		public bool isOpen { get; protected set; }

		protected override void Start()
		{
		}

		public override void OnStartClient(bool IsOwner)
		{
		}

		protected override void OnDestroy()
		{
		}

		protected void PhoneOpened()
		{
		}

		protected void PhoneClosed()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.Phone.HomeScreen._003CDelayedSetCanvasActive_003Ed__15))]
		private global::System.Collections.IEnumerator DelayedSetCanvasActive(bool active, float delay)
		{
			return null;
		}

		public void SetIsOpen(bool o)
		{
		}

		public void SetCanvasActive(bool a)
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void OnUncappedMinPass()
		{
		}

		public global::UnityEngine.UI.Button GenerateAppIcon<T>(global::ScheduleOne.UI.App<T> prog) where T : global::ScheduleOne.DevUtilities.PlayerSingleton<T>
		{
			return null;
		}
	}
}
