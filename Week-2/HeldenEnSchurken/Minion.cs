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
    public class Minion: Person
    {
        private string weakness;

        public string GetWeakness()
        {
            return weakness;
        }

        public Minion(string weakness)
        {
            this.weakness = weakness;
        }
    }
}