public delegate double BillingStrategy(double baseAmount);

public class PatientEventArgs : EventArgs
{
    public string Message { get; set; }
}


public abstract class Patient
{
    public string Name { get; set; }
    public int Age { get; set; }

    public double BaseTreatmentCost { get; set; }

    
    public event EventHandler<PatientEventArgs> PatientAdmitted;

    public Patient(string name, int age, double baseCost)
    {
        Name = name;
        Age = age;
        BaseTreatmentCost = baseCost;
    }

    
    public double CalculateBill(BillingStrategy strategy)
    {
        return strategy(BaseTreatmentCost);
    }

    
    public void Admit()
    {
        OnPatientAdmitted($"{Name} has been admitted.");
    }

    protected virtual void OnPatientAdmitted(string message)
    {
        PatientAdmitted?.Invoke(this, new PatientEventArgs() { Message = message });
    }

    
    public abstract void DisplayPatientType();
}


public class InPatient : Patient
{
    public InPatient(string name, int age, double baseCost)
        : base(name, age, baseCost) { }

    public override void DisplayPatientType()
    {
        Console.WriteLine("Patient Type: In-Patient");
    }
}

public class OutPatient : Patient
{
    public OutPatient(string name, int age, double baseCost)
        : base(name, age, baseCost) { }

    public override void DisplayPatientType()
    {
        Console.WriteLine("Patient Type: Out-Patient");
    }
}

public class EmergencyPatient : Patient
{
    public EmergencyPatient(string name, int age, double baseCost)
        : base(name, age, baseCost) { }

    public override void DisplayPatientType()
    {
        Console.WriteLine("Patient Type: Emergency Patient");
    }
}


public class HospitalNotifier
{
    public void OnPatientAdmitted(object sender, PatientEventArgs e)
    {
        Console.WriteLine($"[Notification to Departments]: {e.Message}");
    }
}


class Program
{
    static void Main()
    {
        HospitalNotifier notifier = new HospitalNotifier();

        Console.WriteLine("=== Hospital Patient Management System ===");
        Console.Write("Enter patient name: ");
        string name = Console.ReadLine();

        Console.Write("Enter patient age: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write("Enter base treatment cost: ");
        double baseCost = double.Parse(Console.ReadLine());

        Console.WriteLine("Select Patient Type: 1. In-Patient  2. Out-Patient  3. Emergency");
        int choice = int.Parse(Console.ReadLine());

        Patient patient = null;

        switch (choice)
        {
            case 1: patient = new InPatient(name, age, baseCost); break;
            case 2: patient = new OutPatient(name, age, baseCost); break;
            case 3: patient = new EmergencyPatient(name, age, baseCost); break;
            default:
                Console.WriteLine("Invalid choice");
                return;
        }

        
        patient.PatientAdmitted += notifier.OnPatientAdmitted;

        
        patient.Admit();
        patient.DisplayPatientType();

        
        BillingStrategy regularBilling = amount => amount;
        BillingStrategy discountBilling = amount => amount * 0.9;
        BillingStrategy emergencyBilling = amount => amount * 1.5;

        BillingStrategy appliedStrategy = regularBilling;

        
        if (patient is InPatient)
            appliedStrategy = discountBilling;
        else if (patient is EmergencyPatient)
            appliedStrategy = emergencyBilling;

        
        double finalBill = patient.CalculateBill(appliedStrategy);
        Console.WriteLine($"Final Treatment Bill for {patient.Name}: ${finalBill:F2}");
    }
}
