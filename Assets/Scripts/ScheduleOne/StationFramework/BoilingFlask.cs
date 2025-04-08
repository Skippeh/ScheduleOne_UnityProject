namespace ScheduleOne.StationFramework
{
	public class BoilingFlask : global::ScheduleOne.StationFramework.Fillable
	{
		public const float TEMPERATURE_MAX = 500f;

		public float TEMPERATURE_MAX_VELOCITY;

		public float TEMPERATURE_ACCELERATION;

		public const float OVERHEAT_TIME = 1.25f;

		public bool LockTemperature;

		public global::UnityEngine.AnimationCurve BoilSoundPitchCurve;

		public float LabelJitterScale;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.ObjectScripts.BunsenBurner Burner;

		public global::UnityEngine.Canvas TemperatureCanvas;

		public global::TMPro.TextMeshProUGUI TemperatureLabel;

		public global::UnityEngine.UI.Slider TemperatureSlider;

		public global::UnityEngine.RectTransform TemperatureRangeIndicator;

		public global::UnityEngine.ParticleSystem SmokeParticles;

		public global::ScheduleOne.Audio.AudioSourceController BoilSound;

		public global::UnityEngine.MeshRenderer OverheatMesh;

		public float CurrentTemperature { get; private set; }

		public float CurrentTemperatureVelocity { get; private set; }

		public bool IsTemperatureInRange => false;

		public float OverheatScale { get; private set; }

		public global::ScheduleOne.StationFramework.StationRecipe Recipe { get; private set; }

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

		public void SetRecipe(global::ScheduleOne.StationFramework.StationRecipe recipe)
		{
		}
	}
}
