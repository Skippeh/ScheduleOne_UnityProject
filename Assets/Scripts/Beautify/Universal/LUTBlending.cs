namespace Beautify.Universal
{
	[global::UnityEngine.ExecuteInEditMode]
	public class LUTBlending : global::UnityEngine.MonoBehaviour
	{
		private static class ShaderParams
		{
			public static int LUT2;

			public static int Phase;
		}

		public global::UnityEngine.Texture2D LUT1;

		public global::UnityEngine.Texture2D LUT2;

		[global::UnityEngine.Range(0f, 1f)]
		public float LUT1Intensity;

		[global::UnityEngine.Range(0f, 1f)]
		public float LUT2Intensity;

		[global::UnityEngine.Range(0f, 1f)]
		public float phase;

		public global::UnityEngine.Shader lerpShader;

		private float oldPhase;

		private global::UnityEngine.RenderTexture rt;

		private global::UnityEngine.Material lerpMat;

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
