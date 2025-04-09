using System.Collections.Generic;
using ScheduleOne.DevUtilities;
using ScheduleOne.Vehicles;
using ScheduleOne.Vehicles.Modification;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class VehicleModMenu : Singleton<VehicleModMenu>
	{
		public static float repaintCost;

		[Header("UI References")]
		[SerializeField]
		protected Canvas canvas;

		[SerializeField]
		protected RectTransform buttonContainer;

		[SerializeField]
		protected RectTransform tempIndicator;

		[SerializeField]
		protected RectTransform permIndicator;

		[SerializeField]
		protected Button confirmButton_Online;

		[SerializeField]
		protected TextMeshProUGUI confirmText_Online;

		[Header("References")]
		public Transform CameraPosition;

		public Transform VehiclePosition;

		[Header("Prefabs")]
		[SerializeField]
		protected GameObject buttonPrefab;

		public UnityEvent onPaintPurchased;

		protected LandVehicle currentVehicle;

		protected List<RectTransform> colorButtons;

		protected Dictionary<EVehicleColor, RectTransform> colorToButton;

		protected EVehicleColor selectedColor;

		private Coroutine openCloseRoutine;

		public bool IsOpen { get; private set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Exit(ExitAction action)
		{
		}

		protected virtual void Update()
		{
		}

		public void Open(LandVehicle vehicle)
		{
		}

		public void Close()
		{
		}

		public void ColorClicked(EVehicleColor col)
		{
		}

		private void UpdateConfirmButton()
		{
		}

		private void RefreshSelectionIndicator()
		{
		}

		public void ConfirmButtonClicked()
		{
		}
	}
}
