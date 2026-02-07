using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextsc : MonoBehaviour
{
    public static int n = 0;
    public void PlayGame()
    {
        if (n == 0)
        {
            n++;
            SceneManager.LoadSceneAsync(3);
        }
        else if (n == 1)
        {
            n++;
            SceneManager.LoadSceneAsync(4);
        }
        else if (n == 2)
        {
            SceneManager.LoadSceneAsync(5);
        }

    }
}
