using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	[RequireComponent(typeof(AudioSource))]
	public class LightningRenderer : BaseSpriteInstancedRenderer
	{
		private static List<LightningSpawnArea> m_SpawnAreas;

		private float m_LightningProbability;

		private float m_NextSpawnTime;

		private SkyProfile m_SkyProfile;

		private LightningArtItem m_Style;

		private float m_TimeOfDay;

		private AudioSource m_AudioSource;

		private float m_LightningIntensity;

		private float m_ThunderSoundDelay;

		private float m_SpawnCoolDown;

		private const float k_ProbabiltyCheckInterval = 0.5f;

		private void Start()
		{
		}

		protected override Bounds CalculateMeshBounds()
		{
			return default(Bounds);
		}

		protected override BaseSpriteItemData CreateSpriteItemData()
		{
			return null;
		}

		protected override bool IsRenderingEnabled()
		{
			return false;
		}

		protected override void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale)
		{
			spritePosition = default(Vector3);
			spriteRotation = default(Quaternion);
			spriteScale = default(Vector3);
		}

		protected override void ConfigureSpriteItemData(BaseSpriteItemData data)
		{
		}

		protected override void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data)
		{
		}

		protected override void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock)
		{
		}

		protected override int GetNextSpawnCount()
		{
			return 0;
		}

		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, LightningArtItem artItem)
		{
		}

		private void SyncDataFromSkyProfile()
		{
		}

		private LightningSpawnArea GetRandomLightningSpawnArea()
		{
			return null;
		}

		private void PlayThunderBoltSound()
		{
		}

		public static void AddSpawnArea(LightningSpawnArea area)
		{
		}

		public static void RemoveSpawnArea(LightningSpawnArea area)
		{
		}

		private Vector3 GetRandomWorldPositionInsideSpawnArea(LightningSpawnArea area)
		{
			return default(Vector3);
		}

		private float CalculateLightningBoltScaleForArea(LightningSpawnArea area)
		{
			return 0f;
		}
	}
}
