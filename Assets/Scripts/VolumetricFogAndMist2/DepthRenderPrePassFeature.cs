// Decompiled with JetBrains decompiler
// Type: VolumetricFogAndMist2.DepthRenderPrePassFeature
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
  public class DepthRenderPrePassFeature : ScriptableRendererFeature
  {
    public DepthRenderPrePassFeature.DepthRenderPass m_ScriptablePass;
    public static bool installed;
    [Tooltip("Specify which cameras can execute this render feature. If you have several cameras in your scene, make sure only the correct cameras use this feature in order to optimize performance.")]
    public LayerMask cameraLayerMask;
    [Tooltip("Ignores reflection probes from executing this render feature")]
    public bool ignoreReflectionProbes;
    [Tooltip("Uses an optimized shader to compute depth for the objects included in the transparent pass. If this option is disabled, the original shader of the objects will be used instead (this can be useful if the original shaders include vertex transformations).")]
    public bool useOptimizedDepthOnlyShader;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void Create() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override void AddRenderPasses(
      ScriptableRenderer renderer,
      ref RenderingData renderingData)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DepthRenderPrePassFeature() => throw null;

    public class DepthRenderPass : ScriptableRenderPass
    {
      public const string m_ProfilerTag = "CustomDepthPrePass";
      public const string m_DepthOnlyShader = "Hidden/VolumetricFog2/DepthOnly";
      public static readonly List<Renderer> cutOutRenderers;
      public static int transparentLayerMask;
      public static int alphaCutoutLayerMask;
      public static FilteringSettings filterSettings;
      public static int currentCutoutLayerMask;
      public static readonly List<ShaderTagId> shaderTagIdList;
      public RTHandle m_Depth;
      public static Material depthOnlyMaterial;
      public static Material depthOnlyMaterialCutOff;
      public static Material[] depthOverrideMaterials;
      public static Shader fogShader;
      public static DepthRenderPrePassFeature options;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public DepthRenderPass() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void Setup(DepthRenderPrePassFeature options) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void SetupKeywords() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void SetupLayerMasks(int transparentLayerMask, int alphaCutoutLayerMask)
      {
        throw null;
      }

      [MethodImpl(MethodImplOptions.NoInlining)]
      public static void FindAlphaClippingRenderers() => throw null;

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
      public override void FrameCleanup(CommandBuffer cmd) => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      public void CleanUp() => throw null;

      [MethodImpl(MethodImplOptions.NoInlining)]
      static DepthRenderPass() => throw null;
    }
  }
}
