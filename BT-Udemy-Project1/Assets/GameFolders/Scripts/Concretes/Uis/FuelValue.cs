using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using BTUdemyProject1.Movements;

namespace BTUdemyProject1.Uis
{
    public class FuelValue : MonoBehaviour
    {
        Slider _slider;
        Fuel _fuel;
        
        private void Awake()
        {
            _slider = GetComponent<Slider>();
            _fuel = FindObjectOfType<Fuel>();
        }

        private void Update()
        {
            _slider.value = _fuel.CurrentFuel;
        }
    }
}

