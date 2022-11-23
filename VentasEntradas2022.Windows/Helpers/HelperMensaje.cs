using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VentasEntradas2022.Windows.Helpers
{
    public class HelperMensaje
    {
        public static void Mensaje(HelperTipoMensaje tipo, string mensaje, string titulo)
        {
            switch (tipo)
            {
                case HelperTipoMensaje.OK:
                    MessageBox.Show($"{mensaje}", $"{titulo}",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                case HelperTipoMensaje.Error:
                    MessageBox.Show($"{mensaje}", $"{titulo}",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    break;
                case HelperTipoMensaje.Warning:
                    MessageBox.Show($"{mensaje}", $"{titulo}",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(tipo), tipo, null);
            }

        }

        public static DialogResult Mensaje(string mensaje, string titulo)
        {
            return MessageBox.Show($"{mensaje}", $"{titulo}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
        }
    }
}
