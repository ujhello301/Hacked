using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FProfile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void onMouseDown()
    {
        SceneManager.LoadScene("Facebook");
    }
    public void onMouseDown1()
    {
        SceneManager.LoadScene("FMessage");
    }
}