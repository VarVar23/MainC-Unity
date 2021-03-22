using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class CheckPoint : MonoBehaviour
    {
        private bool check = true;
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                GetComponent<MeshRenderer>().material.DisableKeyword("_EMISSION");

                if (check)
                {
                    collision.gameObject.GetComponent<Player>().Score++;
                    check = false;
                }
            }
        }
    }
}

