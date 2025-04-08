namespace Funly.SkyStudio
{
	public class RainSplashRenderer : global::Funly.SkyStudio.BaseSpriteInstancedRenderer
	{
		private global::UnityEngine.Camera m_DepthCamera;

		private float[] m_StartSplashYPositions;

		private float[] m_DepthUs;

		private float[] m_DepthVs;

		private float m_SplashAreaStart;

		private float m_SplashAreaLength;

		private float m_SplashScale;

		private float m_SplashScaleVarience;

		private float m_SplashItensity;

		private float m_SplashSurfaceOffset;

		private global::Funly.SkyStudio.SkyProfile m_SkyProfile;

		private float m_TimeOfDay;

		private global::Funly.SkyStudio.RainSplashArtItem m_Style;

		private global::UnityEngine.Bounds m_Bounds;

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

		protected override int GetNextSpawnCount()
		{
			return 0;
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

		public void UpdateForTimeOfDay(global::Funly.SkyStudio.SkyProfile skyProfile, float timeOfDay, global::Funly.SkyStudio.RainSplashArtItem style)
		{
		}

		private void SyncDataFromSkyProfile()
		{
		}

		private global::UnityEngine.Vector3 CreateWorldSplashPoint()
		{
			return default(global::UnityEngine.Vector3);
		}
	}
}
