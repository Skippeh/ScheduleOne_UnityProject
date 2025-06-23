namespace ScheduleOne.Audio
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.UI.Button))]
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.EventSystems.EventTrigger))]
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Audio.AudioSourceController))]
	public class ButtonSound : global::UnityEngine.MonoBehaviour
	{
		public global::ScheduleOne.Audio.AudioSourceController AudioSource;

		public global::UnityEngine.EventSystems.EventTrigger EventTrigger;

		public bool PlaySoundOnClickStart;

		[global::UnityEngine.Header("Clips")]
		public global::UnityEngine.AudioClip HoverClip;

		public float HoverSoundVolume;

		public global::UnityEngine.AudioClip ClickClip;

		public float ClickSoundVolume;

		private global::UnityEngine.UI.Button Button;

		public void Awake()
		{
		}

		private void OnValidate()
		{
		}

		public void AddEventTrigger(global::UnityEngine.EventSystems.EventTrigger eventTrigger, global::UnityEngine.EventSystems.EventTriggerType eventTriggerType, global::System.Action action)
		{
		}

		protected virtual void Hovered()
		{
		}

		protected virtual void Clicked()
		{
		}
	}
}
