﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public Transform[] spawnLocations;
    public GameObject[] whatToSpawnPrefab;
    public GameObject[] whatToSpawnClone;

    private Collider2D Player;
    public Collider2D[] colliders;

    void Start () {
        //spawn();
        Player = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
        colliders = gameObject.GetComponentsInChildren<Collider2D>();
    }

    void Update () {

    }

    public void spawn(){
        for (int i = 0; i < whatToSpawnPrefab.Length; i++)
        {
            whatToSpawnClone[i] = Instantiate(whatToSpawnPrefab[i], spawnLocations[i].transform.position, Quaternion.Euler(0, 0, 0)) as GameObject;
        }
    }

    //public void OnCollisionEnter2D(Collision2D collision)
    //{
    //    Collider2D[] colliders = gameObject.GetComponentsInChildren<Collider2D>();
    //    foreach (Collider2D collider2D in colliders)
    //    {
    //        if (collider2D.IsTouching(Player))
    //        {
    //            spawn();
    //            collider2D.enabled = false;
    //            //Destroy(collision.gameObject);
    //        }
    //    }
    //}

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    //var colliders = gameObject.GetComponentsInChildren<Collider2D>();
    //    //Debug.Log(colliders);
    //    //for (var index = 0; index < colliders.Length; index++)
    //    //{
    //        //var colliderItem = colliders[index];
    //        if (collision.gameObject.tag == "Player")
    //        {
    //            //colliderItem.enabled = false;
    //            Debug.Log("collision");
    //        }
    //    //}
    //}

    public void collisionDetected(TowerCreate towerCreate){
        //Debug.Log("child collided (parent)");
    }
}
