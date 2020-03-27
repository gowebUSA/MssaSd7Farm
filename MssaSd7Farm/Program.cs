using System;

namespace MssaSd7Farm
{//ref: guru99.com/c-sharp-class-object.html
    public class Horse
    {
        //Make properties for EX 10A C^N ---------------------------------------------------------------------
        //string horseName;
        //string horseSpeak;
        //int horseLegs;
        //public void SetHorse(string hrName, string hrSpeak, int hrLegs)
        //{
        //    horseName = hrName;
        //    horseSpeak = hrSpeak;
        //    horseLegs = hrLegs;

        //}
        private string horseName;
        private string horseSpeak;
        private int horseLegs = 4;
        public string SetHorseName 
            { 
            get => this.horseName; 
            set => this.horseName = value; 
            }
        public string SetHorseSpeak
        {
            get => this.horseSpeak;
            set => this.horseSpeak = value;
        }
        public int SetHorseLegs
        {
            get => this.horseLegs;
        }
        public string GetHorseName()
        {
            return horseName;
        }
        public string GetHorseSpeak()
        {
            return horseSpeak;
        }
        public int GetHorseLegs()
        {
            return horseLegs;
        }
    }
    class Cow
    {
        string cowName;
        string cowSpeak;
        int cowLegs;
        public void SetCow(string coName, string coSpeak, int coLegs)
        {
            cowName = coName;
            cowSpeak = coSpeak;
            cowLegs = coLegs;

        }
        public string GetCowName()
        {
            return cowName;
        }
        public string GetCowSpeak()
        {
            return cowSpeak;
        }
        public int GetCowLegs()
        {
            return cowLegs;
        }
    }
    class Pig
    {
        string pigName;
        string pigSpeak;
        int pigLegs;
        public void SetPig(string pgName, string pgSpeak, int pgLegs)
        {
            pigName = pgName;
            pigSpeak = pgSpeak;
            pigLegs = pgLegs;
            
        }
        public string GetPigName()
        {
            return pigName;
        }
        public string GetPigSpeak()
        {
            return pigSpeak;
        }
        public int GetPigLegs()
        {
            return pigLegs;
        }
    }
    class Chicken
    {
        string chickName;
        string chickSpeak;
        int chickLegs;
        public void SetChicken(string chName, string chspeak, int chlegs)
            {
                chickName = chName;
                chickSpeak = chspeak;
                chickLegs = chlegs;

            }
        public string GetChickenName()
        {
            return chickName;
        }
        public string GetChickenSpeak()
        {
            return chickSpeak;
        }
        public int GetChickenLegs()
        {
            return chickLegs;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("MSSA SD7 Farm.Program.Main()\n\n");
        {
            Chicken mrLittle = new Chicken();
            mrLittle.SetChicken("Mr. Little", "cluck", 2);
            Chicken rooster = new Chicken();
            rooster.SetChicken("Mr. Rooster", "cock-a-doodle-do", 1);
                Console.WriteLine(
                $"{mrLittle.GetChickenName()} is a chicken that says {mrLittle.GetChickenSpeak()} and has {mrLittle.GetChickenLegs()} legs.\n" +
                $"{rooster.GetChickenName()} on the other hand says {rooster.GetChickenSpeak()} and he only has {rooster.GetChickenLegs()} leg.\n"
                );
        }
        {
                //EX 10A C^N----------------------------------------------------------------------------------
                //Horse mrEd = new Horse();
                //mrEd.SetHorseName = "Mr. Ed";
                //mrEd.SetHorseSpeak = "neighehehee";
                //mrEd.SetHorseLegs = 4;
                //Simplified
                Horse mrEd = new Horse
                {
                    SetHorseName = "Mr. Ed",
                    SetHorseSpeak = "neighehehee",
                    //GetHorseLegs() is read only.
                };
                Console.WriteLine(
                $"{mrEd.GetHorseName()} is a racing horse that {mrEd.GetHorseSpeak()} when he runs and has {mrEd.GetHorseLegs()} legs.\n"
                );
        }
        {
            Cow bigMac = new Cow();
            bigMac.SetCow("Big Mac", "mooh", 4);
            Console.WriteLine(
                $"{bigMac.GetCowName()} wakes up in the morning and says {bigMac.GetCowSpeak()}. He stands on his {bigMac.GetCowLegs()} legs.\n"
                );
        }
        {
            Pig porkChop = new Pig();
            porkChop.SetPig("Piglett", "Oink", 1);
            Console.WriteLine(
                $"I saw {porkChop.GetPigName()} walking down the isle {porkChop.GetPigSpeak()}ing. She injured her {porkChop.GetPigLegs()} leg.\n"
                );
        }

        }
    }
}
