using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.Audio;
using ScheduleOne.PlayerScripts;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Equipping
{
	public class AvatarRangedWeapon : AvatarWeapon
	{
		[CompilerGenerated]
		private sealed class _003CReload_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public AvatarRangedWeapon _003C_003E4__this;

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
			public _003CReload_003Ed__30(int _003C_003E1__state)
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

		public static string[] RaycastLayers;

		[Header("Weapon Settings")]
		public int MagazineSize;

		public float ReloadTime;

		public float MaxFireRate;

		public bool CanShootWhileMoving;

		public float EquipTime;

		public float RaiseTime;

		public float Damage;

		[Header("Accuracy")]
		public float HitChange_MinRange;

		public float HitChange_MaxRange;

		[Header("References")]
		public Transform MuzzlePoint;

		public AudioSourceController FireSound;

		[Header("Settings")]
		public string LoweredAnimationTrigger;

		public string RaisedAnimationTrigger;

		public string RecoilAnimationTrigger;

		private bool isReloading;

		private float timeEquipped;

		private float timeRaised;

		private float timeSinceLastShot;

		private int currentAmmo;

		public bool IsRaised { get; protected set; }

		public override void Equip(Avatar _avatar)
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

		public virtual void Shoot(Vector3 endPoint)
		{
		}

		[IteratorStateMachine(typeof(_003CReload_003Ed__30))]
		private IEnumerator Reload()
		{
			return null;
		}

		public bool IsPlayerInLoS(Player target)
		{
			return false;
		}
	}
}
