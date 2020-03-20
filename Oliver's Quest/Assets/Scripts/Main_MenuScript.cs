using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_MenuScript : MonoBehaviour
{
    [SerializeField] private Button startButton = null;
    [SerializeField] private Button chaptersButton = null;

    void Awake()
    {
        startButton.GetComponentInChildren<Text>().text = "Start";
        chaptersButton.GetComponentInChildren<Text>().text = "Chapters";
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
