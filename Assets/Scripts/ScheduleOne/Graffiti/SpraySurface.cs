namespace ScheduleOne.Graffiti
{
	public class SpraySurface : global::FishNet.Object.NetworkBehaviour, global::ScheduleOne.IGUIDRegisterable
	{
		public const float PIXEL_SIZE = 0.006666671f;

		public const int PADDING = 8;

		[global::UnityEngine.Header("Settings")]
		public string BakedGUID;

		[global::UnityEngine.Range(1f, 1000f)]
		public int Width;

		[global::UnityEngine.Range(1f, 1000f)]
		public int Height;

		public global::UnityEngine.AnimationCurve FalloffCurve;

		[global::UnityEngine.Range(0f, 100f)]
		public int FalloffRadius;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform BottomLeftPoint;

		public global::UnityEngine.Rendering.Universal.DecalProjector Projector;

		private global::ScheduleOne.Graffiti.Drawing drawing;

		private global::ScheduleOne.Graffiti.Drawing cachedDrawing;

		public global::System.Action onDrawingChanged;

		private global::System.Collections.Generic.List<int> pastRequestIDs;

		private bool NetworkInitialize___EarlyScheduleOne_002EGraffiti_002ESpraySurfaceAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EGraffiti_002ESpraySurfaceAssembly_002DCSharp_002Edll_Excuted;

		public global::System.Guid GUID { get; protected set; }

		public global::FishNet.Object.NetworkObject CurrentEditor { get; private set; }

		public int DrawingStrokeCount => 0;

		public global::UnityEngine.Texture DrawingOutputTexture => null;

		public int DrawingPaintedPixelCount => 0;

		public global::ScheduleOne.Map.EMapRegion Region { get; private set; }

		public bool HasDrawingBeenFinalized { get; private set; }

		public global::UnityEngine.Vector3 TopRightPoint => default(global::UnityEngine.Vector3);

		public virtual void Awake()
		{
		}

		private void Start()
		{
		}

		protected override void OnValidate()
		{
		}

		private void ResizeProjector()
		{
		}

		public bool CanBeEdited()
		{
			return false;
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void ReplicateTo(global::FishNet.Connection.NetworkConnection conn)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void SetCurrentEditor_Server(global::FishNet.Object.NetworkObject player)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		private void SetCurrentEditor_Client(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject player)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void AddStrokes_Server(global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> newStrokes, int requestID)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void AddStrokes_Client(global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> newStrokes, int requestID)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void ClearDrawing()
		{
		}

		public void EnsureDrawingExists()
		{
		}

		private void CreateNewDrawing()
		{
		}

		public void CacheDrawing()
		{
		}

		public void RestoreFromCache()
		{
		}

		public global::UnityEngine.Vector3 ToWorldPosition(global::ScheduleOne.Graffiti.UShort2 coordinate, float offset = 0f)
		{
			return default(global::UnityEngine.Vector3);
		}

		public void DrawPaintedPixel(global::ScheduleOne.Graffiti.PixelData data, bool applyTexture)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void MarkDrawingFinalized()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void SetFinalized()
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void Set(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Graffiti.SprayStroke[] strokes, bool hasBeenFinalized)
		{
		}

		private void DrawingChanged()
		{
		}

		private float[] GetFalloffTable()
		{
			return null;
		}

		public void SetGUID(global::System.Guid guid)
		{
		}

		[global::EasyButtons.Button]
		public void RegenerateGUID()
		{
		}

		public bool ShouldSave()
		{
			return false;
		}

		public global::ScheduleOne.Persistence.Datas.SpraySurfaceData GetSaveData()
		{
			return null;
		}

		public virtual void NetworkInitialize___Early()
		{
		}

		public virtual void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Server_SetCurrentEditor_Server_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		public void RpcLogic___SetCurrentEditor_Server_3323014238(global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcReader___Server_SetCurrentEditor_Server_3323014238(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetCurrentEditor_Client_1824087381(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcLogic___SetCurrentEditor_Client_1824087381(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcReader___Observers_SetCurrentEditor_Client_1824087381(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetCurrentEditor_Client_1824087381(global::FishNet.Connection.NetworkConnection conn, global::FishNet.Object.NetworkObject player)
		{
		}

		private void RpcReader___Target_SetCurrentEditor_Client_1824087381(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_AddStrokes_Server_1511871282(global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> newStrokes, int requestID)
		{
		}

		public void RpcLogic___AddStrokes_Server_1511871282(global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> newStrokes, int requestID)
		{
		}

		private void RpcReader___Server_AddStrokes_Server_1511871282(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_AddStrokes_Client_1511871282(global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> newStrokes, int requestID)
		{
		}

		private void RpcLogic___AddStrokes_Client_1511871282(global::System.Collections.Generic.List<global::ScheduleOne.Graffiti.SprayStroke> newStrokes, int requestID)
		{
		}

		private void RpcReader___Observers_AddStrokes_Client_1511871282(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_ClearDrawing_2166136261()
		{
		}

		public void RpcLogic___ClearDrawing_2166136261()
		{
		}

		private void RpcReader___Server_ClearDrawing_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Server_MarkDrawingFinalized_2166136261()
		{
		}

		public void RpcLogic___MarkDrawingFinalized_2166136261()
		{
		}

		private void RpcReader___Server_MarkDrawingFinalized_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetFinalized_2166136261()
		{
		}

		private void RpcLogic___SetFinalized_2166136261()
		{
		}

		private void RpcReader___Observers_SetFinalized_2166136261(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Observers_Set_4105842735(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Graffiti.SprayStroke[] strokes, bool hasBeenFinalized)
		{
		}

		public void RpcLogic___Set_4105842735(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Graffiti.SprayStroke[] strokes, bool hasBeenFinalized)
		{
		}

		private void RpcReader___Observers_Set_4105842735(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_Set_4105842735(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Graffiti.SprayStroke[] strokes, bool hasBeenFinalized)
		{
		}

		private void RpcReader___Target_Set_4105842735(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void Awake_UserLogic_ScheduleOne_002EGraffiti_002ESpraySurface_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
