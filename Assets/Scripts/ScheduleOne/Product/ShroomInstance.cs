namespace ScheduleOne.Product
{
	[global::System.Serializable]
	public class ShroomInstance : global::ScheduleOne.Product.ProductItemInstance
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CDoPsychedlicEffectBlend_003Ed__15 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float targetValuePercentage;

			public float duration;

			public global::ScheduleOne.FX.PsychedelicFullScreenFeature.MaterialProperties targetMaterialProperties;

			private float _003Celapsed_003E5__2;

			private global::ScheduleOne.FX.PsychedelicFullScreenFeature.MaterialProperties _003CactiveProperties_003E5__3;

			private global::ScheduleOne.FX.PsychedelicFullScreenFeature.MaterialProperties _003CsourceProperties_003E5__4;

			private float _003CstartValue_003E5__5;

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
			public _003CDoPsychedlicEffectBlend_003Ed__15(int _003C_003E1__state)
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

		private static global::UnityEngine.Coroutine _psychedelicEffectCoroutine;

		public override string Name => null;

		private global::ScheduleOne.Product.ShroomDefinition _shroomDefinition => null;

		public ShroomInstance()
		{
		}

		public ShroomInstance(global::ScheduleOne.ItemFramework.ItemDefinition definition, int quantity, global::ScheduleOne.ItemFramework.EQuality quality, global::ScheduleOne.Product.Packaging.PackagingDefinition packaging = null)
		{
		}

		public override global::ScheduleOne.ItemFramework.ItemInstance GetCopy(int overrideQuantity = -1)
		{
			return null;
		}

		public override global::ScheduleOne.Persistence.Datas.ItemData GetItemData()
		{
			return null;
		}

		public override void ApplyEffectsToNPC(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public override void ClearEffectsFromNPC(global::ScheduleOne.NPCs.NPC npc)
		{
		}

		public override void ApplyEffectsToPlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		public override void ClearEffectsFromPlayer(global::ScheduleOne.PlayerScripts.Player player)
		{
		}

		private void ApplyEffectsToAvatar(global::ScheduleOne.AvatarFramework.Avatar avatar)
		{
		}

		private void ClearEffectsFromAvatar(global::ScheduleOne.AvatarFramework.Avatar avatar)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Product.ShroomInstance._003CDoPsychedlicEffectBlend_003Ed__15))]
		private global::System.Collections.IEnumerator DoPsychedlicEffectBlend(global::ScheduleOne.FX.PsychedelicFullScreenFeature.MaterialProperties targetMaterialProperties, float targetValuePercentage, float duration)
		{
			return null;
		}
	}
}
