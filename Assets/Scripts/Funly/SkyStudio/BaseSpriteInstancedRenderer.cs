namespace Funly.SkyStudio
{
	public abstract class BaseSpriteInstancedRenderer : global::UnityEngine.MonoBehaviour
	{
		public const int kArrayMaxSprites = 1000;

		[global::UnityEngine.Tooltip("Mesh used to render the instances onto. If empty, a quad will be used.")]
		public global::UnityEngine.Mesh modelMesh;

		[global::UnityEngine.Tooltip("Sky Studio sprite sheet animated shader material.")]
		public global::UnityEngine.Material renderMaterial;

		protected global::System.Collections.Generic.Queue<global::Funly.SkyStudio.BaseSpriteItemData> m_Available;

		protected global::System.Collections.Generic.HashSet<global::Funly.SkyStudio.BaseSpriteItemData> m_Active;

		private global::UnityEngine.MaterialPropertyBlock m_PropertyBlock;

		private global::UnityEngine.Matrix4x4[] m_ModelMatrices;

		private float[] m_StartTimes;

		private float[] m_EndTimes;

		protected global::Funly.SkyStudio.SpriteSheetData m_SpriteSheetLayout;

		protected global::UnityEngine.Texture m_SpriteTexture;

		protected global::UnityEngine.Color m_TintColor;

		protected global::UnityEngine.Mesh m_DefaltModelMesh;

		public int maxSprites { get; protected set; }

		protected global::UnityEngine.Camera m_ViewerCamera { get; set; }

		private void Start()
		{
		}

		protected abstract global::UnityEngine.Bounds CalculateMeshBounds();

		protected abstract global::Funly.SkyStudio.BaseSpriteItemData CreateSpriteItemData();

		protected abstract bool IsRenderingEnabled();

		protected abstract int GetNextSpawnCount();

		protected abstract void CalculateSpriteTRS(global::Funly.SkyStudio.BaseSpriteItemData data, out global::UnityEngine.Vector3 spritePosition, out global::UnityEngine.Quaternion spriteRotation, out global::UnityEngine.Vector3 spriteScale);

		protected abstract void ConfigureSpriteItemData(global::Funly.SkyStudio.BaseSpriteItemData data);

		protected abstract void PrepareDataArraysForRendering(int instanceId, global::Funly.SkyStudio.BaseSpriteItemData data);

		protected abstract void PopulatePropertyBlockForRendering(ref global::UnityEngine.MaterialPropertyBlock propertyBlock);

		private global::Funly.SkyStudio.BaseSpriteItemData DequeueNextSpriteItemData()
		{
			return null;
		}

		private void ReturnSpriteItemData(global::Funly.SkyStudio.BaseSpriteItemData splash)
		{
		}

		protected virtual void LateUpdate()
		{
		}

		private void GenerateNewSprites()
		{
		}

		private void AdvanceAllSprites()
		{
		}

		private void RenderAllSprites()
		{
		}

		protected global::UnityEngine.Mesh GetMesh()
		{
			return null;
		}

		protected virtual global::UnityEngine.Mesh GenerateMesh()
		{
			return null;
		}
	}
}
