namespace ScheduleOne.AvatarFramework.Customization
{
	public class CustomizationManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.AvatarFramework.Customization.CustomizationManager>
	{
		public delegate void AvatarSettingsChanged(global::ScheduleOne.AvatarFramework.AvatarSettings settings);

		public const string AppearancesFolderPath = "Assets/Resources/Appearances";

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.AvatarFramework.AvatarSettings ActiveSettings;

		public global::ScheduleOne.AvatarFramework.Avatar TemplateAvatar;

		public global::TMPro.TMP_InputField SaveInputField;

		public global::TMPro.TMP_InputField LoadInputField;

		public global::UnityEngine.UI.Toggle GenerateCombinedLayerToggle;

		public global::ScheduleOne.AvatarFramework.Customization.CustomizationManager.AvatarSettingsChanged OnAvatarSettingsChanged;

		public global::ScheduleOne.AvatarFramework.AvatarSettings DefaultSettings;

		private bool isEditingOriginal;

		private string loadedSettingsAssetPath;

		protected override void Start()
		{
		}

		public void CreateSettings(string assetName, string assetPath)
		{
		}

		public void CreateSettings()
		{
		}

		public void LoadSettings(global::ScheduleOne.AvatarFramework.AvatarSettings loadedSettings)
		{
		}

		public void LoadSettings(string path, bool editOriginal = false)
		{
		}

		private void ApplyDefaultSettings(global::ScheduleOne.AvatarFramework.AvatarSettings settings)
		{
		}

		public void LoadSettings()
		{
		}

		public void GenderChanged(float genderScale)
		{
		}

		public void WeightChanged(float weightScale)
		{
		}

		public void HeightChanged(float height)
		{
		}

		public void SkinColorChanged(global::UnityEngine.Color col)
		{
		}

		public void HairChanged(global::ScheduleOne.AvatarFramework.Accessory newHair)
		{
		}

		public void HairColorChanged(global::UnityEngine.Color newCol)
		{
		}

		public void EyeBallTintChanged(global::UnityEngine.Color col)
		{
		}

		public void UpperEyeLidRestingPositionChanged(float newVal)
		{
		}

		public void LowerEyeLidRestingPositionChanged(float newVal)
		{
		}

		public void EyebrowScaleChanged(float newVal)
		{
		}

		public void EyebrowThicknessChanged(float newVal)
		{
		}

		public void EyebrowRestingHeightChanged(float newVal)
		{
		}

		public void EyebrowRestingAngleChanged(float newVal)
		{
		}

		public void PupilDilationChanged(float dilation)
		{
		}

		public void FaceLayerChanged(global::ScheduleOne.AvatarFramework.FaceLayer layer, int index)
		{
		}

		public void FaceLayerColorChanged(global::UnityEngine.Color col, int index)
		{
		}

		public void BodyLayerChanged(global::ScheduleOne.AvatarFramework.AvatarLayer layer, int index)
		{
		}

		public void BodyLayerColorChanged(global::UnityEngine.Color col, int index)
		{
		}

		public void AccessoryChanged(global::ScheduleOne.AvatarFramework.Accessory acc, int index)
		{
		}

		public void AccessoryColorChanged(global::UnityEngine.Color col, int index)
		{
		}
	}
}
