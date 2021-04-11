using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step : MonoBehaviour
{
    #region Variables
    [TextArea(1,10)]
    public string contentText;
    public string locationText;
    public Step[] nextSteps;

    #endregion
}
