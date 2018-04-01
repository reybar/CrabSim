using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sort : MonoBehaviour {

    public string sortingLayer;

    void Start() {
                this.GetComponent<Renderer>().sortingLayerName = sortingLayer;
    }
}
