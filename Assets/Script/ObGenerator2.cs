using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObGenerator2 : MonoBehaviour
{
    public GameObject ObjectPrefab;
    float span = 2.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(ObjectPrefab);
            int px = Random.Range(5, 11);
            int py = Random.Range(-1, 4);

            go.transform.position = new Vector3(px, py, 0);
        }
    }
}
