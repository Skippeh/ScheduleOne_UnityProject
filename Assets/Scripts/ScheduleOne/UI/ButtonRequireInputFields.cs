namespace ScheduleOne.UI
{
	public class ButtonRequireInputFields : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public class Input
		{
			public global::TMPro.TMP_InputField InputField;

			public global::UnityEngine.RectTransform ErrorMessage;
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.UI.ButtonRequireInputFields.Input> Inputs;

		public global::TMPro.TMP_Dropdown Dropdown;

		public global::UnityEngine.UI.Button Button;

		public void Update()
		{
		}
	}
}
