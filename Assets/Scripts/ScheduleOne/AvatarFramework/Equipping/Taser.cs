namespace ScheduleOne.AvatarFramework.Equipping
{
	public class Taser : global::ScheduleOne.AvatarFramework.Equipping.AvatarRangedWeapon
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CFlash_003Ed__10 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.AvatarFramework.Equipping.Taser _003C_003E4__this;

			public global::UnityEngine.Vector3 endPoint;

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
			public _003CFlash_003Ed__10(int _003C_003E1__state)
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

		public const float TaseDuration = 2f;

		public const float TaseMoveSpeedMultiplier = 0.5f;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.GameObject FlashObject;

		public global::ScheduleOne.Audio.AudioSourceController ChargeSound;

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject RayPrefab;

		private global::UnityEngine.Coroutine flashRoutine;

		public override void Equip(global::ScheduleOne.AvatarFramework.Avatar _avatar)
		{
		}

		protected override void Shoot(global::UnityEngine.Vector3 endPoint)
		{
		}

		public override void ApplyHitToDamageable(global::ScheduleOne.Combat.IDamageable damageable, global::UnityEngine.Vector3 hitPoint)
		{
		}

		public override void SetIsRaised(bool raised)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.AvatarFramework.Equipping.Taser._003CFlash_003Ed__10))]
		private global::System.Collections.IEnumerator Flash(global::UnityEngine.Vector3 endPoint)
		{
			return null;
		}
	}
}
