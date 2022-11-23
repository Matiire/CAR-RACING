using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class RespawnScript : MonoBehaviour{

   [SerializeField] GameObject player;

   [SerializeField] Transform SpawnPoint;

   [SerializeField] float spawnValue;

   void Update(){
    if(player.transform.position.y < -spawnValue){
        RespawnPoint();
    }
   }

   void RespawnPoint(){
    transform.position = SpawnPoint.position;
   } 
}