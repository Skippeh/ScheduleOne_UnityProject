using UnityEngine;

namespace Beautify.Universal
{
	[ExecuteInEditMode]
	public class LUTBlending : MonoBehaviour
	{
		private static class ShaderParams
		{
			public static int LUT2;

			public static int Phase;
		}

		public Texture2D LUT1;

		public Texture2D LUT2;

		[Range(0f, 1f)]
		public float LUT1Intensity;

		[Range(0f, 1f)]
		public float LUT2Intensity;

		[Range(0f, 1f)]
		public float phase;

		public Shader lerpShader;

		private float oldPhase;

		private RenderTexture rt;

		private Material lerpMat;

		private void OnEnable()
		{
		}

		private void OnValidate()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateBeautifyLUT()
		{
		}
	}
}
