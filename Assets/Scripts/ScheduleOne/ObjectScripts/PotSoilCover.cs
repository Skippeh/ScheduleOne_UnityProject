using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	public class PotSoilCover : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCheckQueue_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PotSoilCover _003C_003E4__this;

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
			public _003CCheckQueue_003Ed__25(int _003C_003E1__state)
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

		public const int TEXTURE_SIZE = 128;

		public const int POUR_RADIUS = 32;

		public const int UPDATES_PER_SECOND = 24;

		public const float COVERAGE_THRESHOLD = 0.5f;

		public const float BASE_COVERAGE = 0.215f;

		public const float SUCCESS_COVERAGE_THRESHOLD = 0.95f;

		public const float DELAY = 0.35f;

		public float CurrentCoverage;

		[Header("Settings")]
		public float Radius;

		[Header("References")]
		public MeshRenderer MeshRenderer;

		public Texture2D PourMask;

		public UnityEvent onSufficientCoverage;

		private bool queued;

		private Vector3 queuedWorldPos;

		private Texture2D mainTex;

		private Vector3 relative;

		private Vector2 vector2;

		private Vector2 normalizedOffset;

		private Vector2 originPixel;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		public void ConfigureAppearance(Color col, float transparency)
		{
		}

		public void Reset()
		{
		}

		public void QueuePour(Vector3 worldSpacePosition)
		{
		}

		public float GetNormalizedProgress()
		{
			return 0f;
		}

		[IteratorStateMachine(typeof(_003CCheckQueue_003Ed__25))]
		private IEnumerator CheckQueue()
		{
			return null;
		}

		private void Blank()
		{
		}

		private void DelayedApplyPour(Vector3 worldSpace)
		{
		}

		private void ApplyPour(Vector3 worldSpace)
		{
		}

		private float GetPourMaskValue(int x, int y)
		{
			return 0f;
		}

		private float GetCoverage()
		{
			return 0f;
		}
	}
}
