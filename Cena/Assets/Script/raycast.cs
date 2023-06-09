using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycast : MonoBehaviour
{
    public static bool Atirado;
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Verifique se o botão esquerdo do mouse foi pressionado
        {
            Atirado = false;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {   
                if (hit.collider.gameObject.tag == "Inimigo") // Verifique se o Raycast atingiu o objeto atual
                {
                    Atirado = true;
                    Destroy(hit.collider.gameObject); // Destrua o objeto
                }
            }
        }
        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out RaycastHit hitinfo, 100f)) 
        {
            Debug.Log("Hit Something");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hitinfo.distance, Color.green);
        }
        else    
        {
            Debug.Log ("Hit Nothing");
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 100f, Color.red);
        }
    }
}
