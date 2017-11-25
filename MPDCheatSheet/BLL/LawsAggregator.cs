using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BLL
{
    public class LawsAggregator : ILawAggregator
    {
        public IEnumerable<Charge> GetFelonyCharges()
        {
            return new List<Charge>
            {
                new Charge()
                {
                    Name = "First Degree Murder",
                    ArgSentence = 10,
                    Sentence = 40,
                    HasArgSentence = true

                },
                new Charge()
                {
                    Name = "Second Degree Murder",
                    ArgSentence = 10,
                    Sentence = 35,
                    HasArgSentence = true
                },
                new Charge()
                {
                    Name = "Attempted Murder",
                    ArgSentence = 10,
                    Sentence = 25,
                    HasArgSentence = true
                },
                new Charge()
                {
                    Name = "Voluntary Manslaughter",
                    Sentence = 20,
                    HasArgSentence = false
                },
                new Charge()
                {
                    Name = "Involuntary Manslaughter",
                    Sentence = 15,
                    HasArgSentence = false
                },
                new Charge()
                {
                    Name = "Vehicular Manslaughter",
                    Sentence = 15,
                    HasArgSentence = false
                },
                new Charge()
                {
                    Name = "Bank Robbery",
                    Sentence = 35,
                    HasArgSentence = false
                },
                new Charge()
                {
                    Name = "Robbery",
                    Sentence = 20,
                    HasArgSentence = true,
                    ArgSentence = 5
                },
                new Charge()
                {
                    Name = "Kidnapping",
                    Sentence = 25,
                    HasArgSentence = true,
                    ArgSentence = 10
                },
                 new Charge()
                {
                    Name = "Arson",
                    Sentence = 15,
                    HasArgSentence = false
                },
                 new Charge()
                {
                    Name = "Criminal Negligence",
                    Sentence = 15,
                    HasArgSentence = false
                },
                  new Charge()
                {
                    Name = "Weapons Stockpiling",
                    Sentence = 25,
                    HasArgSentence = true,
                    ArgSentence = 10,
                    HasAdditionalItems = true,
                    AdditionalSentence = 10
                },
                  new Charge()
                {
                    Name = "Weapons Caching",
                    Sentence = 20,
                    HasArgSentence = true,
                    ArgSentence = 10
                },
                   new Charge()
                {
                    Name = "Weapons Distribution",
                    Sentence = 25,
                },
                    new Charge()
                {
                    Name = "Weapons Trafficking",
                    Sentence = 25,
                    HasArgSentence = true,
                    ArgSentence = 10
                },
                new Charge()
                {
                    Name = "Possession of Explosives",
                    Sentence = 30,
                    HasArgSentence = true,
                    ArgSentence = 10
                },
                 new Charge()
                {
                    Name = "Possession of a Class 2 Firearm",
                    Sentence = 25,
                    HasArgSentence = true,
                    ArgSentence = 10
                },
                  new Charge()
                {
                    Name = "Possession of a Class 1 Firearm",
                    Sentence = 15,
                    HasArgSentence = true,
                    ArgSentence = 5
                },
                new Charge()
                {
                    Name = "Unlawful Discharge of a Firearm",
                    Sentence = 10,
                },
                 new Charge()
                {
                    Name = "Drug Cultivation and Manufacturing",
                    Sentence = 25,
                },
                new Charge()
                {
                    Name = "Class 2 Drug Distribution/Trafficking",
                    Sentence = 25,
                    HasArgSentence = true,
                    ArgSentence = 5
                },
                new Charge()
                {
                    Name = "Class 1 Drug Distribution/Trafficking",
                    Sentence = 10,
                    HasArgSentence = true,
                    ArgSentence = 5
                },
                new Charge()
                {
                    Name = "Corruption",
                    Sentence = 45,
                },
                new Charge()
                {
                    Name = "Bribery",
                    Sentence = 45,
                },
                new Charge()
                {
                    Name = "Extortion",
                    Sentence = 25,
                },
                new Charge()
                {
                    Name = "Money Laundering",
                    Sentence = 25,
                },
                new Charge()
                {
                    Name = "Racketeering / RICO",
                    Sentence = 25,
                },
                new Charge()
                {
                    Name = "Human Trafficking",
                    Sentence = 35,
                },
                new Charge()
                {
                    Name = "Organ Distribution/Trafficking",
                    Sentence = 35,
                    ArgSentence = 5,
                    HasAdditionalItems = true
                },
                new Charge()
                {
                    Name = "Grand Theft Auto",
                    Sentence = 15,
                },
                new Charge()
                {
                    Name = "Violation of a No Fly Zone",
                    Sentence = 15,
                },
                new Charge()
                {
                    Name = "Felony Improper Operation of a Motor Vehicle",
                    Sentence = 20,
                },
                 new Charge()
                {
                    Name = "Felony Driving Under the Influence",
                    Sentence = 25,
                },
                new Charge()
                {
                    Name = "Felony Evading Arrest",
                    Sentence = 20,
                },
                new Charge()
                {
                    Name = "False Impersonation of a Lawyer or Government Official",
                    Sentence = 15,
                },
                new Charge()
                {
                    Name = "Burglary",
                    Sentence = 15,
                },
                new Charge()
                {
                    Name = "Escaping Custody",
                    Sentence = 20,
                },
                new Charge()
                {
                    Name = "Obstruction of Justice",
                    Sentence = 25,
                },
                new Charge()
                {
                    Name = "Poaching",
                    Sentence = 20,
                    ArgSentence = 10,
                    HasArgSentence = true
                },
                new Charge()
                {
                    Name = "Perjury",
                    Sentence = 25,
                },
                new Charge()
                {
                    Name = "Terroristic Threat",
                    Sentence = 30,
                },
                new Charge()
                {
                    Name = "Jailbreak",
                    Sentence = 35,
                },

            };
        }

        public IEnumerable<Charge> GetMisdemeanorCharges()
        {
            return new List<Charge>
            {
                new Charge()
                {
                    Name = "Class 2 Drug Possession",
                    Sentence = 15
                },
                new Charge()
                {
                    Name = "Class 1 Drug Possession",
                    Sentence = 10
                },
                new Charge()
                {
                    Name = "Class 2 Drug Paraphernalia",
                    Sentence = 10
                },
                new Charge()
                {
                    Name = "Class 1 Drug Paraphernalia",
                    Sentence = 10
                },
                new Charge()
                {
                    Name = "Unlawful Consumption",
                    Sentence = 10
                },
                new Charge()
                {
                    Name = "Possession of Contraband",
                    Sentence = 10
                },
                new Charge()
                {
                    Name = "Illegal Ammunition",
                    Sentence = 1
                },
                new Charge()
                {
                    Name = "Possession of Organ(s)",
                    Sentence = 15
                },
                new Charge()
                {
                    Name = "Driving Under the Influence / Driving While Intoxicated (DUI / DWI)",
                    Sentence = 10
                },
                new Charge()
                {
                    Name = "Hit and Run",
                    Sentence = 10
                },
                new Charge()
                {
                    Name = "Evading Arrest",
                    Sentence = 10
                },
                new Charge()
                {
                    Name = "Improper Operation of a Motor Vehicle",
                    Sentence = 10
                },
                new Charge()
                {
                    Name = "Assault",
                    Sentence = 10,
                    ArgSentence = 5,
                    HasArgSentence = true
                },
                new Charge()
                {
                    Name = "Battery",
                    Sentence = 10,
                    ArgSentence = 5,
                    HasArgSentence = true
                },
                new Charge()
                {
                    Name = "Resisting Arrest",
                    Sentence = 10,
                },
                new Charge()
                {
                    Name = "Unlawful Discharge of a Firearm",
                    Sentence = 5,
                },
                new Charge()
                {
                    Name = "Trespassing on Restricted Government Soil",
                    Sentence = 10,
                },
                new Charge()
                {
                    Name = "Breaking and Entering",
                    Sentence = 10,
                },
                new Charge()
                {
                    Name = "Prostitution",
                    Sentence = 10,
                },
                new Charge()
                {
                    Name = "Stalking",
                    Sentence = 5,
                },
                new Charge()
                {
                    Name = "Possession of Stolen Goods",
                    Sentence = 10,
                },
                new Charge()
                {
                    Name = "False Report",
                    Sentence = 5,
                },
                new Charge()
                {
                    Name = "Conspiracy",
                    Sentence = 10,
                },
                new Charge()
                {
                    Name = "Violation of Probation",
                    Sentence = 10,
                },
                new Charge()
                {
                    Name = "Fleeing & Eluding",
                    Sentence = 10,
                },
                new Charge()
                {
                    Name = "Criminal Mischief",
                    Sentence = 10,
                },
                new Charge()
                {
                    Name = "Solicitation",
                    Sentence = 10,
                },
                new Charge()
                {
                    Name = "Disorderly Conduct",
                    Sentence = 5,
                },
                new Charge()
                {
                    Name = "Criminal Negligence",
                    Sentence = 10,
                },
                new Charge()
                {
                    Name = "Secret Listening Violation",
                    Sentence = 5,
                },
            };
        }

        public IEnumerable<Charge> MinorMisdemeanors()
        {
            return new List<Charge>
            {
                new Charge()
                {
                    Name = "Brandishing a Firearm",
                    Sentence = 4000
                },
                new Charge()
                {
                    Name = "Aggressive Driving",
                    Sentence = 5000
                },
                new Charge()
                {
                    Name = "Reckless Driving (41 km/h over)",
                    Sentence = 3000
                },
                new Charge()
                {
                    Name = "Excessive Speeding 3 (31-40 km/h over)",
                    Sentence = 1500
                },
                new Charge()
                {
                    Name = "Excessive Speeding 2 (21-30 km/h over)",
                    Sentence = 800
                },
                new Charge()
                {
                    Name = "Excessive Speeding (11-20 km/h over)",
                    Sentence = 700
                },
                new Charge()
                {
                    Name = "Speeding (5-10 km/h over)",
                    Sentence = 500
                },
                new Charge()
                {
                    Name = "Disturbing the Peace",
                    Sentence = 100
                },
                new Charge()
                {
                    Name = "Failure to Yield to an Emegency Vehicle",
                    Sentence = 2000
                },
                new Charge()
                {
                    Name = "Unlawful Solicitation",
                    Sentence = 1000
                },
                new Charge()
                {
                    Name = "Larceny",
                    Sentence = 3000
                },
                new Charge()
                {
                    Name = "Failure to Stop",
                    Sentence = 800
                },
                new Charge()
                {
                    Name = "Criminal Mischief",
                    Sentence = 1000
                },
                new Charge()
                {
                    Name = "Operating a Vehicle without a License",
                    Sentence = 5000
                },
                new Charge()
                {
                    Name = "Operation of a Non-Street Legal Vehicle",
                    Sentence = 2000
                },
                new Charge()
                {
                    Name = "Illegal Parking",
                    Sentence = 200
                },
                new Charge()
                {
                    Name = "Excessive Vehicle Noise",
                    Sentence = 100
                },
                new Charge()
                {
                    Name = "Driving without Proper Use of Headlights",
                    Sentence = 250
                },
                new Charge()
                {
                    Name = "Illegal U-turn",
                    Sentence = 150
                },
                new Charge()
                {
                    Name = "Loitering",
                    Sentence = 30
                },
                new Charge()
                {
                    Name = "Public Intoxication",
                    Sentence = 80
                },
                new Charge()
                {
                    Name = "Failure to Yield",
                    Sentence = 500
                },
                new Charge()
                {
                    Name = "Indecent Exposure",
                    Sentence = 60
                },
                new Charge()
                {
                    Name = "Fishing without proper Licensure",
                    Sentence = 60
                },
                new Charge()
                {
                    Name = "Obstructing Traffic",
                    Sentence = 60
                },
            };
        }
    }
}
