using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace LiquidVolumeFX
{
	[ExecuteInEditMode]
	[HelpURL("https://kronnect.com/support")]
	[AddComponentMenu("Effects/Liquid Volume")]
	[DisallowMultipleComponent]
	public class LiquidVolume : MonoBehaviour
	{
		private struct MeshCache
		{
			public Vector3[] verticesSorted;

			public Vector3[] verticesUnsorted;

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

		[SerializeField]
		private TOPOLOGY _topology;

		[SerializeField]
		private DETAIL _detail;

		[SerializeField]
		[Range(0f, 1f)]
		private float _level;

		[SerializeField]
		[Range(0f, 1f)]
		private float _levelMultiplier;

		[SerializeField]
		[Tooltip("Uses directional light color")]
		private bool _useLightColor;

		[SerializeField]
		[Tooltip("Uses directional light direction for day/night cycle")]
		private bool _useLightDirection;

		[SerializeField]
		private Light _directionalLight;

		[SerializeField]
		[ColorUsage(true)]
		private Color _liquidColor1;

		[SerializeField]
		[Range(0.1f, 4.85f)]
		private float _liquidScale1;

		[SerializeField]
		[ColorUsage(true)]
		private Color _liquidColor2;

		[SerializeField]
		[Range(2f, 4.85f)]
		private float _liquidScale2;

		[SerializeField]
		[Range(0f, 1f)]
		private float _alpha;

		[SerializeField]
		[ColorUsage(true)]
		private Color _emissionColor;

		[SerializeField]
		private bool _ditherShadows;

		[SerializeField]
		[Range(0f, 1f)]
		private float _murkiness;

		[SerializeField]
		[Range(0f, 1f)]
		private float _turbulence1;

		[SerializeField]
		[Range(0f, 1f)]
		private float _turbulence2;

		[SerializeField]
		private float _frecuency;

		[SerializeField]
		[Range(0f, 2f)]
		private float _speed;

		[SerializeField]
		[Range(0f, 5f)]
		private float _sparklingIntensity;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sparklingAmount;

		[SerializeField]
		[Range(0f, 10f)]
		private float _deepObscurance;

		[SerializeField]
		[ColorUsage(true)]
		private Color _foamColor;

		[SerializeField]
		[Range(0.01f, 1f)]
		private float _foamScale;

		[SerializeField]
		[Range(0f, 0.1f)]
		private float _foamThickness;

		[SerializeField]
		[Range(-1f, 1f)]
		private float _foamDensity;

		[SerializeField]
		[Range(4f, 100f)]
		private float _foamWeight;

		[SerializeField]
		[Range(0f, 1f)]
		private float _foamTurbulence;

		[SerializeField]
		private bool _foamVisibleFromBottom;

		[SerializeField]
		private bool _smokeEnabled;

		[ColorUsage(true)]
		[SerializeField]
		private Color _smokeColor;

		[SerializeField]
		[Range(0.01f, 1f)]
		private float _smokeScale;

		[SerializeField]
		[Range(0f, 10f)]
		private float _smokeBaseObscurance;

		[SerializeField]
		[Range(0f, 10f)]
		private float _smokeHeightAtten;

		[SerializeField]
		[Range(0f, 20f)]
		private float _smokeSpeed;

		[SerializeField]
		private bool _fixMesh;

		public Mesh originalMesh;

		public Vector3 originalPivotOffset;

		[SerializeField]
		private Vector3 _pivotOffset;

		[SerializeField]
		private bool _limitVerticalRange;

		[SerializeField]
		[Range(0f, 1.5f)]
		private float _upperLimit;

		[SerializeField]
		[Range(-1.5f, 1.5f)]
		private float _lowerLimit;

		[SerializeField]
		private int _subMeshIndex;

		[SerializeField]
		private Material _flaskMaterial;

		[SerializeField]
		[Range(0f, 1f)]
		private float _flaskThickness;

		[SerializeField]
		[Range(0f, 1f)]
		private float _glossinessInternal;

		[SerializeField]
		private bool _scatteringEnabled;

		[SerializeField]
		[Range(1f, 16f)]
		private int _scatteringPower;

		[SerializeField]
		[Range(0f, 10f)]
		private float _scatteringAmount;

		[SerializeField]
		private bool _refractionBlur;

		[SerializeField]
		[Range(0f, 1f)]
		private float _blurIntensity;

		[SerializeField]
		private int _liquidRaySteps;

		[SerializeField]
		private int _foamRaySteps;

		[SerializeField]
		private int _smokeRaySteps;

		[SerializeField]
		private Texture2D _bumpMap;

		[SerializeField]
		[Range(0f, 1f)]
		private float _bumpStrength;

		[SerializeField]
		[Range(0f, 10f)]
		private float _bumpDistortionScale;

		[SerializeField]
		private Vector2 _bumpDistortionOffset;

		[SerializeField]
		private Texture2D _distortionMap;

		[SerializeField]
		private Texture2D _texture;

		[SerializeField]
		private Vector2 _textureScale;

		[SerializeField]
		private Vector2 _textureOffset;

		[SerializeField]
		[Range(0f, 10f)]
		private float _distortionAmount;

		[SerializeField]
		private bool _depthAware;

		[SerializeField]
		private float _depthAwareOffset;

		[SerializeField]
		private bool _irregularDepthDebug;

		[SerializeField]
		private bool _depthAwareCustomPass;

		[SerializeField]
		private bool _depthAwareCustomPassDebug;

		[SerializeField]
		[Range(0f, 5f)]
		private float _doubleSidedBias;

		[SerializeField]
		private float _backDepthBias;

		[SerializeField]
		private LEVEL_COMPENSATION _rotationLevelCompensation;

		[SerializeField]
		private bool _ignoreGravity;

		[SerializeField]
		private bool _reactToForces;

		[SerializeField]
		private Vector3 _extentsScale;

		[SerializeField]
		[Range(1f, 3f)]
		private int _noiseVariation;

		[SerializeField]
		private bool _allowViewFromInside;

		[SerializeField]
		private bool _debugSpillPoint;

		[SerializeField]
		private int _renderQueue;

		[SerializeField]
		private Cubemap _reflectionTexture;

		[SerializeField]
		[Range(0.1f, 5f)]
		private float _physicsMass;

		[SerializeField]
		[Range(0f, 0.2f)]
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

		[NonSerialized]
		public Material liqMat;

		private Material liqMatSimple;

		private Material liqMatDefaultNoFlask;

		private Mesh mesh;

		[NonSerialized]
		public Renderer mr;

		private static readonly List<Material> mrSharedMaterials;

		private Vector3 lastPosition;

		private Vector3 lastScale;

		private Quaternion lastRotation;

		private string[] shaderKeywords;

		private bool camInside;

		private float lastDistanceToCam;

		private DETAIL currentDetail;

		private Vector4 turb;

		private Vector4 shaderTurb;

		private float turbulenceSpeed;

		private float murkinessSpeed;

		private float liquidLevelPos;

		private bool shouldUpdateMaterialProperties;

		private int currentNoiseVariation;

		private float levelMultipled;

		private Texture2D noise3DUnwrapped;

		private Texture3D[] noise3DTex;

		private Color[][] colors3D;

		private Vector3[] verticesUnsorted;

		private Vector3[] verticesSorted;

		private static Vector3[] rotatedVertices;

		private int[] verticesIndices;

		private float volumeRef;

		private float lastLevelVolumeRef;

		private Vector3 inertia;

		private Vector3 lastAvgVelocity;

		private float angularVelocity;

		private float angularInertia;

		private float turbulenceDueForces;

		private Quaternion liquidRot;

		private float prevThickness;

		private GameObject spillPointGizmo;

		private static string[] defaultContainerNames;

		private Color[] pointLightColorBuffer;

		private Vector4[] pointLightPositionBuffer;

		private int lastPointLightCount;

		private static readonly Dictionary<Mesh, MeshCache> meshCache;

		private readonly List<Vector3> verts;

		private readonly List<Vector3> cutPoints;

		private Vector3 cutPlaneCenter;

		[SerializeField]
		private Mesh fixedMesh;

		public TOPOLOGY topology
		{
			get
			{
				return default(TOPOLOGY);
			}
			set
			{
			}
		}

		public DETAIL detail
		{
			get
			{
				return default(DETAIL);
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

		public Light directionalLight
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color liquidColor1
		{
			get
			{
				return default(Color);
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

		public Color liquidColor2
		{
			get
			{
				return default(Color);
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

		public Color emissionColor
		{
			get
			{
				return default(Color);
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

		public Color foamColor
		{
			get
			{
				return default(Color);
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

		public Color smokeColor
		{
			get
			{
				return default(Color);
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

		public Vector3 pivotOffset
		{
			get
			{
				return default(Vector3);
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

		public Material flaskMaterial
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

		public Texture2D bumpMap
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

		public Vector2 bumpDistortionOffset
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Texture2D distortionMap
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture2D texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Vector2 textureScale
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public Vector2 textureOffset
		{
			get
			{
				return default(Vector2);
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

		public LEVEL_COMPENSATION rotationLevelCompensation
		{
			get
			{
				return default(LEVEL_COMPENSATION);
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

		public Vector3 extentsScale
		{
			get
			{
				return default(Vector3);
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

		public Cubemap reflectionTexture
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

		public event PropertiesChangedEvent onPropertiesChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
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

		private int vertexComparer(Vector3 v0, Vector3 v1)
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

		private Color ApplyGlobalAlpha(Color originalColor)
		{
			return default(Color);
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

		private float SignedVolumeOfTriangle(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 zeroPoint)
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

		private Vector3 ClampVertexToSlicePlane(Vector3 p, Vector3 q, float level)
		{
			return default(Vector3);
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

		private int PolygonSortOnPlane(Vector3 p1, Vector3 p2)
		{
			return 0;
		}

		private void UpdateTurbulence()
		{
		}

		private void CheckInsideOut()
		{
		}

		private bool PointInAABB(Vector3 point)
		{
			return false;
		}

		private bool PointInCylinder(Vector3 point)
		{
			return false;
		}

		private void UpdateInsideOut()
		{
		}

		public bool GetSpillPoint(out Vector3 spillPosition, float apertureStart = 1f)
		{
			spillPosition = default(Vector3);
			return false;
		}

		public bool GetSpillPoint(out Vector3 spillPosition, out float spillAmount, float apertureStart = 1f, LEVEL_COMPENSATION rotationCompensation = LEVEL_COMPENSATION.None)
		{
			spillPosition = default(Vector3);
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

		public void CenterPivot(Vector3 offset)
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

		public void CopyFrom(LiquidVolume lv)
		{
		}
	}
}
