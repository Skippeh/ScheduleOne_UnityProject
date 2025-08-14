namespace ScheduleOne.Interaction
{
	public class InteractionManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Interaction.InteractionManager>
	{
		public const float RayRadius = 0.075f;

		public const float MaxInteractionRange = 5f;

		[global::UnityEngine.SerializeField]
		protected global::UnityEngine.LayerMask interaction_SearchMask;

		[global::UnityEngine.SerializeField]
		protected float rightClickRange;

		public global::ScheduleOne.Interaction.EInteractionSearchType interactionSearchType;

		public bool DEBUG;

		[global::UnityEngine.Header("Settings")]
		public global::UnityEngine.InputSystem.InputActionReference InteractInput;

		[global::UnityEngine.Header("Visuals Settings")]
		public global::UnityEngine.Color messageColor_Default;

		public global::UnityEngine.Color iconColor_Default;

		public global::UnityEngine.Color iconColor_Default_Key;

		public global::UnityEngine.Color messageColor_Invalid;

		public global::UnityEngine.Color iconColor_Invalid;

		public global::UnityEngine.Sprite icon_Key;

		public global::UnityEngine.Sprite icon_LeftMouse;

		public global::UnityEngine.Sprite icon_Cross;

		public static float interactCooldown;

		private float timeSinceLastInteractStart;

		private global::ScheduleOne.EntityFramework.BuildableItem itemBeingDestroyed;

		private float destroyTime;

		private static float timeToDestroy;

		public global::UnityEngine.LayerMask Interaction_SearchMask => default(global::UnityEngine.LayerMask);

		public bool CanDestroy { get; set; }

		public global::ScheduleOne.Interaction.InteractableObject HoveredInteractableObject { get; protected set; }

		public global::ScheduleOne.Interaction.InteractableObject HoveredValidInteractableObject { get; protected set; }

		public global::ScheduleOne.Interaction.InteractableObject InteractedObject { get; protected set; }

		public string InteractKeyStr { get; protected set; }

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

		public void SetCanDestroy(bool canDestroy)
		{
		}
	}
}
