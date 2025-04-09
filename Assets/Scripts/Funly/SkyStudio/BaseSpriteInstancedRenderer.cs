using System.Collections.Generic;
using UnityEngine;

namespace Funly.SkyStudio
{
	public abstract class BaseSpriteInstancedRenderer : MonoBehaviour
	{
		public const int kArrayMaxSprites = 1000;

		[Tooltip("Mesh used to render the instances onto. If empty, a quad will be used.")]
		public Mesh modelMesh;

		[Tooltip("Sky Studio sprite sheet animated shader material.")]
		public Material renderMaterial;

		protected Queue<BaseSpriteItemData> m_Available;

		protected HashSet<BaseSpriteItemData> m_Active;

		private MaterialPropertyBlock m_PropertyBlock;

		private Matrix4x4[] m_ModelMatrices;

		private float[] m_StartTimes;

		private float[] m_EndTimes;

		protected SpriteSheetData m_SpriteSheetLayout;

		protected Texture m_SpriteTexture;

		protected Color m_TintColor;

		protected Mesh m_DefaltModelMesh;

		public int maxSprites { get; protected set; }

		protected Camera m_ViewerCamera { get; set; }

		private void Start()
		{
		}

		protected abstract Bounds CalculateMeshBounds();

		protected abstract BaseSpriteItemData CreateSpriteItemData();

		protected abstract bool IsRenderingEnabled();

		protected abstract int GetNextSpawnCount();

		protected abstract void CalculateSpriteTRS(BaseSpriteItemData data, out Vector3 spritePosition, out Quaternion spriteRotation, out Vector3 spriteScale);

		protected abstract void ConfigureSpriteItemData(BaseSpriteItemData data);

		protected abstract void PrepareDataArraysForRendering(int instanceId, BaseSpriteItemData data);

		protected abstract void PopulatePropertyBlockForRendering(ref MaterialPropertyBlock propertyBlock);

		private BaseSpriteItemData DequeueNextSpriteItemData()
		{
			return null;
		}

		private void ReturnSpriteItemData(BaseSpriteItemData splash)
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

		protected Mesh GetMesh()
		{
			return null;
		}

		protected virtual Mesh GenerateMesh()
		{
			return null;
		}
	}
}
