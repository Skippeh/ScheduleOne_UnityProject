namespace ScheduleOne.Tiles
{
	public class Grid : global::UnityEngine.MonoBehaviour, global::ScheduleOne.IGUIDRegisterable
	{
		public const float TileSize = 0.5f;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.Tile> Tiles;

		public global::System.Collections.Generic.List<global::ScheduleOne.Tiles.CoordinateTilePair> CoordinateTilePairs;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Property.Property _parentProperty;

		[global::UnityEngine.Serialization.FormerlySerializedAs("StaticGUID")]
		[global::UnityEngine.SerializeField]
		private string _guid;

		public global::System.Action<string, global::ScheduleOne.Temperature.TemperatureEmitterInfo[]> OnCosmeticTemperatureEmittersChanged;

		public global::System.Action<global::ScheduleOne.Temperature.TemperatureEmitterInfo[]> OnTemperatureEmittersChanged;

		protected global::System.Collections.Generic.Dictionary<global::ScheduleOne.Tiles.Coordinate, global::ScheduleOne.Tiles.Tile> _coordinateToTile;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Temperature.TemperatureEmitter> _cosmeticTemperatureEmitters;

		protected global::System.Collections.Generic.List<global::ScheduleOne.Temperature.TemperatureEmitter> _temperatureEmitters;

		private bool _cosmeticEmittersChangedThisFrame;

		private bool _emittersChangedThisFrame;

		public global::System.Guid GUID { get; protected set; }

		public global::ScheduleOne.Property.Property ParentProperty => null;

		public global::UnityEngine.Transform Container => null;

		public global::UnityEngine.Vector3 Origin => default(global::UnityEngine.Vector3);

		public global::ScheduleOne.Temperature.TemperatureEmitterInfo[] TemperatureEmitterInfos { get; private set; }

		public int Width { get; private set; }

		public int Height { get; private set; }

		protected virtual void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		private void ProcessCoordinateDataPairs()
		{
		}

		public void RegisterTile(global::ScheduleOne.Tiles.Tile tile)
		{
		}

		public void DeregisterTile(global::ScheduleOne.Tiles.Tile tile)
		{
		}

		[global::EasyButtons.Button]
		public void RegenerateGUID()
		{
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		public global::ScheduleOne.Tiles.Coordinate GetMatchedCoordinate(global::ScheduleOne.Tiles.FootprintTile tileToMatch)
		{
			return null;
		}

		public bool IsTileValidAtCoordinate(global::ScheduleOne.Tiles.Coordinate gridCoord, global::ScheduleOne.Tiles.FootprintTile tile, global::ScheduleOne.EntityFramework.GridItem tileOwner = null)
		{
			return false;
		}

		public global::ScheduleOne.Tiles.Tile GetTile(global::ScheduleOne.Tiles.Coordinate coord)
		{
			return null;
		}

		[global::EasyButtons.Button]
		public void SetVisible()
		{
		}

		[global::EasyButtons.Button]
		public void SetInvisible()
		{
		}

		public void AddTemperatureEmitter(global::ScheduleOne.Temperature.TemperatureEmitter emitter, bool onlyCosmetic)
		{
		}

		public void RemoveTemperatureEmitter(global::ScheduleOne.Temperature.TemperatureEmitter emitter, bool onlyCosmetic)
		{
		}

		private void CosmeticTemperatureEmittersChanged()
		{
		}

		private void TemperatureEmittersChanged()
		{
		}

		private void SetGridSize()
		{
		}
	}
}
