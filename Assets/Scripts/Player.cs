using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Player : MonoBehaviour
{
    public Camera cam;   //camera
    public NavMeshAgent nv;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray r = cam.ScreenPointToRay(Input.mousePosition);  //take input from mouse from which direction we want to aplayer to move 
            RaycastHit h;          // creating variable

            if(Physics.Raycast(r, out h))    //add some physcis to store ray cast hit we want 
            {
                nv.SetDestination(h.point);
            }
         }
    }
}
