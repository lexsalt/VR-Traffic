using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawnScript : MonoBehaviour
{
    // public GameObject car3Spawn;
    public GameObject[] cars;
    // container for  ref to logic script (replaced by global variable lightColor) 
    // public logicScript logicScriptRef;
    // public GameObject trafficLight;


    public float spawnRate = 4;
    private float timer = 0;
    public int indexOfCars;

    void Awake () {
        // ref to logic script (replaced by global variable lightColor)
        // logicScriptRef = GameObject.Find("trafficLight").GetComponent<logicScript>();
    }


    // Start is called before the first frame update
    void Start()
    {
        // spawner();
        // Debug.Log(logicScriptRef.redLight);
        // Debug.Log(cars.Length);
        // Debug.Log(logicScript.lightColor);
    }
    void FixedUpdate() {
        // Debug.Log(logicScriptRef.redLight);
        if (logicScript.lightColor == 0) {
            // Debug.Log("True!!");
        } else if (logicScript.lightColor == 1) {
            if (timer < spawnRate)
        {
            timer = timer + Time.deltaTime;
        } else 
        {
            spawner();
            timer = 0;
            randomSpawnRate();
        }
        }
    }
    void spawner() {
        indexOfCars = Random.Range(0, cars.Length);
        // Debug.Log(indexOfCars);
        // Debug.Log(cars.Length);
            // Instantiate(car3Spawn, transform.position, transform.rotation);
            if (cars.Length > 0) {
                Instantiate(cars[indexOfCars], new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation);
            } else {
                // Debug.Log(cars.Length);
            }
    }
    void randomSpawnRate () {
        spawnRate = Random.Range(2,4);
    }
}
