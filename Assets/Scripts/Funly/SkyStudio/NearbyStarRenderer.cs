namespace Funly.SkyStudio
{
	public class NearbyStarRenderer : BaseStarDataRenderer
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CComputeStarData_003Ed__7 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::Funly.SkyStudio.NearbyStarRenderer _003C_003E4__this;

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
			public _003CComputeStarData_003Ed__7(int _003C_003E1__state)
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

		private const int kMaxStars = 2000;

		private const int kStarPointTextureWidth = 2048;

		private const float kStarPaddingRadiusMultipler = 2.1f;

		private global::UnityEngine.RenderTexture CreateRenderTexture(string name, int renderTextureSize, global::UnityEngine.RenderTextureFormat format)
		{
			return null;
		}

		private global::UnityEngine.Material GetNearbyStarMaterial(global::UnityEngine.Vector4 randomSeed, int starCount)
		{
			return null;
		}

		private void WriteDebugTexture(global::UnityEngine.RenderTexture rt, string path)
		{
		}

		private global::UnityEngine.Texture2D GetStarListTexture(string starTexKey, out int validStarPixelCount)
		{
			validStarPixelCount = default(int);
			return null;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::Funly.SkyStudio.NearbyStarRenderer._003CComputeStarData_003Ed__7))]
		public override global::System.Collections.IEnumerator ComputeStarData()
		{
			return null;
		}

		private global::UnityEngine.Texture2D ConvertToTexture2D(global::UnityEngine.RenderTexture rt)
		{
			return null;
		}
	}
}
