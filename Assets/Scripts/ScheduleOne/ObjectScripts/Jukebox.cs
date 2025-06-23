namespace ScheduleOne.ObjectScripts
{
	public class Jukebox : global::ScheduleOne.EntityFramework.GridItem
	{
		[global::System.Serializable]
		public class Track
		{
			public string TrackName;

			public global::UnityEngine.AudioClip Clip;

			public string ArtistName;
		}

		[global::System.Serializable]
		public class JukeboxState
		{
			public int CurrentVolume;

			public bool IsPlaying;

			public float CurrentTrackTime;

			public int[] TrackOrder;

			public int CurrentTrackOrderIndex;

			public bool Shuffle;

			public global::ScheduleOne.ObjectScripts.Jukebox.ERepeatMode RepeatMode;

			public bool Sync;
		}

		public enum ERepeatMode
		{
			None = 0,
			RepeatQueue = 1,
			RepeatTrack = 2
		}

		public const float MUSIC_FADE_MULTIPLIER = 0.4f;

		public const int TRACK_COUNT = 27;

		private global::ScheduleOne.ObjectScripts.Jukebox.JukeboxState _jukeboxState;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.ObjectScripts.Jukebox.Track[] TrackList;

		public global::UnityEngine.GameObject[] VolumeIndicatorBars;

		public global::ScheduleOne.Audio.AudioSourceController AudioSourceController;

		public global::System.Action onStateChanged;

		private bool NetworkInitialize___EarlyScheduleOne_002EObjectScripts_002EJukeboxAssembly_002DCSharp_002Edll_Excuted;

		private bool NetworkInitialize__LateScheduleOne_002EObjectScripts_002EJukeboxAssembly_002DCSharp_002Edll_Excuted;

		public int CurrentVolume => 0;

		public float NormalizedVolume => 0f;

		public bool IsPlaying => false;

		public float CurrentTrackTime => 0f;

		private int[] TrackOrder => null;

		public int CurrentTrackOrderIndex => 0;

		public bool Shuffle => false;

		public global::ScheduleOne.ObjectScripts.Jukebox.ERepeatMode RepeatMode => default(global::ScheduleOne.ObjectScripts.Jukebox.ERepeatMode);

		public bool Sync => false;

		public global::ScheduleOne.ObjectScripts.Jukebox.Track currentTrack => null;

		private global::UnityEngine.AudioClip currentClip => null;

		public override void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		public override void OnSpawnServer(global::FishNet.Connection.NetworkConnection connection)
		{
		}

		public void ChangeVolume(int change)
		{
		}

		public void SetVolume(int volume, bool replicate)
		{
		}

		private void ApplyVolume()
		{
		}

		[global::EasyButtons.Button]
		public void TogglePlay()
		{
		}

		[global::EasyButtons.Button]
		public void Back()
		{
		}

		[global::EasyButtons.Button]
		public void Next()
		{
		}

		private int GetPreviousTrackOrderIndex()
		{
			return 0;
		}

		private int GetNextTrackOrderIndex()
		{
			return 0;
		}

		[global::EasyButtons.Button]
		public void ToggleShuffle()
		{
		}

		[global::EasyButtons.Button]
		public void ToggleRepeatMode()
		{
		}

		[global::EasyButtons.Button]
		public void ToggleSync()
		{
		}

		public void PlayTrack(int trackID)
		{
		}

		[global::FishNet.Object.ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SendJukeboxState(global::ScheduleOne.ObjectScripts.Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		[global::FishNet.Object.ObserversRpc(RunLocally = true)]
		[global::FishNet.Object.TargetRpc]
		public void SetJukeboxState(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		public void SetJukeboxState(global::ScheduleOne.ObjectScripts.Jukebox.JukeboxState state, bool setTrackTime)
		{
		}

		private global::ScheduleOne.ObjectScripts.Jukebox.Track GetTrack(int orderIndex)
		{
			return null;
		}

		private bool ValidateQueue(int[] queue)
		{
			return false;
		}

		private void ReplicateStateToOtherClients(bool setTrackTime)
		{
		}

		private void ReplicateStateToOtherJukeboxes(bool setTrackTime)
		{
		}

		public override global::ScheduleOne.Persistence.Datas.BuildableItemData GetBaseData()
		{
			return null;
		}

		public override void NetworkInitialize___Early()
		{
		}

		public override void NetworkInitialize__Late()
		{
		}

		public override void NetworkInitializeIfDisabled()
		{
		}

		private void RpcWriter___Server_SendJukeboxState_1728100027(global::ScheduleOne.ObjectScripts.Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		public void RpcLogic___SendJukeboxState_1728100027(global::ScheduleOne.ObjectScripts.Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		private void RpcReader___Server_SendJukeboxState_1728100027(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel, global::FishNet.Connection.NetworkConnection conn)
		{
		}

		private void RpcWriter___Observers_SetJukeboxState_2499833112(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		public void RpcLogic___SetJukeboxState_2499833112(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		private void RpcReader___Observers_SetJukeboxState_2499833112(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		private void RpcWriter___Target_SetJukeboxState_2499833112(global::FishNet.Connection.NetworkConnection conn, global::ScheduleOne.ObjectScripts.Jukebox.JukeboxState state, bool setTrackTime, bool setSync)
		{
		}

		private void RpcReader___Target_SetJukeboxState_2499833112(global::FishNet.Serializing.PooledReader PooledReader0, global::FishNet.Transporting.Channel channel)
		{
		}

		protected virtual void Awake_UserLogic_ScheduleOne_002EObjectScripts_002EJukebox_Assembly_002DCSharp_002Edll()
		{
		}
	}
}
