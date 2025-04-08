namespace ScheduleOne.AvatarFramework.Customization
{
	public class CharacterCreator : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.AvatarFramework.Customization.CharacterCreator>
	{
		public enum ECategory
		{
			Body = 0,
			Hair = 1,
			Face = 2,
			Eyes = 3,
			Eyebrows = 4,
			Clothing = 5,
			Accessories = 6
		}

		public global::System.Collections.Generic.List<global::ScheduleOne.UI.CharacterCreator.BaseCharacterCreatorField> Fields;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.Transform Container;

		public global::UnityEngine.Transform CameraPosition;

		public global::UnityEngine.Transform RigContainer;

		public global::ScheduleOne.AvatarFramework.Avatar Rig;

		public global::UnityEngine.Canvas Canvas;

		public global::UnityEngine.Animation CanvasAnimation;

		[global::UnityEngine.Header("Settings")]
		public bool DemoCreator;

		public global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings DefaultSettings;

		public global::System.Collections.Generic.List<global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings> Presets;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings> onComplete;

		public global::UnityEngine.Events.UnityEvent<global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings, global::System.Collections.Generic.List<global::ScheduleOne.Clothing.ClothingInstance>> onCompleteWithClothing;

		private global::System.Collections.Generic.Dictionary<string, global::ScheduleOne.Clothing.ClothingDefinition> lastSelectedClothingDefinitions;

		private float rigTargetY;

		public bool IsOpen { get; protected set; }

		public global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings ActiveSettings { get; protected set; }

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		public void Open(global::ScheduleOne.AvatarFramework.Customization.BasicAvatarSettings initialSettings, bool showUI = true)
		{
		}

		public void ShowUI()
		{
		}

		public void Close()
		{
		}

		public void DisableStuff()
		{
		}

		public void Done()
		{
		}

		public void SliderChanged(float newVal)
		{
		}

		public T SetValue<T>(string fieldName, T value, global::ScheduleOne.Clothing.ClothingDefinition definition)
		{
			return default(T);
		}

		public void SelectPreset(string presetName)
		{
		}

		public void RefreshCategory(global::ScheduleOne.AvatarFramework.Customization.CharacterCreator.ECategory category)
		{
		}
	}
}
