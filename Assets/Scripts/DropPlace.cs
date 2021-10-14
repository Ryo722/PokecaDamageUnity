using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropPlace : MonoBehaviour, IDropHandler
{
    BattleFieldMax battleFieldMax;
    BenchFieldMax benchFieldMax;
    SubBenchFieldMax subBenchFieldMax;
    string name;
    int max;

    private void Start()
    {
        battleFieldMax = GetComponent<BattleFieldMax>();
        benchFieldMax = GetComponent<BenchFieldMax>();
        subBenchFieldMax = GetComponent<SubBenchFieldMax>();
    }

    public void OnDrop(PointerEventData eventData)
    {
        CardMovement card = eventData.pointerDrag.GetComponent<CardMovement>();
        this.name = this.transform.name;

        switch (name)
        {
            case "BattleField":
                max = battleFieldMax.max;
                break;
            case "BenchField":
                max = benchFieldMax.max;
                break;
            case "SubBenchField":
                max = subBenchFieldMax.max;
                break;
        }
        if(card != null　&& this.transform.childCount < max)
        {
            card.defaultParent = this.transform;
        }
    }
}
