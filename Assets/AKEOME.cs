using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class AKEOME : MonoBehaviour
{
    [SerializeField]
    private GameObject[] a;

    [SerializeField]
    private GameObject[] ke;

    [SerializeField]
    private GameObject[] o;

    [SerializeField]
    private GameObject[] me;

    void Start()
    {
        //A();
        Ke();
        O();
        Me();
    }

    private void A()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(a[0].transform.DOMoveX(3.5f, 1));
        sequence.Append(a[1].transform.DOMoveZ(0, 2));
        sequence.Append(a[2].transform.DOMove(new Vector3(0, 0, 0), 1));
        sequence.Append(a[2].transform.DOMove(new Vector3(0, 0, 2.5f), 1));
        sequence.Append(a[2].transform.DOMove(new Vector3(4, 0, 2.5f), 1));
        sequence.Append(a[2].transform.DOMove(new Vector3(4, 0, 0), 1));
    }

    private void Ke()
    {

    }

    private void O()
    {

    }

    private void Me()
    {

    }
}
