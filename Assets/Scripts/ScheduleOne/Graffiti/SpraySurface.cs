namespace ScheduleOne.Graffiti
{
	public class SpraySurface : global::FishNet.Object.NetworkBehaviour
	{
		public const float PIXEL_SIZE = 0.006666671f;

		[global::UnityEngine.Header("Settings")]
		public bool Editable;

		[global::UnityEngine.Range(1f, 1000f)]
		public int Width;

		[global::UnityEngine.Range(1f, 1000f)]
		public int Height;

		public global::UnityEngine.AnimationCurve FalloffCurve;

		[global::UnityEngine.SerializeField]
		public bool IsVandalismSurface;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform BottomLeftPoint;

		public global::UnityEngine.Rendering.Universal.DecalProjector Projector;

		protected global::ScheduleOne.Graffiti.Drawing drawing;

		private global::ScheduleOne.Graffiti.Drawing cachedDrawing;

		public global::System.Action onDrawingChanged;

		private global::System.Collections.Generic.List<int> pastRequestIDs;

		private bool NetworkInitialize___EarlyScheduleOne_002EGraffiti_002ESpraySurfaceAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EGraffiti_002ESpraySurfaceAssembly_002DCSharp_002Edll_Excuted;

		public global::FishNet.Object.NetworkObject CurrentEditor { get; private set; }

		public int DrawingStrokeCount => 0;

		public global::UnityEngine.Texture DrawingOutputTexture => null;

		public int DrawingPaintedPixelCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int RoundedWidth => 0;

		public int RoundedHeight => 0;

		public bool ContainsCartelGraffiti { get; set; }

		public global::UnityEngine.Vector3 TopRightPoint => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Vector3 CenterPoint => default(global::UnityEngine.Vector3);

		public virtual void Awake()
		{
		}

		protected override void OnValidate()
		{
		}

		private void ResizeProjector()
		{
		}

		public bool CanBeEdited(bool checkEditor)
		{
			return false;
		}

		public bool CanUndo()
		{
			return false;
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public virtual void ReplicateTo(global::FishNet.Connection.NetworkConnection conn)
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

		public virtual void OnEditingFinished()
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

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void AddTextureToHistory_Server(int requestID)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void AddTextureToHistory_Client(int requestID)
		{
		}

		public void CacheDrawing()
		{
		}

		public void PrintHistoryCount()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void Undo_Server(int requestID)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		private void Undo_Client(int requestID)
		{
		}

		public virtual void CleanGraffiti()
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false)]
		public void ClearDrawing()
		{
		}

		public void EnsureDrawingExists()
		{
		}

		protected void CreateNewDrawing()
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

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void Set(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Graffiti.SprayStroke[] strokes, bool isCartelGraffiti)
		{
		}

		private void DrawingChanged()
		{
		}

		public global::ScheduleOne.Graffiti.SerializedGraffitiDrawing GetSerializedDrawing()
		{
			return null;
		}

		[global::EasyButtons.Button]
		public void LoadSerializedDrawing(global::ScheduleOne.Graffiti.SerializedGraffitiDrawing serializedDrawing, bool isCartelGraffiti)
		{
		}

		public bool WillDrawingFit(int width, int height)
		{
			return false;
		}

		public static int GetPadding(byte strokeSize)
		{
			return 0;
		}

		public virtual bool ShouldSave()
		{
			return false;
		}

		public virtual global::ScheduleOne.Persistence.Datas.SpraySurfaceData GetSaveData()
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

		private void RpcWriter___Server_AddTextureToHistory_Server_3316948804(int requestID)
		{
		}

		public void RpcLogic___AddTextureToHistory_Server_3316948804(int requestID)
		{
		}

		private void RpcReader___Server_AddTextureToHistory_Server_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_AddTextureToHistory_Client_3316948804(int requestID)
		{
		}

		private void RpcLogic___AddTextureToHistory_Client_3316948804(int requestID)
		{
		}

		private void RpcReader___Observers_AddTextureToHistory_Client_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Server_Undo_Server_3316948804(int requestID)
		{
		}

		public void RpcLogic___Undo_Server_3316948804(int requestID)
		{
		}

		private void RpcReader___Server_Undo_Server_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_Undo_Client_3316948804(int requestID)
		{
		}

		private void RpcLogic___Undo_Client_3316948804(int requestID)
		{
		}

		private void RpcReader___Observers_Undo_Client_3316948804(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
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

		private void RpcWriter___Observers_Set_4105842735(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Graffiti.SprayStroke[] strokes, bool isCartelGraffiti)
		{
		}

		public void RpcLogic___Set_4105842735(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Graffiti.SprayStroke[] strokes, bool isCartelGraffiti)
		{
		}

		private void RpcReader___Observers_Set_4105842735(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_Set_4105842735(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.Graffiti.SprayStroke[] strokes, bool isCartelGraffiti)
		{
		}

		private void RpcReader___Target_Set_4105842735(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EGraffiti_002ESpraySurface_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
