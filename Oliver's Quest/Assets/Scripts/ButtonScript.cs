using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Image theButton = null;
    public GameObject nextSlide = null;

    // Start is called before the first frame update
    void Start()
    {
        theButton.alphaHitTestMinimumThreshold = 0.0001f;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NextScene()
    {
        gameObject.SetActive(false);
        nextSlide.SetActive(true);
    }
}
