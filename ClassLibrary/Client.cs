﻿namespace ClassLibrary
{
    public class Client
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        public Client(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
        }

        public override string ToString()
        {
            return $"{Achternaam.ToUpperInvariant()} {Voornaam}";
        }
    }
}
