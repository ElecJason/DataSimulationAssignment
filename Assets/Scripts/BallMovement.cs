using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField] private GameObject dataManager;
    private DataReader _data;

    [SerializeField] private int _scale = 10; //scale divides by this amount
    private Vector3 _position;
    private int _index = 0;
    private bool _hasTimerFinished;
    void Start()
    {
        _hasTimerFinished = true;
        _data = dataManager.GetComponent<DataReader>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_index >= _data._frameArray.Count) return;
        
        _position = new Vector3(_data._xBalPos[_index] / _scale, _data._yBalPos[_index] / _scale, _data._zBalPos[_index] / _scale);
        transform.position = Vector3.MoveTowards(transform.position, _position, Time.deltaTime * _data._ballSpeed[_index]);

        if (!_hasTimerFinished) return;
        StartCoroutine(Wait());
        _index++;
    }

    IEnumerator Wait()
    {
        _hasTimerFinished = false;
        yield return new WaitForSeconds(0.001f);
        _hasTimerFinished = true;
    }
}
