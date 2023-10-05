using Microsoft.MixedReality.Toolkit.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class ARbutton : MonoBehaviour
{
    public event Action OnButtonClicked;
    
    [SerializeField] private TextMeshPro _title;

    [SerializeField] private Interactable _interactable ;

    private Item _item ;
    public void Initialize(Item config)
    {
        _title.text = config.Title;
        _item = config;
        _interactable.OnClick.AddListener(ProcessClick);

    }

    private void ProcessClick()
    {
        OnButtonClicked?.Invoke();
        //var randPosition = new Vector3(UnityEngine.Random.Range(-5f, 5f), UnityEngine.Random.Range(-5f, 5f), UnityEngine.Random.Range(-5f, 5f));
        var position = Camera.main.transform.position + Camera.main.transform.forward * 2;
        var item = Instantiate(_item.objectPrefab, position, Quaternion.identity);
        item.GetComponent<Rigidbody>().isKinematic = false;

    }
}

