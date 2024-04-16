namespace Mediatheque.Core.Model
{

    public class CD : ObjetDePret
    {
        public string Groupe { get; set; }

        public DateTime DateDeSortie { get; set; }

        public CD() : base("")
        {
        }
        public CD(string titreDeLObjet, string groupe) : base(titreDeLObjet)
        {
        }

    }
}
