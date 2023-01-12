using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;
using SimpleJSON;



// UnityWebRequest.Get example

// Access a website and use UnityWebRequest.Get to download a page.
// Also try to download a non-existing page. Display the error.

public class One_speed_90 : MonoBehaviour
{
    public Transform foot;
    public Transform rfoot;
    public Transform KATVR;

    void Start()
    {
        // My example.
        StartCoroutine(GetRequest());
    }

    IEnumerator GetRequest()
    {
        
        while(true)
        {   float startTime = 0.0f;
            startTime = Time.time; 
            string uri = "http://127.0.0.1:8000/";
            float fx = foot.transform.localPosition.x;
            float fy = foot.transform.localPosition.y;
            float fz = foot.transform.localPosition.z;
            float rfx = rfoot.transform.localPosition.x;
            float rfy = rfoot.transform.localPosition.y;
            float rfz = rfoot.transform.localPosition.z;


            float frEulerx = foot.rotation.eulerAngles.x;
            float frEulery = foot.rotation.eulerAngles.y;
            float frEulerz = foot.rotation.eulerAngles.z;
            float rfrEulerx = rfoot.rotation.eulerAngles.x;
            float rfrEulery = rfoot.rotation.eulerAngles.y;
            float rfrEulerz = rfoot.rotation.eulerAngles.z;            
            


            string envio = System.String.Format("[{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11}]", fx, fy, fz,frEulerx,frEulery,frEulerz, rfx, rfy, rfz,rfrEulerx,rfrEulery,rfrEulerz);  
            uri += envio;
            
            using (UnityWebRequest webRequest = UnityWebRequest.Get(uri))    
            {
                // Request and wait for the desired page.
                yield return webRequest.SendWebRequest();
                string[] pages = uri.Split('/');
                int page = pages.Length - 1;

                JSONNode coordinates = JSON.Parse(webRequest.downloadHandler.text);              

                float pos = int.Parse(coordinates["prediction"]);
                print(pos);
            if(pos==1){
                KATVR.transform.position += transform.forward * 0.2f;
            }
            else if(pos==2){
                KATVR.transform.position -= transform.right * 0.2f;
            }
            else if(pos==3){
                KATVR.transform.position -= transform.forward * 0.2f;
            }
            else if(pos==4){
                KATVR.transform.position += transform.right * 0.2f;
            }
            else{
                KATVR.transform.position = KATVR.transform.position;
            }
                while((Time.time - startTime)<0.1){
                    yield return new WaitForSeconds(0.01f);
                }
            }            
        }
    }
} 