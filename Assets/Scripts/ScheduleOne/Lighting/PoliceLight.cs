namespace ScheduleOne.Lighting
{
	public class PoliceLight : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CCycleCoroutine_003Ed__17 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Lighting.PoliceLight _003C_003E4__this;

			private float _003Ctime_003E5__2;

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
			public _003CCycleCoroutine_003Ed__17(int _003C_003E1__state)
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

		public bool IsOn;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.MeshRenderer[] RedMeshes;

		public global::UnityEngine.MeshRenderer[] BlueMeshes;

		public global::ScheduleOne.DevUtilities.OptimizedLight[] RedLights;

		public global::ScheduleOne.DevUtilities.OptimizedLight[] BlueLights;

		public global::ScheduleOne.Audio.AudioSourceController Siren;

		[global::UnityEngine.Header("Settings")]
		public float CycleDuration;

		public global::UnityEngine.Material RedOffMat;

		public global::UnityEngine.Material RedOnMat;

		public global::UnityEngine.Material BlueOffMat;

		public global::UnityEngine.Material BlueOnMat;

		public global::UnityEngine.AnimationCurve RedBrightnessCurve;

		public global::UnityEngine.AnimationCurve BlueBrightnessCurve;

		public float LightBrightness;

		private global::UnityEngine.Coroutine cycleRoutine;

		public void SetIsOn(bool isOn)
		{
		}

		private void FixedUpdate()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Lighting.PoliceLight._003CCycleCoroutine_003Ed__17))]
		protected global::System.Collections.IEnumerator CycleCoroutine()
		{
			return null;
		}
	}
}
