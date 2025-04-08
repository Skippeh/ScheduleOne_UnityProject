namespace VLB
{
	public static class BatchingHelper
	{
		public static bool forceEnableDepthBlend => false;

		public static bool IsGpuInstancingEnabled(global::UnityEngine.Material material)
		{
			return false;
		}

		public static void SetMaterialProperties(global::UnityEngine.Material material, bool enableGpuInstancing)
		{
		}

		private static bool DoesRenderingModePreventBatching(global::VLB.ShaderMode shaderMode, ref string reasons)
		{
			return false;
		}

		public static bool CanBeBatched(global::VLB.VolumetricLightBeamSD beamA, global::VLB.VolumetricLightBeamSD beamB, ref string reasons)
		{
			return false;
		}

		public static bool CanBeBatched(global::VLB.VolumetricLightBeamSD beam, ref string reasons)
		{
			return false;
		}

		public static bool CanBeBatched(global::VLB.VolumetricLightBeamHD beamA, global::VLB.VolumetricLightBeamHD beamB, ref string reasons)
		{
			return false;
		}

		public static bool CanBeBatched(global::VLB.VolumetricLightBeamHD beam, ref string reasons)
		{
			return false;
		}

		public static bool CanBeBatched(global::VLB.VolumetricLightBeamAbstractBase beamA, global::VLB.VolumetricLightBeamAbstractBase beamB, ref string reasons)
		{
			return false;
		}

		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
}
