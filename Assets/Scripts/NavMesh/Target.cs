using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    private MeshRenderer render;

    void Start() {
        render = GetComponent<MeshRenderer>();
    }

    void Update() {
        if (Input.GetMouseButtonDown(0)) {
            // Si aínda non está visible, activamos o meshrenderer
            if (!render.enabled)  {
                render.enabled = true;
            }
                
            
            RaycastHit hitData;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitData, 1000)) {
                transform.position = hitData.point;
            }
        }

        if (Input.GetMouseButtonDown(1)) {
            // con botón dereito desactivamos a persecución e tamén a visualización do obxeto
            if (render.enabled)  {
                render.enabled = false;
            }
        }
    }
}
