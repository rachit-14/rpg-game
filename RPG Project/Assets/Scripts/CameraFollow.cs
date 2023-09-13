using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class CameraFollow : MonoBehaviour
    {
        [SerializeField] GameObject target;
        public Vector3 offset;

        // Update is called once per frame
        void Update()
        {
            transform.position = target.transform.position + offset;
        }
    }
}
