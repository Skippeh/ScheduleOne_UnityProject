namespace ScheduleOne.Audio
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.UI.Button))]
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.EventSystems.EventTrigger))]
	[global::UnityEngine.RequireComponent(typeof(global::ScheduleOne.Audio.AudioSourceController))]
	public class ButtonSound : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("PlaySoundOnClickStart")]
		private bool _playSoundOnClickStart;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("HoverClip")]
		private global::UnityEngine.AudioClip _hoverClip;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("HoverSoundVolume")]
		private float _hoverVolume;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("ClickClip")]
		private global::UnityEngine.AudioClip _clickClip;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Serialization.FormerlySerializedAs("ClickSoundVolume")]
		private float _clickVolume;

		private global::ScheduleOne.Audio.AudioSourceController _audioSource;

		private global::UnityEngine.UI.Button _button;

		private global::UnityEngine.EventSystems.EventTrigger _eventTrigger;

		public void Awake()
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
