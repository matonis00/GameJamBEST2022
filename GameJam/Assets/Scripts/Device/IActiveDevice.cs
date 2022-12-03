using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class IActiveDevice : MonoBehaviour
{
    public UnityEvent onPowerUpEvent;
    public UnityEvent isPoweredEvent;
    public UnityEvent isNotPoweredEvent;

    protected int powerLevel;
    protected int maxPowerLevel;
    protected int requiredPower;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void Update()
    {

    }

    public int getPowerLelvel()
    {
        return powerLevel;
    }
    public int getMaxPowerLelvel()
    {
        return maxPowerLevel;
    }

    public void Active()
    {
        Debug.Log("w��czylem urzadzenie i odjo�em pront");
        onPowerUpEvent.Invoke();
        powerLevel++;
        ActivateDevice();
    }

    virtual public void ActivateDevice()
    {
    }

}