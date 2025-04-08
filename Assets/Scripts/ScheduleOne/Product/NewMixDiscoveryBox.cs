namespace ScheduleOne.Product
{
	public class NewMixDiscoveryBox : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class DrugTypeVisuals
		{
			public global::ScheduleOne.Product.EDrugType DrugType;

			public global::ScheduleOne.Packaging.FilledPackagingVisuals Visuals;
		}

		private bool isOpen;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform CameraPosition;

		public global::TMPro.TextMeshPro PropertiesText;

		public global::ScheduleOne.Product.NewMixDiscoveryBox.DrugTypeVisuals[] Visuals;

		public global::UnityEngine.Animation Animation;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Transform Lid;

		private global::UnityEngine.Pose closedLidPose;

		private global::ScheduleOne.Product.NewMixOperation currentMix;

		public void Start()
		{
		}

		public void ShowProduct(global::ScheduleOne.Product.ProductDefinition baseDefinition, global::System.Collections.Generic.List<global::ScheduleOne.Properties.Property> properties)
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
