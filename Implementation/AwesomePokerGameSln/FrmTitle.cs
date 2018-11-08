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

    private void btnNetwork_Click(object sender, EventArgs e)
    {
        PGNetwork cursock = new PGNetwork();
        if (btnNetwork.Text == "Offline") {
            btnNetwork.Text = "Online";
            PGNetwork.Connect(cursock);
        }
        else
        {
            PGNetwork.Disconnect(cursock);
            btnNetwork.Text = "Offline";
        }
    }

        private void btnColor_Click(object sender, EventArgs e)
        {
            if (btnColor.Text.EndsWith("On", true, null))
            {
                FrmTitle2.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                btnQuit.BackColor = System.Drawing.Color.WhiteSmoke;
                btnViewRuleBook.BackColor = System.Drawing.Color.WhiteSmoke;
                btnNewGame.BackColor = System.Drawing.Color.WhiteSmoke;
                btnColor.Text = "Colorblind Off";
            }
            else
            {
                FrmTitle2.Visible = false;
                label1.Visible = true;
                label2.Visible = true;
                btnQuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))); ;
                btnViewRuleBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
                btnNewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
                btnColor.Text = "Colorblind On";


            }
        }
    } 
}
