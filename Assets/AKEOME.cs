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
        A();
        Ke();
        O();
        Me();
    }

    private void A()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(a[0].transform.DOMoveX(3.5f, 1));
        sequence.Append(a[1].transform.DOMoveZ(0, 1));
        sequence.Append(a[2].transform.DOMove(new Vector3(0, 0, 0), 1));
        sequence.Append(a[2].transform.DOMove(new Vector3(0, 0, 2.5f), 1));
        sequence.Append(a[2].transform.DOMove(new Vector3(4, 0, 2.5f), 1));
        sequence.Append(a[2].transform.DOMove(new Vector3(4, 0, 0), 2));
    }

    private void Ke()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(ke[0].transform.DOMoveZ(-4.5f, 2));
        sequence.Append(ke[1].transform.DOMoveX(4.5f, 2));
        sequence.Append(ke[2].transform.DOMoveZ(-5.5f, 3));
    }

    private void O()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(o[0].transform.DOMoveX(-2f, 1));
        sequence.Append(o[1].transform.DOMoveZ(-2, 1));
        sequence.Append(o[1].transform.DOMoveX(-6, 1));
        sequence.Append(o[1].transform.DOMoveZ(0, 1));
        sequence.Append(o[1].transform.DOMoveX(-1.5f, 1));
        sequence.Append(o[1].transform.DOMoveZ(-2, 1));
        sequence.Append(o[2].transform.DOMoveZ(0.5f, 1));
    }

    private void Me()
    {
        var sequence = DOTween.Sequence();

        sequence.Append(me[0].transform.DOMoveZ(-4, 1));
        sequence.Append(me[0].transform.DOMove(new Vector3(-4.5f, 0, -6), 1));
        sequence.Append(me[1].transform.DOMove(new Vector3(-7.5f, 0, -6f), 1));
        sequence.Append(me[1].transform.DOMoveZ(-3.5f, 1));
        sequence.Append(me[1].transform.DOMoveX(-3, 1));
        sequence.Append(me[1].transform.DOMoveZ(-6, 2));
    }
}
