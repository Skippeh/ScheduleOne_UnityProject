using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ScheduleOne.ConstructableScripts;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Storage;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

namespace ScheduleOne.Interaction
{
	public class InteractionManager : Singleton<InteractionManager>
	{
		[CompilerGenerated]
		private sealed class _003CILerpDisplayScale_003Ed__68 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float startScale;

			public float endScale;

			public InteractionManager _003C_003E4__this;

			private float _003ClerpTime_003E5__2;

			private float _003Ci_003E5__3;

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
			public _003CILerpDisplayScale_003Ed__68(int _003C_003E1__state)
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

		public const float RayRadius = 0.075f;

		public const float MaxInteractionRange = 5f;

		[SerializeField]
		protected LayerMask interaction_SearchMask;

		[SerializeField]
		protected float rightClickRange;

		public EInteractionSearchType interactionSearchType;

		public bool DEBUG;

		[Header("Visuals Settings")]
		public Color messageColor_Default;

		public Color iconColor_Default;

		public Color iconColor_Default_Key;

		public Color messageColor_Invalid;

		public Color iconColor_Invalid;

		public Sprite icon_Key;

		public Sprite icon_LeftMouse;

		public Sprite icon_Cross;

		public float displaySizeMultiplier;

		[Header("References")]
		[SerializeField]
		protected Canvas interaction_Canvas;

		[SerializeField]
		protected RectTransform interactionDisplay_Container;

		[SerializeField]
		protected Image interactionDisplay_Icon;

		[SerializeField]
		protected Text interactionDisplay_IconText;

		[SerializeField]
		protected Text interactionDisplay_MessageText;

		public RectTransform wsLabelContainer;

		[SerializeField]
		protected InputActionReference InteractInput;

		[HideInInspector]
		public string InteractKey;

		[SerializeField]
		protected RectTransform backgroundImage;

		[Header("Prefabs")]
		public GameObject WSLabelPrefab;

		private bool interactionDisplayEnabledThisFrame;

		private BuildableItem itemBeingDestroyed;

		private Pallet palletBeingDestroyed;

		private Constructable constructableBeingDestroyed;

		private float destroyTime;

		private float tempDisplayScale;

		public static float interactCooldown;

		private float timeSinceLastInteractStart;

		public List<WorldSpaceLabel> activeWSlabels;

		private static float timeToDestroy;

		private Coroutine ILerpDisplayScale_Coroutine;

		public LayerMask Interaction_SearchMask => default(LayerMask);

		public bool CanDestroy { get; set; }

		public InteractableObject hoveredInteractableObject { get; protected set; }

		public InteractableObject hoveredValidInteractableObject { get; protected set; }

		public InteractableObject interactedObject { get; protected set; }

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

		protected virtual BuildableItem GetHoveredBuildableItem()
		{
			return null;
		}

		protected virtual Pallet GetHoveredPallet()
		{
			return null;
		}

		protected virtual Constructable GetHoveredConstructable()
		{
			return null;
		}

		public void SetCanDestroy(bool canDestroy)
		{
		}

		public void EnableInteractionDisplay(Vector3 pos, Sprite icon, string spriteText, string message, Color messageColor, Color iconColor)
		{
		}

		public void LerpDisplayScale(float endScale)
		{
		}

		[IteratorStateMachine(typeof(_003CILerpDisplayScale_003Ed__68))]
		protected IEnumerator ILerpDisplayScale(float startScale, float endScale)
		{
			return null;
		}
	}
}
