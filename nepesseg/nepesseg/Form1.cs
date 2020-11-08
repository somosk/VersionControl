using nepesseg.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nepesseg
{
    public partial class Form1 : Form
    {
        List<Person> Population = new List<Person>();
        List<BirthProbability> BirthProbabilities = new List<BirthProbability>();
        List<DeathProbability> DeathProbabilities = new List<DeathProbability>();

        Random rng = new Random(1234);

        public Form1()
        {
            InitializeComponent();

            Population = GetPopulation(@"E:\Documents\IRF\VersionControl\nép-teszt.csv");
          
            BirthProbabilities = GetBirthProbalities(@"E:\Documents\IRF\VersionControl\születés.csv");
            DeathProbabilities = GetDeathProbabilities(@"E:\Documents\IRF\VersionControl\halál.csv");
            dataGridView1.DataSource = Population;
            dataGridView2.DataSource = BirthProbabilities;
            dataGridView3.DataSource = DeathProbabilities;

            for (int year = 2005; year <= 2024; year++)
            {
                for (int i = 0; i < Population.Count; i++)
                {
                    // Ide jön a szimulációs lépés
                }

                int nbrOfMales = (from x in Population
                                  where x.Gender == Gender.Male && x.IsAlive
                                  select x).Count();
                int nbrOfFemales = (from x in Population
                                    where x.Gender == Gender.Female && x.IsAlive
                                    select x).Count();
                Console.WriteLine(
                    string.Format("Év:{0} Fiúk:{1} Lányok:{2}", year, nbrOfMales, nbrOfFemales));
            }
        }

        private List<DeathProbability> GetDeathProbabilities(string csvpath)
        {
            List<DeathProbability> halVals = new List<DeathProbability>();
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    halVals.Add(new DeathProbability()
                    {
                        gender = (Gender)Enum.Parse(typeof(Gender), line[0]),
                        Age = int.Parse(line[1]),
                        P = double.Parse(line[2])

                    });
                }
            }
            return halVals;
        }

        private List<BirthProbability> GetBirthProbalities(string csvpath)
        {
            List<BirthProbability> szulVals = new List<BirthProbability>();
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    szulVals.Add(new BirthProbability()
                    {
                        Age = int.Parse(line[0]),
                        NumberOfChilden = byte.Parse(line[1]),
                        P = double.Parse(line[2])

                    });
                }
            }
            return szulVals; ;
        }

        private List<Person> GetPopulation(string csvpath)
        {
            List<Person> Population = new List<Person>();
            using (StreamReader sr = new StreamReader(csvpath, Encoding.Default))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine().Split(';');
                    Population.Add(new Person()
                    {
                        BirthYear = int.Parse(line[0]),
                        Gender = (Gender)Enum.Parse(typeof(Gender), line[1]),
                        NbrOfChildren = int.Parse(line[2])
                    });
                }
            }
            return Population;
        }
    }
}
