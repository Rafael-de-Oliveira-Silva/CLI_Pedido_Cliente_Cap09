using System;
using System.Globalization;

namespace Exercicio_Fixacao_Cap09.Entities
{
    class Client
    {
        private string Name { get; set; }

        private string Email { get; set; }

        private DateTime BirthDate { get; set; }

        public Client(string name, string email, DateTime birthDate)
        {
            this.Name = name;
            this.Email = email;
            this.BirthDate = birthDate;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetEmail()
        {
            return Email;
        }

        public DateTime GetBirthDate()
        {
            return BirthDate;
        }

        public override string ToString()
        {
            return Name+" ("+BirthDate.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture)+") - "+Email;
        }
    }
}
