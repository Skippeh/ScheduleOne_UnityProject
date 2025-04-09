using UnityEngine;

namespace Funly.SkyStudio
{
	public class SkyMaterialController
	{
		[SerializeField]
		private Material _skyboxMaterial;

		[SerializeField]
		private Color _skyColor;

		[SerializeField]
		private Color _skyMiddleColor;

		[SerializeField]
		private Color _horizonColor;

		[SerializeField]
		[Range(-1f, 1f)]
		private float _gradientFadeBegin;

		[SerializeField]
		[Range(0f, 2f)]
		private float _gradientFadeLength;

		[SerializeField]
		[Range(0f, 1f)]
		private float _skyMiddlePosition;

		[SerializeField]
		private Cubemap _backgroundCubemap;

		[SerializeField]
		[Range(-1f, 1f)]
		private float _starFadeBegin;

		[SerializeField]
		[Range(0f, 2f)]
		private float _starFadeLength;

		[SerializeField]
		[Range(0f, 1f)]
		private float _horizonDistanceScale;

		[SerializeField]
		private Texture _starBasicCubemap;

		[SerializeField]
		private float _starBasicTwinkleSpeed;

		[SerializeField]
		private float _starBasicTwinkleAmount;

		[SerializeField]
		private float _starBasicOpacity;

		[SerializeField]
		private Color _starBasicTintColor;

		[SerializeField]
		private float _starBasicExponent;

		[SerializeField]
		private float _starBasicIntensity;

		[SerializeField]
		private Texture _starLayer1Texture;

		[SerializeField]
		private Texture2D _starLayer1DataTexture;

		[SerializeField]
		private Color _starLayer1Color;

		[SerializeField]
		[Range(0f, 0.1f)]
		private float _starLayer1MaxRadius;

		[SerializeField]
		[Range(0f, 1f)]
		private float _starLayer1TwinkleAmount;

		[SerializeField]
		[Range(0f, 10f)]
		private float _starLayer1TwinkleSpeed;

		[SerializeField]
		[Range(0f, 10f)]
		private float _starLayer1RotationSpeed;

		[SerializeField]
		[Range(0.0001f, 0.9999f)]
		private float _starLayer1EdgeFeathering;

		[SerializeField]
		[Range(1f, 10f)]
		private float _starLayer1BloomFilterBoost;

		[SerializeField]
		private Vector4 _starLayer1SpriteDimensions;

		[SerializeField]
		private int _starLayer1SpriteItemCount;

		[SerializeField]
		[Range(0f, 1f)]
		private float _starLayer1SpriteAnimationSpeed;

		[SerializeField]
		private Texture _starLayer2Texture;

		[SerializeField]
		private Texture2D _starLayer2DataTexture;

		[SerializeField]
		private Color _starLayer2Color;

		[SerializeField]
		[Range(0f, 0.1f)]
		private float _starLayer2MaxRadius;

		[SerializeField]
		[Range(0f, 1f)]
		private float _starLayer2TwinkleAmount;

		[SerializeField]
		[Range(0f, 10f)]
		private float _starLayer2TwinkleSpeed;

		[SerializeField]
		[Range(0f, 10f)]
		private float _starLayer2RotationSpeed;

		[SerializeField]
		[Range(0.0001f, 0.9999f)]
		private float _starLayer2EdgeFeathering;

		[SerializeField]
		[Range(1f, 10f)]
		private float _starLayer2BloomFilterBoost;

		[SerializeField]
		private Vector4 _starLayer2SpriteDimensions;

		[SerializeField]
		private int _starLayer2SpriteItemCount;

		[SerializeField]
		[Range(0f, 1f)]
		private float _starLayer2SpriteAnimationSpeed;

		[SerializeField]
		private Texture _starLayer3Texture;

		[SerializeField]
		private Texture2D _starLayer3DataTexture;

		[SerializeField]
		private Color _starLayer3Color;

		[SerializeField]
		[Range(0f, 0.1f)]
		private float _starLayer3MaxRadius;

		[SerializeField]
		[Range(0f, 1f)]
		private float _starLayer3TwinkleAmount;

		[SerializeField]
		[Range(0f, 10f)]
		private float _starLayer3TwinkleSpeed;

		[SerializeField]
		[Range(0f, 10f)]
		private float _starLayer3RotationSpeed;

		[SerializeField]
		[Range(0.0001f, 0.9999f)]
		private float _starLayer3EdgeFeathering;

		[SerializeField]
		[Range(1f, 10f)]
		private float _starLayer3BloomFilterBoost;

		[SerializeField]
		private Vector4 _starLayer3SpriteDimensions;

		[SerializeField]
		private int _starLayer3SpriteItemCount;

		[SerializeField]
		[Range(0f, 1f)]
		private float _starLayer3SpriteAnimationSpeed;

		[SerializeField]
		private Texture _moonTexture;

		[SerializeField]
		private float _moonRotationSpeed;

		[SerializeField]
		private Color _moonColor;

		[SerializeField]
		private Vector3 _moonDirection;

		[SerializeField]
		private Matrix4x4 _moonWorldToLocalMatrix;

		[SerializeField]
		[Range(0f, 1f)]
		private float _moonSize;

		[SerializeField]
		[Range(0.0001f, 0.9999f)]
		private float _moonEdgeFeathering;

		[SerializeField]
		[Range(1f, 10f)]
		private float _moonBloomFilterBoost;

		[SerializeField]
		private Vector4 _moonSpriteDimensions;

		[SerializeField]
		private int _moonSpriteItemCount;

		[SerializeField]
		[Range(0f, 1f)]
		private float _moonSpriteAnimationSpeed;

		[SerializeField]
		[Range(0f, 1f)]
		private float _moonAlpha;

		[SerializeField]
		private Texture _sunTexture;

		[SerializeField]
		private Color _sunColor;

		[SerializeField]
		private float _sunRotationSpeed;

		[SerializeField]
		private Vector3 _sunDirection;

		[SerializeField]
		private Matrix4x4 _sunWorldToLocalMatrix;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunSize;

		[SerializeField]
		[Range(0.0001f, 0.9999f)]
		private float _sunEdgeFeathering;

		[SerializeField]
		[Range(1f, 10f)]
		private float _sunBloomFilterBoost;

		[SerializeField]
		private Vector4 _sunSpriteDimensions;

		[SerializeField]
		private int _sunSpriteItemCount;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunSpriteAnimationSpeed;

		[SerializeField]
		[Range(0f, 1f)]
		private float _sunAlpha;

		[SerializeField]
		[Range(-1f, 1f)]
		private float _cloudBegin;

		private float _cloudTextureTiling;

		[SerializeField]
		private Color _cloudColor;

		[SerializeField]
		private Texture _cloudTexture;

		[SerializeField]
		private Texture _artCloudCustomTexture;

		[SerializeField]
		private float _cloudDensity;

		[SerializeField]
		private float _cloudSpeed;

		[SerializeField]
		private float _cloudDirection;

		[SerializeField]
		private float _cloudHeight;

		[SerializeField]
		private Color _cloudColor1;

		[SerializeField]
		private Color _cloudColor2;

		[SerializeField]
		private float _cloudFadePosition;

		[SerializeField]
		private float _cloudFadeAmount;

		[SerializeField]
		private float _cloudAlpha;

		[SerializeField]
		private Texture _cloudCubemap;

		[SerializeField]
		private float _cloudCubemapRotationSpeed;

		[SerializeField]
		private Texture _cloudCubemapDoubleLayerCustomTexture;

		[SerializeField]
		private float _cloudCubemapDoubleLayerRotationSpeed;

		[SerializeField]
		private float _cloudCubemapDoubleLayerHeight;

		[SerializeField]
		private Color _cloudCubemapDoubleLayerTintColor;

		[SerializeField]
		private Color _cloudCubemapTintColor;

		[SerializeField]
		private float _cloudCubemapHeight;

		[SerializeField]
		private Texture _cloudCubemapNormalTexture;

		[SerializeField]
		private Color _cloudCubemapNormalLitColor;

		[SerializeField]
		private Color _cloudCubemapNormalShadowColor;

		[SerializeField]
		private float _cloudCubemapNormalRotationSpeed;

		[SerializeField]
		private float _cloudCubemapNormalHeight;

		[SerializeField]
		private float _cloudCubemapNormalAmbientItensity;

		[SerializeField]
		private Texture _cloudCubemapNormalDoubleLayerCustomTexture;

		[SerializeField]
		private float _cloudCubemapNormalDoubleLayerRotationSpeed;

		[SerializeField]
		private float _cloudCubemapNormalDoubleLayerHeight;

		[SerializeField]
		private Color _cloudCubemapNormalDoubleLayerLitColor;

		[SerializeField]
		private Color _cloudCubemapNormalDoubleLayerShadowColor;

		[SerializeField]
		private Vector3 _cloudCubemapNormalLightDirection;

		[SerializeField]
		private Color _fogColor;

		[SerializeField]
		private float _fogDensity;

		[SerializeField]
		private float _fogHeight;

		public Material SkyboxMaterial
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color SkyColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color SkyMiddleColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color HorizonColor
		{
			get
			{
				return default(Color);
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

		public Cubemap BackgroundCubemap
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

		public Texture StarBasicCubemap
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

		public Color StarBasicTintColor
		{
			get
			{
				return default(Color);
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

		public Texture StarLayer1Texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture2D StarLayer1DataTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color StarLayer1Color
		{
			get
			{
				return default(Color);
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

		public Texture StarLayer2Texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture2D StarLayer2DataTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color StarLayer2Color
		{
			get
			{
				return default(Color);
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

		public Texture StarLayer3Texture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture2D StarLayer3DataTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color StarLayer3Color
		{
			get
			{
				return default(Color);
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

		public Texture MoonTexture
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

		public Color MoonColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Vector3 MoonDirection
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Matrix4x4 MoonWorldToLocalMatrix
		{
			get
			{
				return default(Matrix4x4);
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

		public Texture SunTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color SunColor
		{
			get
			{
				return default(Color);
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

		public Vector3 SunDirection
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Matrix4x4 SunWorldToLocalMatrix
		{
			get
			{
				return default(Matrix4x4);
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

		public Color CloudColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Texture CloudTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Texture ArtCloudCustomTexture
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

		public Color CloudColor1
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color CloudColor2
		{
			get
			{
				return default(Color);
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

		public Texture CloudCubemap
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

		public Texture CloudCubemapDoubleLayerCustomTexture
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

		public Color CloudCubemapDoubleLayerTintColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color CloudCubemapTintColor
		{
			get
			{
				return default(Color);
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

		public Texture CloudCubemapNormalTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public Color CloudCubemapNormalLitColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color CloudCubemapNormalShadowColor
		{
			get
			{
				return default(Color);
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

		public Texture CloudCubemapNormalDoubleLayerCustomTexture
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

		public Color CloudCubemapNormalDoubleLayerLitColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Color CloudCubemapNormalDoubleLayerShadowColor
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Vector3 CloudCubemapNormalLightDirection
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		public Color FogColor
		{
			get
			{
				return default(Color);
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

		public Vector2 GetStarLayer1SpriteDimensions()
		{
			return default(Vector2);
		}

		public void SetStarLayer2SpriteDimensions(int columns, int rows)
		{
		}

		public Vector2 GetStarLayer2SpriteDimensions()
		{
			return default(Vector2);
		}

		public void SetStarLayer3SpriteDimensions(int columns, int rows)
		{
		}

		public Vector2 GetStarLayer3SpriteDimensions()
		{
			return default(Vector2);
		}

		public void SetMoonSpriteDimensions(int columns, int rows)
		{
		}

		public Vector2 GetMoonSpriteDimensions()
		{
			return default(Vector2);
		}

		public void SetSunSpriteDimensions(int columns, int rows)
		{
		}

		public Vector2 GetSunSpriteDimensions()
		{
			return default(Vector2);
		}

		private void ApplyGradientValuesOnMaterial()
		{
		}

		private void ApplyStarFadeValuesOnMaterial()
		{
		}
	}
}
