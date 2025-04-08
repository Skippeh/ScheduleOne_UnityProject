namespace VLB
{
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.DisallowMultipleComponent]
	[global::UnityEngine.RequireComponent(typeof(global::VLB.VolumetricLightBeamAbstractBase))]
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/comp-dustparticles/")]
	public class VolumetricDustParticles : global::UnityEngine.MonoBehaviour
	{
		public const string ClassName = "VolumetricDustParticles";

		[global::UnityEngine.Range(0f, 1f)]
		public float alpha;

		[global::UnityEngine.Range(0.0001f, 0.1f)]
		public float size;

		public global::VLB.ParticlesDirection direction;

		public global::UnityEngine.Vector3 velocity;

		[global::System.Obsolete("Use 'velocity' instead")]
		public float speed;

		public float density;

		[global::VLB.MinMaxRange(0f, 1f)]
		public global::VLB.MinMaxRangeFloat spawnDistanceRange;

		[global::System.Obsolete("Use 'spawnDistanceRange' instead")]
		public float spawnMinDistance;

		[global::System.Obsolete("Use 'spawnDistanceRange' instead")]
		public float spawnMaxDistance;

		public bool cullingEnabled;

		public float cullingMaxDistance;

		[global::UnityEngine.SerializeField]
		private float m_AlphaAdditionalRuntime;

		private global::UnityEngine.ParticleSystem m_Particles;

		private global::UnityEngine.ParticleSystemRenderer m_Renderer;

		private global::UnityEngine.Material m_Material;

		private global::UnityEngine.Gradient m_GradientCached;

		private bool m_RuntimePropertiesDirty;

		private static bool ms_NoMainCameraLogged;

		private static global::UnityEngine.Camera ms_MainCamera;

		private global::VLB.VolumetricLightBeamAbstractBase m_Master;

		public bool isCulled { get; private set; }

		public float alphaAdditionalRuntime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool particlesAreInstantiated => false;

		public int particlesCurrentCount => 0;

		public int particlesMaxCount => 0;

		public global::UnityEngine.Camera mainCamera => null;

		private void Start()
		{
		}

		private void InstantiateParticleSystem()
		{
		}

		private void OnEnable()
		{
		}

		private void SetActive(bool active)
		{
		}

		private void SetActiveAndPlay()
		{
		}

		private void Play()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void SetParticleProperties()
		{
		}

		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		private void UpdateCulling()
		{
		}
	}
}
