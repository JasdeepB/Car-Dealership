﻿using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Dealership
{
    public partial class Dealership : Form
    {
        MySqlConnection conn;
        string connString = "SERVER=sql3.freemysqlhosting.net;PORT=3306;DATABASE=sql3326055;UID=sql3326055;PASSWORD=F23ItuHar5";
        public Dealership()
        {
            InitializeComponent();

            cust_comboBox.Items.Add("All Customers");
            cust_comboBox.Items.Add("Search Customers");
            cust_comboBox.Items.Add("Add Customer");
            cust_comboBox.Items.Add("Update Customer");
            cust_comboBox.Items.Add("Delete Customer");

            cars_comboBox.Items.Add("All Inventory");
            cars_comboBox.Items.Add("Search Car");
            cars_comboBox.Items.Add("Add Car");
            cars_comboBox.Items.Add("Update Car");
            cars_comboBox.Items.Add("Delete Car");
            cars_comboBox.SelectedIndex = 0;

            cars_StatusComboBox.Items.Add("Available");
            cars_StatusComboBox.Items.Add("Sold");
            cars_StatusComboBox.Items.Add("Incoming Shipment");

            emp_comboBox.Items.Add("All Employees");
            emp_comboBox.Items.Add("Search Employee");
            emp_comboBox.Items.Add("Add New Employee");
            emp_comboBox.Items.Add("Update Employee");
            emp_comboBox.Items.Add("Delete Employee");
            emp_comboBox.SelectedIndex = 0;

        }

        private void cust_Button_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = null;
                MySqlDataAdapter sda = null;
                conn = new MySqlConnection(connString);
                DataSet ds = new DataSet();
                conn.Open();

                string FirstName = cust_firstNMTxtB.Text.ToString();
                string MiddleName = cust_middleNMTxtB.ToString();
                string LastName = cust_lastNMTxtB.Text.ToString();
                string PhoneNumber = cust_PhoneNbrTxtB.Text.ToString();
                string Email = cust_emailTxtB.Text.ToString();
                string CmdString = "";

                switch(cust_comboBox.SelectedIndex)
                {
                    case 0:
                        //Show All
                       
                        break;

                    case 1:
                        //Search
                        break;

                    case 2:
                        //Add
                        break;

                    case 3:
                        //Update
                        break;

                    case 4:
                        //Delete
                        break;
                }
            }
            catch(MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void car_SearchBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = null;
                MySqlDataAdapter sda = null;
                conn = new MySqlConnection(connString);
                DataSet ds = new DataSet();
                conn.Open();

                string VIN = cars_VINTxtB.Text.ToString();
                int VinLength = VIN.Length;
                string Make = cars_makeTxtB.Text.ToString();
                int MakeLength = Make.Length;
                string Model = cars_modelTxtB.Text.ToString();
                int ModelLength = Model.Length;
                string Year = cars_YearTxtB.Text.ToString();
                string Color = cars_ColorTxtB.Text.ToString();
                string Mileage = cars_MileageTxtB.Text.ToString();
                bool Used = cars_YesCheckBox.Checked;
                string Status = cars_StatusComboBox.SelectedItem.ToString();
                string CmdString = "";

                switch (cars_comboBox.SelectedIndex)
                {
                    case 0:
                        //Show Inventory
                        CmdString = "SELECT VIN, Make, Model, Year, Color, Mileage, Used FROM Car";
                        sda = new MySqlDataAdapter(CmdString, conn);

                        sda.Fill(ds);
                        cars_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                    case 1:
                        //Search

                        break;
                    case 2:
                        //Add

                        break;

                    case 3:
                        //Update
                        break;

                    case 4:
                        //Delete
                        CmdString = "DELETE FROM Car WHERE = '" + VIN + "')";

                        CmdString = "SELECT VIN, Make, Model, Year, Color, Mileage, Used FROM Car";
                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        cars_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void emp_Button_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = null;
                MySqlDataAdapter sda = null;
                conn = new MySqlConnection(connString);
                DataSet ds = new DataSet();
                conn.Open();

                string FirstName = emp_FirstNameTxtB.Text.ToString();
                string MiddleName = emp_MiddleNameTxtB.Text.ToString();
                string LastName = emp_LastNameTxtB.Text.ToString();
                string PhoneNumber = emp_PhoneTxtB.Text.ToString();
                string Supervisor = emp_SupervisorTxtB.Text.ToString();
                string Email = emp_EmailTxtB.Text.ToString();
                string Title = emp_TitleTxtB.Text.ToString();
                string CmdString = "";

                switch (emp_comboBox.SelectedIndex)
                {
                    case 0:
                        //Show All
                        CmdString = "SELECT FirstName, MiddleName, LastName, SupervisorID, Number, Email, Title " +
                            "FROM Employee JOIN PhoneInfo ON(Employee.ID = PhoneInfo.EmployeeID)";
                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        emp_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 1:
                        //Search
                        CmdString = "SELECT FirstName, MiddleName, LastName, (SELECT CONCAT(FirstName, ' ', LastName) FROM Employee WHERE ID IN (SELECT SupervisorID FROM Employee ";
                        if (FirstName != "")
                        {
                            CmdString += "WHERE FirstName LIKE '" + FirstName + "'";
                        }
                        if (MiddleName != "")
                        {
                            if (FirstName != "")
                                CmdString += " AND MiddleName LIKE '" + MiddleName + "'";
                            else
                                CmdString += "WHERE MiddleName LIKE " + MiddleName + "'";
                        }
                        if (LastName != "")
                        {
                            if (FirstName != "" || MiddleName != "")
                                CmdString += " AND LastName LIKE '" + LastName + "'";
                            else
                                CmdString += "WHERE LastName LIKE '" + LastName + "'";
                        }
                        if (Supervisor != "")
                        {

                            if (FirstName != "" || MiddleName != "" || LastName != "")
                            {
                                CmdString += " AND SuppervisorID = (SELECT ID FROM Employee WHERE(SELECT CONCAT(FirstName, ' ', LastName) FROM Employee) LIKE '" + Supervisor + "')";
                            }

                            else
                                CmdString += "WHERE SupervisorID = " + Supervisor;
                        }

                        if (PhoneNumber != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || Supervisor != "")
                                CmdString += " AND Number LIKE '" + PhoneNumber + "'";
                            else
                                CmdString += "'WHERE Number LIKE " + PhoneNumber + "'";
                        }
                        if (Email != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || Supervisor != "" || PhoneNumber != "")
                                CmdString += " AND Email LIKE '" + Email + "'";
                            else
                                CmdString += "WHERE Email LIKE '" + Email + "'";
                        }
                        if (Title != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || Supervisor != "" || Email != "" || PhoneNumber != "")

                                CmdString += " AND Title LIKE '" + Title + "'";
                            else
                                CmdString += "WHERE Title LIKE '" + Title + "'";
                        }

                        CmdString += " )) AS Supervisor, Number, Email, Title FROM Employee JOIN PhoneInfo ON(Employee.ID = PhoneInfo.EmployeeID) ";

                        if (FirstName != "")
                        {
                            CmdString += "WHERE FirstName LIKE '" + FirstName + "'";
                        }

                        if (MiddleName != "")
                        {
                            if (FirstName != "")
                                CmdString += " AND MiddleName LIKE '" + MiddleName + "'";
                            else
                                CmdString += "WHERE MiddleName LIKE " + MiddleName + "'";
                        }
                        if (LastName != "")
                        {
                            if (FirstName != "" || MiddleName != "")
                                CmdString += " AND LastName LIKE '" + LastName + "'";
                            else
                                CmdString += "WHERE LastName LIKE '" + LastName + "'";
                        }
                        if (Supervisor != "")
                        {

                            if (FirstName != "" || MiddleName != "" || LastName != "")
                                CmdString += " AND SuppervisorID = (SELECT ID FROM Employee WHERE(SELECT CONCAT(FirstName, ' ', LastName) FROM Employee) LIKE '" + Supervisor + "')";

                            else
                                CmdString += "WHERE SupervisorID = " + Supervisor;
                        }

                        if (PhoneNumber != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || Supervisor != "")
                                CmdString += " AND Number LIKE '" + PhoneNumber + "'";
                            else
                                CmdString += "'WHERE Number LIKE " + PhoneNumber + "'";
                        }
                        if (Email != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || Supervisor != "" || PhoneNumber != "")
                                CmdString += " AND Email LIKE '" + Email + "'";
                            else
                                CmdString += "WHERE Email LIKE '" + Email + "'";
                        }
                        if (Title != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || Supervisor != "" || Email != "" || PhoneNumber != "")

                                CmdString += " AND Title LIKE '" + Title + "'";
                            else
                                CmdString += "WHERE Title LIKE '" + Title + "'";
                        }

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        emp_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 2:
                        //Add
                        CmdString = "INSERT INTO Employee (FirstName, MiddleName, LastName, SupervisorID, Email, Title) VALUES ("
                        + "'" + FirstName + "'";
                        if (MiddleName != "")
                            CmdString += ",'" + MiddleName + "'";
                        else
                            CmdString += ", NULL";
                        CmdString += ", '" + LastName + "'";
                        if (Supervisor != "")
                            CmdString += ", (SELECT ID FROM Employee WHERE CONCAT(FirstName, ' ', LastName) LIKE '" + Supervisor + "')";
                        else
                            CmdString += ", NULL";
                        CmdString += ",'" + Email + "'"
                        + ", '" + Title + "')";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "INSERT INTO PhoneInfo (TypeID, Number, EmployeeID) VALUES ( 'C', '" + PhoneNumber + "', last_insert_id())";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();


                        CmdString = "SELECT FirstName, MiddleName, LastName, SupervisorID, Number, Email, Title " +
                        "FROM Employee JOIN PhoneInfo ON(Employee.PhoneID = PhoneInfo.ID)";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        emp_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 3:
                        //Update
                        CmdString = "UPDATE Employee SET ";
                        if (FirstName != "")
                        {
                            CmdString += "FirstName = '" + FirstName + "'";
                        }
                        if (MiddleName != "")
                        {
                            if (FirstName != "")
                                CmdString += ", MiddleName = '" + MiddleName + "'";
                            else
                                CmdString += "MiddleName = " + MiddleName + "'";
                        }
                        if (LastName != "")
                        {
                            if (FirstName != "" || MiddleName != "")
                                CmdString += ", LastName = '" + LastName + "'";
                            else
                                CmdString += "LastName = '" + LastName + "'";
                        }
                        if (Supervisor != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "")
                                CmdString += ", (SELECT ID FROM Employee WHERE CONCAT(FirstName, ' ', LastName) LIKE '" + Supervisor + "')";
                            else
                                CmdString += ", (SELECT ID FROM Employee WHERE CONCAT(FirstName, ' ', LastName) LIKE '" + Supervisor + "')";
                        }
                        if (Email != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || Supervisor != "")
                                CmdString += ", Email = '" + Email + "'";
                            else
                                CmdString += "Email = '" + Email + "'";
                        }
                        if (Title != "")
                        {
                            if (FirstName != "" || MiddleName != "" || LastName != "" || Supervisor != "" || Email != "")
                                CmdString += ", Title = '" + Title + "'";
                            else
                                CmdString += "Title = '" + Title + "'";
                        }
                        CmdString += "WHERE OLD.Email = " + Email;

                        if (PhoneNumber != "")
                        {
                            CmdString = "UPDATE PhoneInfo SET Number = '" + PhoneNumber +
                            "' WHERE EmployeeID = (SELECT ID FROM Employee WHERE OLD.Email = " + Email + ")";
                        }


                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "SELECT FirstName, MiddleName, LastName, SupervisorID, Number, Email, Title " +
                            "FROM Employee JOIN PhoneInfo ON(Employee.PhoneID = PhoneInfo.ID)";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        emp_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;

                    case 4:
                        //Delete
                        CmdString = "DELETE FROM Employee WHERE Email = '" + Email + "'";

                        cmd = new MySqlCommand(CmdString, conn);
                        cmd.ExecuteNonQuery();

                        CmdString = "SELECT FirstName, MiddleName, LastName, SupervisorID, Number, Email, Title " +
                            "FROM Employee JOIN PhoneInfo ON(Employee.PhoneID = PhoneInfo.ID)";

                        sda = new MySqlDataAdapter(CmdString, conn);
                        sda.Fill(ds);
                        emp_dataGridView.DataSource = ds.Tables[0].DefaultView;
                        conn.Close();
                        break;
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void cust_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cust_comboBox.SelectedIndex)
            {
                case 0:
                    cust_Button.Text = "Show Customers";
                    break;
                case 1:
                    cust_Button.Text = "Search Customers";
                    break;
                case 2:
                    cust_Button.Text = "Add Customer";
                    break;
                case 3:
                    cust_Button.Text = "Update Customer";
                    break;

                case 4:
                    cust_Button.Text = "Delete Customer";
                    break;
            }
        }
        private void cars_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cars_comboBox.SelectedIndex)
            {
                case 0:
                    car_SearchBtn.Text = "Show Inventory";
                    break;
                case 1:
                    car_SearchBtn.Text = "Search Cars";
                    break;
                case 2:
                    car_SearchBtn.Text = "Add Car";
                    break;
                case 3:
                    car_SearchBtn.Text = "Update Car";
                    break;
                case 4:
                    car_SearchBtn.Text = "Delete Car";
                    break;
            }
        }
        private void emp_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (emp_comboBox.SelectedIndex)
            {
                case 0:
                    emp_Button.Text = "Show All";
                    break;
                case 1:
                    emp_Button.Text = "Search";
                    break;
                case 2:
                    emp_Button.Text = "Add Employee";
                    break;
                case 3:
                    emp_Button.Text = "Update Employee";
                    break;
                case 4:
                    emp_Button.Text = "Delete Employee";
                    break;
            }
        }
        private void cars_YesCheckBox_Click(object sender, EventArgs e)
        {
            if (cars_YesCheckBox.Checked == true)
            {
                if (cars_NoCheckBox.Checked == true)
                {
                    cars_YesCheckBox.Checked = false;
                    cars_NoCheckBox.Checked = true;
                }
            }
        }
        private void cars_NoCheckBox_Click(object sender, EventArgs e)
        {
            if (cars_NoCheckBox.Checked == true)
            {
                if (cars_YesCheckBox.Checked == true)
                {
                    cars_NoCheckBox.Checked = false;
                    cars_YesCheckBox.Checked = true;
                }
            }
        }
    }
}
