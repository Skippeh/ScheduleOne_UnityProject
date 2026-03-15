namespace ScheduleOne
{
	public class InputDescriptor : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Assign a InputDescriptorData scriptableObject. The scriptableObject should be placed in Assets/CustomUI/InputDescriptor")]
		private global::ScheduleOne.InputDescriptorData data;

		[global::UnityEngine.SerializeField]
		[global::UnityEngine.Tooltip("Assign the UITrigger component that suppose to detect and receive input when the input action from the InputDescriptorData is fired")]
		private global::ScheduleOne.UITrigger uiTrigger;

		public void DetectTriggerInput()
		{
		}

		public void OnReset()
		{
		}

		public bool GetInputTriggered()
		{
			return false;
		}

		public T GetInputValue<T>() where T : struct
		{
			return default(T);
		}
	}
}
