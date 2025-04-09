using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class ButtonRequireInputFields : MonoBehaviour
	{
		[Serializable]
		public class Input
		{
			public TMP_InputField InputField;

			public RectTransform ErrorMessage;
		}

		public List<Input> Inputs;

		public TMP_Dropdown Dropdown;

		public Button Button;

		public void Update()
		{
		}
	}
}
