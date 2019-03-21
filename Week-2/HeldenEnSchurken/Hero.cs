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
    public class Hero : Person, IHasStrengths
    {
        private Person _sidekick;
        private readonly Villain _archnemesis;

        private readonly List<string> _strengts;

        public Hero(string name, Villain archnemesis) : base(name)
        {
            this._archnemesis = archnemesis;
            _strengts = new List<string>();
        }

        public void AddStrengths(string strength)
        {
            _strengts.Add(strength);
        }

        public List<string> GetStrengths()
        {
            return _strengts;
        }

        public Villain GetArchnemesis()
        {
            return _archnemesis;
        }

        public void UpdateSidekick(Person s)
        {
            _sidekick = s;
        }

        public Person GetSidekick()
        {
            return _sidekick;
        }
    }
}