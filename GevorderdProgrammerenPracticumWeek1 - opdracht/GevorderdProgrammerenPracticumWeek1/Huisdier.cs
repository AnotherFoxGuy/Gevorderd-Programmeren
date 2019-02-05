// This file is part of GevorderdProgrammerenPracticumWeek1
// 
// Copyright (c) 2019 AnotherFoxGuy
// 
// GevorderdProgrammerenPracticumWeek1 is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License version 3, as
// published by the Free Software Foundation.
// 
// GevorderdProgrammerenPracticumWeek1 is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with GevorderdProgrammerenPracticumWeek1. If not, see <http://www.gnu.org/licenses/>.
// 

namespace GevorderdProgrammerenPracticumWeek1
{
    /// <summary>
    /// De Huisdier class
    /// </summary>
    public class Huisdier
    {
        private string naam;
        private string soort;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n">Naam</param>
        /// <param name="s">Soort</param>
        public Huisdier(string n, string s)
        {
            naam = n;
            soort = s;
        }

        /// <summary>
        /// Get de naam
        /// </summary>
        /// <returns>de naam</returns>
        public string GetNaam()
        {
            return naam;
        }

        /// <summary>
        /// Get de soort
        /// </summary>
        /// <returns>de soort</returns>
        public string GetSoort()
        {
            return soort;
        }

        /// <summary>
        /// Get de Beschrijving 
        /// </summary>
        /// <returns>de Beschrijving</returns>
        public string GetBeschrijving()
        {
            return $"{naam} {soort}";
        }
    }
}