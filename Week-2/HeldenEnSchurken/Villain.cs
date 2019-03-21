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
    /// <summary>
    /// The Villain class
    /// </summary>
    public class Villain : Person, IHasStrengths
    {
        private readonly List<Minion> _minions;
        private readonly List<string> _strengts;


        /// <summary>
        /// New Villain
        /// </summary>
        /// <param name="name">the nanme</param>
        /// <param name="ev">the evilness</param>
        public Villain(string name, int ev) : base(name, ev)
        {
            _strengts = new List<string>();
            _minions = new List<Minion>();
        }

        /// <summary>
        /// Add a strength
        /// </summary>
        /// <param name="strength">name of strength</param>
        public void AddStrengths(string strength)
        {
            _strengts.Add(strength);
        }

        /// <summary>
        /// Gat all strengts
        /// </summary>
        /// <returns>A List of strengts</returns>
        public List<string> GetStrengths()
        {
            return _strengts;
        }

        /// <summary>
        ///  Add a Minion
        /// </summary>
        /// <param name="m">the minion</param>
        public void AddMinion(Minion m)
        {
            _minions.Add(m);
        }

        /// <summary>
        ///  Get all minions
        /// </summary>
        /// <returns>A lsint of all minions</returns>
        public List<Minion> GetMinions()
        {
            return _minions;
        }
    }
}