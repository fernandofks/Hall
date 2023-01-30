using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationSpeed_45 : MonoBehaviour
{   
    public Text placa;
    private int waitTime=240;
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
        yield return new WaitForSeconds(60);
        //parado
        anim.SetFloat("speedMultiplier", stop_speed);

        //parado0
        placa.text="parado_um";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);


        //devagar
        anim.SetFloat("speedMultiplier", slow_speed);
        
        //devagar0
        placa.text="fente";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //rapido0
        placa.text="esquerda";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido90
        placa.text="trás";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido180
        placa.text="direita";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        placa.text="ACABOU";
        placa.color= Color.blue;

    }
}
