using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM5 : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("0");  // 載入場景0
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("第四題");  // 載入場景Q4
        }        
       
    }
}
