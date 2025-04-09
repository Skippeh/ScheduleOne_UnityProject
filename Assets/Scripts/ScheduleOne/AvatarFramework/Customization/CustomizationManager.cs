using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Customization
{
	public class CustomizationManager : Singleton<CustomizationManager>
	{
		public delegate void AvatarSettingsChanged(AvatarSettings settings);

		[SerializeField]
		private AvatarSettings ActiveSettings;

		public Avatar TemplateAvatar;

		public TMP_InputField SaveInputField;

		public TMP_InputField LoadInputField;

		public AvatarSettingsChanged OnAvatarSettingsChanged;

		public AvatarSettings DefaultSettings;

		private bool isEditingOriginal;

		protected override void Start()
		{
		}

		public void CreateSettings(string name)
		{
		}

		public void CreateSettings()
		{
		}

		public void LoadSettings(AvatarSettings loadedSettings)
		{
		}

		public void LoadSettings(string settingsName, bool editOriginal = false)
		{
		}

		private void ApplyDefaultSettings(AvatarSettings settings)
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

		public void SkinColorChanged(Color col)
		{
		}

		public void HairChanged(Accessory newHair)
		{
		}

		public void HairColorChanged(Color newCol)
		{
		}

		public void EyeBallTintChanged(Color col)
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

		public void FaceLayerChanged(FaceLayer layer, int index)
		{
		}

		public void FaceLayerColorChanged(Color col, int index)
		{
		}

		public void BodyLayerChanged(AvatarLayer layer, int index)
		{
		}

		public void BodyLayerColorChanged(Color col, int index)
		{
		}

		public void AccessoryChanged(Accessory acc, int index)
		{
		}

		public void AccessoryColorChanged(Color col, int index)
		{
		}
	}
}
