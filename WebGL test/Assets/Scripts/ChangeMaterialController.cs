using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterialController : MonoBehaviour
{
    public Material material;
    public void ChangeMaterial(GameObject gameObject)
    {
        MeshRenderer meshRenderer = gameObject.GetComponent<MeshRenderer>();
        meshRenderer.material = material;
    }

    public void changeMat(GameObject gameObject, Shader material)
    {

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
