using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimerUI.Partials;

namespace TimerUI
{
    public partial class EditSpellWindow : Form
    {
        private readonly SpellPartial parent;

        public EditSpellWindow(SpellPartial parent)
        {
            InitializeComponent();

            this.parent = parent;
        }

        private void EditSpellWindow_Load(object sender, EventArgs e)
        {
            spellNameTextBox.Text = parent.SpellName;
            cooldownNumericUpDown.Value = parent.Cooldown;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (spellNameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Spell name can't be empty");
                return;
            }

            parent.SpellName = spellNameTextBox.Text;
            parent.Cooldown = (int)cooldownNumericUpDown.Value;
            this.Dispose();
        }
    }
}
