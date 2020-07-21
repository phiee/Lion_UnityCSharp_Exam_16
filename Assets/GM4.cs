using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM4 : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("第五題");  // 載入場景Q5
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("第三題");  // 載入場景Q3
        }
    }
}
