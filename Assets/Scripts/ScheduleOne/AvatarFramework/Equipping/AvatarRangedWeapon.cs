namespace ScheduleOne.AvatarFramework.Equipping
{
	public class AvatarRangedWeapon : global::ScheduleOne.AvatarFramework.Equipping.AvatarWeapon
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CReload_003Ed__30 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.AvatarFramework.Equipping.AvatarRangedWeapon _003C_003E4__this;

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
			public _003CReload_003Ed__30(int _003C_003E1__state)
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

		public static string[] RaycastLayers;

		[global::UnityEngine.Header("Weapon Settings")]
		public int MagazineSize;

		public float ReloadTime;

		public float MaxFireRate;

		public bool CanShootWhileMoving;

		public float EquipTime;

		public float RaiseTime;

		public float Damage;

		[global::UnityEngine.Header("Accuracy")]
		public float HitChange_MinRange;

		public float HitChange_MaxRange;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform MuzzlePoint;

		public global::ScheduleOne.Audio.AudioSourceController FireSound;

		[global::UnityEngine.Header("Settings")]
		public string LoweredAnimationTrigger;

		public string RaisedAnimationTrigger;

		public string RecoilAnimationTrigger;

		private bool isReloading;

		private float timeEquipped;

		private float timeRaised;

		private float timeSinceLastShot;

		private int currentAmmo;

		public bool IsRaised { get; protected set; }

		public override void Equip(global::ScheduleOne.AvatarFramework.Avatar _avatar)
		{
		}

		public virtual void SetIsRaised(bool raised)
		{
		}

		private void Update()
		{
		}

		public override void ReceiveMessage(string message, object data)
		{
		}

		public bool CanShoot()
		{
			return false;
		}

		public virtual void Shoot(global::UnityEngine.Vector3 endPoint)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.AvatarFramework.Equipping.AvatarRangedWeapon._003CReload_003Ed__30))]
		private global::System.Collections.IEnumerator Reload()
		{
			return null;
		}

		public bool IsPlayerInLoS(global::ScheduleOne.PlayerScripts.Player target)
		{
			return false;
		}
	}
}
