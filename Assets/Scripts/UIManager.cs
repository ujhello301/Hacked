using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class UIManager : MonoBehaviour
{
    public void LoginButton() {  
        SceneManager.LoadScene("Login");  
    }  
 
 
    public void LevelsButton() {  
        SceneManager.LoadScene("Levels-Normal");  
    }  

    

    public void Register() {  
        SceneManager.LoadScene("Register");  
    }  

    public void Modules() {  
        SceneManager.LoadScene("ScenarioMenu");  
    }  

    public void Awards() {  
        SceneManager.LoadScene("Awards");  
    }  

    public void impersonationButton() {  
        SceneManager.LoadScene("SampleScene");  
    }  
    
    public void settings() {  
        SceneManager.LoadScene("Settings");  
    }  

    public void backToMenu() {  
        SceneManager.LoadScene("Menu-normal");  
    }  

    public void backToLevels() {  
        SceneManager.LoadScene("Levels-Normal");  
    } 

    public void lockedModules() {  
        SceneManager.LoadScene("Locked-Modules");  
    }  
    public void backToLogin() {  
        SceneManager.LoadScene("Login");  
    }  
    
}   
