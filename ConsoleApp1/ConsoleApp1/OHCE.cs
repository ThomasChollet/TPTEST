using System.Text;

namespace OHCE
{
    public class Ohce
    {
        private readonly ILangue _langue;
        private readonly PériodeJournée _périodeJournée;

        public Ohce(ILangue langue, PériodeJournée périodeJournée)
        {
            _langue = langue;
            _périodeJournée = périodeJournée;
        }

        public string Palindrome(string input)
        {
            var stringBuilder = new StringBuilder();

            var reversed = new string(
                input.Reverse().ToArray()
            );

            if (reversed.Equals(input))
                stringBuilder.Append( this._langue.BienDit());
            else 
                stringBuilder.Append(this._langue.MalDit());


            stringBuilder.Append(this._langue.AuRevoir());

            return stringBuilder.ToString(); 
        }

        public string Saluer()
        {
            if(_périodeJournée._date.TimeOfDay.Hours > 18)
            {
                return this._langue.DireBonsoir();
            }

            return this._langue.DireBonjour();
        }

        public string Inviter()
        {
            return this._langue.Inviter();
        }
    }
}
