using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetGenerator : MonoBehaviour
{
   public GameObject let;
   public float minX;
   public float maxX;
   public float minY;
   public float maxY;
   private float timeBetweenSpawn;
   private float spwanTime; 
   public float tbsMin;
   public float tbsMax;

    void Start()
    {
      timeBetweenSpawn = Random.Range(tbsMin, tbsMax);
    }
    void Update()
    {
      if(Time.time > spwanTime)
      {
        Spawn();
        spwanTime = Time.time + timeBetweenSpawn;
      }  
    }

    void Spawn()
    {
    float randomX = Random.Range(minX,maxX);
    float randomY = Random.Range(minY,maxY);

    Instantiate(let, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
