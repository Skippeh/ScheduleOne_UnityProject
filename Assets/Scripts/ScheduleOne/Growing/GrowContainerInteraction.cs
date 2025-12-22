namespace ScheduleOne.Growing
{
	public class GrowContainerInteraction : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Interaction.InteractableObject _interactableObject;

		private bool _interactableActivatedThisFrame;

		private global::UnityEngine.Vector3 displayLocationPointDefaultLocalPosition;

		protected virtual void Awake()
		{
		}

		private void LateUpdate()
		{
		}

		public void ConfigureInteraction(string labelText, global::ScheduleOne.Interaction.InteractableObject.EInteractableState interactionState, bool setLabelPosition = false, global::UnityEngine.Vector3 labelPosition = default(global::UnityEngine.Vector3))
		{
		}

		protected virtual bool TryGetFallbackInteractionMessage(out string message, out global::ScheduleOne.Interaction.InteractableObject.EInteractableState state)
		{
			message = null;
			state = default(global::ScheduleOne.Interaction.InteractableObject.EInteractableState);
			return false;
		}
	}
}
