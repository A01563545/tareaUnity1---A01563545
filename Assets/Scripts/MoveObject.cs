using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObject : MonoBehaviour
{

    float x, y, z;
    // Start is called before the first frame update
    public Vector3 speed;
    

    // Update is called once per frame
    void Update() // Se ejecuta cada frame. // 120 fps, 20 fps
    {
        transform.position += new Vector3(x, y, z); // En Unity, la frontal es Z, la lateral es X y la vertical es Y
        x += speed.x * Time.deltaTime; // Potente = .008, Pobre =  0.050 
        y += speed.y * Time.deltaTime;
        z += speed.z * Time.deltaTime;
    }
}
