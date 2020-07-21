using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM3 : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("第四題");  // 載入場景Q4
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("第二題");  // 載入場景Q2
        }
    }
}
