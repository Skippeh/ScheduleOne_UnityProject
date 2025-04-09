using UnityEngine;

namespace VLB
{
	public static class UtilsBeamProps
	{
		public static bool CanChangeDuringPlaytime(VolumetricLightBeamAbstractBase self)
		{
			return false;
		}

		public static Quaternion GetInternalLocalRotation(VolumetricLightBeamAbstractBase self)
		{
			return default(Quaternion);
		}

		public static float GetThickness(VolumetricLightBeamAbstractBase self)
		{
			return 0f;
		}

		public static float GetFallOffEnd(VolumetricLightBeamAbstractBase self)
		{
			return 0f;
		}

		public static ColorMode GetColorMode(VolumetricLightBeamAbstractBase self)
		{
			return default(ColorMode);
		}

		public static Color GetColorFlat(VolumetricLightBeamAbstractBase self)
		{
			return default(Color);
		}

		public static Gradient GetColorGradient(VolumetricLightBeamAbstractBase self)
		{
			return null;
		}

		public static float GetConeAngle(VolumetricLightBeamAbstractBase self)
		{
			return 0f;
		}

		public static float GetConeRadiusStart(VolumetricLightBeamAbstractBase self)
		{
			return 0f;
		}

		public static float GetConeRadiusEnd(VolumetricLightBeamAbstractBase self)
		{
			return 0f;
		}

		public static int GetSortingLayerID(VolumetricLightBeamAbstractBase self)
		{
			return 0;
		}

		public static int GetSortingOrder(VolumetricLightBeamAbstractBase self)
		{
			return 0;
		}

		public static bool GetFadeOutEnabled(VolumetricLightBeamAbstractBase self)
		{
			return false;
		}

		public static float GetFadeOutEnd(VolumetricLightBeamAbstractBase self)
		{
			return 0f;
		}

		public static Dimensions GetDimensions(VolumetricLightBeamAbstractBase self)
		{
			return default(Dimensions);
		}

		public static int GetGeomSides(VolumetricLightBeamAbstractBase self)
		{
			return 0;
		}
	}
}
