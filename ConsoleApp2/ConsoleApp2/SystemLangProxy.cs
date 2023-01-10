using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using OHCE;
    
namespace OHCE.Console
{
    internal class SystemLangProxy : OHCE.ILangue
    {
        public string GetLanguage()
        {
            return CultureInfo.InstalledUICulture.TwoLetterISOLanguageName;
        }

        public string DireBonjour()
        {
            switch(this.GetLanguage())
            {
                case "fr":
                    return "Bonjour";
                // case "it":
                    // return "Bonjourno";
            }

            return "Hello";
        }

        public string DireBonsoir()
        {
            switch (this.GetLanguage())
            {
                case "fr":
                    return "Bonsoir";
            }

            return "Good evening";
        }

        public string Inviter()
        {
            switch (this.GetLanguage())
            {
                case "fr":
                    return "Entrez un mot pour savoir si c'est un palindrome";
            }

            return "Enter a word to check if it's a palindrome";
        }

        public string BienDit()
        {
            switch (this.GetLanguage())
            {
                case "fr":
                    return "Bien dit !";
            }

            return "Well said !";
        }

        public string MalDit()
        {
            switch(this.GetLanguage())
            {
                case "fr":
                    return "Ceci n'est pas un palindrome.";
            }

            return "This is not a palindrome...";
        }

        public string AuRevoir()
        {
            switch (this.GetLanguage())
            {
                case "fr":
                    return "Au revoir !";
            }

            return "Bye !";
        }
    }
}
