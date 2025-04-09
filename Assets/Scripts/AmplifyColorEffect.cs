using System;
using System.Collections.Generic;
using AmplifyColor;
using UnityEngine;
using UnityEngine.Serialization;

[ImageEffectAllowedInSceneView]
[ImageEffectTransformsToLDR]
[ExecuteInEditMode]
[AddComponentMenu("Image Effects/Amplify Color")]
public class AmplifyColorEffect : MonoBehaviour
{
	public const int LutSize = 32;

	public const int LutWidth = 1024;

	public const int LutHeight = 32;

	private const int DepthCurveLutRange = 1024;

	public Tonemapping Tonemapper;

	public float Exposure;

	public float LinearWhitePoint;

	[FormerlySerializedAs("UseDithering")]
	public bool ApplyDithering;

	public Quality QualityLevel;

	public float BlendAmount;

	public Texture LutTexture;

	public Texture LutBlendTexture;

	public Texture MaskTexture;

	public bool UseDepthMask;

	public AnimationCurve DepthMaskCurve;

	public bool UseVolumes;

	public float ExitVolumeBlendTime;

	public Transform TriggerVolumeProxy;

	public LayerMask VolumeCollisionMask;

	private Camera ownerCamera;

	private Shader shaderBase;

	private Shader shaderBlend;

	private Shader shaderBlendCache;

	private Shader shaderMask;

	private Shader shaderMaskBlend;

	private Shader shaderDepthMask;

	private Shader shaderDepthMaskBlend;

	private Shader shaderProcessOnly;

	private RenderTexture blendCacheLut;

	private Texture2D defaultLut;

	private Texture2D depthCurveLut;

	private Color32[] depthCurveColors;

	private ColorSpace colorSpace;

	private Quality qualityLevel;

	private Material materialBase;

	private Material materialBlend;

	private Material materialBlendCache;

	private Material materialMask;

	private Material materialMaskBlend;

	private Material materialDepthMask;

	private Material materialDepthMaskBlend;

	private Material materialProcessOnly;

	private bool blending;

	private float blendingTime;

	private float blendingTimeCountdown;

	private Action onFinishBlend;

	private AnimationCurve prevDepthMaskCurve;

	private bool volumesBlending;

	private float volumesBlendingTime;

	private float volumesBlendingTimeCountdown;

	private Texture volumesLutBlendTexture;

	private float volumesBlendAmount;

	private Texture worldLUT;

	private AmplifyColorVolumeBase currentVolumeLut;

	private RenderTexture midBlendLUT;

	private bool blendingFromMidBlend;

	private VolumeEffect worldVolumeEffects;

	private VolumeEffect currentVolumeEffects;

	private VolumeEffect blendVolumeEffects;

	private float worldExposure;

	private float currentExposure;

	private float blendExposure;

	private float effectVolumesBlendAdjust;

	private List<AmplifyColorVolumeBase> enteredVolumes;

	private AmplifyColorTriggerProxyBase actualTriggerProxy;

	[HideInInspector]
	public VolumeEffectFlags EffectFlags;

	[SerializeField]
	[HideInInspector]
	private string sharedInstanceID;

	private bool silentError;

	public Texture2D DefaultLut => null;

	public bool IsBlending => false;

	private float effectVolumesBlendAdjusted => 0f;

	public string SharedInstanceID => null;

	public bool WillItBlend => false;

	public void NewSharedInstanceID()
	{
	}

	private void ReportMissingShaders()
	{
	}

	private void ReportNotSupported()
	{
	}

	private bool CheckShader(Shader s)
	{
		return false;
	}

	private bool CheckShaders()
	{
		return false;
	}

	private bool CheckSupport()
	{
		return false;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void VolumesBlendTo(Texture blendTargetLUT, float blendTimeInSec)
	{
	}

	public void BlendTo(Texture blendTargetLUT, float blendTimeInSec, Action onFinishBlend)
	{
	}

	private void CheckCamera()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	public void EnterVolume(AmplifyColorVolumeBase volume)
	{
	}

	public void ExitVolume(AmplifyColorVolumeBase volume)
	{
	}

	private void UpdateVolumes()
	{
	}

	private void SetupShader()
	{
	}

	private void ReleaseMaterials()
	{
	}

	private Texture2D CreateDefaultLut()
	{
		return null;
	}

	private Texture2D CreateDepthCurveLut()
	{
		return null;
	}

	private void UpdateDepthCurveLut()
	{
	}

	private void CheckUpdateDepthCurveLut()
	{
	}

	private void CreateHelperTextures()
	{
	}

	private bool CheckMaterialAndShader(Material material, string name)
	{
		return false;
	}

	private bool CreateMaterials()
	{
		return false;
	}

	private void SetMaterialKeyword(string keyword, bool state)
	{
	}

	private void SafeRelease<T>(ref T obj) where T : UnityEngine.Object
	{
	}

	private void ReleaseTextures()
	{
	}

	public static bool ValidateLutDimensions(Texture lut)
	{
		return false;
	}

	private void UpdatePostEffectParams()
	{
	}

	private int ComputeShaderPass()
	{
		return 0;
	}

	private void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
	}
}
