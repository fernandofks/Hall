using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationSpeed : MonoBehaviour
{   
    public Text placa;
    private int waitTime=20;
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
        placa.text="parado_1";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado45
        placa.text="parado_vire_2";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado90
        placa.text="parado_vire_3";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado135
        placa.text="parado_vire_4";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado180
        placa.text="parado_vire_5";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado225
        placa.text="parado_vire_6";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado270
        placa.text="parado_vire_7";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado315
        placa.text="parado_vire_8";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);

        //devagar
        anim.SetFloat("speedMultiplier", slow_speed);
        
        //devagar0
        placa.text="devagar_vire_1";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar45
        placa.text="devagar_vire_2";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar90
        placa.text="devagar_vire_3";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar135
        placa.text="devagar_vire_4";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar180
        placa.text="devagar_vire_5";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar225
        placa.text="devagar_vire_6";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar270
        placa.text="devagar_vire_7";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar315
        placa.text="devagar_vire_8";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //rapido
        anim.SetFloat("speedMultiplier", fast_speed);

        //rapido0
        placa.text="rapido_1";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido45
        placa.text="rapido_2";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido90
        placa.text="rapido_3";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido135
        placa.text="rapido_4";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido180
        placa.text="rapido_5";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido225
        placa.text="rapido_6";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido270
        placa.text="rapido_7";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido315
        placa.text="rapido_8";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);


        //devagar
        anim.SetFloat("speedMultiplier", slow_speed);
        
        //devagar0
        placa.text="devagar_vire_1";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar45
        placa.text="devagar_vire_2";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar90
        placa.text="devagar_vire_3";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar135
        placa.text="devagar_vire_4";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar180
        placa.text="devagar_vire_5";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar225
        placa.text="devagar_vire_6";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar270
        placa.text="devagar_vire_7";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar315
        placa.text="devagar_vire_8";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //parado
        anim.SetFloat("speedMultiplier", stop_speed);

        //parado0
        placa.text="parado_1";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado45
        placa.text="parado_vire_2";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado90
        placa.text="parado_vire_3";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado135
        placa.text="parado_vire_4";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado180
        placa.text="parado_vire_5";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado225
        placa.text="parado_vire_6";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado270
        placa.text="parado_vire_7";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado315
        placa.text="parado_vire_8";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        
        //rapido
        anim.SetFloat("speedMultiplier", fast_speed);

        //rapido0
        placa.text="rapido_1";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido45
        placa.text="rapido_2";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido90
        placa.text="rapido_3";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido135
        placa.text="rapido_4";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido180
        placa.text="rapido_5";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido225
        placa.text="rapido_6";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido270
        placa.text="rapido_7";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido315
        placa.text="rapido_8";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);


        //parado
        anim.SetFloat("speedMultiplier", stop_speed);

        //parado0
        placa.text="parado_1";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado45
        placa.text="parado_vire_2";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado90
        placa.text="parado_vire_3";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado135
        placa.text="parado_vire_4";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado180
        placa.text="parado_vire_5";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado225
        placa.text="parado_vire_6";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado270
        placa.text="parado_vire_7";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado315
        placa.text="parado_vire_8";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        ;
        placa.text="ACABOU";
        placa.color= Color.blue;

    }
}
