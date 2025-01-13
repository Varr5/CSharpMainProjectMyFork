using System.Collections;
using System.Collections.Generic;
using Controller;
using Model;
using Model.Config;
using UnityEngine;

public class EnterPoint : MonoBehaviour
{
    [SerializeField] private Settings _settings;
    [SerializeField] private Canvas _targetCanvas;
    
    private RootController _rootController;


    //Привет, здесь был я!
    /*/
    *
    *
    *
    /*/
    
    
    void Start()
    {
        _settings.LoadUnits();
        
        _rootController = new RootController(_settings, _targetCanvas);
    }
}
