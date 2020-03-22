using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TeaGameManager : MonoBehaviour
{
    [SerializeField] private Slider completionSlider = null;
    [SerializeField] private TeaBagScript teaScript = null;
    [SerializeField] private GameObject nextButton = null;
    [SerializeField] private GameObject congratsText = null;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkCompletion();
    }

    private void checkCompletion()
    {
        if (teaScript.GetLocked() && completionSlider.value < 100)
        {
            completionSlider.value += 0.5f;
        }
        else if(completionSlider.value == 100)
        {
            nextButton.SetActive(true);
            congratsText.SetActive(true);
        }
    }
}
