using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearDirector : MonoBehaviour
{
    GameObject Canvas;
    // Start is called before the first frame update
    void Start()
    {
        this.Canvas = GameObject.Find("Canvas");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            Destroy(Canvas);
            SceneManager.LoadScene("GameScene");
        }
        
    }
}
