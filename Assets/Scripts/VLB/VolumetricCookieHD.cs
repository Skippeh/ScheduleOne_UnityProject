namespace VLB
{
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.DisallowMultipleComponent]
	[global::UnityEngine.RequireComponent(typeof(global::VLB.VolumetricLightBeamHD))]
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/comp-cookie-hd/")]
	public class VolumetricCookieHD : global::UnityEngine.MonoBehaviour
	{
		public const string ClassName = "VolumetricCookieHD";

		[global::UnityEngine.SerializeField]
		private float m_Contribution;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture m_CookieTexture;

		[global::UnityEngine.SerializeField]
		private global::VLB.CookieChannel m_Channel;

		[global::UnityEngine.SerializeField]
		private bool m_Negative;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2 m_Translation;

		[global::UnityEngine.SerializeField]
		private float m_Rotation;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2 m_Scale;

		private global::VLB.VolumetricLightBeamHD m_Master;

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

		public global::UnityEngine.Texture cookieTexture
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public global::VLB.CookieChannel channel
		{
			get
			{
				return default(global::VLB.CookieChannel);
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

		public global::UnityEngine.Vector2 translation
		{
			get
			{
				return default(global::UnityEngine.Vector2);
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

		public global::UnityEngine.Vector2 scale
		{
			get
			{
				return default(global::UnityEngine.Vector2);
			}
			set
			{
			}
		}

		private void SetDirty()
		{
		}

		public static void ApplyMaterialProperties(global::VLB.VolumetricCookieHD instance, global::VLB.BeamGeometryHD geom)
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
