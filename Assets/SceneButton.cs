using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneButton : MonoBehaviour
{
    
    public void Load(int level)
    {
        SceneManager.LoadScene(level);
    }
}