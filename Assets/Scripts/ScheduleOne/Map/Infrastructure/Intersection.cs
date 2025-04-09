using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ScheduleOne.Map.Infrastructure
{
	public class Intersection : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CRun_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Intersection _003C_003E4__this;

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
			public _003CRun_003Ed__8(int _003C_003E1__state)
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
		protected List<TrafficLight> path1Lights;

		[SerializeField]
		protected List<TrafficLight> path2Lights;

		[SerializeField]
		protected List<GameObject> path1Obstacles;

		[SerializeField]
		protected List<GameObject> path2Obstacles;

		[Header("Settings")]
		[SerializeField]
		protected float path1Time;

		[SerializeField]
		protected float path2Time;

		[SerializeField]
		protected float timeOffset;

		protected virtual void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CRun_003Ed__8))]
		protected IEnumerator Run()
		{
			return null;
		}

		protected void SetPath1Lights(TrafficLight.State state)
		{
		}

		protected void SetPath2Lights(TrafficLight.State state)
		{
		}
	}
}
