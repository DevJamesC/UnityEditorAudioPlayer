using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MBS.Tools
{
    public class DestroyOnPlayMode : MonoBehaviour
    {

        // Update is called once per frame
        void Update()
        {
            if (Application.isPlaying)
                DestroyImmediate(gameObject, true);
        }
    }
}
