using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private void LateUpdate()
    {
        if (Player.S.State == PlayerState.Alive)
        {
            float posx = _target.transform.position.x;
            Camera.main.transform.position = new Vector3(posx + (Camera.main.aspect * 7), Camera.main.transform.position.y, -10);
        }
        
    }
}
