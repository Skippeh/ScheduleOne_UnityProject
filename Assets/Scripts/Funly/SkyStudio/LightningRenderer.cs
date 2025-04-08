namespace Funly.SkyStudio
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.AudioSource))]
	public class LightningRenderer : global::Funly.SkyStudio.BaseSpriteInstancedRenderer
	{
		private static global::System.Collections.Generic.List<global::Funly.SkyStudio.LightningSpawnArea> m_SpawnAreas;

		private float m_LightningProbability;

		private float m_NextSpawnTime;

		private global::Funly.SkyStudio.SkyProfile m_SkyProfile;

		private global::Funly.SkyStudio.LightningArtItem m_Style;

		private float m_TimeOfDay;

		private global::UnityEngine.AudioSource m_AudioSource;

		private float m_LightningIntensity;

		private float m_ThunderSoundDelay;

		private float m_SpawnCoolDown;

		private const float k_ProbabiltyCheckInterval = 0.5f;

		private void Start()
		{
		}

		protected override global::UnityEngine.Bounds CalculateMeshBounds()
		{
			return default(global::UnityEngine.Bounds);
		}

		protected override global::Funly.SkyStudio.BaseSpriteItemData CreateSpriteItemData()
		{
			return null;
		}

		protected override bool IsRenderingEnabled()
		{
			return false;
		}

		protected override void CalculateSpriteTRS(global::Funly.SkyStudio.BaseSpriteItemData data, out global::UnityEngine.Vector3 spritePosition, out global::UnityEngine.Quaternion spriteRotation, out global::UnityEngine.Vector3 spriteScale)
		{
			spritePosition = default(global::UnityEngine.Vector3);
			spriteRotation = default(global::UnityEngine.Quaternion);
			spriteScale = default(global::UnityEngine.Vector3);
		}

		protected override void ConfigureSpriteItemData(global::Funly.SkyStudio.BaseSpriteItemData data)
		{
		}

		protected override void PrepareDataArraysForRendering(int instanceId, global::Funly.SkyStudio.BaseSpriteItemData data)
		{
		}

		protected override void PopulatePropertyBlockForRendering(ref global::UnityEngine.MaterialPropertyBlock propertyBlock)
		{
		}

		protected override int GetNextSpawnCount()
		{
			return 0;
		}

		public void UpdateForTimeOfDay(global::Funly.SkyStudio.SkyProfile skyProfile, float timeOfDay, global::Funly.SkyStudio.LightningArtItem artItem)
		{
		}

		private void SyncDataFromSkyProfile()
		{
		}

		private global::Funly.SkyStudio.LightningSpawnArea GetRandomLightningSpawnArea()
		{
			return null;
		}

		private void PlayThunderBoltSound()
		{
		}

		public static void AddSpawnArea(global::Funly.SkyStudio.LightningSpawnArea area)
		{
		}

		public static void RemoveSpawnArea(global::Funly.SkyStudio.LightningSpawnArea area)
		{
		}

		private global::UnityEngine.Vector3 GetRandomWorldPositionInsideSpawnArea(global::Funly.SkyStudio.LightningSpawnArea area)
		{
			return default(global::UnityEngine.Vector3);
		}

		private float CalculateLightningBoltScaleForArea(global::Funly.SkyStudio.LightningSpawnArea area)
		{
			return 0f;
		}
	}
}
