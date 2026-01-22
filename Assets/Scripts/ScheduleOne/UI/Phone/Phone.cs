namespace ScheduleOne.UI.Phone
{
	public class Phone : global::ScheduleOne.DevUtilities.PlayerSingleton<global::ScheduleOne.UI.Phone.Phone>
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CSetIsHorizontal_Process_003Ed__50 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.Phone.Phone _003C_003E4__this;

			public bool h;

			private float _003CadjustedRotationTime_003E5__2;

			private global::UnityEngine.Quaternion _003CstartRotation_003E5__3;

			private global::UnityEngine.Quaternion _003CendRotation_003E5__4;

			private float _003Ci_003E5__5;

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
			public _003CSetIsHorizontal_Process_003Ed__50(int _003C_003E1__state)
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
		private sealed class _003CSetLookOffset_Process_003Ed__54 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.Phone.Phone _003C_003E4__this;

			public float lookOffset;

			private float _003CstartOffset_003E5__2;

			private float _003CendOffset_003E5__3;

			private float _003CmoveTime_003E5__4;

			private float _003Ci_003E5__5;

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
			public _003CSetLookOffset_Process_003Ed__54(int _003C_003E1__state)
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

		public static global::UnityEngine.GameObject ActiveApp;

		public global::ScheduleOne.ScriptableObjects.PhoneCallData testData;

		public global::ScheduleOne.ScriptableObjects.CallerID testCalller;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject phoneModel;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform orientation_Vertical;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform orientation_Horizontal;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.GraphicRaycaster raycaster;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject PhoneFlashlight;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.Audio.AudioSourceController FlashlightToggleSound;

		[global::UnityEngine.Header("Settings")]
		public float rotationTime;

		public float LookOffsetMax;

		public float LookOffsetMin;

		public float OpenVerticalOffset;

		[global::UnityEngine.Header("Fonts")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.DevUtilities.ColorFont _generalColorFont;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.DevUtilities.ColorFont _productColorFont;

		public global::System.Action onPhoneOpened;

		public global::System.Action onPhoneClosed;

		public global::System.Action closeApps;

		private global::UnityEngine.EventSystems.EventSystem eventSystem;

		private global::ScheduleOne.Vision.VisibilityAttribute flashlightVisibility;

		private global::UnityEngine.Coroutine rotationCoroutine;

		private global::UnityEngine.Coroutine lookOffsetCoroutine;

		public bool IsOpen { get; protected set; }

		public bool isHorizontal { get; protected set; }

		public bool isOpenable { get; protected set; }

		public bool FlashlightOn { get; protected set; }

		public float ScaledLookOffset => 0f;

		public global::ScheduleOne.DevUtilities.ColorFont GeneralColorFont => null;

		protected override void Awake()
		{
		}

		public override void OnStartClient(bool IsOwner)
		{
		}

		protected override void Start()
		{
		}

		protected virtual void Update()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void ToggleFlashlight()
		{
		}

		public void SetOpenable(bool o)
		{
		}

		public void SetIsOpen(bool o)
		{
		}

		public void SetIsHorizontal(bool h)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.Phone.Phone._003CSetIsHorizontal_Process_003Ed__50))]
		protected global::System.Collections.IEnumerator SetIsHorizontal_Process(bool h)
		{
			return null;
		}

		public void SetLookOffsetMultiplier(float multiplier)
		{
		}

		public void RequestCloseApp()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.Phone.Phone._003CSetLookOffset_Process_003Ed__54))]
		protected global::System.Collections.IEnumerator SetLookOffset_Process(float lookOffset)
		{
			return null;
		}

		public bool MouseRaycast(out global::UnityEngine.EventSystems.RaycastResult result)
		{
			result = default(global::UnityEngine.EventSystems.RaycastResult);
			return false;
		}
	}
}
