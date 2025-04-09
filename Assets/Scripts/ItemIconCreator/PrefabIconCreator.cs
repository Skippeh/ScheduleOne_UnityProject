using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ItemIconCreator
{
	[ExecuteInEditMode]
	public class PrefabIconCreator : IconCreator
	{
		[CompilerGenerated]
		private sealed class _003CBuildAllIcons_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public PrefabIconCreator _003C_003E4__this;

			private int _003Ci_003E5__2;

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
			public _003CBuildAllIcons_003Ed__7(int _003C_003E1__state)
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

		[Header("Items")]
		public GameObject[] itemsToShot;

		public Transform itemPosition;

		private GameObject instantiatedItem;

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

		[IteratorStateMachine(typeof(_003CBuildAllIcons_003Ed__7))]
		public IEnumerator BuildAllIcons()
		{
			return null;
		}
	}
}
