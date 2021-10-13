using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubBenchField : MonoBehaviour
{
    [SerializeField] GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        this.gameObject.SetActive(false);
    }
}
