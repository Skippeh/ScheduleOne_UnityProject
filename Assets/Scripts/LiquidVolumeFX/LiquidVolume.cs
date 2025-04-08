namespace LiquidVolumeFX
{
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.HelpURL("https://kronnect.com/support")]
	[global::UnityEngine.AddComponentMenu("Effects/Liquid Volume")]
	[global::UnityEngine.DisallowMultipleComponent]
	public class LiquidVolume : global::UnityEngine.MonoBehaviour
	{
		private struct MeshCache
		{
			public global::UnityEngine.Vector3[] verticesSorted;

			public global::UnityEngine.Vector3[] verticesUnsorted;

			public int[] indices;
		}

		private delegate float MeshVolumeCalcFunction(float level01, float yExtent);

		private static class ShaderParams
		{
			public static int PointLightInsideAtten;

			public static int PointLightColorArray;

			public static int PointLightPositionArray;

			public static int PointLightCount;

			public static int GlossinessInt;

			public static int DoubleSidedBias;

			public static int BackDepthBias;

			public static int Muddy;

			public static int Alpha;

			public static int AlphaCombined;

			public static int SparklingIntensity;

			public static int SparklingThreshold;

			public static int DepthAtten;

			public static int SmokeColor;

			public static int SmokeAtten;

			public static int SmokeSpeed;

			public static int SmokeHeightAtten;

			public static int SmokeRaySteps;

			public static int LiquidRaySteps;

			public static int FlaskBlurIntensity;

			public static int FoamColor;

			public static int FoamRaySteps;

			public static int FoamDensity;

			public static int FoamWeight;

			public static int FoamBottom;

			public static int FoamTurbulence;

			public static int RefractTex;

			public static int FlaskThickness;

			public static int Size;

			public static int Scale;

			public static int Center;

			public static int SizeWorld;

			public static int DepthAwareOffset;

			public static int Turbulence;

			public static int TurbulenceSpeed;

			public static int MurkinessSpeed;

			public static int Color1;

			public static int Color2;

			public static int EmissionColor;

			public static int LightColor;

			public static int LightDir;

			public static int LevelPos;

			public static int UpperLimit;

			public static int LowerLimit;

			public static int FoamMaxPos;

			public static int CullMode;

			public static int ZTestMode;

			public static int NoiseTex;

			public static int NoiseTexUnwrapped;

			public static int GlobalRefractionTexture;

			public static int RotationMatrix;

			public static int QueueOffset;

			public static int PreserveSpecular;
		}

		public static bool FORCE_GLES_COMPATIBILITY;

		[global::UnityEngine.SerializeField]
		private global::LiquidVolumeFX.TOPOLOGY _topology;

		[global::UnityEngine.SerializeField]
		private global::LiquidVolumeFX.DETAIL _detail;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _level;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _levelMultiplier;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Uses directional light color")]
		private bool _useLightColor;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Uses directional light direction for day/night cycle")]
		private bool _useLightDirection;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Light _directionalLight;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.ColorUsage(true)]
		private global::UnityEngine.Color _liquidColor1;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0.1f, 4.85f)]
		private float _liquidScale1;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.ColorUsage(true)]
		private global::UnityEngine.Color _liquidColor2;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(2f, 4.85f)]
		private float _liquidScale2;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _alpha;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.ColorUsage(true)]
		private global::UnityEngine.Color _emissionColor;

		[global::UnityEngine.SerializeField]
		private bool _ditherShadows;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _murkiness;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _turbulence1;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _turbulence2;

		[global::UnityEngine.SerializeField]
		private float _frecuency;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 2f)]
		private float _speed;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 5f)]
		private float _sparklingIntensity;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _sparklingAmount;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 10f)]
		private float _deepObscurance;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.ColorUsage(true)]
		private global::UnityEngine.Color _foamColor;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0.01f, 1f)]
		private float _foamScale;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 0.1f)]
		private float _foamThickness;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(-1f, 1f)]
		private float _foamDensity;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(4f, 100f)]
		private float _foamWeight;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _foamTurbulence;

		[global::UnityEngine.SerializeField]
		private bool _foamVisibleFromBottom;

		[global::UnityEngine.SerializeField]
		private bool _smokeEnabled;

		[global::UnityEngine.ColorUsage(true)]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _smokeColor;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0.01f, 1f)]
		private float _smokeScale;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 10f)]
		private float _smokeBaseObscurance;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 10f)]
		private float _smokeHeightAtten;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 20f)]
		private float _smokeSpeed;

		[global::UnityEngine.SerializeField]
		private bool _fixMesh;

		public global::UnityEngine.Mesh originalMesh;

		public global::UnityEngine.Vector3 originalPivotOffset;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector3 _pivotOffset;

		[global::UnityEngine.SerializeField]
		private bool _limitVerticalRange;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1.5f)]
		private float _upperLimit;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(-1.5f, 1.5f)]
		private float _lowerLimit;

		[global::UnityEngine.SerializeField]
		private int _subMeshIndex;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Material _flaskMaterial;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _flaskThickness;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _glossinessInternal;

		[global::UnityEngine.SerializeField]
		private bool _scatteringEnabled;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(1f, 16f)]
		private int _scatteringPower;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 10f)]
		private float _scatteringAmount;

		[global::UnityEngine.SerializeField]
		private bool _refractionBlur;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _blurIntensity;

		[global::UnityEngine.SerializeField]
		private int _liquidRaySteps;

		[global::UnityEngine.SerializeField]
		private int _foamRaySteps;

		[global::UnityEngine.SerializeField]
		private int _smokeRaySteps;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture2D _bumpMap;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _bumpStrength;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 10f)]
		private float _bumpDistortionScale;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2 _bumpDistortionOffset;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture2D _distortionMap;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture2D _texture;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2 _textureScale;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2 _textureOffset;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 10f)]
		private float _distortionAmount;

		[global::UnityEngine.SerializeField]
		private bool _depthAware;

		[global::UnityEngine.SerializeField]
		private float _depthAwareOffset;

		[global::UnityEngine.SerializeField]
		private bool _irregularDepthDebug;

		[global::UnityEngine.SerializeField]
		private bool _depthAwareCustomPass;

		[global::UnityEngine.SerializeField]
		private bool _depthAwareCustomPassDebug;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 5f)]
		private float _doubleSidedBias;

		[global::UnityEngine.SerializeField]
		private float _backDepthBias;

		[global::UnityEngine.SerializeField]
		private global::LiquidVolumeFX.LEVEL_COMPENSATION _rotationLevelCompensation;

		[global::UnityEngine.SerializeField]
		private bool _ignoreGravity;

		[global::UnityEngine.SerializeField]
		private bool _reactToForces;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector3 _extentsScale;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(1f, 3f)]
		private int _noiseVariation;

		[global::UnityEngine.SerializeField]
		private bool _allowViewFromInside;

		[global::UnityEngine.SerializeField]
		private bool _debugSpillPoint;

		[global::UnityEngine.SerializeField]
		private int _renderQueue;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Cubemap _reflectionTexture;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0.1f, 5f)]
		private float _physicsMass;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 0.2f)]
		private float _physicsAngularDamp;

		private const int SHADER_KEYWORD_DEPTH_AWARE_INDEX = 0;

		private const int SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS_INDEX = 1;

		private const int SHADER_KEYWORD_IGNORE_GRAVITY_INDEX = 2;

		private const int SHADER_KEYWORD_NON_AABB_INDEX = 3;

		private const int SHADER_KEYWORD_TOPOLOGY_INDEX = 4;

		private const int SHADER_KEYWORD_REFRACTION_INDEX = 5;

		private const string SHADER_KEYWORD_DEPTH_AWARE = "LIQUID_VOLUME_DEPTH_AWARE";

		private const string SHADER_KEYWORD_DEPTH_AWARE_CUSTOM_PASS = "LIQUID_VOLUME_DEPTH_AWARE_PASS";

		private const string SHADER_KEYWORD_NON_AABB = "LIQUID_VOLUME_NON_AABB";

		private const string SHADER_KEYWORD_IGNORE_GRAVITY = "LIQUID_VOLUME_IGNORE_GRAVITY";

		private const string SHADER_KEYWORD_SPHERE = "LIQUID_VOLUME_SPHERE";

		private const string SHADER_KEYWORD_CUBE = "LIQUID_VOLUME_CUBE";

		private const string SHADER_KEYWORD_CYLINDER = "LIQUID_VOLUME_CYLINDER";

		private const string SHADER_KEYWORD_IRREGULAR = "LIQUID_VOLUME_IRREGULAR";

		private const string SHADER_KEYWORD_FP_RENDER_TEXTURE = "LIQUID_VOLUME_FP_RENDER_TEXTURES";

		private const string SHADER_KEYWORD_USE_REFRACTION = "LIQUID_VOLUME_USE_REFRACTION";

		private const string SPILL_POINT_GIZMO = "SpillPointGizmo";

		[global::System.NonSerialized]
		public global::UnityEngine.Material liqMat;

		private global::UnityEngine.Material liqMatSimple;

		private global::UnityEngine.Material liqMatDefaultNoFlask;

		private global::UnityEngine.Mesh mesh;

		[global::System.NonSerialized]
		public global::UnityEngine.Renderer mr;

		private static readonly global::System.Collections.Generic.List<global::UnityEngine.Material> mrSharedMaterials;

		private global::UnityEngine.Vector3 lastPosition;

		private global::UnityEngine.Vector3 lastScale;

		private global::UnityEngine.Quaternion lastRotation;

		private string[] shaderKeywords;

		private bool camInside;

		private float lastDistanceToCam;

		private global::LiquidVolumeFX.DETAIL currentDetail;

		private global::UnityEngine.Vector4 turb;

		private global::UnityEngine.Vector4 shaderTurb;

		private float turbulenceSpeed;

		private float murkinessSpeed;

		private float liquidLevelPos;

		private bool shouldUpdateMaterialProperties;

		private int currentNoiseVariation;

		private float levelMultipled;

		private global::UnityEngine.Texture2D noise3DUnwrapped;

		private global::UnityEngine.Texture3D[] noise3DTex;

		private global::UnityEngine.Color[][] colors3D;

		private global::UnityEngine.Vector3[] verticesUnsorted;

		private global::UnityEngine.Vector3[] verticesSorted;

		private static global::UnityEngine.Vector3[] rotatedVertices;

		private int[] verticesIndices;

		private float volumeRef;

		private float lastLevelVolumeRef;

		private global::UnityEngine.Vector3 inertia;

		private global::UnityEngine.Vector3 lastAvgVelocity;

		private float angularVelocity;

		private float angularInertia;

		private float turbulenceDueForces;

		private global::UnityEngine.Quaternion liquidRot;

		private float prevThickness;

		private global::UnityEngine.GameObject spillPointGizmo;

		private static string[] defaultContainerNames;

		private global::UnityEngine.Color[] pointLightColorBuffer;

		private global::UnityEngine.Vector4[] pointLightPositionBuffer;

		private int lastPointLightCount;

		private static readonly global::System.Collections.Generic.Dictionary<global::UnityEngine.Mesh, global::LiquidVolumeFX.LiquidVolume.MeshCache> meshCache;

		private readonly global::System.Collections.Generic.List<global::UnityEngine.Vector3> verts;

		private readonly global::System.Collections.Generic.List<global::UnityEngine.Vector3> cutPoints;

		private global::UnityEngine.Vector3 cutPlaneCenter;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Mesh fixedMesh;

		public global::LiquidVolumeFX.TOPOLOGY topology
		{
			get
			{
				return default(global::LiquidVolumeFX.TOPOLOGY);
			}
			set
			{
			}
		}

		public global::LiquidVolumeFX.DETAIL detail
		{
			get
			{
				return default(global::LiquidVolumeFX.DETAIL);
			}
			set
			{
			}
		}

		public float level
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float levelMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useLightColor
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useLightDirection
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public global::UnityEngine.Light directionalLight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color liquidColor1
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public float liquidScale1
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color liquidColor2
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public float liquidScale2
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float alpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color emissionColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public bool ditherShadows
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float murkiness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float turbulence1
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float turbulence2
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float frecuency
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float speed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float sparklingIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float sparklingAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float deepObscurance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color foamColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public float foamScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float foamThickness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float foamDensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float foamWeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float foamTurbulence
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool foamVisibleFromBottom
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool smokeEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color smokeColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public float smokeScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float smokeBaseObscurance
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float smokeHeightAtten
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float smokeSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool fixMesh
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector3 pivotOffset
		{
			get
			{
				return default(global::UnityEngine.Vector3);
			}
			set
			{
			}
		}

		public bool limitVerticalRange
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float upperLimit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float lowerLimit
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int subMeshIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public global::UnityEngine.Material flaskMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float flaskThickness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float glossinessInternal
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool scatteringEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int scatteringPower
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float scatteringAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool refractionBlur
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float blurIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int liquidRaySteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int foamRaySteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int smokeRaySteps
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture2D bumpMap
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float bumpStrength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float bumpDistortionScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector2 bumpDistortionOffset
		{
			get
			{
				return default(global::UnityEngine.Vector2);
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture2D distortionMap
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture2D texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector2 textureScale
		{
			get
			{
				return default(global::UnityEngine.Vector2);
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector2 textureOffset
		{
			get
			{
				return default(global::UnityEngine.Vector2);
			}
			set
			{
			}
		}

		public float distortionAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool depthAware
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float depthAwareOffset
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool irregularDepthDebug
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool depthAwareCustomPass
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool depthAwareCustomPassDebug
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float doubleSidedBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float backDepthBias
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::LiquidVolumeFX.LEVEL_COMPENSATION rotationLevelCompensation
		{
			get
			{
				return default(global::LiquidVolumeFX.LEVEL_COMPENSATION);
			}
			set
			{
			}
		}

		public bool ignoreGravity
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool reactToForces
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector3 extentsScale
		{
			get
			{
				return default(global::UnityEngine.Vector3);
			}
			set
			{
			}
		}

		public int noiseVariation
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool allowViewFromInside
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool debugSpillPoint
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int renderQueue
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public global::UnityEngine.Cubemap reflectionTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float physicsMass
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float physicsAngularDamp
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public static bool useFPRenderTextures => false;

		public float liquidSurfaceYPosition => 0f;

		public event global::LiquidVolumeFX.PropertiesChangedEvent onPropertiesChanged
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		private void OnEnable()
		{
		}

		private void Reset()
		{
		}

		private void OnDestroy()
		{
		}

		private void RenderObject()
		{
		}

		public void OnWillRenderObject()
		{
		}

		private void FixedUpdate()
		{
		}

		private void OnDidApplyAnimationProperties()
		{
		}

		public void ClearMeshCache()
		{
		}

		private void ReadVertices()
		{
		}

		private int vertexComparer(global::UnityEngine.Vector3 v0, global::UnityEngine.Vector3 v1)
		{
			return 0;
		}

		private void UpdateAnimations()
		{
		}

		public void UpdateMaterialProperties()
		{
		}

		private void UpdateMaterialPropertiesNow()
		{
		}

		private global::UnityEngine.Color ApplyGlobalAlpha(global::UnityEngine.Color originalColor)
		{
			return default(global::UnityEngine.Color);
		}

		private void GetRenderer()
		{
		}

		private void UpdateLevels(bool updateShaderKeywords = true)
		{
		}

		private void RotateVertices()
		{
		}

		private float SignedVolumeOfTriangle(global::UnityEngine.Vector3 p1, global::UnityEngine.Vector3 p2, global::UnityEngine.Vector3 p3, global::UnityEngine.Vector3 zeroPoint)
		{
			return 0f;
		}

		public float GetMeshVolumeUnderLevelFast(float level01, float yExtent)
		{
			return 0f;
		}

		public float GetMeshVolumeWSFast()
		{
			return 0f;
		}

		public float GetMeshVolumeUnderLevelWSFast(float level)
		{
			return 0f;
		}

		private global::UnityEngine.Vector3 ClampVertexToSlicePlane(global::UnityEngine.Vector3 p, global::UnityEngine.Vector3 q, float level)
		{
			return default(global::UnityEngine.Vector3);
		}

		public float GetMeshVolumeUnderLevel(float level01, float yExtent)
		{
			return 0f;
		}

		public float GetMeshVolumeWS()
		{
			return 0f;
		}

		public float GetMeshVolumeUnderLevelWS(float level)
		{
			return 0f;
		}

		private int PolygonSortOnPlane(global::UnityEngine.Vector3 p1, global::UnityEngine.Vector3 p2)
		{
			return 0;
		}

		private void UpdateTurbulence()
		{
		}

		private void CheckInsideOut()
		{
		}

		private bool PointInAABB(global::UnityEngine.Vector3 point)
		{
			return false;
		}

		private bool PointInCylinder(global::UnityEngine.Vector3 point)
		{
			return false;
		}

		private void UpdateInsideOut()
		{
		}

		public bool GetSpillPoint(out global::UnityEngine.Vector3 spillPosition, float apertureStart = 1f)
		{
			spillPosition = default(global::UnityEngine.Vector3);
			return false;
		}

		public bool GetSpillPoint(out global::UnityEngine.Vector3 spillPosition, out float spillAmount, float apertureStart = 1f, global::LiquidVolumeFX.LEVEL_COMPENSATION rotationCompensation = global::LiquidVolumeFX.LEVEL_COMPENSATION.None)
		{
			spillPosition = default(global::UnityEngine.Vector3);
			spillAmount = default(float);
			return false;
		}

		private void UpdateSpillPointGizmo()
		{
		}

		public void BakeRotation()
		{
		}

		public void CenterPivot()
		{
		}

		public void CenterPivot(global::UnityEngine.Vector3 offset)
		{
		}

		public void RefreshMeshAndCollider()
		{
		}

		public void Redraw()
		{
		}

		private void CheckMeshDisplacement()
		{
		}

		private void RestoreOriginalMesh()
		{
		}

		public void CopyFrom(global::LiquidVolumeFX.LiquidVolume lv)
		{
		}
	}
}
