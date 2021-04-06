using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TextQuest : MonoBehaviour
{
    #region Variables
    public Text contentLabel;
    public Step startStep;
    private Step currentStep;
    #endregion
    #region Unity livecycle

    private void Start()
    {
        currentStep = startStep;
        UpdateContentLabel();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Step nextStep = currentStep.nextStep1;
            MoveToNextStep(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            MoveToNextStep(1);
        }
    }

    #endregion
    #region Public methods

    

    #endregion
    #region Private methods

    private void UpdateContentLabel()
    {
        contentLabel.text = currentStep.contentText;
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
