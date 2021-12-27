using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusGenerator : MonoBehaviour
{
   public GameObject _let;
   public float _minX;
   public float _maxX;
   public float _minY;
   public float _maxY;
   public float _timeBetweenSpawn;
   private float _spwanTime; 

    void Update()
    {
      if(Time.time > _spwanTime)
      {
        Spawn();
        _spwanTime = Time.time + _timeBetweenSpawn;
      }  
    }

    void Spawn()
    {
    float randomX = Random.Range(_minX,_maxX);
    float randomY = Random.Range(_minY,_maxY);

    Instantiate(_let, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }
}
