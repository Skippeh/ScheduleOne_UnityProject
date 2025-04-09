using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	[RequireComponent(typeof(ReflectionProbe))]
	public class ReflectionProbeUpdater : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CProcessQueue_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			private int _003CrenderDuration_Frames_003E5__2;

			private int _003Ci_003E5__3;

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
			public _003CProcessQueue_003Ed__6(int _003C_003E1__state)
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

		public ReflectionProbe Probe;

		private static List<ReflectionProbe> renderQueue;

		private static Coroutine RenderRoutine;

		private void OnValidate()
		{
		}

		private void Start()
		{
		}

		private void UpdateProbe()
		{
		}

		[IteratorStateMachine(typeof(_003CProcessQueue_003Ed__6))]
		private IEnumerator ProcessQueue()
		{
			return null;
		}
	}
}
