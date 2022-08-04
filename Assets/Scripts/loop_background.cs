﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour {

   public float scroll_Speed = 0.1f;
   
   private MeshRenderer mesh_Renderer;

    void Awake  () {
        mesh_Renderer = GetComponent<MeshRenderer>(); 
    }

    void Update () {

        float x = Time.time * scroll_Speed;

        Vector2 offset = new Vector2(x, 0);

        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
   
   
    }



}  // Class