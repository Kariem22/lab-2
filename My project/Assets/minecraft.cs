using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minecraft : MonoBehaviour
{
    public float moveSpeed;
    public float jumpHeight;
    public KeyCode Spacebar;
    public KeyCode L;
    public KeyCode R;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
         
         if(Input.GetKeyDown(Spacebar)){
            GetComponent<Rigidbody2D>().linearVelocity = new Vector2( GetComponent<Rigidbody2D>().linearVelocity.x, jumpHeight );
        }
        if(Input.GetKey(L))
        {
            GetComponent<Rigidbody2D>().linearVelocity = new Vector2(-moveSpeed,  GetComponent<Rigidbody2D>().linearVelocity.y );
            if (GetComponent<SpriteRenderer>() !=null){
                GetComponent<SpriteRenderer>().flipX=true;
            }
        }
        if(Input.GetKey(R))
        {
            GetComponent<Rigidbody2D>().linearVelocity = new Vector2(moveSpeed,  GetComponent<Rigidbody2D>().linearVelocity.y );
            GetComponent<SpriteRenderer>().flipX=false;
        }
}

}
