using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IMessage2 : MonoBehaviour
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
        SceneManager.LoadScene("IMessage1");
    }
    public void onMouseDown1()
    {
        SceneManager.LoadScene("NextLevel");
    }
    public void onMouseDown2()
    {
        SceneManager.LoadScene("IProfile");
    }
}
