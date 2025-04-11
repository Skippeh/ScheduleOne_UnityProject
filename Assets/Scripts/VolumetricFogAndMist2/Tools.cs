// Decompiled with JetBrains decompiler
// Type: VolumetricFogAndMist2.Tools
// Assembly: Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 96BEA75E-C4F9-48CA-8D0E-33D7E4D3B52E
// Assembly location: G:\Temp\test\Unity.RenderPipelines.Universal.Runtime.dll

using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
namespace VolumetricFogAndMist2
{
  public static class Tools
  {
    public static Color ColorBlack;
    public static Mesh _fullScreenMesh;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CheckCamera(ref Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static VolumetricFogManager CheckMainManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void CheckManager<T>(ref T manager) where T : Component => throw null;

    public static Mesh fullscreenMesh
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static Tools() => throw null;
  }
}
