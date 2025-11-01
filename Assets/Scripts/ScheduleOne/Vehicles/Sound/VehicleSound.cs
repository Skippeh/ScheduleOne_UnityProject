namespace ScheduleOne.Vehicles.Sound
{
	public class VehicleSound : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CAdjustVolume_003Ed__29 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Vehicles.Sound.VehicleSound _003C_003E4__this;

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
			public _003CAdjustVolume_003Ed__29(int _003C_003E1__state)
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

		public const float COLLISION_SOUND_COOLDOWN = 0.5f;

		public float VolumeMultiplier;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Audio.AudioSourceController EngineStartSource;

		public global::ScheduleOne.Audio.AudioSourceController EngineIdleSource;

		public global::ScheduleOne.Audio.AudioSourceController EngineLoopSource;

		public global::ScheduleOne.Audio.AudioSourceController HandbrakeSource;

		public global::ScheduleOne.Audio.AudioSourceController HonkSource;

		public global::ScheduleOne.Audio.AudioSourceController ImpactSound;

		[global::UnityEngine.Header("Impact Sounds")]
		public float MinCollisionMomentum;

		public float MaxCollisionMomentum;

		public float MinCollisionVolume;

		public float MaxCollisionVolume;

		public float MinCollisionPitch;

		public float MaxCollisionPitch;

		[global::UnityEngine.Header("Engine Loop Settings")]
		public global::UnityEngine.AnimationCurve EngineLoopPitchCurve;

		public float EngineLoopPitchMultiplier;

		public global::UnityEngine.AnimationCurve EngineLoopVolumeCurve;

		private float currentIdleVolume;

		private float lastCollisionTime;

		private float lastCollisionMomentum;

		private float volumeTarget;

		private bool isUpdatingVolume;

		public global::ScheduleOne.Vehicles.LandVehicle Vehicle { get; private set; }

		protected virtual void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnOccupy(bool isOccupied)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Vehicles.Sound.VehicleSound._003CAdjustVolume_003Ed__29))]
		private global::System.Collections.IEnumerator AdjustVolume()
		{
			return null;
		}

		public void UpdateIdle()
		{
		}

		protected void HandbrakeApplied()
		{
		}

		protected void EngineStart()
		{
		}

		public void Honk()
		{
		}

		private void OnCollision(global::UnityEngine.Collision collision)
		{
		}
	}
}
