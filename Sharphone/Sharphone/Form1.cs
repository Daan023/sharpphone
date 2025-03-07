using System.ComponentModel.Design.Serialization;

namespace Sharphone
{
    public partial class Form1 : Form
    {
        List<SmartPhone> smartPhones { get; set; }
        int geselecteerdeIndex;
        bool userloggedin = false;
        

        public Form1()
        {

            if ( ! userloggedin )
            {
                Loginform formlogin = new Loginform();
                formlogin.ShowDialog();
                if (formlogin.DialogResult == DialogResult.OK)
                {
                    InitializeComponent();

                    smartPhones = new List<SmartPhone>();



                    smartPhones.Add(new SmartPhone(0, "Samsung", "Blackhole E55", 128000, 128.92, 0));

                    RefreshListBox();

                    /*foreach (SmartPhone phone in smartPhones)
                    {
                        string displayText = $"{phone.Brand} - {phone.Model}";
                        listPhones.Items.Add(displayText);
                    }*/
                }

            }
           



        }

        private void Btnaddphone_Click(object sender, EventArgs e)
        {
            formaddPhone form = new formaddPhone();
           

            if (form.ShowDialog() == DialogResult.OK)
            {
                
                int id = smartPhones.Count + 1;                                                                                
                SmartPhone phone = form.Phone;
                phone.Id = id;

                smartPhones.Add(phone);
                RefreshListBox();
            }
            else
            {
               
            }
        }

        

        private void btnModify_Click(object sender, EventArgs e)
        {

            SmartPhone geselecteerdeSmartPhone = smartPhones[listPhones.SelectedIndex];

            formaddPhone FormaddPhone = new formaddPhone(geselecteerdeSmartPhone);
            DialogResult result = FormaddPhone.ShowDialog();

            if (result == DialogResult.OK)
            {
                SmartPhone aangepasteSmartphone = FormaddPhone.Phone;

                smartPhones[geselecteerdeIndex] = aangepasteSmartphone;

                //RefreshListBox();
            }
        }

        private void RefreshListBox()
        {
            listPhones.Items.Clear();
            foreach (SmartPhone phone in smartPhones)
            {
                string displayText = $"{phone.Brand} - {phone.Model}";
                listPhones.Items.Add(displayText);
            }
        }
    }
}