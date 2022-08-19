using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeWaiter : MonoBehaviour
{
    void Start()
    {

    }
    // queria usar esse na vdd
    // coloquei elas la pra testar
    // tendi
    // vamo ve de novo
    public IEnumerator WaitTenSeconds()
    {
        yield return new WaitForSeconds(10f);
    }

    public IEnumerator WaitThirtenSeconds()
    {
        yield return new WaitForSeconds(30f);
    }

    public IEnumerator WaitAMinute()
    {
        yield return new WaitForSeconds(60f);
    }
}
