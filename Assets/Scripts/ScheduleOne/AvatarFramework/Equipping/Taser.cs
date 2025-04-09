using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	public class Taser : AvatarRangedWeapon
	{
		[CompilerGenerated]
		private sealed class _003CFlash_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Taser _003C_003E4__this;

			public Vector3 endPoint;

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
			public _003CFlash_003Ed__9(int _003C_003E1__state)
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

		public const float TaseDuration = 2f;

		public const float TaseMoveSpeedMultiplier = 0.5f;

		[Header("References")]
		public GameObject FlashObject;

		public AudioSourceController ChargeSound;

		[Header("Prefabs")]
		public GameObject RayPrefab;

		private Coroutine flashRoutine;

		public override void Equip(Avatar _avatar)
		{
		}

		public override void Shoot(Vector3 endPoint)
		{
		}

		public override void SetIsRaised(bool raised)
		{
		}

		[IteratorStateMachine(typeof(_003CFlash_003Ed__9))]
		private IEnumerator Flash(Vector3 endPoint)
		{
			return null;
		}
	}
}
