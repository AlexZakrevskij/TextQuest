using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextQuest : MonoBehaviour
{
    #region Variables

    public Text contentLabel;
    public Text currentLocation;
    public Step startStep;
    private Step currentStep;
   /*
    *Ну тут с главного экрана не работает
    * 3й вариант, чтобы сразу закончить игру,
    * я пока хз как это сделать :) Но сделаю
    * в ближайшее время :)
    * 2е задание не делал, ребенок все время отнял на выходных,
    * что смог допилить то допилил
    */
    private KeyCode[] userChoise =
    {
        KeyCode.Alpha0, KeyCode.Alpha1, KeyCode.Alpha2,
        KeyCode.Alpha3, KeyCode.Alpha4, KeyCode.Alpha5,
        KeyCode.Alpha6, KeyCode.Alpha7, KeyCode.Alpha8,
        KeyCode.Alpha9
    };
    
    #endregion
    #region Unity livecycle
    private void Start()
    {
        currentStep = startStep;
        UpdateContentLabel();
    }

    private void Update()
    {
        for (int i = 0; i < userChoise.Length; i++)
        {
            if (Input.GetKeyDown(userChoise[i]))
            {
                MoveToNextStep(i-1);
            }
        }
    }
    #endregion
    
    #region Private methods
    private void UpdateContentLabel()
    {
        contentLabel.text = currentStep.contentText;
        currentLocation.text = currentStep.locationText;
    }

    private void MoveToNextStep(int stepIndex)
    {
        if (currentStep.nextSteps.Length > stepIndex)
        {
            currentStep = currentStep.nextSteps[stepIndex];
            UpdateContentLabel();
        }
    }
    #endregion
}
