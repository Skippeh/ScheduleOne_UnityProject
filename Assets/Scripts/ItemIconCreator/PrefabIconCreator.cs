namespace ItemIconCreator
{
	[global::UnityEngine.ExecuteInEditMode]
	public class PrefabIconCreator : global::ItemIconCreator.IconCreator
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CBuildAllIcons_003Ed__7 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::ItemIconCreator.PrefabIconCreator _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CBuildAllIcons_003Ed__7(int _003C_003E1__state)
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

		[global::UnityEngine.Header("Items")]
		public global::UnityEngine.GameObject[] itemsToShot;

		public global::UnityEngine.Transform itemPosition;

		private global::UnityEngine.GameObject instantiatedItem;

		public override void BuildIcons()
		{
		}

		public override bool CheckConditions()
		{
			return false;
		}

		protected override void Update()
		{
		}

		private void ClearShit()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ItemIconCreator.PrefabIconCreator._003CBuildAllIcons_003Ed__7))]
		public global::System.Collections.IEnumerator BuildAllIcons()
		{
			return null;
		}
	}
}
