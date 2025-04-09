using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.DevUtilities;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI.Phone
{
	public class HomeScreen : PlayerSingleton<HomeScreen>
	{
		[CompilerGenerated]
		private sealed class _003CDelayedSetCanvasActive_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public HomeScreen _003C_003E4__this;

			public bool active;

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
			public _003CDelayedSetCanvasActive_003Ed__15(int _003C_003E1__state)
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

		[Header("References")]
		[SerializeField]
		protected Canvas canvas;

		[SerializeField]
		protected Text timeText;

		[SerializeField]
		protected RectTransform appIconContainer;

		[Header("Prefabs")]
		[SerializeField]
		protected GameObject appIconPrefab;

		protected List<Button> appIcons;

		private Coroutine delayedSetOpenRoutine;

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

		[IteratorStateMachine(typeof(_003CDelayedSetCanvasActive_003Ed__15))]
		private IEnumerator DelayedSetCanvasActive(bool active, float delay)
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

		protected virtual void MinPass()
		{
		}

		public Button GenerateAppIcon<T>(App<T> prog) where T : PlayerSingleton<T>
		{
			return null;
		}
	}
}
