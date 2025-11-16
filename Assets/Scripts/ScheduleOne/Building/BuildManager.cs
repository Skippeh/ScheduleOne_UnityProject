namespace ScheduleOne.Building
{
	public class BuildManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Building.BuildManager>
	{
		[global::System.Serializable]
		public class BuildSound
		{
			public global::ScheduleOne.ItemFramework.BuildableItemDefinition.EBuildSoundType Type;

			public global::ScheduleOne.Audio.AudioSourceController Sound;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.Building.BuildManager.BuildSound> PlaceSounds;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Transform tempContainer;

		public global::FishNet.Object.NetworkObject networkObject;

		[global::UnityEngine.Header("Prefabs")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject storedItemBuildHandler;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject cashBuildHandler;

		[global::UnityEngine.Header("Materials")]
		public global::UnityEngine.Material ghostMaterial_White;

		public global::UnityEngine.Material ghostMaterial_Red;

		public global::UnityEngine.Transform _tempContainer => null;

		public bool isBuilding { get; protected set; }

		public global::UnityEngine.GameObject currentBuildHandler { get; protected set; }

		protected override void Awake()
		{
		}

		public void StartBuilding(global::ScheduleOne.ItemFramework.ItemInstance item)
		{
		}

		public void StopBuilding()
		{
		}

		public void PlayBuildSound(global::ScheduleOne.ItemFramework.BuildableItemDefinition.EBuildSoundType type, global::UnityEngine.Vector3 point)
		{
		}

		public void DisableColliders(global::UnityEngine.GameObject obj)
		{
		}

		public void DisableLights(global::UnityEngine.GameObject obj)
		{
		}

		public void DisableNetworking(global::UnityEngine.GameObject obj)
		{
		}

		public void DisableSpriteRenderers(global::UnityEngine.GameObject obj)
		{
		}

		public void ApplyMaterial(global::UnityEngine.GameObject obj, global::UnityEngine.Material mat, bool allMaterials = true)
		{
		}

		public void DisableNavigation(global::UnityEngine.GameObject obj)
		{
		}

		public void DisableCanvases(global::UnityEngine.GameObject obj)
		{
		}

		public global::ScheduleOne.EntityFramework.GridItem CreateGridItem(global::ScheduleOne.ItemFramework.ItemInstance item, global::ScheduleOne.Tiles.Grid grid, global::UnityEngine.Vector2 originCoordinate, int rotation, string guid = "")
		{
			return null;
		}

		public global::ScheduleOne.EntityFramework.ProceduralGridItem CreateProceduralGridItem(global::ScheduleOne.ItemFramework.ItemInstance item, int rotationAngle, global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateProceduralTilePair> matches, string guid = "")
		{
			return null;
		}

		public global::ScheduleOne.EntityFramework.SurfaceItem CreateSurfaceItem(global::ScheduleOne.ItemFramework.ItemInstance item, global::ScheduleOne.Building.Surface parentSurface, global::UnityEngine.Vector3 relativePosition, global::UnityEngine.Quaternion relativeRotation, string guid = "")
		{
			return null;
		}
	}
}
