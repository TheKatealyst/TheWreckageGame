using UnityEngine;

public class MermationControl : MonoBehaviour
{
    Animator mermator;
    private bool IsSwimming;

    void Start()
    {
        mermator = GetComponent<Animator>();
        IsSwimming = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.D))
        {
            IsSwimming = true;
        }
        else if(Input.GetKey(KeyCode.F))
        {
            IsSwimming = false;
        }
    }
}
