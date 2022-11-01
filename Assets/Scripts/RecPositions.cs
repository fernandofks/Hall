
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class RecPositions : MonoBehaviour {
     private string fileName = "v_test_i_0.txt"; // file pathname
     private float interval = 0.01f; // save positions each 0.05 second
     private float tSample = 60; // sampling starts after this time
     private List<Vector3> positions;
     private List<Quaternion> rotations;
     private List<Vector3> rpositions;
     private List<Quaternion> rrotations;
     private List<Vector3> cpositions;
     private List<Quaternion> crotations;
 
     GameObject MLeftFoot;
     GameObject MRightFoot;
     GameObject Camera;
 
     void Start(){
         MLeftFoot = GameObject.Find("MLeftFoot");
         MRightFoot = GameObject.Find("MRightFoot");
         Camera= GameObject.Find("Camera");
         positions = new List<Vector3>(); // initialize the array...
         rotations = new List<Quaternion>(); 
         rpositions = new List<Vector3>(); // initialize the array...
         rrotations = new List<Quaternion>();
         cpositions = new List<Vector3>(); // initialize the array...
         crotations = new List<Quaternion>();
         // and start recording after tSample:
         InvokeRepeating("RecPoint", tSample, interval);
     }
     void RecPoint(){
         positions.Add(MLeftFoot.transform.position);
         rotations.Add(MLeftFoot.transform.rotation);
         rpositions.Add(MRightFoot.transform.position);
         rrotations.Add(MRightFoot.transform.rotation);
         cpositions.Add(Camera.transform.position);
         crotations.Add(Camera.transform.rotation);
         // store position...
     }
     // function that saves to a text file:
    void SaveToFile(string fileName){
         System.IO.File.WriteAllText(fileName, ""); // clear old file, if any
         
         for(int i=0; i<positions.Count; i++){
            string line = System.String.Format("{0:f3},{1:f3},{2:f3},{3:f3},{4:f3},{5:f3},{6:f3},{7:f3},{8:f3},{9:f3},{10:f3},{11:f3},{12:f3},{13:f3},{14:f3},{15:f3},{16:f3},{17:f3},{18:f3},{19:f3},{20:f3}\r\n", positions[i].x, positions[i].y, positions[i].z, rotations[i].x, rotations[i].y, rotations[i].z, rotations[i].w, rpositions[i].x, rpositions[i].y, rpositions[i].z, rrotations[i].x, rrotations[i].y, rrotations[i].z, rrotations[i].w, cpositions[i].x, cpositions[i].y, cpositions[i].z, crotations[i].x, crotations[i].y, crotations[i].z, crotations[i].w);
            System.IO.File.AppendAllText(fileName, line); // append to the file
         }
    }
     // example of use:
     void OnApplicationQuit(){
       
             SaveToFile(fileName); // save positions
     }
}
   