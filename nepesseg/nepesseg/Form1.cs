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

        Random rng = new Random();

        public Form1()
        {
            InitializeComponent();

            csvpathtxt.Text = "E:\\Documents\\IRF\\VersionControl\\nép-teszt.csv";
            Population = GetPopulation(@"E:\Documents\IRF\VersionControl\nép-teszt.csv");

            BirthProbabilities = GetBirthProbalities(@"E:\Documents\IRF\VersionControl\születés.csv");
            DeathProbabilities = GetDeathProbabilities(@"E:\Documents\IRF\VersionControl\halál.csv");
          

            
        }

        private void simulate(int zaroev)
        {
            for (int year = 2005; year <= zaroev; year++)
            {
                for (int i = 0; i < Population.Count; i++)
                {
                    SimStep(year, Population[i]);
                }

                int nbrOfMales = (from x in Population
                                  where x.Gender == Gender.Male && x.IsAlive
                                  select x).Count();
                int nbrOfFemales = (from x in Population
                                    where x.Gender == Gender.Female && x.IsAlive
                                    select x).Count();
                /*Console.WriteLine(
                    string.Format("Év:{0} Fiúk:{1} Lányok:{2}", year, nbrOfMales, nbrOfFemales));*/
                eredmenytxt.Text = eredmenytxt.Text + string.Format("Szimulációs év:{0}" + Environment.NewLine + "\t" + " Fiuk:{1}" + Environment.NewLine + "\t" + " Lányok:{2}" + Environment.NewLine, year, nbrOfMales, nbrOfFemales);

            }
        }

        private void SimStep(int year, Person person)
        {

            if (!person.IsAlive) return;


            byte age = (byte)(year - person.BirthYear);


            double pDeath = (from x in DeathProbabilities
                             where x.gender == person.Gender && x.Age == age
                             select x.P).FirstOrDefault();

            if (rng.NextDouble() <= pDeath)
                person.IsAlive = false;


            if (person.IsAlive && person.Gender == Gender.Female)
            {

                double pBirth = (from x in BirthProbabilities
                                 where x.Age == age
                                 select x.P).FirstOrDefault();

                if (rng.NextDouble() <= pBirth)
                {
                    Person újszülött = new Person();
                    újszülött.BirthYear = year;
                    újszülött.NbrOfChildren = 0;
                    újszülött.Gender = (Gender)(rng.Next(1, 3));
                    Population.Add(újszülött);
                }
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

        private void browsebtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = false;

            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                csvpathtxt.Text = choofdlog.FileName.ToString();

            }
            Population = GetPopulation(choofdlog.FileName);
        }

        private void startbtn_Click(object sender, EventArgs e)
        {
            eredmenytxt.Text = "";
            simulate(int.Parse(zaroev.Value.ToString()));
            
        }
    }
}
