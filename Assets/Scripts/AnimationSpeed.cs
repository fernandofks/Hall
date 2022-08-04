using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationSpeed : MonoBehaviour
{   
    public Text placa;
    private int waitTime=30;
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
            placa.text="Se prepare";
     placa.color= Color.blue;
          yield return new WaitForSeconds(60);

    //parado
     anim.SetFloat("speedMultiplier", stop_speed);
     placa.text="parado";
     placa.color= Color.red;
    //devagar
     yield return new WaitForSeconds(waitTime);
     anim.SetFloat("speedMultiplier", slow_speed);
     placa.text="devagar";
     placa.color= Color.yellow;
    //rapido
     yield return new WaitForSeconds(waitTime);
     anim.SetFloat("speedMultiplier", fast_speed);
     placa.text="rapido";
     placa.color=Color.green;
    //devagar
     yield return new WaitForSeconds(waitTime);
     anim.SetFloat("speedMultiplier", slow_speed);
     placa.text="devagar";
     placa.color= Color.yellow;
    //parado
     yield return new WaitForSeconds(waitTime);
     anim.SetFloat("speedMultiplier", stop_speed);
     placa.text="parado";
     placa.color= Color.red;
    //rapido
     yield return new WaitForSeconds(waitTime);
     anim.SetFloat("speedMultiplier", fast_speed);
     placa.text="rapido";
     placa.color=Color.green;
    //parado
     yield return new WaitForSeconds(waitTime);

     anim.SetFloat("speedMultiplier", stop_speed);
     placa.text="parado";
     placa.color= Color.red;
     yield return new WaitForSeconds(waitTime);

    placa.text="ACABOU";
     placa.color= Color.blue;

    }
}
