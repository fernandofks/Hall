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
    static float angulo_y;

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
            float fx = foot.position.x;
            float fy = foot.position.y;
            float fz = foot.transform.localPosition.z;
            float frx= foot.rotation.x;
            float fry= foot.rotation.y;
            float frz= foot.rotation.z;
            float frw = foot.rotation.w;
            float frEulerx = foot.rotation.eulerAngles.x;
            float frEulery = foot.rotation.eulerAngles.y;
            float frEulerz = foot.rotation.eulerAngles.z;
            float rfx = rfoot.position.x;
            float rfy = rfoot.position.y;
            float rfz = rfoot.transform.localPosition.z;
            float rfrx= rfoot.rotation.x;
            float rfry= rfoot.rotation.y;
            float rfrz= rfoot.rotation.z;
            float rfrw= rfoot.rotation.w;
            float rfrEulerx = rfoot.rotation.eulerAngles.x;
            float rfrEulery = rfoot.rotation.eulerAngles.y;
            float rfrEulerz = rfoot.rotation.eulerAngles.z;            
            string envio = System.String.Format("[{0},{1},{2},{3},{4},{5}]", fx, fy, fz, rfx, rfy, rfz);  
            uri += envio;
            
            yield return new WaitForSeconds(0.03f);
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

                // Mudando posição
                // Quaternion moveAng = foot.transform.eulerAngles - rfoot.transform.eulerAngles;
                // transform.position += moveAng*Vector3.forward*pos;
                // rot = new Vector3( 0, (frEulery+rfrEulery)/2, 0);

                transform.position += transform.forward * 0.2f * pos;
                // transform.eulerAngles = rot;
                // transform.Rotate(0, (frEulery+rfrEulery)/2, 0, Space.World);
                // //print(Time.time - startTime);
                // Quaternion target = Quaternion.Euler(0, (frEulery+rfrEulery)/2, 0);
                // Dampen towards the target rotation
                // transform.rotation = Quaternion.Slerp(transform.rotation, target,  Time.deltaTime * 5.0f);
                // transform.Rotate( rot,  Space.World);
                // var rot2 = transform.localRotation.eulerAngles; //get the angles
                // rot2.Set(0f,(frEulery+rfrEulery)/2 , 0f); //set the angle
                // transform.localRotation = Quaternion.Euler(rot2);
                print("angulo_y_ANTES:"+ angulo_y);
                // Vector3 angulo_pe_esquerdo = transform.TransformVector(foot.rotation.eulerAngles);
                // Vector3 angulo_pe_direito  = transform.TransformVector(rfoot.rotation.eulerAngles);
                // Vector3 angulo_pe_esquerdo =foot.rotation.eulerAngles;
                // Vector3 angulo_pe_direito= rfoot.rotation.eulerAngles;
                Vector3 angulo_pe_esquerdo =foot.localRotation.eulerAngles;
                Vector3 angulo_pe_direito= rfoot.localRotation.eulerAngles;
                float angulo_pes = (angulo_pe_direito.y+angulo_pe_esquerdo.y)/2;
                Vector3 to = new Vector3(0, angulo_pes, 0);
                // to=transform.TransformVector(to);
                // Vector3 angulo_atual= transform.rotation.eulerAngles;
                // transform.eulerAngles = Vector3.Lerp(transform.TransformDirection(transform.rotation.eulerAngles) , to, 0.002f);
                // transform.rotation= transform.TransformDirection(to);
                // transform.rotation= Lerp(transform.rotation.eulerAngles, to, 0));
                // transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(to),0.002f);  
                transform.rotation = Quaternion.Euler(to);

                // Quaternion target  = Quaternion.Euler(0, angulo_pes-angulo_y, 0);
                // transform.rotation= target;
                // Vector3 to = new Vector3(0,(frEulery+rfrEulery)/2 , 0);
                // transform.eulerAngles = Vector3.Lerp(to2, to, 0);
                // float angle = Mathf.MoveTowardsAngle(transform.eulerAngles.y, angulo_pes, 0);
                // transform.eulerAngles = new Vector3(0, angle, 0);
                // angulo_y=angulo_pes;
                print("rotacao_atual:" + transform.rotation.eulerAngles );
                print("angulo_pes"+angulo_pes);
                print("angulo_pe_esquerdo:"+angulo_pe_esquerdo);
                // transform.rotation = Quaternion.AngleAxis((frEulery+rfrEulery)/2, Vector3.up);
                while((Time.time - startTime)<0.1){
                    yield return new WaitForSeconds(0.001f);
                }
            }            
        }
    }
} 