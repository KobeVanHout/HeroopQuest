using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClass
{
    enum HeldType {Barbaar, Tovenaar, Dwerg, Elf }

    class Held
    {
        public string Naam { get; set; }

        public int MaxIntelligentie { get;private set; }

        public int HuidigIntelligentie { get; set; }

        public int MaxHealth { get;private set; }

        public int HuidigLichaam { get; set; }

        public HeldType HeroType { get; set; }

        public string Beschrijving{ get;private set; }

        public int AanvalDobbesteen { get; private set; } = 2;

        public int Verdediging { get; private set; } = 2;

        public int Loop { get; private set; } = 2;

    }
}
