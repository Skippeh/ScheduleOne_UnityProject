using ScheduleOne.DevUtilities;
using TMPro;
using UnityEngine;

namespace ScheduleOne.UI
{
	public class TextInputScreen : Singleton<TextInputScreen>
	{
		public delegate void OnSubmit(string text);

		public Canvas Canvas;

		public TextMeshProUGUI HeaderLabel;

		public TMP_InputField InputField;

		private OnSubmit onSubmit;

		public bool IsOpen => false;

		protected override void Awake()
		{
		}

		public void Submit()
		{
		}

		public void Cancel()
		{
		}

		private void Update()
		{
		}

		public void Exit(ExitAction action)
		{
		}

		public void Open(string header, string text, OnSubmit _onSubmit, int maxChars = 10000)
		{
		}

		private void Close(bool submit)
		{
		}
	}
}
