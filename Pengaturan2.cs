using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pengaturan : MonoBehaviour
{
    [Header("Input Deskripsi")]
    public ObserverAR[] observers; // Array observer
    public string[] namaObservers; // Array nama
    [TextArea]
    public string[] deskripsiObservers; // Array deskripsi

    [Header("UI Deskripsi")]
    public Text txtNama;
    public Text txtDeskripsi;

    void Start()
    {
        // ...existing code...
    }

    void Update()
    {
        // Cek semua observer, tampilkan nama/deskripsi observer yang aktif (pertama ditemukan)
        for (int i = 0; i < observers.Length; i++)
        {
            if (observers[i] != null && observers[i].GetMarker())
            {
                txtNama.text = namaObservers.Length > i ? namaObservers[i] : "";
                txtDeskripsi.text = deskripsiObservers.Length > i ? deskripsiObservers[i] : "";
                return; // Tampilkan hanya satu observer aktif
            }
        }
        // Jika tidak ada observer aktif, kosongkan UI
        txtNama.text = "";
        txtDeskripsi.text = "";
    }
}
