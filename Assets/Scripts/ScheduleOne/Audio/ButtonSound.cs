using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace ScheduleOne.Audio
{
	[RequireComponent(typeof(Button))]
	[RequireComponent(typeof(EventTrigger))]
	[RequireComponent(typeof(AudioSourceController))]
	public class ButtonSound : MonoBehaviour
	{
		public AudioSourceController AudioSource;

		public EventTrigger EventTrigger;

		[Header("Clips")]
		public AudioClip HoverClip;

		public float HoverSoundVolume;

		public AudioClip ClickClip;

		public float ClickSoundVolume;

		private Button Button;

		public void Awake()
		{
		}

		private void OnValidate()
		{
		}

		public void AddEventTrigger(EventTrigger eventTrigger, EventTriggerType eventTriggerType, Action action)
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
