﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key42 : MonoBehaviour
{
public AudioSource key42;
public Rigidbody rb;
private void OnMouseDown() 
{

  transform.Rotate(-4,0,0);
    rb.isKinematic=true;
      key42.Play();

}    

private void OnMouseUp() {
  key42.Stop();
  rb.isKinematic=false;
}
}
