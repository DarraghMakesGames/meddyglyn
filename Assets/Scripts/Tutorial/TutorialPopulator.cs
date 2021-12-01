using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class TutorialPopulator : MonoBehaviour
{

    //public Tutorial tutorial;
    public TMP_Text nameText;
    public TMP_Text tutorialText;
    public Image tutorialImg;

    private void Populate(Tutorial setTutorial)
    {
        nameText.text = "Tutorial: " + setTutorial.tutorialName;
        tutorialText.text = setTutorial.tutorialText;
        tutorialImg.sprite = setTutorial.tutorialImage;
    }

}
