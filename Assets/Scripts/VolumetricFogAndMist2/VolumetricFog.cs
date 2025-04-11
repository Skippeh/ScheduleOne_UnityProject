// Decompiled with JetBrains decompiler
// Type: VolumetricFogAndMist2.VolumetricFog
// Assembly: Unity.RenderPipelines.Universal.Runtime, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 96BEA75E-C4F9-48CA-8D0E-33D7E4D3B52E
// Assembly location: G:\Temp\test\Unity.RenderPipelines.Universal.Runtime.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.Universal;

#nullable disable
namespace VolumetricFogAndMist2
{
  [ExecuteInEditMode]
  [DefaultExecutionOrder(100)]
  [HelpURL("https://kronnect.com/guides/volumetric-fog-urp-introduction/")]
  public class VolumetricFog : MonoBehaviour
  {
    public VolumetricFogProfile profile;
    [Tooltip("Supports Unity native lights including point and spot lights.")]
    public bool enableNativeLights;
    [Tooltip("Multiplier to native lights intensity")]
    public float nativeLightsMultiplier;
    [Tooltip("Enable fast point lights. This option is much faster than native lights. However, if you enable native lights, this option can't be enabled as point lights are already included in the native lights support.")]
    public bool enablePointLights;
    [Tooltip("Supports Adaptative Probe Volumes (Unity 2023.1+)")]
    public bool enableAPV;
    [Tooltip("Multiplier to native lights intensity")]
    public float apvIntensityMultiplier;
    public bool enableVoids;
    [Tooltip("Makes this fog volume follow another object automatically")]
    public bool enableFollow;
    public Transform followTarget;
    public VolumetricFogFollowMode followMode;
    public bool followIncludeDistantFog;
    public Vector3 followOffset;
    [Tooltip("Fades in/out fog effect when reference controller enters the fog volume.")]
    public bool enableFade;
    [Tooltip("Fog volume blending starts when reference controller is within this fade distance to any volume border.")]
    public float fadeDistance;
    [Tooltip("If this option is disabled, the fog disappears when the reference controller exits the volume and appears when the controller enters the volume. Enable this option to fade out the fog volume when the controller enters the volume. ")]
    public bool fadeOut;
    [Tooltip("The controller (player or camera) to check if enters the fog volume.")]
    public Transform fadeController;
    [Tooltip("Enable sub-volume blending.")]
    public bool enableSubVolumes;
    [Tooltip("Allowed subVolumes. If no subvolumes are specified, any subvolume entered by this controller will affect this fog volume.")]
    public List<VolumetricFogSubVolume> subVolumes;
    [Tooltip("Customize how this fog volume data is updated and animated")]
    public bool enableUpdateModeOptions;
    public VolumetricFogUpdateMode updateMode;
    [Tooltip("Camera used to compute visibility of this fog volume. If not set, the system will use the main camera.")]
    public Camera updateModeCamera;
    public Bounds updateModeBounds;
    [Tooltip("Shows the fog volume boundary in Game View")]
    public bool showBoundary;
    [NonSerialized]
    public MeshRenderer meshRenderer;
    public MeshFilter mf;
    public Material fogMat;
    public Material noiseMat;
    public Material turbulenceMat;
    public Shader fogShader;
    public RenderTexture rtNoise;
    public RenderTexture rtTurbulence;
    public float turbAcum;
    public Vector3 windAcum;
    public Vector3 detailNoiseWindAcum;
    public Vector3 sunDir;
    public float dayLight;
    public float moonLight;
    public List<string> shaderKeywords;
    public string[] keywordsArray;
    public Texture3D detailTex;
    public Texture3D refDetailTex;
    public Mesh debugMesh;
    public Material fogDebugMat;
    public VolumetricFogProfile activeProfile;
    public VolumetricFogProfile lerpProfile;
    public Vector3 lastControllerPosition;
    public float alphaMultiplier;
    public Material distantFogMat;
    public bool profileIsInstanced;
    public bool requireUpdateMaterial;
    public ColorSpace currentAppliedColorSpace;
    public static Texture2D blueNoiseTex;
    public Color ambientMultiplied;
    [NonSerialized]
    public bool forceTerrainCaptureUpdate;
    public static readonly List<VolumetricFog> volumetricFogs;
    public Bounds cameraFrustumBounds;
    public static readonly Vector3[] frustumVertices;
    public Vector3 cameraFrustumLastPosition;
    public Quaternion cameraFrustumLastRotation;
    public bool enableFogOfWar;
    public Vector3 fogOfWarCenter;
    public bool fogOfWarIsLocal;
    public Vector3 fogOfWarSize;
    public bool fogOfWarShowCoverage;
    [Range(32f, 2048f)]
    public int fogOfWarTextureSize;
    [Tooltip("Delay before the fog alpha is restored. A value of 0 keeps the fog cleared forever.")]
    [Range(0.0f, 100f)]
    public float fogOfWarRestoreDelay;
    [Range(0.0f, 25f)]
    public float fogOfWarRestoreDuration;
    [Range(0.0f, 1f)]
    public float fogOfWarSmoothness;
    public bool fogOfWarBlur;
    public const int MAX_SIMULTANEOUS_TRANSITIONS = 10000;
    public bool canDestroyFOWTexture;
    public bool maskEditorEnabled;
    public MASK_TEXTURE_BRUSH_MODE maskBrushMode;
    public Color maskBrushColor;
    [Range(1f, 128f)]
    public int maskBrushWidth;
    [Range(0.0f, 1f)]
    public float maskBrushFuzziness;
    [Range(0.0f, 1f)]
    public float maskBrushOpacity;
    [SerializeField]
    public Texture2D _fogOfWarTexture;
    public Color32[] fogOfWarColorBuffer;
    public VolumetricFog.FogOfWarTransition[] fowTransitionList;
    public int lastTransitionPos;
    public Dictionary<int, int> fowTransitionIndices;
    public bool requiresTextureUpload;
    public Material fowBlur;
    public RenderTexture fowBlur1;
    public RenderTexture fowBlur2;
    public const string SURFACE_CAM_NAME = "SurfaceCam";
    public RenderTexture rt;
    public Camera surfaceCam;
    public Matrix4x4 camMatrix;
    public Vector3 lastCamPos;
    public LayerMask lastTerrainLayerMask;
    public UniversalRendererData depthRendererData;
    public static Matrix4x4 identityMatrix;

    public VolumetricFogProfile settings
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    public Material material
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    [RuntimeInitializeOnLoadMethod]
    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void Init() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnEnable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDisable() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDidApplyAnimationProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnValidate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void OnDrawGizmosSelected() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void LateUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool CanUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CalculateFrustumBounds(Camera camera) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CalculateFrustumVertices(Camera cam) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateNoise() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMaterialProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMaterialProperties(bool forceTerrainCaptureUpdate) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateMaterialPropertiesNow(bool skipTerrainCapture = false, bool forceTerrainCaptureUpdate = false)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ComputeActiveProfile() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float ComputeVolumeFade(Transform transform, float fadeDistance) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ApplyProfileSettings() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateDistantFogPropertiesNow() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateFogOfWarMaterialBoundsProperties() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void FindAlphaClippingObjects() => throw null;

    public Vector3 anchoredFogOfWarCenter
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
    }

    public Texture2D fogOfWarTexture
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FogOfWarInit() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FogOfWarDestroy() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ReloadFogOfWarTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void EnsureTextureIsReadable(Texture2D tex) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void FogOfWarUpdateTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetScaledSize(int size, float factor) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void UpdateFogOfWar(bool forceUpload = false) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFowBlurTexture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CreateFoWBlurRTs() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFogOfWarAlpha(Vector3 worldPosition, float radius, float fogNewAlpha)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFogOfWarAlpha(
      Vector3 worldPosition,
      float radius,
      float fogNewAlpha,
      float duration = 0.0f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFogOfWarAlpha(
      Vector3 worldPosition,
      float radius,
      float fogNewAlpha,
      float duration = 0.0f,
      float smoothness = 0.0f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFogOfWarAlpha(
      Vector3 worldPosition,
      float radius,
      float fogNewAlpha,
      bool blendAlpha = false,
      float duration = 0.0f,
      float smoothness = 0.0f,
      float restoreDelay = 0.0f,
      float restoreDuration = 2f,
      float restoreToAlphaValue = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFogOfWarAlpha(Bounds bounds, float fogNewAlpha, float duration = 0.0f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFogOfWarAlpha(
      Bounds bounds,
      float fogNewAlpha,
      float duration,
      float smoothness)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFogOfWarAlpha(
      Bounds bounds,
      float fogNewAlpha,
      bool blendAlpha,
      float duration = 0.0f,
      float smoothness = 0.0f,
      float restoreDelay = 0.0f,
      float restoreDuration = 2f,
      float restoreToAlpha = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFogOfWarAlpha(
      Collider collider,
      float fogNewAlpha,
      bool blendAlpha = false,
      float duration = 0.0f,
      float smoothness = 0.0f,
      float restoreDelay = 0.0f,
      float restoreDuration = 2f,
      float restoreToAlpha = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetFogOfWarAlpha(
      GameObject go,
      float fogNewAlpha,
      float duration = 0.0f,
      float restoreDelay = 0.0f,
      float restoreDuration = 2f,
      float restoreToAlpha = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float Sign(float p1x, float p1z, float p2x, float p2z, float p3x, float p3z)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool PointInTriangle(
      float x,
      float z,
      float v1x,
      float v1z,
      float v2x,
      float v2z,
      float v3x,
      float v3z)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetFogOfWarAlpha(Vector3 worldPosition, float radius, float alpha = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetFogOfWarAlpha(Bounds bounds, float alpha = 1f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetFogOfWarAlpha(Vector3 position, Vector3 size, float alpha = 1f) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetFogOfWarAlpha(Vector3 position, float extentsX, float extentsZ, float alpha = 1f)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ResetFogOfWar(float alpha = 1f) => throw null;

    public Color32[] fogOfWarTextureData
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get => throw null;
      [MethodImpl(MethodImplOptions.NoInlining)] set => throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddFogOfWarTransitionSlot(
      int x,
      int y,
      byte initialAlpha,
      byte targetAlpha,
      float delay,
      float duration,
      byte restoreToAlpha,
      float restoreDelay,
      float restoreDuration)
    {
      throw null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public float GetFogOfWarAlpha(Vector3 worldPosition) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void DisposeSurfaceCapture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CheckSurfaceCapture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SurfaceCaptureSupportCheck() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CheckAndAssignDepthRenderer(UniversalAdditionalCameraData camData) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void PerformHeightmapCapture() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetupCameraCaptureMatrix() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SurfaceCaptureUpdate() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void ComputeSufaceTransform(Matrix4x4 proj, Matrix4x4 view) => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public VolumetricFog() => throw null;

    [MethodImpl(MethodImplOptions.NoInlining)]
    static VolumetricFog() => throw null;

    public struct FogOfWarTransition
    {
      public bool enabled;
      public int x;
      public int y;
      public float startTime;
      public float startDelay;
      public float duration;
      public int initialAlpha;
      public int targetAlpha;
      public int restoreToAlpha;
      public float restoreDelay;
      public float restoreDuration;
    }

    public enum HeightmapCaptureResolution
    {
      _64 = 64, // 0x00000040
      _128 = 128, // 0x00000080
      _256 = 256, // 0x00000100
      _512 = 512, // 0x00000200
      _1024 = 1024, // 0x00000400
    }
  }
}
