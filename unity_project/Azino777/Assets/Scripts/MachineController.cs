using TMPro;
using UnityEngine;

public class MachineController : MonoBehaviour
{
    [SerializeField] private Slot[] slots;
    [SerializeField] private TMP_Text sumText;
    private int _i = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Stop()
    {
        if (_i < slots.Length)
        {
            slots[_i].Stop();
            _i++;
        }
    }
}
