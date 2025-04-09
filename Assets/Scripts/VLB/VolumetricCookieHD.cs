using UnityEngine;

namespace VLB
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeamHD))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-cookie-hd/")]
	public class VolumetricCookieHD : MonoBehaviour
	{
		public const string ClassName = "VolumetricCookieHD";

		[SerializeField]
		private float m_Contribution;

		[SerializeField]
		private Texture m_CookieTexture;

		[SerializeField]
		private CookieChannel m_Channel;

		[SerializeField]
		private bool m_Negative;

		[SerializeField]
		private Vector2 m_Translation;

		[SerializeField]
		private float m_Rotation;

		[SerializeField]
		private Vector2 m_Scale;

		private VolumetricLightBeamHD m_Master;

		public float contribution
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Texture cookieTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public CookieChannel channel
		{
			get
			{
				return default(CookieChannel);
			}
			set
			{
			}
		}

		public bool negative
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public Vector2 translation
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		public float rotation
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public Vector2 scale
		{
			get
			{
				return default(Vector2);
			}
			set
			{
			}
		}

		private void SetDirty()
		{
		}

		public static void ApplyMaterialProperties(VolumetricCookieHD instance, BeamGeometryHD geom)
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDidApplyAnimationProperties()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
