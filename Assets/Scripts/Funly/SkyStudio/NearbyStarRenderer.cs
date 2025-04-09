using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Funly.SkyStudio
{
	public class NearbyStarRenderer : BaseStarDataRenderer
	{
		[CompilerGenerated]
		private sealed class _003CComputeStarData_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NearbyStarRenderer _003C_003E4__this;

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
			public _003CComputeStarData_003Ed__7(int _003C_003E1__state)
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

		private const int kMaxStars = 2000;

		private const int kStarPointTextureWidth = 2048;

		private const float kStarPaddingRadiusMultipler = 2.1f;

		private RenderTexture CreateRenderTexture(string name, int renderTextureSize, RenderTextureFormat format)
		{
			return null;
		}

		private Material GetNearbyStarMaterial(Vector4 randomSeed, int starCount)
		{
			return null;
		}

		private void WriteDebugTexture(RenderTexture rt, string path)
		{
		}

		private Texture2D GetStarListTexture(string starTexKey, out int validStarPixelCount)
		{
			validStarPixelCount = default(int);
			return null;
		}

		[IteratorStateMachine(typeof(_003CComputeStarData_003Ed__7))]
		public override IEnumerator ComputeStarData()
		{
			return null;
		}

		private Texture2D ConvertToTexture2D(RenderTexture rt)
		{
			return null;
		}
	}
}
