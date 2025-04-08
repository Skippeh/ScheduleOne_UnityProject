namespace VLB
{
	public static class ShaderProperties
	{
		public static class SD
		{
			public static readonly int FadeOutFactor;

			public static readonly int ConeSlopeCosSin;

			public static readonly int AlphaInside;

			public static readonly int AlphaOutside;

			public static readonly int AttenuationLerpLinearQuad;

			public static readonly int DistanceCamClipping;

			public static readonly int FresnelPow;

			public static readonly int GlareBehind;

			public static readonly int GlareFrontal;

			public static readonly int DrawCap;

			public static readonly int DepthBlendDistance;

			public static readonly int CameraParams;

			public static readonly int DynamicOcclusionClippingPlaneWS;

			public static readonly int DynamicOcclusionClippingPlaneProps;

			public static readonly int DynamicOcclusionDepthTexture;

			public static readonly int DynamicOcclusionDepthProps;

			public static readonly int LocalForwardDirection;

			public static readonly int TiltVector;

			public static readonly int AdditionalClippingPlaneWS;
		}

		public static class HD
		{
			public static readonly int Intensity;

			public static readonly int SideSoftness;

			public static readonly int CameraForwardOS;

			public static readonly int CameraForwardWS;

			public static readonly int TransformScale;

			public static readonly int ShadowDepthTexture;

			public static readonly int ShadowProps;

			public static readonly int Jittering;

			public static readonly int CookieTexture;

			public static readonly int CookieProperties;

			public static readonly int CookiePosAndScale;

			public static readonly int GlobalCameraBlendingDistance;

			public static readonly int GlobalJitteringNoiseTex;
		}

		public static readonly int ConeRadius;

		public static readonly int ConeGeomProps;

		public static readonly int ColorFlat;

		public static readonly int DistanceFallOff;

		public static readonly int NoiseVelocityAndScale;

		public static readonly int NoiseParam;

		public static readonly int ColorGradientMatrix;

		public static readonly int LocalToWorldMatrix;

		public static readonly int WorldToLocalMatrix;

		public static readonly int BlendSrcFactor;

		public static readonly int BlendDstFactor;

		public static readonly int ZTest;

		public static readonly int ParticlesTintColor;

		public static readonly int HDRPExposureWeight;

		public static readonly int GlobalUsesReversedZBuffer;

		public static readonly int GlobalNoiseTex3D;

		public static readonly int GlobalNoiseCustomTime;

		public static readonly int GlobalDitheringFactor;

		public static readonly int GlobalDitheringNoiseTex;
	}
}
