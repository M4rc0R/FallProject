using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerAt : MonoBehaviour
{
    public GameObject Player;
    
    private void OnTriggerEnter(Collider other){
        if(other.gameObject == Player){
            Player.transform.parent = transform;
        }
    }
}
