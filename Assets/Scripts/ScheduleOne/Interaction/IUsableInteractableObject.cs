namespace ScheduleOne.Interaction
{
	public class IUsableInteractableObject : global::ScheduleOne.Interaction.InteractableObject
	{
		[global::UnityEngine.SerializeReference]
		private global::UnityEngine.MonoBehaviour _iUsableMonoBehaviour;

		private string _defaultMessage;

		private global::ScheduleOne.Management.IUsable _iUsable;

		private void Awake()
		{
		}

		public override void Hovered()
		{
		}
	}
}
