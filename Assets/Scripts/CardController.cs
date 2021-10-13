using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardController : MonoBehaviour
{
    GameObject parentField;
    string field;

    private void Start()
    {
        parentField = transform.parent.gameObject;
        field = parentField.name;
        Debug.Log(field);
    }

    public void RemoveCardFromBench()
    {
        Destroy(this.gameObject);
    }
}
