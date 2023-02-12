using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monster
{
    public class PlayerControl : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.localPosition += new Vector3(-300, 0, 0) * Time.deltaTime;
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.localPosition += new Vector3(300, 0, 0) * Time.deltaTime;
            }

        }
    }

}
