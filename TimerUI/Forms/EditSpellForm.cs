using System;
using System.Windows.Forms;
using TimerLibrary.Models;
using TimerUI.Forms.Partials;

namespace TimerUI.Forms
{
    public partial class EditSpellForm : Form
    {
        private readonly SpellUserControl parentControl;

        public EditSpellForm(SpellUserControl parentControl)
        {
            InitializeComponent();

            this.parentControl = parentControl;
        }

        private void EditSpellWindow_Load(object sender, EventArgs e)
        {
            spellNameTextBox.Text = parentControl.SummonerSpell.Name;
            cooldownNumericUpDown.Value = parentControl.SummonerSpell.Cooldown;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (spellNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Spell name can't be empty");
                return;
            }

            parentControl.SummonerSpell.Name = spellNameTextBox.Text;
            parentControl.SummonerSpell.Cooldown = (int)cooldownNumericUpDown.Value;

            (parentControl.ParentForm as MainForm).MatchValueChanged = true;
            parentControl.UpdateData();

            this.Dispose();
        }
    }
}
