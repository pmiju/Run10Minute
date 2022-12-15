using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator2 : MonoBehaviour
{
    public GameObject CherryPrefab;
    float span = 5.0f;
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
            GameObject go = Instantiate(CherryPrefab);
            int px = Random.Range(5, 10);
            int py = Random.Range(-2, 3);
            go.transform.position = new Vector3(px, py, 0);
        }
    }
}
