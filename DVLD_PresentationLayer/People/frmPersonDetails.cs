using DVLD_BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_PresentationLayer
{
    public partial class frmPersonDetails : Form
    {
        public frmPersonDetails(clsPerson Person)
        {
            InitializeComponent();
            _SelectedPerson = Person;
        }

        clsPerson _SelectedPerson = new clsPerson();

        void _RoundControls()
        {
            Control[] controls = { ctrlPersonDetails, pnlPeopleLoader };
            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);

        }


        void _GoBackToPeopleForm()
        {
            frmPeople frmPeople_v = new frmPeople();
            clsDVLDSettings.ShowFormInPanel(pnlPeopleLoader, frmPeople_v);
        }

        private void frmPersonDetails_Load(object sender, EventArgs e)
        {
            _RoundControls();
            ctrlPersonDetails.DispalyPersonData(_SelectedPerson.ID);
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            _GoBackToPeopleForm();
        }

        private void btnEditPerson_Click(object sender, EventArgs e)
        {
            frmAdd_EditPerson frmAdd_EditPerson_v = new frmAdd_EditPerson(_SelectedPerson);
            clsDVLDSettings.ShowFormInPanel(pnlPeopleLoader, frmAdd_EditPerson_v);
        }
    }
}
