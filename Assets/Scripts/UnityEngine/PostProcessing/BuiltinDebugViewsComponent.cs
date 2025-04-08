namespace UnityEngine.PostProcessing
{
	public sealed class BuiltinDebugViewsComponent : global::UnityEngine.PostProcessing.PostProcessingComponentCommandBuffer<global::UnityEngine.PostProcessing.BuiltinDebugViewsModel>
	{
		private static class Uniforms
		{
			internal static readonly int _DepthScale;

			internal static readonly int _TempRT;

			internal static readonly int _Opacity;

			internal static readonly int _MainTex;

			internal static readonly int _TempRT2;

			internal static readonly int _Amplitude;

			internal static readonly int _Scale;
		}

		private enum Pass
		{
			Depth = 0,
			Normals = 1,
			MovecOpacity = 2,
			MovecImaging = 3,
			MovecArrows = 4
		}

		private class ArrowArray
		{
			public global::UnityEngine.Mesh mesh { get; private set; }

			public int columnCount { get; private set; }

			public int rowCount { get; private set; }

			public void BuildMesh(int columns, int rows)
			{
			}

			public void Release()
			{
			}
		}

		private const string k_ShaderString = "Hidden/Post FX/Builtin Debug Views";

		private global::UnityEngine.PostProcessing.BuiltinDebugViewsComponent.ArrowArray m_Arrows;

		public override bool active => false;

		public override global::UnityEngine.DepthTextureMode GetCameraFlags()
		{
			return default(global::UnityEngine.DepthTextureMode);
		}

		public override global::UnityEngine.Rendering.CameraEvent GetCameraEvent()
		{
			return default(global::UnityEngine.Rendering.CameraEvent);
		}

		public override string GetName()
		{
			return null;
		}

		public override void PopulateCommandBuffer(global::UnityEngine.Rendering.CommandBuffer cb)
		{
		}

		private void DepthPass(global::UnityEngine.Rendering.CommandBuffer cb)
		{
		}

		private void DepthNormalsPass(global::UnityEngine.Rendering.CommandBuffer cb)
		{
		}

		private void MotionVectorsPass(global::UnityEngine.Rendering.CommandBuffer cb)
		{
		}

		private void PrepareArrows()
		{
		}

		public override void OnDisable()
		{
		}
	}
}
