using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM1 : MonoBehaviour
{
   public int i = 0;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            SceneManager.LoadScene("第二題");  // 載入場景Q2
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            SceneManager.LoadScene("0");  // 載入場景0
        }

        if (i < 10)
        {
            gameObject.transform.Translate(1, 0, 0);
            i++;
        }
        System.Threading.Thread.Sleep(100);
    }

}
