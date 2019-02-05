// This file is part of HeldenEnSchurken
// 
// Copyright (c) 2019 AnotherFoxGuy
// 
// HeldenEnSchurken is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License version 3, as
// published by the Free Software Foundation.
// 
// HeldenEnSchurken is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with HeldenEnSchurken. If not, see <http://www.gnu.org/licenses/>.
// 

using System.Collections.Generic;

namespace HeldenEnSchurken
{
    public class Villain: Person,IHasStrengths
    {
        private List<Minion> minions;
        private List<string> strengts;
        private int evilness;

        public Villain(string name, int evilness)
        {
            this.name = name;
            if (evilness > 100)
                evilness = 50;
            this.evilness = evilness;
            strengts = new List<string>();
            minions = new List<Minion>();
        }


        public void AddMinion(Minion m)
        {
            minions.Add(m);
        }


        public List<Minion> GetMinions()
        {
            return minions;
        }

        public void AddStrengths(string strength)
        {
            strengts.Add(strength);
        }

        public List<string> GetStrengths()
        {
            return strengts;
        }

        public int getEvilness()
        {
            return evilness;
        }
    }
}