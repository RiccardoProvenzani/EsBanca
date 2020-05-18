using System;
using System.Collections.Generic;
using System.Text;

namespace Banca
{
    public class Intestatario
    {
        private string nomeCompleto { get; } // nome dell'intestatario
		private DateTime dataNascita { get; } // data nascita dell'intestatario
		private string indirizzo { get; } // indirizzo dell'intestatario 
		private string email { get; } // e-mail dell'intestatario

		/// <summary>
		/// costruttore
		/// </summary>
		/// <param name="nomeCompleto_"></param>
		/// <param name="dataNascita_"></param>
		/// <param name="indirizzo_"></param>
		/// <param name="email_"></param>
		public Intestatario(string nomeCompleto_, DateTime dataNascita_, string indirizzo_, string email_)
        {
            nomeCompleto = nomeCompleto_;
            dataNascita = dataNascita_;
            indirizzo = indirizzo_;
            email = email_;
        }
    }
}
