using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float jumpForce = 680.0f;
    int jumpCount = 0;
    bool isGrounded = false; //바닥에 닿았는지 나타내는거
    public AudioClip audioDie;
    public AudioClip audioItem;

    Rigidbody2D rigid2D; 
    Animator animator; 
    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        this.animator = GetComponent<Animator>();
        this.audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && jumpCount<2)
        {
            jumpCount++;
            //점프 직전에 속도를 순간적으로 제로로 변경
            this.rigid2D.velocity = Vector2.zero;
            //위쪽으로 힘 주기
            this.rigid2D.AddForce(new Vector2(0, jumpForce));
        }
        else if(Input.GetMouseButtonUp(0) && this.rigid2D.velocity.y>0)
        {
            //현재 속도를 절반으로 
            this.rigid2D.velocity = this.rigid2D.velocity * 1.0f;
        }

        //애니메이터의 Grounded파라미터를 isGrounded값으로 갱신
        this.animator.SetBool("Grounded", isGrounded);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.contacts[0].normal.y>0.7f)
        {
            isGrounded = true;
            jumpCount = 0;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        //어떤 클라이더에서 뗴어진 경우 isGrounded를 false로 변경
        isGrounded = false;
    }

    //충돌판정
    void OnTriggerEnter2D(Collider2D other)
    {
        //장애물
        if(other.gameObject.tag == "obs")
        {
            this.audioSource.PlayOneShot(this.audioDie);
            Destroy(other.gameObject);
            // this.audioSource.PlayOneShot(this.audioDie);
             GameObject director = GameObject.Find("GameDirector");
            
            director.GetComponent<GameDirector>().DecreaseHp();
        }
        //아이템
        if(other.gameObject.tag == "Item1")
        {
            this.audioSource.PlayOneShot(this.audioItem);
             Destroy(other.gameObject);
             GameObject director = GameObject.Find("GameDirector");
            
            director.GetComponent<GameDirector>().GetItem1();

            //  this.audioSource.PlayOneShot(this.audioItem);
        }
        if(other.gameObject.tag == "Item2")
        {
            this.audioSource.PlayOneShot(this.audioItem);
             Destroy(other.gameObject);
             GameObject director = GameObject.Find("GameDirector");
            
            director.GetComponent<GameDirector>().GetItem2();
            //  this.audioSource.PlayOneShot(this.audioItem);
        }
        
    }


    // //충돌판정(아이템)
    // void OnTriggerEnter2D(Collider2D coll)
    // {
    //     if(coll.gameObject.tag == "Item")
    //     {
    //          Destroy(coll.gameObject);
    //          this.audioSource.PlayOneShot(this.audioItem);
    //     }
    // }
}

