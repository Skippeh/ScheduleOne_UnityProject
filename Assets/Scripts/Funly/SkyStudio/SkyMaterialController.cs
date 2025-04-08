namespace Funly.SkyStudio
{
	public class SkyMaterialController
	{
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Material _skyboxMaterial;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _skyColor;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _skyMiddleColor;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _horizonColor;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(-1f, 1f)]
		private float _gradientFadeBegin;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 2f)]
		private float _gradientFadeLength;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _skyMiddlePosition;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Cubemap _backgroundCubemap;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(-1f, 1f)]
		private float _starFadeBegin;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 2f)]
		private float _starFadeLength;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _horizonDistanceScale;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture _starBasicCubemap;

		[global::UnityEngine.SerializeField]
		private float _starBasicTwinkleSpeed;

		[global::UnityEngine.SerializeField]
		private float _starBasicTwinkleAmount;

		[global::UnityEngine.SerializeField]
		private float _starBasicOpacity;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _starBasicTintColor;

		[global::UnityEngine.SerializeField]
		private float _starBasicExponent;

		[global::UnityEngine.SerializeField]
		private float _starBasicIntensity;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture _starLayer1Texture;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture2D _starLayer1DataTexture;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _starLayer1Color;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 0.1f)]
		private float _starLayer1MaxRadius;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _starLayer1TwinkleAmount;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 10f)]
		private float _starLayer1TwinkleSpeed;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 10f)]
		private float _starLayer1RotationSpeed;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0.0001f, 0.9999f)]
		private float _starLayer1EdgeFeathering;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(1f, 10f)]
		private float _starLayer1BloomFilterBoost;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector4 _starLayer1SpriteDimensions;

		[global::UnityEngine.SerializeField]
		private int _starLayer1SpriteItemCount;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _starLayer1SpriteAnimationSpeed;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture _starLayer2Texture;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture2D _starLayer2DataTexture;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _starLayer2Color;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 0.1f)]
		private float _starLayer2MaxRadius;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _starLayer2TwinkleAmount;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 10f)]
		private float _starLayer2TwinkleSpeed;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 10f)]
		private float _starLayer2RotationSpeed;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0.0001f, 0.9999f)]
		private float _starLayer2EdgeFeathering;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(1f, 10f)]
		private float _starLayer2BloomFilterBoost;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector4 _starLayer2SpriteDimensions;

		[global::UnityEngine.SerializeField]
		private int _starLayer2SpriteItemCount;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _starLayer2SpriteAnimationSpeed;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture _starLayer3Texture;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture2D _starLayer3DataTexture;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _starLayer3Color;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 0.1f)]
		private float _starLayer3MaxRadius;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _starLayer3TwinkleAmount;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 10f)]
		private float _starLayer3TwinkleSpeed;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 10f)]
		private float _starLayer3RotationSpeed;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0.0001f, 0.9999f)]
		private float _starLayer3EdgeFeathering;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(1f, 10f)]
		private float _starLayer3BloomFilterBoost;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector4 _starLayer3SpriteDimensions;

		[global::UnityEngine.SerializeField]
		private int _starLayer3SpriteItemCount;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _starLayer3SpriteAnimationSpeed;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture _moonTexture;

		[global::UnityEngine.SerializeField]
		private float _moonRotationSpeed;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _moonColor;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector3 _moonDirection;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Matrix4x4 _moonWorldToLocalMatrix;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _moonSize;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0.0001f, 0.9999f)]
		private float _moonEdgeFeathering;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(1f, 10f)]
		private float _moonBloomFilterBoost;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector4 _moonSpriteDimensions;

		[global::UnityEngine.SerializeField]
		private int _moonSpriteItemCount;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _moonSpriteAnimationSpeed;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _moonAlpha;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture _sunTexture;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _sunColor;

		[global::UnityEngine.SerializeField]
		private float _sunRotationSpeed;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector3 _sunDirection;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Matrix4x4 _sunWorldToLocalMatrix;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _sunSize;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0.0001f, 0.9999f)]
		private float _sunEdgeFeathering;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(1f, 10f)]
		private float _sunBloomFilterBoost;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector4 _sunSpriteDimensions;

		[global::UnityEngine.SerializeField]
		private int _sunSpriteItemCount;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _sunSpriteAnimationSpeed;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(0f, 1f)]
		private float _sunAlpha;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Range(-1f, 1f)]
		private float _cloudBegin;

		private float _cloudTextureTiling;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _cloudColor;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture _cloudTexture;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture _artCloudCustomTexture;

		[global::UnityEngine.SerializeField]
		private float _cloudDensity;

		[global::UnityEngine.SerializeField]
		private float _cloudSpeed;

		[global::UnityEngine.SerializeField]
		private float _cloudDirection;

		[global::UnityEngine.SerializeField]
		private float _cloudHeight;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _cloudColor1;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _cloudColor2;

		[global::UnityEngine.SerializeField]
		private float _cloudFadePosition;

		[global::UnityEngine.SerializeField]
		private float _cloudFadeAmount;

		[global::UnityEngine.SerializeField]
		private float _cloudAlpha;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture _cloudCubemap;

		[global::UnityEngine.SerializeField]
		private float _cloudCubemapRotationSpeed;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture _cloudCubemapDoubleLayerCustomTexture;

		[global::UnityEngine.SerializeField]
		private float _cloudCubemapDoubleLayerRotationSpeed;

		[global::UnityEngine.SerializeField]
		private float _cloudCubemapDoubleLayerHeight;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _cloudCubemapDoubleLayerTintColor;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _cloudCubemapTintColor;

		[global::UnityEngine.SerializeField]
		private float _cloudCubemapHeight;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture _cloudCubemapNormalTexture;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _cloudCubemapNormalLitColor;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _cloudCubemapNormalShadowColor;

		[global::UnityEngine.SerializeField]
		private float _cloudCubemapNormalRotationSpeed;

		[global::UnityEngine.SerializeField]
		private float _cloudCubemapNormalHeight;

		[global::UnityEngine.SerializeField]
		private float _cloudCubemapNormalAmbientItensity;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture _cloudCubemapNormalDoubleLayerCustomTexture;

		[global::UnityEngine.SerializeField]
		private float _cloudCubemapNormalDoubleLayerRotationSpeed;

		[global::UnityEngine.SerializeField]
		private float _cloudCubemapNormalDoubleLayerHeight;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _cloudCubemapNormalDoubleLayerLitColor;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _cloudCubemapNormalDoubleLayerShadowColor;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector3 _cloudCubemapNormalLightDirection;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color _fogColor;

		[global::UnityEngine.SerializeField]
		private float _fogDensity;

		[global::UnityEngine.SerializeField]
		private float _fogHeight;

		public global::UnityEngine.Material SkyboxMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color SkyColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public global::UnityEngine.Color SkyMiddleColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public global::UnityEngine.Color HorizonColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public float GradientFadeBegin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float GradientFadeLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SkyMiddlePosition
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Cubemap BackgroundCubemap
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float StarFadeBegin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarFadeLength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float HorizonDistanceScale
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture StarBasicCubemap
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float StarBasicTwinkleSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarBasicTwinkleAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarBasicOpacity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color StarBasicTintColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public float StarBasicExponent
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarBasicIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture StarLayer1Texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture2D StarLayer1DataTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color StarLayer1Color
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public float StarLayer1MaxRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarLayer1TwinkleAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarLayer1TwinkleSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarLayer1RotationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarLayer1EdgeFeathering
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarLayer1BloomFilterBoost
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int StarLayer1SpriteItemCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float StarLayer1SpriteAnimationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture StarLayer2Texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture2D StarLayer2DataTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color StarLayer2Color
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public float StarLayer2MaxRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarLayer2TwinkleAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarLayer2TwinkleSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarLayer2RotationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarLayer2EdgeFeathering
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarLayer2BloomFilterBoost
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int StarLayer2SpriteItemCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float StarLayer2SpriteAnimationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture StarLayer3Texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture2D StarLayer3DataTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color StarLayer3Color
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public float StarLayer3MaxRadius
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarLayer3TwinkleAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarLayer3TwinkleSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarLayer3RotationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarLayer3EdgeFeathering
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float StarLayer3BloomFilterBoost
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int StarLayer3SpriteItemCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float StarLayer3SpriteAnimationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture MoonTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float MoonRotationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color MoonColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector3 MoonDirection
		{
			get
			{
				return default(global::UnityEngine.Vector3);
			}
			set
			{
			}
		}

		public global::UnityEngine.Matrix4x4 MoonWorldToLocalMatrix
		{
			get
			{
				return default(global::UnityEngine.Matrix4x4);
			}
			set
			{
			}
		}

		public float MoonSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MoonEdgeFeathering
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MoonBloomFilterBoost
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int MoonSpriteItemCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float MoonSpriteAnimationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float MoonAlpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture SunTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color SunColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public float SunRotationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector3 SunDirection
		{
			get
			{
				return default(global::UnityEngine.Vector3);
			}
			set
			{
			}
		}

		public global::UnityEngine.Matrix4x4 SunWorldToLocalMatrix
		{
			get
			{
				return default(global::UnityEngine.Matrix4x4);
			}
			set
			{
			}
		}

		public float SunSize
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SunEdgeFeathering
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SunBloomFilterBoost
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int SunSpriteItemCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public float SunSpriteAnimationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float SunAlpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CloudBegin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CloudTextureTiling
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color CloudColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture CloudTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture ArtCloudCustomTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float CloudDensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CloudSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CloudDirection
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CloudHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color CloudColor1
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public global::UnityEngine.Color CloudColor2
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public float CloudFadePosition
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CloudFadeAmount
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CloudAlpha
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture CloudCubemap
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float CloudCubemapRotationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture CloudCubemapDoubleLayerCustomTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float CloudCubemapDoubleLayerRotationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CloudCubemapDoubleLayerHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color CloudCubemapDoubleLayerTintColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public global::UnityEngine.Color CloudCubemapTintColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public float CloudCubemapHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture CloudCubemapNormalTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color CloudCubemapNormalLitColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public global::UnityEngine.Color CloudCubemapNormalShadowColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public float CloudCubemapNormalRotationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CloudCubemapNormalHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CloudCubemapNormalAmbientIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Texture CloudCubemapNormalDoubleLayerCustomTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float CloudCubemapNormalDoubleLayerRotationSpeed
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float CloudCubemapNormalDoubleLayerHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::UnityEngine.Color CloudCubemapNormalDoubleLayerLitColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public global::UnityEngine.Color CloudCubemapNormalDoubleLayerShadowColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector3 CloudCubemapNormalLightDirection
		{
			get
			{
				return default(global::UnityEngine.Vector3);
			}
			set
			{
			}
		}

		public global::UnityEngine.Color FogColor
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public float FogDensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float FogHeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public void SetStarLayer1SpriteDimensions(int columns, int rows)
		{
		}

		public global::UnityEngine.Vector2 GetStarLayer1SpriteDimensions()
		{
			return default(global::UnityEngine.Vector2);
		}

		public void SetStarLayer2SpriteDimensions(int columns, int rows)
		{
		}

		public global::UnityEngine.Vector2 GetStarLayer2SpriteDimensions()
		{
			return default(global::UnityEngine.Vector2);
		}

		public void SetStarLayer3SpriteDimensions(int columns, int rows)
		{
		}

		public global::UnityEngine.Vector2 GetStarLayer3SpriteDimensions()
		{
			return default(global::UnityEngine.Vector2);
		}

		public void SetMoonSpriteDimensions(int columns, int rows)
		{
		}

		public global::UnityEngine.Vector2 GetMoonSpriteDimensions()
		{
			return default(global::UnityEngine.Vector2);
		}

		public void SetSunSpriteDimensions(int columns, int rows)
		{
		}

		public global::UnityEngine.Vector2 GetSunSpriteDimensions()
		{
			return default(global::UnityEngine.Vector2);
		}

		private void ApplyGradientValuesOnMaterial()
		{
		}

		private void ApplyStarFadeValuesOnMaterial()
		{
		}
	}
}
