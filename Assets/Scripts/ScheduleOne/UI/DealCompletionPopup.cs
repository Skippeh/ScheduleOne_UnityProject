namespace ScheduleOne.UI
{
	public class DealCompletionPopup : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.DealCompletionPopup>
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CPlayPopupRoutine_003Ed__21 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ScheduleOne.UI.DealCompletionPopup _003C_003E4__this;

			public global::ScheduleOne.Economy.Customer customer;

			public global::System.Collections.Generic.List<global::ScheduleOne.Quests.Contract.BonusPayment> bonuses;

			public float originalRelationshipDelta;

			public float basePayment;

			public float satisfaction;

			private float _003CpaymentLerpTime_003E5__2;

			private float _003CsatisfactionLerpTime_003E5__3;

			private float _003CendDelta_003E5__4;

			private float _003ClerpTime_003E5__5;

			private float _003Ci_003E5__6;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CPlayPopupRoutine_003Ed__21(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.RectTransform Container;

		public global::UnityEngine.CanvasGroup Group;

		public global::UnityEngine.Animation Anim;

		public global::TMPro.TextMeshProUGUI Title;

		public global::TMPro.TextMeshProUGUI PaymentLabel;

		public global::TMPro.TextMeshProUGUI SatisfactionValueLabel;

		public global::ScheduleOne.UI.Relations.RelationCircle RelationCircle;

		public global::TMPro.TextMeshProUGUI RelationshipLabel;

		public global::UnityEngine.Gradient SatisfactionGradient;

		public global::ScheduleOne.Audio.AudioSourceController SoundEffect;

		public global::TMPro.TextMeshProUGUI[] BonusLabels;

		[global::UnityEngine.Header("Animations")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Animation _animation;

		private global::UnityEngine.Coroutine routine;

		private global::UnityEngine.AnimationState _animationState;

		public bool IsPlaying { get; protected set; }

		protected override void Awake()
		{
		}

		public void PlayPopup(global::ScheduleOne.Economy.Customer customer, float satisfaction, float originalRelationshipDelta, float basePayment, global::System.Collections.Generic.List<global::ScheduleOne.Quests.Contract.BonusPayment> bonuses)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.UI.DealCompletionPopup._003CPlayPopupRoutine_003Ed__21))]
		private global::System.Collections.IEnumerator PlayPopupRoutine(global::ScheduleOne.Economy.Customer customer, float satisfaction, float originalRelationshipDelta, float basePayment, global::System.Collections.Generic.List<global::ScheduleOne.Quests.Contract.BonusPayment> bonuses)
		{
			return null;
		}

		private void SetRelationshipLabel(float delta)
		{
		}
	}
}
