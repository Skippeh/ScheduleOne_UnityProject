namespace ScheduleOne.Weather
{
	public class MaskController : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass32_0
		{
			public global::UnityEngine.Rendering.AsyncGPUReadbackRequest request;

			internal bool _003CDoHeightConversionRoutine_003Eb__0()
			{
				return false;
			}
		}

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDoHeightConversionRoutine_003Ed__32 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.Weather.MaskController _003C_003E4__this;

			private global::ScheduleOne.Weather.MaskController._003C_003Ec__DisplayClass32_0 _003C_003E8__1;

			private global::UnityEngine.ComputeBuffer _003CheightBuffer_003E5__2;

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
			public _003CDoHeightConversionRoutine_003Ed__32(int _003C_003E1__state)
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

		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.ComputeShader _wetMaskShader;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.ComputeShader _maskDownsampleShader;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.RenderTexture _wetMaskTexture;

		[global::UnityEngine.Header("General Settings")]
		[global::UnityEngine.SerializeField]
		private int _worldSize;

		[global::UnityEngine.Header("Wet Mask Settings")]
		[global::UnityEngine.SerializeField]
		private int _wetMaskResolution;

		[global::UnityEngine.SerializeField]
		private float _wetGrowthRate;

		[global::UnityEngine.SerializeField]
		private float _wetDecayRate;

		[global::UnityEngine.SerializeField]
		private float _sunEvapMultiplier;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.AnimationCurve _wetnessGrowthCurve;

		[global::UnityEngine.Header("Height Settings")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture2D _heightMask;

		[global::UnityEngine.SerializeField]
		private int _downsampledResolution;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2 _minMaxHeight;

		[global::UnityEngine.Header("Debugging & Development")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.RenderTexture _debugTexture;

		private global::UnityEngine.Vector2[] _weatherVolumeOrigins;

		private float[] _weatherRainValues;

		private float[] _weatherSunValues;

		private global::UnityEngine.ComputeBuffer _volumeOriginsBuffer;

		private global::UnityEngine.ComputeBuffer _volumeRainBuffer;

		private global::UnityEngine.ComputeBuffer _volumeSunBuffer;

		private global::UnityEngine.Coroutine _heightConversionCo;

		private float[] _heightMap;

		public float WorldSize => 0f;

		public int HeightMapResolution => 0;

		public float[] HeightMap => null;

		public global::UnityEngine.Vector2 MinMaxHeight => default(global::UnityEngine.Vector2);

		public void Initialise(int weatherVolumeCount, float blendAmount, global::UnityEngine.Vector3 weatherVolumeSize)
		{
		}

		public void RunWetMaskShader(global::System.Collections.Generic.List<global::ScheduleOne.Weather.WeatherVolume> weatherVolumes)
		{
		}

		public void ConvertHeightToArray()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Weather.MaskController._003CDoHeightConversionRoutine_003Ed__32))]
		private global::System.Collections.IEnumerator DoHeightConversionRoutine()
		{
			return null;
		}

		private void OnDestroy()
		{
		}
	}
}
