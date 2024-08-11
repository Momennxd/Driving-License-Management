using Bunifu.Framework.UI;
using DVLD_BusinessLayer;
using DVLD_PresentationLayer.Properties;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace DVLD_PresentationLayer
{
    public class clsDVLDSettings
    {

        public static clsUser CurrentUser = new clsUser();

        public static string UserInfoFilePath = @"LastUserLoginInfo.txt";

        public static char Seperator = '#';


        public static void GetUserInfoByFile(ref string UserName, ref string Password, string FilePath, char Sep)
        {
            string FileContent = GetFileTextContent(FilePath);
          
            UserName = FileContent.Split(Sep)[0];
            Password = FileContent.Split(Sep)[1];
        }

        public static void ClearFileContent(string FilePath)
        {
            string text = "";

            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                // Write the text to the file
                writer.Write(text);
            }
        }

        public static string GetFileTextContent(string FilePath)
        {
            // Create a new instance of StreamReader and specify the file path
            using (StreamReader reader = new StreamReader(FilePath))
            {
                // Read the entire content of the file
                string text = reader.ReadToEnd();

                // Display the text
                return text;
            }
        }

        public static void SaveUserInfoToLogin(string UserName, string Password, string FilePath, char Sep)
        {
            string text = UserName + Sep + Password;

            using (StreamWriter writer = new StreamWriter(FilePath))
            {
                // Write the text to the file
                writer.Write(text);
            }
        }


        public static void AddColumnToDataTable(string ColumnName, Type ColumnType, ref DataTable DT)
        {
            DataColumn dataColumn = new DataColumn(ColumnName, ColumnType);        
            DT.Columns.Add(dataColumn);
        }

        public static void AddColumnToDataBunifuGridView(string ColumnName, Type ColumnType, ref BunifuCustomDataGrid DG, DataGridViewImageCellLayout Layout = DataGridViewImageCellLayout.Stretch)
        {
            if (ColumnType == typeof(Image))
            {
                DataGridViewImageColumn ImgColmn = new DataGridViewImageColumn();
                ImgColmn.HeaderText = ColumnName;
                ImgColmn.Name = ColumnName;
                ImgColmn.ImageLayout = Layout;
                DG.Columns.Add(ImgColmn);
            }
            else
            {
                DataGridViewColumn dataColumn = new DataGridViewColumn();
                dataColumn.Name = ColumnName;
                dataColumn.ValueType = ColumnType;
                DG.Columns.Add(dataColumn);
            }
        }


        public static void AddValueToDataTable(int Row, int Column, dynamic Value, ref DataTable DT)
        {
            DT.Rows[Row][Column] = Value;
        }

        public static void AddValueToDataTable(int Row, string ColumnName, dynamic Value, ref DataTable DT)
        {
            DT.Rows[Row][ColumnName] = Value;
        }

        public static void AddValueToBunifuGridView(int Row, string ColumnName, dynamic Value, ref BunifuCustomDataGrid DG)
        {
            DG.Rows[Row].Cells[ColumnName].Value = Value;
        }

        public static void AddImageToBunifuGridView(int Row, string ColumnName, Image Img, ref BunifuCustomDataGrid DG)
        {

            DG.Rows[Row].Cells[ColumnName].Value = Img;
        }


        public static void ChangeColumnNameInDataTable(int Column, string NewName, ref DataTable DT)
        {
            DT.Columns[Column].ColumnName = NewName;
        }

        public static void ChangeColumnNameInDataTable(string ColumnName, string NewName, ref DataTable DT)
        {
            DT.Columns[ColumnName].ColumnName = NewName;
        }

        public static void ShowFormInPanel(Panel pnl, Form frm)
        {
            pnl.Controls.Clear();
            frm.Dock = DockStyle.Fill; frm.TopLevel = false; frm.TopMost = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            pnl.Controls.Add(frm);
            frm.Show();
        }

        public static Image GetImageByPath(string Path)
        {
            try
            {
                return Image.FromFile(Path);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static void ShowDataOnCustomDataGridView(BunifuCustomDataGrid DG, DataTable DT)
        {
            DG.DataSource = DT;
        }

        public static void RoundControlsByCustomElips(BunifuElipse bElips , Control[] C)
        {
            for (int i = 0; i < C.Length;i++)
            {
                bElips.ApplyElipse(C[i]);
            }
        }

        public static void StyleBunifuThinButtonIDLE(BunifuThinButton2 BTN, Color idleFillColor, Color idleForeColor, Color idleLineColor)
        {
            BTN.IdleFillColor = idleFillColor;
            BTN.IdleForecolor = idleForeColor;
            BTN.IdleLineColor = idleLineColor;
        }

        public static bool IsNumber(string UserInput)
        {
            double number;
            if (double.TryParse(UserInput, out number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ShowDataOnContolText(Control LBL, dynamic Data)
        {
            LBL.Text = Data.ToString();
        }

        public static void ShowDateOnCustomDatePicker(BunifuDatepicker DT, DateTime Date)
        {
            DT.Value = Date;
        }


        public static string GetPersonFullName(clsPerson Person)
        {
            return (Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName);
        }

        public static string GetPersonFullName(int PersonID)
        {
            clsPerson Person = clsPerson.Find(PersonID);
            return (Person.FirstName + " " + Person.SecondName + " " + Person.ThirdName + " " + Person.LastName);
        }


        public static string GetPersonGender(clsPerson Person)
        {
            if (Person.Gender == 0)
                return "Male";
            else if (Person.Gender == 1)
                return "Female";
            else
                return "Other";
        }

        public static void DispalyImageForUser(PictureBox pbPersonPic, clsPerson Person)
        {
            if (string.IsNullOrEmpty(Person.ImagePath))
            {
                if (Person.Gender == 0)
                    pbPersonPic.Image = Resources.MaleUser;

                else if (Person.Gender == 1)

                    pbPersonPic.Image = Resources.femaleUser1;
                else
                    pbPersonPic.Image = null;
            }
            else
            {
                pbPersonPic.ImageLocation = Person.ImagePath;

            }
        }

        public static void DispalyDefaultImageForUser(PictureBox pbPersonPic, clsPerson Person)
        {

            if (Person.Gender == 0)
                pbPersonPic.Image = Resources.MaleUser;

            else if (Person.Gender == 1)

                pbPersonPic.Image = Resources.femaleUser1;
            else
                pbPersonPic.Image = null;
           
        }

        public static void DispalyDefaultImageForUser(PictureBox pbPersonPic, int Gender)
        {

            if (Gender == 0)
                pbPersonPic.Image = Resources.MaleUser;

            else if (Gender == 1)

                pbPersonPic.Image = Resources.femaleUser1;
            else
                pbPersonPic.Image = null;

        }



        public static void ShowItemAsSelectedOnComboBoxByName(ref ComboBox CB, string ItemName)
        {
            for (int i = 0; i < CB.Items.Count; i++) 
            {
                if (CB.GetItemText(CB.Items[i]) == ItemName)
                {
                    CB.SelectedIndex = i;
                    return;
                }
            }
        }

        public static bool ValidateIfTxtBoxIsNotNumber(Control txtBox, string ErrorText, ErrorProvider errorProvider)
        {
            if (!IsNumber(txtBox.Text))
            {
                errorProvider.SetError(txtBox, ErrorText);
                return false;
            }

            return true;
        }

        public static bool ValidateTxtBox(TextBox txtBox, string ErrorCase, string ErrorText, ErrorProvider errorProvider)
        {
            if (txtBox.Text == ErrorCase)
            {
                errorProvider.SetError(txtBox, ErrorText);
                return false;
            }

            return true;
        }

        public static bool ValidateTxtBox(BunifuTextbox txtBox, string ErrorCase, string ErrorText, ErrorProvider errorProvider)
        {
            if (txtBox.Text == ErrorCase)
            {
                errorProvider.SetError(txtBox, ErrorText);
                return false;
            }

            return true;
        }

        public static bool ValidateCustomRadioButton(MaterialRadioButton bCtrl, bool ErrorCase, string ErrorText, ErrorProvider errorProvider)
        {
            if (bCtrl.Checked == ErrorCase)
            {
                errorProvider.SetError(bCtrl, ErrorText);
                return false;
            }

            return true;
        }


        public static bool ValidateTxtBox(Control txtBox, bool ErrorCase, string ErrorText, ErrorProvider errorProvider)
        {
            if (ErrorCase)
            {
                errorProvider.SetError(txtBox, ErrorText);
                return false;
            }

            return true;
        }

        public static bool ValidateCustomDatePicker(BunifuDatepicker bDatePicker, DateTime minDate, DateTime maxDate, string ErrorText, ErrorProvider errorProvider)
        {
            if (bDatePicker.Value > maxDate || bDatePicker.Value < minDate)
            {
                errorProvider.SetError(bDatePicker, ErrorText);
                return false;
            }

            return true;
        }


        public static DateTime GetBirthDateFor18YearsAgo()
        {
            DateTime today = DateTime.Today;
            DateTime birthDate = today.AddYears(-18);
            return birthDate;
        }

        public static DateTime GetBirthDateFor110YearsAgo()
        {
            DateTime today = DateTime.Today;
            DateTime maxAgeDate = today.AddYears(-110);
            return maxAgeDate;
        }


        public static bool IsEmailValid(string Email)
        {
            Email = Email.ToLower();
            return (Email.Contains("@") && Email.EndsWith(".com"));
        }

        public static bool IsDate1GreaterThanDate2(DateTime date1, DateTime date2)
        {
            return (date1 > date2);
        }

        public static void ImportDataToPersonObj(dynamic Val, ref dynamic Varible)
        {
            Varible = Val;
        }

        public static byte GetGenderIndexByName(string GenderName)
        {
            if (GenderName == "Male")
                return 0;
            else if (GenderName == "Female")
                return 1;
            else
                return 2;
        }

        public static void ImportNationalitiesToComboBox(ComboBox cbNationalities, DataTable dtCountries)
        {
            foreach (DataRow Row in dtCountries.Rows)
            {
                cbNationalities.Items.Add(Row["CountryName"].ToString());
            }
        }

        public static void ImportDataToComboBox(ComboBox CB, DataTable dtData, string ImportFromColumnName)
        {
            foreach (DataRow Row in dtData.Rows)
            {
                CB.Items.Add(Row[ImportFromColumnName].ToString());
            }
        }


        public static void DeleteOldPersonImageFromSource(clsPerson Person)
        {
            if (!string.IsNullOrEmpty(Person.ImagePath))
            {
                File.Delete(Person.ImagePath);
            }
        }

        public static void ResetString(ref string S)
        {
            S = "";
        }

        public static void ResetCustomSearchBar(BunifuTextbox bTextBox, Label lblSearchBar)
        {
            bTextBox.text = "";
            lblSearchBar.Text = "Search";
        }

        public static void ResetCustomSearchBar(BunifuTextbox bTextBox, Label lblSearchBar, string SearchBarTxt)
        {
            bTextBox.text = "";
            lblSearchBar.Text = SearchBarTxt;
        }

        public static void ShowIndexOnSearchFilter(ComboBox cbSearchFilter, int Index)
        {
            cbSearchFilter.SelectedIndex = Index;

        }

        public static void Dis_EnableContol(Control Ctrl, bool Enable)
        {
            Ctrl.Enabled = Enable;
        }

        public static void In_VisibleControl(Control Ctrl, bool Visible)
        {
            Ctrl.Visible = Visible;
        }

        public static void ShowForm(Form FRM)
        {
            FRM.Show();
        }

      
    }
}
