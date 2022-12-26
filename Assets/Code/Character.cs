using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour{
    
    private float speed = 4f;
    private float forceJump = 4f;
    private float posX;
    private Rigidbody2D rb;
    
    void Start(){ 
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        posX = Input.GetAxis("Horizontal");
        transform.position += (Vector3) new Vector2(posX * speed * Time.deltaTime, 0f); 

        if(Input.GetKeyDown(KeyCode.Space)){
            rb.AddForce(transform.up * forceJump, ForceMode2D.Impulse);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "Limit"){
            Destroy(gameObject);
        }
    }
}
