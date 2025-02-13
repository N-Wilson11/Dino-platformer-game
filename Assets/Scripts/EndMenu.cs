using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{

    public void Quit()
    {
       Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene("Start Screen");
    }


}
