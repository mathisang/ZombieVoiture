using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSkinCar : MonoBehaviour
{   
    public Material[] materials;
    public int numChoice;
    public Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        rend.sharedMaterial = materials[numChoice];
    }
}
