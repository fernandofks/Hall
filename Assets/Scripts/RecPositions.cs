
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class RecPositions : MonoBehaviour {
     public string fileName = "positions.txt"; // file pathname
     public float interval = 0.1f; // save positions each 0.1 second
     public float tSample = 10.0f; // sampling starts after this time
     private List<Vector3> positions;
     private List<Vector3> rotations;
     private List<Vector3> rpositions;
     private List<Vector3> rrotations;
 
     GameObject MLeftFoot;
     GameObject MRightFoot;
 
     void Start(){
         MLeftFoot = GameObject.Find("MLeftFoot");
         MRightFoot = GameObject.Find("MRightFoot");
         positions = new List<Vector3>(); // initialize the array...
         rotations = new List<Vector3>();
         rpositions = new List<Vector3>(); // initialize the array...
         rrotations = new List<Vector3>();
         // and start recording after tSample:
         InvokeRepeating("RecPoint", tSample, interval);
     }
     void RecPoint(){
         positions.Add(MLeftFoot.transform.position);
         rotations.Add(MLeftFoot.transform.eulerAngles);
         rpositions.Add(MRightFoot.transform.position);
         rrotations.Add(MRightFoot.transform.eulerAngles);
         // store position...
     }
     // function that saves to a text file:
    void SaveToFile(string fileName){
         System.IO.File.WriteAllText(fileName, ""); // clear old file, if any
         
         for(int i=0; i<positions.Count; i++){
            
            string line = System.String.Format("{0:f2},{1:f2},{2:f2},{3:f2};{4:f2};{5:f2};{6:f2},{7:f2},{8:f2},{9:f2};{10:f2};{11:f2}\r\n", positions[i].x, positions[i].y, positions[i].z, rotations[i].x, rotations[i].y, rotations[i].z, rpositions[i].x, rpositions[i].y, rpositions[i].z, rrotations[i].x, rrotations[i].y, rrotations[i].z);
            System.IO.File.AppendAllText(fileName, line); // append to the file
         }
    }
     // example of use:
     void OnApplicationQuit(){
       
             SaveToFile(fileName); // save positions
     }
}
   