namespace ScheduleOne.Casino
{
	public class SlotReel : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class SymbolRotation
		{
			public global::ScheduleOne.Casino.SlotMachine.ESymbol Symbol;

			public float Rotation;
		}

		[global::UnityEngine.Header("Settings")]
		public global::ScheduleOne.Casino.SlotReel.SymbolRotation[] SymbolRotations;

		public float SpinSpeed;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Audio.AudioSourceController StopSound;

		public global::UnityEngine.Events.UnityEvent onStart;

		public global::UnityEngine.Events.UnityEvent onStop;

		public bool IsSpinning { get; private set; }

		public global::ScheduleOne.Casino.SlotMachine.ESymbol CurrentSymbol { get; private set; }

		public float CurrentRotation { get; private set; }

		private void Awake()
		{
		}

		private void Update()
		{
		}

		public void Spin()
		{
		}

		public void Stop(global::ScheduleOne.Casino.SlotMachine.ESymbol endSymbol)
		{
		}

		public void SetSymbol(global::ScheduleOne.Casino.SlotMachine.ESymbol symbol)
		{
		}

		private void SetReelRotation(float rotation)
		{
		}

		private float GetSymbolRotation(global::ScheduleOne.Casino.SlotMachine.ESymbol symbol)
		{
			return 0f;
		}
	}
}
