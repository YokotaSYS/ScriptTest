using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int mp = 53;
    public void Magic()
    {
        if (mp >= 5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため、魔法が使えない。");
        }
        

        
    }


        
    

}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //課題
        int[] array = { 1, 3, 5, 7, 9 };
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }

        //発展課題
        int mp = 53;
        Boss boss = new Boss();
        //10回+１回ループ
        for(int i = 0; i < 11;i++)
        {
            boss.Magic();
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
