using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotateFloor : MonoBehaviour
{   
    public Text placa;
    private int waitTime=60;
    private float stop_speed=0;
    private float slow_speed=0.02f;
    private float fast_speed=0.04f;
    public GameObject target;
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        StartCoroutine(ChangeSpeed());
    }

    // Update is called once per frame
    void Update()
    {
        // Spin the object around the target at 20 degrees/second.
        transform.RotateAround(target.transform.position, Vector3.up, 20 * Time.deltaTime);
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
