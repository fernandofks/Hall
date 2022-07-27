using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using SimpleJSON;



// UnityWebRequest.Get example

// Access a website and use UnityWebRequest.Get to download a page.
// Also try to download a non-existing page. Display the error.

public class MyBehaviour : MonoBehaviour
{

    public Transform foot;
    public Transform rfoot;
 
    void Start()
    {
        // My example.
        StartCoroutine(GetRequest());
    }

    IEnumerator GetRequest()
    {
        
        while(true)
        {

            string uri = "http://127.0.0.1:8000/";

            float fy = foot.position.y;
            float fz = foot.position.z;
            float rfy = rfoot.position.y;
            float rfz = rfoot.position.z;
            
            string envio = System.String.Format("[{0},{1},{2},{3}]", fy,fz,rfy,rfz);  
            
            //uri += "[0.08,%200.14,%200.09,%200.18]";

            uri += envio;

            yield return new WaitForSeconds(0.5f);

            using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))    
            {

                // Request and wait for the desired page.
                yield return webRequest.SendWebRequest();

                string[] pages = uri.Split('/');
                int page = pages.Length - 1;

                // switch (webRequest.result)
                // {
                //     case UnityWebRequest.Result.ConnectionError:
                //     case UnityWebRequest.Result.DataProcessingError:
                //         Debug.LogError(pages[page] + ": Error: " + webRequest.error);
                //         break;
                //     case UnityWebRequest.Result.ProtocolError:
                //         Debug.LogError(pages[page] + ": HTTP Error: " + webRequest.error);
                //         break;
                //     case UnityWebRequest.Result.Success:
                //         // Debug.Log(pages[page] + ":\nReceived: " + webRequest.downloadHandler.text);

                        JSONNode coordinates = JSON.Parse(webRequest.downloadHandler.text);
                        print(coordinates["prediction"]);
                        
                        float pos = float.Parse(coordinates["prediction"]);



                        //Mudando posição
                        transform.position += Vector3.forward * 1.0f * pos;


                //         break;
                // }
                
            }
        }
    }
}