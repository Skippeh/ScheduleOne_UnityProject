namespace ScheduleOne.Interaction
{
	public class InteractionManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Interaction.InteractionManager>
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CILerpDisplayScale_003Ed__68 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float startScale;

			public float endScale;

			public global::ScheduleOne.Interaction.InteractionManager _003C_003E4__this;

			private float _003ClerpTime_003E5__2;

			private float _003Ci_003E5__3;

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
			public _003CILerpDisplayScale_003Ed__68(int _003C_003E1__state)
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

		public const float RayRadius = 0.075f;

		public const float MaxInteractionRange = 5f;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.LayerMask interaction_SearchMask;

		[global::UnityEngine.SerializeField]
		protected float rightClickRange;

		public global::ScheduleOne.Interaction.EInteractionSearchType interactionSearchType;

		public bool DEBUG;

		[global::UnityEngine.Header("Visuals Settings")]
		public global::UnityEngine.Color messageColor_Default;

		public global::UnityEngine.Color iconColor_Default;

		public global::UnityEngine.Color iconColor_Default_Key;

		public global::UnityEngine.Color messageColor_Invalid;

		public global::UnityEngine.Color iconColor_Invalid;

		public global::UnityEngine.Sprite icon_Key;

		public global::UnityEngine.Sprite icon_LeftMouse;

		public global::UnityEngine.Sprite icon_Cross;

		public float displaySizeMultiplier;

		[global::UnityEngine.Header("References")]
		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.Canvas interaction_Canvas;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform interactionDisplay_Container;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Image interactionDisplay_Icon;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text interactionDisplay_IconText;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.UI.Text interactionDisplay_MessageText;

		public global::UnityEngine.RectTransform wsLabelContainer;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.InputSystem.InputActionReference InteractInput;

		[global::UnityEngine.HideInInspector]
		public string InteractKey;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.RectTransform backgroundImage;

		[global::UnityEngine.Header("Prefabs")]
		public global::UnityEngine.GameObject WSLabelPrefab;

		private bool interactionDisplayEnabledThisFrame;

		private global::ScheduleOne.EntityFramework.BuildableItem itemBeingDestroyed;

		private global::ScheduleOne.Storage.Pallet palletBeingDestroyed;

		private global::ScheduleOne.ConstructableScripts.Constructable constructableBeingDestroyed;

		private float destroyTime;

		private float tempDisplayScale;

		public static float interactCooldown;

		private float timeSinceLastInteractStart;

		public global::System.Collections.Generic.List<global::ScheduleOne.Interaction.WorldSpaceLabel> activeWSlabels;

		private static float timeToDestroy;

		private global::UnityEngine.Coroutine ILerpDisplayScale_Coroutine;

		public global::UnityEngine.LayerMask Interaction_SearchMask => default(global::UnityEngine.LayerMask);

		public bool CanDestroy { get; set; }

		public global::ScheduleOne.Interaction.InteractableObject hoveredInteractableObject { get; protected set; }

		public global::ScheduleOne.Interaction.InteractableObject hoveredValidInteractableObject { get; protected set; }

		public global::ScheduleOne.Interaction.InteractableObject interactedObject { get; protected set; }

		protected override void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void LoadInteractKey()
		{
		}

		protected virtual void Update()
		{
		}

		protected virtual void LateUpdate()
		{
		}

		protected virtual void CheckHover()
		{
		}

		protected virtual void CheckInteraction()
		{
		}

		protected virtual void CheckRightClick()
		{
		}

		protected virtual global::ScheduleOne.EntityFramework.BuildableItem GetHoveredBuildableItem()
		{
			return null;
		}

		protected virtual global::ScheduleOne.Storage.Pallet GetHoveredPallet()
		{
			return null;
		}

		protected virtual global::ScheduleOne.ConstructableScripts.Constructable GetHoveredConstructable()
		{
			return null;
		}

		public void SetCanDestroy(bool canDestroy)
		{
		}

		public void EnableInteractionDisplay(global::UnityEngine.Vector3 pos, global::UnityEngine.Sprite icon, string spriteText, string message, global::UnityEngine.Color messageColor, global::UnityEngine.Color iconColor)
		{
		}

		public void LerpDisplayScale(float endScale)
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::ScheduleOne.Interaction.InteractionManager._003CILerpDisplayScale_003Ed__68))]
		protected global::System.Collections.IEnumerator ILerpDisplayScale(float startScale, float endScale)
		{
			return null;
		}
	}
}
