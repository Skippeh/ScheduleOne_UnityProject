using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using UnityEngine;

namespace ScheduleOne.Lighting
{
	public class PoliceLight : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCycleCoroutine_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PoliceLight _003C_003E4__this;

			private float _003Ctime_003E5__2;

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
			public _003CCycleCoroutine_003Ed__17(int _003C_003E1__state)
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

		public bool IsOn;

		[Header("References")]
		public MeshRenderer[] RedMeshes;

		public MeshRenderer[] BlueMeshes;

		public OptimizedLight[] RedLights;

		public OptimizedLight[] BlueLights;

		public AudioSourceController Siren;

		[Header("Settings")]
		public float CycleDuration;

		public Material RedOffMat;

		public Material RedOnMat;

		public Material BlueOffMat;

		public Material BlueOnMat;

		public AnimationCurve RedBrightnessCurve;

		public AnimationCurve BlueBrightnessCurve;

		public float LightBrightness;

		private Coroutine cycleRoutine;

		public void SetIsOn(bool isOn)
		{
		}

		private void FixedUpdate()
		{
		}

		[IteratorStateMachine(typeof(_003CCycleCoroutine_003Ed__17))]
		protected IEnumerator CycleCoroutine()
		{
			return null;
		}
	}
}
