using UnityEngine;

namespace Funly.SkyStudio
{
	public class RainSplashRenderer : BaseSpriteInstancedRenderer
	{
		private Camera m_DepthCamera;

		private float[] m_StartSplashYPositions;

		private float[] m_DepthUs;

		private float[] m_DepthVs;

		private float m_SplashAreaStart;

		private float m_SplashAreaLength;

		private float m_SplashScale;

		private float m_SplashScaleVarience;

		private float m_SplashItensity;

		private float m_SplashSurfaceOffset;

		private SkyProfile m_SkyProfile;

		private float m_TimeOfDay;

		private RainSplashArtItem m_Style;

		private Bounds m_Bounds;

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

		protected override int GetNextSpawnCount()
		{
			return 0;
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

		public void UpdateForTimeOfDay(SkyProfile skyProfile, float timeOfDay, RainSplashArtItem style)
		{
		}

		private void SyncDataFromSkyProfile()
		{
		}

		private Vector3 CreateWorldSplashPoint()
		{
			return default(Vector3);
		}
	}
}
