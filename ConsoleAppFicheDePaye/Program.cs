namespace ConsoleAppFicheDePaye
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //employé
            Console.WriteLine("Quel est votre prenom ?");
            string prenom = Console.ReadLine();
            Console.WriteLine("Quel est votre nom ?");
            string nom = Console.ReadLine();
            Console.WriteLine("Quel est votre nombre d'heures travaillées ?");
            decimal heures = Convert.ToDecimal(Console.ReadLine());
            decimal tauxHoraire = 12.31m; // change en fonction du poste et de l'ancienneté
            decimal salaireBrut = heures * tauxHoraire;
            // santé
            decimal CompSantéSalarié = 20.0m;
            // retraite
            decimal CompRetraite = salaireBrut * 0.0315m;
            decimal Vieillesse = salaireBrut * 0.073m;
            decimal ContribEquiGen = salaireBrut * 0.0086m;
            // contribution sociale
            decimal CSGdeductible = salaireBrut * 0.068m;
            decimal CSGnonDeductible = salaireBrut * 0.024m;
            decimal CRDS = salaireBrut * 0.05m;
            decimal totalRetenue = CompSantéSalarié + CompRetraite + Vieillesse + ContribEquiGen + CSGdeductible + CSGnonDeductible + CRDS;
            // employeur
            // santé
            decimal maladie = salaireBrut * 0.073m;
            decimal compSantéEmployeur = 20.0m;
            // accident de travail et maladie professionelles
            decimal cotisAccdient = salaireBrut * 0.0224m;
            // retraite 
            decimal VieilesseEmployeur = salaireBrut * 0.1045m;
            decimal retraiteComp = salaireBrut * 0.0472m;
            decimal contribEquilGenemployeur = salaireBrut * 0.0129m;
            // famille 
            decimal allocationFami = salaireBrut * 0.0345m;
            decimal contribRegimGarantieSalaire = salaireBrut * 0.015m;
            // formation
            decimal formationPro = salaireBrut * 0.055m;
            decimal taxeApprentissage = salaireBrut * 0.068m;
            decimal contribDialogueSocial = salaireBrut * 0.002m;
            // salaire 
            decimal salaireNet = salaireBrut + CompSantéSalarié + CompRetraite + Vieillesse + ContribEquiGen + CSGdeductible + CSGnonDeductible + CRDS;
            decimal montantTotal = salaireBrut + maladie + compSantéEmployeur + cotisAccdient + VieilesseEmployeur + retraiteComp + contribEquilGenemployeur + allocationFami + contribRegimGarantieSalaire + formationPro + taxeApprentissage + contribDialogueSocial;
            decimal exoneration = salaireBrut * 0.032m;
            Console.WriteLine("Fiche de paie association AAD");
            Console.WriteLine("Nom : {0}", nom);
            Console.WriteLine("Prenom : {0}", prenom);
            Console.WriteLine("Nombre d'heures travaillées : {0}", heures);
            Console.WriteLine("taux horaire : {0}", tauxHoraire);
            Console.WriteLine("Salaire brut : {0}", salaireBrut);
            Console.WriteLine("cotisation salariale");           
            Console.WriteLine("Contribution santé salarié : {0}", CompSantéSalarié);
            Console.WriteLine("Contribution retraite : {0}", CompRetraite);
            Console.WriteLine("Contribution vieillesse : {0}", Vieillesse);
            Console.WriteLine("Contribution équité générale : {0}", ContribEquiGen);
            Console.WriteLine("Contribution sociale déductible : {0}", CSGdeductible);
            Console.WriteLine("Contribution sociale non déductible : {0}", CSGnonDeductible);
            Console.WriteLine("Contribution sociale CRDS : {0}", CRDS);
            Console.WriteLine("total cotisations : {0}", totalRetenue);
            Console.WriteLine("cotisation employeur");
            Console.WriteLine("Contribution santé employeur : {0}", compSantéEmployeur);
            Console.WriteLine("Contribution retraite employeur : {0}", retraiteComp);
            Console.WriteLine("Contribution vieillesse employeur : {0}", VieilesseEmployeur);
            Console.WriteLine("Contribution équité générale employeur : {0}", contribEquilGenemployeur);
            Console.WriteLine("Allocation familiale : {0}", allocationFami);
            Console.WriteLine("Contribution régime de garantie salaire : {0}", contribRegimGarantieSalaire);
            Console.WriteLine("Formation professionnelle : {0}", formationPro);
            Console.WriteLine("Taxe d'apprentissage : {0}", taxeApprentissage);
            Console.WriteLine("Contribution dialogue social : {0}", contribDialogueSocial);
            

        }
    }
}