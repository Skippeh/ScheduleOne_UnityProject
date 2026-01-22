namespace ScheduleOne.AvatarFramework.Customization
{
	[global::System.Serializable]
	[global::UnityEngine.CreateAssetMenu(fileName = "BasicAvatarSettings", menuName = "ScriptableObjects/BasicAvatarSettings", order = 1)]
	public class BasicAvatarSettings : global::UnityEngine.ScriptableObject
	{
		public const float GenderScaleMultiplier = 0.7f;

		public const string MaleUnderwearPath = "Avatar/Layers/Bottom/MaleUnderwear";

		public const string FemaleUnderwearPath = "Avatar/Layers/Bottom/FemaleUnderwear";

		public int Gender;

		public float Weight;

		public global::UnityEngine.Color SkinColor;

		public string HairStyle;

		public global::UnityEngine.Color HairColor;

		public string Mouth;

		public string FacialHair;

		public string FacialDetails;

		public float FacialDetailsIntensity;

		public global::UnityEngine.Color EyeballColor;

		public float UpperEyeLidRestingPosition;

		public float LowerEyeLidRestingPosition;

		public float PupilDilation;

		public float EyebrowScale;

		public float EyebrowThickness;

		public float EyebrowRestingHeight;

		public float EyebrowRestingAngle;

		public string Top;

		public global::UnityEngine.Color TopColor;

		public string Bottom;

		public global::UnityEngine.Color BottomColor;

		public string Shoes;

		public global::UnityEngine.Color ShoesColor;

		public string Headwear;

		public global::UnityEngine.Color HeadwearColor;

		public string Eyewear;

		public global::UnityEngine.Color EyewearColor;

		public global::System.Collections.Generic.List<string> Tattoos;

		public T SetValue<T>(string fieldName, T value)
		{
			return default(T);
		}

		public T GetValue<T>(string fieldName)
		{
			return default(T);
		}

		public global::ScheduleOne.AvatarFramework.AvatarSettings GetAvatarSettings()
		{
			return null;
		}

		public static global::UnityEngine.Color GetNippleColor(global::UnityEngine.Color skinColor)
		{
			return default(global::UnityEngine.Color);
		}

		public virtual string GetJson(bool prettyPrint = true)
		{
			return null;
		}
	}
}
