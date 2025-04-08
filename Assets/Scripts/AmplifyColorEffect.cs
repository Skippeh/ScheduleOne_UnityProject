[global::UnityEngine.ImageEffectAllowedInSceneView]
[global::UnityEngine.ImageEffectTransformsToLDR]
[global::UnityEngine.ExecuteInEditMode]
[global::UnityEngine.AddComponentMenu("Image Effects/Amplify Color")]
public class AmplifyColorEffect : global::UnityEngine.MonoBehaviour
{
	public const int LutSize = 32;

	public const int LutWidth = 1024;

	public const int LutHeight = 32;

	private const int DepthCurveLutRange = 1024;

	public global::AmplifyColor.Tonemapping Tonemapper;

	public float Exposure;

	public float LinearWhitePoint;

	[global::UnityEngine.Serialization.FormerlySerializedAs("UseDithering")]
	public bool ApplyDithering;

	public global::AmplifyColor.Quality QualityLevel;

	public float BlendAmount;

	public global::UnityEngine.Texture LutTexture;

	public global::UnityEngine.Texture LutBlendTexture;

	public global::UnityEngine.Texture MaskTexture;

	public bool UseDepthMask;

	public global::UnityEngine.AnimationCurve DepthMaskCurve;

	public bool UseVolumes;

	public float ExitVolumeBlendTime;

	public global::UnityEngine.Transform TriggerVolumeProxy;

	public global::UnityEngine.LayerMask VolumeCollisionMask;

	private global::UnityEngine.Camera ownerCamera;

	private global::UnityEngine.Shader shaderBase;

	private global::UnityEngine.Shader shaderBlend;

	private global::UnityEngine.Shader shaderBlendCache;

	private global::UnityEngine.Shader shaderMask;

	private global::UnityEngine.Shader shaderMaskBlend;

	private global::UnityEngine.Shader shaderDepthMask;

	private global::UnityEngine.Shader shaderDepthMaskBlend;

	private global::UnityEngine.Shader shaderProcessOnly;

	private global::UnityEngine.RenderTexture blendCacheLut;

	private global::UnityEngine.Texture2D defaultLut;

	private global::UnityEngine.Texture2D depthCurveLut;

	private global::UnityEngine.Color32[] depthCurveColors;

	private global::UnityEngine.ColorSpace colorSpace;

	private global::AmplifyColor.Quality qualityLevel;

	private global::UnityEngine.Material materialBase;

	private global::UnityEngine.Material materialBlend;

	private global::UnityEngine.Material materialBlendCache;

	private global::UnityEngine.Material materialMask;

	private global::UnityEngine.Material materialMaskBlend;

	private global::UnityEngine.Material materialDepthMask;

	private global::UnityEngine.Material materialDepthMaskBlend;

	private global::UnityEngine.Material materialProcessOnly;

	private bool blending;

	private float blendingTime;

	private float blendingTimeCountdown;

	private global::System.Action onFinishBlend;

	private global::UnityEngine.AnimationCurve prevDepthMaskCurve;

	private bool volumesBlending;

	private float volumesBlendingTime;

	private float volumesBlendingTimeCountdown;

	private global::UnityEngine.Texture volumesLutBlendTexture;

	private float volumesBlendAmount;

	private global::UnityEngine.Texture worldLUT;

	private AmplifyColorVolumeBase currentVolumeLut;

	private global::UnityEngine.RenderTexture midBlendLUT;

	private bool blendingFromMidBlend;

	private global::AmplifyColor.VolumeEffect worldVolumeEffects;

	private global::AmplifyColor.VolumeEffect currentVolumeEffects;

	private global::AmplifyColor.VolumeEffect blendVolumeEffects;

	private float worldExposure;

	private float currentExposure;

	private float blendExposure;

	private float effectVolumesBlendAdjust;

	private global::System.Collections.Generic.List<AmplifyColorVolumeBase> enteredVolumes;

	private AmplifyColorTriggerProxyBase actualTriggerProxy;

	[global::UnityEngine.HideInInspector]
	public global::AmplifyColor.VolumeEffectFlags EffectFlags;

	[global::UnityEngine.SerializeField]
	[global::UnityEngine.HideInInspector]
	private string sharedInstanceID;

	private bool silentError;

	public global::UnityEngine.Texture2D DefaultLut => null;

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

	private bool CheckShader(global::UnityEngine.Shader s)
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

	private void VolumesBlendTo(global::UnityEngine.Texture blendTargetLUT, float blendTimeInSec)
	{
	}

	public void BlendTo(global::UnityEngine.Texture blendTargetLUT, float blendTimeInSec, global::System.Action onFinishBlend)
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

	private global::UnityEngine.Texture2D CreateDefaultLut()
	{
		return null;
	}

	private global::UnityEngine.Texture2D CreateDepthCurveLut()
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

	private bool CheckMaterialAndShader(global::UnityEngine.Material material, string name)
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

	private void SafeRelease<T>(ref T obj) where T : global::UnityEngine.Object
	{
	}

	private void ReleaseTextures()
	{
	}

	public static bool ValidateLutDimensions(global::UnityEngine.Texture lut)
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

	private void OnRenderImage(global::UnityEngine.RenderTexture source, global::UnityEngine.RenderTexture destination)
	{
	}
}
