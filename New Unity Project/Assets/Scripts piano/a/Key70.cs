﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key70 : MonoBehaviour
{
public AudioSource key70;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key70.Play();

}    

private void OnMouseUp() {
  key70.Stop();
  rb.isKinematic=false;
}
}
