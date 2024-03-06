using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMat3 : MonoBehaviour
{
    public Material material;
    public void ChangeMaterial(GameObject gameObject)
    {
        MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();
        meshRenderer.material = material;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
