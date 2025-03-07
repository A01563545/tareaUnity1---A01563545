using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject cubePrefab;
    public void InstantiatePrefab()
    {
        GameObject newPrefab = Instantiate(cubePrefab);
        MoveObject moveObject = newPrefab.GetComponent<MoveObject>(); // En C#, <> es un génerico. 
        moveObject.speed = new Vector3(0, 0, Random.Range(0.1f, 1.5f)); // En C#, cuando colocamos f es para especificar que es flotante. 

    }
}
