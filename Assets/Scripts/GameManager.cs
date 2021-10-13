using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform BattleFieldTransform;
    [SerializeField] Transform BenchFieldTransform;
    [SerializeField] GameObject cardPrefab;

    // Start is called before the first frame update
    void Start()
    {
        CreateCard(BattleFieldTransform);
    }

    void CreateCard(Transform field)
    {
        //カードの生成とデータの受け渡し
        GameObject card = Instantiate(cardPrefab, field, false);
    }

    public void CreateCardOnBench()
    {
        CreateCard(BenchFieldTransform);
    }

    
}
