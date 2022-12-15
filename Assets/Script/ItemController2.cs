using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController2 : MonoBehaviour
{
    //ĳ���� �̸��� �°� ���Ķ� ���־�;;
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        this.Player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //�������� �̵�
        transform.Translate(-0.02f, 0, 0);

        //ȭ�� ������ ������ ������!
        if (transform.position.x < -10.0f)
        {
            Destroy(gameObject);
        }

        //�浹 ����
        // Vector2 p1 = transform.position;
        // Vector2 p2 = this.Player.transform.position;
        // Vector2 dir = p1 - p2;
        // float d = dir.magnitude;
        // float r1 = 0.5f;
        // float r2 = 1.0f;

        // if (d < r1 + r2)
        // {
        //     GameObject director = GameObject.Find("GameDirector");
        //     // director.GetComponent<GameDirector>().IncreaseScore2();
        //      director.GetComponent<GameDirector>().GetItem2();
    
        //     //Destroy(gameObject);
        // }
    }
}
