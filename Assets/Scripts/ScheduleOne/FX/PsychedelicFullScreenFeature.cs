namespace ScheduleOne.FX
{
	public class PsychedelicFullScreenFeature : global::UnityEngine.Rendering.Universal.ScriptableRendererFeature
	{
		[global::System.Serializable]
		public class Settings
		{
			public string profilerTag;

			public global::UnityEngine.Rendering.Universal.RenderPassEvent renderPassEvent;

			public global::UnityEngine.Material passMaterial;

			[global::UnityEngine.Header("Active Properties")]
			public global::ScheduleOne.FX.PsychedelicFullScreenFeature.MaterialProperties ActiveProperties;

			[global::UnityEngine.Header("Presets")]
			public global::System.Collections.Generic.List<global::ScheduleOne.FX.PsychedelicFullScreenFeature.MaterialPropertyPreset> MaterialPresets;
		}

		[global::System.Serializable]
		public class MaterialPropertyPreset
		{
			public string Name;

			public global::ScheduleOne.FX.PsychedelicFullScreenData Data;
		}

		[global::System.Serializable]
		public class MaterialProperties
		{
			public float NoiseScale;

			public float Blend;

			public global::UnityEngine.Vector2 PanSpeed;

			public bool DoesBounce;

			public float Amplitude;

			public global::ScheduleOne.FX.PsychedelicFullScreenFeature.MaterialProperties Clone()
			{
				return null;
			}
		}

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.FX.PsychedelicFullScreenFeature.Settings _settings;

		private static readonly int BLEND_ID;

		private static readonly int NOISE_SCALE_ID;

		private static readonly int PAN_SPEED_ID;

		private static readonly int DOES_BOUNCE_ID;

		private static readonly int AMPLITUDE_ID;

		private global::ScheduleOne.FX.PsychedelicFullScreenPass _psychedelicPass;

		public global::ScheduleOne.FX.PsychedelicFullScreenFeature.Settings FeatureSettings => null;

		public global::ScheduleOne.FX.PsychedelicFullScreenFeature.MaterialProperties ActiveMaterialProperties => null;

		public override void Create()
		{
		}

		public override void AddRenderPasses(global::UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref global::UnityEngine.Rendering.Universal.RenderingData renderingData)
		{
		}

		public void SetActiveMaterialProperties(global::ScheduleOne.FX.PsychedelicFullScreenFeature.MaterialProperties properties)
		{
		}

		public void PrintMaterialValue()
		{
		}

		public global::ScheduleOne.FX.PsychedelicFullScreenData GetMaterialPreset(string presetName)
		{
			return null;
		}
	}
}
