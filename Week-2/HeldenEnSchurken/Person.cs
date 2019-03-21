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

namespace HeldenEnSchurken
{
    /// <summary>
    /// The Person class
    /// </summary>
    public class Person
    {
        private readonly int _evilness;
        private string _name;

        /// <summary>
        /// Person consturctor
        /// </summary>
        /// <param name="n">Name</param>
        /// <param name="evilness">evilness</param>
        public Person(string n = "", int evilness = 55)
        {
            this._name = n;

            if (evilness > 100 || evilness < 0)
                evilness = 50;
            
            this._evilness =  evilness;
        }

        /// <summary>
        /// Get the Name
        /// </summary>
        /// <returns> the name</returns>
        public string GetName()
        {
            return _name;
        }

        /// <summary>
        /// Get the evilness
        /// </summary>
        /// <returns>The evilness</returns>
        public int GetEvilness()
        {
            return _evilness;
        }
    }
}