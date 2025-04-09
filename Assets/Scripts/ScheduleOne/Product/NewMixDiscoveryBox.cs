using System;
using System.Collections.Generic;
using ScheduleOne.Interaction;
using ScheduleOne.Packaging;
using TMPro;
using UnityEngine;

namespace ScheduleOne.Product
{
	public class NewMixDiscoveryBox : MonoBehaviour
	{
		[Serializable]
		public class DrugTypeVisuals
		{
			public EDrugType DrugType;

			public FilledPackagingVisuals Visuals;
		}

		private bool isOpen;

		[Header("References")]
		public Transform CameraPosition;

		public TextMeshPro PropertiesText;

		public DrugTypeVisuals[] Visuals;

		public Animation Animation;

		public InteractableObject IntObj;

		public Transform Lid;

		private Pose closedLidPose;

		private NewMixOperation currentMix;

		public void Start()
		{
		}

		public void ShowProduct(ProductDefinition baseDefinition, List<ScheduleOne.Properties.Property> properties)
		{
		}

		private void CloseCase()
		{
		}

		private void OpenCase()
		{
		}

		private void Interacted()
		{
		}
	}
}
