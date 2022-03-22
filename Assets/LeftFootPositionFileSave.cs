
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class RecPositions : MonoBehaviour {
     public string fileName = "D:/positions.txt"; // file pathname
     public float interval = 0.1f; // save positions each 0.1 second
     public float tSample = 10.0f; // sampling starts after this time
     private List<Vector3> positions;
     private List<Vector3> rotations;
 
     GameObject LeftFoot;
 
     void Start(){
         LeftFoot = GameObject.Find("mixamorig:LeftFoot (1)");
         positions = new List<Vector3>(); // initialize the array...
         rotations = new List<Vector3>();
         // and start recording after tSample:
         InvokeRepeating("RecPoint", tSample, interval);
     }
     void RecPoint(){
         positions.Add(LeftFoot.transform.position);
         rotations.Add(LeftFoot.transform.eulerAngles); // store position...
     }
     // function that saves to a text file:
     void SaveToFile(string fileName){

         System.IO.File.WriteAllText(fileName, ""); // clear old file, if any
             string line = System.String.Format("{0,6:f2};{1,6:f2};{2,6:f2};{3,6:f2};{4,6:f2};{5,6:f2\r\n", positions[0].x, positions[0].y, positions[0].z, rotations[0].x, rotations[0].y, rotations[0].z);
             System.IO.File.AppendAllText(fileName, line); // append to the file
         }
    
     
     // example of use:
     void OnGUI(){
       
             SaveToFile(fileName); // save positions
     }
}
   
