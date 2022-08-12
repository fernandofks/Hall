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
            float fx = foot.position.x;
            float fy = foot.position.y;
            float fz = foot.position.z;
            float frx= foot.rotation.x;
            float fry= foot.rotation.y;
            float frz= foot.rotation.z;
            float frw = foot.rotation.w;
            float rfx = rfoot.position.x;
            float rfy = rfoot.position.y;
            float rfz = rfoot.position.z;
            float rfrx= rfoot.rotation.x;
            float rfry= rfoot.rotation.y;
            float rfrz= rfoot.rotation.z;
            float rfrw= rfoot.rotation.w;
            
            string envio = System.String.Format("[{0},{1},{2},{3},{4},{5},{6},{7}]", frx, fry, frz,frw, rfrx, rfry, rfrz, rfrw);  
            
            //uri += "[0.08,%200.14,%200.09,%200.18]";

            uri += envio;

            yield return new WaitForSeconds(0.05f);

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
                        
                        float pos = float.Parse(coordinates["prediction"]);
                        print(pos);


                        //Mudando posição
                        transform.position += Vector3.forward * 0.2f * pos;


                //         break;
                // }
                
            }
        }
    }
}