﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key31 : MonoBehaviour
{
public AudioSource key31;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-5,0,0);
    rb.isKinematic=true;
      key31.Play();

}    

private void OnMouseUp() {
  key31.Stop();
  rb.isKinematic=false;
}
}
