using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI_Layer.Utilities
{
    internal static class Helper
    {
        internal static void ButtonSituation(Control.ControlCollection controlCollection, bool IdIsNotNull, bool NameIsNotNull)
        {
            Button buttonAdd = null, buttonDelete = null, buttonUpdate = null;
            foreach (Control control in controlCollection)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    if (button.Name is "btnAdd") buttonAdd = button;
                    if (button.Name is "btnDelete") buttonDelete = button;
                    if (button.Name is "btnUpdate") buttonUpdate = button;

                    if (buttonAdd is not null && buttonDelete is not null && buttonUpdate is not null) SituationChange(buttonAdd, buttonDelete, buttonUpdate, IdIsNotNull, NameIsNotNull);
                }
            }
        }
        static void SituationChange(Button buttonAdd, Button buttonDelete, Button buttonUpdate, bool IdIsNotNull, bool NameIsNotNull)
        {
            if (IdIsNotNull && NameIsNotNull)
            {
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = true;
                buttonUpdate.Enabled = true;
            }
            else if (!IdIsNotNull && NameIsNotNull)
            {
                buttonAdd.Enabled = true;
                buttonDelete.Enabled = false;
                buttonUpdate.Enabled = false;
            }
            else if (IdIsNotNull && !NameIsNotNull)
            {
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = false;
                buttonUpdate.Enabled = false;
            }
            else
            {
                buttonAdd.Enabled = false;
                buttonDelete.Enabled = false;
                buttonUpdate.Enabled = false;
            }
        }

        internal static void WriteSelectClear(Control.ControlCollection controlCollection)
        {
            foreach (Control control in controlCollection)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is DataGridView)
                {
                    ((DataGridView)control).ClearSelection();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = default;
                }
            }
        }
    }
}

