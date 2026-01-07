using System;

class ClinicApp
{
    static void Main()
    {
        Patient[] patients = new Patient[2];

        patients[0] = CreateInPatient();
        patients[1] = CreateOutPatient();

        Console.WriteLine("\n--- BILL SUMMARY ---");
        ShowBills(patients);
    }

    static Patient CreateInPatient()
    {
        Console.WriteLine("In-Patient Entry");

        int days = int.Parse(Ask("Days Admitted: "));
        double dailyRate = double.Parse(Ask("Daily Rate: "));

        InPatient ip = new InPatient(days, dailyRate);
        FillCommonDetails(ip);

        return ip;
    }

    static Patient CreateOutPatient()
    {
        Console.WriteLine("\nOut-Patient Entry");

        double fee = double.Parse(Ask("Consultation Fee: "));

        OutPatient op = new OutPatient(fee);
        FillCommonDetails(op);

        return op;
    }

    static void FillCommonDetails(Patient patient)
    {
        patient.PatientId = int.Parse(Ask("Patient ID: "));
        patient.PatientName = Ask("Patient Name: ");
        patient.Age = int.Parse(Ask("Age: "));
        patient.AddRecord(Ask("Diagnosis: "));
    }

    static void ShowBills(Patient[] patients)
    {
        foreach (Patient p in patients)
        {
            p.GetPatientDetails();
            Console.WriteLine("Total Bill: " + p.CalculateBill());

            if (p is IMedicalRecord record)
            {
                record.ViewRecords();
            }

            Console.WriteLine();
        }
    }

    static string Ask(string msg)
    {
        Console.Write(msg);
        return Console.ReadLine();
    }
}