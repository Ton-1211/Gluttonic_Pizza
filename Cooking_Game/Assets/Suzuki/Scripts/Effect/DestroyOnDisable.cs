using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnDisable : MonoBehaviour
{
    void OnDisable()
    {
        Destroy(gameObject);
    }
}
