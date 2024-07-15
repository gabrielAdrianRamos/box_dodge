using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SkinChecker : MonoBehaviour
{

    public Toggle[] skinToggles;
    private int selectedSkinIndex;
    // Start is called before the first frame update
    void Start()
    {
        //Load selected skin index from PlayerPrefs or default to 0
        selectedSkinIndex = PlayerPrefs.GetInt("SelectedSkinIndex", 0);

        foreach (Toggle toggle in skinToggles)
        {
            toggle.isOn = false;
            toggle.onValueChanged.AddListener(delegate {ToggleValueChanged(toggle);});
        }

        if (selectedSkinIndex >= 0 && selectedSkinIndex < skinToggles.Length)
        {
            if (skinToggles[selectedSkinIndex] != null)
            {
                skinToggles[selectedSkinIndex].isOn = true;
            }
        }
    }

public void ToggleValueChanged(Toggle changeToggle)
{
    if (changeToggle.isOn)
    {
        int index = System.Array.IndexOf(skinToggles, changeToggle);
        if (index != -1)
        {
            selectedSkinIndex = index;
            PlayerPrefs.SetInt("SelectedSkinIndex", selectedSkinIndex);
        }
    }
}
}
