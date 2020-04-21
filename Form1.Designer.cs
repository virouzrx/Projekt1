namespace projekt2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.addDriver = new System.Windows.Forms.Button();
            this.addTechReview = new System.Windows.Forms.Button();
            this.addDrivingLincense = new System.Windows.Forms.Button();
            this.addCarDocs = new System.Windows.Forms.Button();
            this.searchCarHistory = new System.Windows.Forms.Button();
            this.searchDrivingLicenses = new System.Windows.Forms.Button();
            this.searchCarsWithNoInsurence = new System.Windows.Forms.Button();
            this.searchCarNoTechReview = new System.Windows.Forms.Button();
            this.searchCarVin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.delCarDocs = new System.Windows.Forms.Button();
            this.delDrivingLicense = new System.Windows.Forms.Button();
            this.delTechReview = new System.Windows.Forms.Button();
            this.delCar = new System.Windows.Forms.Button();
            this.delDriver = new System.Windows.Forms.Button();
            this.addCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDriver
            // 
            this.addDriver.Location = new System.Drawing.Point(29, 75);
            this.addDriver.Name = "addDriver";
            this.addDriver.Size = new System.Drawing.Size(126, 45);
            this.addDriver.TabIndex = 0;
            this.addDriver.Text = "kierowcę";
            this.addDriver.UseVisualStyleBackColor = true;
            this.addDriver.Click += new System.EventHandler(this.addDriver_Click);
            // 
            // addTechReview
            // 
            this.addTechReview.Location = new System.Drawing.Point(29, 177);
            this.addTechReview.Name = "addTechReview";
            this.addTechReview.Size = new System.Drawing.Size(126, 45);
            this.addTechReview.TabIndex = 4;
            this.addTechReview.Text = "badanie techniczne";
            this.addTechReview.UseVisualStyleBackColor = true;
            // 
            // addDrivingLincense
            // 
            this.addDrivingLincense.Location = new System.Drawing.Point(29, 228);
            this.addDrivingLincense.Name = "addDrivingLincense";
            this.addDrivingLincense.Size = new System.Drawing.Size(126, 45);
            this.addDrivingLincense.TabIndex = 5;
            this.addDrivingLincense.Text = "prawo jazdy";
            this.addDrivingLincense.UseVisualStyleBackColor = true;
            // 
            // addCarDocs
            // 
            this.addCarDocs.Location = new System.Drawing.Point(29, 279);
            this.addCarDocs.Name = "addCarDocs";
            this.addCarDocs.Size = new System.Drawing.Size(126, 45);
            this.addCarDocs.TabIndex = 6;
            this.addCarDocs.Text = "dokumenty pojazdu";
            this.addCarDocs.UseVisualStyleBackColor = true;
            this.addCarDocs.Click += new System.EventHandler(this.addCarDocs_Click);
            // 
            // searchCarHistory
            // 
            this.searchCarHistory.Location = new System.Drawing.Point(415, 75);
            this.searchCarHistory.Name = "searchCarHistory";
            this.searchCarHistory.Size = new System.Drawing.Size(373, 45);
            this.searchCarHistory.TabIndex = 7;
            this.searchCarHistory.Text = "historię pojazdu";
            this.searchCarHistory.UseVisualStyleBackColor = true;
            this.searchCarHistory.Click += new System.EventHandler(this.button6_Click);
            // 
            // searchDrivingLicenses
            // 
            this.searchDrivingLicenses.Location = new System.Drawing.Point(415, 126);
            this.searchDrivingLicenses.Name = "searchDrivingLicenses";
            this.searchDrivingLicenses.Size = new System.Drawing.Size(373, 45);
            this.searchDrivingLicenses.TabIndex = 8;
            this.searchDrivingLicenses.Text = "prawa jazdy kierowców";
            this.searchDrivingLicenses.UseVisualStyleBackColor = true;
            // 
            // searchCarsWithNoInsurence
            // 
            this.searchCarsWithNoInsurence.Location = new System.Drawing.Point(415, 177);
            this.searchCarsWithNoInsurence.Name = "searchCarsWithNoInsurence";
            this.searchCarsWithNoInsurence.Size = new System.Drawing.Size(373, 45);
            this.searchCarsWithNoInsurence.TabIndex = 9;
            this.searchCarsWithNoInsurence.Text = "pojazdy bez polisy";
            this.searchCarsWithNoInsurence.UseVisualStyleBackColor = true;
            // 
            // searchCarNoTechReview
            // 
            this.searchCarNoTechReview.Location = new System.Drawing.Point(415, 228);
            this.searchCarNoTechReview.Name = "searchCarNoTechReview";
            this.searchCarNoTechReview.Size = new System.Drawing.Size(373, 45);
            this.searchCarNoTechReview.TabIndex = 10;
            this.searchCarNoTechReview.Text = "pojazdy z nieaktualnym przeglądem";
            this.searchCarNoTechReview.UseVisualStyleBackColor = true;
            // 
            // searchCarVin
            // 
            this.searchCarVin.Location = new System.Drawing.Point(415, 279);
            this.searchCarVin.Name = "searchCarVin";
            this.searchCarVin.Size = new System.Drawing.Size(373, 45);
            this.searchCarVin.TabIndex = 11;
            this.searchCarVin.Text = "samochody po nr VIN";
            this.searchCarVin.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dodaj...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(552, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Przeglądaj...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(233, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Usuń...";
            // 
            // delCarDocs
            // 
            this.delCarDocs.Location = new System.Drawing.Point(193, 279);
            this.delCarDocs.Name = "delCarDocs";
            this.delCarDocs.Size = new System.Drawing.Size(126, 45);
            this.delCarDocs.TabIndex = 18;
            this.delCarDocs.Text = "dokumenty pojazdu";
            this.delCarDocs.UseVisualStyleBackColor = true;
            // 
            // delDrivingLicense
            // 
            this.delDrivingLicense.Location = new System.Drawing.Point(193, 228);
            this.delDrivingLicense.Name = "delDrivingLicense";
            this.delDrivingLicense.Size = new System.Drawing.Size(126, 45);
            this.delDrivingLicense.TabIndex = 17;
            this.delDrivingLicense.Text = "prawo jazdy";
            this.delDrivingLicense.UseVisualStyleBackColor = true;
            // 
            // delTechReview
            // 
            this.delTechReview.Location = new System.Drawing.Point(193, 177);
            this.delTechReview.Name = "delTechReview";
            this.delTechReview.Size = new System.Drawing.Size(126, 45);
            this.delTechReview.TabIndex = 16;
            this.delTechReview.Text = "badanie techniczne";
            this.delTechReview.UseVisualStyleBackColor = true;
            // 
            // delCar
            // 
            this.delCar.Location = new System.Drawing.Point(193, 126);
            this.delCar.Name = "delCar";
            this.delCar.Size = new System.Drawing.Size(126, 45);
            this.delCar.TabIndex = 15;
            this.delCar.Text = "pojazd";
            this.delCar.UseVisualStyleBackColor = true;
            // 
            // delDriver
            // 
            this.delDriver.Location = new System.Drawing.Point(193, 75);
            this.delDriver.Name = "delDriver";
            this.delDriver.Size = new System.Drawing.Size(126, 45);
            this.delDriver.TabIndex = 14;
            this.delDriver.Text = "kierowcę";
            this.delDriver.UseVisualStyleBackColor = true;
            // 
            // addCar
            // 
            this.addCar.Location = new System.Drawing.Point(31, 126);
            this.addCar.Name = "addCar";
            this.addCar.Size = new System.Drawing.Size(123, 44);
            this.addCar.TabIndex = 20;
            this.addCar.Text = "pojazd";
            this.addCar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addCar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delCarDocs);
            this.Controls.Add(this.delDrivingLicense);
            this.Controls.Add(this.delTechReview);
            this.Controls.Add(this.delCar);
            this.Controls.Add(this.delDriver);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchCarVin);
            this.Controls.Add(this.searchCarNoTechReview);
            this.Controls.Add(this.searchCarsWithNoInsurence);
            this.Controls.Add(this.searchDrivingLicenses);
            this.Controls.Add(this.searchCarHistory);
            this.Controls.Add(this.addCarDocs);
            this.Controls.Add(this.addDrivingLincense);
            this.Controls.Add(this.addTechReview);
            this.Controls.Add(this.addDriver);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addDriver;
        private System.Windows.Forms.Button addTechReview;
        private System.Windows.Forms.Button addDrivingLincense;
        private System.Windows.Forms.Button addCarDocs;
        private System.Windows.Forms.Button searchCarHistory;
        private System.Windows.Forms.Button searchDrivingLicenses;
        private System.Windows.Forms.Button searchCarsWithNoInsurence;
        private System.Windows.Forms.Button searchCarNoTechReview;
        private System.Windows.Forms.Button searchCarVin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button delCarDocs;
        private System.Windows.Forms.Button delDrivingLicense;
        private System.Windows.Forms.Button delTechReview;
        private System.Windows.Forms.Button delCar;
        private System.Windows.Forms.Button delDriver;
        private System.Windows.Forms.Button addCar;
    }
}

