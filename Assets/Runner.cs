using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Runner : MonoBehaviour
{
    public float MoveSpeed;
    float i = 0;
    [Header("結束畫面")]
    public CanvasGroup final;

    void Start()
    {
        
    }

    void Update()
    {
        if (i > -10f)
        {
            GameObject.Find("MaleFree1").transform.position += new Vector3(0, 0, -0.05f);
        }
      
        if (i < -10f)
            {
                MoveSpeed = 0;
                final.alpha = 1;           //顯示結束畫面 啟動互動 啟動遮擋
                final.interactable = true;
                final.blocksRaycasts = true;
            }
        
}
    
}