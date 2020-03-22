using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CakeGameManager : MonoBehaviour
{
    [SerializeField] private Transform cutLocationOne = null;
    [SerializeField] private Transform cutLocationTwo = null;
    [SerializeField] private Transform cutLocationThree = null;
    [SerializeField] private Transform cutLocationFour = null;
    [SerializeField] private Transform cutLocationFive = null;
    [SerializeField] private Transform cutLocationSix = null;
    [SerializeField] private GameObject continueButton = null;
    [SerializeField] private GameObject congratsText = null;
    [SerializeField] private GameObject cutCakeImage = null;
    [SerializeField] private GameObject uncutCakeImage = null;

    private bool cutLocationOneBool = false;
    private bool cutLocationTwoBool = false;
    private bool cutLocationThreeBool = false;
    private bool cutLocationFourBool = false;
    private bool cutLocationFiveBool = false;
    private bool cutLocationSixBool = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfCutLocation();
        CheckIfFinished();
    }

    private void CheckIfCutLocation()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (cutLocationOne.GetComponent<Collider2D>() == Physics2D.OverlapPoint(pos))
            {
                cutLocationOneBool = true;
                Debug.Log("CutOne)");
            }
            else if (cutLocationTwo.GetComponent<Collider2D>() == Physics2D.OverlapPoint(pos))
            {
                cutLocationTwoBool = true;
                Debug.Log("CutTwo)");
            }
            else if (cutLocationThree.GetComponent<Collider2D>() == Physics2D.OverlapPoint(pos))
            {
                cutLocationThreeBool = true;
                Debug.Log("CutThree)");
            }
            else if (cutLocationFour.GetComponent<Collider2D>() == Physics2D.OverlapPoint(pos))
            {
                cutLocationFourBool = true;
                Debug.Log("CutFour)");
            }
            else if (cutLocationFive.GetComponent<Collider2D>() == Physics2D.OverlapPoint(pos))
            {
                cutLocationFiveBool = true;
                Debug.Log("CutFive)");
            }
            else if (cutLocationSix.GetComponent<Collider2D>() == Physics2D.OverlapPoint(pos))
            {
                cutLocationSixBool = true;
                Debug.Log("CutSix)");
            }
        }
    }

    private void CheckIfFinished()
    {
        if (cutLocationOneBool && cutLocationTwoBool && cutLocationThreeBool && cutLocationFourBool && cutLocationFiveBool && cutLocationSixBool)
        {
            continueButton.SetActive(true);
            congratsText.SetActive(true);
            cutCakeImage.SetActive(true);
            uncutCakeImage.SetActive(false);
        }
    }
}
