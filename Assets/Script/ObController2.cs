using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(-0.03f, 0, 0);

        if (transform.position.x < -10.0f)
        {
            
            Destroy(gameObject);
        }
        
    }
}
