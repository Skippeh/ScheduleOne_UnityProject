// Decompiled with JetBrains decompiler
// Type: VolumetricFogAndMist2.ShaderParams
// Assembly: Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 96BEA75E-C4F9-48CA-8D0E-33D7E4D3B52E
// Assembly location: G:\Temp\test\Unity.RenderPipelines.Universal.Runtime.dll

using System.Runtime.CompilerServices;

#nullable disable
namespace VolumetricFogAndMist2
{
  public static class ShaderParams
  {
    public static int DetailOffset;
    public static int DetailColor;
    public static int DetailData;
    public static int Density;
    public static int NativeLightsMultiplier;
    public static int APVIntensityMultiplier;
    public static int ShadowData;
    public static int LightDiffusionIntensity;
    public static int LightDiffusionPower;
    public static int DeepObscurance;
    public static int NoiseScale;
    public static int SpecularThreshold;
    public static int SpecularIntensity;
    public static int SpecularColor;
    public static int NoiseFinalMultiplier;
    public static int NoiseStrength;
    public static int TurbulenceAmount;
    public static int FogOfWarCenterAdjusted;
    public static int FogOfWarSize;
    public static int FogOfWarCenter;
    public static int FogOfWarTexture;
    public static int DistanceData;
    public static int MaxDistanceData;
    public static int DepthGradientTexture;
    public static int HeightGradientTexture;
    public static int DetailTexture;
    public static int RaymarchSettings;
    public static int SunDir;
    public static int Color;
    public static int MainTex;
    public static int WindDirection;
    public static int DetailWindDirection;
    public static int LightColor;
    public static int BoundsBorder;
    public static int BoundsExtents;
    public static int BoundsCenter;
    public static int BoundsData;
    public static int RotationInvMatrix;
    public static int RotationMatrix;
    public static int SurfaceCaptureMatrix;
    public static int SurfaceDepthTexture;
    public static int SurfaceData;
    public static int PointLightCount;
    public static int PointLightInsideAtten;
    public static int PointLightPositions;
    public static int PointLightColors;
    public static int VoidCount;
    public static int VoidSizes;
    public static int VoidPositions;
    public static int VoidMatrices;
    public const string CustomDepthTextureName = "_CustomDepthTexture";
    public static int CustomDepthTexture;
    public static int CustomDepthAlphaCutoff;
    public static int CustomDepthBaseMap;
    public static int SpotLightCount;
    public static int SpotLightPositions;
    public static int SpotLightDirections;
    public static int SpotLightColors;
    public static int BlueNoiseTexture;
    public static int DistantFogData;
    public static int BaseAltitude;
    public static int CullMode;
    public const string SKW_CUSTOM_DEPTH_ALPHA_TEST = "DEPTH_PREPASS_ALPHA_TEST";
    public const string SKW_SHAPE_BOX = "VF2_SHAPE_BOX";
    public const string SKW_SHAPE_SPHERE = "VF2_SHAPE_SPHERE";
    public const string SKW_POINT_LIGHTS = "VF2_POINT_LIGHTS";
    public const string SKW_NATIVE_LIGHTS = "VF2_NATIVE_LIGHTS";
    public const string SKW_VOIDS = "VF2_VOIDS";
    public const string SKW_FOW = "VF2_FOW";
    public const string SKW_RECEIVE_SHADOWS = "VF2_RECEIVE_SHADOWS";
    public const string SKW_DISTANCE = "VF2_DISTANCE";
    public const string SKW_CONSTANT_DENSITY = "VF2_CONSTANT_DENSITY";
    public const string SKW_DETAIL_NOISE = "VF2_DETAIL_NOISE";
    public const string SKW_SURFACE = "VF2_SURFACE";
    public const string SKW_DEPTH_PREPASS = "VF2_DEPTH_PREPASS";
    public const string SKW_DEPTH_GRADIENT = "VF2_DEPTH_GRADIENT";
    public const string SKW_HEIGHT_GRADIENT = "VF2_HEIGHT_GRADIENT";
    public const string SKW_DIRECTIONAL_COOKIE = "VF2_LIGHT_COOKIE";
    public const string SKW_APV = "VF2_APV";
    public const string SKW_DIFFUSION_SMOOTH = "VF2_DIFFUSION_SMOOTH";
    public const string SKW_DIFFUSION_STRONG = "VF2_DIFFUSION_STRONG";

    [MethodImpl(MethodImplOptions.NoInlining)]
    static ShaderParams() => throw null;
  }
}
