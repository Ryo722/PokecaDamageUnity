using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DamageDropdown : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Dropdown ddtmp; /*  */
        List<string> optionlist = new List<string>();

        //Optionsに表示する数値をリストに追加

        for (int i = 0; i <= 900; i += 10)
        {
            optionlist.Add(i.ToString());
        }

        //DropdownコンポーネントのOptionsという項目にOptionsのリストがありました
        //それを編集するためにDropdownコンポーネントを取得
        ddtmp = GetComponent<Dropdown>();

        //一度すべてのOptionsをクリア
        ddtmp.ClearOptions();

        //リストを追加
        ddtmp.AddOptions(optionlist);
    }

}
