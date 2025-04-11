// Decompiled with JetBrains decompiler
// Type: VolumetricFogAndMist2.FogVoidManager
// Assembly: Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 96BEA75E-C4F9-48CA-8D0E-33D7E4D3B52E
// Assembly location: G:\Temp\test\Unity.RenderPipelines.Universal.Runtime.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
namespace VolumetricFogAndMist2
{
  [ExecuteInEditMode]
  [DefaultExecutionOrder(100)]
  public class FogVoidManager : MonoBehaviour, IVolumetricFogManager
  {
    public static bool usingVoids;
    public const int MAX_FOG_VOID = 8;
    [Header("Void Search Settings")]
    public Transform trackingCenter;
    [Tooltip("Fog voids are sorted by camera distance every certain time interval to ensure the nearest 8 voids are used.")]
    public float distanceSortTimeInterval;
    public static readonly List<FogVoid> fogVoids;
    public Vector4[] fogVoidPositions;
    public Vector4[] fogVoidSizes;
    public Matrix4x4[] fogVoidMatrices;
    public float distanceSortLastTime;
    public static bool requireRefresh;
    public int lastFogVoidCount;

    public string managerName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SubmitFogVoidData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RegisterFogVoid(FogVoid fogVoid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnregisterFogVoid(FogVoid fogVoid) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TrackFogVoids(bool forceImmediateUpdate = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int fogVoidDistanceComparer(FogVoid v1, FogVoid v2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Refresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FogVoidManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static FogVoidManager() => throw null;
  }
}
