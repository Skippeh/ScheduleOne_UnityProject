// Decompiled with JetBrains decompiler
// Type: VolumetricFogAndMist2.VolumetricFogProfile
// Assembly: Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 96BEA75E-C4F9-48CA-8D0E-33D7E4D3B52E
// Assembly location: G:\Temp\test\Unity.RenderPipelines.Universal.Runtime.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

#nullable disable
namespace VolumetricFogAndMist2
{
  [CreateAssetMenu(menuName = "Volumetric Fog \u008B& Mist/Fog Profile", fileName = "VolumetricFogProfile", order = 1001)]
  public class VolumetricFogProfile : ScriptableObject
  {
    [Header("Rendering")]
    [Range(1f, 16f)]
    public int raymarchQuality;
    [Tooltip("Determines the minimum step size. Increase to improve performance / decrease to improve accuracy. When increasing this value, you can also increase 'Jittering' amount to improve quality.")]
    public float raymarchMinStep;
    public float jittering;
    [Range(0.0f, 2f)]
    public float dithering;
    [Tooltip("The render queue for this renderer. By default, all transparent objects use a render queue of 3000. Use a lower value to render before all transparent objects.")]
    public int renderQueue;
    [Tooltip("Optional sorting layer Id (number) for this renderer. By default 0. Usually used to control the order with other transparent renderers, like Sprite Renderer.")]
    public int sortingLayerID;
    [Tooltip("Optional sorting order for this renderer. Used to control the order with other transparent renderers, like Sprite Renderer.")]
    public int sortingOrder;
    [Header("Density")]
    [Tooltip("Do not use any noise at all")]
    public bool constantDensity;
    public Texture2D noiseTexture;
    [Tooltip("Size of the final noise used by the shader. Reduce to improve performance on old devices.")]
    public VolumetricFogNoiseSize noiseTextureOptimizedSize;
    [Range(0.0f, 3f)]
    public float noiseStrength;
    public float noiseScale;
    public float noiseFinalMultiplier;
    public bool useDetailNoise;
    public Texture3D detailTexture;
    public float detailScale;
    [Range(0.0f, 1f)]
    public float detailStrength;
    public float detailOffset;
    public float density;
    [Header("Geometry")]
    public VolumetricFogShape shape;
    [Range(0.0f, 1f)]
    public float border;
    [Tooltip("Ignores volume height and use a custom height defined by this profile")]
    public bool customHeight;
    public float height;
    public float verticalOffset;
    [Tooltip("When enabled, makes fog appear at certain distance from a camera")]
    public float distance;
    [Range(0.0f, 1f)]
    public float distanceFallOff;
    [Tooltip("Maximum distance from camera")]
    public float maxDistance;
    [Range(0.0f, 1f)]
    public float maxDistanceFallOff;
    [Tooltip("Fits the fog altitude to the terrain heightmap")]
    public bool terrainFit;
    public VolumetricFog.HeightmapCaptureResolution terrainFitResolution;
    [Tooltip("Which objects will be included in the heightmap capture. By default all objects are included but you may want to restrict this to just the terrain.")]
    public LayerMask terrainLayerMask;
    [Tooltip("The height of fog above terrain surface.")]
    public float terrainFogHeight;
    public float terrainFogMinAltitude;
    public float terrainFogMaxAltitude;
    [Header("Colors")]
    [ColorUsage(false)]
    public Color albedo;
    public bool enableDepthGradient;
    [GradientUsage(true)]
    public Gradient depthGradient;
    public float depthGradientMaxDistance;
    public bool enableHeightGradient;
    [GradientUsage(true)]
    public Gradient heightGradient;
    public float brightness;
    [Range(0.0f, 2f)]
    public float deepObscurance;
    public Color specularColor;
    [Range(0.0f, 1f)]
    public float specularThreshold;
    [Range(0.0f, 1f)]
    public float specularIntensity;
    [Header("Animation")]
    public float turbulence;
    public Vector3 windDirection;
    public bool useCustomDetailNoiseWindDirection;
    public Vector3 detailNoiseWindDirection;
    [Header("Directional Light")]
    [Tooltip("Enable to synchronize fog light intensity and color with the Sun and the Moon (must be assigned into Volumetric Fog Manager)")]
    public bool dayNightCycle;
    [Tooltip("When day/night cycle option is disabled, customize the direction of the Sun light.")]
    public Vector3 sunDirection;
    [Tooltip("Custom sun color when day/night cycle is disabled")]
    public Color sunColor;
    [Tooltip("Custom sun intensity when day/night cycle is disabled")]
    public float sunIntensity;
    [Tooltip("Ambient light influence")]
    public float ambientLightMultiplier;
    public DiffusionModel lightDiffusionModel;
    [Range(0.0f, 256f)]
    public float lightDiffusionPower;
    public float lightDiffusionIntensity;
    public bool receiveShadows;
    [Range(0.0f, 1f)]
    public float shadowIntensity;
    [Tooltip("Removes shadowed fog")]
    [Range(0.0f, 1f)]
    public float shadowCancellation;
    public float shadowMaxDistance;
    [Tooltip("Uses the directional light cookie")]
    public bool cookie;
    [Header("Distant Fog")]
    [Tooltip("Enables exponential distant fog. Use this option to cover horizon/sky/far distances with optimal performance")]
    public bool distantFog;
    public float distantFogStartDistance;
    public float distantFogDistanceDensity;
    public float distantFogMaxHeight;
    public float distantFogHeightDensity;
    public Color distantFogColor;
    public float distantFogDiffusionIntensity;
    public int distantFogRenderQueue;
    public float distantFogBaseAltitude;
    [NonSerialized]
    public Texture2D depthGradientTex;
    [NonSerialized]
    public Texture2D heightGradientTex;
    public Color[] depthGradientColors;
    public Color[] heightGradientColors;
    public static readonly List<float> colorKeysTimes;
    public static readonly List<float> alphaKeysTimes;

    public event OnSettingsChanged onSettingsChanged
    {
      [MethodImpl(MethodImplOptions.NoInlining)] add => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] remove => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ValidateSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Lerp(VolumetricFogProfile p1, VolumetricFogProfile p2, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LerpGradient(Gradient g, Gradient a, Gradient b, float t) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VolumetricFogProfile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VolumetricFogProfile() => throw null;
  }
}
