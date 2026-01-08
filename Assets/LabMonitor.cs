using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;

public class LabMonitor : MonoBehaviour
{
  [SerializeField] private TextMeshProUGUI displayLabel;

  // XRI 3.0 uses SelectEnterEventArgs
  public void UpdateMonitorOnGrab(SelectEnterEventArgs args)
  {
    displayLabel.text = "OBJECT DETECTED: <color=green>SECURED</color>";
    Debug.Log("Specimen identified by Lab System.");
  }
  public void ResetMonitorOnDrop(SelectExitEventArgs args)
  {
    displayLabel.text = "SCANNING...";
  }
}