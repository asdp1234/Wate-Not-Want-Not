using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    [SerializeField]
    Button q, p;
    
    // Start is called before the first frame update
    void Start()
    {
        q.onClick.AddListener(Quit);
        p.onClick.AddListener(Play);
    }

    void Quit()
    {
        Application.Quit();
    }
    void Play()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
