using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleGameManager : MonoBehaviour
{
    [SerializeField] private PuzzlePieceOneScript scriptOne = null;
    [SerializeField] private PuzzlePieceTwoScript scriptTwo = null;
    [SerializeField] private PuzzlePieceThreeScript scriptThree = null;
    [SerializeField] private PuzzlePieceFourScript scriptFour = null;
    [SerializeField] private GameObject continueButton = null;
    [SerializeField] private GameObject congratsText = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkComplete();
    }

    private void checkComplete()
    {
        if(scriptOne.GetLocked() && scriptTwo.GetLocked() && scriptThree.GetLocked() && scriptFour.GetLocked())
        {
            continueButton.SetActive(true);
            congratsText.SetActive(true);
        }
    }
}
