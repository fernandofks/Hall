using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimationSpeed_45 : MonoBehaviour
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
        //parado90
        placa.text="parado_dois";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado180
        placa.text="parado_tres";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado270
        placa.text="parado_quatro";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);

        //devagar
        anim.SetFloat("speedMultiplier", slow_speed);
        
        //devagar0
        placa.text="devagar_um";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar90
        placa.text="devagar_dois";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar180
        placa.text="devagar_tres";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar270
        placa.text="devagar_quatro";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //rapido
        anim.SetFloat("speedMultiplier", fast_speed);

        //rapido0
        placa.text="rapido_um";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido90
        placa.text="rapido_dois";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido180
        placa.text="rapido_tres";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido270
        placa.text="rapido_quatro";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //devagar
        anim.SetFloat("speedMultiplier", slow_speed);
        //devagar0
        placa.text="devagar_um";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar90
        placa.text="devagar_dois";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar180
        placa.text="devagar_tres";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        //devagar270
        placa.text="devagar_quatro";
        placa.color= Color.yellow;
        yield return new WaitForSeconds(waitTime);

        
        //parado
        anim.SetFloat("speedMultiplier", stop_speed);

        //parado0
        placa.text="parado_um";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado90
        placa.text="parado_dois";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado180
        placa.text="parado_tres";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado270
        placa.text="parado_quatro";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
       
        //rapido
        anim.SetFloat("speedMultiplier", fast_speed);

        //rapido0
        placa.text="rapido_um";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido90
        placa.text="rapido_dois";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido180
        placa.text="rapido_tres";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //rapido270
        placa.text="rapido_quatro";
        placa.color=Color.green;
        yield return new WaitForSeconds(waitTime);

        //parado
        anim.SetFloat("speedMultiplier", stop_speed);

        //parado0
        placa.text="parado_um";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado90
        placa.text="parado_dois";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado180
        placa.text="parado_tres";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        //parado270
        placa.text="parado_quatro";
        placa.color= Color.red;
        yield return new WaitForSeconds(waitTime);
        
        placa.text="ACABOU";
        placa.color= Color.blue;

    }
}
