
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class RecPositions : MonoBehaviour {
     public string fileName = "walk_data_13_Fernando.txt"; // file pathname
     public float interval = 0.1f; // save positions each 0.1 second
     public float tSample = 60; // sampling starts after this time
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
            string line = System.String.Format("{0:f2},{1:f2},{2:f2},{3:f2},{4:f2},{5:f2},{6:f2},{7:f2},{8:f2},{9:f2},{10:f2},{11:f2},{12:f2},{13:f2},{14:f2},{15:f2},{16:f2},{17:f2},{18:f2},{19:f2},{20:f2}\r\n", positions[i].x, positions[i].y, positions[i].z, rotations[i].x, rotations[i].y, rotations[i].z, rotations[i].w, rpositions[i].x, rpositions[i].y, rpositions[i].z, rrotations[i].x, rrotations[i].y, rrotations[i].z, rrotations[i].w, cpositions[i].x, cpositions[i].y, cpositions[i].z, crotations[i].x, crotations[i].y, crotations[i].z, crotations[i].w);
            System.IO.File.AppendAllText(fileName, line); // append to the file
         }
    }
     // example of use:
     void OnApplicationQuit(){
       
             SaveToFile(fileName); // save positions
     }
}
   