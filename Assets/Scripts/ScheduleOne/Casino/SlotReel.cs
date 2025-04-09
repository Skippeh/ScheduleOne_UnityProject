using System;
using ScheduleOne.Audio;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Casino
{
	public class SlotReel : MonoBehaviour
	{
		[Serializable]
		public class SymbolRotation
		{
			public SlotMachine.ESymbol Symbol;

			public float Rotation;
		}

		[Header("Settings")]
		public SymbolRotation[] SymbolRotations;

		public float SpinSpeed;

		[Header("References")]
		public AudioSourceController StopSound;

		public UnityEvent onStart;

		public UnityEvent onStop;

		public bool IsSpinning { get; private set; }

		public SlotMachine.ESymbol CurrentSymbol { get; private set; }

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

		public void Stop(SlotMachine.ESymbol endSymbol)
		{
		}

		public void SetSymbol(SlotMachine.ESymbol symbol)
		{
		}

		private void SetReelRotation(float rotation)
		{
		}

		private float GetSymbolRotation(SlotMachine.ESymbol symbol)
		{
			return 0f;
		}
	}
}
