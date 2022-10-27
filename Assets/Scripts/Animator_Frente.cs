using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Animator_Frente : MonoBehaviour
{   
    public Text placa;
    private int start_time = 60;
    private int waitTime=120;
    private float stop_speed=0;
    private float slow_speed=0.02f;
    private float fast_speed=0.04f;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(ChangeSpeed());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ChangeSpeed()
    {   
        //preparo
        placa.text="Se prepare";
        placa.color= Color.blue;
        yield return new WaitForSeconds(start_time);

        //parado
        anim.SetFloat("speedMultiplier", stop_speed);
        placa.text="parado";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
 
        //devagar
        anim.SetFloat("speedMultiplier", slow_speed);
        placa.text="devagar";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);
 
        //rapido
        anim.SetFloat("speedMultiplier", fast_speed);
        placa.text="rapido";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);


        //devagar
        anim.SetFloat("speedMultiplier", slow_speed);
        placa.text="devagar";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //parado
        anim.SetFloat("speedMultiplier", stop_speed);
        placa.text="parado";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
      
        
        //rapido
        anim.SetFloat("speedMultiplier", fast_speed);
        placa.text="rapido";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

     

        //parado
        anim.SetFloat("speedMultiplier", stop_speed);
        placa.text="parado";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
     

        placa.text="ACABOU";
        placa.color= Color.blue;

    }
}
