using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hits : MonoBehaviour
{
       public Light light;
       void OnTriggerEnter(Collider col){
        light.enabled = false;	
        }
}
