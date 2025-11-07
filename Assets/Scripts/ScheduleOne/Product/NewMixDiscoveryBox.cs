namespace ScheduleOne.Product
{
	public class NewMixDiscoveryBox : global::UnityEngine.MonoBehaviour
	{
		private bool isOpen;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform CameraPosition;

		public global::TMPro.TextMeshPro PropertiesText;

		public global::UnityEngine.Animation Animation;

		public global::ScheduleOne.Interaction.InteractableObject IntObj;

		public global::UnityEngine.Transform Lid;

		public global::ScheduleOne.Product.MultiTypeVisualsSetter Visuals;

		private global::UnityEngine.Pose closedLidPose;

		private global::ScheduleOne.Product.NewMixOperation currentMix;

		public void Start()
		{
		}

		public void ShowProduct(global::ScheduleOne.Product.ProductDefinition baseDefinition, global::System.Collections.Generic.List<global::ScheduleOne.Effects.Effect> properties)
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
