using System;
using System.IO;
using System.Collections.Generic;

class KutyaNev
{
    private int id;
    private string nev;

    public string Nev
    {
        get { return nev; }
    }

    public KutyaNev(int id, string nev)
    {
        this.id = id;
        this.nev = nev;
    }
}


