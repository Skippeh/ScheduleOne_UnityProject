// Decompiled with JetBrains decompiler
// Type: VolumetricFogAndMist2.PointLightManager
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
  public class PointLightManager : MonoBehaviour, IVolumetricFogManager
  {
    public static bool usingPointLights;
    public const int MAX_POINT_LIGHTS = 16;
    [Header("Point Light Search Settings")]
    [Tooltip("Point lights are sorted by distance to tracking center object")]
    public Transform trackingCenter;
    [Tooltip("Point lights are sorted by camera distance every certain time interval to ensure the nearest 16 point lights are used.")]
    public float distanceSortTimeInterval;
    [Tooltip("Ignore point lights behind camera")]
    public bool excludeLightsBehind;
    [Header("Common Settings")]
    [Tooltip("Global inscattering multiplier for point lights")]
    public float inscattering;
    [Tooltip("Global intensity multiplier for point lights")]
    public float intensity;
    [Tooltip("Reduces light intensity near point lights")]
    public float insideAtten;
    public static readonly List<FogPointLight> pointLights;
    public static bool requireRefresh;
    public int lastPointLightsCount;
    public Vector4[] pointLightColorBuffer;
    public Vector4[] pointLightPositionBuffer;
    public float distanceSortLastTime;

    public string managerName
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SubmitPointLightData() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void RegisterPointLight(FogPointLight fogPointLight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void UnregisterPointLight(FogPointLight fogPointLight) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void TrackPointLights(bool forceImmediateUpdate = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int pointLightsDistanceComparer(FogPointLight l1, FogPointLight l2) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Refresh() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public PointLightManager() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static PointLightManager() => throw null;
  }
}
