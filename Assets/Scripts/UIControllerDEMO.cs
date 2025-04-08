public class UIControllerDEMO : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.Space(5f)]
	[global::UnityEngine.Header("I do not recommend using it in your projects")]
	[global::UnityEngine.Header("This script was created to demonstrate api")]
	public global::AdvancedPeopleSystem.CharacterCustomization CharacterCustomization;

	[global::UnityEngine.Space(15f)]
	public global::UnityEngine.UI.Text playbutton_text;

	public global::UnityEngine.UI.Text bake_text;

	public global::UnityEngine.UI.Text lod_text;

	public global::UnityEngine.UI.Text panelNameText;

	public global::UnityEngine.UI.Slider fatSlider;

	public global::UnityEngine.UI.Slider musclesSlider;

	public global::UnityEngine.UI.Slider thinSlider;

	public global::UnityEngine.UI.Slider slimnessSlider;

	public global::UnityEngine.UI.Slider breastSlider;

	public global::UnityEngine.UI.Slider heightSlider;

	public global::UnityEngine.UI.Slider legSlider;

	public global::UnityEngine.UI.Slider headSizeSlider;

	public global::UnityEngine.UI.Slider headOffsetSlider;

	public global::UnityEngine.UI.Slider[] faceShapeSliders;

	public global::UnityEngine.RectTransform HairPanel;

	public global::UnityEngine.RectTransform BeardPanel;

	public global::UnityEngine.RectTransform ShirtPanel;

	public global::UnityEngine.RectTransform PantsPanel;

	public global::UnityEngine.RectTransform ShoesPanel;

	public global::UnityEngine.RectTransform HatPanel;

	public global::UnityEngine.RectTransform AccessoryPanel;

	public global::UnityEngine.RectTransform BackpackPanel;

	public global::UnityEngine.RectTransform FaceEditPanel;

	public global::UnityEngine.RectTransform BaseEditPanel;

	public global::UnityEngine.RectTransform SkinColorPanel;

	public global::UnityEngine.RectTransform EyeColorPanel;

	public global::UnityEngine.RectTransform HairColorPanel;

	public global::UnityEngine.RectTransform UnderpantsColorPanel;

	public global::UnityEngine.RectTransform EmotionsPanel;

	public global::UnityEngine.RectTransform SavesPanel;

	public global::UnityEngine.RectTransform SavesPanelList;

	public global::UnityEngine.RectTransform SavesPrefab;

	public global::System.Collections.Generic.List<global::UnityEngine.RectTransform> SavesList;

	public global::UnityEngine.UI.Image SkinColorButtonColor;

	public global::UnityEngine.UI.Image EyeColorButtonColor;

	public global::UnityEngine.UI.Image HairColorButtonColor;

	public global::UnityEngine.UI.Image UnderpantsColorButtonColor;

	public global::UnityEngine.Vector3[] CameraPositionForPanels;

	public global::UnityEngine.Vector3[] CameraEulerForPanels;

	private int currentPanelIndex;

	public global::UnityEngine.Camera Camera;

	public global::UnityEngine.RectTransform femaleUI;

	public global::UnityEngine.RectTransform maleUI;

	private int lodIndex;

	private bool walk_active;

	private bool canvasVisible;

	public void SwitchCharacterSettings(string name)
	{
	}

	public void ShowFaceEdit()
	{
	}

	public void ShowBaseEdit()
	{
	}

	public void SetFaceShape(int index)
	{
	}

	public void SetHeadOffset()
	{
	}

	public void BodyFat()
	{
	}

	public void BodyMuscles()
	{
	}

	public void BodyThin()
	{
	}

	public void BodySlimness()
	{
	}

	public void BodyBreast()
	{
	}

	public void SetHeight()
	{
	}

	public void SetHeadSize()
	{
	}

	public void Lod_Event(int next)
	{
	}

	public void SetNewSkinColor(global::UnityEngine.Color color)
	{
	}

	public void SetNewEyeColor(global::UnityEngine.Color color)
	{
	}

	public void SetNewHairColor(global::UnityEngine.Color color)
	{
	}

	public void SetNewUnderpantsColor(global::UnityEngine.Color color)
	{
	}

	public void VisibleSkinColorPanel(bool v)
	{
	}

	public void VisibleEyeColorPanel(bool v)
	{
	}

	public void VisibleHairColorPanel(bool v)
	{
	}

	public void VisibleUnderpantsColorPanel(bool v)
	{
	}

	public void ShirtPanel_Select(bool v)
	{
	}

	public void PantsPanel_Select(bool v)
	{
	}

	public void ShoesPanel_Select(bool v)
	{
	}

	public void BackpackPanel_Select(bool v)
	{
	}

	public void HairPanel_Select(bool v)
	{
	}

	public void BeardPanel_Select(bool v)
	{
	}

	public void HatPanel_Select(bool v)
	{
	}

	public void EmotionsPanel_Select(bool v)
	{
	}

	public void AccessoryPanel_Select(bool v)
	{
	}

	public void SavesPanel_Select(bool v)
	{
	}

	public void SaveSelect(int index)
	{
	}

	public void EmotionsChange_Event(int index)
	{
	}

	public void HairChange_Event(int index)
	{
	}

	public void BeardChange_Event(int index)
	{
	}

	public void ShirtChange_Event(int index)
	{
	}

	public void PantsChange_Event(int index)
	{
	}

	public void ShoesChange_Event(int index)
	{
	}

	public void BackpackChange_Event(int index)
	{
	}

	public void HatChange_Event(int index)
	{
	}

	public void AccessoryChange_Event(int index)
	{
	}

	public void HideAllPanels()
	{
	}

	public void SaveToFile()
	{
	}

	public void ClearFromFile()
	{
	}

	public void Randimize()
	{
	}

	public void PlayAnim()
	{
	}

	private void Update()
	{
	}
}
