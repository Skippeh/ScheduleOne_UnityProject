// Decompiled with JetBrains decompiler
// Type: VolumetricFogAndMist2.FogVoid
// Assembly: Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 96BEA75E-C4F9-48CA-8D0E-33D7E4D3B52E
// Assembly location: G:\Temp\test\Unity.RenderPipelines.Universal.Runtime.dll

using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
namespace VolumetricFogAndMist2
{
  [ExecuteInEditMode]
  public class FogVoid : MonoBehaviour
  {
    [Range(0.0f, 1f)]
    public float roundness;
    [Range(0.0f, 1f)]
    public float falloff;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDrawGizmosSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FogVoid() => throw null;
  }
}
