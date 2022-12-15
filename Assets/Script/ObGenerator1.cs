using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObGenerator1 : MonoBehaviour
{
    public GameObject rockPrefab;
    float span = 1.5f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if(this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(rockPrefab);
            int px = Random.Range(5, 11);
            go.transform.position = new Vector3(px,-3, 0);
        }
    }
}
