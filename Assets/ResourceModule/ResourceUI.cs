using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

[RequireComponent(typeof(Resource))]
public class ResourceUI : MonoBehaviour
{
    public Text Value;
    public Text Label;

    private Resource resource;

    private Coroutine valueTicker;
    private int cachedValue;


    private void Awake()
    {
        resource = GetComponent<Resource>();
        Label.text = resource.name;

        // Let the method 'updateUI()' run when the OnValueChanged UnityEvent is invoked.
        // See the resource class for more info.
        resource.OnValueChanged.AddListener(UpdateUI);
    }

    private void Start()
    {
        UpdateUI();
    }

    public void UpdateUI()
    {
        // We could just set Value.text to resource.Quantity and be done, but in this
        // version of the UI we made the visual number to increase until it reaches
        // the actual number of the model. To do this we use a Coroutine.
        Value.text = Convert.ToString(resource.GetQuantity());
    }

}
