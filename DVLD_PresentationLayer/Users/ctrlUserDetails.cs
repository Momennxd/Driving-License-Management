using Bunifu.Framework.UI;
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
    public partial class ctrlUserDetails : UserControl
    {
        public ctrlUserDetails()
        {
            InitializeComponent();
            _RoundControls();
        }

        void _RoundControls()
        {
            Control[] controls = {pnlUserID, pnlUserName, pnlIsActive };

            clsDVLDSettings.RoundControlsByCustomElips(bunifuElipse1, controls);
        }

        clsUser _User = new clsUser();

        int _UserID = -1;

        void _LoadDataToUserobj(int UserID)
        {
            _User = clsUser.FindByUserID(UserID);
        }

        void _DiplayDataonUserPersonCTRL()
        {
            ctrlUserPersonDetails.DispalyPersonData(_User.PersonID);
        }

        void _DisplayUserData()
        {
            clsDVLDSettings.ShowDataOnContolText(lblUserID, _User.UserID);
            clsDVLDSettings.ShowDataOnContolText(lblUserName, _User.UserName);

            if (_User.IsActive)
                swtchIsActive.Checked = true;
            else if (_User.IsActive)
                swtchIsActive.Checked = false;


        }

        public void DispalyUserInfo(int UserID)
        {
            _LoadDataToUserobj(UserID);
            _DiplayDataonUserPersonCTRL();
            _DisplayUserData();
        }

    }
}
