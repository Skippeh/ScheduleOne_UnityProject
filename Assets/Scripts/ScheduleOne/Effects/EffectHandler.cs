namespace ScheduleOne.Effects
{
	public abstract class EffectHandler : global::UnityEngine.MonoBehaviour
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDoDelayDeactivate_003Ed__24 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float duration;

			public global::ScheduleOne.Effects.EffectHandler _003C_003E4__this;

			public global::System.Action onComplete;

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
			public _003CDoDelayDeactivate_003Ed__24(int _003C_003E1__state)
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

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private string _id;

		[global::UnityEngine.SerializeField]
		private bool _scaleToParent;

		[global::UnityEngine.SerializeField]
		private bool _positionToParent;

		[global::UnityEngine.SerializeField]
		private bool _activeByDefault;

		private global::UnityEngine.Coroutine _delayDeactivateCoroutine;

		public virtual string Id => null;

		public virtual bool ScaleToParent => false;

		public virtual bool PositionToParent => false;

		public abstract void Activate();

		public abstract void Deactivate();

		public abstract void SetNumericParameter(string effectName, string variable, float value);

		public abstract void SetNumericParameterForAll(string variable, float value);

		public abstract void SetVectorParameter(string effectName, string variable, global::UnityEngine.Vector3 value);

		public abstract void SetVectorParameter(string effectName, string variable, global::UnityEngine.Vector2 value);

		public abstract void SetVectorParameterForAll(string variable, global::UnityEngine.Vector3 value);

		public abstract void SetVectorParameterForAll(string variable, global::UnityEngine.Vector2 value);

		public abstract void SetColorParameterForAll(string variable, global::UnityEngine.Color value);

		public virtual void Initialise()
		{
		}

		public void SetPosition(global::UnityEngine.Vector3 position)
		{
		}

		public void SetSize(global::UnityEngine.Vector3 size)
		{
		}

		public void DelayDeactivate(float duration, global::System.Action onComplete = null)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Effects.EffectHandler._003CDoDelayDeactivate_003Ed__24))]
		private global::System.Collections.IEnumerator DoDelayDeactivate(float duration, global::System.Action onComplete = null)
		{
			return null;
		}

		protected string AddPrefixToVariableName(string variable)
		{
			return null;
		}
	}
}
