using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekt2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            /*if (!Database.Exists("Cepik"))
            {
                Database.SetInitializer(new CreateDatabaseIfNotExists<CepikDB>());
                InitializeComponent();
            }
            else InitializeComponent(); <- dlaczego baza danych się nie generuje?*/

            /* ******************************************************************** */

            /*  Database.SetInitializer(new CreateDatabaseIfNotExists<CepikDB>());

            var context = new CepikDB();
            context.Database.Create(); <-- to też nie działa*/
            using (var databaseCreate = new CepikDB())
            {
                if (!databaseCreate.Database.Exists())
                {
                    var CarData = new CarData();
                        CarData.CarID = 1;
                    var CarDocs = new CarDocs();
                    var Cars = new Cars();
                    var CarSpecs = new CarSpecs();
                    var Drivers = new Drivers();
                    var DrivingLicense = new DrivingLicense();
                    var InsuranceCompany = new InsuranceCompany();
                    var InsurancePolicy = new InsurancePolicy();
                    var IssuingAuthority = new IssuingAuthority();
                    var TechnicalReview = new TechnicalReview();
                    var TechnicalReviewStation = new TechnicalReviewStation();
                    databaseCreate.SaveChanges();
                    InitializeComponent();

                }
            }
        }
        private void addDriver_Click(object sender, EventArgs e)
        {
            var newForm1 = new addDriverForm();
            newForm1.Show();
        }
        private void addCarDocs_Click(object sender, EventArgs e)
        {
            var newForm = new addCarDocsForm();
            newForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
