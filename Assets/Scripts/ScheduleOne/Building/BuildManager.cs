using System;
using System.Collections.Generic;
using FishNet.Object;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.ItemFramework;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using UnityEngine;
using Grid = ScheduleOne.Tiles.Grid;

namespace ScheduleOne.Building
{
	public class BuildManager : Singleton<BuildManager>
	{
		[Serializable]
		public class BuildSound
		{
			public BuildableItemDefinition.EBuildSoundType Type;

			public AudioSourceController Sound;
		}

		public List<BuildSound> PlaceSounds;

		[Header("References")]
		[SerializeField]
		protected Transform tempContainer;

		public NetworkObject networkObject;

		[Header("Prefabs")]
		[SerializeField]
		protected GameObject storedItemBuildHandler;

		[SerializeField]
		protected GameObject cashBuildHandler;

		[Header("Materials")]
		public Material ghostMaterial_White;

		public Material ghostMaterial_Red;

		public Transform _tempContainer => null;

		public bool isBuilding { get; protected set; }

		public GameObject currentBuildHandler { get; protected set; }

		protected override void Awake()
		{
		}

		public void StartBuilding(ItemInstance item)
		{
		}

		public void StartBuildingStoredItem(ItemInstance item)
		{
		}

		public void StartPlacingCash(ItemInstance item)
		{
		}

		public void StopBuilding()
		{
		}

		public void PlayBuildSound(BuildableItemDefinition.EBuildSoundType type, Vector3 point)
		{
		}

		public void DisableColliders(GameObject obj)
		{
		}

		public void DisableLights(GameObject obj)
		{
		}

		public void DisableNetworking(GameObject obj)
		{
		}

		public void DisableSpriteRenderers(GameObject obj)
		{
		}

		public void ApplyMaterial(GameObject obj, Material mat, bool allMaterials = true)
		{
		}

		public void DisableNavigation(GameObject obj)
		{
		}

		public void DisableCanvases(GameObject obj)
		{
		}

		public GridItem CreateGridItem(ItemInstance item, Grid grid, Vector2 originCoordinate, int rotation, string guid = "")
		{
			return null;
		}

		public ProceduralGridItem CreateProceduralGridItem(ItemInstance item, int rotationAngle, List<CoordinateProceduralTilePair> matches, string guid = "")
		{
			return null;
		}

		public SurfaceItem CreateSurfaceItem(ItemInstance item, Surface parentSurface, Vector3 relativePosition, Quaternion relativeRotation, string guid = "")
		{
			return null;
		}

		public void CreateStoredItem(StorableItemInstance item, IStorageEntity parentStorageEntity, StorageGrid grid, Vector2 originCoord, float rotation)
		{
		}
	}
}
