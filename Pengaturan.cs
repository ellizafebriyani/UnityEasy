using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pengaturan : MonoBehaviour
{
    [Header("Input Deskripsi")]
    public ObserverAR tr;
    public string nama;

    [TextArea]
    public string deskripsi;

    [Header("UI Deskrpisi")]
    public Text txtNama;
    public Text txtDeskripsi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if(tr.GetMarker()){
                txtNama.text = nama;
                txtDeskripsi.text = deskripsi;
            }
        
    }
}
