using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] private Button startButton = null;
    [SerializeField] private Button chaptersButton = null;
    [SerializeField] private Button aboutButton = null;

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadStart(string chapter)
    {
        SceneManager.LoadScene(chapter);
    }
}
