using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Instantiate : MonoBehaviour
{

    public GameObject Retangulo;
    // Start is called before the first frame update
    void Start()
    {
        GameObject copiaRetangulo = Instantiate(Retangulo);
        Destroy(copiaRetangulo.gameObject, 2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}