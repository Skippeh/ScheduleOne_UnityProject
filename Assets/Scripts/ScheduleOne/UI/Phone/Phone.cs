using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.ScriptableObjects;
using ScheduleOne.Vision;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	public class Phone : PlayerSingleton<Phone>
	{
		[CompilerGenerated]
		private sealed class _003CSetIsHorizontal_Process_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Phone _003C_003E4__this;

			public bool h;

			private float _003CadjustedRotationTime_003E5__2;

			private Quaternion _003CstartRotation_003E5__3;

			private Quaternion _003CendRotation_003E5__4;

			private float _003Ci_003E5__5;

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
			public _003CSetIsHorizontal_Process_003Ed__46(int _003C_003E1__state)
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
		private sealed class _003CSetLookOffset_Process_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Phone _003C_003E4__this;

			public float lookOffset;

			private float _003CstartOffset_003E5__2;

			private float _003CendOffset_003E5__3;

			private float _003CmoveTime_003E5__4;

			private float _003Ci_003E5__5;

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
			public _003CSetLookOffset_Process_003Ed__50(int _003C_003E1__state)
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

		public static GameObject ActiveApp;

		public PhoneCallData testData;

		public CallerID testCalller;

		[Header("References")]
		[SerializeField]
		protected GameObject phoneModel;

		[SerializeField]
		protected Transform orientation_Vertical;

		[SerializeField]
		protected Transform orientation_Horizontal;

		[SerializeField]
		protected GraphicRaycaster raycaster;

		[SerializeField]
		protected GameObject PhoneFlashlight;

		[SerializeField]
		protected AudioSourceController FlashlightToggleSound;

		[Header("Settings")]
		public float rotationTime;

		public float LookOffsetMax;

		public float LookOffsetMin;

		public float OpenVerticalOffset;

		public Action onPhoneOpened;

		public Action onPhoneClosed;

		public Action closeApps;

		private EventSystem eventSystem;

		private VisibilityAttribute flashlightVisibility;

		private Coroutine rotationCoroutine;

		private Coroutine lookOffsetCoroutine;

		public bool IsOpen { get; protected set; }

		public bool isHorizontal { get; protected set; }

		public bool isOpenable { get; protected set; }

		public bool FlashlightOn { get; protected set; }

		public float ScaledLookOffset => 0f;

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

		[IteratorStateMachine(typeof(_003CSetIsHorizontal_Process_003Ed__46))]
		protected IEnumerator SetIsHorizontal_Process(bool h)
		{
			return null;
		}

		public void SetLookOffsetMultiplier(float multiplier)
		{
		}

		public void RequestCloseApp()
		{
		}

		[IteratorStateMachine(typeof(_003CSetLookOffset_Process_003Ed__50))]
		protected IEnumerator SetLookOffset_Process(float lookOffset)
		{
			return null;
		}

		public bool MouseRaycast(out RaycastResult result)
		{
			result = default(RaycastResult);
			return false;
		}
	}
}
