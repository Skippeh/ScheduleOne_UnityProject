using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ScheduleOne.UI
{
	public class FeedbackForm : AeLa.EasyFeedback.FeedbackForm
	{
		[CompilerGenerated]
		private sealed class _003CScreenshotAndOpenForm_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public FeedbackForm _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CScreenshotAndOpenForm_003Ed__18(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private Coroutine ssCoroutine;

		public CanvasGroup CanvasGroup;

		public Toggle ScreenshotToggle;

		public Toggle SaveFileToggle;

		public TMP_InputField SummaryField;

		public TMP_InputField DescriptionField;

		public RectTransform Cog;

		public TMP_Dropdown CategoryDropdown;

		public override void Awake()
		{
		}

		private void Update()
		{
		}

		public void PrepScreenshot()
		{
		}

		private void OnScreenshotToggle(bool value)
		{
		}

		private void OnSaveFileToggle(bool value)
		{
		}

		public void SetFormData(string title)
		{
		}

		public void SetCategory(string categoryName)
		{
		}

		public override void Submit()
		{
		}

		protected override string GetTextToAppendToTitle()
		{
			return null;
		}

		private void Clear()
		{
		}

		[IteratorStateMachine(typeof(_003CScreenshotAndOpenForm_003Ed__18))]
		private IEnumerator ScreenshotAndOpenForm()
		{
			return null;
		}
	}
}
