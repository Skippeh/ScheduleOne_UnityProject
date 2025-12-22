namespace ScheduleOne.Growing
{
	public class PotInteraction : global::ScheduleOne.Growing.GrowContainerInteraction
	{
		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.ObjectScripts.Pot _pot;

		protected override void Awake()
		{
		}

		protected override bool TryGetFallbackInteractionMessage(out string message, out global::ScheduleOne.Interaction.InteractableObject.EInteractableState state)
		{
			message = null;
			state = default(global::ScheduleOne.Interaction.InteractableObject.EInteractableState);
			return false;
		}
	}
}
