// Decompiled with JetBrains decompiler
// Type: VolumetricFogAndMist2.VolumetricFogRenderFeature
// Assembly: Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 96BEA75E-C4F9-48CA-8D0E-33D7E4D3B52E
// Assembly location: G:\Temp\test\Unity.RenderPipelines.Universal.Runtime.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

#nullable disable
namespace VolumetricFogAndMist2
{
  public class VolumetricFogRenderFeature : ScriptableRendererFeature
  {
    [SerializeField]
    [HideInInspector]
    public Shader blurShader;
    public VolumetricFogRenderFeature.VolumetricFogRenderPass fogRenderPass;
    public VolumetricFogRenderFeature.BlurRenderPass blurRenderPass;
    public static bool installed;
    public static bool isRenderingBeforeTransparents;
    public RenderPassEvent renderPassEvent;
    [Tooltip("Specify which fog volumes will be rendered by this feature.")]
    public LayerMask fogLayerMask;
    [Tooltip("Specify which cameras can execute this render feature. If you have several cameras in your scene, make sure only the correct cameras use this feature in order to optimize performance.")]
    public LayerMask cameraLayerMask;
    [Tooltip("Ignores reflection probes from executing this render feature")]
    public bool ignoreReflectionProbes;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static int GetScaledSize(int size, float factor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Create() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void AddRenderPasses(
      ScriptableRenderer renderer,
      ref RenderingData renderingData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VolumetricFogRenderFeature() => throw null;

    public static class ShaderParams
    {
      public const string LightBufferName = "_LightBuffer";
      public static int LightBuffer;
      public static int LightBufferSize;
      public static int MainTex;
      public static int BlurRT;
      public static int BlurRT2;
      public static int MiscData;
      public static int ForcedInvisible;
      public static int DownsampledDepth;
      public static int BlueNoiseTexture;
      public static int BlurScale;
      public static int Downscaling;
      public static int ScatteringData;
      public static int ScatteringTint;
      public static int BlurredTex;
      public const string SKW_DITHER = "DITHER";
      public const string SKW_EDGE_PRESERVE = "EDGE_PRESERVE";
      public const string SKW_EDGE_PRESERVE_UPSCALING = "EDGE_PRESERVE_UPSCALING";
      public const string SKW_SCATTERING_HQ = "SCATTERING_HQ";

      [MethodImpl(MethodImplOptions.NoInlining)]
      static ShaderParams() => throw null;
    }

    public class VolumetricFogRenderPass : ScriptableRenderPass
    {
      public const string m_ProfilerTag = "Volumetric Fog Light Buffer Rendering";
      public static FilteringSettings filteringSettings;
      public static readonly List<ShaderTagId> shaderTagIdList;
      public RTHandle m_LightBuffer;
      public VolumetricFogRenderFeature settings;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public VolumetricFogRenderPass() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void CleanUp() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Setup(VolumetricFogRenderFeature settings) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void Configure(
        CommandBuffer cmd,
        RenderTextureDescriptor cameraTextureDescriptor)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      static VolumetricFogRenderPass() => throw null;
    }

    public class BlurRenderPass : ScriptableRenderPass
    {
      public const string m_ProfilerTag = "Volumetric Fog Render Feature";
      public ScriptableRenderer renderer;
      public static Material mat;
      public static RenderTextureDescriptor sourceDesc;
      public static VolumetricFogManager manager;
      public static readonly VolumetricFogRenderFeature.BlurRenderPass.PassData passData;
      public static VolumetricFogRenderFeature.BlurRenderPass.ScatteringMipData[] rt;
      public const int PYRAMID_MAX_LEVELS = 5;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Setup(
        Shader shader,
        ScriptableRenderer renderer,
        VolumetricFogRenderFeature settings)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void Configure(
        CommandBuffer cmd,
        RenderTextureDescriptor cameraTextureDescriptor)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void ExecutePass(
        VolumetricFogRenderFeature.BlurRenderPass.PassData passData,
        CommandBuffer cmd)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void ComputeScattering(CommandBuffer cmd, RTHandle source, Material mat)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void FullScreenBlit(
        CommandBuffer cmd,
        RenderTargetIdentifier source,
        RenderTargetIdentifier destination,
        Material material,
        int passIndex)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void Cleanup() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public BlurRenderPass() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static BlurRenderPass() => throw null;

      public enum Pass
      {
        BlurHorizontal,
        BlurVertical,
        BlurVerticalAndBlend,
        UpscalingBlend,
        DownscaleDepth,
        BlurVerticalFinal,
        Resample,
        ResampleAndCombine,
        ScatteringPrefilter,
        ScatteringBlend,
      }

      public class PassData
      {
        public RTHandle source;

        [MethodImpl(MethodImplOptions.NoInlining)]
        public PassData() => throw null;
      }

      public struct ScatteringMipData
      {
        public int rtDown;
        public int rtUp;
        public int width;
        public int height;
      }
    }
  }
}
