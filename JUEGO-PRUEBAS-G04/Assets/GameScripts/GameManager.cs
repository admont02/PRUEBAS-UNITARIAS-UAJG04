using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //[SerializeField]
    //Toggle toggle;  // Referencia al Toggle en la UI
    //private bool herramientaActiva = true;

    //void Start()
    //{
    //    // Asegurarse de que el Toggle refleja el estado inicial
    //    toggle.isOn = herramientaActiva;
    //    // Añadir listener al Toggle
    //    toggle.onValueChanged.AddListener(OnToggleChanged);
    //    // Aplicar el estado inicial
    //    UpdateScriptActivation();
    //}

    //void OnToggleChanged(bool isOn)
    //{
    //    herramientaActiva = isOn;
    //    UpdateScriptActivation();
    //}

    //void UpdateScriptActivation()
    //{
        
    //    // Encontrar todas las instancias de MyScript en la escena
    //    Transmitter[] scripts = FindObjectsOfType<Transmitter>();

    //    // Activar/desactivar cada instancia basado en herramientaActiva
    //    foreach (var script in scripts)
    //    {
    //        script.enabled = herramientaActiva;
    //    }
    //    Listener list = FindObjectOfType<Listener>();
    //    list.enabled = herramientaActiva;
    //    CanvasSoundController controller = FindObjectOfType<CanvasSoundController>();
    //    controller.ClearAll();
    //    controller.enabled = herramientaActiva;
    //}
}
