using ScheduleOne.Audio;
using ScheduleOne.ObjectScripts;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.StationFramework
{
	public class BoilingFlask : Fillable
	{
		public const float TEMPERATURE_MAX = 500f;

		public float TEMPERATURE_MAX_VELOCITY;

		public float TEMPERATURE_ACCELERATION;

		public const float OVERHEAT_TIME = 1.25f;

		public bool LockTemperature;

		public AnimationCurve BoilSoundPitchCurve;

		public float LabelJitterScale;

		[Header("References")]
		public BunsenBurner Burner;

		public Canvas TemperatureCanvas;

		public TextMeshProUGUI TemperatureLabel;

		public Slider TemperatureSlider;

		public RectTransform TemperatureRangeIndicator;

		public ParticleSystem SmokeParticles;

		public AudioSourceController BoilSound;

		public MeshRenderer OverheatMesh;

		public float CurrentTemperature { get; private set; }

		public float CurrentTemperatureVelocity { get; private set; }

		public bool IsTemperatureInRange => false;

		public float OverheatScale { get; private set; }

		public StationRecipe Recipe { get; private set; }

		public void Update()
		{
		}

		private void FixedUpdate()
		{
		}

		private void UpdateCanvas()
		{
		}

		private void UpdateSmoke()
		{
		}

		public void SetCanvasVisible(bool visible)
		{
		}

		public void SetTemperature(float temp)
		{
		}

		public void SetRecipe(StationRecipe recipe)
		{
		}
	}
}
