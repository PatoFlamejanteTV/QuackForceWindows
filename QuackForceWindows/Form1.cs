using System;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace QuackForceWindows
{
    public partial class Form1 : Form
    {
        // Importa funções necessárias da API do Windows
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool EnumWindows(EnumWindowsProc lpEnumFunc, IntPtr lParam);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowText(IntPtr hWnd, StringBuilder lpString, int nMaxCount);

        [DllImport("user32.dll", SetLastError = true)]
        static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);

        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        private delegate bool EnumWindowsProc(IntPtr hWnd, IntPtr lParam);

        // Adicione este dicionário no início da classe Form1 (antes do construtor)
        private static readonly System.Collections.Generic.Dictionary<string, uint> WindowsMessages = new System.Collections.Generic.Dictionary<string, uint>(StringComparer.OrdinalIgnoreCase)
        {
            { "WM_NULL", 0x0000 },
            { "WM_CREATE", 0x0001 },
            { "WM_DESTROY", 0x0002 },
            { "WM_MOVE", 0x0003 },
            { "WM_SIZE", 0x0005 },
            { "WM_ACTIVATE", 0x0006 },
            { "WM_SETFOCUS", 0x0007 },
            { "WM_KILLFOCUS", 0x0008 },
            { "WM_ENABLE", 0x000A },
            { "WM_SETREDRAW", 0x000B },
            { "WM_SETTEXT", 0x000C },
            { "WM_GETTEXT", 0x000D },
            { "WM_GETTEXTLENGTH", 0x000E },
            { "WM_PAINT", 0x000F },
            { "WM_CLOSE", 0x0010 },
            { "WM_QUIT", 0x0012 },
            { "WM_SHOWWINDOW", 0x0018 },
            { "WM_SETCURSOR", 0x0020 },
            { "WM_KEYDOWN", 0x0100 },
            { "WM_KEYUP", 0x0101 },
            { "WM_CHAR", 0x0102 },
            { "WM_COMMAND", 0x0111 },
            { "WM_SYSCOMMAND", 0x0112 },
            // Adicione mais conforme necessário
        };

        public Form1()
        {
            InitializeComponent();
            LoadWindowNames();
        }

        private void LoadWindowNames()
        {
            listBox1.Items.Clear();
            EnumWindows(delegate (IntPtr hWnd, IntPtr lParam)
            {
                int length = GetWindowTextLength(hWnd);
                if (length == 0)
                    return true;

                StringBuilder builder = new StringBuilder(length + 1);
                GetWindowText(hWnd, builder, builder.Capacity);

                string windowTitle = builder.ToString();
                if (windowTitle != null && windowTitle.Trim().Length > 0)
                {
                    listBox1.Items.Add(windowTitle);
                }
                return true;
            }, IntPtr.Zero);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string processName = WindowNameChooser.Text.Trim();
            string hexMsg = WindowCustomHex.Text.Trim();
            string wParamText = textBoxWParam.Text.Trim();
            string lParamText = textBoxLParam.Text.Trim();

            if (string.IsNullOrEmpty(processName) || string.IsNullOrEmpty(hexMsg))
            {
                statusLabel.Text = "Preencha todos os campos.";
                return;
            }

            // Tenta converter a mensagem hex ou WM_ em uint
            uint msg;
            if (hexMsg.StartsWith("WM_", StringComparison.OrdinalIgnoreCase))
            {
                if (!WindowsMessages.TryGetValue(hexMsg.ToUpper(), out msg))
                {
                    statusLabel.Text = "Mensagem WM_ desconhecida.";
                    return;
                }
            }
            else if (!uint.TryParse(hexMsg, System.Globalization.NumberStyles.HexNumber, null, out msg))
            {
                statusLabel.Text = "Hex inválido.";
                return;
            }

            // Converte wParam e lParam (aceita decimal ou hex com 0x)
            IntPtr wParam = IntPtr.Zero;
            IntPtr lParam = IntPtr.Zero;
            try
            {
                wParam = (IntPtr)Convert.ToInt32(
                    wParamText.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ?
                    wParamText.Substring(2) : wParamText, wParamText.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? 16 : 10);
            }
            catch { statusLabel.Text = "wParam inválido."; return; }
            try
            {
                lParam = (IntPtr)Convert.ToInt32(
                    lParamText.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ?
                    lParamText.Substring(2) : lParamText, lParamText.StartsWith("0x", StringComparison.OrdinalIgnoreCase) ? 16 : 10);
            }
            catch { statusLabel.Text = "lParam inválido."; return; }

            // Procura o processo pelo nome
            Process[] procs = Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(processName));
            if (procs.Length == 0)
            {
                statusLabel.Text = "Janela não encontrada.";
                return;
            }

            IntPtr targetHwnd = IntPtr.Zero;
            foreach (Process proc in procs)
            {
                targetHwnd = proc.MainWindowHandle;
                if (targetHwnd != IntPtr.Zero)
                    break;
            }

            if (targetHwnd == IntPtr.Zero)
            {
                statusLabel.Text = "Handle da janela não encontrado.";
                return;
            }

            // Envia a mensagem
            SendMessage(targetHwnd, msg, wParam, lParam);
            statusLabel.Text = $"Mensagem 0x{msg:X} enviada!";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Small guide on thing to do :Dagora");
        }
    }
}