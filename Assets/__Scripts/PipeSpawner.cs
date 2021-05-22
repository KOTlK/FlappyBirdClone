using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] private Transform _obstacle;
    [SerializeField] private Transform _parent;

    private Vector3 _spawnPosition;
    

    private void Start()
    {
        _spawnPosition = Vector3.zero;
        _spawnPosition.x = 20;
    }


    private void FixedUpdate()
    {
        if (_parent.transform.childCount < 20)
        {
            _spawnPosition.y = Random.Range(CameraBounds.Min.y + CameraBounds.Max.y / 4, CameraBounds.Max.y - CameraBounds.Max.y / 4);
            SpawnPipe(_spawnPosition);
            _spawnPosition.x += 15;
            
        }
        RemovePipe();

    }


    private void SpawnPipe(Vector3 position)
    {
        Instantiate(_obstacle, position, Quaternion.identity, _parent);

    }

    private void RemovePipe()
    {                
        Transform child = _parent.GetChild(0);
        if (child.position.x < CameraBounds.Min.x - 10)
        {
            Destroy(child.gameObject);
        }
        
    }

    
}
