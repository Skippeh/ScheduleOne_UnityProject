namespace ScheduleOne.AvatarFramework.Equipping
{
	public class AvatarGun : global::ScheduleOne.AvatarFramework.Equipping.AvatarRangedWeapon
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CFlash_003Ed__7 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.AvatarFramework.Equipping.AvatarGun _003C_003E4__this;

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
			public _003CFlash_003Ed__7(int _003C_003E1__state)
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
		public global::UnityEngine.Animation Anim;

		public global::UnityEngine.ParticleSystem ShellParticles;

		public global::UnityEngine.ParticleSystem SmokeParticles;

		public global::UnityEngine.Transform FlashObject;

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject RayPrefab;

		private global::UnityEngine.Coroutine flashRoutine;

		protected override void Shoot(global::UnityEngine.Vector3 endPoint)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.AvatarFramework.Equipping.AvatarGun._003CFlash_003Ed__7))]
		private global::System.Collections.IEnumerator Flash(global::UnityEngine.Vector3 endPoint)
		{
			return null;
		}
	}
}
