using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateFloor_5 : MonoBehaviour
{   
    public Text placa;
    private int waitTime=360;
    private float stop_speed=0;
    private float slow_speed=0.02f;
    private float fast_speed=0.04f;
    Animator anim;
    //DON'T HAVE THE GAME OBJECT MOVE RIGHT AWAY, WAIT 60 SECONDS
    private bool isWait = true;
    private bool first_time = true;

    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(StartDelay());
        StartCoroutine(ChangeSpeed());
    }

    // Update is called once per frame

     private void Update()
     {
         //AFTER 5 SECONDS THE GAME OBJECT STARTS MOVING
         if (!isWait)
         {
             Move();
         }
     }
 
     private void Move()
     {
            transform.Rotate(0,5,0);
            StartCoroutine(StartDelay()); // restarts the coroutine
     }
 
     //after 10 seconds, the object moves
     IEnumerator StartDelay()
     {
        if(first_time==true){
             yield return new WaitForSeconds(60);
             first_time=false;
         }
         isWait = true;//object now waits to move
         yield return new WaitForSeconds(5);
         isWait = false; //object is no longer waiting to move
     }
 

    IEnumerator ChangeSpeed()
    {   
        //preparo
        placa.text="Se prepare";
        placa.color= Color.blue;
        yield return new WaitForSeconds(60);
        //parado
        anim.SetFloat("speedMultiplier", stop_speed);

        //parado0
        placa.text="parado";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
       
        //devagar
        anim.SetFloat("speedMultiplier", slow_speed);
        
        //devagar0
        placa.text="devagar";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        
        //rapido
        anim.SetFloat("speedMultiplier", fast_speed);

        //rapido0
        placa.text="rapido";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

       

        //devagar
        anim.SetFloat("speedMultiplier", slow_speed);
        //devagar0
        placa.text="devagar";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

       
        //parado
        anim.SetFloat("speedMultiplier", stop_speed);

        //parado0
        placa.text="parado";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        
        //rapido
        anim.SetFloat("speedMultiplier", fast_speed);

        //rapido0
        placa.text="rapido";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);


        //parado
        anim.SetFloat("speedMultiplier", stop_speed);

        //parado0
        placa.text="parad";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);

        placa.text="ACABOU";
        placa.color= Color.blue;

    }
}