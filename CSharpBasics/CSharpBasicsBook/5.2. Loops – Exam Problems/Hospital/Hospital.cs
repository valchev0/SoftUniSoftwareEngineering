using System;

namespace Hospital
{
    internal class Hospital
    {
        static void Main(string[] args)
        {
            // a doctor - only one patient a day
            // 7 doctors total
            // every 3 days the hospital make a revision - if it's needed employment a new doctor
            int doctors = 7;
            int period = int.Parse(Console.ReadLine());
            int untreatedPatients = 0;
            int treatedPatients = 0;
            int counterDays = 0;
            for (int days = 1; days <= period; days++)
            {
                counterDays++;
                int patients = int.Parse(Console.ReadLine());
                if (counterDays == 3)
                {
                    if (untreatedPatients > treatedPatients)
                    {
                        doctors++;
                    }
                    counterDays = 0;
                }
                if (patients > doctors)
                {
                    untreatedPatients += (patients - doctors);
                    treatedPatients += doctors;
                }
                else
                {
                    treatedPatients += patients;
                }
            }
            Console.WriteLine("Treated patients: {0}.", treatedPatients);
            Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
        }
    }
}