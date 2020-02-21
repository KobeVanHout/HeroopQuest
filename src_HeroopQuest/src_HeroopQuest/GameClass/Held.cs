using System;
using System.Collections.Generic;
using System.Text;

namespace src_HeroopQuest.GameClass
{
    enum HeldType {Barbaar, Tovenaar, Dwerg, Elf }

    class Held
    {
        public Held(HeldType type, string naam)
        {
            Naam = naam;
            HeroType = type;
            switch (type)
            {
                case HeldType.Barbaar:
                    AanvalDobbesteen = 3;
                    MaxIntelligentie = 2;
                    MaxHealth = 8;
                    break;
                case HeldType.Tovenaar:
                    AanvalDobbesteen = 1;
                    MaxIntelligentie = 6;
                    MaxHealth = 4;
                    break;
                case HeldType.Dwerg:
                    MaxIntelligentie = 3;
                    MaxHealth = 7;
                    break;
                case HeldType.Elf:
                    MaxIntelligentie = 4;
                    MaxHealth = 6;
                    break;
                default:
                    break;
            }
            HuidigIntelligentie = MaxIntelligentie;
            HuidigLichaam = MaxHealth;
        }

        public string Naam { get; set; }

        public int MaxIntelligentie { get;private set; }

        public int HuidigIntelligentie { get; set; }

        public int MaxHealth { get;private set; }

        public int HuidigLichaam { get; set; }

        public HeldType HeroType { get;private set; }

        public string Beschrijving{ get;private set; }

        public int AanvalDobbesteen { get; private set; } = 2;

        public int VerdedigingDobbesteen { get; private set; } = 2;

        public int LoopDobbesteen { get; private set; } = 2;

    }
}
