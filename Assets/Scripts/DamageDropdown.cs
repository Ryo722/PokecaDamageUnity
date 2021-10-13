using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DamageDropdown : MonoBehaviour
{
    Dropdown damageDropdown;

    // Start is called before the first frame update
    void Start()
    {
        List<string> optionlist = new List<string>();

        //Optionsに表示する数値をリストに追加

        for (int i = 0; i <= 900; i += 10)
        {
            optionlist.Add(i.ToString());
        }

        //DropdownコンポーネントのOptionsという項目にOptionsのリストがありました
        //それを編集するためにDropdownコンポーネントを取得
        damageDropdown = GetComponent<Dropdown>();

        //一度すべてのOptionsをクリア
        damageDropdown.ClearOptions();

        //リストを追加
        damageDropdown.AddOptions(optionlist);
    }

    public void PlusDamage()
    {
        damageDropdown.value++;
    }

    public void MinusDamage()
    {
        damageDropdown.value--;
    }

}
