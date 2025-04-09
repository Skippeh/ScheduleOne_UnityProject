using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ItemIconCreator
{
	[ExecuteInEditMode]
	public class MaterialIconCreator : IconCreator
	{
		[CompilerGenerated]
		private sealed class _003CBuildIconsRotine_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public MaterialIconCreator _003C_003E4__this;

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
			public _003CBuildIconsRotine_003Ed__4(int _003C_003E1__state)
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

		public Renderer targetRenderer;

		public Material[] materials;

		public override void BuildIcons()
		{
		}

		public override bool CheckConditions()
		{
			return false;
		}

		[IteratorStateMachine(typeof(_003CBuildIconsRotine_003Ed__4))]
		private IEnumerator BuildIconsRotine()
		{
			return null;
		}

		private void Reset()
		{
		}

		protected override void Update()
		{
		}
	}
}
