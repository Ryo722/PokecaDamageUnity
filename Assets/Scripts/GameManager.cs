using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] Transform BattleFieldTransform;
    [SerializeField] Transform BenchFieldTransform;
    [SerializeField] Transform SubBenchFieldTransfrom;
    [SerializeField] GameObject Bench;
    [SerializeField] GameObject SubBench;
    [SerializeField] GameObject cardPrefab;
    bool bigBench;
    Transform field;
    int BenchObjCount;
    int SubBenchObjCount;

    // Start is called before the first frame update
    void Start()
    {
        field = BattleFieldTransform;
        GameObject card = Instantiate(cardPrefab, field, false) as GameObject;
        bigBench = false;
        field = BenchFieldTransform;
    }

    private void Update()
    {
        if (bigBench)
        {
            SubBench.SetActive(true);
        }
        else
        {
            SubBench.SetActive(false);
        }
    }

    void CreateCard(Transform field)
    {
        
        //ベンチのカードの枚数でベンチを拡張するか決める（ムゲンダイナ）
        BenchObjCount = Bench.transform.childCount;
        SubBenchObjCount = SubBench.transform.childCount;


        if (SubBenchObjCount >= 3)
        {
            return;
        }
        if (BenchObjCount >= 5 && bigBench && SubBenchObjCount < 3)
        {
            field = SubBenchFieldTransfrom;
        }
        else if(BenchObjCount >= 5 && !bigBench)
        {
            return;
        }
        else if(BenchObjCount < 5)
        {
            field = BenchFieldTransform;
        }
        //カードの生成とデータの受け渡し
        GameObject card = Instantiate(cardPrefab, field, false) as GameObject;
    }

    public void CreateCardOnBench()
    {
        CreateCard(field);
    }

    public void ToggleBench8()
    {
        bigBench = !bigBench;
        if (!bigBench)
        {
            foreach (Transform child in SubBench.transform)
            {
                Destroy(child.gameObject);
            }
        }
    }
}
