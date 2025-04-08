namespace ScheduleOne.UI.Construction
{
	public class FeaturesManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.Construction.FeaturesManager>
	{
		public global::ScheduleOne.ConstructableScripts.Constructable activeConstructable;

		public global::ScheduleOne.Construction.Features.Feature selectedFeature;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform featureIconsContainer;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform featureMenuRect;

		[global::UnityEngine.SerializeField]
		protected global::TMPro.TextMeshProUGUI featureMenuTitleLabel;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform featureInterfaceContainer;

		[global::UnityEngine.Header("Prefabs")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.GameObject featureIconPrefab;

		private global::ScheduleOne.UI.Construction.Features.FI_Base currentFeatureInterface;

		private bool roofSetInvisible;

		protected global::System.Collections.Generic.List<global::ScheduleOne.UI.Construction.FeatureIcon> featureIcons;

		public bool isActive => false;

		protected override void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public void OpenFeatureMenu(global::ScheduleOne.Construction.Features.Feature feature)
		{
		}

		public void CloseFeatureMenu()
		{
		}

		public void DeselectFeature()
		{
		}

		public void Activate(global::ScheduleOne.ConstructableScripts.Constructable constructable)
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
