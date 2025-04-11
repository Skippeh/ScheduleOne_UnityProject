// Decompiled with JetBrains decompiler
// Type: VolumetricFogAndMist2.VolumetricFogManager
// Assembly: Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 96BEA75E-C4F9-48CA-8D0E-33D7E4D3B52E
// Assembly location: G:\Temp\test\Unity.RenderPipelines.Universal.Runtime.dll

using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

#nullable disable
namespace VolumetricFogAndMist2
{
  [ExecuteInEditMode]
  [HelpURL("https://kronnect.com/guides/volumetric-fog-urp-adding-volumetric-fog-mist-to-your-scene/#ftoc-heading-1")]
  public class VolumetricFogManager : MonoBehaviour, IVolumetricFogManager
  {
    public static PointLightManager _pointLightManager;
    public static FogVoidManager _fogVoidManager;
    public static VolumetricFogManager _instance;
    [Tooltip("Directional light used as the Sun")]
    public Light sun;
    [Tooltip("Directional light used as the Moon")]
    public Light moon;
    [Tooltip("Flip depth texture. Use only as a workaround to a bug in URP if the depth shows inverted in GameView. Alternatively you can enable MSAA or HDR instead of using this option.")]
    public bool flipDepthTexture;
    [Tooltip("Enable this option to choose this manager when others could be loaded from sub-scenes")]
    public bool mainManager;
    [Tooltip("Optionally specify which transparent layers must be included in the depth prepass. Use only to avoid fog clipping with certain transparent objects.")]
    public LayerMask includeTransparent;
    [Tooltip("Cull mode for the transparent depth prepass")]
    public CullMode transparentCullMode;
    [Tooltip("Optionally specify which semi-transparent (materials using alpha clipping or cut-off) must be included in the depth prepass. Use only to avoid fog clipping with certain transparent objects.")]
    public LayerMask includeSemiTransparent;
    [Tooltip("Optionally determines the alpha cut off for semitransparent objects")]
    [Range(0.0f, 1f)]
    public float alphaCutOff;
    [Tooltip("Light scattering effect through fog")]
    [Range(0.0f, 1f)]
    public float scattering;
    [Tooltip("Threshold applied to input brightness")]
    public float scatteringThreshold;
    [Tooltip("Brightness multiplier applied to input")]
    public float scatteringIntensity;
    [Tooltip("Absorption or brightness decay inside the fog")]
    [Range(0.0f, 1f)]
    public float scatteringAbsorption;
    public Color scatteringTint;
    [Tooltip("Uses higher resolution intermediate buffers and edge-aware upsampling filter")]
    public bool scatteringHighQuality;
    [Range(1f, 8f)]
    public float downscaling;
    [Tooltip("Depth-based detection threshold for the upscaling reconstruction filter")]
    public float downscalingEdgeDepthThreshold;
    [Range(0.0f, 6f)]
    public int blurPasses;
    [Range(1f, 8f)]
    public float blurDownscaling;
    [Range(0.1f, 4f)]
    public float blurSpread;
    [Tooltip("Uses 16-bit RGBA floating point pixel format for rendering & blur fog volumes. If disabled, 8-bit RGBA pixel format will be used which can improve performance on certain devices. Note that if you use bloom or other HDR-based effects, you should enable this HDR option as well.")]
    public bool blurHDR;
    [Tooltip("Enable to use an edge-aware blur.")]
    public bool blurEdgePreserve;
    [Tooltip("Ignores blur when fog color intensity is below this value.")]
    public float blurEdgeDepthThreshold;
    [Range(0.0f, 0.2f)]
    public float ditherStrength;
    public const string SKW_FLIP_DEPTH_TEXTURE = "VF2_FLIP_DEPTH_TEXTURE";
    public const uint FOG_VOLUMES_RENDERING_LAYER = 131072;

    public string managerName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static bool allowFogVoidRotation
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static VolumetricFogManager instance
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static VolumetricFogManager GetManagerIfExists() => throw null;

    public static PointLightManager pointLightManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public static FogVoidManager fogVoidManager
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupLights() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupDepthPrePass() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static GameObject CreateFogVolume(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static GameObject CreateFogVoid(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static GameObject CreateFogSubVolume(string name) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VolumetricFogManager() => throw null;
  }
}
