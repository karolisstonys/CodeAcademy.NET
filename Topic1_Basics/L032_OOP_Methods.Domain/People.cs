using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L032_OOP_Methods.Domain
{    
    /*
    Access Modifiers (Prieinamumo modifikuotojai)
     
    public: Tipą ar narį galima pasiekti naudojant bet kurį kitą kodą tame pačiame assembly kode ar kitame assembly, kuris jį referuoja.
    private: Tipą ar narį galima pasiekti tik pagal kodą toje pačioje klasėje (ar struktūroje).
    internal: Tipą ar narį galima pasiekti naudojant bet kurį kodą tame pačiame assembly(Projekto) kode, bet ne iš kito assembly kodo.
    protected: (Eisim kada prieisime paveldimumo/inheritence tema)
    */

    internal class People
    {        
        public string Name { get; set; }
    }
}
