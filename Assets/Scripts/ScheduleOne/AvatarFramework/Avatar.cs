namespace ScheduleOne.AvatarFramework
{
	public class Avatar : global::UnityEngine.MonoBehaviour
	{
		public const int MAX_ACCESSORIES = 9;

		public const bool CombinedLayersEnabled = true;

		public const float DEFAULT_SMOOTHNESS = 0.25f;

		private static float maleShoulderScale;

		private static float femaleShoulderScale;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.AvatarFramework.Animation.AvatarAnimation Animation;

		public global::ScheduleOne.AvatarFramework.Animation.AvatarLookController LookController;

		public global::UnityEngine.SkinnedMeshRenderer[] BodyMeshes;

		public global::UnityEngine.SkinnedMeshRenderer[] ShapeKeyMeshes;

		public global::UnityEngine.SkinnedMeshRenderer FaceMesh;

		public global::ScheduleOne.AvatarFramework.EyeController Eyes;

		public global::ScheduleOne.AvatarFramework.EyebrowController EyeBrows;

		public global::UnityEngine.Transform BodyContainer;

		public global::UnityEngine.Transform Armature;

		public global::UnityEngine.Transform LeftShoulder;

		public global::UnityEngine.Transform RightShoulder;

		public global::UnityEngine.Transform HeadBone;

		public global::UnityEngine.Transform HipBone;

		public global::UnityEngine.Rigidbody[] RagdollRBs;

		public global::UnityEngine.Collider[] RagdollColliders;

		public global::UnityEngine.Rigidbody MiddleSpineRB;

		public global::ScheduleOne.AvatarFramework.Emotions.AvatarEmotionManager EmotionManager;

		public global::ScheduleOne.AvatarFramework.AvatarEffects Effects;

		public global::UnityEngine.Transform MiddleSpine;

		public global::UnityEngine.Transform LowerSpine;

		public global::UnityEngine.Transform LowestSpine;

		public global::ScheduleOne.AvatarFramework.Impostors.AvatarImpostor Impostor;

		public global::ScheduleOne.Audio.FootstepSounds FootstepSounds;

		public global::UnityEngine.ParticleSystem BloodParticles;

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.AvatarFramework.AvatarSettings InitialAvatarSettings;

		public global::UnityEngine.Material DefaultAvatarMaterial;

		public bool UseCombinedLayer;

		public global::UnityEngine.Events.UnityEvent<bool, bool, bool> onRagdollChange;

		[global::UnityEngine.Header("Data - readonly")]
		[global::UnityEngine.SerializeField]
		protected float appliedGender;

		[global::UnityEngine.SerializeField]
		protected float appliedWeight;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.AvatarFramework.Hair appliedHair;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Color appliedHairColor;

		[global::UnityEngine.SerializeField]
		protected global::ScheduleOne.AvatarFramework.Accessory[] appliedAccessories;

		[global::UnityEngine.SerializeField]
		protected bool wearingHairBlockingAccessory;

		private float additionalWeight;

		private float additionalGender;

		[global::UnityEngine.Header("Runtime loading")]
		public global::ScheduleOne.AvatarFramework.AvatarSettings SettingsToLoad;

		public global::UnityEngine.Events.UnityEvent onSettingsLoaded;

		private global::UnityEngine.Vector3 originalHipPos;

		private bool usingCombinedLayer;

		private bool blockEyeFaceLayers;

		public bool Ragdolled { get; protected set; }

		public global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable CurrentEquippable { get; protected set; }

		public global::ScheduleOne.AvatarFramework.AvatarSettings CurrentSettings { get; protected set; }

		public global::UnityEngine.Transform CenterPointTransform => null;

		public global::UnityEngine.Vector3 CenterPoint => default(global::UnityEngine.Vector3);

		[global::EasyButtons.Button]
		public void Load()
		{
		}

		[global::EasyButtons.Button]
		public void LoadNaked()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		public void SetVisible(bool vis)
		{
		}

		public void GetMugshot(global::System.Action<global::UnityEngine.Texture2D> callback)
		{
		}

		public void SetEmission(global::UnityEngine.Color color)
		{
		}

		public bool IsMale()
		{
			return false;
		}

		public bool IsWhite()
		{
			return false;
		}

		public string GetFormalAddress(bool capitalized = true)
		{
			return null;
		}

		public string GetThirdPersonAddress(bool capitalized = true)
		{
			return null;
		}

		public string GetThirdPersonPronoun(bool capitalized = true)
		{
			return null;
		}

		private void ApplyShapeKeys(float gender, float weight, bool bodyOnly = false)
		{
		}

		private void SetFeetShrunk(bool shrink, float reduction)
		{
		}

		private void SetWearingHairBlockingAccessory(bool blocked)
		{
		}

		public void LoadAvatarSettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		public void LoadNakedSettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings, int maxLayerOrder = 19)
		{
		}

		public void ApplyBodySettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		public void SetAdditionalWeight(float weight)
		{
		}

		public void SetAdditionalGender(float gender)
		{
		}

		public void SetSkinColor(global::UnityEngine.Color color)
		{
		}

		public void ApplyHairSettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		public void SetHairVisible(bool visible)
		{
		}

		public void ApplyHairColorSettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		public void OverrideHairColor(global::UnityEngine.Color color)
		{
		}

		public void ResetHairColor()
		{
		}

		public void ApplyEyeBallSettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		public void ApplyEyeLidSettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		public void ApplyEyeLidColorSettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		public void ApplyEyebrowSettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		public void SetBlockEyeFaceLayers(bool block)
		{
		}

		public void ApplyFaceLayerSettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		private void SetFaceLayer(int index, string assetPath, global::UnityEngine.Color color)
		{
		}

		public void SetFaceTexture(global::UnityEngine.Texture2D tex, global::UnityEngine.Color color)
		{
		}

		public void ApplyBodyLayerSettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings, int maxOrder = -1)
		{
		}

		private void SetBodyLayer(int index, string assetPath, global::UnityEngine.Color color)
		{
		}

		public void ApplyAccessorySettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		private void DestroyAccessories()
		{
		}

		public virtual void SetRagdollPhysicsEnabled(bool ragdollEnabled, bool playStandUpAnim = true)
		{
		}

		public virtual global::ScheduleOne.AvatarFramework.Equipping.AvatarEquippable SetEquippable(string assetPath)
		{
			return null;
		}

		public virtual void ReceiveEquippableMessage(string message, object data)
		{
		}
	}
}
