namespace ScheduleOne.UI.Stations
{
	public class MushroomSpawnStationInterface : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Stations.MushroomSpawnStationInterface>
	{
		private const float CameraLerpTime = 0.2f;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Canvas _canvas;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.RectTransform _container;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UI.ItemSlotUI _grainBagSlotUI;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UI.ItemSlotUI _syringeSlotUI;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.UI.ItemSlotUI _outputSlotUI;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.UI.Button _beginButton;

		[global::UnityEngine.SerializeField]
		private global::TMPro.TextMeshProUGUI _instructionLabel;

		public global::System.Action OnExitStation;

		public bool IsOpen { get; private set; }

		public global::ScheduleOne.StationFramework.MushroomSpawnStation Station { get; private set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Exit(global::ScheduleOne.DevUtilities.ExitAction action)
		{
		}

		private void Update()
		{
		}

		public void Open(global::ScheduleOne.StationFramework.MushroomSpawnStation station)
		{
		}

		public void Close(bool exitStation)
		{
		}

		private void StationContentsChanged()
		{
		}

		private void UpdateInstruction()
		{
		}

		private bool CanBeginTask(out string instruction)
		{
			instruction = null;
			return false;
		}

		private void UpdateBeginButton()
		{
		}

		private void BeginTask()
		{
		}
	}
}
