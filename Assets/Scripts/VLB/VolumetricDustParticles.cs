using System;
using UnityEngine;

namespace VLB
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeamAbstractBase))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dustparticles/")]
	public class VolumetricDustParticles : MonoBehaviour
	{
		public const string ClassName = "VolumetricDustParticles";

		[Range(0f, 1f)]
		public float alpha;

		[Range(0.0001f, 0.1f)]
		public float size;

		public ParticlesDirection direction;

		public Vector3 velocity;

		[Obsolete("Use 'velocity' instead")]
		public float speed;

		public float density;

		[MinMaxRange(0f, 1f)]
		public MinMaxRangeFloat spawnDistanceRange;

		[Obsolete("Use 'spawnDistanceRange' instead")]
		public float spawnMinDistance;

		[Obsolete("Use 'spawnDistanceRange' instead")]
		public float spawnMaxDistance;

		public bool cullingEnabled;

		public float cullingMaxDistance;

		[SerializeField]
		private float m_AlphaAdditionalRuntime;

		private ParticleSystem m_Particles;

		private ParticleSystemRenderer m_Renderer;

		private Material m_Material;

		private Gradient m_GradientCached;

		private bool m_RuntimePropertiesDirty;

		private static bool ms_NoMainCameraLogged;

		private static Camera ms_MainCamera;

		private VolumetricLightBeamAbstractBase m_Master;

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

		public Camera mainCamera => null;

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
