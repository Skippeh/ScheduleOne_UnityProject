using UnityEngine;

namespace VLB
{
	public static class BatchingHelper
	{
		public static bool forceEnableDepthBlend => false;

		public static bool IsGpuInstancingEnabled(Material material)
		{
			return false;
		}

		public static void SetMaterialProperties(Material material, bool enableGpuInstancing)
		{
		}

		private static bool DoesRenderingModePreventBatching(ShaderMode shaderMode, ref string reasons)
		{
			return false;
		}

		public static bool CanBeBatched(VolumetricLightBeamSD beamA, VolumetricLightBeamSD beamB, ref string reasons)
		{
			return false;
		}

		public static bool CanBeBatched(VolumetricLightBeamSD beam, ref string reasons)
		{
			return false;
		}

		public static bool CanBeBatched(VolumetricLightBeamHD beamA, VolumetricLightBeamHD beamB, ref string reasons)
		{
			return false;
		}

		public static bool CanBeBatched(VolumetricLightBeamHD beam, ref string reasons)
		{
			return false;
		}

		public static bool CanBeBatched(VolumetricLightBeamAbstractBase beamA, VolumetricLightBeamAbstractBase beamB, ref string reasons)
		{
			return false;
		}

		private static void AppendErrorMessage(ref string message, string toAppend)
		{
		}
	}
}
