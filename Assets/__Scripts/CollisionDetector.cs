using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private readonly string _greenZoneTag = "GreenZone";
    private readonly string _pipeTag = "Pipe";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(_pipeTag))
        {
            Player.S.Die();
        } else if (other.CompareTag(_greenZoneTag))
        {
            ScoreCounter.UpdateScore();
        }
    }
}
