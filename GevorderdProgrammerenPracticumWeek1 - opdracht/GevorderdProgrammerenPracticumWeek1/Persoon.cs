using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GevorderdProgrammerenPracticumWeek1
{
    /// <summary>
    /// De Persoon class
    /// </summary>
    class Persoon
    {
        private string voornaam;
        
        private string achternaam;
        
        private int leeftijd;
        private List<Huisdier> huisdieren;

        /// <summary>
        /// Nieuw Persoon
        /// </summary>
        /// <param name="voornaam">voornaam</param>
        /// <param name="achternaam">achternaam</param>
        /// <param name="leeftijd">leeftijd</param>
        public Persoon(string voornaam = null, string achternaam = null, int leeftijd = default)
        {
            this.voornaam = voornaam;
            this.achternaam = achternaam;
            this.leeftijd = leeftijd;
            huisdieren = new List<Huisdier>();
        }

        /// <summary>
        ///  Get de Naam van de persoon
        /// </summary>
        /// <returns></returns>
        public string GetNaam()
        {
            return $"{voornaam} {achternaam}";
        }

        /// <summary>
        ///  Get all de Huisdier
        /// </summary>
        /// <returns>List met alle huisdier</returns>
        public List<Huisdier> GetHuisdieren()
        {
            return huisdieren;
        }

        /// <summary>
        /// Add een huisdier
        /// </summary>
        /// <param name="huisdier">New huisdier</param>
        public void AddHuisdier(Huisdier huisdier)
        {
            huisdieren.Add(huisdier);
        }

        /// <summary>
        /// Get de Leeftijd
        /// </summary>
        /// <returns>De Leeftijd</returns>
        public int GetLeeftijd()
        {
            return leeftijd;
        }
    }
}
