using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotion : MonoBehaviour
{

    public Rigidbody2D Rb2d;

    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            MoveR();
        }

            else  if(Input.GetKey(KeyCode.A))
        {
            MoveL();
        }

        else
        {
            Rb2d.velocity = new Vector2(0, Rb2d.velocity.y);
        }
    }

      
      
      
      
        void MoveR()
    {
        //Move Right With Speed = "Speed"
        Rb2d.velocity = new Vector2(Speed, Rb2d.velocity.y);
    }

            void MoveL()
    {
        //Move Left With Speed = "Speed"
        Rb2d.velocity = new Vector2(-Speed, Rb2d.velocity.y);
    }
}
