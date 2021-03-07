using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesignPatternsTest
{
    public partial class MainDesignPatternsForm : Form
    {
        string newLine;
        public MainDesignPatternsForm()
        {
            InitializeComponent();
            newLine = Environment.NewLine;
        }

        private void btnFactory_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();

            Factory.CreditCard cardDetails = Factory.CreditCardFactory.GetCreditCard("Platinum");

            if (cardDetails != null)
            {
                txtSaida.AppendText("CardType : " + cardDetails.GetCardType() + newLine);
                txtSaida.AppendText("CreditLimit : " + cardDetails.GetCreditLimit() + newLine);
                txtSaida.AppendText("AnnualCharge :" + cardDetails.GetAnnualCharge() + newLine);
            }
            else
            {
                txtSaida.AppendText("Invalid Card Type");
            }
            //Console.ReadLine();
        }

        private void btnFactoryMethod_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();

            FactoryMethod.CreditCard creditCard = new FactoryMethod.PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
               txtSaida.AppendText("Card Type : " + creditCard.GetCardType() + newLine);
               txtSaida.AppendText("Credit Limit : " + creditCard.GetCreditLimit() + newLine);
               txtSaida.AppendText("Annual Charge :" + creditCard.GetAnnualCharge() + newLine);
            }
            else
            {
                txtSaida.AppendText("Invalid Card Type" + newLine);
            }
           txtSaida.AppendText("--------------" + newLine);
            creditCard = new FactoryMethod.MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
               txtSaida.AppendText("Card Type : " + creditCard.GetCardType() + newLine);
               txtSaida.AppendText("Credit Limit : " + creditCard.GetCreditLimit() + newLine);
               txtSaida.AppendText("Annual Charge :" + creditCard.GetAnnualCharge() + newLine);
            }
            else
            {
                txtSaida.AppendText("Invalid Card Type" + newLine);
            }
            //Console.ReadLine();
        }

        private void btnAbstractFactory_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();

            AbstractFactory.Animal animal = null;
            AbstractFactory.AnimalFactory animalFactory = null;
            string speakSound = null;
            // Create the Sea Factory object by passing the factory type as Sea
            animalFactory = AbstractFactory.AnimalFactory.CreateAnimalFactory("Sea");
            txtSaida.AppendText("Animal Factory type : " + animalFactory.GetType().Name + newLine);
            txtSaida.AppendText("" + newLine);
            // Get Octopus Animal object by passing the animal type as Octopus
            animal = animalFactory.GetAnimal("Octopus");
            txtSaida.AppendText("Animal Type : " + animal.GetType().Name + newLine);
            speakSound = animal.speak();
            txtSaida.AppendText(animal.GetType().Name + " Speak : " + speakSound + newLine);
            txtSaida.AppendText("" + newLine);
            txtSaida.AppendText("--------------------------" + newLine);
            // Create Land Factory object by passing the factory type as Land
            animalFactory = AbstractFactory.AnimalFactory.CreateAnimalFactory("Land");
            txtSaida.AppendText("Animal Factory type : " + animalFactory.GetType().Name + newLine);
            txtSaida.AppendText("" + newLine);
            // Get Lion Animal object by passing the animal type as Lion
            animal = animalFactory.GetAnimal("Lion");
            txtSaida.AppendText("Animal Type : " + animal.GetType().Name + newLine);
            speakSound = animal.speak();
            txtSaida.AppendText(animal.GetType().Name + " Speak : " + speakSound + newLine);
            txtSaida.AppendText("" + newLine);
            // Get Cat Animal object by passing the animal type as Cat
            animal = animalFactory.GetAnimal("Cat");
            txtSaida.AppendText("Animal Type : " + animal.GetType().Name + newLine);
            speakSound = animal.speak();
            txtSaida.AppendText(animal.GetType().Name + " Speak : " + speakSound + newLine);
           // Console.Read();

        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();
            // Client Code
            Builder.Report report;
            Builder.ReportDirector reportDirector = new Builder.ReportDirector();
            // Construct and display Reports
            Builder.PDFReport pdfReport = new Builder.PDFReport();
            report = reportDirector.MakeReport(pdfReport);
            txtSaida.AppendText(report.DisplayReport() + Environment.NewLine);
            txtSaida.AppendText("-------------------" + Environment.NewLine);
            Builder.ExcelReport excelReport = new Builder.ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            txtSaida.AppendText(report.DisplayReport() + Environment.NewLine);

            //Console.ReadKey();
        }

        private void btnSingletonV1_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();
            Singleton.SingletonV1 fromTeachaer = Singleton.SingletonV1.GetInstance;
            txtSaida.Text = fromTeachaer.PrintDetails();
            Singleton.SingletonV1 fromStudent = Singleton.SingletonV1.GetInstance;
            txtSaida.Text = fromStudent.PrintDetails();
            //Console.ReadLine();
        }

        private void btnSingletonV2_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();
            Parallel.Invoke(
                 () => PrintTeacherDetails(),
                 () => PrintStudentdetails()
                 );
            Console.ReadLine();
        }
        private void PrintTeacherDetails()
        {
            Singleton.SingletonV2 fromTeacher = Singleton.SingletonV2.GetInstance;
            txtSaida.Text = fromTeacher.PrintDetails();
        }
        private void PrintStudentdetails()
        {
            Singleton.SingletonV2 fromStudent = Singleton.SingletonV2.GetInstance;
            txtSaida.Text = fromStudent.PrintDetails();
        }

        private void btnAdapter_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();

            string[,] employeesArray = new string[5, 4]
           {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
           };

            Adapter.ITarget target = new Adapter.EmployeeAdapter();
            txtSaida.AppendText("HR system passes employee string array to Adapter" + Environment.NewLine);
            txtSaida.AppendText(target.ProcessCompanySalary(employeesArray));
           // Console.Read();
        }

        private void btnFacade_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();

            Facade.Order order = new Facade.Order();
            txtSaida.AppendText(order.PlaceOrder());
            //Console.Read();
        }

        private void btnProxy_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();
            txtSaida.AppendText("Client passing employee with Role Developer to folderproxy" + Environment.NewLine);
            Proxy.Employee emp1 = new Proxy.Employee("Anurag", "Anurag123", "Developer");
            Proxy.SharedFolderProxy folderProxy1 = new Proxy.SharedFolderProxy(emp1);
            txtSaida.AppendText(folderProxy1.PerformRWOperations() + Environment.NewLine);
            //Console.WriteLine();
            txtSaida.AppendText("Client passing employee with Role Manager to folderproxy" + Environment.NewLine);
            Proxy.Employee emp2 = new Proxy.Employee("Pranaya", "Pranaya123", "Manager");
            Proxy.SharedFolderProxy folderProxy2 = new Proxy.SharedFolderProxy(emp2);
            txtSaida.AppendText(folderProxy2.PerformRWOperations() + Environment.NewLine);
           // Console.Read();
        }

        private void btnDecorator_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();
            Decorator.ICar bmwCar1 = new Decorator.BMWCar();
            bmwCar1.ManufactureCar();
            txtSaida.AppendText(bmwCar1 + Environment.NewLine);
            Decorator.DieselCarDecorator carWithDieselEngine = new Decorator.DieselCarDecorator(bmwCar1);
            carWithDieselEngine.ManufactureCar();
            txtSaida.AppendText(carWithDieselEngine + Environment.NewLine);
            txtSaida.AppendText(Environment.NewLine);
            Decorator.ICar bmwCar2 = new Decorator.BMWCar();
            Decorator.PetrolCarDecorator carWithPetrolEngine = new Decorator.PetrolCarDecorator(bmwCar2);
            carWithPetrolEngine.ManufactureCar();
            txtSaida.AppendText(carWithPetrolEngine + Environment.NewLine);
            // Console.ReadKey();
        }

        private void btnObserver_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();
            //Create a Product with Out Of Stock Status
            Observer.Subject RedMI = new Observer.Subject("Red MI Mobile", 10000, "Out Of Stock");
            //User Anurag will be created and user1 object will be registered to the subject
            Observer.Observer user1 = new Observer.Observer("Anurag", RedMI);
            //User Pranaya will be created and user1 object will be registered to the subject
            Observer.Observer user2 = new Observer.Observer("Pranaya", RedMI);
            //User Priyanka will be created and user3 object will be registered to the subject
            Observer.Observer user3 = new Observer.Observer("Priyanka", RedMI);

            txtSaida.AppendText("Red MI Mobile current state : " + RedMI.getAvailability() + " " + Environment.NewLine);
           //Console.WriteLine();
            // Now product is available
            RedMI.setAvailability("Available");
            //Console.Read();
        }

        private void btnCommand_Click(object sender, EventArgs e)
        {
            txtSaida.Clear();

            Command.Document document = new Command.Document();
            Command.ICommand openCommand = new Command.OpenCommand(document);
            Command.ICommand saveCommand = new Command.SaveCommand(document);
            Command.ICommand closeCommand = new Command.CloseCommand(document);
            Command.MenuOptions menu = new Command.MenuOptions(openCommand, saveCommand, closeCommand);
            menu.clickOpen();
            menu.clickSave();
            menu.clickClose();
            //Console.ReadKey();
        }
    }
}
