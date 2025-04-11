// Decompiled with JetBrains decompiler
// Type: VolumetricFogAndMist2.FogPointLight
// Assembly: Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 96BEA75E-C4F9-48CA-8D0E-33D7E4D3B52E
// Assembly location: G:\Temp\test\Unity.RenderPipelines.Universal.Runtime.dll

using System;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
namespace VolumetricFogAndMist2
{
  [ExecuteInEditMode]
  public class FogPointLight : MonoBehaviour
  {
    [NonSerialized]
    public Light pointLight;
    [Tooltip("Inscattering multiplier for this point light")]
    public float inscattering;
    [Tooltip("Intensity multiplier for this point light")]
    public float intensity;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FogPointLight() => throw null;
  }
}
