using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copypaste : MonoBehaviour {

    public void CopyPaste()
    {
        UniClipboard.SetText("HEST DEMOTEKST www.hestedemo.dk");
    }
}
