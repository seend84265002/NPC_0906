using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private void dialoguet(string nar)
    {
        print("��ܤ��e:"+nar);
    }
    ///<summary>
    ///��ܤ��e
    ///</summary>
    public bool openStore()
    {
        return true;
    }
    ///<summary>
    ///�}�Ұө�
    ///</summary>

    public int BuyProps()
    {
        print("�D������w�]��" + 100);
        return 0;
    }
    ///<summary>
    ///�ʶR�D��
    ///</summary>

    public void getmission(int a)
    {
       print("���Ƚs��"+a);
    }
    ///<summary>
    ///���o����
    ///</summary>
    private int renmission()
    {
        print("��o���ȹD��ƶq�w�]��"+1);
        return 0;
    }
    ///<summary>
    ///���ȧ�s
    ///</summary>

    private bool missioncomp(int a)
    {
        print("���Ƚs��"+a+"����");
        return false;
    }
    ///<summary>
    ///���ȧ���
    ///</summary>

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
