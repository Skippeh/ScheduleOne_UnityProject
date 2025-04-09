using System.Collections.Generic;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.Construction.Features;
using ScheduleOne.DevUtilities;
using ScheduleOne.UI.Construction.Features;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI.Construction
{
	public class FeaturesManager : Singleton<FeaturesManager>
	{
		public Constructable activeConstructable;

		public Feature selectedFeature;

		[Header("References")]
		[SerializeField]
		protected RectTransform featureIconsContainer;

		[SerializeField]
		protected RectTransform featureMenuRect;

		[SerializeField]
		protected TextMeshProUGUI featureMenuTitleLabel;

		[SerializeField]
		protected RectTransform featureInterfaceContainer;

		[Header("Prefabs")]
		[SerializeField]
		protected GameObject featureIconPrefab;

		private FI_Base currentFeatureInterface;

		private bool roofSetInvisible;

		protected List<FeatureIcon> featureIcons;

		public bool isActive => false;

		protected override void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public void OpenFeatureMenu(Feature feature)
		{
		}

		public void CloseFeatureMenu()
		{
		}

		public void DeselectFeature()
		{
		}

		public void Activate(Constructable constructable)
		{
		}

		public void Deactivate()
		{
		}

		private void ClearIcons()
		{
		}

		private void CreateIcons()
		{
		}

		private void UpdateIconTransforms()
		{
		}
	}
}
