using AwesomePokerGameSln.Properties;
using System;
using System.Windows.Forms;

namespace AwesomePokerGameSln {
  public partial class FrmTitle : Form {
    public FrmTitle() {
      InitializeComponent();
    }

    private void btnQuit_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    private void btnViewRuleBook_Click(object sender, EventArgs e) {
      if (btnViewRuleBook.Text.StartsWith("View", true, null)) {
        picRulebook.Visible = true;
        btnViewRuleBook.Text = "Close Rule Book";
      }
      else {
        picRulebook.Visible = false;
        btnViewRuleBook.Text = "View Rule Book";
      }
    }


    private void btnNewGame_Click(object sender, EventArgs e) {
      FrmPlaygame frmPlaygame = new FrmPlaygame();
      frmPlaygame.Show();
      Hide();
    }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (btnColor.Text.EndsWith("On", true, null))
            {
                FrmTitle2.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = true;
                btnColor.Text = "Colorblind Off";
            }
            else
            {
                FrmTitle2.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = false;
                btnColor.Text = "Colorblind On";


            }
        }
  }
}
