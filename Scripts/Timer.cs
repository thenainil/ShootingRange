using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

public Light light1;
public Light light2;
public Light light3;
public Light light4;
public Light light5;
public Light light6;
public Light light7;
public Light light8;
public Light light9;
public Light light10;

public Text timerText;
private float startTime;
private float endTime;

   void start(){
   	startTime = Time.time;
   }

   void OnTriggerExit(Collider col){
   	if(statusCheck() == false){
   	
   	endTime = Time.time - startTime;
   	string minutes = ((int) endTime / 60).ToString();
   	string seconds = (endTime % 60).ToString("f2");
   	timerText.text = "Time: " + minutes + ":" + seconds;
   	}

   }     
        
   bool statusCheck(){
   bool round1 = true;
   bool round2 = true;
   bool round3 = true;
   if(light1.enabled == false && light2.enabled == false && light3.enabled == false)
   round1 = false;
   if(light4.enabled == false && light5.enabled == false && light6.enabled == false)
   round2 = false;
   if(light7.enabled == false && light8.enabled == false && light9.enabled == false)
   round3 = false;
   if(round1 == false && round2 == false && round3 == false && light10.enabled == false)
   return false;
   else
   return true;
   
   
   }
}
